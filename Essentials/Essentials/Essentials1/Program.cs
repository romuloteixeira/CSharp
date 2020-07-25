namespace Essentials1
{
    class Program
    {
        static void Main(string[] args)
        {
            StructVsClass.Run();
            Finalizers.Run();
            //var thirdClassFinalizer = new ThirdClassFinalizer();
            var finalizer2 = new Finalizer2();
            finalizer2.ShowDuration();

            ExampleClass ex = new ExampleClass();
            ex.ShowDuration();
        }
    }
}
