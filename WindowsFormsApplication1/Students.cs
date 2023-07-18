using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Students : Abstract
    {
        public List<string> students = new List<string>();

        public Students()
        {
            if (File.Exists("students.txt"))
            {
                using (StreamReader sr = File.OpenText("students.txt"))
                {
                    string line = null;

                    while ((line = sr.ReadLine()) != null)
                    {
                        students.Add(line);
                    }
                }

            }
        }

        public override void Filing()
        {
            using (StreamWriter sw = File.CreateText("students.txt"))
            {
                foreach (string line in students)
                {
                    sw.WriteLine(line);
                }
            }
        }

        public override void Insert(string data)
        {
            students.Add(data);
            Filing();
        }

        public override void Update(int id, string data)
        {
            students[id] = data;
            Filing();
        }

        public override void Delete(int id)
        {
            students.RemoveAt(id);
            Filing();
        }
    }
}
