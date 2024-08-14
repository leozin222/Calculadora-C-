// //tipos de variáveis

// using System.ComponentModel;

// int x = 10;

// double pi = 3.14;

// char letra = 'A';

// bool isTrue = true;

// string texto = "Uma linda mensagem";



// double outroValor;

// //conversão implicita
// outroValor = x;

// //conversão explicita
// int valorInteiro = (int) pi;

// //conversão com a classe Convert
// int y = Convert.ToInt32(texto);

// int numero;
// Console.WriteLine("Digite um Número");
// numero = Convert.ToInt32(Console.ReadLine());

// //concatenação de strigs
// Console.WriteLine("O Usurio digitou " + numero);

// //interpolação
// Console.WriteLine($"O dobro do que o usuário Digitou: {numero * 2}");


int num1;
Console.WriteLine("Digite o Primeiro Número: ");
num1 = Convert.ToInt32(Console.ReadLine());

int num2;
Console.WriteLine("Digite o Segundo Número: ");
num2 = Convert.ToInt32(Console.ReadLine());

int ResultadoSoma = num1 + num2;

int ResultadoSub = num1 - num2;

int ResultadoMulti = num1 * num2;

double ResultadoDivi = num1 / num2;

Console.WriteLine("Resultado dos números somados: " + ResultadoSoma);

Console.WriteLine($"Resultado dos números subtraídos: {ResultadoSub}");

Console.WriteLine("Resultado dos números multiplicados: " + ResultadoMulti);

Console.WriteLine("Resultado dos números Divididos: " + ResultadoDivi);






