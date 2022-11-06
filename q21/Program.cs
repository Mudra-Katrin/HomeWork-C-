// Напишите программу,которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве
using System;
 
class GFG
{
     
static void distance(float x1, float y1,
                     float z1, float x2,
                     float y2, float z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.WriteLine("Distance is " + d);
    return;
}
 
// Driver code
public static void Main()
{
    float x1 = 3;
    float y1 = 6;
    float z1 = 8;
    float x2 = 2;
    float y2 = 1;
    float z2 = -7;
     
    // function call
    // for distance
    distance(x1, y1, z1,
             x2, y2, z2);
}
}
 



