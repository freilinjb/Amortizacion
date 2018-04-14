namespace Amortizacion
{
    partial class DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            Telerik.WinControls.UI.DonutSeries donutSeries1 = new Telerik.WinControls.UI.DonutSeries();
            Telerik.Charting.PieDataPoint pieDataPoint1 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint2 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint3 = new Telerik.Charting.PieDataPoint();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis2 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.ScatterAreaSeries scatterAreaSeries1 = new Telerik.WinControls.UI.ScatterAreaSeries();
            Telerik.Charting.ScatterDataPoint scatterDataPoint1 = new Telerik.Charting.ScatterDataPoint();
            Telerik.Charting.ScatterDataPoint scatterDataPoint2 = new Telerik.Charting.ScatterDataPoint();
            Telerik.Charting.ScatterDataPoint scatterDataPoint3 = new Telerik.Charting.ScatterDataPoint();
            Telerik.Charting.ScatterDataPoint scatterDataPoint4 = new Telerik.Charting.ScatterDataPoint();
            Telerik.Charting.ScatterDataPoint scatterDataPoint5 = new Telerik.Charting.ScatterDataPoint();
            Telerik.WinControls.UI.ScatterAreaSeries scatterAreaSeries2 = new Telerik.WinControls.UI.ScatterAreaSeries();
            Telerik.Charting.ScatterDataPoint scatterDataPoint6 = new Telerik.Charting.ScatterDataPoint();
            Telerik.Charting.ScatterDataPoint scatterDataPoint7 = new Telerik.Charting.ScatterDataPoint();
            Telerik.Charting.ScatterDataPoint scatterDataPoint8 = new Telerik.Charting.ScatterDataPoint();
            Telerik.Charting.ScatterDataPoint scatterDataPoint9 = new Telerik.Charting.ScatterDataPoint();
            Telerik.Charting.ScatterDataPoint scatterDataPoint10 = new Telerik.Charting.ScatterDataPoint();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radChartView2 = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radChartView1
            // 
            this.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            this.radChartView1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radChartView1, "radChartView1");
            this.radChartView1.Name = "radChartView1";
            pieDataPoint1.Label = 0.32780082987551867D;
            pieDataPoint1.LegendTitle = "Capita";
            pieDataPoint1.OffsetFromCenter = 0D;
            pieDataPoint1.RadiusAspectRatio = 1F;
            pieDataPoint1.Value = 79D;
            pieDataPoint2.Label = 0.33195020746887965D;
            pieDataPoint2.LegendTitle = "Intereses";
            pieDataPoint2.OffsetFromCenter = 0D;
            pieDataPoint2.RadiusAspectRatio = 1F;
            pieDataPoint2.Value = 80D;
            pieDataPoint3.Label = 0.34024896265560167D;
            pieDataPoint3.LegendTitle = "Prestado";
            pieDataPoint3.OffsetFromCenter = 0D;
            pieDataPoint3.RadiusAspectRatio = 1F;
            pieDataPoint3.Value = 82D;
            donutSeries1.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            pieDataPoint1,
            pieDataPoint2,
            pieDataPoint3});
            donutSeries1.ShowLabels = true;
            this.radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            donutSeries1});
            this.radChartView1.ShowGrid = false;
            this.radChartView1.ShowLegend = true;
            this.radChartView1.ShowPanZoom = true;
            this.radChartView1.ShowTitle = true;
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.ShowTrackBall = true;
            this.radChartView1.ThemeName = "Fluent";
            this.radChartView1.Title = "Total generales";
            // 
            // radPanel1
            // 
            resources.ApplyResources(this.radPanel1, "radPanel1");
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPanel1.ThemeName = "Fluent";
            // 
            // radChartView2
            // 
            cartesianArea1.GridDesign.AlternatingHorizontalColor = false;
            cartesianArea1.GridDesign.DrawHorizontalFills = false;
            cartesianArea1.GridDesign.DrawHorizontalStripes = false;
            cartesianArea1.GridDesign.DrawVerticalStripes = false;
            this.radChartView2.AreaDesign = cartesianArea1;
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.LabelFitMode = Telerik.Charting.AxisLabelFitMode.MultiLine;
            linearAxis1.LabelRotationAngle = 300D;
            linearAxis1.MajorStep = 10D;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "Mensial";
            linearAxis2.IsPrimary = true;
            linearAxis2.LabelRotationAngle = 300D;
            linearAxis2.MajorStep = 10D;
            linearAxis2.TickOrigin = null;
            linearAxis2.Title = "";
            this.radChartView2.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            linearAxis1,
            linearAxis2});
            this.radChartView2.BackColor = System.Drawing.Color.Transparent;
            this.radChartView2.ForeColor = System.Drawing.Color.Gray;
            this.radChartView2.LegendTitle = "asdfasdfadf";
            resources.ApplyResources(this.radChartView2, "radChartView2");
            this.radChartView2.Name = "radChartView2";
            scatterDataPoint1.XValue = 45D;
            scatterDataPoint1.YValue = 34D;
            scatterDataPoint2.XValue = 79D;
            scatterDataPoint2.YValue = 37D;
            scatterDataPoint3.XValue = 71D;
            scatterDataPoint3.YValue = 30D;
            scatterDataPoint4.XValue = 72D;
            scatterDataPoint4.YValue = 74D;
            scatterDataPoint5.XValue = 50D;
            scatterDataPoint5.YValue = 38D;
            scatterAreaSeries1.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            scatterDataPoint1,
            scatterDataPoint2,
            scatterDataPoint3,
            scatterDataPoint4,
            scatterDataPoint5});
            scatterAreaSeries1.HorizontalAxis = linearAxis1;
            scatterAreaSeries1.LabelAngle = 90D;
            scatterAreaSeries1.LabelDistanceToPoint = 14D;
            scatterAreaSeries1.LegendTitle = "gfdgdf";
            scatterAreaSeries1.VerticalAxis = linearAxis2;
            scatterDataPoint6.XValue = 41D;
            scatterDataPoint6.YValue = 26D;
            scatterDataPoint7.XValue = 52D;
            scatterDataPoint7.YValue = 10D;
            scatterDataPoint8.XValue = 32D;
            scatterDataPoint8.YValue = 42D;
            scatterDataPoint9.XValue = 69D;
            scatterDataPoint9.YValue = 65D;
            scatterDataPoint10.XValue = 34D;
            scatterDataPoint10.YValue = 65D;
            scatterAreaSeries2.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            scatterDataPoint6,
            scatterDataPoint7,
            scatterDataPoint8,
            scatterDataPoint9,
            scatterDataPoint10});
            scatterAreaSeries2.HorizontalAxis = linearAxis1;
            scatterAreaSeries2.LabelAngle = 90D;
            scatterAreaSeries2.LabelDistanceToPoint = 15D;
            scatterAreaSeries2.LegendTitle = "wdfsdf";
            scatterAreaSeries2.VerticalAxis = linearAxis2;
            this.radChartView2.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            scatterAreaSeries1,
            scatterAreaSeries2});
            this.radChartView2.ShowGrid = false;
            this.radChartView2.ShowPanZoom = true;
            this.radChartView2.ShowToolTip = true;
            this.radChartView2.ShowTrackBall = true;
            this.radChartView2.ThemeName = "Fluent";
            // 
            // DashBoard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.radChartView2);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radChartView1);
            this.Name = "DashBoard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadChartView radChartView2;
    }
}