namespace AluguelQuartos {
    internal class Program {
        static void Main(string[] args) {

            Estudante[] vet = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
             

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite seu email: ");
                string email = Console.ReadLine();

                Console.Write("Qual quarto deseja? ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0;i < 10;i++) { 
                if (vet[i] != null) {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            
            }

        }
    }
}