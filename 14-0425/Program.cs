namespace _14_0425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            RequestManager rq = new RequestManager();
            for(int i = 0; i < n; i++)
            {
                rq.Add(new FileRequest(Console.ReadLine()));    

            }
            rq.Show();
        }
    }
}
