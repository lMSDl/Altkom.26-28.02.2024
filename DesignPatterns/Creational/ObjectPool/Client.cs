namespace Altkom._26_28._02._2024.DesignPatterns.Creational.ObjectPool
{
    internal class Client
    {
        public static void Execute()
        {
            /*int counter = 0;
            while (true)
            {
                if (counter > 1000)
                {
                    Thread.Sleep(1);
                    continue;
                }

                Item item = new()
                {
                    IsVisible = true
                };
                _ = Task.Delay(100).ContinueWith(t => { item.IsVisible = false; _ = Interlocked.Decrement(ref counter); });
                _ = Interlocked.Increment(ref counter);
            }*/

            /*ObjectPool<Item> objectPool = new(1000, () => new Item());
            while (true)
            {
                Item? item = objectPool.Acquire();
                if (item == null)
                {
                    Thread.Sleep(1);
                    continue;
                }

                item.IsVisible = true;
                _ = Task.Delay(100).ContinueWith(t => { item.IsVisible = false; objectPool.Release(item); });
            }*/

            ItemPool itemPool = new(1000);
            while (true)
            {
                Item? item = itemPool.Acquire();
                if (item == null)
                {
                    Thread.Sleep(1);
                    continue;
                }

                _ = Task.Delay(100).ContinueWith(t => { item.IsVisible = false; });
            }
        }
    }
}
