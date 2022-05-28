// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void GetArray(){
        
    int size = Convert.ToInt32(new Random().Next(0, 99));
    double[] array = new double[size];
    int count = 0;
    

    while (count < size){
        Random x = new Random();
        double random = Convert.ToDouble(x.Next(1, 1000)/10.00);
        
        array[count] = random;
        count++;
    }
    Console.WriteLine();
    Console.WriteLine("Был созан массив: ");
    foreach (double i in array){
        Console.Write($"{i} ");
    }
    Console.WriteLine();
    Console.WriteLine();
    
    int countMax = 0;
    int countMin = 0;
    int countPosition = 0;
    while(countPosition<size){
        if (array[countMax] < array[countPosition]){
            countMax = countPosition;
        }
        if (array[countMin] > array[countPosition]){
            countMin = countPosition;
        }
        countPosition++;
    }
     
    
    
    
    Console.WriteLine();
    Console.WriteLine($" Наибольшее число массива равно {array[countMax]}");
    Console.WriteLine($" Наименьшее число массива равно {array[countMin]}");
    
}

GetArray();

