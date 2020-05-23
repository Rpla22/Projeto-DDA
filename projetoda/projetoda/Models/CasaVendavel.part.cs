<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
  public partial class CasaVendavel: Casa
    {
        public CasaVendavel(string localidade, string rua, string numero, string andar, string area, string numeroAssoalhadas, string numeroWc, string numeroPisos, string tipo, int cliente, string valorBaseVenda, string valorComissao) : base(localidade, rua, numero, andar, area, numeroAssoalhadas, numeroWc, numeroPisos, tipo, cliente)
        {
            ValorBaseVenda = valorBaseVenda;
            ValorComissao = valorComissao;

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
  public partial class CasaVendavel: Casa
    {
        public CasaVendavel(string localidade, string rua, string numero, string andar, string area, string numeroAssoalhadas, string numeroWc, string numeroPisos, string tipo, int cliente, string valorBaseVenda, string valorComissao) : base(localidade, rua, numero, andar, area, numeroAssoalhadas, numeroWc, numeroPisos, tipo, cliente)
        {
            ValorBaseVenda = valorBaseVenda;
            ValorComissao = valorComissao;

        }
    }
}
>>>>>>> develop
