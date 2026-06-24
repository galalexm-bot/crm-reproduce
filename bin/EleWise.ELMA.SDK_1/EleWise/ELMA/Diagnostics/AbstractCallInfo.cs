// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.AbstractCallInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>
  /// Базовый класс информации о каком-либо вызове.
  /// Классы, наследуемые от <c>AbstractCallInfo</c> должны в обязательном порядке иметь конструктор по умолчанию.
  /// </summary>
  [Serializable]
  public abstract class AbstractCallInfo : IDisposable, IWorkTreeElement, ISerializable
  {
    private readonly List<IWorkTreeElement> workTree;
    private static IEnumerable<IMetricAggregator> _metricAggregators;
    private static AbstractCallInfo oUZPnCEB2AY2E4oQijbd;

    /// <summary>Ctor</summary>
    protected AbstractCallInfo()
    {
      AbstractCallInfo.eqqfRpEB1PI4EiojVwiM();
      this.workTree = new List<IWorkTreeElement>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            this.StartTime = AbstractCallInfo.tHxVomEBNid8BtXtPVfd();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_3;
          case 4:
            if (ComponentManager.Current.Stage == ComponentManager.LifetimeStage.Initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 6;
              continue;
            }
            goto label_10;
          case 5:
            goto label_14;
          case 6:
            if (AbstractCallInfo._metricAggregators != null)
            {
              num = 3;
              continue;
            }
            goto case 7;
          case 7:
            AbstractCallInfo._metricAggregators = ComponentManager.Current.GetExtensionPoints<IMetricAggregator>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
          default:
            if (!ComponentManager.Initialized)
            {
              num = 5;
              continue;
            }
            goto case 4;
        }
      }
label_11:
      return;
label_3:
      return;
label_14:
      return;
