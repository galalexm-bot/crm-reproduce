// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.ModuleDefaultStatusAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>Определяет статус по умолчанию модуля ELMA</summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class ModuleDefaultStatusAttribute : Attribute
  {
    private ModuleStatus status;
    internal static ModuleDefaultStatusAttribute kq0n9epUCtJ7091myJv;

    /// <summary>Ctor</summary>
    /// <param name="status">Статус модуля</param>
    public ModuleDefaultStatusAttribute(ModuleStatus status)
    {
      ModuleDefaultStatusAttribute.hC1UBKpzK5KV9HDeiiY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.status = status;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Статус модуля</summary>
    public ModuleStatus Status => this.status;

    internal static void hC1UBKpzK5KV9HDeiiY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hAfsTDpslISUFPu3gni() => ModuleDefaultStatusAttribute.kq0n9epUCtJ7091myJv == null;

    internal static ModuleDefaultStatusAttribute xV4cu9pco4sYUI62X8Q() => ModuleDefaultStatusAttribute.kq0n9epUCtJ7091myJv;
  }
}
