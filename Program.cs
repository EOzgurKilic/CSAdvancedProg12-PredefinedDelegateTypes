namespace CPPPPAdvancedProgramming12;

class Program
{
    static void Main(string[] args)
    {
        //Predefined Delegates


        //Action delegate
        //In short, it s a predefined delegate that can represent void methods with no parameters.
        //There is a generic version of it (Action<T>) that can represent void methods with generic parameters
        Action ActionDelegate = new Action(MethodForAction);
        Action<int> ActionGenDelegate1 = new Action<int>(MethodForAction1);
        Action<int, int, int> ActionGenDelegate2 = new Action<int, int, int>(MethodForAction2);
        ActionDelegate();
        ActionGenDelegate1(1);
        ActionGenDelegate2(1, 1, 1);

        void MethodForAction()
        {
            Console.WriteLine("Action Method!");
        }

        void MethodForAction1<t1>(t1 a)
        {
            Console.WriteLine("Action Method with 1 generic parameter!");
        }

        void MethodForAction2<t1, t2, t3>(t1 a, t2 b, t3 c)
        {
            Console.WriteLine("Action Method with 3 generic parameters!");
        }


        //Func delegate
        //For generic and return type methods.
        //Its last generic argument must be the return type of the method.
        Func<string, string, int> FuncDelegator = new Func<string, string, int>(MethodForFunc<string, string, int>);
        Console.WriteLine(FuncDelegator("a", "b"));
        int MethodForFunc<t1, t2, t3>(t1 a, t2 b)
        {
            return 5;
        }
        //A funct delegator returning a tuple type;
        Func<string, (int, string)> FuncDelegator1 = new Func<string, (int, string)>(MethodForFunc1<string, (int, string)>);
        Console.WriteLine(FuncDelegator1("Anan"));
        (int, string) MethodForFunc1<t1, t2>(t1 a)
        {
            if (a is string x)
                return (5, x);
            return (5, "0");
        }


        //Predicate Delegator
        //Can represent methods with a single generic parameter that return boolean type values.
        Predicate<int> PredicateDelegator = new Predicate<int>(MethodForPredicate<int>);
        bool MethodForPredicate<t1>(t1 a)
        {
            return true;
        }
    }
}