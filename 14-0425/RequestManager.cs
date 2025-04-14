using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_0425
{
    internal class RequestManager
    {
        public List<FileRequest> Requests = new List<FileRequest>();
        
        public RequestManager()
        {

        }
        public void Add(FileRequest req)
        {
            if (!Requests.Contains(req))
            {
                Requests.Add(req);  
            }
            
        }
    }
}
