// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.AspMvcAreaMasterLocationFormatAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
  {
    private static AspMvcAreaMasterLocationFormatAttribute Wg6BYMfQCTroYtO1vu7Q;

    public AspMvcAreaMasterLocationFormatAttribute(string format)
    {
      AspMvcAreaMasterLocationFormatAttribute.P5g9N2fQZvjv0PLuh1fu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Format = format;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string Format
    {
      get => this.\u003CFormat\u003Ek__BackingField;
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
              this.\u003CFormat\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    internal static void P5g9N2fQZvjv0PLuh1fu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool o0ykl5fQvev3mlFYjJae() => AspMvcAreaMasterLocationFormatAttribute.Wg6BYMfQCTroYtO1vu7Q == null;

    internal static AspMvcAreaMasterLocationFormatAttribute px16MMfQ8BJDh3U9LUNI() => AspMvcAreaMasterLocationFormatAttribute.Wg6BYMfQCTroYtO1vu7Q;
  }
}
