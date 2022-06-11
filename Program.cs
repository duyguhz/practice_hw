using System;

namespace practicee
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Akif", "Amin", "Zerife", "Durdane" };
            int result = FindNameCount(names);
            Console.WriteLine(result);


            int[] nums = { 7, 3, 4, 5, 67, 54, 55, 88, };

            int[] newArray = GiveEvenNums(nums);
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

           




            #region task1
            static int FindNameCount(string[] names)
            {
                int count = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Length > 5)
                    {
                        count++;


                    }


                }
                return count;

            }
            #endregion
            #region task2
            static int[] GiveEvenNums(int[] nums)
            {
                int index = 0;
                int newSize = EvenNumbersCount(nums);
                int[] evenNums = new int[newSize];

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        evenNums[index] = nums[i];
                        index++;
                    }
                }
                return evenNums;

            }

            static int EvenNumbersCount(int[] nums)
            {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
            #endregion
            #region task3
            static int FindIndex(int[] numbers, int num)
            {
                int max = numbers.Length - 1;
                int min = 0;
                int index = -1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    while (min <= max)
                    {
                        int mid = (min + max) / 2;
                        if (num == numbers[mid])
                        {
                            index = mid;
                            break;
                        }
                        else if (num > numbers[mid])
                        {
                            min = mid + 1;
                        }
                        else
                        {
                            max = mid - 1;
                        }

                    }
                    if (index == -1)
                    {
                        Console.WriteLine("eded yoxdur");
                    }
                    else
                    {
                        Console.WriteLine($"{num} {index} nomreli indexde yerlesir");
                    }

                }
                return index;




            }
            #endregion
            #region task4
            static bool FindIfIncluded(int[] numss,int[] numss2)
            {
                bool check = false;
                for (int i = 0; i < numss.Length; i++)
                {
                    for (int j = 0; j < numss2.Length; j++)
                    {
                        if (numss[i]==numss2[j])
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            #endregion
            #region task5
            static bool StartsWithA(string[] words)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i][0]=='A')
                    {
                        return true;
                    }
                }
                return false;
            }
            #endregion
            #region task6

            static int[] AddInteger(int[] numbers,int n)
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = n;
            }
            #endregion
        }
    }
}


