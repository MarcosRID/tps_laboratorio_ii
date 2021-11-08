using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Archivos<T> where T : new()
    {

        public static void Serializar(T objeto, string path)
        {
            XmlSerializer serializo = null;

            try
            {
                using (XmlTextWriter escribo = new XmlTextWriter(path, Encoding.UTF8))
                {
                    escribo.Formatting = Formatting.Indented;

                    serializo = new XmlSerializer(typeof(T));
                    serializo.Serialize(escribo, objeto);

                }

            }
            catch (Exception)
            { }

        }


        public static T Deserializar(string path)
        {
            using (XmlTextReader lector = new XmlTextReader(path))
            {
                try
                {
                    XmlSerializer serializo = serializo = new XmlSerializer(typeof(T));

                    return (T)serializo.Deserialize(lector);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
