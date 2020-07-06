using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;
using Naxam.Controls.Forms;
using Naxam.Mapbox.Layers;
using Newtonsoft.Json;
using Xamarin.Forms;
using Point = GeoJSON.Net.Geometry.Point;
//using Point = GeoJSON.Net.Geometry.Point;

namespace XFMapboxIDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            map.DidTapOnMapCommand = new Command<Tuple<Position, Point>>((Tuple<Position, Point> obj) =>
            {
                //var features = map.GetFeaturesAroundPoint.Invoke(obj.Item2, 6, null);
                //var filtered = features.Where((arg) => arg.Attributes != null);
                //foreach (Feature feat in filtered)
                //{
                //    var str = JsonConvert.SerializeObject(feat);
                //    System.Diagnostics.Debug.WriteLine(str);
                //}

            });
            map.DidFinishLoadingStyleCommand = new Command<MapStyle>((obj) =>
            {
                //map.ResetPositionFunc.Execute(null);
                //foreach (Layer layer in obj.OriginalLayers)
                //{
                //    System.Diagnostics.Debug.WriteLine(layer.Id);
                //}

            });
            map.ZoomLevel = Device.RuntimePlatform == Device.Android ? 4 : 10;
        }
    }
}
