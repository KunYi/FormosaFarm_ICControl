using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormosaRM_ICControl
{
    public  class ICControlObject
    {
        public class LoRaControlObject
        {
            public class IrrigationObject
            {
                public bool channel1 { get; set; }
                public bool channel2 { get; set; }
                public bool channel3 { get; set; }
                public bool channel4 { get; set; }
            }
            public string Obj { get; set; }
            public string Control { get; set; }
            public IrrigationObject Irrigation;
        }
        public bool confirmed { get; set; }
        public uint fPort { get; set; }
        public LoRaControlObject @object;
        public ICControlObject() {
            confirmed = false;
            fPort = 10;
            @object = new LoRaControlObject();
            @object.Obj = "Irrigation";
            @object.Control = "Set";
            @object.Irrigation = new LoRaControlObject.IrrigationObject();
            @object.Irrigation.channel1 = false;
            @object.Irrigation.channel2 = false;
            @object.Irrigation.channel3 = false;
            @object.Irrigation.channel4 = false;
        }
    }
}
