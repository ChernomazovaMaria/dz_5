// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.
Console.WriteLine("Введите положительные трехзначные числа");
int[] a= new int [4];
int chet=0;
for (int i=0; i<a.Length; i++){
    a[i]=Convert.ToInt32(Console.ReadLine());
    if (a[i]%2==0) {
        chet++;
    }
}
Console.WriteLine("{0} четных числа", chet);
