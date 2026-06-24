// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.EnumMetadataAdditionalAttributesAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  public class EnumMetadataAdditionalAttributesAttribute : Attribute
  {
    private readonly string enumAdditionalAttributes;
    internal static EnumMetadataAdditionalAttributesAttribute OLpO88oQ4hJJNjfjkRkp;

    public EnumMetadataAdditionalAttributesAttribute(string enumAdditionalAttributes)
    {
      EnumMetadataAdditionalAttributesAttribute.QRcg7loQAtwxYnBNYWJX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.enumAdditionalAttributes = enumAdditionalAttributes;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string EnumAdditionalAttributes => this.enumAdditionalAttributes;

    internal static void QRcg7loQAtwxYnBNYWJX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Dao8eToQ6fgtqf70Qt23() => EnumMetadataAdditionalAttributesAttribute.OLpO88oQ4hJJNjfjkRkp == null;

    internal static EnumMetadataAdditionalAttributesAttribute bas1PeoQHSZFRKIyGcxF() => EnumMetadataAdditionalAttributesAttribute.OLpO88oQ4hJJNjfjkRkp;
  }
}
