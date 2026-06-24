// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.CopyActionAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, указывающий, что нужно делать с объектом при копировании связанного объекта
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Interface)]
  public class CopyActionAttribute : Attribute
  {
    private readonly CopyAction copyAction;
    internal static CopyActionAttribute r2sys4oCqwarR4T0wm5n;

    public CopyActionAttribute()
    {
      CopyActionAttribute.JNPA8ZoCTEbEDUnvM6ed();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public CopyActionAttribute(CopyAction copyAction)
    {
      CopyActionAttribute.JNPA8ZoCTEbEDUnvM6ed();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.copyAction = copyAction;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public CopyAction CopyAction => this.copyAction;

    internal static void JNPA8ZoCTEbEDUnvM6ed() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool EXy9KxoCKIP4Y0TLm66p() => CopyActionAttribute.r2sys4oCqwarR4T0wm5n == null;

    internal static CopyActionAttribute Ik21NOoCXFXtpv4ZUHbX() => CopyActionAttribute.r2sys4oCqwarR4T0wm5n;
  }
}
