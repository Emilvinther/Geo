using Geometry;

internal class Program
{
    static void Main(string[] args)
    {
        // Making new shape objects
        Shape sq = new Square(5,5);
        Shape re = new Rektangel(55, 103);
        Shape pa = new Paralleogram(33,21,120);
        Shape tr = new Trapez(45, 66, 33, 11);
        Shape tre = new Trekant(17, 55);
        
        // Making shape list
        List<Shape> shapelist = new List<Shape>();

        // Adding objects to list
        shapelist.Add(sq);
        shapelist.Add(re);
        shapelist.Add(pa);
        shapelist.Add(tr);
        shapelist.Add(tre);

        // Writes out List
        foreach ( Shape i in shapelist)
        {
            Console.WriteLine("\n");
            Console.WriteLine(i.GetType().Name);
            Console.WriteLine("Areal {0}",Math.Round(i.Perimiter(),2));
            Console.WriteLine("Omkreds: {0}",Math.Round(i.Area(),2));

        }
        


        Console.ReadKey();


    }


}
