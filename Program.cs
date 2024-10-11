Console.Write("What is a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("What is operation: ");
#pragma warning disable CS8600
string operation = Console.ReadLine();
#pragma warning restore CS8600 
Console.Write("What is b: ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (operation == "+") {
     sum = a + b;
}
else if (operation == "-") {
    sum = a - b;
}
else if (operation == "/") {
    sum = a / b;
}
else if (operation == "*") {
    sum = a * b;
}
else {
    Console.WriteLine("Enter following operations only +,-,*,/");
}
Console.WriteLine(sum);

Console.Write("What is ur number ");
int i = Convert.ToInt32(Console.ReadLine());
int total = 0;
while (i>0) {
    total = total + i;
    i--;
}
Console.WriteLine(total);

Console.Write("Write an integer: ");
int oe = Convert.ToInt32(Console.ReadLine());
if (oe%2 == 0) {

    Console.WriteLine("Your number is even");
}
else {
    Console.WriteLine("Your number is odd");
}
//123