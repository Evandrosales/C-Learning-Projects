using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_De_Contas_Bytebank.Funcionarios;

namespace Controle_De_Contas_Bytebank.Diretoria
{
    public class Diretor : Funcionario
    {
        public override  double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }

    }
}
