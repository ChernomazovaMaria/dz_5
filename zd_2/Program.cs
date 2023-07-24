// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечетными индексами.
Console.WriteLine("Введите случайные числа");
int[] a= new int[4];
int sum=0;
for (int i=0; i<a.Length; i++){
    a[i]=Convert.ToInt32(Console.ReadLine());
    if (i%2!=0) {
        sum=sum+a[i];
    }
}
Console.WriteLine("Сумма элементов с нечетными индексами равна {0}",sum);
    
        
        
        
    

