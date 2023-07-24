// Задайте массив вещественных чисел. Найдите разницу между максимальными и минимальными элементами массива
Console.WriteLine("Введите вещественные числа");
double[] a= new double[4];
for (int i=0; i<a.Length; i++){
    a[i]=Convert.ToDouble(Console.ReadLine());
}
double min=a[0];
double max=a[0];
for (int i = 0; i<a.Length; i++) {
    if (a[i]>max){
        max=a[i];
    }
    if (a[i] < min){
        min=a[i];
    }
}
double raz=max-min;
Console.WriteLine("Разница между максимальным и минимальным значением равна {0}", raz);
    