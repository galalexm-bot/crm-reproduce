// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Impl.DefaultEventBus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Threading.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Events.Impl
{
  /// <summary>
  /// Шина событий по умолчанию, реализация сервиса для ручной подписки на события
  /// </summary>
  internal class DefaultEventBus : IEventBusAsync, IEventBus, IEventHandlerSubscribeService
  {
    private readonly Func<IEnumerable<LazyEventHandler>> eventHandlersFunc;
    private readonly List<IEventHandler> eventHandlers;
    private readonly ReaderWriterLockSlim eventHandlersLock;
    internal static DefaultEventBus pwEhgKGY4LKsLwZm8a8l;

    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    /// <param name="eventHandlersFunc">Инъекция обработчиков событий</param>
    public DefaultEventBus(
      Func<IEnumerable<LazyEventHandler>> eventHandlersFunc)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.eventHandlers = new List<IEventHandler>();
      this.eventHandlersLock = new ReaderWriterLockSlim();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.eventHandlersFunc = eventHandlersFunc;
      this.Logger = NullLogger.Instance;
    }

    /// <inheritdoc />
    public IDisposable Subscribe(IEventHandler eventHandler)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DefaultEventBus.sbjR1LGY7antC5NT79rM((object) eventHandler, DefaultEventBus.kUEfU5GYAOSIVUfBHc5h(92412609 - 1050237057 ^ -957555108));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            this.AddEventHandler(eventHandler);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return (IDisposable) new DefaultEventBus.UnSubscriber(this, eventHandler);
    }

    /// <inheritdoc />
    public IEnumerable Notify(string messageName, IDictionary<string, object> eventData) => (IEnumerable) this.NotifyHandlers(messageName, eventData, true).ToArray<object>();

    /// <inheritdoc />
    public async Task<IEnumerable> NotifyAsync(
      string messageName,
      IDictionary<string, object> eventData,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num1 = 2;
      int num2;
      IEnumerable array;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 3 : 1;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
            continue;
          case 3:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 10;
              else
                goto label_16;
label_6:
              TaskAwaiter<IEnumerable<object>> awaiter;
              while (true)
              {
                TaskAwaiter<IEnumerable<object>> taskAwaiter;
                int num4;
                switch (num3)
                {
                  case 1:
                    goto label_16;
                  case 2:
                  case 6:
                    array = (IEnumerable) awaiter.GetResult().ToArray<object>();
                    num4 = 3;
                    break;
                  case 3:
                    goto label_28;
                  case 4:
                    goto label_22;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 6;
                    break;
                  case 7:
                    if (awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
                      continue;
                    }
                    goto default;
                  case 8:
                    taskAwaiter = new TaskAwaiter<IEnumerable<object>>();
                    num3 = 5;
                    continue;
                  case 9:
                  case 10:
                    awaiter = taskAwaiter;
                    num3 = 8;
                    continue;
                  case 11:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<object>>, DefaultEventBus.\u003CNotifyAsync\u003Ed__10>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 4 : 4;
                    continue;
                  case 12:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 5 : 11;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 12;
                    continue;
                }
                num3 = num4;
              }
label_22:
              return;
label_16:
              awaiter = this.NotifyHandlersAsync(messageName, eventData, true, cancellationToken).GetAwaiter();
              num3 = 7;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
              {
                num3 = 7;
                goto label_6;
              }
              else
                goto label_6;
            }
            catch (Exception ex)
            {
              int num5 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_18;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
                    continue;
                }
              }
label_18:
              return;
            }
          case 4:
label_28:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_25;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(array);
            num1 = 5;
            continue;
        }
      }
