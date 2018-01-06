using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution
{
    public class Order
    {
        public DateTime OrderDate { get; set; }

        public virtual DateTime CalculateEstimatedDeliveryDate()
        {
            return this.OrderDate;
        }
    }
    //Order from User.  
    public class UserOrder : Order
    {
        public override DateTime CalculateEstimatedDeliveryDate()
        {
            return base.CalculateEstimatedDeliveryDate();
        }
    }
    //Order from Dealer.  
    public class DealerOrder : Order
    {
        public override DateTime CalculateEstimatedDeliveryDate()
        {
            return this.OrderDate.AddDays(4);
        }
    }
    //Order from Distributor.  
    public class DistributorOrder : Order
    {
        public override DateTime CalculateEstimatedDeliveryDate()
        {
            return this.OrderDate.AddDays(2);
        }
    }
}
