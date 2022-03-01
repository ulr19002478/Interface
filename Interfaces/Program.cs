using Interfaces;
//finding area of triangle using interfaces
Triangle tri = new Triangle(20,20);
Console.WriteLine(tri.Area());

//finding area of square using interfaces
Square sq = new Square(20, 20);
Console.WriteLine(sq.Area());

List<IShape> shapes = new List<IShape>();
shapes.Add(sq);
shapes.Add(tri);