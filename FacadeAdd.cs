using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
   public interface FacadeAdd
    {
        public void add();
    }

   public class FAcade
   {
      public  purchases p = new purchases();
      public  purchasemen pm = new purchasemen();

   }
}
