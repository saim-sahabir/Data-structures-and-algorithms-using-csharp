
//array sort 
 
  int [] randomNumbers = new []{22,23,33,4,2,234,4,4,55,4};

var result = RemoveDuplicates(ArraySort(randomNumbers)) ;

foreach (var item in result)
{
    Console.WriteLine(item);
}

    int[] ArraySort(int[] numbers)
    {
        int temp;
         for (int i = 0; i < numbers.Length; i++)
         {
             for (int j = 0; j < numbers.Length; j++)
             {
                 if (numbers[i] < numbers[j])
                 {
                     temp = numbers[j];
                     numbers[j] = numbers[i];
                     numbers[i] = temp;
                 }
             }
         }

         return numbers;
     }
     
   /// remove duplicates element numbers

    int[] RemoveDuplicates(int [] numbers)
    { 
        int dupCount = 0;
        int[] unDuplicateNumbers = new int [numbers.Length - dupCount];
       
        for (int i = 0; i < numbers.Length; i++)
        {
             if (!unDuplicateNumbers.Contains(numbers[i]))
             {
                 unDuplicateNumbers[i] = numbers[i]; 
                 Console.WriteLine(numbers[i]);
             }
             else
             {
                  dupCount++;
             }
            
        }

        Console.WriteLine($" your duplicates number :{dupCount}");
        
        return unDuplicateNumbers;
    }