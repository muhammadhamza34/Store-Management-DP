using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace StoreManagementSystem
{
   public interface StrategyInterface
    {
        DataTable  Execute(string a, int id);
    }
}
