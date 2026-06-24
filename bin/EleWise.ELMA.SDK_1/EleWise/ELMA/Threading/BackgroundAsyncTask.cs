// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.BackgroundAsyncTask
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Threading
{
  /// <summary>Фоновая задача</summary>
  public class BackgroundAsyncTask
  {
    private readonly Func<Task> action;
    private readonly Type ownerType;
    private readonly string name;
    private readonly string description;
    private readonly bool useCallSessionOwner;
    private readonly bool handleExceptions;
    private static BackgroundAsyncTask wuN6HKBSmEMQ7UKhKwmA;

    /// <summary>Ctor</summary>
    /// <param name="action">Действие выполняемое в рамках задачи</param>
    /// <param name="ownerType">Тип владельца</param>
    /// <param name="name">Название</param>
    /// <param name="description">Описание</param>
    /// <param name="useCallSessionOwner">Использовать сессию вызова владельца</param>
    /// <param name="handleExceptions">Перехватывать исключения</param>
    public BackgroundAsyncTask(
      Func<Task> action,
      Type ownerType,
      string name,
      string description,
      bool useCallSessionOwner = true,
      bool handleExceptions = true)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317731036));
      this.action = action;
      this.ownerType = ownerType;
      this.name = name;
      this.description = description;
      this.useCallSessionOwner = useCallSessionOwner;
      this.handleExceptions = handleExceptions;
    }

    /// <summary>Исключение, возникшее при исполнении задачи</summary>
    public Exception ExecutionException
    {
      get => this.\u003CExecutionException\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CExecutionException\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Выполнить задачу</summary>
    public Task ExecuteAsync()
    {
      int num = 2;
      // ISSUE: variable of a compiler-generated type
      BackgroundAsyncTask.\u003CExecuteAsync\u003Ed__11 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = BackgroundAsyncTask.QYuHltBSJ5kK3jIg247a();
            num = 4;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 3 : 2;
            continue;
          case 5:
            goto label_3;
          default:
            tBuilder.Start<BackgroundAsyncTask.\u003CExecuteAsync\u003Ed__11>(ref stateMachine);
            num = 5;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    internal static bool DJVa6qBSyFHo92a3T7sE() => BackgroundAsyncTask.wuN6HKBSmEMQ7UKhKwmA == null;

    internal static BackgroundAsyncTask qhh1u7BSMwraSxZF0utx() => BackgroundAsyncTask.wuN6HKBSmEMQ7UKhKwmA;

    internal static AsyncTaskMethodBuilder QYuHltBSJ5kK3jIg247a() => AsyncTaskMethodBuilder.Create();
  }
}
