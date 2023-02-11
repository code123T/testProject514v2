using System.Threading.Tasks;
using System.Threading;

namespace HumanResourcesManagmentSystem.Services
{
    public static class LoadingService
    {
        public static void Loading()
        {
            ManualResetEventSlim finishEvent = new ManualResetEventSlim();
            finishEvent.Reset();

            DustInTheWind.ConsoleTools.Controls.Spinners.ProgressBar progressBar = new DustInTheWind.ConsoleTools.Controls.Spinners.ProgressBar();

            Task.Run<Task>(async () =>
            {
                progressBar.Display();

                for (int i = 0; i < 100; i++)
                {
                    await Task.Delay(10);
                    progressBar.Value++;
                }

                finishEvent.Set();
            });

            finishEvent.Wait();

            progressBar.Close();
        }
    }
}
