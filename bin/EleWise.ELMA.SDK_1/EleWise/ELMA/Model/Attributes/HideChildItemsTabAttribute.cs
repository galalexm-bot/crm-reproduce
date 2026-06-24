// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.HideChildItemsTabAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, указывающий, нужно ли показывать вкладку "Вложенные свойства"
  /// в свойствах отображения контрола сущности в дизайнере
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
  public class HideChildItemsTabAttribute : Attribute
  {
    private readonly bool needHide;
    private static HideChildItemsTabAttribute CQqweDofJBGoGeAV0Va1;

    /// <summary>Ctor</summary>
    public HideChildItemsTabAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(true);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="needHide">Нужно ли скрывать</param>
    public HideChildItemsTabAttribute(bool needHide)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.needHide = needHide;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Нужно ли скрывать</summary>
    public bool NeedHide => this.needHide;

    internal static bool UCu1FNof9k3xAxweonvf() => HideChildItemsTabAttribute.CQqweDofJBGoGeAV0Va1 == null;

    internal static HideChildItemsTabAttribute k8KZEKofd0ByVICdEM0D() => HideChildItemsTabAttribute.CQqweDofJBGoGeAV0Va1;
  }
}
