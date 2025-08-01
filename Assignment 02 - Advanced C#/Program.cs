using System;

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
        static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
        public static int[] RemoveDuplicates(int[] arr, ref int size)
        {
            bool[] check = new bool[100];
            int[] newarr = new int[arr.Length];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (check[arr[i]] == false)
                {
                    newarr[index] = arr[i];
                    check[arr[i]] = true;
                    index++;
                }

            }
            size = index;
            return newarr;
        }
        static void RemoveOddNumbers(List<int> numbers)
        {
            numbers.RemoveAll(n => n % 2 != 0);
        }


        static void SearchInStack(Stack<int> stack, int target)
        {
            int count = 0;
            bool found = false;
            foreach (var item in stack)
            {
                count++;
                if (item.Equals(target))
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
            }
            else
            {
                Console.WriteLine("Target was not found");
            }
        }
        static List<int> FindIntersection(int[] arr1, int[] arr2)
        {

            int[] freq = new int[1000];
            List<int> result = new List<int>();


            foreach (int num in arr1)
            {
                freq[num]++;
            }


            foreach (int num in arr2)
            {
                if (freq[num] > 0)
                {
                    result.Add(num);
                    freq[num]--;
                }
            }

            return result;
        }


        static List<int> FindSublistWithSum(List<int> list, int target)
        {
            int start = 0, currentSum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                currentSum += list[i];

                
                while (currentSum > target && start <= i)
                {
                    currentSum -= list[start];
                    start++;
                }

                
                if (currentSum == target)
                {
                    return list.GetRange(start, i - start + 1);
                }
            }

            return null; 
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
            //int n = int.Parse(Console.ReadLine());
            //int[] arr= new int[n];
            //Console.WriteLine("Enter array numbers");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //bool isPalindrome = IsPalindrome(arr);

            //if (isPalindrome)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
            //Queue<int> q = new Queue<int>();
            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //q.Enqueue(5);

            //ReverseQueue(q);

            //Console.WriteLine("Reversed Queue:");
            //foreach (var item in q)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string s = Console.ReadLine();

            //if (IsBalanced(s))
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //}
            #endregion

            #region 5. Given an array, implement a function to remove duplicate elements from an array.
            //int[] arr = { 1, 2, 2, 3, 4, 1, 5, 3, 6, 6, 7 };

            //int size = arr.Length;
            //int[] result = RemoveDuplicates(arr, ref size);

            //Console.WriteLine("Array after removing duplicates:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}

            #endregion


            #region 6. Given an array list , implement a function to remove all odd numbers from it.
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //RemoveOddNumbers(numbers);

            //Console.WriteLine("After Removing Odd Numbers:");

            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion

            #region 7. Implement a queue that can hold different data types. 
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);          
            //queue.Enqueue("Apple");    
            //queue.Enqueue(5.28);     


            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item + " ");
            //}


            #endregion

            #region 8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).
            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Push(50);

            //int target = int.Parse(Console.ReadLine());

            //SearchInStack(stack, target);

            #endregion

            #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
            //int[] arr1 = { 1, 2, 3, 4, 4 };
            //int[] arr2 = { 10, 4, 4 };

            //List<int> intersection = FindIntersection(arr1, arr2);

            //foreach (var item in intersection)
            //{
            //    Console.Write(item + " ");
            //}



            #endregion

            #region 10. Given  an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
            List<int> list = new List<int>() { 1, 2, 3, 7, 5 };

            int target = 12;
            List<int> result = FindSublistWithSum(list, target);

            if(result==null)
            {
                Console.WriteLine("No sublist found with the given sum.");
            }
            else
            {
               
                foreach(var item in result)
                {
                    Console.Write(item + " ");
                }
            }
            #endregion
        }
    }
}
