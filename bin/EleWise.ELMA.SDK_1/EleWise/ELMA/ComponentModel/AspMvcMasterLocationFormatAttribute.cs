// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.AspMvcMasterLocationFormatAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class AspMvcMasterLocationFormatAttribute : Attribute
  {
    internal static AspMvcMasterLocationFormatAttribute JcrZN5fQKqafgwgqSeC7;

    public AspMvcMasterLocationFormatAttribute(string format)
    {
      AspMvcMasterLocationFormatAttribute.vc8O5tfQk24q9BD90cCJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Format = format;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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

    internal static void vc8O5tfQk24q9BD90cCJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool mlfsbHfQXhUUL2GllhFI() => AspMvcMasterLocationFormatAttribute.JcrZN5fQKqafgwgqSeC7 == null;

    internal static AspMvcMasterLocationFormatAttribute vMh8MLfQTyGk0kY4a3iU() => AspMvcMasterLocationFormatAttribute.JcrZN5fQKqafgwgqSeC7;
  }
}
