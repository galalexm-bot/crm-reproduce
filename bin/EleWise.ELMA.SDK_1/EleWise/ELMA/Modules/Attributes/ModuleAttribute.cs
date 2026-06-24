// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.ModuleAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>Атрибут, содержащий базовые параметры модуля ELMA</summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class ModuleAttribute : Attribute
  {
    private string id;
    private Guid uid;
    private static ModuleAttribute NjhGBtaftS7q38fGlSi;

    /// <summary>Ctor</summary>
    /// <param name="id">Строковый идентификатор модуля</param>
    /// <param name="uid">Уникальный идентификатор модуля</param>
    public ModuleAttribute(string id, string uid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.uid = new Guid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 2:
            this.id = id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Строковый идентификатор модуля</summary>
    public string Id => this.id;

    /// <summary>Уникальный идентификатор модуля</summary>
    public Guid Uid => this.uid;

    internal static bool llLRPsaQIRgZxZkIKpC() => ModuleAttribute.NjhGBtaftS7q38fGlSi == null;

    internal static ModuleAttribute joGvD4aCx6Jg7C3NIUV() => ModuleAttribute.NjhGBtaftS7q38fGlSi;
  }
}
