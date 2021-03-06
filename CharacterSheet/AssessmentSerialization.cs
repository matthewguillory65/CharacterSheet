﻿using System.IO;
using System.Xml.Serialization;

namespace CharacterSheet
{
    class AssessmentSerialization<T>
    {
        public static T Serialize(string filename, T data)//Makes the file for the data to save to
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(filename + ".xml");
            serializer.Serialize(writer, data);
            writer.Close();
            return data;
        }


        public static T Deserialize(string fileName)//Loads data from the saved files
        {
            T data;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(fileName + ".xml");
            data = (T)serializer.Deserialize(reader);
            reader.Close();
            return data;
        }
    }
}
