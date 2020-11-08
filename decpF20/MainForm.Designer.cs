namespace decpF20
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabSwitch = new System.Windows.Forms.TabControl();
            this.solutionsPage = new System.Windows.Forms.TabPage();
            this.globalErrorsPlotView = new OxyPlot.WindowsForms.PlotView();
            this.approximationsPlotView = new OxyPlot.WindowsForms.PlotView();
            this.errorsPage = new System.Windows.Forms.TabPage();
            this.maxGlobalErrorsPlotView = new OxyPlot.WindowsForms.PlotView();
            this.labelValueN0 = new System.Windows.Forms.Label();
            this.labelValueN = new System.Windows.Forms.Label();
            this.labelValueY0 = new System.Windows.Forms.Label();
            this.labelValueX = new System.Windows.Forms.Label();
            this.labelValueX0 = new System.Windows.Forms.Label();
            this.numControlN0 = new System.Windows.Forms.NumericUpDown();
            this.numControlN = new System.Windows.Forms.NumericUpDown();
            this.numControlX = new System.Windows.Forms.NumericUpDown();
            this.numControlY0 = new System.Windows.Forms.NumericUpDown();
            this.numControlX0 = new System.Windows.Forms.NumericUpDown();
            this.equationPanel = new System.Windows.Forms.Panel();
            this.numControlX0_2 = new System.Windows.Forms.NumericUpDown();
            this.labelValueX0_2 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.labelUsageTip = new System.Windows.Forms.Label();
            this.labelChangedValues = new System.Windows.Forms.Label();
            this.tabSwitch.SuspendLayout();
            this.solutionsPage.SuspendLayout();
            this.errorsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numControlN0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlX0)).BeginInit();
            this.equationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numControlX0_2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSwitch
            // 
            this.tabSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSwitch.Controls.Add(this.solutionsPage);
            this.tabSwitch.Controls.Add(this.errorsPage);
            this.tabSwitch.Location = new System.Drawing.Point(0, 0);
            this.tabSwitch.Name = "tabSwitch";
            this.tabSwitch.SelectedIndex = 0;
            this.tabSwitch.Size = new System.Drawing.Size(589, 552);
            this.tabSwitch.TabIndex = 0;
            this.tabSwitch.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabSwitch_Selected);
            // 
            // solutionsPage
            // 
            this.solutionsPage.Controls.Add(this.globalErrorsPlotView);
            this.solutionsPage.Controls.Add(this.approximationsPlotView);
            this.solutionsPage.Location = new System.Drawing.Point(4, 22);
            this.solutionsPage.Name = "solutionsPage";
            this.solutionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.solutionsPage.Size = new System.Drawing.Size(581, 526);
            this.solutionsPage.TabIndex = 0;
            this.solutionsPage.Text = "Numerical solutions";
            this.solutionsPage.UseVisualStyleBackColor = true;
            this.solutionsPage.SizeChanged += new System.EventHandler(this.solutionsPage_SizeChanged);
            // 
            // globalErrorsPlotView
            // 
            this.globalErrorsPlotView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.globalErrorsPlotView.Location = new System.Drawing.Point(6, 264);
            this.globalErrorsPlotView.Name = "globalErrorsPlotView";
            this.globalErrorsPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.globalErrorsPlotView.Size = new System.Drawing.Size(570, 256);
            this.globalErrorsPlotView.TabIndex = 1;
            this.globalErrorsPlotView.Text = "Local errors";
            this.globalErrorsPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.globalErrorsPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.globalErrorsPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.globalErrorsPlotView.MouseEnter += new System.EventHandler(this.showUsageTip);
            this.globalErrorsPlotView.MouseLeave += new System.EventHandler(this.hideUsageTip);
            // 
            // approximationsPlotView
            // 
            this.approximationsPlotView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approximationsPlotView.Location = new System.Drawing.Point(6, 6);
            this.approximationsPlotView.Name = "approximationsPlotView";
            this.approximationsPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.approximationsPlotView.Size = new System.Drawing.Size(570, 256);
            this.approximationsPlotView.TabIndex = 1;
            this.approximationsPlotView.Text = "y(x)";
            this.approximationsPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.approximationsPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.approximationsPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.approximationsPlotView.MouseEnter += new System.EventHandler(this.showUsageTip);
            this.approximationsPlotView.MouseLeave += new System.EventHandler(this.hideUsageTip);
            // 
            // errorsPage
            // 
            this.errorsPage.Controls.Add(this.maxGlobalErrorsPlotView);
            this.errorsPage.Location = new System.Drawing.Point(4, 22);
            this.errorsPage.Name = "errorsPage";
            this.errorsPage.Padding = new System.Windows.Forms.Padding(3);
            this.errorsPage.Size = new System.Drawing.Size(581, 526);
            this.errorsPage.TabIndex = 1;
            this.errorsPage.Text = "Total approximation errors";
            this.errorsPage.UseVisualStyleBackColor = true;
            // 
            // maxGlobalErrorsPlotView
            // 
            this.maxGlobalErrorsPlotView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxGlobalErrorsPlotView.Location = new System.Drawing.Point(8, 6);
            this.maxGlobalErrorsPlotView.Name = "maxGlobalErrorsPlotView";
            this.maxGlobalErrorsPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.maxGlobalErrorsPlotView.Size = new System.Drawing.Size(570, 514);
            this.maxGlobalErrorsPlotView.TabIndex = 2;
            this.maxGlobalErrorsPlotView.Text = "y(x)";
            this.maxGlobalErrorsPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.maxGlobalErrorsPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.maxGlobalErrorsPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.maxGlobalErrorsPlotView.MouseEnter += new System.EventHandler(this.showUsageTip);
            this.maxGlobalErrorsPlotView.MouseLeave += new System.EventHandler(this.hideUsageTip);
            // 
            // labelValueN0
            // 
            this.labelValueN0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValueN0.AutoSize = true;
            this.labelValueN0.Location = new System.Drawing.Point(590, 152);
            this.labelValueN0.Name = "labelValueN0";
            this.labelValueN0.Size = new System.Drawing.Size(22, 13);
            this.labelValueN0.TabIndex = 3;
            this.labelValueN0.Text = "n0:";
            // 
            // labelValueN
            // 
            this.labelValueN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValueN.AutoSize = true;
            this.labelValueN.Location = new System.Drawing.Point(651, 152);
            this.labelValueN.Name = "labelValueN";
            this.labelValueN.Size = new System.Drawing.Size(52, 13);
            this.labelValueN.TabIndex = 3;
            this.labelValueN.Text = "N (steps):";
            // 
            // labelValueY0
            // 
            this.labelValueY0.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelValueY0.AutoSize = true;
            this.labelValueY0.Location = new System.Drawing.Point(151, 33);
            this.labelValueY0.Name = "labelValueY0";
            this.labelValueY0.Size = new System.Drawing.Size(21, 13);
            this.labelValueY0.TabIndex = 3;
            this.labelValueY0.Text = "y0:";
            // 
            // labelValueX
            // 
            this.labelValueX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelValueX.AutoSize = true;
            this.labelValueX.Location = new System.Drawing.Point(150, 77);
            this.labelValueX.Name = "labelValueX";
            this.labelValueX.Size = new System.Drawing.Size(17, 13);
            this.labelValueX.TabIndex = 3;
            this.labelValueX.Text = "X:";
            // 
            // labelValueX0
            // 
            this.labelValueX0.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelValueX0.AutoSize = true;
            this.labelValueX0.Location = new System.Drawing.Point(46, 35);
            this.labelValueX0.Name = "labelValueX0";
            this.labelValueX0.Size = new System.Drawing.Size(21, 13);
            this.labelValueX0.TabIndex = 3;
            this.labelValueX0.Text = "x0:";
            // 
            // numControlN0
            // 
            this.numControlN0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numControlN0.Enabled = false;
            this.numControlN0.Location = new System.Drawing.Point(591, 168);
            this.numControlN0.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numControlN0.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numControlN0.Name = "numControlN0";
            this.numControlN0.Size = new System.Drawing.Size(55, 20);
            this.numControlN0.TabIndex = 2;
            this.numControlN0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numControlN0.ValueChanged += new System.EventHandler(this.numControlN0_ValueChanged);
            // 
            // numControlN
            // 
            this.numControlN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numControlN.Location = new System.Drawing.Point(652, 168);
            this.numControlN.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numControlN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numControlN.Name = "numControlN";
            this.numControlN.Size = new System.Drawing.Size(55, 20);
            this.numControlN.TabIndex = 2;
            this.numControlN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numControlN.ValueChanged += new System.EventHandler(this.numControlN_ValueChanged);
            // 
            // numControlX
            // 
            this.numControlX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numControlX.DecimalPlaces = 2;
            this.numControlX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numControlX.Location = new System.Drawing.Point(151, 93);
            this.numControlX.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numControlX.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numControlX.Name = "numControlX";
            this.numControlX.Size = new System.Drawing.Size(55, 20);
            this.numControlX.TabIndex = 2;
            this.numControlX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numControlX.ValueChanged += new System.EventHandler(this.numControlX_ValueChanged);
            // 
            // numControlY0
            // 
            this.numControlY0.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numControlY0.DecimalPlaces = 2;
            this.numControlY0.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numControlY0.Location = new System.Drawing.Point(151, 49);
            this.numControlY0.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numControlY0.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numControlY0.Name = "numControlY0";
            this.numControlY0.Size = new System.Drawing.Size(55, 20);
            this.numControlY0.TabIndex = 2;
            this.numControlY0.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numControlY0.ValueChanged += new System.EventHandler(this.showModifiedValuesTip);
            // 
            // numControlX0
            // 
            this.numControlX0.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numControlX0.DecimalPlaces = 2;
            this.numControlX0.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numControlX0.Location = new System.Drawing.Point(46, 51);
            this.numControlX0.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numControlX0.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numControlX0.Name = "numControlX0";
            this.numControlX0.Size = new System.Drawing.Size(55, 20);
            this.numControlX0.TabIndex = 2;
            this.numControlX0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numControlX0.ValueChanged += new System.EventHandler(this.numControlX0_ValueChanged);
            // 
            // equationPanel
            // 
            this.equationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.equationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("equationPanel.BackgroundImage")));
            this.equationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.equationPanel.Controls.Add(this.numControlX0_2);
            this.equationPanel.Controls.Add(this.numControlX0);
            this.equationPanel.Controls.Add(this.labelValueX0_2);
            this.equationPanel.Controls.Add(this.labelValueX0);
            this.equationPanel.Controls.Add(this.numControlY0);
            this.equationPanel.Controls.Add(this.labelValueX);
            this.equationPanel.Controls.Add(this.labelValueY0);
            this.equationPanel.Controls.Add(this.numControlX);
            this.equationPanel.Location = new System.Drawing.Point(591, 28);
            this.equationPanel.Name = "equationPanel";
            this.equationPanel.Size = new System.Drawing.Size(216, 118);
            this.equationPanel.TabIndex = 4;
            // 
            // numControlX0_2
            // 
            this.numControlX0_2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numControlX0_2.DecimalPlaces = 2;
            this.numControlX0_2.Enabled = false;
            this.numControlX0_2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numControlX0_2.Location = new System.Drawing.Point(84, 93);
            this.numControlX0_2.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numControlX0_2.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numControlX0_2.Name = "numControlX0_2";
            this.numControlX0_2.Size = new System.Drawing.Size(55, 20);
            this.numControlX0_2.TabIndex = 2;
            this.numControlX0_2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelValueX0_2
            // 
            this.labelValueX0_2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelValueX0_2.AutoSize = true;
            this.labelValueX0_2.Location = new System.Drawing.Point(84, 77);
            this.labelValueX0_2.Name = "labelValueX0_2";
            this.labelValueX0_2.Size = new System.Drawing.Size(21, 13);
            this.labelValueX0_2.TabIndex = 3;
            this.labelValueX0_2.Text = "x0:";
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Location = new System.Drawing.Point(722, 166);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Recalculate";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // labelUsageTip
            // 
            this.labelUsageTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsageTip.AutoSize = true;
            this.labelUsageTip.Location = new System.Drawing.Point(621, 477);
            this.labelUsageTip.Name = "labelUsageTip";
            this.labelUsageTip.Size = new System.Drawing.Size(159, 39);
            this.labelUsageTip.TabIndex = 6;
            this.labelUsageTip.Text = "Use Right Mouse Button to pan,\r\nLeft Mouse Button to pick the\r\npoints and scroll " +
    "to zoom in/out.";
            this.labelUsageTip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelUsageTip.Visible = false;
            // 
            // labelChangedValues
            // 
            this.labelChangedValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChangedValues.AutoSize = true;
            this.labelChangedValues.Location = new System.Drawing.Point(627, 196);
            this.labelChangedValues.Name = "labelChangedValues";
            this.labelChangedValues.Size = new System.Drawing.Size(150, 26);
            this.labelChangedValues.TabIndex = 6;
            this.labelChangedValues.Text = "You have modified the values,\r\nhit Enter to update the plots.";
            this.labelChangedValues.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelChangedValues.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.updateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 552);
            this.Controls.Add(this.labelChangedValues);
            this.Controls.Add(this.labelUsageTip);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.equationPanel);
            this.Controls.Add(this.labelValueN0);
            this.Controls.Add(this.tabSwitch);
            this.Controls.Add(this.labelValueN);
            this.Controls.Add(this.numControlN);
            this.Controls.Add(this.numControlN0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DE Computation Practicum 2020";
            this.tabSwitch.ResumeLayout(false);
            this.solutionsPage.ResumeLayout(false);
            this.errorsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numControlN0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlX0)).EndInit();
            this.equationPanel.ResumeLayout(false);
            this.equationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numControlX0_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabSwitch;
        private System.Windows.Forms.TabPage solutionsPage;
        private System.Windows.Forms.TabPage errorsPage;
        private OxyPlot.WindowsForms.PlotView globalErrorsPlotView;
        private OxyPlot.WindowsForms.PlotView approximationsPlotView;
        private OxyPlot.WindowsForms.PlotView maxGlobalErrorsPlotView;
        private System.Windows.Forms.Label labelValueN;
        private System.Windows.Forms.Label labelValueY0;
        private System.Windows.Forms.Label labelValueX;
        private System.Windows.Forms.Label labelValueX0;
        private System.Windows.Forms.NumericUpDown numControlN;
        private System.Windows.Forms.NumericUpDown numControlX;
        private System.Windows.Forms.NumericUpDown numControlY0;
        private System.Windows.Forms.NumericUpDown numControlX0;
        private System.Windows.Forms.Label labelValueN0;
        private System.Windows.Forms.NumericUpDown numControlN0;
        private System.Windows.Forms.Panel equationPanel;
        private System.Windows.Forms.NumericUpDown numControlX0_2;
        private System.Windows.Forms.Label labelValueX0_2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label labelUsageTip;
        private System.Windows.Forms.Label labelChangedValues;
    }
}

