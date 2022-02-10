using CC_Exceptions_Lesson13;

class Program
{
    static void Main(string[] args)
    {
        #region Inner Exception

        try
        {
            A();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            //
        }

        #endregion

        #region throw Exception
        Car c = null;
        try
        {
            c = new Car(3,"",1990);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentDoorsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentColorException ex)
        {
            Console.WriteLine(ex.Message);
        }

        #endregion

        #region when keyword

        int[] myInts1;
        int[] myInts2 = null;
        int index = int.Parse(Console.ReadLine());//20
        try
        {
            myInts1 = new int[] { 1, 2, 3 };
            myInts2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int index4 = myInts1[index];
        }
        catch (IndexOutOfRangeException ex) when (index < myInts2.Length)
        {
            Console.WriteLine("try the another array (myInts2)");
        }
        catch (IndexOutOfRangeException ex) when (index < 15)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        #endregion

        CallToImportantMethod();
        #region Try-Catch
        //DivideByZeroException
        int num = 0;
        try
        {
            //Program p1 = null;
            //p1.GetType();

            num = 3;
            int y = 0;
            //y = 10;
            //if(y == 0)
            //{
            //    DivideByZeroException divExp = new DivideByZeroException("y = 0 is not allowed...");
            //    OnCatchDivideByZeroException(divExp);
            //}
            Console.WriteLine(num / y);
            Console.WriteLine("hello");

            DivideByZeroException argexc = new DivideByZeroException("Bla Bla Bla....");
            //argexc.Message => ""BLA BLA BLA....""

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("num = " + num);
            Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("argument null exception");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //NullException
        Program p = null;
        p = new Program();
        p.GetType();

        //IndexOutOfRange
        float[] myFloats = new float[5];
        int size = int.Parse(Console.ReadLine());
        for (int j = 0; j < 10; j++)
        {
            if (j < myFloats.Length)
                Console.WriteLine(myFloats[j]);
        }

        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        if (number2 == 0)
            number2 = 1;
        Console.WriteLine(number1 / number2);

        #endregion
    }

    //static void OnCatchDivideByZeroException(DivideByZeroException ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}

    static void CallToImportantMethod()
    {
        try
        {
            bool b = ImportantMethod("its your job....");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
        }
    }

    static bool ImportantMethod(string work)
    {
        bool response = false;

        try
        {
            BeforeWork("request....");
            int i = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("error");
        }
        finally
        {
            try
            {
                AfterWork(response);
                AfterWork(response);
                AfterWork(response);
            }
            catch (Exception)
            {
            }
            //return response;//Error
        }
        return response;
    }

    static void BeforeWork(string request)
    {
        //"C/:ProgramFiles/log.txt"
        Console.WriteLine($"the request is: { request}.");
    }

    static void AfterWork(bool res)
    {
        //"C/:ProgramFiles/log.txt"
        Console.WriteLine($"resposne is: {res}.");
    }

    static void A()
    {
        try
        {
            B();
        }
        catch (Exception exFromBMethod)
        {
            Exception cusExc3 = new Exception("some problem...", exFromBMethod);
            throw cusExc3;
        }
    }

    static void B()
    {
        try
        {
            C();
        }
        catch (Exception exFromCMethod)
        {
            Exception cusExc2 = new Exception("its index problem",exFromCMethod);
            throw cusExc2;
        }
    }

    static void C()
    {
        try
        {
            int[] array = new int[3];
            int i = array[10];
        }
        catch (Exception sysException)
        {
            Exception customException = new Exception("array is too short because is only with 3 items and the user try to get far away from this...",sysException);
            throw customException;
        }
    }
}
