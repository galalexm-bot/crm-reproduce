// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.AuditableEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Параметры события для обработчика <see cref="T:EleWise.ELMA.Events.Audit.IAuditableEventHandler" />
  /// </summary>
  [Serializable]
  public class AuditableEventArgs : AuditEventArgs
  {
    private static AuditableEventArgs pYZjC3GL76HEooggow4m;

    /// <summary>Ctor</summary>
    public AuditableEventArgs()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Params = new Dictionary<string, object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    /// <summary>Тип объекта, у которого идет вызов</summary>
    public Type InvokerType
    {
      get => this.\u003CInvokerType\u003Ek__BackingField;
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
              this.\u003CInvokerType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    /// <summary>Вызываемый метод</summary>
    public MethodInfo Method
    {
      get => this.\u003CMethod\u003Ek__BackingField;
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
              this.\u003CMethod\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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
    public Dictionary<string, object> Params { get; set; }

    /// <summary>Результат</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672460350)] = this.Invoker;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638667527)] = (object) this.InvokerType;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669630185)] = (object) this.Method;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712215205)] = (object) this.Params;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813442649)] = this.Result;
        return extendedProperties;
      }
    }

    internal static bool uauZYnGLxKTW97OEpfgS() => AuditableEventArgs.pYZjC3GL76HEooggow4m == null;

    internal static AuditableEventArgs IEbUBlGL0283sD5eFCUy() => AuditableEventArgs.pYZjC3GL76HEooggow4m;
  }
}
