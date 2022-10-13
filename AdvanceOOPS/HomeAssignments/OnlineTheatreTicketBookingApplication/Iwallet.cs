using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBookingApplication
{
    public interface Iwallet
    {
//         1.Interface IWallet
// Properties: WalletBalance 
// Method: RechargeWallet
        
        double WalletBalance { get; set; }
        void RechargeWallet()
        {

        }
        


    }
}