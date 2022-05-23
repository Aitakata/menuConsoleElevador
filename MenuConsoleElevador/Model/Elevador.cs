using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsoleElevador.Model
{
    internal class ElevadorModel

    {   // propriedades
        public int AndarAtual { get; set; }
        public int TotalAndar { get; set; }
        public int Capacidade { get; set; }
        public int NroPessoas { get; set; }
        
        // Métodos 
        public ElevadorModel()
        {   // inicializacoa das propriedades
            this.AndarAtual = 0;
            this.TotalAndar = 0;
            this.Capacidade = 0;
            this.NroPessoas = 0;
            Console.Write("Qual a capacidade do elevador? ");
            int cap = int.Parse(Console.ReadLine());
            Console.Write("Qual o número total de andares do prédio? ");
            int tot = int.Parse(Console.ReadLine());
            Inicializar(cap, tot);
        } 
       
        public void Inicializar(int capacidade, int totAndares)
        {
            // recebe como parâmetros a capacidade do elevador  e 
            // o total de andares no prédio (os elevadores sempre
            // começam no térreo e vazio)
            this.Capacidade = capacidade;
            this.TotalAndar = totAndares;
        }
        public void Subir()
        {   // subir um andar (não deve subir se já
            // estiver no último andar);
            if  (this.AndarAtual == this.TotalAndar)
            {
                Console.WriteLine("\nJá estamos no topo do prédio!");
            } else
            {
                this.AndarAtual++; 
                Console.WriteLine("\nSubindo para o andar {0}", this.AndarAtual);
            }
            
        }
        public void Descer()
        {   //  descer um andar (não deve descer se
            //  já estiver no térreo);
            if (this.AndarAtual == 0)
            {
                Console.WriteLine("\nJá estamos no térreo e este prédio \n"+
                                  "não tem subsolo!");
            }
            else
            {
                this.AndarAtual--;
                Console.WriteLine("\nDescendo para o andar {0}", this.AndarAtual);
            }
        }
        public void Entrar()
        {   //  Acrescenta uma pessoa no elevador
            //  (só deve acrescentar se ainda houver espaço)
            if (this.NroPessoas >= this.Capacidade)
            {
                Console.WriteLine("\nInfelizmente o elevador já está com a\n"+
                                  "capacidade máxima. Por favor, aguarde " +
                                  "próximo !!\n");
            } else
            {
                this.NroPessoas++;
                Console.WriteLine("\nAgora o estamos com {0} pessoas no elevador",
                    this.NroPessoas);
            }
        }
        public void Sair()
        {   //  remove uma pessoa do elevador
            //  //(só deve remover se houver alguém)
            if (this.NroPessoas != 0)
            {
                this.NroPessoas--;
                Console.WriteLine("\nAgora o estamos com {0} pessoas no elevador",
                    this.NroPessoas);
            }
            else
            {
                Console.WriteLine("\nO elevador já está vazio!!\n");
            }
        }
       
    }
}
