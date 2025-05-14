using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Whats.Shared.Common;
using Whatts.Application.Contracts;
using Whatts.Application.DTO;
using Whatts.Domain.Contracts;

namespace Whatts.Application.Handlers
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserDomain _userDomain;

        public UserApplication(IUserDomain userDomain)
        {
            _userDomain = userDomain;
        }
        public Response<WalletDTO> getWalletByEmail(string email)
        {
            try
            {
                WalletDTO wallet = new WalletDTO();

                wallet = _userDomain.GetWalletByEmail(email);

                if (wallet != null)
                {

                    return new Response<WalletDTO>()
                    {
                        IsSuccess = true,
                        Message = "Ok",
                        StatusCode = (int)HttpStatusCode.OK,
                        Data = wallet
                    };
                }
                else
                {
                    return new Response<WalletDTO>()
                    {
                        IsSuccess = false,
                        Message = "Not found",
                        StatusCode = (int)HttpStatusCode.NotFound
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<WalletDTO>()
                {
                    IsSuccess = false,
                    StatusCode = (int)HttpStatusCode.OK,
                    Exception = ex,
                    Message = ex.Message,
                    StringCode = ex.GetType().Name

                };
            }
        }
    }
}
