using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class IssueBook : Abstract
    {
        public List<string> issuebook = new List<string>();

        public IssueBook()
        {
            if (File.Exists("borrow.txt"))
            {
                using (StreamReader sr = File.OpenText("borrow.txt"))
                {
                    string line = null;

                    while ((line = sr.ReadLine()) != null)
                    {
                        issuebook.Add(line);
                    }
                }
            }
        }

        public override void Filing()
        {
            using (StreamWriter sw = File.CreateText("borrow.txt"))
            {
                foreach (string line in issuebook)
                {
                     sw.WriteLine(line);
                }
            }
        }

        public override void Insert(string data)
        {
            issuebook.Add(data);
            Filing();
        }

        public override void Update(int id,string data)
        {
            issuebook[id] = data;
            Filing();
        }

        public override void Delete(int id)
        {
            issuebook.RemoveAt(id);
            Filing();
        }
    }
}
