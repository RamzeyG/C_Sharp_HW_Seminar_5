// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void GetArray(){
        
    int size = Convert.ToInt32(new Random().Next(0, 99));
    int[] array = new int[size];
    int count = 0;
    

    while (count < size){
        int random = new Random().Next(100, 1000);
        
        array[count] = random;
        count++;
    }
    Console.WriteLine();
    Console.WriteLine("Был созан массив: ");
    foreach (int i in array){
        Console.Write($"{i} ");
    }
    Console.WriteLine();
    Console.WriteLine();
    
    
    Console.WriteLine("Числа массива стоящие на нечетной позиции: ");
    int summ = 0;
    int count1 = 1;
    while (count1<size){
        Console.Write($"{array[count1]} ");
        summ = summ + array[count1];
        count1= count1 + 2;
    } 
    
    
    
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях равна {summ}");
    
}

GetArray();