label_25:;
    }

    /// <summary>Выполнить обработчики и получить результат выполнения</summary>
    /// <param name="messageName">Название обработчика</param>
    /// <param name="eventData">Данные события</param>
    /// <param name="failFast"><c>true</c> если прокидывать исключение при ошибке обработки</param>
    /// <returns>Результат обработчик</returns>
    private IEnumerable<object> NotifyHandlers(
      string messageName,
      IDictionary<string, object> eventData,
      bool failFast)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<object>) new DefaultEventBus.\u003CNotifyHandlers\u003Ed__11(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__messageName = messageName,
        \u003C\u003E3__eventData = eventData,
        \u003C\u003E3__failFast = failFast
      };
    }

    /// <summary>Выполнить обработчики и получить результат выполнения</summary>
    /// <param name="messageName">Название обработчика</param>
    /// <param name="eventData">Данные события</param>
    /// <param name="failFast"><c>true</c> если прокидывать исключение при ошибке обработки</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат обработчик</returns>
    private async Task<IEnumerable<object>> NotifyHandlersAsync(
      string messageName,
      IDictionary<string, object> eventData,
      bool failFast,
      CancellationToken cancellationToken)
    {
      int num1 = 5;
      while (true)
      {
        IEnumerable<object> result1;
        int num2;
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 2;
            continue;
          case 2:
            goto label_56;
          case 3:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 17 : 32;
              else
                goto label_18;
label_7:
              TaskAwaiter<IEnumerable[]> taskAwaiter;
              TaskAwaiter<IEnumerable[]> awaiter;
              string messageName1;
              while (true)
              {
                List<object> result;
                int num4;
                int index;
                IEnumerable[] result2;
                string[] strArray;
                IOrderedEnumerable<LazyEventHandler> source1;
                IEnumerable source2;
                DefaultEventBus defaultEventBus;
                string interfaceName;
                string methodName;
                IDictionary<string, object> eventData1;
                bool failFast1;
                CancellationToken cancellationToken1;
                switch (num3)
                {
                  case 1:
                    goto label_53;
                  case 2:
                    cancellationToken1 = cancellationToken;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 20 : 20;
                    continue;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    if (!DefaultEventBus.\u003CNotifyHandlersAsync\u003Ed__12.fpPlxD8ZpfTMQZLfRXoj((object) this.Logger))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 4 : 4;
                      continue;
                    }
                    goto case 26;
                  case 4:
                  case 5:
                    result = new List<object>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 15 : 30;
                    continue;
                  case 6:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 10;
                    continue;
                  case 7:
                    taskAwaiter = new TaskAwaiter<IEnumerable[]>();
                    num4 = 6;
                    break;
                  case 8:
                    if (strArray.Length != 2)
                    {
                      num3 = 17;
                      continue;
                    }
                    interfaceName = strArray[0];
                    num3 = 14;
                    continue;
                  case 9:
                    defaultEventBus = this;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 21 : 9;
                    continue;
                  case 10:
                    result2 = awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 22 : 16;
                    continue;
                  case 11:
                    result1 = (IEnumerable<object>) result;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 4 : 13;
                    continue;
                  case 12:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 30 : 33;
                    continue;
                  case 13:
                    goto label_3;
                  case 14:
                    methodName = strArray[1];
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                    continue;
                  case 15:
                    eventData1 = eventData;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 6 : 28;
                    continue;
                  case 16:
                    result.AddRange(source2.Cast<object>());
                    num3 = 18;
                    continue;
                  case 17:
                    goto label_25;
                  case 18:
                  case 29:
                    ++index;
                    num4 = 25;
                    break;
                  case 19:
                    if (source2 == null)
                    {
                      num3 = 29;
                      continue;
                    }
                    goto case 16;
                  case 20:
                    // ISSUE: reference to a compiler-generated method
                    strArray = (string[]) DefaultEventBus.\u003CNotifyHandlersAsync\u003Ed__12.bjRwQX8ZN2lA51AJ4hft((object) messageName1, (object) new char[1]
                    {
                      '.'
                    });
                    num4 = 8;
                    break;
                  case 21:
                    messageName1 = messageName;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 15 : 1;
                    continue;
                  case 22:
                    index = 0;
                    num3 = 24;
                    continue;
                  case 23:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 12;
                    continue;
                  case 24:
                  case 25:
                    if (index >= result2.Length)
                    {
                      num3 = 11;
                      continue;
                    }
                    goto case 34;
                  case 26:
                    ILogger logger = this.Logger;
                    // ISSUE: reference to a compiler-generated method
                    object format = DefaultEventBus.\u003CNotifyHandlersAsync\u003Ed__12.dQRKFk8Z39MABtLy17lg(-1350312861 << 3 ^ 2082160612);
                    object[] objArray = new object[2];
                    // ISSUE: reference to a compiler-generated method
                    object separator = DefaultEventBus.\u003CNotifyHandlersAsync\u003Ed__12.dQRKFk8Z39MABtLy17lg(-1217523399 ^ -1217520325);
                    IOrderedEnumerable<LazyEventHandler> source3 = source1;
                    // ISSUE: reference to a compiler-generated field
                    Func<LazyEventHandler, string> func1 = DefaultEventBus.\u003C\u003Ec.\u003C\u003E9__12_1;
                    Func<LazyEventHandler, string> selector;
                    if (func1 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      DefaultEventBus.\u003C\u003Ec.\u003C\u003E9__12_1 = selector = (Func<LazyEventHandler, string>) (h => h.ToString());
                    }
                    else
                      goto label_60;
label_48:
                    string[] array = source3.Select<LazyEventHandler, string>(selector).ToArray<string>();
                    objArray[0] = (object) string.Join((string) separator, array);
                    objArray[1] = (object) messageName1;
                    logger.DebugFormat((string) format, objArray);
                    num3 = 5;
                    continue;
label_60:
                    selector = func1;
                    goto label_48;
                  case 27:
                    goto label_18;
                  case 28:
                    failFast1 = failFast;
                    num3 = 2;
                    continue;
                  case 30:
                    awaiter = Task.WhenAll<IEnumerable>(source1.Select<LazyEventHandler, Task<IEnumerable>>((Func<LazyEventHandler, Task<IEnumerable>>) (handler => defaultEventBus.TryNotifyHandlerAsync(handler, messageName1, interfaceName, methodName, eventData1, failFast1, cancellationToken1)))).GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 31 : 23;
                    continue;
                  case 31:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = 23;
                      continue;
                    }
                    goto case 10;
                  case 32:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 9 : 1;
                    continue;
                  case 33:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable[]>, DefaultEventBus.\u003CNotifyHandlersAsync\u003Ed__12>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
                    continue;
                  case 34:
                    source2 = result2[index];
                    num3 = 19;
                    continue;
                  default:
                    IEnumerable<LazyEventHandler> source4 = ((IEnumerable<LazyEventHandler>) this.CloneEventHandlers()).Concat<LazyEventHandler>(this.eventHandlersFunc());
                    // ISSUE: reference to a compiler-generated field
                    Func<LazyEventHandler, int> func2 = DefaultEventBus.\u003C\u003Ec.\u003C\u003E9__12_0;
                    Func<LazyEventHandler, int> keySelector;
                    if (func2 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      DefaultEventBus.\u003C\u003Ec.\u003C\u003E9__12_0 = keySelector = (Func<LazyEventHandler, int>) (handler => DefaultEventBus.\u003C\u003Ec.iwh0bs8Zvt8e5Q3aC2ht((object) handler));
                    }
                    else
                      goto label_59;
label_45:
                    source1 = source4.OrderBy<LazyEventHandler, int>(keySelector);
                    num4 = 3;
                    break;
label_59:
                    keySelector = func2;
                    goto label_45;
                }
                num3 = num4;
              }
