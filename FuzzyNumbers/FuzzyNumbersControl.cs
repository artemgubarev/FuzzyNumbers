using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace FuzzyNumbers
{
    public partial class FuzzyNumbersControl : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable _Anumber;
        private DataTable _Bnumber;
        private DataTable _Cnumber;
        private readonly List<string> _charts = new List<string>();
        public FuzzyNumbersControl()
        {
            InitializeComponent();
            FillDataTables();
        }

        private void FillDataTables()
        {
            _Anumber = new DataTable();
            _Bnumber = new DataTable();
            _Cnumber = new DataTable();

            string[] colNames = { "alpha lvl", "нижняя", "верхняя" };

            for (int i = 0; i < colNames.Length; i++)
            {
                _Anumber.Columns.Add(colNames[i]);
                _Bnumber.Columns.Add(colNames[i]);
                _Cnumber.Columns.Add(colNames[i]);
            }

            GridViewRefresh(AgridControl, AgridView, _Anumber);
            GridViewRefresh(BgridControl, BgridView, _Bnumber);
            GridViewRefresh(CgridControl, CgridView, _Cnumber);
                

            // тестовые данные из методички
            _Anumber.Rows.Add(new object[] { 0, 1, 9 });
            _Anumber.Rows.Add(new object[] { 0.5, 2, 8 });
            _Anumber.Rows.Add(new object[] { 1, 3, 4 });

            _Bnumber.Rows.Add(new object[] { 0, 1, 9 });
            _Bnumber.Rows.Add(new object[] { 0.5, 3, 6 });
            _Bnumber.Rows.Add(new object[] { 1, 4, 5 });
            _Bnumber.Rows.Add(new object[] { 0.2, 2, 7 });
        }

        private void GridViewRefresh(GridControl gridControl, GridView gridView, DataTable dataTable)
        {
            gridControl.BeginUpdate();
            gridView.Columns.Clear();
            gridControl.DataSource = null;
            GC.Collect();
            gridControl.DataSource = dataTable;
            gridControl.EndUpdate();
            gridView.LayoutChanged();
        }

        private DataTable DefineDataSource(string dataSourceName)
        {
            DataTable dataSource = null;
            if (dataSourceName == "A")
            {
                dataSource = _Anumber;
            }
            if (dataSourceName == "B")
            {
                dataSource = _Bnumber;
            }
            if (dataSourceName == "C")
            {
                dataSource = _Cnumber;
            }

            return dataSource;
        }

        private void gridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            string dataSourceName  = ((GridView)sender).Tag.ToString();
            var dataSource = DefineDataSource(dataSourceName);
            int lastRow = dataSource.Rows.Count - 1; 
            if (!double.TryParse(dataSource.Rows[lastRow][0].ToString(), 
                    NumberStyles.Any, CultureInfo.InvariantCulture, out double number1) ||
                number1 < 0 || number1 > 1)
            {
                dataSource.Rows.RemoveAt(lastRow);
            }
            bool secondRow = double.TryParse(dataSource.Rows[lastRow][1].ToString(),
                NumberStyles.Any, CultureInfo.InvariantCulture, out double number2);
            bool thirdRow = double.TryParse(dataSource.Rows[lastRow][2].ToString(),
                NumberStyles.Any, CultureInfo.InvariantCulture, out double number3);

            if (!secondRow || !thirdRow)
            {
                dataSource.Rows.RemoveAt(lastRow);
            }
        }

        private void buildChartButton_Click(object sender, EventArgs e)
        {
            string seriesName = ((SimpleButton)sender).Tag.ToString();
            var series = new Series(seriesName, ViewType.Line);
            var dataSource = DefineDataSource(seriesName);

            if (dataSource.Rows.Count == 0 ||
                _charts.Contains(seriesName))
            {
                return;
            }

            var points = new List<(double, double)>();
            for (int i = 0; i < dataSource.Rows.Count; i++)
            {
                double y = ParseDouble(dataSource.Rows[i][0].ToString());
                double x1 = ParseDouble(dataSource.Rows[i][1].ToString());
                double x2 = ParseDouble(dataSource.Rows[i][2].ToString());
                points.Add((x1, y));
                points.Add((x2, y));
            }
            points = points.OrderBy(item => item.Item1).ToList();

            foreach (var point in points)
            {
                series.Points.Add(new SeriesPoint(point.Item1, point.Item2));
            }
            _charts.Add(seriesName);
            chartControl.Series.Add(series);
        }

        private void removeChartButton_Click(object sender, EventArgs e)
        {
            string chartName = chartNameTextEdit.Text;
            if (_charts.Contains(chartName))
            {
                _charts.Remove(chartName);
                var series = chartControl.Series[chartName];
                chartControl.Series.Remove(series);
                chartNameTextEdit.Text = string.Empty;
            }
        }

        private void clearChartButton_Click(object sender, EventArgs e)
        {
            chartControl.Series.Clear();
            _charts.Clear();
        }

        private void arithmeticOperationButton_Click(object sender, EventArgs e)
        {
            string operation = ((SimpleButton)sender).Text;
            var A = GetMatrix(_Anumber);
            var B = GetMatrix(_Bnumber);

            var C = FuzzyNumbersCalculator.ExecuteOperation(A, B, operation).ToArray();

            _Cnumber.Clear();
            foreach (var row in C)
            {
                object[] _row = new object[] { row[0], row[1], row[2] };
                _Cnumber.Rows.Add(_row);
            }
            GridViewRefresh(CgridControl, CgridView, _Cnumber);
        }

        private IEnumerable<double[]> GetMatrix(DataTable dataTable)
        {
            var matrix = new List<double[]>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                double[] values = new double[3];
                for (int j = 0; j < 3; j++)
                {
                    values[j] = ParseDouble(dataTable.Rows[i][j].ToString());
                }
                matrix.Add(values);
            }

            return matrix;
        }

        private double ParseDouble(string number)
        {
            number = number.Replace('.', ',');
            return double.Parse(number);
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            var A = GetMatrix(_Anumber);
            var B = GetMatrix(_Bnumber);

            var compareValue = FuzzyNumbersCalculator.Compare(A, B);

            var buttons = new Dictionary<string, SimpleButton>()
            {
                { ">", moreButton },
                { ">=", moreOrEqualButton },
                { "<", lessButton },
                { "<=", lessOrEqualButton },
                { "=", equalButton },
                { "!=", noEqualButton},
            };

            foreach (var button in buttons)
            {
                button.Value.Appearance.BackColor = Color.Red;
                if (compareValue.Contains(button.Key))
                {
                    button.Value.Appearance.BackColor = Color.Green;
                }
            }
        }
    }
}
