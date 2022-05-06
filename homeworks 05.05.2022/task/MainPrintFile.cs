using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class MainPrintFile
    {
        public MainPrintFile(IPrintable instans)
        {
                IPrintable file = (IPrintable)instans;
                file.printFile();
        }
    }
}
