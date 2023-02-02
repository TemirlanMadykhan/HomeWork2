// Random random = new Random();
// int min = 100;
// int max = 999;
// int number = random.Next(min, max + 1);
// Console.WriteLine(number);
// int a = number / 10;
// int b = number % 10;
// Console.WriteLine(b);

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
