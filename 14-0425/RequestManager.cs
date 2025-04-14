using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_0425
{
    internal class RequestManager
    {
        
        public HashSet<string> FileRequests = new HashSet<string>();
        public Queue<FileRequest> Queue = new Queue<FileRequest>();
        public RequestManager()
        {

        }
        public void Add(FileRequest req)
        {
            if (FileRequests.Add(req.Name))
            {
                Queue.Enqueue(req);
            }
               
        }
        public void Show()
        {
            foreach(var req in Queue)
            {
                Console.WriteLine($"Обработка на файл: {req.Name}");
            }
        }
    }
}
