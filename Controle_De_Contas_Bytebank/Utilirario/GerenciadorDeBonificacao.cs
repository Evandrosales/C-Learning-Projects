using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_De_Contas_Bytebank.Funcionarios;
using Controle_De_Contas_Bytebank.Diretoria;

namespace Controle_De_Contas_Bytebank.Utilirario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }
        //public void Registrar(Diretor diretoria)
        //{
        //    this.TotalDeBonificacao += diretoria.GetBonificacao();
        //}

    }
}
