// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Напишите программу, которая будет создавать копию заданного 2-мерного массива с помощью поэлементного копирования.
double [] getCoord (double b1, double k1, double b2, double k2)
{
    double [] coord = new double [2];
    coord[0] = (b2-b1)/(k1-k2);
    coord[1] = k1*coord[0] + b1;


    return coord;
}
double [] coord = getCoord(25,12,2,6);
Console.WriteLine($"Координаты точки пересечения X = {coord[0]}, Y = {coord[1]}");