// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.ElmaTasksPool
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Threading
{
  /// <summary>Пул исполнителей задач</summary>
  internal sealed class ElmaTasksPool : IDisposable
  {
    private readonly Queue<Func<Task>> queue;
    private readonly string systemThreadTimeoutAppSettingsKey;
    private readonly string appSettingsKey;
    private readonly int minTasksCount;
    private int tasksCount;
    private bool dispose;
    internal static ElmaTasksPool RF6034BS9VCfR1q9HIYA;

    /// <summary>Ctor</summary>
    /// <param name="appSettingsKey">Ключ настройки приложения, содержащей размер пула (максимальное количество задач)</param>
    /// <param name="minTasksCount">Минимальное количество задач</param>
    public ElmaTasksPool(string appSettingsKey, int minTasksCount)
    {
      ElmaTasksPool.VpY2s3BSr4INplL0Uaha();
      this.queue = new Queue<Func<Task>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ElmaTasksPool.hY6EDaBS52qqkUFfUYOg((object) appSettingsKey, ElmaTasksPool.EPsbIMBSgeia7QMMMjEt(589593376 ^ -1977315327 ^ -1459490523));
            num = 3;
            continue;
          case 2:
            this.tasksCount = 0;
            num = 4;
            continue;
          case 3:
            this.systemThreadTimeoutAppSettingsKey = appSettingsKey + (string) ElmaTasksPool.EPsbIMBSgeia7QMMMjEt(-420743386 ^ -420811518);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 4:
            Task.Run(new Func<Task>(this.SystemDo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 4 : 6;
            continue;
          case 5:
            this.minTasksCount = minTasksCount;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 1;
            continue;
          case 6:
            goto label_3;
          default:
            this.appSettingsKey = appSettingsKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 5 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Поместить задачу в очередь на исполнение</summary>
    /// <param name="taskFactory">Фабрика задачи, которую необходимо выполнить</param>
    public void Push(Func<Task> taskFactory)
    {
      if (this.dispose)
        throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218424344) + this.appSettingsKey + z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222098710));
      lock (this.queue)
        this.queue.Enqueue(taskFactory);
      Task.Run(new Func<Task>(this.Do));
    }

    /// <inheritdoc />
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.dispose = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить количество задач пула</summary>
    /// <returns>Количество задач</returns>
    internal int GetTasksCount() => this.tasksCount;

    private Task Do()
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      ElmaTasksPool.\u003CDo\u003Ed__10 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 5;
            continue;
          case 4:
            tBuilder.Start<ElmaTasksPool.\u003CDo\u003Ed__10>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 1;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 3 : 0;
            continue;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private Task SystemDo()
    {
      int num = 2;
      // ISSUE: variable of a compiler-generated type
      ElmaTasksPool.\u003CSystemDo\u003Ed__11 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 5 : 5;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_7;
          case 4:
            tBuilder.Start<ElmaTasksPool.\u003CSystemDo\u003Ed__11>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 2;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 4;
            continue;
        }
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    internal static void VpY2s3BSr4INplL0Uaha() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object EPsbIMBSgeia7QMMMjEt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void hY6EDaBS52qqkUFfUYOg([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool HcbTJDBSdyipb4AqLtVp() => ElmaTasksPool.RF6034BS9VCfR1q9HIYA == null;

    internal static ElmaTasksPool vABP7FBSlqhxPoOsGfUn() => ElmaTasksPool.RF6034BS9VCfR1q9HIYA;
  }
}
