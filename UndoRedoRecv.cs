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
    public class UndoRedoRecv
    {
        private String st;

        public DataTable Undo(string a)
        {
            ProjConn.getcon();
            return ProjConn.display(a);
        
        }

        public DataTable Redo(string a)
        {
            ProjConn.getcon();
            return ProjConn.display(a);
        
        }
    }
}
