using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Domains
{
    public class ContextoRamais : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Setor> Setores { get; set; }
    }
}
