using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatts.Application.DTO;
using Whatts.Domain.Contracts;
using Whatts.Domain.Entity;
using Whatts.Infrastructure.Contracts;

namespace Whatts.Domain.Handlers
{
    public class UserDomain : IUserDomain
    {
        private readonly IUserRepository _iuserRepository;
        public UserDomain(IUserRepository userRepitory) 
        {
            _iuserRepository = userRepitory;
        }
        public WalletDTO GetWalletByEmail(string email)
        {

            WalletDTO wallet = null;
            WalletModel walletModel = null;

            walletModel=_iuserRepository.GetWalletByEmail(email);

            if (walletModel != null) 
            {
                wallet=new WalletDTO();
                wallet.email = walletModel.Email;
                wallet.IdWallet = walletModel.IdWallet;
                wallet.AliasWallet = walletModel.Name;
            }

            return wallet;

        }
    }
}
