Console.Write("input a quantity elements for array: " );
int element1 = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [element1];

void ShowArray(string[] stringArray)
{
 for (int i = 0; i < stringArray.Length; i++)
 {
  Console.Write($"input {i+1} a elements for array: ");
   stringArray[i] = Console.ReadLine();
  }
}
string[] element(string[] stringArray)
{
  int element2 = 0;
   for (int i = 0; i < stringArray.Length; i++)
   {
   if(stringArray[i].Length <=3)
    element2++;
   }
string[] temp = new string[element2];
int j = 0;
for (int i = 0; i < stringArray.Length; i++)
 {
    if(stringArray[i].Length <=3)
    {
     temp[j] = stringArray[i];
     j++;
     }
 }
     return temp; 
}
void print(string[] stringArray)
{
  Console.Write("[");
  for (int i = 0; i < stringArray.Length; i++)
   Console.Write($"{stringArray[i]},"); 
   Console.Write("]");
}
ShowArray(stringArray);
print(element(stringArray));
