// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.AssemblyModuleAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>Указывает модуль, к которому относится данная сборка</summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class AssemblyModuleAttribute : Attribute
  {
    private Guid uid;
    internal static AssemblyModuleAttribute jVn61xabaatVej9GilC;

    /// <summary>Ctor</summary>
    /// <param name="uid">Уникальный идентификатор модуля</param>
    public AssemblyModuleAttribute(string uid)
    {
      AssemblyModuleAttribute.vibIaJaEWjFn0bsICPY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.uid = new Guid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Уникальный идентификатор модуля</summary>
    public Guid Uid => this.uid;

    internal static void vibIaJaEWjFn0bsICPY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JUUIlTahX3UHyxLNYOm() => AssemblyModuleAttribute.jVn61xabaatVej9GilC == null;

    internal static AssemblyModuleAttribute csu5GRaG3uxGaxRwjRX() => AssemblyModuleAttribute.jVn61xabaatVej9GilC;
  }
}