label_53:
              return;
label_25:
              // ISSUE: reference to a compiler-generated method
              throw new ArgumentException(EleWise.ELMA.SR.T((string) DefaultEventBus.\u003CNotifyHandlersAsync\u003Ed__12.dQRKFk8Z39MABtLy17lg(-867826612 ^ -868082822), (object) messageName1));
label_18:
              awaiter = taskAwaiter;
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
              {
                num3 = 7;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_49;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 2;
                    continue;
                }
              }
label_49:
              return;
            }
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 3;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 4;
            continue;
        }
label_3:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
      }
label_56:;
    }

    /// <summary>Выполнить попытку обработки события</summary>
    /// <param name="eventHandler">Обработчик события</param>
    /// <param name="messageName">Название обработчика</param>
    /// <param name="interfaceName">Название интерфейса обработчика</param>
    /// <param name="methodName">Название метода обработчика</param>
    /// <param name="eventData">Данные события</param>
    /// <param name="failFast"><c>true</c> если прокидывать исключение при ошибке обработки</param>
    /// <param name="returnValue">Результат обработки</param>
    /// <returns><c>true</c> если обработка завершена успешно</returns>
    private bool TryNotifyHandler(
      LazyEventHandler eventHandler,
      string messageName,
      string interfaceName,
      string methodName,
      IDictionary<string, object> eventData,
      bool failFast,
      out IEnumerable returnValue)
    {
      try
      {
        return this.TryInvoke(eventHandler, interfaceName, methodName, eventData, out returnValue);
      }
      catch (Exception ex)
      {
        this.Logger.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137717770), (object) messageName, (object) eventHandler.GetType().FullName, (object) ex.GetType().Name), ex);
        if (failFast)
        {
          throw;
        }
        else
        {
          returnValue = (IEnumerable) null;
          return false;
        }
      }
    }

    /// <summary>Выполнить попытку обработки события</summary>
    /// <param name="eventHandler">Обработчик события</param>
    /// <param name="messageName">Название обработчика</param>
    /// <param name="interfaceName">Название интерфейса обработчика</param>
    /// <param name="methodName">Название метода обработчика</param>
    /// <param name="eventData">Данные события</param>
    /// <param name="failFast"><c>true</c> если прокидывать исключение при ошибке обработки</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат вызова</returns>
    private async Task<IEnumerable> TryNotifyHandlerAsync(
      LazyEventHandler eventHandler,
      string messageName,
      string interfaceName,
      string methodName,
      IDictionary<string, object> eventData,
      bool failFast,
      CancellationToken cancellationToken)
    {
      int num1 = 3;
      while (true)
      {
        IEnumerable result;
        int num2;
        switch (num1)
        {
          case 1:
            goto label_36;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 2;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 2;
            continue;
          case 4:
            try
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_7;
                }
              }
label_7:
              try
              {
                int num4;
                if (num2 != 0)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 11 : 11;
                else
                  goto label_20;
label_10:
                TaskAwaiter<IEnumerable> taskAwaiter;
                TaskAwaiter<IEnumerable> awaiter;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 10:
                      result = awaiter.GetResult();
                      num4 = 5;
                      continue;
                    case 2:
                      taskAwaiter = awaiter;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 3 : 1;
                      continue;
                    case 3:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable>, DefaultEventBus.\u003CTryNotifyHandlerAsync\u003Ed__14>(ref awaiter, this);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 4 : 4;
                      continue;
                    case 4:
                      goto label_33;
                    case 5:
                      goto label_38;
                    case 6:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 1;
                      continue;
                    case 7:
                      taskAwaiter = new TaskAwaiter<IEnumerable>();
                      num4 = 9;
                      continue;
                    case 8:
                      goto label_20;
                    case 9:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 10;
                      continue;
                    case 11:
                      awaiter = this.TryInvokeAsync(eventHandler, interfaceName, methodName, eventData, cancellationToken).GetAwaiter();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                      continue;
                    default:
                      if (awaiter.IsCompleted)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
                        continue;
                      }
                      goto case 6;
                  }
                }
