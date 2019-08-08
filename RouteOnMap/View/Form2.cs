using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteOnMap
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public UserInput UserInput { get; set; }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine(UserInput.userinput);
            if(UserInput.userinput != null)
            {
                Set_MapLocation(UserInput.userinput);
            }
            else
            {
                Set_MapLocation("Deakin University");
            }
            
            Load_Map();
        }

        public void Load_Map()
        {
            RouteMap2.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
        }

        public void Set_MapLocation(string keyWord)
        {

            RouteMap2.MaxZoom = 24;
            RouteMap2.Zoom = 14;
            Console.WriteLine(keyWord.Trim());
            GeoCoderStatusCode statusCode = new GeoCoderStatusCode();
            var pointLatLng = RouteMap2.GeocodingProvider.GetPoint(keyWord.Trim(), out statusCode);
            if (statusCode == GeoCoderStatusCode.OK)
            {
                RouteMap2.Position = new PointLatLng(pointLatLng.Value.Lat, pointLatLng.Value.Lng);
            }
        }
    }
}
