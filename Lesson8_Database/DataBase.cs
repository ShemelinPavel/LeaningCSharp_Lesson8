using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Lesson8_Database
{
    // Класс для вопроса    
    [Serializable]
    public class Question
    {
        private string text;    // Текст вопроса
        private bool trueFalse; // Правда или нет
        private string descr;   // Доп. описание ответа

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public bool TrueFalse
        {
            get { return trueFalse; }
            set { trueFalse = value; }

        }

        public string Description
        {
            get { return descr; }
            set { descr = value; }

        }

        public Question()
        {
        }
        public Question(string text, bool trueFalse, string descr = "")
        {
            Text = text;
            TrueFalse = trueFalse;
            Description = descr;
        }
    }
 
    // Класс для хранения списка вопросов. А так же для сериализации в XML и десериализации из XML
    class TrueFalse
    {
        private string fileName;
        private List<Question> list;

        public List<Question> List
        {
            get { return list; }
            set { list = value; }
        }

        public string FileName
        {
            set { fileName = value; }
            get { return fileName; }
        }

        public TrueFalse(string fileName)
        {
            FileName = fileName;
            List = new List<Question>();
        }

        public void Add(string text, bool trueFalse, string descr)
        {
            list.Add(new Question(text, trueFalse, descr) );
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
            else throw new IndexOutOfRangeException("Error!");
        }

        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}
