using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF_and_MS_Report_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReportViewer.Load += ReportViewer_Load;
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            TracksDataSet dataSet = new TracksDataSet();
            //_Database_mdfDataSet dataset = new _Database_mdfDataSet();
            dataSet.BeginInit();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = dataSet.Tracks;
            ReportViewer.LocalReport.DataSources.Add(reportDataSource);
            ReportViewer.LocalReport.ReportPath = "../../Report.rdlc";
            dataSet.EndInit();

            TracksDataSetTableAdapters.TracksTableAdapter tracksTableAdapter = new TracksDataSetTableAdapters.TracksTableAdapter { ClearBeforeFill = true };
            tracksTableAdapter.Fill(dataSet.Tracks);
            ReportViewer.RefreshReport();
        }
    }
}