label_33:
                return;
label_20:
                awaiter = taskAwaiter;
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                {
                  num4 = 7;
                  goto label_10;
                }
                else
                  goto label_10;
              }
              catch (Exception ex)
              {
                int num5 = 3;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_38;
                    case 2:
                      goto label_27;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      DefaultEventBus.\u003CTryNotifyHandlerAsync\u003Ed__14.Ddcstx8ZAV6Lv34xUujb((object) this.Logger, DefaultEventBus.\u003CTryNotifyHandlerAsync\u003Ed__14.AbZZic8ZHM0SYXHRp3Zj(DefaultEventBus.\u003CTryNotifyHandlerAsync\u003Ed__14.Bcv6v18ZwmaO78H608gx(1669371371 ^ 1669630419), (object) messageName, (object) eventHandler.GetType().FullName, DefaultEventBus.\u003CTryNotifyHandlerAsync\u003Ed__14.UItc948Z6B4UYRbjmKRn((object) DefaultEventBus.\u003CTryNotifyHandlerAsync\u003Ed__14.iWbbbA8Z4nhFnFkWaG9H((object) ex))), (object) ex);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                      continue;
                    default:
                      if (failFast)
                      {
                        num5 = 2;
                        continue;
                      }
                      result = (IEnumerable) null;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
                      continue;
                  }
                }
label_27:
                throw;
              }
            }
            catch (Exception ex)
            {
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
                num6 = 0;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    goto label_29;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = 2;
                    continue;
                }
              }
label_29:
              return;
            }
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
            continue;
        }
label_38:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 5 : 3;
      }
