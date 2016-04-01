using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Prestige_YoYo
{
    public partial class General_User : Form, myForm
    {
        string userName;
        string password;

        frmSelectFactory frmFactory;
        string factory;

        frmSelectStation frmStation;
        string station;
        

        public void setFactory(string newFactory)
        {
            if (newFactory != null && newFactory != "")
            {
                factory = newFactory;
                lblFactorySelected.Text = factory;
            }
        }
        public void setStation(string newStation)
        {
            if (newStation != null && newStation != "")
            {
                station = newStation;
                lblStationSelected.Text = station;
            }
        }

        public void setUserName(string newUserName)
        {
            userName = newUserName;
            this.Text += " - " + newUserName;
        }
        public void setPassword(string newPassword)
        {
            password = newPassword;
        }
        
        public General_User()
        {
            InitializeComponent();
            //Production yield

            // Populate series data
            
            double[] notImplementedValue = {1};
            string[] notImplementedText = { "Data not retrived" };
            pieProductionYield.Series.Add("Pie");
            pieProductionYield.Series["Pie"].Points.DataBindXY( notImplementedText,notImplementedValue);

            // Set Doughnut chart type
            pieProductionYield.Series["Pie"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            // Set labels style
            pieProductionYield.Series["Pie"]["PieLabelStyle"] = "Inside";
            pieProductionYield.Series["Pie"].IsValueShownAsLabel = true;

            pieProductionYield.ChartAreas[0].Area3DStyle.Enable3D = true;
            pieProductionYield.Series["Pie"].BorderColor = Color.Black;
            pieProductionYield.Series["Pie"].BorderWidth = 1;
            pieProductionYield.Series["Pie"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;

            // Populate Field Yield

            pieFinalYield.Series.Add("Pie");
            pieFinalYield.Series["Pie"].Points.DataBindXY(notImplementedText, notImplementedValue);

            // Set Doughnut chart type
            pieFinalYield.Series["Pie"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            // Set labels style
            pieFinalYield.Series["Pie"]["PieLabelStyle"] = "Inside";
            pieFinalYield.Series["Pie"].IsValueShownAsLabel = true;

            pieFinalYield.ChartAreas[0].Area3DStyle.Enable3D = true;
            pieFinalYield.Series["Pie"].BorderColor = Color.Black;
            pieFinalYield.Series["Pie"].BorderWidth = 1;
            pieFinalYield.Series["Pie"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;

            //populate Pareto Defects
            double[] yValues = { 65.62, 75.54, 60.45, 34.73, 85.42 };
            string[] xValues = { "France", "Canada", "Germany", "USA", "Italy" };
            paretoDefects.Series.Add("Pareto");
            paretoDefects.Series["Pareto"].Points.DataBindXY(xValues, yValues);

            // Set Doughnut chart type
            paretoDefects.Series["Pareto"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            // Set labels style
            paretoDefects.Series["Pareto"]["PieLabelStyle"] = "Inside";
            paretoDefects.Series["Pareto"].IsValueShownAsLabel = true;
            
            MakeParetoChart(paretoDefects, "Pareto","hmmm");
            //pieFinalYield.Series["Pareto"].BorderColor = Color.Black;
            //pieFinalYield.Series["Pareto"].BorderWidth = 1;
            //pieFinalYield.Series["Pareto"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;

        }

        private void btnProductionYield_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelectFactory_Click(object sender, EventArgs e)
        {
            frmFactory = new frmSelectFactory(this);
            frmFactory.Show();
        }

        private void btnSelectStation_Click(object sender, EventArgs e)
        {
            frmStation = new frmSelectStation(this);
            frmStation.setFactory(factory);
            frmStation.Show();
        }

        private void tabDefects_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabProductionYield_Enter(object sender, EventArgs e)
        {
            

        }

        private void tabFinalYield_Enter(object sender, EventArgs e)
        {

        }


        void MakeParetoChart(Chart chart, string srcSeriesName, string destSeriesName)
        {

            // Get the name of the ChartArea of the source series
            string strChartArea = chart.Series[srcSeriesName].ChartArea;

            // Ensure that the source series is a column chart type
            chart.Series[srcSeriesName].ChartType = SeriesChartType.Column;

            // Sort the data in the series to be in descending order
            chart.DataManipulator.Sort(PointSortOrder.Descending, srcSeriesName);

            // Find the total of all points in the source series
            double total = 0.0;
            foreach (DataPoint pt in chart.Series[srcSeriesName].Points)
                total += pt.YValues[0];

            // Set the max. value on the primary axis to the total
            chart.ChartAreas[strChartArea].AxisY.Maximum = total;

            // Create the destination series and add it to the chart
            Series destSeries = new Series(destSeriesName);
            chart.Series.Add(destSeries);

            // Ensure the destination series is a Line or Spline chart type
            destSeries.ChartType = SeriesChartType.Line;

            destSeries.BorderWidth = 3;

            // Assign the series to the same chart area as the column chart
            destSeries.ChartArea = chart.Series[srcSeriesName].ChartArea;

            // Assign this series to use the secondary axis and set its maximum to be 100%
            destSeries.YAxisType = AxisType.Secondary;
            chart.ChartAreas[strChartArea].AxisY2.Maximum = 100;

            // Locale specific percentage format with no decimals
            chart.ChartAreas[strChartArea].AxisY2.LabelStyle.Format = "P0";

            // Turn off the end point values of the primary X axis
            chart.ChartAreas[strChartArea].AxisX.LabelStyle.IsEndLabelVisible = false;

            // For each point in the source series find % of total and assign it to destination series
            double percentage = 0.0;

            foreach (DataPoint pt in chart.Series[srcSeriesName].Points)
            {

               
                percentage += (pt.YValues[0] / total * 100.0);
               destSeries.Points.Add(Math.Round(percentage, 2));

            }

            // Set to 3D
            chart.ChartAreas[strChartArea].Area3DStyle.Enable3D = true;
        }

    }
}
