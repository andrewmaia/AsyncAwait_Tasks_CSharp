using System.Diagnostics;

namespace Biblioteca
{
    public class PreparadorCafeManha
    {
        public delegate void GerouMensagemEventHandler(string mensagem);
        public event GerouMensagemEventHandler GerouMensagem;

        #region Async

        public async  Task PrepareBreakfastAsync()
        {
            var watch = Stopwatch.StartNew();


            Coffee cup = PourCoffee();
            GerarMensagem("coffee is ready");


            //Neste ponto nao deveria aguardar esses tres caras finalizar
            Task<Egg> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2);


            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    GerarMensagem("Eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    GerarMensagem("Bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    GerarMensagem("Toast is ready");
                }
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            GerarMensagem("oj is ready");

            GerarMensagem("Breakfast is ready");

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            GerarMensagem($"{elapsedMs} millisecond");
        }

        private  async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            Toast toast = await ToastBreadAsync(2);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }
        private async  Task<Egg> FryEggsAsync(int howMany)
        {
            GerarMensagem("Warming the egg pan...");
            await Task.Delay(3000);
            GerarMensagem($"cracking {howMany} eggs");
            GerarMensagem("cooking the eggs ...");
            await Task.Delay(3000);
            GerarMensagem("Put eggs on plate");
            return new Egg();
        }

        private async  Task<Bacon> FryBaconAsync(int slices)
        {
            GerarMensagem($"putting {slices} slices of bacon in the pan");
            GerarMensagem("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
                GerarMensagem("flipping a slide of bacon");

            GerarMensagem("cooking the second side of bacon...");
            await Task.Delay(3000);
            GerarMensagem("Put bacon on plate");

            return new Bacon();
        }

        private async  Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
                GerarMensagem("Putting a slice of bread in the toaster");

            GerarMensagem("Start toasting...");
            await Task.Delay(3000);
            GerarMensagem("Remove toast from toaster");

            return new Toast();
        }
        #endregion


        #region Sync

        public  void PrepareBreakfastSync()
        {
            var watch = Stopwatch.StartNew();


            Coffee cup = PourCoffee();
            GerarMensagem("coffee is ready");

            Egg eggs = FryEggsSync(2);
            GerarMensagem("eggs are ready");

            Bacon bacon = FryBaconSync(3);
            GerarMensagem("bacon is ready");

            Toast toast = ToastBreadSync(2);
            ApplyButter(toast);
            ApplyJam(toast);
            GerarMensagem("toast is ready");

            Juice oj = PourOJ();
            GerarMensagem("oj is ready");

            GerarMensagem("Breakfast is ready");

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            GerarMensagem($"{elapsedMs} millisecond");
        }
        private  Egg FryEggsSync(int howMany)
        {
            GerarMensagem("Warming the egg pan...");
            Task.Delay(3000).Wait();
            GerarMensagem($"cracking {howMany} eggs");
            GerarMensagem("cooking the eggs ...");
            Task.Delay(3000).Wait();
            GerarMensagem("Put eggs on plate");
            return new Egg();
        }

        private  Bacon FryBaconSync(int slices)
        {
            GerarMensagem($"putting {slices} slices of bacon in the pan");
            GerarMensagem("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
                GerarMensagem("flipping a slide of bacon");

            GerarMensagem("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            GerarMensagem("Put bacon on plate");

            return new Bacon();
        }

        private  Toast ToastBreadSync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
                GerarMensagem("Putting a slice of bread in the toaster");

            GerarMensagem("Start toasting...");
            Task.Delay(3000).Wait();
            GerarMensagem("Remove toast from toaster");

            return new Toast();
        }
        #endregion


        #region Common
        private  Coffee PourCoffee()
        {
            GerarMensagem("Pouring coffee");
            return new Coffee();
        }

        private  void ApplyJam(Toast toast) => GerarMensagem("Putting jam on the toast");

        private  void ApplyButter(Toast toast) => GerarMensagem("Putting butter on the toast");

        private  Juice PourOJ()
        {
            GerarMensagem("Pouring orange juice");
            return new Juice();
        }

        private void GerarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            GerouMensagem?.Invoke(mensagem);
        }

        #endregion
    }

    #region classes

    public class Coffee
    {

    }

    public class Egg
    {

    }

    public class Bacon
    {

    }

    public class Toast
    {

    }

    public class Juice
    {

    }

    #endregion
}