label_36:;
    }

    /// <summary>Выполнить попытку вызова обработчика</summary>
    /// <param name="eventHandler">Обработчик события</param>
    /// <param name="interfaceName">Название интерфейса</param>
    /// <param name="methodName">Название метода</param>
    /// <param name="arguments">Список аргументов вызова</param>
    /// <param name="returnValue">Результат обработки</param>
    /// <returns><c>true</c> если обработка завершена успешно</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool TryInvoke(
      LazyEventHandler eventHandler,
      string interfaceName,
      string methodName,
      IDictionary<string, object> arguments,
      out IEnumerable returnValue)
    {
      foreach (Type interfaceType in eventHandler.EventHandlerType.GetInterfaces())
      {
        if (string.Equals(interfaceType.Name, interfaceName, StringComparison.OrdinalIgnoreCase))
          return this.TryInvokeMethod(eventHandler.Value, interfaceType, methodName, arguments, out returnValue);
      }
      returnValue = (IEnumerable) null;
      return false;
    }

    /// <summary>Выполнить попытку вызова обработчика</summary>
    /// <param name="eventHandler">Обработчик события</param>
    /// <param name="interfaceName">Название интерфейса</param>
    /// <param name="methodName">Название метода</param>
    /// <param name="arguments">Список аргументов вызова</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат вызова</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private async Task<IEnumerable> TryInvokeAsync(
      LazyEventHandler eventHandler,
      string interfaceName,
      string methodName,
      IDictionary<string, object> arguments,
      CancellationToken cancellationToken)
    {
      int num1 = 3;
      int num2;
      IEnumerable result;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_34;
          case 2:
            num1 = 4;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 2;
            continue;
          case 4:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 15 : 1;
              else
                goto label_7;
label_5:
              TaskAwaiter<IEnumerable> taskAwaiter;
              Type[] interfaces;
              TaskAwaiter<IEnumerable> awaiter;
              Type interfaceType;
              int index;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                    continue;
                  case 2:
                  case 14:
                    interfaceType = interfaces[index];
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 8 : 19;
                    continue;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    if (!string.Equals((string) DefaultEventBus.\u003CTryInvokeAsync\u003Ed__16.tHJAx08ZmyGsQO2Aikpn((object) interfaceType), interfaceName, StringComparison.OrdinalIgnoreCase))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 4 : 0;
                      continue;
                    }
                    goto case 11;
                  case 4:
                  case 13:
                    ++index;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 8 : 10;
                    continue;
                  case 5:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = 8;
                      continue;
                    }
                    goto case 22;
                  case 6:
                  case 10:
                    if (index < interfaces.Length)
                    {
                      num3 = 2;
                      continue;
                    }
                    goto case 20;
                  case 7:
                    goto label_31;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 1;
                    continue;
                  case 9:
                    index = 0;
                    num3 = 6;
                    continue;
                  case 11:
                    awaiter = this.TryInvokeMethodAsync(eventHandler.Value, interfaceType, methodName, arguments, cancellationToken).GetAwaiter();
                    num3 = 5;
                    continue;
                  case 12:
                    taskAwaiter = new TaskAwaiter<IEnumerable>();
                    num3 = 18;
                    continue;
                  case 15:
                    interfaces = eventHandler.EventHandlerType.GetInterfaces();
                    num3 = 9;
                    continue;
                  case 16:
                  case 17:
                    goto label_35;
                  case 18:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 22;
                    continue;
                  case 19:
                    cancellationToken.ThrowIfCancellationRequested();
                    num3 = 3;
                    continue;
                  case 20:
                    result = (IEnumerable) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 16 : 12;
                    continue;
                  case 21:
                    goto label_7;
                  case 22:
                    result = awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 17 : 10;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable>, DefaultEventBus.\u003CTryInvokeAsync\u003Ed__16>(ref awaiter, this);
                    num3 = 7;
                    continue;
                }
              }
label_31:
              return;
label_7:
              awaiter = taskAwaiter;
              num3 = 12;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
              {
                num3 = 4;
                goto label_5;
              }
              else
                goto label_5;
            }
            catch (Exception ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_27;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = 2;
                    continue;
                }
              }
label_27:
              return;
            }
          case 5:
label_35:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
            continue;
        }
      }
