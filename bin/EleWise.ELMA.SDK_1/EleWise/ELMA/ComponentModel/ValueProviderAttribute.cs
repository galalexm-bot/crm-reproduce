// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ValueProviderAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// For a parameter that is expected to be one of the limited set of values.
  /// Specify fields of which type should be used as values for this parameter.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
  public sealed class ValueProviderAttribute : Attribute
  {
    internal static ValueProviderAttribute Il8ABjfffI5gEM0tGCvd;

    public ValueProviderAttribute(string name)
    {
      ValueProviderAttribute.tMfP5dffvIaKbGuLAmmN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Name = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
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

    internal static void tMfP5dffvIaKbGuLAmmN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool qgTOoOffQnj7vfhiUC7e() => ValueProviderAttribute.Il8ABjfffI5gEM0tGCvd == null;

    internal static ValueProviderAttribute gwjdeSffCaKXgbeRT6Pb() => ValueProviderAttribute.Il8ABjfffI5gEM0tGCvd;
  }
}
