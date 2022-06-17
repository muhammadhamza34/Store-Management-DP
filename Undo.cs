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
    public class Undo: Comander
    {
        private UndoRedoRecv on;

        public void UndoBhai(UndoRedoRecv ok)
        {

            on = ok;
        }
        public DataTable exec(string a)
        {
           return on.Undo(a);
        }
    }
}
