using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Books : Abstract
    {
        public List<string> books = new List<string>();

        public Books()
        {
            if (File.Exists("books.txt"))
            {
                using (StreamReader sr = File.OpenText("books.txt"))
                {
                    string line = null;

                    while ((line = sr.ReadLine()) != null)
                    {
                        books.Add(line);
                    }
                }
            }
        }

        public override void Filing()
        {
            using (StreamWriter sw = File.CreateText("books.txt"))
            {
                foreach (string line in books)
                {
                    sw.WriteLine(line);
                }
            }
        }

        public override void Insert(string data)
        {
            books.Add(data);
            Filing();
        }

        public override void Update(int id, string data)
        {
            books[id] = data;
            Filing();
        }

        public override void Delete(int id)
        {
            books.RemoveAt(id);
            Filing();
        }
    }
}
