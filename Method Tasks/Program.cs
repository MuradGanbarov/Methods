//namespace MethodTasks
//{
//    class Programm
//    {
//        static void Main(string[] args)
//        {
//            // Display the number of command line arguments.
//            Console.WriteLine(PositiveNumber());
//        }
    

//    //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

//    //Console.WriteLine(Min(array));

//    //static int Min(int [] array)
//    //{
//    //    int first = array[0];
//    //    for (int i = 1; i < array.Length; i++)
//    //    {
//    //        if (first > array[i])
//    //        {
//    //            first = array[i];
//    //            //Bu min'dir. Eger biz deyishsek "first < array[i]", bu halda biz max tapiriq.
//    //        }
//    //    }
//    //    return first;
//    //}
//    // ================================================================================================
//    // TASK 2
//        //static int Area(int r)
//        //{
//        //    int p = 3;
//        //    int square = p * r * r;
//        //    return square;
//        //}

//        //static int Area(int a, int b)
//        //{
//        //    int square = a * b;
//        //    return square;
//        //}

//        //static int Area(int a, int b, int c)
//        //{
//        //    int square = 2 * ((a * b) + (a * c) + (b * c));
//        //    return square;
//        //}

//        //static int Area(int a, int b, int c, int r)
//        //{
//        //    int p = (a + b + c) / 2;
//        //    int square = p * r;
//        //    return square;
//        //}  
    
//        //TASK3
//        static int PositiveNumber(int summ) 
//        {
//            summ = 0;
//            int num = int.Parse(Console.ReadLine());
//            if (num <= 0)
//            {
//                Console.WriteLine("Please input number greater than 0");
//            }
//            if (num > 0)
//            {
//                summ = num % 10;
//                summ = (summ + 1) % 10;
//            }
//            if (num > 0 || num < 1000)
//            {
//            summ = (num % 1000)/100 + (num % 100)/10 + (num % 10);
//            }
//            return summ;
//        }
//    }
//}
            









