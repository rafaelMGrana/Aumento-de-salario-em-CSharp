using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double salario = 0;
            double salarioAumento = 0;
            double salarioFinal = 0;

            
            Console.Write("Entre com o salario do funcionario : ");
            salario = double.Parse(Console.ReadLine()); 

            
            Console.Write("Salário inicial é de : " + salario + "\n");

            
            salarioAumento = salario + (salario * 0.15);
            Console.Write("Salário com aumento é de : " + salarioAumento + "\n");  

            
            salarioFinal = salarioAumento - (salarioAumento * 0.08);
            Console.Write("Salário final é de : " + salarioFinal + "\n");   

            
            Console.ReadKey();




        }
    }
}