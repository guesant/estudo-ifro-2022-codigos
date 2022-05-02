using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplo5.RegrasDeNegocio
{
    internal class CalculadoraDeValores
    { // INÍCIO Classe
        //atributos
        private double valor1; 
        private double valor2;
        private double total;

        //métodos 

        public double SomaDeValores(double v1, double v2)
        {
            valor1 = v1; 
            valor2 = v2;
            total = valor1 + valor2;
            return total;
        }

        public double SubtracaoDeValores(double v1, double v2)
        {
            valor1 = v1;
            valor2 = v2; 
            total = valor1 - valor2;
            return total;
        }

        // 1 - Criar o método MultiplicacaoDeValores       
        public double MultiplicacaoDeValores(double v1, double v2)
        {
            valor1 = v1;
            valor2 = v2;
            total = valor1 * valor2;
            return total;
        }

        // 2 - Criar o método DividirValores
        public double DividirValores(double v1, double v2)
        {
            valor1 = v1;
            valor2 = v2;
            total = valor1 / valor2;
            return total;
        }

        // 3 - Criar o método CalcularRaizQuadrada
        public double CalcularRaizQuadrada(double v1)
        {
            valor1 = v1;
            total = Math.Sqrt(v1);
            return total;
        }

        // 4 - Criar o método CalcularPotencia
        public double CalcularPotencia(double v1, double v2)
        {
            valor1 = v1;
            valor2 = v2;
            total = Math.Pow(v1, v2);
            return total;
        }

        // 5  - Criar o método CalcularFatorial
        public double CalcularFatorial(int v1)
        {
            valor1 = v1;

            // começamos com o número 1.
            int resultado = 1;

            // vamos multiplicando o resultado por (v1; v1 - 1; ...; 2).
            for(int i = v1; i > 1; i--)
            {
                resultado *= i;
            }

            total = resultado;

            return total;
        }


        // 6 - Criar o método CalcularDescontoDaCompra
        public double CalcularDescontoDaCompra(double valor, double desconto)
        {
            total = valor * (1 - desconto / 100);
            return total;
        }

        // 7 - Criar o método AumentarSalario
        public double AumentarSalario(double salarioAtual, double aumento)
        {
            total = salarioAtual * (1 + aumento / 100);
            return total;
        }

        // 8 - Criar o método CalcularAreaDoRetangulo
        public double CalcularAreaDoRetangulo(int largura, int altura)
        {
            valor1 = largura;
            valor2 = altura;
            total = largura * altura;
            return total;
        }

        // 9 - Criar o método VerificarTriangulo

        public string VerificarTriangulo(int a, int b, int c)
        {
            // Fonte: https://mundoeducacao.uol.com.br/matematica/condicao-existencia-um-triangulo.htm
            if (
                Math.Abs(b - c) < a && a < (b + c) &&
                Math.Abs(a - c) < b && a < (a + c) &&
                Math.Abs(a - b) < c && a < (a + b) 
                ) {
                // Triângulo é Válido

                if (a == b && b == c && a == c)
                {
                    return "Triângulo Equilátero";
                }

                if (
                    (a == b && a != c) ||
                    (a == c && a != b) ||
                    (b == c && b != a)
                )
                {
                    return "Triângulo Isósceles";
                }


                return "Triângulo Escaleno";
            } else
            {
                return "Triângulo Inválido!";
            }
        }

    } // FIM Classe
}
