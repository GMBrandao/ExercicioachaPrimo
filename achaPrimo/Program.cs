internal class Program
{
    private static void Main(string[] args)
    {
        double primo;
        int count, aux = 0;

        Console.WriteLine("Digite um número:");
        primo = double.Parse(Console.ReadLine());

        for(count = 1; count <= (primo/2); count++)
        {
            if (primo % count == 0)
                aux++;
            if (aux == 2)
                break;
        }

        if (primo != 1)
        {
            if(aux == 1)
                Console.WriteLine("O número "+ primo + " é primo.");
            else
                Console.WriteLine("O número " + primo + " não é primo.");
        }
        else
            Console.WriteLine("1 é uma exceção na regra dos primos");
    }
}