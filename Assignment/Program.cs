namespace Assignment
{
    internal class Program
    {
        #region Question 01
        class StringFun
        {
            public static int GetCountOfUpperCaseChars(string Name)
            {
                int count = 0;
                if (Name is not null)
                {
                    for (int i = 0; i < Name.Length; i++)
                        if (char.IsUpper(Name[i]))
                            count++;
                }
                return count;
            }

            public static int GetCountOfLowerCaseChars(string Name)
            {
                int count = 0;
                if (Name is not null)
                {
                    for (int i = 0; i < Name.Length; i++)
                        if (char.IsLower(Name[i]))
                            count++;
                }
                return count;
            }
        }
        ///Step 0. Declaring Delegate Function
        public delegate int CustomFunc(string arg01);
        public delegate bool CustomPre(int arg01);
        public static List<int> FindNumbers(List<int> nums, CustomPre pre)
        {
            List<int> result = new List<int>();

            if (nums?.Count > 0)
            {
                foreach (int num in nums)
                {
                    //if(num % 2 != 0)
                    if (pre(num))
                        result.Add(num);
                }
            }
            return result;
        }

        class ConditionFunc
        {
            public static bool IsOdd(int Number) => Number % 2 != 0;
            public static bool IsEven(int Number) => Number % 2 == 0;

            public static bool IsDivisible(int Number) => Number % 7 == 0;
        }

        public static Action DelegateDoAction()
        {
            return delegate { Console.WriteLine("Hello Samer"); };
            return () => Console.WriteLine("Hello Samer");
        } 
	#endregion
        static void Main(string[] args)
        {
            #region Question 01
            ///What is Delegates?
            ///Delegate is a C# feature

            ///Delegates has 2 Usages:-
            ///1. Functional Programming 
            ///2. Event-Driven Programming

            ///Step 1. Declare delegate reference 
            ///CustomFunc reference;

            ///Step 2. Initialize Delegate reference 
            //reference = new CustomFunc(StringFun.GetCountOfUpperCaseChars);
            ///reference = StringFun.GetCountOfUpperCaseChars; //"Syntax Sugar"
            //reference = StringFun.GetCountOfLowerCaseChars;

            //Step 3. Use The Delegate reference
            ///int Res = reference("SaMer EMAd");
            ///Console.WriteLine($"Result = {Res}");

            //int[] numbers = { 8, 2, 9, 5, 10, 7, 3, 6, 1, 4 };
            //CustomFun<int> func = SortingTypes.CompareGrt;
            //func = default;
            //SortingAlgo.BubbleSort(numbers, delegate (int x, int y) { return x > y; });
            //SortingAlgo.BubbleSort(numbers, (x, y) => x > y);
            //foreach (int num in numbers) 
            //    Console.WriteLine(num);

            //int[] numbers = { 8, 2, 9, 5, 10, 7, 3, 6, 1, 4 };
            //CustomFun<int, int, bool> func = SortingTypes.CompareGrt;
            //func = default;
            //SortingAlgo.BubbleSort(numbers, delegate (int x, int y) { return x > y; });
            //SortingAlgo<int>.BubbleSort(numbers, func);
            //foreach (int num in numbers)
            //    Console.WriteLine(num);


            //string[] Names = { "Omar", "Nada", "Ziad", "Amir", "Mona", "Yaml", "Samer", "Emad" };
            //CustomFun<string, string, bool> func = SortingTypes.CompareGrt;
            //SortingAlgo<string>.BubbleSort(Names, func);

            //foreach (string Name in Names)
            //{
            //    Console.WriteLine(Name);
            //}

            //List<int> numbers = Enumerable.Range(0, 100).ToList();
            //List<int> Odds = FindNumbers(numbers, ConditionFunc.IsOdd);
            //foreach (int num in Odds)
            //{
            //    Console.WriteLine(num);
            //}

            //List<int> numbers = Enumerable.Range(0, 100).ToList();
            //List<int> Odds = FindNumbers(numbers, ConditionFunc.IsEven);
            //foreach (int num in Odds)
            //{
            //    Console.WriteLine(num);
            //} 

            //List<int> numbers = Enumerable.Range(0, 100).ToList();
            //List<int> Odds = FindNumbers(numbers, ConditionFunc.IsDivisible);
            //foreach (int num in Odds)
            //{
            //    Console.WriteLine(num);
            //} 

            //Predicate<int> pre = SomeFunc.Test;
            //pre(10);
            //
            //
            //Func<int, string> func = SomeFunc.Cast;
            //func.Invoke(10);
            //
            //
            //Action<string> action = SomeFunc.Print;
            //action.Invoke("Samer");

            //Predicate<int> pre = delegate (int num) { return num > 0; };
            //pre.Invoke(10);
            //pre(10);
            //
            //
            //Func<int, string> func = delegate (int num) { return num.ToString(); };
            //func.Invoke(10);
            //func(10);
            //
            //
            //Action<string> action = delegate (string Name) { Console.WriteLine($"Hello {Name}"); }
            //action.Invoke("Samer"); 

            // '=>' Called as "FatArrow" and Read as "GoesTo"
            //Predicate<int> pre = num => num > 0;
            //pre.Invoke(10);
            //pre(10);
            //
            //
            //Func<int, string> func = num => num.ToString();
            //func.Invoke(10);
            //func(10);
            //
            //
            //Action<string> action = Name => Console.WriteLine($"Hello {Name}");
            //action.Invoke("Samer"); 

            // var keyword used for implicitly typed local variable [C# 2.0]
            //var Name = "Samer";
            //var x; //Invalid
            //Name = 22; //Invalid

            //var in C# 10.0
            //var pre = (int num) => num > 0;
            //pre.Invoke(10);
            //pre(10);
            //
            //
            //var func = (int num) => num.ToString();
            //func.Invoke(10);
            //func(10);
            //
            //
            //var action = (string Name) => Console.WriteLine($"Hello {Name}");
            //action.Invoke("Samer");

            //List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> OddNums = FindNumbers(nums, ConditionFunc.IsOdd);
            //List<int> OddNums = FindNumbers(nums, delegate (int Number) { return Number % 2 != 0; });
            //List<int> OddNums = FindNumbers(nums, (Number) => Number % 2 != 0);
            //List<int> OddNums = nums.FindAll(N => N % 2 != 0);
            //nums.Find(N => N % 2 != 0);
            //nums.FindLast(N => N % 2 != 0);
            //nums.Exists(x => x > 0);
            //nums.TrueForAll(x => x > 0);
            //nums.ForEach(Samer =>
            //{
            //    Samer += 10;
            //});
            //nums.Remove(10);
            //nums.RemoveAll(x => x % 2 ==0);
            //foreach (int num in OddNums)
            //{
            //    Console.WriteLine(num);
            //}

            //DelegateDoAction()(); 
            #endregion
        }
    }
}
