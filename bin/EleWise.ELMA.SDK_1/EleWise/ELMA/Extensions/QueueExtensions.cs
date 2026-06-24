// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueueExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Extensions
{
  public static class QueueExtensions
  {
    public static bool LockTryDequeue<T>(this Queue<T> queue, out T result)
    {
      lock (queue)
      {
        result = default (T);
        if (queue.Count == 0)
          return false;
        result = queue.Dequeue();
        return true;
      }
    }

    public static void LockEnqueue<T>(this Queue<T> queue, T item)
    {
      lock (queue)
        queue.Enqueue(item);
    }

    /// <summary>Очистить очередь</summary>
    /// <typeparam name="T">Параметр типизирующий очередь</typeparam>
    /// <param name="queue">Очередь</param>
    public static void LockClear<T>(this Queue<T> queue)
    {
      lock (queue)
        queue.Clear();
    }
  }
}
