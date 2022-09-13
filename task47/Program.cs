// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.WriteLine("Введите кол-во строк");
int rows = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов");
int columns = int.Parse(Console.ReadLine());

double [,] GetArray(int m, int n){
    double [,] result = new double [m, n];

    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().NextDouble() * 100;
        }
    }
    return result;
}
double[,] arr = GetArray(3, 4);
for (int i =0; i < rows; i++){
    for (int j =0; j < columns; j++){
        System.Console.WriteLine($"{arr[i, j]} ");
    }
    System.Console.WriteLine();
}