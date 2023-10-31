// See https://aka.ms/new-console-template for more information





double deposit = 100_000;

double rate = 0.06;

for (int year = 1; year <= 25; year++)
{
    Console.WriteLine($"{year}\t{deposit:C2}");
    double sum = deposit * rate;
    deposit = sum + deposit;

    Console.WriteLine(deposit);
}




































