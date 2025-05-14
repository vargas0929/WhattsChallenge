using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatts.Domain.Entity
{
    public class WalletModel
    {
        public int IdWallet { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
