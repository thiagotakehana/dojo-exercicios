using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDojo
{
    /* Participantes
        PEREIRA     BIA    LUCAS    RENAN    MARCOS    TAKEHANA
        Duração 01h40
    */
    
    //http://dojopuzzles.com/problemas/exibe/caixa-eletronico/

    public static class CaixaEletronico
    {
        public static string Sacar(int valor)
        {
            int qtdNotas100 = 0;
            int qtdNotas50 = 0;
            int qtdNotas20 = 0;
            int qtdNotas10 = 0;
            int resto = 0;
            string retornoNotas = string.Empty;
            resto = valor;
            if ((resto >= 100))
            {
                qtdNotas100 = resto / 100;
                resto = resto % 100;
                
                if(qtdNotas100 > 1)
                {
                    return $"{qtdNotas100} notas de 100";
                }

                if (qtdNotas100 == 1)
                {
                    return "1 nota de 100";
                }
            }

            if (resto >= 50)
            {
                qtdNotas50 = resto / 50;
                if (qtdNotas50 == 1)
                {
                    return "1 nota de 50";
                }
            }

            if (resto >= 20)
            {
                qtdNotas20 = resto / 20;
         
                if (qtdNotas20 > 1)
                {
                    return $"{qtdNotas20} notas de 20";
                }

                if (qtdNotas20 == 1)
                {
                    return "1 nota de 20";
                }

            }

            if (resto == 10)
            {
                return "1 nota de 10";

            }

            return "valor invalido";
            
            
        }
    }

    //Notas disponíveis de R$ 100,00; R$ 50,00; R$ 20,00 e R$ 10,00
    //Valor do Saque: R$ 30,00 – Resultado Esperado: Entregar 1 nota de R$20,00 e 1 nota de R$ 10,00.

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Saque10reaisRetorna10()
        {
            string retorno = CaixaEletronico.Sacar(10);
            Assert.AreEqual(retorno, "1 nota de 10");
        }

        [TestMethod]
        public void Saque100reais()
        {
            string retorno = CaixaEletronico.Sacar(100);
            Assert.AreEqual(retorno, "1 nota de 100");
        }
        [TestMethod]
        public void Saque20reais()
        {
            string retorno = CaixaEletronico.Sacar(20);
            Assert.AreEqual(retorno, "1 nota de 20");
        }

        [TestMethod]
        public void Saque50reais()
        {
            string retorno = CaixaEletronico.Sacar(50);
            Assert.AreEqual(retorno, "1 nota de 50");
        }

        [TestMethod]
        public void Saque200reais()
        {
            string retorno = CaixaEletronico.Sacar(200);
            Assert.AreEqual(retorno, "2 notas de 100");
        }

        [TestMethod]
        public void Saque40reais()
        {
            string retorno = CaixaEletronico.Sacar(40);
            Assert.AreEqual(retorno, "2 notas de 20");
        }


        [TestMethod]
        public void Saque30reais()
        {
            string retorno = CaixaEletronico.Sacar(30);
            Assert.AreEqual(retorno, "1 nota de 20 e 1 nota de 10");
        }
    }
}
