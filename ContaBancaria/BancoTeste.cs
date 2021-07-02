using System;
using System.Globalization;


namespace ContaBancaria
{
    class BancoTeste
    {
        private string _nome;
        public double Saldo { get; private set; }//o Saldo se Não Houver Atribuição o Valor inicial dele é 0.
        public int Conta { get; private set; }

        public BancoTeste(string nome, int conta)
        {
            _nome = nome;
            Conta = conta;           
        }
        public BancoTeste(string nome, double depositoInicial, int conta) : this(nome, conta)//o This está Repassando o Construtor à Cima Reaproveitando.
        {
            Deposito(depositoInicial); //Chamando o Metodo de Deposito Inicial para Fazer o Deposito
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public void Deposito(double deposito)
        {
            Saldo = Saldo + deposito;
        }
        public void Saque(double saque)
        {
            Saldo = Saldo - saque - 5;
        }
        public override string ToString() //override tostring faz automático o exemplo abaixo.
        {
            return "Numero da Conta : " + Conta + ", Nome :" + _nome + ", Saldo na Conta : $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
