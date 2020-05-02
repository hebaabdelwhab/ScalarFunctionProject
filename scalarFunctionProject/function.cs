using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace scalarFunctionProject
{
    class function
    {
        //public string definition;
        public string name;
        public int numArguments;
        public string[] dataTypes;
        // public string returnType;


        public function( string name, int numArguments, string[] dataType)
        {
           // this.definition = definition;
            this.name = name;
            this.numArguments = numArguments;
            for(int i=1;i<dataType.Count(); i++)
            {
                dataTypes[i]= dataType.ElementAt(i);
            }
            //this.returnType = returnType;

        }
        public void writeFunction()
        {
            if (!File.Exists("function.xml")) //case file doesnot exist
            {
                XmlWriter writer = XmlWriter.Create("function.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("table");
                writer.WriteStartAttribute("name", "Function");
                //data of employee,id,name,salary,bonus,taxes,department,depId
                writer.WriteStartElement("Function"); 
                writer.WriteStartElement("name");
                writer.WriteString(name);
                writer.WriteEndElement();
                //------------------------------------------------
                writer.WriteStartElement("numberofarguments");
               writer.WriteString(Convert.ToString(numArguments));
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("datatypes");
                for (int i = 0; i < dataTypes.Length; i++)
                {
                    writer.WriteStartElement("dataType");
                    writer.WriteString(dataTypes.ElementAt(i));
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
               //------------------------------------------------------
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                }
               else{
                XmlDocument doc = new XmlDocument();
                
                doc.Load("function.xml");
                XmlElement parent = doc.CreateElement("function");
                //------------------------------------------------
                XmlElement node = doc.CreateElement("name");
                node.InnerText=Convert.ToString(name);     
                parent.AppendChild(node);
                //------------------------------------------------
                node=doc.CreateElement("numberOfArguments");
                node.InnerText=Convert.ToString(numArguments);        
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("data types");
                for(int i=0;i<dataTypes.Count();i++)
                {
                XmlElement node1 = doc.CreateElement("dataType");
                node1.InnerText = Convert.ToString(dataTypes.ElementAt(i));
                    node.AppendChild(node1);
                }
                XmlElement root = doc.DocumentElement;
                root.AppendChild(parent);
                doc.Save("function.xml");
                }
        }
        public void readFunction(string name)
        {

        }
    }
}