using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoStructs
{
    internal class Program
    {

        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;
        

        public Produto(string nome, float preco, float peso, string marca)
        {
            this.nome = nome;
            this.preco = preco;
            this.peso = peso;
            this.marca = marca;
        }

        public void ExibirInfo()
        {
                Console.WriteLine($"Nome: {this.nome} ");
                Console.WriteLine($"Preço: {this.preco}");
                Console.WriteLine($"Peso: { this.peso } KG");
                Console.WriteLine($"Marca: { this.marca }" );
        }

        public float AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc / 100f;
                return this.preco - desconto;
            }
    }
        static void Main(string[] args)
        {
            Produto bola = new Produto("Bola do ronaldinho",12f,1f,"Nike");
            Produto balde = new Produto("Balde vermelho",8f,2f,"????");

            bola.ExibirInfo();
            Console.WriteLine("===============================");
            balde.ExibirInfo();



            float valorFinal = bola.AdicionarCupom(50f);
            balde.AdicionarCupom(50f);


            Console.ReadLine();

        }
    }
}