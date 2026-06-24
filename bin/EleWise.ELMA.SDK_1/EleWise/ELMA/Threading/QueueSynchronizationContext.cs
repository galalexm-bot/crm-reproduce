// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.QueueSynchronizationContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Threading
{
  public class QueueSynchronizationContext : SynchronizationContext
  {
    private Queue<QueueSynchronizationContext.WorkItem> queue;
    private System.Action afterQueueItemExecuted;
    private static QueueSynchronizationContext aJPAoEBRWU0cPX7HjjHN;

    public QueueSynchronizationContext()
    {
      QueueSynchronizationContext.xiRUaJBRh4vef5OWPRIo();
      this.queue = new Queue<QueueSynchronizationContext.WorkItem>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public QueueSynchronizationContext(System.Action afterQueueItemExecuted)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.queue = new Queue<QueueSynchronizationContext.WorkItem>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.afterQueueItemExecuted = afterQueueItemExecuted;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public override SynchronizationContext CreateCopy() => (SynchronizationContext) new QueueSynchronizationContext(this.afterQueueItemExecuted);

    public override void Post(SendOrPostCallback d, object state)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.queue.Enqueue(new QueueSynchronizationContext.WorkItem(d, state));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void Send(SendOrPostCallback d, object state)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            QueueSynchronizationContext.eKWvRWBRGPabk3JlDATx((object) d, state);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void ExecuteQueue()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            QueueSynchronizationContext.C6gduYBRERGWAoUX0GbA((object) this.queue.Dequeue());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 6;
            continue;
          case 4:
            QueueSynchronizationContext.kUHpKGBRfKsm8R9KykM6((object) this.afterQueueItemExecuted);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_6;
          case 6:
            if (this.afterQueueItemExecuted == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 3;
              continue;
            }
            goto case 4;
          default:
            if (QueueSynchronizationContext.FcDjgoBRQmeGRMA9C7cX((object) this.queue) <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 5;
              continue;
            }
            goto case 1;
        }
      }
label_6:;
    }

    internal static void xiRUaJBRh4vef5OWPRIo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool qWX8IVBRoB3k8VjiT8uY() => QueueSynchronizationContext.aJPAoEBRWU0cPX7HjjHN == null;

    internal static QueueSynchronizationContext bbu9dUBRbPdqjk0uNPpm() => QueueSynchronizationContext.aJPAoEBRWU0cPX7HjjHN;

    internal static void eKWvRWBRGPabk3JlDATx([In] object obj0, [In] object obj1) => ((SendOrPostCallback) obj0)(obj1);

    internal static void C6gduYBRERGWAoUX0GbA([In] object obj0) => ((QueueSynchronizationContext.WorkItem) obj0).Invoke();

    internal static void kUHpKGBRfKsm8R9KykM6([In] object obj0) => ((System.Action) obj0)();

    internal static int FcDjgoBRQmeGRMA9C7cX([In] object obj0) => ((Queue<QueueSynchronizationContext.WorkItem>) obj0).Count;

    private class WorkItem
    {
      private object callback;
      private object state;
      internal static object ib3woGQC7pTCG8Qt8lnL;

      public WorkItem(SendOrPostCallback callback, object state)
      {
        QueueSynchronizationContext.WorkItem.zfQ4vEQCmmOjqfMhVrhM();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.callback = (object) callback;
              num = 2;
              continue;
            case 2:
              this.state = state;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      public void Invoke()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              QueueSynchronizationContext.WorkItem.fR6XQYQCyCcCPhsND4WA(this.callback, this.state);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static void zfQ4vEQCmmOjqfMhVrhM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool QXBPexQCxWLNB3dfJU0U() => QueueSynchronizationContext.WorkItem.ib3woGQC7pTCG8Qt8lnL == null;

      internal static QueueSynchronizationContext.WorkItem OdND08QC0MCqclQePGQU() => (QueueSynchronizationContext.WorkItem) QueueSynchronizationContext.WorkItem.ib3woGQC7pTCG8Qt8lnL;

      internal static void fR6XQYQCyCcCPhsND4WA([In] object obj0, [In] object obj1) => ((SendOrPostCallback) obj0)(obj1);
    }
  }
}
