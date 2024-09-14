/* Clases
var rect = new rectangulo();
rect.Base = 20;
rect.Altura = 40;
Console.WriteLine($"El are es: {rec.Area()}" );
Console.WriteLine($"El perimetro es: {rec.Perimetre()}" );
*/


var cuadr = new Cuadrado(){
    cuadr.Base = 20;
    cuadr.Altura = 40;
    Console.WriteLine($"El area es: {rec.Area()}" );
    Console.WriteLine($"El perimetro es: {rec.Perimetre()}" );
    Console.WriteLine($"El lado es: {cuadr.Lado()}" );
}


class Rectangulo {

    public double Base {get; set;}

    public double Altura() {get; set;}

    public double Area() = Base * Altura;

    public double Parametro() => 2* Base + 2 *Altura;

}


class Cuadrado {

    public double lado{

    get {Base=value; Altura=value; }

    get {return Base;}

    }
}


