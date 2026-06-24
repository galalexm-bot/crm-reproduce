// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionInvokeEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Actions
{
  /// <summary>Аргументы для вызова и проверки действий</summary>
  [Serializable]
  public class ActionInvokeEventArgs : AuditEventArgs
  {
    internal static ActionInvokeEventArgs P6mm9Bft7kN0VAjE8x4n;

    /// <summary>Конструктор</summary>
    public ActionInvokeEventArgs()
    {
      ActionInvokeEventArgs.HntYoeftmQRgF9Tiv9f9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Params = (ICollection<object>) new List<object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Объект, у которого идет вызов метода</summary>
    public object Invoker
    {
      get => this.\u003CInvoker\u003Ek__BackingField;
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
              this.\u003CInvoker\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

    /// <summary>Входящие параметры</summary>
    public ICollection<object> Params { get; set; }

    /// <summary>Выполнено ли действие до конца</summary>
    public bool Invoked
    {
      get => this.\u003CInvoked\u003Ek__BackingField;
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
              this.\u003CInvoked\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    /// <summary>Результат</summary>
    /// <remarks>
    /// В данном поле всегда находится реальный результат, который возвращает метод.
    /// Например, если вызываемая операция асинхронная и возвращает Task{TResult}, то
    /// в данное поле будет записан экземпляр класса TResult.
    /// </remarks>
    public object Result
    {
      get => this.\u003CResult\u003Ek__BackingField;
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
              this.\u003CResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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

    /// <summary>Получить словарь свойств расширения объекта</summary>
    public override IDictionary<string, object> ExtendedProperties
    {
      get
      {
        IDictionary<string, object> extendedProperties = base.ExtendedProperties;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993179615)] = this.Invoker;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757342028)] = (object) this.Invoked;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867115745)] = (object) this.Params;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139051408)] = this.Result;
        return extendedProperties;
      }
    }

    internal static void HntYoeftmQRgF9Tiv9f9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xHhjCgftxxm8dQSAj9Xh() => ActionInvokeEventArgs.P6mm9Bft7kN0VAjE8x4n == null;

    internal static ActionInvokeEventArgs WcHmHvft0Ipt7Nr3Jknp() => ActionInvokeEventArgs.P6mm9Bft7kN0VAjE8x4n;
  }
}
