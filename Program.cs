//Задача 21
//
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//
//A (3,6,8); B (2,1,-7), -> 15.84
//
//A (7,-5, 0); B (1,-1,9) -> 11.53
//
using System;
//
Point A1 = new Point(3,6,8);
Point B1 = new Point(2,1,-7);
Point A2 = new Point(7,-5, 0);
Point B2 = new Point(1,-1,9);
//
Vector I1 = new Vector(A1, B1);
Vector I2 = new Vector(A2, B2);
//
Console.WriteLine($"Lenght of I1 = {I1.Length(),0:f2}");
Console.WriteLine($"Lenght of I2 = {I2.Length(),0:f2}");
//
class Point
{
    private double x, y, z; 
    public Point()  {x = 0; y = 0; z = 0;}
    public Point(double X, double Y, double Z)  {x = X; y = Y; z = Z;}
    public double X(){return x;}
    public double Y(){return y;}
    public double Z(){return z;}
    public void SetX(double X){x = X;}
    public void SetY(double Y){y = Y;}
    public void SetZ(double Z){z = Z;}
}

class Vector:Point
{
    public Vector(Point From, Point To)
    {
        this.SetX(From.X() - To.X());
        this.SetY(From.Y() - To.Y());
        this.SetZ(From.Z() - To.Z());
    }
    public double Length()
    {
        return(Math.Sqrt(
                        Math.Pow(this.X(), 2) + 
                        Math.Pow(this.Y(), 2) + 
                        Math.Pow(this.Z(), 2)
                        ));        
    }
}
