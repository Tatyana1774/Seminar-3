/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
    int X = ReadInt("Введите координату Х точки А: ");
    int Y = ReadInt("Введите координату Y точки А: ");
    int Z = ReadInt("Введите координату Z точки А: ");

    int X1 = ReadInt("Введите координату Х точки B: ");
    int Y1 = ReadInt("Введите координату Y точки B: ");
    int Z1 = ReadInt("Введите координату Z точки B: ");

    int x = X1 - X;
    int y = Y1 - Y;
    int z = Z1 - Z;

    int d = ((x * x) + (y * y) + (z * z));

    double lenght = Math.Sqrt(d);
    Console.WriteLine($"Расстояние между точками = {lenght} ");

    int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }

