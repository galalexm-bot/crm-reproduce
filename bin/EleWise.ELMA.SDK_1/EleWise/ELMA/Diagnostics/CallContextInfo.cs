// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.CallContextInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>
  /// Информация о текущем потоке обработки (поток, поток Web-запроса)
  /// </summary>
  [Serializable]
  public sealed class CallContextInfo : IWorkTreeElement, IDisposable, ISerializable
  {
    private readonly Stopwatch stopwatch;
    private long callIdCounter;
    private static long _callContextId;
    private readonly List<IWorkTreeElement> workTree;
    private AbstractCallInfo currentCall;
    [ThreadStatic]
    private static TimeSpan _oldRealTotalProcessTime;
    private TimeSpan totalProcessorTime;
    [ThreadStatic]
    private static TimeSpan _oldRealUserProcessorTime;
    private TimeSpan userProcessorTime;
    [ThreadStatic]
    private static TimeSpan _oldRealPrivilegedProcessorTime;
    private TimeSpan privilegedProcessorTime;
    internal static CallContextInfo UXIBw5Eov7VenVuOXbhf;

    internal CallContextInfo(CallContextType? type)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.workTree = new List<IWorkTreeElement>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Id = Interlocked.Increment(ref CallContextInfo._callContextId);
      this.Uid = Guid.NewGuid();
      this.ManagedThreadId = (long) Thread.CurrentThread.ManagedThreadId;
      this.StartTime = DateTime.UtcNow;
      this.Type = type;
      this.ServerHostName = Environment.MachineName;
      this.stopwatch = Stopwatch.StartNew();
      this.Metrics = new MetricsContainer();
      this.Tags = (IDictionary<string, string>) new Dictionary<string, string>();
    }

    /// <inheritdoc />
    public long Id
    {
      get => this.\u003CId\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор сессии</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор текущего управляемого потока</summary>
    public long ManagedThreadId
    {
      get => this.\u003CManagedThreadId\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CManagedThreadId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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

    /// <summary>
    /// Идентификатор CallContextInfo, в рамкаж которого был запущен новый поток,
    /// связанный с данной сессей диагностики
    /// </summary>
    public Guid CreatedParentContextInfoUid
    {
      get => this.\u003CCreatedParentContextInfoUid\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CCreatedParentContextInfoUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Теги дополнительной информации</summary>
    public IDictionary<string, string> Tags { get; set; }

    /// <summary>Описание</summary>
    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    /// <summary>Адрес клиентской машины при веб-запросе</summary>
    public string UserHostAddress
    {
      get => this.\u003CUserHostAddress\u003Ek__BackingField;
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
              this.\u003CUserHostAddress\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>NetBIOS имя сервера</summary>
    public string ServerHostName
    {
      get => this.\u003CServerHostName\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CServerHostName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    /// <summary>Метод веб-запроса (GET/POST)</summary>
    public string HttpMethod
    {
      get => this.\u003CHttpMethod\u003Ek__BackingField;
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
              this.\u003CHttpMethod\u003Ek__BackingField = value;
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
    }

    /// <summary>ID пользователя</summary>
    public object UserId
    {
      get => this.\u003CUserId\u003Ek__BackingField;
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
              this.\u003CUserId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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

    /// <summary>Имя пользователя</summary>
    public string UserName
    {
      get => this.\u003CUserName\u003Ek__BackingField;
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
              this.\u003CUserName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Тип обработки</summary>
    public CallContextType? Type { get; private set; }

    /// <summary>Дата/время начала обработки</summary>
    public DateTime StartTime
    {
      get => this.\u003CStartTime\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CStartTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
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

    /// <summary>Дата/время завершения</summary>
    public DateTime EndTime
    {
      get => this.\u003CEndTime\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CEndTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public TimeSpan TotalTime => CallContextInfo.Yq5NqwEoug0ddEoVZBU3((object) this.stopwatch);

    /// <summary>
    /// Общее количество времени, которое потратил поток на обработку процессором
    /// Доступно для чтения только после завершения потока
    /// </summary>
    public TimeSpan TotalProcessorTime => this.totalProcessorTime;

    /// <summary>
    /// Общее количество времени, которое поток потратил на выполнение кода внутри приложения
    /// Доступно для чтения только после завершения потока
    /// </summary>
    public TimeSpan UserProcessorTime => this.userProcessorTime;

    /// <summary>
    /// Общее количество времени, которое поток потратил на выполнение кода внутри ядра ОС
    /// Доступно для чтения только после завершения потока
    /// </summary>
    public TimeSpan PrivilegedProcessorTime => this.privilegedProcessorTime;

    /// <summary>Информация о родительской сессии диагностики</summary>
    public CallContextInfo ParentContextInfo
    {
      get => this.\u003CParentContextInfo\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CParentContextInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
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

    /// <summary>Дочерняя сессия диагностики</summary>
    public CallContextInfo ChildContextInfo
    {
      get => this.\u003CChildContextInfo\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CChildContextInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
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

    /// <summary>Текущий вызов</summary>
    public AbstractCallInfo CurrentCall
    {
      get => this.currentCall;
      internal set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              CallContextInfo.LnhhJEEoIhhy1pvpQsgn((object) this.ParentContextInfo, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            case 2:
              if (this.ParentContextInfo != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
                continue;
              }
              goto label_7;
            case 3:
              this.currentCall = value;
              num = 2;
              continue;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_8:
        return;
label_7:;
      }
    }

    /// <inheritdoc />
    public IEnumerable<IWorkTreeElement> WorkTree => (IEnumerable<IWorkTreeElement>) this.workTree.ToArray();

    /// <summary>Метрики текущей сессии</summary>
    public MetricsContainer Metrics
    {
      get => this.\u003CMetrics\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMetrics\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public Exception Exception
    {
      get => this.\u003CException\u003Ek__BackingField;
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
              this.\u003CException\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
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

    /// <summary>Получить стек текущего вызова</summary>
    public IEnumerable<AbstractCallInfo> GetCallStack()
    {
      if (this.CurrentCall == null)
        return Enumerable.Empty<AbstractCallInfo>();
      List<AbstractCallInfo> abstractCallInfoList = new List<AbstractCallInfo>();
      for (AbstractCallInfo abstractCallInfo = this.CurrentCall; abstractCallInfo != null; abstractCallInfo = abstractCallInfo.ParentCall)
        abstractCallInfoList.Add(abstractCallInfo);
      return (IEnumerable<AbstractCallInfo>) abstractCallInfoList.ToArray();
    }

    /// <inheritdoc />
    public void Dispose()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_2;
          case 2:
            if (!CallContextInfo.KVWJ1rEoVNmJpF57rN9V())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            ((DiagnosticsManager) CallContextInfo.nv9XlOEoS80fd4O44W7G()).CloseCurrentSession();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          CallContextType? type;
          switch (num2)
          {
            case 1:
              if (this.WorkTree == null)
              {
                num2 = 12;
                continue;
              }
              goto case 18;
            case 2:
            case 7:
            case 12:
              if (this.Exception == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 10 : 30;
                continue;
              }
              goto case 22;
            case 3:
              if (this.UserHostAddress.IsNullOrEmpty())
              {
                num2 = 4;
                continue;
              }
              goto case 20;
            case 4:
            case 36:
              if (CallContextInfo.luCtGxEoX14PSfgnlEtk((object) this.ServerHostName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 11 : 32;
                continue;
              }
              goto case 34;
            case 5:
              if (CallContextInfo.luCtGxEoX14PSfgnlEtk((object) this.Description))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 23 : 22;
                continue;
              }
              goto case 44;
            case 6:
            case 23:
              if (CallContextInfo.xYxJtmEoTDUkRn5IoZZr((object) this.Tags) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 9 : 17;
                continue;
              }
              goto case 3;
            case 8:
              CallContextInfo.UVnvsuEonIWvc17dLKvg((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(-488881205 ^ -489133345), this.EndTime);
              num2 = 15;
              continue;
            case 9:
            case 16:
              CallContextInfo.UVnvsuEonIWvc17dLKvg((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(1052221104 - 768835541 ^ 283129381), this.StartTime);
              num2 = 8;
              continue;
            case 10:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951490956), (object) this.Uid);
              num2 = 25;
              continue;
            case 11:
              CallContextInfo.w5FmwbEoRYis1tXZCUBL((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(-1350312861 << 3 ^ 2082366022), this.Id);
              num2 = 10;
              continue;
            case 13:
              goto label_7;
            case 14:
              if (this.ParentContextInfo != null)
              {
                num2 = 24;
                continue;
              }
              goto case 38;
            case 15:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(-1824388195 ^ -1824120133), (object) this.TotalTime);
              num2 = 42;
              continue;
            case 17:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(1597012150 ^ 1597265134), (object) this.Tags);
              num2 = 3;
              continue;
            case 18:
              if (!this.WorkTree.Any<IWorkTreeElement>())
              {
                num2 = 7;
                continue;
              }
              goto case 41;
            case 19:
              goto label_51;
            case 20:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867111831), (object) this.UserHostAddress);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 13 : 36;
              continue;
            case 21:
              if (!CallContextInfo.luCtGxEoX14PSfgnlEtk((object) this.UserName))
              {
                num2 = 37;
                continue;
              }
              goto case 31;
            case 22:
              info.AddValue((string) CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(1819636893 << 3 ^ 1672449422), (object) this.Exception);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 4 : 19;
              continue;
            case 24:
              goto label_6;
            case 25:
              if (CallContextInfo.k3IviCEoK5IiVKj3iB1y(this.CreatedParentContextInfoUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 32 : 40;
                continue;
              }
              goto case 14;
            case 26:
            case 32:
              if (CallContextInfo.luCtGxEoX14PSfgnlEtk((object) this.HttpMethod))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 29 : 21;
                continue;
              }
              break;
            case 27:
              if (!type.HasValue)
              {
                num2 = 16;
                continue;
              }
              goto case 43;
            case 28:
            case 29:
              if (this.UserId != null)
              {
                num2 = 13;
                continue;
              }
              goto case 21;
            case 30:
              goto label_46;
            case 31:
              type = this.Type;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 27 : 24;
              continue;
            case 33:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(-1886646897 ^ -1886903943), (object) this.userProcessorTime);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 29 : 35;
              continue;
            case 34:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195885677), (object) this.ServerHostName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 26 : 14;
              continue;
            case 35:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(92412609 - 1050237057 ^ -957550756), (object) this.privilegedProcessorTime);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
              continue;
            case 37:
              info.AddValue((string) CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(1994213607 >> 4 ^ 124616962), (object) this.UserName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 15 : 31;
              continue;
            case 38:
              if (!CallContextInfo.luCtGxEoX14PSfgnlEtk((object) this.Name))
              {
                num2 = 39;
                continue;
              }
              goto case 5;
            case 39:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(1597012150 ^ 1596984182), (object) this.Name);
              num2 = 5;
              continue;
            case 40:
              info.AddValue((string) CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(-643786247 ^ -643517939), (object) this.CreatedParentContextInfoUid);
              num2 = 14;
              continue;
            case 41:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(-477139494 ^ -477412216), (object) this.WorkTree);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 2 : 2;
              continue;
            case 42:
              goto label_31;
            case 43:
              SerializationInfo serializationInfo = info;
              object obj1 = CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(864270449 << 6 ^ -521263962);
              type = this.Type;
              object obj2 = CallContextInfo.e4tbCBEokcEgHASlkmTl((Enum) type.Value);
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) serializationInfo, obj1, obj2);
              num2 = 9;
              continue;
            case 44:
              CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397212930), (object) this.Description);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 5 : 6;
              continue;
          }
          CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(~1767720452 ^ -1767467683), (object) this.HttpMethod);
          num2 = 28;
        }
label_6:
        CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(712480695 ^ 712227739), (object) this.ParentContextInfo.Uid);
        num1 = 38;
        continue;
label_7:
        CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(-441065788 ^ -2092910478 ^ 1727089160), (object) this.UserId.ToString());
        num1 = 21;
        continue;
label_31:
        CallContextInfo.AgLEEMEoqFsAvFSY2F6I((object) info, CallContextInfo.mMLcA9Eoi9ttE3yEhZq0(~1767720452 ^ -1767467723), (object) this.totalProcessorTime);
        num1 = 33;
      }
label_51:
      return;
label_46:;
    }

    /// <summary>
    /// Получить новый идентификатор вызова в пределах текущего контекста.
    /// Метод предназначен только для внутреннего использования
    /// </summary>
    /// <returns></returns>
    internal long GetNewCallId()
    {
      int num = 3;
      long newCallId;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            newCallId = ++this.callIdCounter;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 3:
            if (this.ParentContextInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 2;
              continue;
            }
            goto label_2;
          default:
            goto label_6;
        }
      }
label_2:
      return CallContextInfo.oe9OixEoO88DnejBC70f((object) this.ParentContextInfo);
label_6:
      return newCallId;
    }

    /// <summary>
    /// Добавить новый корневой элемент.
    /// Метод предназначен только для внутреннего использования
    /// </summary>
    /// <param name="call">Элемент</param>
    internal void AddWorkTreeElement(IWorkTreeElement call)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.workTree.Add(call);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Закрыть контекст вызова</summary>
    /// <param name="ex">Ошибка</param>
    internal void CloseCallContext(Exception ex)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        TimeSpan timeSpan1;
        TimeSpan totalProcessorTime;
        TimeSpan timeSpan2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.totalProcessorTime = CallContextInfo.mfbIbZEoNtT3lSailUvH(totalProcessorTime, CallContextInfo._oldRealTotalProcessTime);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 2:
              this.privilegedProcessorTime = CallContextInfo.mfbIbZEoNtT3lSailUvH(timeSpan2, CallContextInfo._oldRealPrivilegedProcessorTime);
              num2 = 12;
              continue;
            case 3:
              this.Exception = ex;
              num2 = 10;
              continue;
            case 4:
              this.EndTime = CallContextInfo.bcMKfFEo2URCjk63F47j();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 3 : 1;
              continue;
            case 5:
              totalProcessorTime = ProcessThreadInfo.TotalProcessorTime;
              num2 = 11;
              continue;
            case 6:
              goto label_3;
            case 7:
              timeSpan2 = CallContextInfo.q57oeREo16p7dgMJtMmM();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
              continue;
            case 8:
              this.userProcessorTime = CallContextInfo.mfbIbZEoNtT3lSailUvH(timeSpan1, CallContextInfo._oldRealUserProcessorTime);
              num2 = 9;
              continue;
            case 9:
              goto label_5;
            case 10:
              goto label_10;
            case 11:
              timeSpan1 = CallContextInfo.J8bij6EoPUM5qvuNkK9J();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 6 : 7;
              continue;
            case 12:
              CallContextInfo._oldRealPrivilegedProcessorTime = timeSpan2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 6 : 6;
              continue;
            default:
              CallContextInfo._oldRealTotalProcessTime = totalProcessorTime;
              num2 = 8;
              continue;
          }
        }
