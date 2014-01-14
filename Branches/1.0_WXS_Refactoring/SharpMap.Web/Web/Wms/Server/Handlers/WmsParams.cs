using System;
using System.Drawing;
using GeoAPI.Geometries;

namespace SharpMap.Web.Wms.Server.Handlers
{
    public class WmsParams
    {
        public string Error { get; set; }
        public WmsException.WmsExceptionCode ErrorCode { get; set; }

        public bool IsValid
        {
            get { return String.IsNullOrEmpty(Error); }
        }

        public string Service { get; set; }
        public string Version { get; set; }
        public string Layers { get; set; }
        public string Styles { get; set; }
        public string CRS { get; set; }
        public string QueryLayers { get; set; }
        public Envelope BBOX { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public string Format { get; set; }
        public string InfoFormat { get; set; }
        public int FeatureCount { get; set; }
        public string CqlFilter { get; set; }
        public Color BackColor { get; set; }

        public static WmsParams Failure(string s)
        {
            return Failure(WmsException.WmsExceptionCode.NotApplicable, s);
        }

        public static WmsParams Failure(WmsException.WmsExceptionCode code, string s)
        {
            if (String.IsNullOrEmpty(s))
                throw new ArgumentNullException("s", "an error message should be declared");
            return new WmsParams { Error = s, ErrorCode = code };
        }
    }
}