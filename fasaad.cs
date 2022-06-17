using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
   public class fasaad
    {
       private persons pr;
       private purchasemen pur_man;
       private salesmen sel_man;
       private items itm;
       private purchases objpurchases;
       private sales objsel;
       public fasaad()
       {
            pr = new persons();
            pur_man = new purchasemen();
            sel_man = new salesmen();
            itm = new items();
            objpurchases = new purchases();
            objsel = new sales();
            

       }

       public void Person()
       {
           pr.Show();
       }

       public void Purchaseman()
       {
            
           pur_man.Show();
       }

       public void Salesman()
       {
           sel_man.Show();
       }

       public void item()
       {
           itm.Show();
       }

       public void purchases()
       {

           objpurchases.Show();
       }

       public void sell()
       {
           objsel.Show();

       }

    }
}
