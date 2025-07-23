// O propósito desse arquivo é fazer os exercicíos de lógica de programação, seja no leetcode, edabit, qualquer coisa

/*int inches = 12;
int feet = 36;
int inchesFeet = feet / inches;

Console.WriteLine(inchesFeet);

//

bool reverse = true;

if (reverse == true)
{
    reverse = false;
    Console.WriteLine("Reverse agora é " + reverse + " pq caiu no if");
}
else
{
    
    reverse = true;
    Console.WriteLine("Reverse agora é " +reverse +" pq caiu no else");
}
*/

//Create a function which returns the number of true values there are in an array.
/*
 * i did with int, but you can do with boolean, string, whatever you want

int[] var = new int[] { -1, 10, -8, 2,4,5, -6,-2};
int total = 0;
if (var.Length == 0)
{
    Console.WriteLine(total);
    
    return;
}
else
{

    for (int i = 0; i < var.Length; i++)
    {
        if (var[i] < 0 )
        {
            total++;

        }

    }
    Console.WriteLine(total);

}
*/


//Create a function that takes a string and returns the number (count) of vowels contained within it.
/*
string word = "DaniEl";
int count = 0;
string vowels = "aeiouAEIOU"; 

for ( int i = 0; i < word.Length; i++)
{
    if(vowels.Contains(word[i]))
    {
        count++;
        
    }
}
Console.WriteLine("Total vowels: " + count);
*/

//Create a function that takes three integer arguments (a, b, c) and returns the amount of integers which are of equal value.
/*
int a, b, c;
a = 3;
b = 4;
c = 1;

if(a == b && b == c)
{
    Console.WriteLine(3);
}
else if (a == b || a == c || b == c)
{
    Console.WriteLine(2);
}
else
{
    Console.WriteLine(0);
}
*/

//Create a function that takes a string and returns a new string with all vowels removed.
/*
string word = "Eu peidei melado hoje o dia inteiro";
string vowels = "aeiouAEIOU";

for (int i = 0; i < word.Length; i++)
{
    if (vowels.Contains(word[i]))
    {
        word = word.Remove(i, 1);
        i--; 
        
    }
}
Console.WriteLine(word);
*/



//Write a function that takes a string name and a number num (either 0 or 1) and return "Hello"
//+ name if num is 1, otherwise return "Bye" + name.
/*
string name = "daniel";
int number = 1;
if (number == 1)
{
    Console.WriteLine($"Olá,{name}");
}
else if (number == 0){
    Console.WriteLine($"Tchau,{name}");
}
else
{
    Console.WriteLine("Numero diferente de 0 ou 1");
}

*/
//Create a function that repeats each character in a string n times.
 /*
string word = "Raissa";
int n = 5;
string saida = "";

foreach (char c in word)
{
    for (int i = 0; i < n; i++)
    {
        saida = saida + c;
    }
}

Console.WriteLine(saida);

*/


