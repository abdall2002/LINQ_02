delegate void MDelegate();
//delegate void MDelegate();
//Action, Func, Pred
internal class Program
{
    static void Main(string[] args)
    {
        //M2(M1);
        Action action = M1;
        M2(action);
    }
    static void M1()
    {
        Console.WriteLine("M1");
    }
    //static void M2(MDelegate mDel)
    //{
    //    mDel();
    //    Console.WriteLine("M2");
    //}
    static void M2(Action action)
    {
        action();
        Console.WriteLine("M2");
    }
}
