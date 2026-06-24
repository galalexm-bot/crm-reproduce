// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.HtmlAttributeValueAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
  public sealed class HtmlAttributeValueAttribute : Attribute
  {
    internal static HtmlAttributeValueAttribute jTWbYJfCRO6FQRmYjwy7;

    public HtmlAttributeValueAttribute([NotNull] string name)
    {
      HtmlAttributeValueAttribute.sQo8QBfCXctHAJ9qCgty();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Name = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    [NotNull]
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    internal static void sQo8QBfCXctHAJ9qCgty() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool q45oKmfCqhGMsC8MsePT() => HtmlAttributeValueAttribute.jTWbYJfCRO6FQRmYjwy7 == null;

    internal static HtmlAttributeValueAttribute rM66JRfCKl7p1jjgiWL8() => HtmlAttributeValueAttribute.jTWbYJfCRO6FQRmYjwy7;
  }
}
