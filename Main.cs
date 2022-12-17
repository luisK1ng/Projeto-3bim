internal class Conta
    {
        private string numero  = "-1", autor = "-1";
        private double agencia = -1.0;
        public Conta(string numero, string agencia, double saldo)
        {
            if (nome != "") this.numero = numero;
            if (autor != "") this.agencia = agencia;
            if (preco >= 0) this.saldo = saldo;
        }
        public void SetNumero(string n)
        {
            if (n != "") numero = n;
        }
        public void SetAgencia(string a)
        {
            if (a != "") agencia = a;
        }
        public void SetSaldo(double p)
        {
            if (p >= 0) saldo = p;
        }
        public double GetPreco()
        {
            return preco;
        }
        public string GetNumero()
        {
            return numero;
        }
        public string GetAgencia()
        {
            return agencia;
        }
  
        public override string ToString()
        {
      return $"Numero: {numero} | Agencia: {agencia} | Saldo: {saldo:0.00}";
        }

    }
}