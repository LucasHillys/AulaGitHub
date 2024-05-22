using Deposito;

internal class Program
{
    private static void Main(string[] args)
    {
        double dep = 0;
        Console.Write("Entre o número da conta: ");
        int conta = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string nome = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)? ");
        char sn = char.Parse(Console.ReadLine());

        if (sn == 's') 
        {
            Console.Write("Entre o valor e depósito inicial: ");
            dep = double.Parse(Console.ReadLine());
        }
        Banco banco = new Banco(conta, nome, dep);

        Console.WriteLine(banco);
        Console.WriteLine();

        Console.WriteLine("Escolha a operação a ser feita: ");
        Console.WriteLine("[1] Depósito");
        Console.WriteLine("[2] Saque");
        Console.WriteLine("[0] Sair");
        Console.Write("Opção: ");
        int op = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (op == 1 || op == 2)
        {
            
            if (op == 1)
            {
                Console.Write("Entre um valor para depósito: ");
                dep = double.Parse(Console.ReadLine());
                banco.Deposito(dep);
                Console.WriteLine("Dados atualizados: ");
                Console.WriteLine(banco);
                Console.WriteLine();
            }

            else if (op == 2)

            {
                Console.Write("Entre um valor parra saque: ");
                dep = double.Parse(Console.ReadLine());
                banco.Saque(dep);
                Console.WriteLine("Dados atualizados: ");
                Console.WriteLine(banco);
            }

            Console.WriteLine("Escolha a operação a ser feita: ");
            Console.WriteLine("[1] Depósito");
            Console.WriteLine("[2] Saque");
            Console.WriteLine("[0] Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine();

        }

        Console.WriteLine("Encerrando atendimento...");
        Console.WriteLine();
        Console.WriteLine("Atendimento encerrado.");


    }

}