using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatts.Domain.Entity;

namespace Whatts.Infrastructure.Contracts
{
    public interface IUserRepository
    {
        WalletModel GetWalletByEmail(string  email);
    
    }
}
