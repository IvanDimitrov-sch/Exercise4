using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_0425
{
    internal class FileRequest
    {
        
        public string Name { get; set; }
        //public string Description { get; set; }
        public FileRequest(string name, string description)
        {
            Name = name;
            //Description = description;
        }
    }
}
