using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp
{
    public class Globals
    {
        private static AppData dataBase;
        public static AppData DataBase
        {
            get
            {
                if (dataBase == null)
                    dataBase = new AppData();
                return dataBase;
            }
        }

    }
}
