namespace CIS_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //it counts _ until it raeches the I if there is no I it compares the count 
            // if (count<3) count=0; else I becomes _ count++ continue;

            int melts = CountMelts("___I_I");
            Console.WriteLine("melts : " + melts);
        }
        static int CountMelts(string input)
        {
            int segmantCount = 0;
            int meltCount = 0;
            foreach (char c in input)
            {

                if (c == 'I')
                {
                    if (segmantCount < 3) segmantCount = 0;
                    else
                    {
                        meltCount++;
                        segmantCount++;
                    }
                }
                else segmantCount++;
            }
            return meltCount;
        }

    }
}