label_34:;
    }

    /// <summary>Выполнить попытку вызова метода обработчика</summary>
    /// <param name="eventHandler">Обработчик события</param>
    /// <param name="interfaceType">Тип интерфейса</param>
    /// <param name="methodName">Название метода</param>
    /// <param name="arguments">Список аргументов вызова</param>
    /// <param name="returnValue">Результат вызова</param>
    /// <returns><c>true</c> если вызов завершен успешно</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool TryInvokeMethod(
      IEventHandler eventHandler,
      Type interfaceType,
      string methodName,
      IDictionary<string, object> arguments,
      out IEnumerable returnValue)
    {
      MethodInfo matchingMethod = this.GetMatchingMethod(interfaceType, methodName, arguments);
      if (matchingMethod != (MethodInfo) null)
      {
        List<object> objectList = new List<object>();
        foreach (ParameterInfo parameter in matchingMethod.GetParameters())
          objectList.Add(arguments[parameter.Name]);
        object obj = matchingMethod.Invoke((object) eventHandler, objectList.ToArray());
        returnValue = obj as IEnumerable;
        if (returnValue == null && obj != null)
          returnValue = (IEnumerable) new object[1]{ obj };
        return true;
      }
      returnValue = (IEnumerable) null;
      return false;
    }

    /// <summary>Выполнить попытку вызова метода обработчика</summary>
    /// <param name="eventHandler">Обработчик события</param>
    /// <param name="interfaceType">Тип интерфейса</param>
    /// <param name="methodName">Название метода</param>
    /// <param name="arguments">Список аргументов вызова</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат вызова</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private async Task<IEnumerable> TryInvokeMethodAsync(
      IEventHandler eventHandler,
      Type interfaceType,
      string methodName,
      IDictionary<string, object> arguments,
      CancellationToken cancellationToken)
    {
      int num1 = 3;
      IEnumerable result1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_47;
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = 4;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 2;
            continue;
          case 4:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 15 : 20;
              else
                goto label_17;
label_8:
              TaskAwaiter<object> taskAwaiter;
              IEnumerable enumerable;
              MethodInfo matchingMethod;
              object result2;
              List<object> objectList;
              ParameterInfo parameterInfo;
              TaskAwaiter<object> awaiter;
              int index;
              ParameterInfo[] parameterInfoArray;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                  case 12:
                    goto label_3;
                  case 2:
                    enumerable = result2 as IEnumerable;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 11 : 17;
                    continue;
                  case 3:
                    parameterInfo = parameterInfoArray[index];
                    num3 = 4;
                    continue;
                  case 4:
                    objectList.Add(arguments[parameterInfo.Name]);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 3 : 5;
                    continue;
                  case 5:
                    ++index;
                    num3 = 21;
                    continue;
                  case 6:
                  case 24:
                    result2 = awaiter.GetResult();
                    num3 = 2;
                    continue;
                  case 7:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 29 : 29;
                    continue;
                  case 8:
                    enumerable = (IEnumerable) new object[1]
                    {
                      result2
                    };
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 19 : 15;
                    continue;
                  case 9:
                    // ISSUE: reference to a compiler-generated method
                    if (DefaultEventBus.\u003CTryInvokeMethodAsync\u003Ed__18.bjBmZ38Z9flELQhJ1sXu((object) matchingMethod, (object) null))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 21 : 23;
                      continue;
                    }
                    goto case 26;
                  case 10:
                  case 19:
                    result1 = enumerable;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
                    continue;
                  case 11:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 6;
                      continue;
                    }
                    goto case 7;
                  case 13:
                    goto label_17;
                  case 14:
                  case 21:
                    if (index >= parameterInfoArray.Length)
                    {
                      num3 = 15;
                      continue;
                    }
                    goto case 3;
                  case 15:
                    // ISSUE: reference to a compiler-generated method
                    awaiter = this.InvokeAsyncWithResult(matchingMethod, eventHandler, (object[]) DefaultEventBus.\u003CTryInvokeMethodAsync\u003Ed__18.vw4QOf8ZliAvaICfksS6((object) objectList)).GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 11;
                    continue;
                  case 16:
                    if (result2 == null)
                    {
                      num3 = 10;
                      continue;
                    }
                    goto case 8;
                  case 17:
                    if (enumerable == null)
                    {
                      num3 = 16;
                      continue;
                    }
                    goto case 10;
                  case 18:
                    // ISSUE: reference to a compiler-generated method
                    parameterInfoArray = (ParameterInfo[]) DefaultEventBus.\u003CTryInvokeMethodAsync\u003Ed__18.B3SiPn8ZdeJdsyIkbWKc((object) matchingMethod);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                    continue;
                  case 20:
                    matchingMethod = this.GetMatchingMethod(interfaceType, methodName, arguments);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 9 : 1;
                    continue;
                  case 22:
                    taskAwaiter = new TaskAwaiter<object>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 25 : 3;
                    continue;
                  case 23:
                    objectList = new List<object>();
                    num3 = 18;
                    continue;
                  case 25:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 24;
                    continue;
                  case 26:
                    result1 = (IEnumerable) null;
                    num3 = 12;
                    continue;
                  case 27:
                    goto label_40;
                  case 28:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, DefaultEventBus.\u003CTryInvokeMethodAsync\u003Ed__18>(ref awaiter, this);
                    num3 = 27;
                    continue;
                  case 29:
                    taskAwaiter = awaiter;
                    num3 = 28;
                    continue;
                  default:
                    index = 0;
                    num3 = 14;
                    continue;
                }
              }
label_40:
              return;
label_17:
              awaiter = taskAwaiter;
              num3 = 22;
              goto label_8;
            }
            catch (Exception ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_22;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_21;
                }
              }
label_22:
              return;
label_21:
              return;
            }
          case 5:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          default:
            goto label_44;
        }
      }
label_47:
      return;
