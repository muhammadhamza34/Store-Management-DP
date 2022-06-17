using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    public class ContextStrategy
    {
        private StrategyInterface pr;
                                                                            /*
                                                                              * 
                                                                              * 
                                                                              * IMPLEMENTATION OF STRATEGY HAS BEEN DONE ON PURCHASES AND SALEITEMS
                                                                              * 
                                                                              * 
                                                                              * 
                                                                              */


        public ContextStrategy(StrategyInterface strat)
        {
            this.pr = strat;
        }

        public DataTable exeOP(string a , int id)
        {
            return pr.Execute(a, id);
        }
    }
}
