using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatts.Application.DTO;

namespace Whatts.Domain.Contracts
{
    public interface IUserDomain
    {
        WalletDTO GetWalletByEmail(string email);
    }
}