label_44:;
    }

    /// <summary>Выполнить асинхронный метод и вернуть результат</summary>
    /// <param name="method">Информация о вызове метода</param>
    /// <param name="eventHandler">Обработчик события</param>
    /// <param name="parameters">Аргументы вызова</param>
    /// <returns>Результат</returns>
    private async Task<object> InvokeAsyncWithResult(
      MethodInfo method,
      IEventHandler eventHandler,
      object[] parameters)
    {
      int num1 = 2;
      while (true)
      {
        object result1;
        int num2;
        switch (num1)
        {
          case 1:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 25;
              else
                goto label_23;
label_6:
              TaskAwaiter taskAwaiter1;
              TaskAwaiter awaiter1;
              while (true)
              {
                object result;
                TaskAwaiter<object> taskAwaiter2;
                int num4;
                TaskAwaiter<object> awaiter2;
                object result2;
                switch (num3)
                {
                  case 1:
                  case 27:
                    result2 = awaiter2.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 17 : 12;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = 21;
                    continue;
                  case 3:
                    goto label_40;
                  case 4:
                    goto label_44;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 20;
                    continue;
                  case 6:
                    if (method.ReturnType == TypeOf<Task>.Raw)
                    {
                      num3 = 14;
                      continue;
                    }
                    goto case 16;
                  case 7:
                  case 9:
                    result1 = result;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 4 : 0;
                    continue;
                  case 8:
                    taskAwaiter1 = awaiter1;
                    num3 = 26;
                    continue;
                  case 10:
                    awaiter2 = taskAwaiter2;
                    num3 = 18;
                    continue;
                  case 11:
                    result = (object) null;
                    num3 = 6;
                    continue;
                  case 12:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 20;
                  case 13:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 27;
                    break;
                  case 14:
                    // ISSUE: reference to a compiler-generated method
                    awaiter1 = DefaultEventBus.\u003CInvokeAsyncWithResult\u003Ed__19.TA8q5E8ZjUF5RfXHulnY((object) method.InvokeActionAsync((object) eventHandler, parameters));
                    num4 = 12;
                    break;
                  case 15:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, DefaultEventBus.\u003CInvokeAsyncWithResult\u003Ed__19>(ref awaiter2, this);
                    num3 = 3;
                    continue;
                  case 16:
                    awaiter2 = method.InvokeFunctionAsync((object) eventHandler, parameters).GetAwaiter();
                    num3 = 19;
                    continue;
                  case 17:
                    result = result2;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 9;
                    continue;
                  case 18:
                    taskAwaiter2 = new TaskAwaiter<object>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 11 : 13;
                    continue;
                  case 19:
                    if (awaiter2.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
                      continue;
                    }
                    goto case 2;
                  case 20:
                    awaiter1.GetResult();
                    num3 = 7;
                    continue;
                  case 21:
                    taskAwaiter2 = awaiter2;
                    num3 = 15;
                    continue;
                  case 22:
                    taskAwaiter1 = new TaskAwaiter();
                    num3 = 5;
                    continue;
                  case 23:
                    goto label_23;
                  case 24:
                    goto label_36;
                  case 25:
                    if (num2 != 1)
                    {
                      num3 = 11;
                      continue;
                    }
                    goto case 10;
                  case 26:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DefaultEventBus.\u003CInvokeAsyncWithResult\u003Ed__19>(ref awaiter1, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 24 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 8;
                    continue;
                }
                num3 = num4;
              }
label_40:
              return;
label_36:
              return;
label_23:
              awaiter1 = taskAwaiter1;
              num3 = 22;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
              {
                num3 = 9;
                goto label_6;
              }
              else
                goto label_6;
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_33;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = 2;
                    continue;
                }
              }
label_33:
              return;
            }
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_43;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 3;
            continue;
        }
label_44:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 4;
      }
label_43:;
    }

    /// <summary>Найти подходящий метод</summary>
    /// <param name="interfaceType">Тип интерфейса</param>
    /// <param name="methodName">Название метода</param>
    /// <param name="arguments">Список аргументов вызова</param>
    /// <returns>Информация о методе</returns>
    private MethodInfo GetMatchingMethod(
      Type interfaceType,
      string methodName,
      IDictionary<string, object> arguments)
    {
      List<MethodInfo> collection = new List<MethodInfo>((IEnumerable<MethodInfo>) interfaceType.GetMethods());
      List<MethodInfo> source = new List<MethodInfo>((IEnumerable<MethodInfo>) collection);
      foreach (MethodInfo methodInfo in collection)
      {
        if (string.Equals(methodInfo.Name, methodName, StringComparison.OrdinalIgnoreCase))
        {
          foreach (ParameterInfo parameter in methodInfo.GetParameters())
          {
            if (!arguments.ContainsKey(parameter.Name))
            {
              source.Remove(methodInfo);
              break;
            }
          }
        }
        else
          source.Remove(methodInfo);
      }
      // ISSUE: reference to a compiler-generated method
      return source.Count != 0 ? source.OrderBy<MethodInfo, int>((Func<MethodInfo, int>) (x => DefaultEventBus.\u003C\u003Ec.lgcWRD8Z806yBUmvLsB5((object) x).Length)).Last<MethodInfo>() : (MethodInfo) null;
    }

    /// <summary>Добавить обработчик события</summary>
    /// <param name="eventHandler">Обработчик события</param>
    private void AddEventHandler(IEventHandler eventHandler)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            DefaultEventBus.HwEhRYGYxJQjfF8Jr5uc((object) this.eventHandlersLock);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          default:
            goto label_3;
        }
      }
