using System.Text;

namespace homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1task

            //int[] array = { 2, 3, 4 };
            //CustomResize(ref array,47,29,10,4);
            //for(int i=0;i<array.Length;i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            
            //2task

            //Console.WriteLine(CapitalizedSentence(Console.ReadLine().Trim()));

        }
        public static void CustomResize(ref int[] arr, params int[] nums)
        {
            int[] newarr=new int[arr.Length+nums.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                newarr[arr.Length + i] = nums[i];
            }
            arr = newarr;
            
        }
        public static string CapitalizedWord(string word)
        {
            StringBuilder str = new StringBuilder();
            str.Append(char.ToUpper(word[0]));
            for (int i = 1; i < word.Length; i++)
            {
                str.Append(char.ToLower(word[i]));
            }
            return str.ToString();
        }
        public static string CapitalizedSentence( string sentence)
        {
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < sentence.Length-1; i++)
            {
                if (sentence[i]==' ' && sentence[i+1]==' ')
                {
                    sentence=sentence.Replace("  ", " ");
                    i = 0;
                }
            }
            string[] array= sentence.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                str.Append(CapitalizedWord(array[i]));
                str.Append(' ');
            }

            return str.ToString();
        }
    }
}
