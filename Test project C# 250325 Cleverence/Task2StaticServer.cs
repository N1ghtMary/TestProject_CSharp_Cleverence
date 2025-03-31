using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_project_C__250325_Cleverence
{
    public static class Task2StaticServer
    {
        private static int count = 0;
        private static readonly ReaderWriterLockSlim lockSlim = new ReaderWriterLockSlim();

        // Метод для чтения значения count
        // Пока писатели добавляют и пишут,
        // читатели должны ждать окончания записи
        public static int GetCount()
        {
            // Вход в режим чтения, где читатели могут читать
            // параллельно, не блокируя друг друга
            lockSlim.EnterReadLock(); 
            try
            {
                return count;
            }
            finally
            {
                // Выход из режима чтения
                lockSlim.ExitReadLock(); 
            }
        }

        // Метод для изменения значения count
        // Все потоки ожидают окончания записи
        public static void AddToCount(int value)
        {
            // Вход в режим записи, где писатели могут писали
            // только последовательно и никогда одновременно
            lockSlim.EnterWriteLock();
            try
            {
                count += value;
            }
            finally
            {
                // Выход из режима записи
                lockSlim.ExitWriteLock(); 
            }
        }
    }
}
