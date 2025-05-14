using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatts.Domain.Entity;
using Whatts.Infrastructure.Contracts;

namespace Whatts.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public WalletModel GetWalletByEmail(string email)
        {
            List<WalletDumi> ListasFake = new List<WalletDumi>();


            
            ListasFake.Add(new WalletDumi { id = 1, email = "miguel_vargas_barrios@live.com.mx" });
            ListasFake.Add(new WalletDumi { id = 2, email = "vemo@live.com.mx" });
            ListasFake.Add(new WalletDumi { id = 3, email = "vemo@hotmail.com.mx" });
            ListasFake.Add(new WalletDumi { id = 4, email = "vemo@hotmail.com" });


            WalletDumi item = ListasFake.Find(x=>x.email==email);
            WalletModel wallet = null;

            if (item != null) 
            {
                wallet = new WalletModel();
                wallet.Email = item.email;
                wallet.IdWallet=item.id;
                wallet.Name = "Fake";
                
            }
            return wallet;
            
        }

    }

    public class WalletDumi()
    {
      public  int id { get; set; }
      public  string email { get; set; }               
        
    }
}