label_5:
        CallContextInfo._oldRealUserProcessorTime = timeSpan1;
        num1 = 2;
        continue;
label_10:
        CallContextInfo.TYvWJCEoequ6N8oQd3qJ((object) this.stopwatch);
        num1 = 5;
      }
label_3:;
    }

    internal static bool WfMgxCEo8uhmuxfqJTDs() => CallContextInfo.UXIBw5Eov7VenVuOXbhf == null;

    internal static CallContextInfo h6wnFsEoZYIDFNkc6WNk() => CallContextInfo.UXIBw5Eov7VenVuOXbhf;

    internal static TimeSpan Yq5NqwEoug0ddEoVZBU3([In] object obj0) => ((Stopwatch) obj0).Elapsed;

    internal static void LnhhJEEoIhhy1pvpQsgn([In] object obj0, [In] object obj1) => ((CallContextInfo) obj0).CurrentCall = (AbstractCallInfo) obj1;

    internal static bool KVWJ1rEoVNmJpF57rN9V() => DiagnosticsManager.Initialized;

    internal static object nv9XlOEoS80fd4O44W7G() => (object) DiagnosticsManager.Instance;

    internal static object mMLcA9Eoi9ttE3yEhZq0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void w5FmwbEoRYis1tXZCUBL([In] object obj0, [In] object obj1, [In] long obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static void AgLEEMEoqFsAvFSY2F6I([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static bool k3IviCEoK5IiVKj3iB1y([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool luCtGxEoX14PSfgnlEtk([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static int xYxJtmEoTDUkRn5IoZZr([In] object obj0) => ((ICollection<KeyValuePair<string, string>>) obj0).Count;

    internal static object e4tbCBEokcEgHASlkmTl(Enum enumValue) => (object) enumValue.GetDisplayName();

    internal static void UVnvsuEonIWvc17dLKvg([In] object obj0, [In] object obj1, [In] DateTime obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static long oe9OixEoO88DnejBC70f([In] object obj0) => ((CallContextInfo) obj0).GetNewCallId();

    internal static DateTime bcMKfFEo2URCjk63F47j() => DateTime.UtcNow;

    internal static void TYvWJCEoequ6N8oQd3qJ([In] object obj0) => ((Stopwatch) obj0).Stop();

    internal static TimeSpan J8bij6EoPUM5qvuNkK9J() => ProcessThreadInfo.UserProcessorTime;

    internal static TimeSpan q57oeREo16p7dgMJtMmM() => ProcessThreadInfo.PrivilegedProcessorTime;

    internal static TimeSpan mfbIbZEoNtT3lSailUvH([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 - obj1;
  }
}
