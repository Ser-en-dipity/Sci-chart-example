using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SciChart.Charting.Model.DataSeries;
using System.ComponentModel;
using SciChart.Charting;

namespace Sci_Chart;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // var dataSeries = new XyDataSeries<double, double>();
        // for(int i = 0; i < 4096; i++)
        //     dataSeries.Append(i, Math.Sin(i*0.2));
        // lineSeries.DataSeries = dataSeries;
    }

    private void PointMarkersSelectionExampleView_OnLoaded(object sender, RoutedEventArgs e)
    {
        
        var dataSeries = new XyDataSeries<double, double>();
        for(int i = 0; i < 4096; i++)
        {
            dataSeries.Append(i, Math.Sin(i*0.2), new SelectedPointMetadata() { IsSelected = false });
            
        }
        
        // var data = DataManager.Instance.GetSinewave(100,55,150);

       // Append data to series. SciChart automatically redraws
        // dataSeries.Append(new double[] { 0,1,2,3 }, new double[] { 10,20,30,40 },
        //     new [] { 
        //     new SelectedPointMetadata() { IsSelected = true },
        //         new SelectedPointMetadata() { IsSelected = false },
        //         new SelectedPointMetadata() { IsSelected = false },
        //         new SelectedPointMetadata() { IsSelected = false },
        // } );
        lineSeries.DataSeries = dataSeries;

        sciChart.ZoomExtents();
        
    }

    public class SelectedPointMetadata : IPointMetadata
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsSelected { get; set; }
    }
}
