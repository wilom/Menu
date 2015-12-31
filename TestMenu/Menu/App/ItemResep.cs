using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProject.App
{
    public class ItemResep
    {

        public string ProductId { get; private set; }

        public int Qty { get; private set; }

        public ItemResep(string productId, int qty)
        {           
            this.ProductId = productId;
            this.Qty = qty;
        }
    }
}
