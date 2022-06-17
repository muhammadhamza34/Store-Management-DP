using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;
namespace StoreManagementSystem
{
    public class CommandLister
    {
        public List<Comander> li = new List<Comander>();

        public List<String> str = new List<String>();

        public void addCommand(ref List<string> cmds )
        {
            str = cmds;
           
        }

        public DataTable ExeCommand(Comander Cod)
        {
            string container = str[0];
            string pass = str[1];
            str[0] = pass;
            str[1] = container;

            return Cod.exec(pass);
            
        }

    }
}
