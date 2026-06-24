// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ImplementAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Навешивается на сущность и указывает интерфейс, который она реализует.
  /// Для таких интерфейсов доступен метод InstanceActivator.CreateInstance
  /// </summary>
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  public class ImplementAttribute : Attribute
  {
    private Type interfaceType;
    private static ImplementAttribute Pp3hNoo87J6mxSyX4HMs;

    /// <summary>Ctor</summary>
    /// <param name="interfaceType">Тип интерфейса</param>
    public ImplementAttribute(Type interfaceType)
    {
      ImplementAttribute.MgID1io8mkoyc3pBtIqh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.interfaceType = interfaceType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Тип интерфейса</summary>
    public Type InterfaceType => this.interfaceType;

    internal static void MgID1io8mkoyc3pBtIqh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool KuVgHAo8xhFuR9pSMvfU() => ImplementAttribute.Pp3hNoo87J6mxSyX4HMs == null;

    internal static ImplementAttribute tbLjJpo80XZyJIYSrRF5() => ImplementAttribute.Pp3hNoo87J6mxSyX4HMs;
  }
}
