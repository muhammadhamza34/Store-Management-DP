using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.ComponentModel;

namespace StoreManagementSystem
{
    class Proxy : CommanderListerInterface
    {
        private CommandLister cmol;
        public DataTable ExecCommand(Comander Cod)
        {
            
            
            return cmol.ExeCommand(Cod) ;
        }

        public void addCommand(ref List<string> st)
        {
            if (st != null)
            {
                cmol = new CommandLister();
                cmol.addCommand(ref st);
            }
        }
    }
}
