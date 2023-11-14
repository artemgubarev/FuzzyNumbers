namespace FuzzyNumbers
{
    partial class FuzzyNumbersControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgridControl = new DevExpress.XtraGrid.GridControl();
            this.AgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BgridControl = new DevExpress.XtraGrid.GridControl();
            this.BgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CgridControl = new DevExpress.XtraGrid.GridControl();
            this.CgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.plusButton = new DevExpress.XtraEditors.SimpleButton();
            this.minusButton = new DevExpress.XtraEditors.SimpleButton();
            this.multiplyButton = new DevExpress.XtraEditors.SimpleButton();
            this.divButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.buildBButton = new DevExpress.XtraEditors.SimpleButton();
            this.buildCButton = new DevExpress.XtraEditors.SimpleButton();
            this.compareButton = new DevExpress.XtraEditors.SimpleButton();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.chartNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.clearChartButton = new DevExpress.XtraEditors.SimpleButton();
            this.removeChartButton = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.buildAButton = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.compareLabel = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgridControl
            // 
            this.AgridControl.Location = new System.Drawing.Point(3, 22);
            this.AgridControl.MainView = this.AgridView;
            this.AgridControl.Name = "AgridControl";
            this.AgridControl.Size = new System.Drawing.Size(204, 170);
            this.AgridControl.TabIndex = 0;
            this.AgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.AgridView});
            // 
            // AgridView
            // 
            this.AgridView.GridControl = this.AgridControl;
            this.AgridView.Name = "AgridView";
            this.AgridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.AgridView.OptionsView.ShowGroupPanel = false;
            this.AgridView.OptionsView.ShowIndicator = false;
            this.AgridView.Tag = "A";
            this.AgridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView_RowUpdated);
            // 
            // BgridControl
            // 
            this.BgridControl.Location = new System.Drawing.Point(3, 223);
            this.BgridControl.MainView = this.BgridView;
            this.BgridControl.Name = "BgridControl";
            this.BgridControl.Size = new System.Drawing.Size(204, 150);
            this.BgridControl.TabIndex = 1;
            this.BgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BgridView});
            // 
            // BgridView
            // 
            this.BgridView.GridControl = this.BgridControl;
            this.BgridView.Name = "BgridView";
            this.BgridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.BgridView.OptionsView.ShowGroupPanel = false;
            this.BgridView.OptionsView.ShowIndicator = false;
            this.BgridView.Tag = "B";
            this.BgridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView_RowUpdated);
            // 
            // CgridControl
            // 
            this.CgridControl.Location = new System.Drawing.Point(3, 444);
            this.CgridControl.MainView = this.CgridView;
            this.CgridControl.Name = "CgridControl";
            this.CgridControl.Size = new System.Drawing.Size(204, 153);
            this.CgridControl.TabIndex = 2;
            this.CgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CgridView});
            // 
            // CgridView
            // 
            this.CgridView.GridControl = this.CgridControl;
            this.CgridView.Name = "CgridView";
            this.CgridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.CgridView.OptionsView.ShowGroupPanel = false;
            this.CgridView.OptionsView.ShowIndicator = false;
            this.CgridView.Tag = "C";
            this.CgridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView_RowUpdated);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Множество А :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 201);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Множество B :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 424);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Множество C :";
            // 
            // plusButton
            // 
            this.plusButton.AllowFocus = false;
            this.tablePanel3.SetColumn(this.plusButton, 0);
            this.plusButton.Location = new System.Drawing.Point(3, 3);
            this.plusButton.Name = "plusButton";
            this.tablePanel3.SetRow(this.plusButton, 0);
            this.plusButton.Size = new System.Drawing.Size(45, 32);
            this.plusButton.TabIndex = 6;
            this.plusButton.Tag = "";
            this.plusButton.Text = "+";
            this.plusButton.Click += new System.EventHandler(this.arithmeticOperationButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.AllowFocus = false;
            this.tablePanel3.SetColumn(this.minusButton, 1);
            this.minusButton.Location = new System.Drawing.Point(54, 3);
            this.minusButton.Name = "minusButton";
            this.tablePanel3.SetRow(this.minusButton, 0);
            this.minusButton.Size = new System.Drawing.Size(45, 32);
            this.minusButton.TabIndex = 7;
            this.minusButton.Tag = "";
            this.minusButton.Text = "-";
            this.minusButton.Click += new System.EventHandler(this.arithmeticOperationButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.AllowFocus = false;
            this.tablePanel3.SetColumn(this.multiplyButton, 3);
            this.multiplyButton.Location = new System.Drawing.Point(156, 3);
            this.multiplyButton.Name = "multiplyButton";
            this.tablePanel3.SetRow(this.multiplyButton, 0);
            this.multiplyButton.Size = new System.Drawing.Size(45, 32);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Tag = "";
            this.multiplyButton.Text = "*";
            this.multiplyButton.Click += new System.EventHandler(this.arithmeticOperationButton_Click);
            // 
            // divButton
            // 
            this.divButton.AllowFocus = false;
            this.tablePanel3.SetColumn(this.divButton, 2);
            this.divButton.Location = new System.Drawing.Point(105, 3);
            this.divButton.Name = "divButton";
            this.tablePanel3.SetRow(this.divButton, 0);
            this.divButton.Size = new System.Drawing.Size(45, 32);
            this.divButton.TabIndex = 9;
            this.divButton.Tag = "";
            this.divButton.Text = "/";
            this.divButton.Click += new System.EventHandler(this.arithmeticOperationButton_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(213, 383);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 31);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Построить А";
            // 
            // buildBButton
            // 
            this.buildBButton.AllowFocus = false;
            this.tablePanel1.SetColumn(this.buildBButton, 0);
            this.buildBButton.Location = new System.Drawing.Point(3, 43);
            this.buildBButton.Name = "buildBButton";
            this.tablePanel1.SetRow(this.buildBButton, 1);
            this.buildBButton.Size = new System.Drawing.Size(90, 31);
            this.buildBButton.TabIndex = 11;
            this.buildBButton.Tag = "B";
            this.buildBButton.Text = "Построить B";
            this.buildBButton.Click += new System.EventHandler(this.buildChartButton_Click);
            // 
            // buildCButton
            // 
            this.buildCButton.AllowFocus = false;
            this.tablePanel1.SetColumn(this.buildCButton, 0);
            this.buildCButton.Location = new System.Drawing.Point(3, 81);
            this.buildCButton.Name = "buildCButton";
            this.tablePanel1.SetRow(this.buildCButton, 2);
            this.buildCButton.Size = new System.Drawing.Size(90, 32);
            this.buildCButton.TabIndex = 12;
            this.buildCButton.Tag = "C";
            this.buildCButton.Text = "Построить C";
            this.buildCButton.Click += new System.EventHandler(this.buildChartButton_Click);
            // 
            // compareButton
            // 
            this.compareButton.AllowFocus = false;
            this.tablePanel2.SetColumn(this.compareButton, 0);
            this.tablePanel2.SetColumnSpan(this.compareButton, 2);
            this.compareButton.Location = new System.Drawing.Point(3, 3);
            this.compareButton.Name = "compareButton";
            this.tablePanel2.SetRow(this.compareButton, 0);
            this.compareButton.Size = new System.Drawing.Size(90, 30);
            this.compareButton.TabIndex = 13;
            this.compareButton.Text = "Сравнить";
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // chartControl
            // 
            this.chartControl.Location = new System.Drawing.Point(315, 3);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.Size = new System.Drawing.Size(539, 435);
            this.chartControl.TabIndex = 21;
            // 
            // chartNameTextEdit
            // 
            this.tablePanel4.SetColumn(this.chartNameTextEdit, 1);
            this.tablePanel4.SetColumnSpan(this.chartNameTextEdit, 2);
            this.chartNameTextEdit.Location = new System.Drawing.Point(120, 9);
            this.chartNameTextEdit.Name = "chartNameTextEdit";
            this.chartNameTextEdit.Properties.AllowFocused = false;
            this.tablePanel4.SetRow(this.chartNameTextEdit, 0);
            this.chartNameTextEdit.Size = new System.Drawing.Size(416, 20);
            this.chartNameTextEdit.TabIndex = 25;
            // 
            // clearChartButton
            // 
            this.clearChartButton.AllowFocus = false;
            this.tablePanel4.SetColumn(this.clearChartButton, 2);
            this.clearChartButton.Location = new System.Drawing.Point(297, 42);
            this.clearChartButton.Name = "clearChartButton";
            this.tablePanel4.SetRow(this.clearChartButton, 1);
            this.clearChartButton.Size = new System.Drawing.Size(239, 33);
            this.clearChartButton.TabIndex = 13;
            this.clearChartButton.Text = "Очистить график";
            this.clearChartButton.Click += new System.EventHandler(this.clearChartButton_Click);
            // 
            // removeChartButton
            // 
            this.removeChartButton.AllowFocus = false;
            this.tablePanel4.SetColumn(this.removeChartButton, 1);
            this.removeChartButton.Location = new System.Drawing.Point(120, 42);
            this.removeChartButton.Name = "removeChartButton";
            this.tablePanel4.SetRow(this.removeChartButton, 1);
            this.removeChartButton.Size = new System.Drawing.Size(171, 33);
            this.removeChartButton.TabIndex = 26;
            this.removeChartButton.Text = "Удалить график по названию";
            this.removeChartButton.Click += new System.EventHandler(this.removeChartButton_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.77F)});
            this.tablePanel1.Controls.Add(this.buildAButton);
            this.tablePanel1.Controls.Add(this.buildCButton);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.buildBButton);
            this.tablePanel1.Location = new System.Drawing.Point(213, 462);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F)});
            this.tablePanel1.Size = new System.Drawing.Size(96, 116);
            this.tablePanel1.TabIndex = 0;
            // 
            // buildAButton
            // 
            this.buildAButton.AllowFocus = false;
            this.tablePanel1.SetColumn(this.buildAButton, 0);
            this.buildAButton.Location = new System.Drawing.Point(3, 3);
            this.buildAButton.Name = "buildAButton";
            this.tablePanel1.SetRow(this.buildAButton, 0);
            this.buildAButton.Size = new System.Drawing.Size(90, 33);
            this.buildAButton.TabIndex = 13;
            this.buildAButton.Tag = "A";
            this.buildAButton.Text = "Построить А";
            this.buildAButton.Click += new System.EventHandler(this.buildChartButton_Click);
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 83F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 83F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 83F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 83F)});
            this.tablePanel3.Controls.Add(this.multiplyButton);
            this.tablePanel3.Controls.Add(this.divButton);
            this.tablePanel3.Controls.Add(this.minusButton);
            this.tablePanel3.Controls.Add(this.plusButton);
            this.tablePanel3.Location = new System.Drawing.Point(3, 380);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(204, 38);
            this.tablePanel3.TabIndex = 28;
            // 
            // tablePanel4
            // 
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 23.84F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 36.16F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel4.Controls.Add(this.removeChartButton);
            this.tablePanel4.Controls.Add(this.chartNameTextEdit);
            this.tablePanel4.Controls.Add(this.clearChartButton);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel4.Location = new System.Drawing.Point(315, 444);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 39F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(539, 78);
            this.tablePanel4.TabIndex = 29;
            // 
            // tablePanel5
            // 
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.96F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 13.15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 69.89F)});
            this.tablePanel5.Controls.Add(this.labelControl1);
            this.tablePanel5.Controls.Add(this.chartControl);
            this.tablePanel5.Controls.Add(this.tablePanel4);
            this.tablePanel5.Controls.Add(this.labelControl2);
            this.tablePanel5.Controls.Add(this.tablePanel1);
            this.tablePanel5.Controls.Add(this.tablePanel3);
            this.tablePanel5.Controls.Add(this.tablePanel2);
            this.tablePanel5.Controls.Add(this.labelControl3);
            this.tablePanel5.Controls.Add(this.CgridControl);
            this.tablePanel5.Controls.Add(this.AgridControl);
            this.tablePanel5.Controls.Add(this.BgridControl);
            this.tablePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel5.Location = new System.Drawing.Point(0, 0);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 19F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 176F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 157F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 44F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel5.Size = new System.Drawing.Size(857, 600);
            this.tablePanel5.TabIndex = 30;
            // 
            // tablePanel2
            // 
            this.tablePanel5.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48F)});
            this.tablePanel2.Controls.Add(this.richTextBox);
            this.tablePanel2.Controls.Add(this.compareLabel);
            this.tablePanel2.Controls.Add(this.compareButton);
            this.tablePanel2.Location = new System.Drawing.Point(213, 35);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel5.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 36F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 44F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 36F)});
            this.tablePanel2.Size = new System.Drawing.Size(96, 144);
            this.tablePanel2.TabIndex = 27;
            // 
            // compareLabel
            // 
            this.tablePanel2.SetColumn(this.compareLabel, 0);
            this.tablePanel2.SetColumnSpan(this.compareLabel, 2);
            this.compareLabel.Location = new System.Drawing.Point(3, 43);
            this.compareLabel.Name = "compareLabel";
            this.tablePanel2.SetRow(this.compareLabel, 1);
            this.compareLabel.Size = new System.Drawing.Size(0, 13);
            this.compareLabel.TabIndex = 30;
            // 
            // richTextBox
            // 
            this.tablePanel2.SetColumn(this.richTextBox, 0);
            this.tablePanel2.SetColumnSpan(this.richTextBox, 2);
            this.richTextBox.Location = new System.Drawing.Point(3, 67);
            this.richTextBox.Name = "richTextBox";
            this.tablePanel2.SetRow(this.richTextBox, 2);
            this.tablePanel2.SetRowSpan(this.richTextBox, 2);
            this.richTextBox.Size = new System.Drawing.Size(90, 74);
            this.richTextBox.TabIndex = 31;
            this.richTextBox.Text = "";
            // 
            // FuzzyNumbersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel5);
            this.Name = "FuzzyNumbersControl";
            this.Size = new System.Drawing.Size(857, 600);
            ((System.ComponentModel.ISupportInitialize)(this.AgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            this.tablePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl AgridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView AgridView;
        private DevExpress.XtraGrid.GridControl BgridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView BgridView;
        private DevExpress.XtraGrid.GridControl CgridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CgridView;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton plusButton;
        private DevExpress.XtraEditors.SimpleButton minusButton;
        private DevExpress.XtraEditors.SimpleButton multiplyButton;
        private DevExpress.XtraEditors.SimpleButton divButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton buildBButton;
        private DevExpress.XtraEditors.SimpleButton buildCButton;
        private DevExpress.XtraEditors.SimpleButton compareButton;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraEditors.TextEdit chartNameTextEdit;
        private DevExpress.XtraEditors.SimpleButton removeChartButton;
        private DevExpress.XtraEditors.SimpleButton clearChartButton;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.SimpleButton buildAButton;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl compareLabel;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}
