using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu salário:");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            decimal total = 0;
            decimal valorAumento = 0;  
            int porcento = 0;
            if(salario <= 1800)
porcento = 0.2M;

else if(salario <= 7000)
    porcento = 0.15M;

else if(salario <= 15000)
    porcento = 0.1M;

else
    porcento = 0.05M;

                valorAumento = porcento * salario;
                total = salario + valorAumento;

            Console.WriteLine($"Salário Base: R$ {string.Format("{0:0.00}", salario)}\nPercentual de aumento: {string.Format("{0:0.00}", porcento * 100)}%\nValor do aumento: R$ {string.Format("{0:0.00}", valorRealReajuste)}\nNovo Salário: R$ {string.Format("{0:0.00}", novoSalario)}");

                    }
    }
}
