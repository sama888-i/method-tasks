namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence ="Mence Sehvdi ";
            basherf(sentence);
            
        }
        static void  basherf(string sentence)
        {
            if (sentence.Length >0)
            {
                Console.Write(sentence[0]);

            }
            for (int i =1; i< sentence.Length; i++)
            {
                if (sentence[i -1] ==' ' && sentence[i] !=' ')
                {
                    Console.Write(sentence[i]);
                }
            }

        }

    }
}
