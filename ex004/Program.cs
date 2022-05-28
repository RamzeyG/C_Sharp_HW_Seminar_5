// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


void GetArray(){
        
    int size = Convert.ToInt32(new Random().Next(0, 99));
    
    double[] array = new double[size];
    int count = 0;
    

    while (count < size){
        Random x = new Random();
        double random = Convert.ToDouble(x.Next(1, 100)/10.00);
        
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
    
    int count1 = 0;
    int count2 = size-1;

    int countPosition = 0;
    double[] ProductOfNumbers = new double[size/2];
    while(countPosition<size/2){
        if (count1 == count2){
            Console.WriteLine($"Число {array[count1]} не имеет пары");
        }
        else{
            double x = Math.Round((array[count1] * array[count2]), 4);
            Console.WriteLine($" {array[count1]} * {array[count2]} = {x}");
            ProductOfNumbers[countPosition] = x;
            count1++;
            count2--;
            countPosition++;
        }
        
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("массив произведений: ");
    foreach (double i in ProductOfNumbers){
        Console.Write($"{i} ");
    }
    
    
    
    //Console.WriteLine($" Наибольшее число массива равно {array[countMax]}");
    //Console.WriteLine($" Наименьшее число массива равно {array[countMin]}");
    //Console.WriteLine($" Разница между максимальным и минимальным элементом массива:");
    //Console.WriteLine($"{array[countMax]} - {array[countMin]} = {array[countMax] - array[countMin]}");
    
}

GetArray();


