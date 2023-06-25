using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfGeneration.Model
{
    public class Invoice
    {

        public List<Item> Items { get; set; }
        public class Item
        {
            public string ItemTitle { get; set; }
            public string ComponentId { get; set; }
            public string SecurityLevel { get; set; }
            public string ImageSource { get; set; }
            public List<ImageTemperatureTable> ImageTemperatureTables { get; set; }
            public string Emissivity { get; set; }
            public string AmbientTemperature { get; set; }
            public string ReflectiveTemperature { get; set; }
            public string ObjectDistance { get; set; }
            public string Humidity { get; set; }
            public string RedBrownPhase { get; set; }
            public string BlueBlackPhase { get; set; }
            public string YellowWhitePhase { get; set; }
            public string FaultCause { get; set; }
            public string Recommendations { get; set; }
            public string ImageSource2 { get; set; }

        }

        public class ImageTemperatureTable
        {
            public string ItemPoint { get; set; }
            public string ItemPointTemperature { get; set; }
            public string TemperatureDifference { get; set; }
        }
    }
}
