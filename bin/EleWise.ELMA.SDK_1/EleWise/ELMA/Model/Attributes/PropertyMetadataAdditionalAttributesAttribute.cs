// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.PropertyMetadataAdditionalAttributesAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  [AttributeUsage(AttributeTargets.Property)]
  public class PropertyMetadataAdditionalAttributesAttribute : Attribute
  {
    private readonly string additionalAttributes;
    internal static PropertyMetadataAdditionalAttributesAttribute yZKCCyoCJEtCmnt0ZBfq;

    public PropertyMetadataAdditionalAttributesAttribute(string additionalAttributes)
    {
      PropertyMetadataAdditionalAttributesAttribute.Yyu1FtoClAndDQ8eU5Rk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.additionalAttributes = additionalAttributes;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public string AdditionalAttributes => this.additionalAttributes;

    internal static void Yyu1FtoClAndDQ8eU5Rk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool yTtYERoC9ppSjWUc2xmK() => PropertyMetadataAdditionalAttributesAttribute.yZKCCyoCJEtCmnt0ZBfq == null;

    internal static PropertyMetadataAdditionalAttributesAttribute DJtTmEoCdiBsInxMJLSF() => PropertyMetadataAdditionalAttributesAttribute.yZKCCyoCJEtCmnt0ZBfq;
  }
}
