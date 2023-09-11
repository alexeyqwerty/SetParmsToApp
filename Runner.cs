using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetParmsToApp
{
    public class Runner : BaseVM
    {
        private string parm;

        public string Parm { get => parm; set => SetProperty(ref parm, value); }

        private Command run;

        public Command Run => run ?? (run = new Command(RunCom, () => true));

        private void RunCom()
        {
            Process process = new Process();
            process.StartInfo.FileName = @"D:\Alex\StartWithParms\bin\Debug\StartWithParms.exe";
            process.StartInfo.Arguments = Parm;
            process.Start();
        }
    }
}
