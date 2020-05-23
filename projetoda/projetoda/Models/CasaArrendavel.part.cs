<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public partial class CasaArrendavel :Casa
    {
        public CasaArrendavel(string localidade, string rua, string numero, string andar, string area, string numeroAssoalhadas, string numeroWc, string numeroPisos, string tipo, int cliente,string valorBaseMes, string comissao):base(localidade, rua, numero, andar, area, numeroAssoalhadas, numeroWc, numeroPisos, tipo, cliente)
        {
            ValorBaseMes = valorBaseMes;
            Comissao = comissao; 
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
    public partial class CasaArrendavel :Casa
    {
        public CasaArrendavel(string localidade, string rua, string numero, string andar, string area, string numeroAssoalhadas, string numeroWc, string numeroPisos, string tipo, int cliente,string valorBaseMes, string comissao):base(localidade, rua, numero, andar, area, numeroAssoalhadas, numeroWc, numeroPisos, tipo, cliente)
        {
            ValorBaseMes = valorBaseMes;
            Comissao = comissao; 
        }
    }
}
>>>>>>> develop
