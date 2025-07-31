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
//Write a function that takes the last number of a consecutive list
//of numbers and returns the total of all numbers up to and including it.
/*
int n = 3;
int soma = 0;

for (int i = 0; i < n; i++)
{
    soma = soma + i;
    soma++;
    

}
Console.WriteLine(soma);
*/


//Create a function that takes an array and returns the sum of all numbers in the array.

/*
int[] array = new int[] {-2,84,23};
int soma = 0;

for (int i = 0; i < array.Length; i++)
{
    soma = soma + array[i];
}
Console.WriteLine(soma);
*/

//Given two arrays, which represent two sandwiches, return whether both sandwiches use the same type of bread.
//The bread will always be found at the start and end of the array.
//examples

/*hasSameBread(
  ["white bread", "lettuce", "white bread"],
  ["white bread", "tomato", "white bread"]
) ➞ true

hasSameBread(
  ["brown bread", "chicken", "brown bread"],
  ["white bread", "chicken", "white bread"]
) ➞ false

hasSameBread(
  ["toast", "cheese", "toast"],
  ["brown bread", "cheese", "toast"]
) ➞ falsehasSameBread(
  ["white bread", "lettuce", "white bread"],
  ["white bread", "tomato", "white bread"]
) ➞ true

hasSameBread(
  ["brown bread", "chicken", "brown bread"],
  ["white bread", "chicken", "white bread"]
) ➞ false

hasSameBread(
  ["toast", "cheese", "toast"],
  ["brown bread", "cheese", "toast"]
) ➞ false

*/
/*
string [] array1 = new string[] { "brown bread", "chicken", "brown bread" };
string [] array2 = new string[] { "white bread", "chicken", "white bread" };
bool var = true;
if (array1[0] != array2[0] || array1[2] != array2 [2])
{
    var = false;
    Console.WriteLine(var);

}
else
{
    Console.WriteLine(var);
}
*/

// Create a function that takes two numbers and a mathematical operator and returns the result.
/*
int num1 = 25; 
int num2 = 5;
int soma = 0;
string op = "/";

if (op == "*")
{
    soma = num1 * num2;
    Console.WriteLine(soma);
}
else if (op == "-")
{
    soma = num1 - num2;
    Console.WriteLine(soma);
}
else if (op == "+")
{
    soma = num1 + num2;
    Console.WriteLine(soma);
}
else if (op == "/")
{
    soma = num1 / num2;
    Console.WriteLine(soma);
}
*/


//Create a function to multiply all of the values in an array by the amount of values in the given array.
/*
int arraySize = 4;

int [] array = new int[] { 2, 3, 1, 0 };

for (int i = 0; i < array.Length; i++)
{
    array[i] = arraySize * array[i];
  
}

Console.WriteLine(array);
*/

//Create a function which returns the number of true values there are in an array. 
// idk if i already did this exercise, but im gonna do bcz i think its a good one

/*
bool[] array = new bool[] { true, true, false, true, true };
int numero = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == true)
    {
        numero++;
    }
   

}
Console.WriteLine(numero);
*/

/* A decimal number can be represented as a sequence of bits. To illustrate:

using System.ComponentModel;

6 = 00000110
23 = 00010111
From the bitwise representation of numbers, we can calculate the bitwise AND, bitwise OR and bitwise XOR. Using the example above:

bitwiseAND(6, 23) ➞ 00000110

bitwiseOR(6, 23) ➞ 00010111

bitwiseXOR(6, 23) ➞ 00010001
Write three functions to calculate the bitwise AND, bitwise OR and bitwise XOR of two numbers.

Examples
bitwiseAND(7, 12) ➞ 4

bitwiseOR(7, 12) ➞ 15

bitwiseXOR(7, 12) ➞ 11

esse é um exercicio muito bom

26/07 -- nao consegui fazer

*/


/*
 * Create a function that takes two numbers as arguments
 * (num, length) and returns an array of multiples of num until the array length reaches length.
 * arrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]

arrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]

*/
/*
int num = 7;
int[] array = new int[5];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    sum = num * (i + 1);
    array[i] = sum;
}
Console.WriteLine(string.Join(", ", array)); // system 32

*/
//Create a function that counts the integer's number of digits.
/*
string numero = "-314890";
string total = "";
int soma;
for ( int i = 0;  i < numero.Length; i++)
{
    total = total + numero[i];
  
    
}
Console.WriteLine(total.Length);
*/
//Create a function that takes an array of numbers nums as an argument. Square each number in the array if the number is even and square root √ the number if it is odd.
//Return the sum of the new array rounded to two decimal places.


/*
        ESSE DAQUI EU CURTI
double[] array = new double[5] {1,31,3,11,0 };
double soma = 0;
double totalPar = 0;
double totalImpar = 0;
double total = 0;


for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        soma = (array[i] * array[i]);
        totalPar += soma;
    }
    else
    {
        totalImpar += Math.Sqrt(array[i]);
        total = totalPar + totalImpar;
    }
    
}
Console.WriteLine(total);
*/

//Create a function that takes two number strings and returns their sum as a string.
/*
string primeiroValorString = "";
int primeiroInt = int.Parse(primeiroValorString);

string segundoValorString = "80";
int segundoInt = int.Parse(segundoValorString);

int total = primeiroInt + segundoInt;
Console.WriteLine(total);
*/


//Given an array of boxes, create a function that returns the total volume of all those boxes combined together.
//A box is represented by an array with three elements: length, width and height.



/*
int[] length = new int[3] { 4, 2, 4 };
int[] width = new int[3] {3, 3, 3 };
int[] height = new int[3] { 1, 2, 1 };

int sumLenght1 = 0;
int sumLenght2 = 0;
int sumLenght3 = 0;
int totalLenght = 0;

int totalWidth = 0;
int sumWidth1 = 0;
int sumWidth2 = 0;
int sumWidth3 = 0;

int sumHeight1 = 0;
int sumHeight2 = 0;
int sumHeight3 = 0;
int totalHeight = 0;







for (int i = 0;  i < length.Length;  i++)
{
    sumLenght1 = length[0];
    sumLenght2 = length[1];
    sumLenght3 = length[2];
    
    totalLenght = sumLenght1 * sumLenght2 * sumLenght3;
}
for (int i = 0;i < width.Length; i++)
{
    sumWidth1 = width[0];
    sumWidth2 = width[1];
    sumWidth3 = width[2];

    totalWidth = sumWidth1 * sumWidth2 * sumWidth3;

}
for (int i = 0; i < height.Length; i++)
{
    sumHeight1 = height[0];
    sumHeight2 = height[1];
    sumHeight3 = height[2];

    totalHeight = sumHeight1 * sumHeight2 * sumHeight3;


}

Console.WriteLine($"Valor de lenght: {totalLenght} ");
Console.WriteLine($"Valor de lenght: {totalWidth} ");
Console.WriteLine($"Valor de lenght: {totalHeight} ");

int totalSoma = totalLenght + totalWidth + totalHeight;

Console.WriteLine($"Total: {totalSoma}");


*/

//Write a function that finds the sum of an array. Make your function recursive.
/*
int[] array = new int[2 ] { 1, 2 };
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
Console.WriteLine(sum);

*/

//Create a function that takes an array of numbers and returns the mean (average) of all those numbers.
/*
double[] array = new double[] { 2, 3, 2, 3 };
double sum = 0;
double avg = 0;

for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
    avg = sum / array.Length;
}



Console.WriteLine(avg);
*/


