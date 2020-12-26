using System;
using System.Threading.Tasks;
using SplitArray;
using SplitArray.Work;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fast
{

    public static class ParallelL
    {
        public static void For(int begin, int count, Action<float> action, int? maxCountTask = null)
        {
            var blockCount = new Block<int>();
            var checkException = new Block<bool>();
            Block<Exception> blockException = new Block<Exception>();
            blockCount.Current++;
            int countTask = GetMaxTask(maxCountTask, begin, count);
            Action actionDel = () =>
            {
                while (true)
                {
                    try
                    {
                        if (checkException.Current) break;
                        if (blockCount.Current > count) break;
                        action.Invoke(blockCount.Current);
                        blockCount.Current++;
                    }
                    catch (Exception ex)
                    {
                        checkException.Current = true;
                        blockException.Current = ex;
                    }
                }
            };
            var tasks = Enumerable.Repeat(Task.Run(actionDel), countTask).ToArray();
            Task.WaitAll(tasks);
            if (checkException.Current) throw blockException.Current;
        }
        private static int GetMaxTask(int? maxCountTask, int begin, int count)
        {

            if (maxCountTask == null)
            {
                int countMax = begin / count;
                return countMax > 30 ? 30 : countMax;
            }
            else return maxCountTask.Value;
        }

    }
}
