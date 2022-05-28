// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


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
    
    
    Console.WriteLine("Четные числа массива: ");
    int CountEvenNumber = 0;
    foreach (int i in array){
        
        if (i%2 == 0){
            CountEvenNumber ++;  
            Console.Write($"{i} ");
        }
    
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных элементов массива равно {CountEvenNumber}");
    
}

GetArray();

