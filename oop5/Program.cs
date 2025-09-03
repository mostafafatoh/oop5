namespace oop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empolyee e1 = new Empolyee();
            e1.name = "ahmed";
            e1.Id = 12;
            Empolyee e2 = new Empolyee();
            e2.name = "sasa";
            e2.Id = 24;
            e1.Display();
            e2.Display();
            int x = Mathehelper.Fact(4);
            x = Mathehelper.Fact(4);
            Empolyee.FilePath = "";
        }
    }
}