label_10:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
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

    /// <summary>Дата/время начала вызова</summary>
    public DateTime StartTime
    {
      get => this.\u003CStartTime\u003Ek__BackingField;
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
              this.\u003CStartTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

    /// <summary>Дата/время окончания вызова</summary>
    public DateTime EndTime
    {
      get => this.\u003CEndTime\u003Ek__BackingField;
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
              this.\u003CEndTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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

    /// <summary>Суммарное время работы</summary>
    public TimeSpan TotalTime
    {
      get => this.\u003CTotalTime\u003Ek__BackingField;
      protected set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTotalTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    /// <summary>Чистое время работы</summary>
    public TimeSpan ClearTime
    {
      get => this.\u003CClearTime\u003Ek__BackingField;
      protected set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CClearTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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

    /// <summary>Watch-ер для точного измерения времени работы</summary>
    public Stopwatch Stopwatch
    {
      get => this.\u003CStopwatch\u003Ek__BackingField;
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
              this.\u003CStopwatch\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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

    /// <summary>Информация о контексте выполнения</summary>
    public CallContextInfo ContextInfo
    {
      get => this.\u003CContextInfo\u003Ek__BackingField;
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
              this.\u003CContextInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

    /// <summary>Родительский вызов</summary>
    public AbstractCallInfo ParentCall
    {
      get => this.\u003CParentCall\u003Ek__BackingField;
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
              this.\u003CParentCall\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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
    public IEnumerable<IWorkTreeElement> WorkTree => (IEnumerable<IWorkTreeElement>) this.workTree.ToList<IWorkTreeElement>();

    /// <summary>Выполняется</summary>
    public bool IsPerfomed
    {
      get => this.\u003CIsPerfomed\u003Ek__BackingField;
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
              this.\u003CIsPerfomed\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
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

    /// <summary>Ошибка вызова</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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

    /// <summary>Тип вызова</summary>
    public abstract string CallType { get; }

    /// <summary>Описание</summary>
    public abstract string Description { get; }

    /// <summary>Начать вызов</summary>
    /// <param name="callContext">Информация о контексте вызова</param>
    public virtual void StartCall(CallContextInfo callContext)
    {
      int num = 16;
      IEmptyCallInfo emptyCallInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 10:
            this.ContextInfo = callContext;
            num = 6;
            continue;
          case 2:
            if (emptyCallInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
              continue;
            }
            goto case 18;
          case 3:
            AbstractCallInfo.iSObGcEBaQH4houS7ofV((object) this.ParentCall, (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 13 : 11;
            continue;
          case 4:
            callContext.AddWorkTreeElement((IWorkTreeElement) this);
            num = 12;
            continue;
          case 5:
            if (this.ParentCall != null)
            {
              num = 3;
              continue;
            }
            goto case 4;
          case 6:
            this.Id = callContext.GetNewCallId();
            num = 8;
            continue;
          case 7:
            this.IsPerfomed = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 8:
            this.ParentCall = (AbstractCallInfo) AbstractCallInfo.JRr5UnEBptvpELFdquMX((object) callContext);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 5 : 5;
            continue;
          case 9:
            goto label_23;
          case 11:
            this.StartTime = AbstractCallInfo.tHxVomEBNid8BtXtPVfd();
            num = 14;
            continue;
          case 12:
          case 13:
            AbstractCallInfo.CX9LMEEBDrmbdLg2DBdr((object) callContext, (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 6 : 11;
            continue;
          case 14:
            this.Stopwatch = Stopwatch.StartNew();
            num = 7;
            continue;
          case 15:
            if (callContext != null)
            {
              num = 2;
              continue;
            }
            goto label_6;
          case 16:
            emptyCallInfo = this as IEmptyCallInfo;
            num = 15;
            continue;
          case 17:
            goto label_15;
          case 18:
            if (!AbstractCallInfo.JiHIwYEB3tHOgliKwvLL((object) emptyCallInfo))
            {
              num = 10;
              continue;
            }
            goto label_22;
          default:
            AbstractCallInfo.irB82dEBt7AjBX7br1uw((object) this);
            num = 9;
            continue;
        }
      }
label_23:
      return;
label_15:
      return;
label_22:
      return;
label_6:;
    }

    /// <summary>Завершить вызов</summary>
    protected virtual void StopCall()
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (AbstractCallInfo._metricAggregators != null)
              {
                num2 = 9;
                continue;
              }
              goto label_12;
            case 2:
              this.IsPerfomed = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 3 : 10;
              continue;
            case 3:
              AbstractCallInfo.CX9LMEEBDrmbdLg2DBdr((object) this.ContextInfo, (object) this.ParentCall);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 2;
              continue;
            case 4:
              this.TotalTime = AbstractCallInfo.CIGIj7EB4GRIlp7Gt36E((object) this.Stopwatch);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 3;
              continue;
            case 5:
              goto label_3;
            case 6:
              this.EndTime = AbstractCallInfo.tHxVomEBNid8BtXtPVfd();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 4;
              continue;
            case 7:
              AbstractCallInfo.KstZ43EBw8uR3t7MMVfe((object) this.Stopwatch);
              num2 = 6;
              continue;
            case 8:
              this.workTree.ForEach((Action<IWorkTreeElement>) (a =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      this.ClearTime = AbstractCallInfo.aQVwgxEBJxaig5ulnLYO(this.ClearTime, AbstractCallInfo.LANS0CEBMmInQa2wL66X((object) a));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
              continue;
            case 9:
              AbstractCallInfo._metricAggregators.ForEach<IMetricAggregator>((Action<IMetricAggregator>) (ma =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      AbstractCallInfo.vpxeEwEB9MnwdWFBG3vn((object) ma, (object) this, (object) this.ContextInfo.Metrics);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 10:
              this.ClearTime = this.TotalTime;
              num2 = 8;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        DiagnosticsManager.Helper.StopCallHelper(this);
        num1 = 5;
      }
label_3:;
    }

    /// <inheritdoc />
    public void Dispose()
    {
      int num = 1;
      IEmptyCallInfo emptyCallInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            emptyCallInfo = this as IEmptyCallInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            if (emptyCallInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 2 : 6;
              continue;
            }
            goto case 5;
          case 3:
          case 6:
            AbstractCallInfo.YmwUbMEB6UuuhfBBpaEs((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 7;
            continue;
          case 4:
            goto label_12;
          case 5:
            if (!AbstractCallInfo.JiHIwYEB3tHOgliKwvLL((object) emptyCallInfo))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 3 : 3;
              continue;
            }
            goto label_5;
          case 7:
            goto label_8;
          case 8:
            goto label_2;
          default:
            if (!this.IsPerfomed)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 8 : 8;
              continue;
            }
            goto case 2;
        }
      }
label_12:
      return;
label_8:
      return;
label_2:
      return;
label_5:;
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 17;
      while (true)
      {
        switch (num)
        {
          case 1:
            AbstractCallInfo.r1VcqXEBm8whPRLA7Ysp((object) info, AbstractCallInfo.WDA9QiEBAJBCYmtuilLx(589593376 ^ -1977315327 ^ -1459305931), this.EndTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          case 2:
            info.AddValue((string) AbstractCallInfo.WDA9QiEBAJBCYmtuilLx(-342626196 - 1290888215 ^ -1633245945), (object) this.WorkTree);
            num = 8;
            continue;
          case 3:
            if (AbstractCallInfo.JpjP6aEByqYtUrjn2wXw((object) this.workTree) == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 18 : 18;
              continue;
            }
            goto case 2;
          case 4:
            AbstractCallInfo.JjPlEREBx6oVVqn60pSq((object) info, AbstractCallInfo.WDA9QiEBAJBCYmtuilLx(--1333735954 ^ 1333467896), (object) this.CallType);
            num = 9;
            continue;
          case 5:
            info.AddValue((string) AbstractCallInfo.WDA9QiEBAJBCYmtuilLx(-1978478350 ^ -1978490062), (object) this.Name);
            num = 14;
            continue;
          case 6:
            AbstractCallInfo.JjPlEREBx6oVVqn60pSq((object) info, AbstractCallInfo.WDA9QiEBAJBCYmtuilLx(-1334993905 ^ -1335054891), AbstractCallInfo.RjoOoYEB7yO7pb4wUyY9((object) this));
            num = 11;
            continue;
          case 7:
          case 14:
            if (AbstractCallInfo.nOww3tEBHHmFVjiXkYpW(AbstractCallInfo.RjoOoYEB7yO7pb4wUyY9((object) this)))
            {
              num = 10;
              continue;
            }
            goto case 6;
          case 8:
          case 18:
            if (this.Exception != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 13 : 9;
              continue;
            }
            goto label_7;
          case 9:
            info.AddValue((string) AbstractCallInfo.WDA9QiEBAJBCYmtuilLx(-1822890472 ^ -1822634266), this.StartTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
            continue;
          case 10:
          case 11:
            if (!AbstractCallInfo.nOww3tEBHHmFVjiXkYpW(AbstractCallInfo.wgiNKhEB0xO0IpTBimZX((object) this)))
            {
              num = 4;
              continue;
            }
            goto case 9;
          case 12:
            goto label_12;
          case 13:
            info.AddValue((string) AbstractCallInfo.WDA9QiEBAJBCYmtuilLx(-951514650 ^ -951246720), (object) this.Exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 12 : 4;
            continue;
          case 15:
            this.GetObjectData(info, context);
            num = 3;
            continue;
          case 16:
            if (AbstractCallInfo.nOww3tEBHHmFVjiXkYpW((object) this.Name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 7 : 6;
              continue;
            }
            goto case 5;
          case 17:
            info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461592775), this.Id);
            num = 16;
            continue;
          case 19:
            info.AddValue((string) AbstractCallInfo.WDA9QiEBAJBCYmtuilLx(-606654180 ^ -606922720), (object) this.ClearTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 3 : 15;
            continue;
          default:
            AbstractCallInfo.JjPlEREBx6oVVqn60pSq((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210453787), (object) this.TotalTime);
            num = 19;
            continue;
        }
      }
label_12:
      return;
label_7:;
    }

    /// <summary>Дополнить данные для сериализации объекта</summary>
    /// <param name="info">Данные для сериализации</param>
    /// <param name="context">Контекст потока сериализации</param>
    protected abstract void GetObjectData(SerializationInfo info, StreamingContext context);

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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void eqqfRpEB1PI4EiojVwiM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static DateTime tHxVomEBNid8BtXtPVfd() => DateTime.UtcNow;

    internal static bool G28irCEBeQIuIuK5rUqe() => AbstractCallInfo.oUZPnCEB2AY2E4oQijbd == null;

    internal static AbstractCallInfo VrScqREBPDjSPbxgmLwd() => AbstractCallInfo.oUZPnCEB2AY2E4oQijbd;

    internal static bool JiHIwYEB3tHOgliKwvLL([In] object obj0) => ((IEmptyCallInfo) obj0).IsEmpty;

    internal static object JRr5UnEBptvpELFdquMX([In] object obj0) => (object) ((CallContextInfo) obj0).CurrentCall;

    internal static void iSObGcEBaQH4houS7ofV([In] object obj0, [In] object obj1) => ((AbstractCallInfo) obj0).AddWorkTreeElement((IWorkTreeElement) obj1);

    internal static void CX9LMEEBDrmbdLg2DBdr([In] object obj0, [In] object obj1) => ((CallContextInfo) obj0).CurrentCall = (AbstractCallInfo) obj1;

    internal static void irB82dEBt7AjBX7br1uw([In] object obj0) => DiagnosticsManager.Helper.StartCallHelper((AbstractCallInfo) obj0);

    internal static void KstZ43EBw8uR3t7MMVfe([In] object obj0) => ((Stopwatch) obj0).Stop();

    internal static TimeSpan CIGIj7EB4GRIlp7Gt36E([In] object obj0) => ((Stopwatch) obj0).Elapsed;

    internal static void YmwUbMEB6UuuhfBBpaEs([In] object obj0) => ((AbstractCallInfo) obj0).StopCall();

    internal static bool nOww3tEBHHmFVjiXkYpW([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static object WDA9QiEBAJBCYmtuilLx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RjoOoYEB7yO7pb4wUyY9([In] object obj0) => (object) ((AbstractCallInfo) obj0).Description;

    internal static void JjPlEREBx6oVVqn60pSq([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static object wgiNKhEB0xO0IpTBimZX([In] object obj0) => (object) ((AbstractCallInfo) obj0).CallType;

    internal static void r1VcqXEBm8whPRLA7Ysp([In] object obj0, [In] object obj1, [In] DateTime obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static int JpjP6aEByqYtUrjn2wXw([In] object obj0) => ((List<IWorkTreeElement>) obj0).Count;

    internal static TimeSpan LANS0CEBMmInQa2wL66X([In] object obj0) => ((IWorkTreeElement) obj0).TotalTime;

    internal static TimeSpan aQVwgxEBJxaig5ulnLYO([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 - obj1;

    internal static void vpxeEwEB9MnwdWFBG3vn([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricAggregator) obj0).Add(obj1, (MetricsContainer) obj2);
  }
}
