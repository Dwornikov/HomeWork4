Console.Clear();
System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите квадрат числа");
int b = Convert.ToInt32(Console.ReadLine());
int i = 2;
int c = a;
while(i<=b){
    c=c*a;
    i++;
}
System.Console.WriteLine($"Результат {c}");