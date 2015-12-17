using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Domains
{
    public class Pessoa : EntidadeBase
    {
        public String Nome { get; set; }

        public int SetorID { get; set; }
        public virtual Setor Setor { get; set; }
    }
}
