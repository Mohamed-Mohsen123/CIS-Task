namespace CIS_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountMelts("_I___I___I__I"));
     
        }

        static int CountMelts(string s)
        {
            int total = 0;

            while (true)
            {
                char[] arr = s.ToCharArray();
                Stack<char> stack = new Stack<char>();
                int meltIndex = -1;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '_')
                    {
                        stack.Push('_');

                        // keep ONLY last 3 underscores
                        if (stack.Count > 3)
                            stack.Pop();

                        if (stack.Count == 3)
                        {
                            int next = i + 1;
                            if (next < arr.Length && arr[next] == 'I')
                            {
                                meltIndex = next;
                                break;
                            }
                        }
                    }
                    else
                    {
                        stack.Clear();
                    }
                }

                if (meltIndex == -1) break;

                arr[meltIndex] = '_';
                total++;
                s = new string(arr);
            }

            return total;
        }


    }
}