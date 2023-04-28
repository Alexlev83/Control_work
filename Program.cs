Console.Write("input a elements for array: " );
int element = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [element];

void ShowArray(string [] stringArray)
{
for (int i = 0; i < stringArray.Length; i++)
 Console.Write($"input {i+1} a elements for array: ");
 stringArray[i] = Console.ReadLine();
}