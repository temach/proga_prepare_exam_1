using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication_Exam1
{

    class CompareDeep : System.Collections.Generic.IEqualityComparer<MyBook>
    {
        //
        // Summary:
        //     Determines whether the specified objects are equal.
        //
        // Parameters:
        //   x:
        //     The first object of type T to compare.
        //
        //   y:
        //     The second object of type T to compare.
        //
        // Returns:
        //     true if the specified objects are equal; otherwise, false.

        public bool Equals(MyBook x, MyBook y)
        {
            MyBook r = (x as MyBook);
            MyBook l = (y as MyBook);
            return (r.Author == l.Author)
                && (r.Name == l.Name)
                && (r.Price == l.Price)
                && (r.PageCount == l.PageCount)
                && (r.DateAdded == l.DateAdded)
                && (r.IsPresent == l.IsPresent);
        }

        //
        // Summary:
        //     Returns a hash code for the specified object.
        //
        // Parameters:
        //   obj:
        //     The System.Object for which a hash code is to be returned.
        //
        // Returns:
        //     A hash code for the specified object.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The type of obj is a reference type and obj is null.

        public int GetHashCode(MyBook obj)
        {
            var tmp = (obj as MyBook);
            return tmp.Author.GetHashCode() * 31
                + tmp.Name.GetHashCode() * 7
                + tmp.Price.GetHashCode()
                + tmp.IsPresent.GetHashCode()
                + tmp.PageCount.GetHashCode()
                + tmp.DateAdded.GetHashCode();
        }

    }

    class MyLibrary : Hold<MyBook>
    {

        public void AddBook(MyBook book)
        {
            this._data.Add(book);
            this._data = this._data.Distinct(new CompareDeep()).ToList();
        }

        public void AddBookRange(List<MyBook> allbooks)
        {
            this._data = this._data.Union(allbooks, new CompareDeep()).ToList();
        }

        public void AddFromXmlFile(string filename)
        {
            if (filename.Contains(".allbooks"))
            {
                List<MyBook> new_data = DeSerializeObject<List<MyBook>>(filename);
                AddBookRange(new_data);
            }
            else if (filename.Contains(".book"))
            {
                MyBook new_book = DeSerializeObject<MyBook>(filename);
                AddBook(new_book);
            }
            else
            {
                throw new Exception("Invalid file");
            }
        }

        public IEnumerable<MyBook> PresentBooksOfAuthor(string author)
        {
            return _data.Where(book => book.Author == author && book.IsPresent);
        }

        public void WriteManyFiles(string filename)
        {
            foreach (var book in _data)
            {
                SerializeObject(book, book.ToString() + ".book");
            }
        }

        public void WriteOneFile(string filename)
        {
            SerializeObject(_data, "one_file.allbooks");
        }

        /// <summary>
        /// Serializes an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObject"></param>
        /// <param name="fileName"></param>
        private void SerializeObject<T>(T serializableObject, string fileName)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(System.Char.ToString(c), "");
            }
            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, serializableObject);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(fileName);
                stream.Close();
            }
        }


        /// <summary>
        /// Deserializes an xml file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private T DeSerializeObject<T>(string fileName)
        {
            T objectOut = default(T);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(fileName);
            string xmlString = xmlDocument.OuterXml;

            using (StringReader read = new StringReader(xmlString))
            {
                Type outType = typeof(T);

                XmlSerializer serializer = new XmlSerializer(outType);
                using (XmlReader reader = new XmlTextReader(read))
                {
                    objectOut = (T)serializer.Deserialize(reader);
                    reader.Close();
                }
                read.Close();
            }
            return objectOut;
        }
    }
}
