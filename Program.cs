using cursoUdemmy3;
using System.Globalization;
{
    pessoa a, b;

    a = new pessoa();
    b = new pessoa();

    Console.Write("Qual o nome da primeira pessoa ?");
    a.Nome =Console.ReadLine();
   
    Console.Write("Qual a idade da primeira pessoa ?");
    a.Idade = int.Parse(Console.ReadLine());

    Console.Write("Qual o nome da segunda pessoa ?");
    b.Nome =Console.ReadLine();
  
    Console.Write("Qual a idade da segunda pessoa ?");
    b.Idade = int.Parse(Console.ReadLine());    
    Console.ReadLine();

    if (a.Idade > b.Idade)
    {
        Console.WriteLine("Mais velho : Maria");
    }
    else
    {
        Console.WriteLine("Maior àrea : João ");
    }
}