label_12:
      return;
label_3:
      try
      {
        this.eventHandlers.Add(eventHandler);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        DefaultEventBus.zoPa5vGY00MR4hUjSOif((object) this.eventHandlersLock);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Удалить обработчик события</summary>
    /// <param name="eventHandler">Обработчик события</param>
    private void RemoveEventHandler(IEventHandler eventHandler)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            DefaultEventBus.HwEhRYGYxJQjfF8Jr5uc((object) this.eventHandlersLock);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_11;
          default:
            goto label_2;
        }
      }
label_11:
      return;
label_2:
      try
      {
        this.eventHandlers.Remove(eventHandler);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        DefaultEventBus.zoPa5vGY00MR4hUjSOif((object) this.eventHandlersLock);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Склонировать список обработчиков событий</summary>
    /// <returns>Обработчики событий</returns>
    private LazyEventHandler[] CloneEventHandlers()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            DefaultEventBus.uNd67aGYmxN9FoCej8pH((object) this.eventHandlersLock);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      LazyEventHandler[] array;
      return array;
label_4:
      try
      {
        array = this.eventHandlers.Select<IEventHandler, LazyEventHandler>((Func<IEventHandler, LazyEventHandler>) (h => new LazyEventHandler(h))).ToArray<LazyEventHandler>();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_3;
        }
      }
      finally
      {
        DefaultEventBus.FtlELMGYy6FUjhMeTlyp((object) this.eventHandlersLock);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    internal static bool iGdv4bGY655Ft9eZVxNY() => DefaultEventBus.pwEhgKGY4LKsLwZm8a8l == null;

    internal static DefaultEventBus cipuvuGYHluQTaSBtsMc() => DefaultEventBus.pwEhgKGY4LKsLwZm8a8l;

    internal static object kUEfU5GYAOSIVUfBHc5h(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void sbjR1LGY7antC5NT79rM([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void HwEhRYGYxJQjfF8Jr5uc([In] object obj0) => ((ReaderWriterLockSlim) obj0).EnterWriteLock();

    internal static void zoPa5vGY00MR4hUjSOif([In] object obj0) => ((ReaderWriterLockSlim) obj0).ExitWriteLock();

    internal static void uNd67aGYmxN9FoCej8pH([In] object obj0) => ((ReaderWriterLockSlim) obj0).EnterReadLock();

    internal static void FtlELMGYy6FUjhMeTlyp([In] object obj0) => ((ReaderWriterLockSlim) obj0).ExitReadLock();

    /// <summary>Отписчик от события</summary>
    private class UnSubscriber : IDisposable
    {
      private readonly object defaultEventBus;
      private readonly object eventHandler;
      internal static object rhM1dO88zPYrAf6vkCTL;

      public UnSubscriber(DefaultEventBus defaultEventBus, IEventHandler eventHandler)
      {
        DefaultEventBus.UnSubscriber.KEfJhq8ZWV8KG7xvg75Y();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.eventHandler = (object) eventHandler;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 2:
              this.defaultEventBus = (object) defaultEventBus;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

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
              DefaultEventBus.UnSubscriber.cPMEmg8ZosZLe9ekjwYh(this.defaultEventBus, this.eventHandler);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static void KEfJhq8ZWV8KG7xvg75Y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool flLxF18ZFKkjpiWTeMOK() => DefaultEventBus.UnSubscriber.rhM1dO88zPYrAf6vkCTL == null;

      internal static DefaultEventBus.UnSubscriber Pr9c5E8ZBOTewLVvCYIA() => (DefaultEventBus.UnSubscriber) DefaultEventBus.UnSubscriber.rhM1dO88zPYrAf6vkCTL;

      internal static void cPMEmg8ZosZLe9ekjwYh([In] object obj0, [In] object obj1) => ((DefaultEventBus) obj0).RemoveEventHandler((IEventHandler) obj1);
    }
  }
}
