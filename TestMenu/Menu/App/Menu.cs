using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProject.App
{
    public class Menu
    {
        
        private string _menuId;
        private string _nmMenu;
        private string _finishGoodId;       
        public List<ItemResep> _resep = new List<ItemResep>();
        

        public Menu( string menuId, string nmMenu, string finishGoodId)
        {            
            this._menuId = menuId;
            this._nmMenu = nmMenu;
            this._finishGoodId = finishGoodId;
            
        }       

        public string Id { get { return this._menuId; } }
        public string Name { get { return this._nmMenu; } }
        public string FinishGoodId { get { return this._finishGoodId; } }



        public void MenambahResep(string productId, int qty)
        {
            var newItemRecep = new ItemResep(productId,qty);
            bool cekResep = this._resep.Where(x => x.ProductId == productId).Count() == 0 ? true: false;
            if(cekResep)
            {
                this._resep.Add(newItemRecep);
            }
            else
            {
               throw new NotImplementedException();
            }
        }

       

    }
}
