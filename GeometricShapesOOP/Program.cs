using GeometricShapesOOP;

var quad1 = new Quad(3, 4, 5, 6);
Console.WriteLine($"Quad1 Perimeter: {quad1.Perimeter()}");

var rect1 = new Rect(3, 5);
Console.WriteLine($"Rect1 Perimeter: {rect1.Perimeter()}");
Console.WriteLine($"Rect1 Area: {rect1.Area()}");

var square1 = new Square(5);
Console.WriteLine($"Square1 Perimeter: {square1.Perimeter()}");
Console.WriteLine($"Square1 Area: {square1.Area()}");