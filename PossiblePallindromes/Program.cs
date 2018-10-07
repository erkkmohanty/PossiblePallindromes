using Autofac;
using Nito.AsyncEx;
using System;
using System.Threading.Tasks;

namespace PossiblePallindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AsyncContext.Run(() => MainAsync(args));
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
        }


        static async Task MainAsync(string[] args)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                await app.Run();
            }
        }
    }
}
