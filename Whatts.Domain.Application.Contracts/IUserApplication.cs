using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whats.Shared.Common;
using Whatts.Application.DTO;

namespace Whatts.Application.Contracts
{
    public interface IUserApplication
    {
        Response<WalletDTO> getWalletByEmail(String email);
    }
}
