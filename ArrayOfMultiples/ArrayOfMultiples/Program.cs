//Create a function that takes two numbers as arguments (num, length)
//and returns an array of multiples of num until the array length reaches length.
Random random = new Random();
int lenght, num;
lenght = 5;
num = 7;
int[] randomNumbers = new int[lenght];

randomNumbers = new int[num];
for (int i= 0; i < lenght; i++)
{
    randomNumbers[i] = random.Next(num, 35 );
    
}
foreach (int number in randomNumbers)
{
    Console.WriteLine(number);
}
