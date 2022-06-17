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
{/// <summary>
/// invoker
/// </summary>
   public class Redo: Comander
    {
       private UndoRedoRecv on;

       public void Redobhai(UndoRedoRecv ok )
       {
           on = ok;


       }
       public DataTable exec(string a)
       {
           return on.Redo(a);
            
       }
    }
}
