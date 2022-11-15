using QualityShims.ReportDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIReport.Helpers
{
    public static class ReportDatasourceHelper
    {
        public static void CreateXsd()
        {
            var types = new[] { typeof(DimensionDto)/*, typeof(ReportItemClass2), typeof(ReportItemClass3)*/ };
            var xri = new System.Xml.Serialization.XmlReflectionImporter();
            var xss = new System.Xml.Serialization.XmlSchemas();
            var xse = new System.Xml.Serialization.XmlSchemaExporter(xss);
            foreach (var type in types)
            {
                var xtm = xri.ImportTypeMapping(type);
                xse.ExportTypeMapping(xtm);
            }
            using var sw = new System.IO.StreamWriter("ReportItemSchemas.xsd", false, Encoding.UTF8);
            for (int i = 0; i < xss.Count; i++)
            {
                var xs = xss[i];
                xs.Id = "ReportItemSchemas";
                xs.Write(sw);
            }
        }
    }
}
