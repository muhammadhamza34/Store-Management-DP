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
   public interface CommanderListerInterface
    {
         DataTable ExecCommand(Comander Cod);

          void addCommand(ref List<string> st);
    }
}
