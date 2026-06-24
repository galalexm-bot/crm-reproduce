// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.AspTypePropertyAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class AspTypePropertyAttribute : Attribute
  {
    private static AspTypePropertyAttribute G6Ef3Rfvi0AJyxOZT6xl;

    public bool CreateConstructorReferences
    {
      get => this.\u003CCreateConstructorReferences\u003Ek__BackingField;
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
              this.\u003CCreateConstructorReferences\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    public AspTypePropertyAttribute(bool createConstructorReferences)
    {
      AspTypePropertyAttribute.Ur2m4OfvKVvAixjFACM4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.CreateConstructorReferences = createConstructorReferences;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    internal static bool txgXqdfvRfX6pkTiBdtc() => AspTypePropertyAttribute.G6Ef3Rfvi0AJyxOZT6xl == null;

    internal static AspTypePropertyAttribute UCmNynfvqrgmYjOvl5c3() => AspTypePropertyAttribute.G6Ef3Rfvi0AJyxOZT6xl;

    internal static void Ur2m4OfvKVvAixjFACM4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
