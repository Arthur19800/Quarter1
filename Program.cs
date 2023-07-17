Console.WriteLine("Задача : Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. ");
Console.Write("input array size m: ");
int m;

string [] ModifyArray(string [] array)
{
         
       int index = 0;
       int count = 0;
       
    for(int i = 0;i < array.Length; i++){
        if(array[i].Length <= 3){
          count++;
        }
    }
     
        string [] modifiedArray = new string [count];
    for(int i = 0;i < array.Length; i++){
        
        if(array[i].Length <= 3){
            modifiedArray[index] =array[i]; 
           index++;
        }
    }  
      return modifiedArray;
}
do
{
    m = Convert.ToInt32(Console.ReadLine()); 
    if  (m == 0) Console.WriteLine("Wrong array size");
    else Console.WriteLine("Correct array size! Input array elememts: ");
} while (m == 0);

string [] array = new string [m];
    for(int i = 0;i < array.Length; i++){
            array[i] =Console.ReadLine()!; 
    }
Console.WriteLine();
string [] newModifiedArray = ModifyArray(array);