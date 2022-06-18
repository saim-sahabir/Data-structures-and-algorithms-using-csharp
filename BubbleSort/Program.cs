// See https://aka.ms/new-console-template for more information

namespace DSA_in_Csherp
{
    public class BubbleSortAlgorithm
    {
        
        public static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            int[] randomNumbers = new int[] { 55, 33, 24, 51, 2, 3, 124, 45, 1, 3, 4, };

             var result = BubbleSort(randomNumbers);
             foreach (var item in result)
             {
                 Console.WriteLine(item);
             }
            
             int[] BubbleSort( int [] numbers)
             {
                 int temp;
                 for (int i = 0; i < numbers.Length; i++)
                 {
                      
                     for (int j = 0; j < numbers.Length-1; j++)
                     {
                         if (numbers[j] > numbers[j+1])
                         {
                             temp = numbers[j];
                             numbers[j] = numbers[j + 1];
                             numbers[j + 1] = temp;
                             
                         }
                     }
                     
                    
                     
                 }
                 

                 return numbers;
             }
             
             watch.Stop();
             Console.WriteLine($"Run Time:{watch.ElapsedMilliseconds} ms"); 
        }
       
        
    }
}