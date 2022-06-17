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
   public interface Comander
    {
        DataTable exec(string a);
       
    }
}
