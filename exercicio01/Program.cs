using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis.
            decimal nota1 = 0;
            decimal nota2 = 0;
            decimal media = 0;
            //pedido de entrada para o usuário.
            Console.WriteLine("Digite a primeira nota:");
            //leitura da nota digitada e sua conversão para decimal.
nota1 = Convert.ToDecimal(Console.ReadLine());
//pedido de entrada para o usuário.
Console.WriteLine("Digite a segunda nota:");
//leitura da nota e sua conversão para decimal.
nota2 = Convert.ToDecimal(Console.ReadLine());
//calcula a média e armazena na variável resultado.
media = (nota1 + nota2) / 2;
if(media == 10){
Console.WriteLine("Aprovado com Distinção");
}       
else if(media >= 7){
Console.WriteLine("Aprovado");
}else{
Console.WriteLine("Reprovado");
}

        }
    }
}
