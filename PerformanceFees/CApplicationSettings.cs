using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PerformanceFees
{
    public class CApplicationSettings
    {
        public string _compCore;
        public string _compPrimitiveInit;
        public string _compPrimitiveFunctions;
        public string _compPrimitiveConstructor;

        public string _fileDefaultLocation;
        public string _fileDefaultFile;

        public CApplicationSettings()
        {
            _fileDefaultFile = "test";

        }


        public void Load(string fileName)
        {
            using (var stream = System.IO.File.OpenRead(fileName))
            {
                var serializer = new XmlSerializer(this.GetType());
                
                var deserial =  serializer.Deserialize(stream) as CApplicationSettings;

                _compCore = ForceOnNull(deserial._compCore);
                _compPrimitiveInit = ForceOnNull(deserial._compPrimitiveInit);
                _compPrimitiveFunctions  = ForceOnNull(deserial._compPrimitiveFunctions);
                _fileDefaultLocation = ForceOnNull(deserial._fileDefaultLocation);
                _fileDefaultFile = ForceOnNull(deserial._fileDefaultFile);
                _compPrimitiveConstructor = ForceOnNull(deserial._compPrimitiveConstructor);
            }
        }

        public string ForceOnNull(string pToCheck)
        {
            return pToCheck is null ? "" : pToCheck;
        }

        public void Save(string fileName)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                var writer = new System.IO.StreamWriter(ms);
                var serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(writer, this);
                writer.Flush();
                File.WriteAllBytes(fileName, ms.ToArray());
            }
        }
    
    }
}
