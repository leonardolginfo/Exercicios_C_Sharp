using System;

namespace Dio.Bank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        
        private double Saldo { get; set; }
                
        private double Credito { get; set; }
        
        private string Name { get; set; }

        public Conta(TipoConta tipoConta, double Saldo, double Credito, string Name) 
            {
                this.TipoConta = tipoConta;
                this.Saldo = Saldo;
                this.Credito = Credito;
                this.Name = Name;        
            }

        public bool Sacar(double valorSaque)
                
                //validando se saldo é positivo
                
            {

                if(this.Saldo - valorSaque < (this.Credito * -1)) {
                    Console.WriteLine("Saldo insuficiente!");
                    return false;
                }
                this.Saldo -= valorSaque;
                    
                    Console.WriteLine("O saldo atual da conta de {0} é de {1}", this.Name, this.Saldo);
                
                    return true;
                            
            }

        public void Depositar(double valorDeposito)    
        
        {

                this.Saldo += valorDeposito;
                Console.WriteLine("O saldo atual da conta de {0} é de {1}", this.Name, this.Saldo);
                
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        
        {
                if(this.Sacar(valorTransferencia)){
                    contaDestino.Depositar(valorTransferencia);
                }

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta "+ this.TipoConta + " | ";
            retorno += "Nome " + this.Name + " | ";
            retorno = "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito + " |";
            return retorno;
        }

    }

}