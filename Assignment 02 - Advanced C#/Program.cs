namespace Assignment_02___Advanced_C_
{
    internal class Program
    {
        static int CountGreaterThanX(int[] arr, int x)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num > x)
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsPalindrome(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            #region 1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
            //int n, q;
            //Console.Write("Enter the size: ");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("Enter number of query: ");
            //q = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Console.WriteLine("Enter array numbers");
            //for (int i = 0; i < n; i++)
            //{              
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //while (q > 0)
            //{               
            //    int x = int.Parse(Console.ReadLine());
            //    int result = CountGreaterThanX(arr, x);
            //    Console.WriteLine($"Count of numbers greater than {x}: {result}");
            //    q--;
            //}
            #endregion

            #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
            int n = int.Parse(Console.ReadLine());
            int[] arr= new int[n];
            Console.WriteLine("Enter array numbers");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            bool isPalindrome = IsPalindrome(arr);

            if (isPalindrome)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            #endregion


        }
    }
}
