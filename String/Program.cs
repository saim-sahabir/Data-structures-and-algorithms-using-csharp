
       ///////////////////////////////////////////////////////////////////////////////////////////////////////
       // Smallest distinct window string related problem in  (Geeksforgeeks)                               //
       // link: https://practice.geeksforgeeks.org/problems/smallest-distant-window3132/1#                  //
       ///////////////////////////////////////////////////////////////////////////////////////////////////////
       
       var result = findSubString("AABBBCBBAC");
       Console.WriteLine(result);
       
          int findSubString(string str)
          {
              var chars = str.ToCharArray();
              int smallest = 0;
              for(int i = 0; i < chars.Length; i++)
              { 
                 int count = 1;
               for(int j = 0; j < chars.Length; j++)
               {
                   if(chars[i] == chars[j] && chars[i] != ' ')
                   {
                       count++;
                       chars[j] = '0';
                   }
                  
                   
               }

               if (count > 1 && chars[i] != '0')
               {
                   smallest++;
               }  
                    
           }
             
             
           return  smallest;
       }