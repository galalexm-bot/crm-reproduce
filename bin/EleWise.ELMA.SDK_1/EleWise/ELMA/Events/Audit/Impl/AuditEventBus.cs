// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.Impl.AuditEventBus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Events.Audit.Impl
{
  /// <summary>Шина обработки событий аудита</summary>
  public class AuditEventBus : IEventBusAsync, IEventBus
  {
    private readonly IEnumerableLazy<IAuditEventProvider> auditEventProviders;

    /// <summary>Ctor</summary>
    /// <param name="auditEventProviders">Провайдеры обработки событий аудита</param>
    public AuditEventBus(
      IEnumerableLazy<IAuditEventProvider> auditEventProviders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.auditEventProviders = auditEventProviders;
    }

    /// <inheritdoc />
    public IEnumerable Notify(string messageName, IDictionary<string, object> eventData)
    {
      IAuditEventArgs e = this.Prepare(messageName, eventData);
      if (e == null)
        return (IEnumerable) null;
      foreach (IAuditEventProvider auditEventProvider in this.auditEventProviders.Value)
        auditEventProvider.Notify(messageName, e);
      return (IEnumerable) null;
    }

    /// <inheritdoc />
    public async Task<IEnumerable> NotifyAsync(
      string messageName,
      IDictionary<string, object> eventData,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        IEnumerable result;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_4:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = 5;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_37;
            case 4:
              goto label_36;
            case 5:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = 4;
              continue;
            default:
              try
              {
                int num4;
                if (num3 != 0)
                  num4 = 2;
                else
                  goto label_17;
label_10:
                TaskAwaiter taskAwaiter;
                TaskAwaiter awaiter;
                while (true)
                {
                  int num5;
                  string messageName1;
                  IAuditEventArgs auditEventArgs;
                  CancellationToken cancellationToken1;
                  switch (num4)
                  {
                    case 1:
                    case 19:
                      goto label_4;
                    case 2:
                      num4 = 6;
                      continue;
                    case 4:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AuditEventBus.\u003CNotifyAsync\u003Ed__3>(ref awaiter, this);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 13;
                      continue;
                    case 5:
                      goto label_17;
                    case 6:
                      messageName1 = messageName;
                      num4 = 7;
                      continue;
                    case 7:
                      cancellationToken1 = cancellationToken;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 9 : 14;
                      continue;
                    case 8:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 10 : 5;
                      continue;
                    case 9:
                      if (auditEventArgs == null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 17 : 9;
                        continue;
                      }
                      goto case 11;
                    case 10:
                      taskAwaiter = awaiter;
                      num4 = 4;
                      continue;
                    case 11:
                      awaiter = Task.WhenAll(this.auditEventProviders.Value.OfType<IAuditEventProviderAsync>().Select<IAuditEventProviderAsync, Task>((Func<IAuditEventProviderAsync, Task>) (provider => provider.NotifyAsync(messageName1, auditEventArgs, cancellationToken1)))).GetAwaiter();
                      num4 = 18;
                      continue;
                    case 12:
                      taskAwaiter = new TaskAwaiter();
                      num4 = 15;
                      continue;
                    case 13:
                      goto label_33;
                    case 14:
                      auditEventArgs = this.Prepare(messageName1, eventData);
                      num4 = 9;
                      continue;
                    case 15:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                      continue;
                    case 16:
                      result = (IEnumerable) null;
                      num5 = 19;
                      break;
                    case 17:
                      result = (IEnumerable) null;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
                      continue;
                    case 18:
                      if (awaiter.IsCompleted)
                      {
                        num5 = 3;
                        break;
                      }
                      goto case 8;
                    default:
                      awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 6 : 16;
                      continue;
                  }
                  num4 = num5;
                }
label_33:
                return;
label_17:
                awaiter = taskAwaiter;
                num4 = 12;
                goto label_10;
              }
              catch (Exception ex)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num6 = 2;
                      continue;
                    case 2:
                      goto label_29;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
                      continue;
                  }
                }
label_29:
                return;
              }
          }
        }
label_37:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        num3 = (^this).\u003C\u003E1__state;
        num1 = 2;
      }
label_36:;
    }

    /// <summary>Подготовка к выполнению операции</summary>
    /// <param name="messageName">Имя события</param>
    /// <param name="eventData">Данные события</param>
    /// <returns>Параметры событий аудита</returns>
    private IAuditEventArgs Prepare(string messageName, IDictionary<string, object> eventData)
    {
      string[] strArray = messageName.Split('.');
      if (strArray.Length != 2)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138698546), (object) messageName));
      if (strArray[0] == TypeOf<IAuditEventProvider>.Name)
        return (IAuditEventArgs) null;
      return eventData.Count != 1 ? (IAuditEventArgs) null : eventData.First<KeyValuePair<string, object>>().Value as IAuditEventArgs;
    }
  }
}
