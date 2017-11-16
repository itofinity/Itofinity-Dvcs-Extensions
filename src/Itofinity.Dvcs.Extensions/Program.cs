using System;   

namespace Itofinity.Dvcs.Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Itofinity.Cli.Mef.Cli.Run(
                args, 
                typeof(Program).Assembly
#if DEBUG
                ,null
                ,null
                ,true
#endif
                );
        }
    }
}
