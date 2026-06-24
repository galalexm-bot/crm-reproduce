// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.RazorInjectionAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    internal static RazorInjectionAttribute j1mvavfvOQrZlKYDj4jt;

    public RazorInjectionAttribute(string type, string fieldName)
    {
      RazorInjectionAttribute.WGum7ifvPxLsm5G8j6qN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.FieldName = fieldName;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.Type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public string Type
    {
      get => this.\u003CType\u003Ek__BackingField;
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
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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

    public string FieldName
    {
      get => this.\u003CFieldName\u003Ek__BackingField;
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
              this.\u003CFieldName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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

    internal static void WGum7ifvPxLsm5G8j6qN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool RkTUjBfv2td5jWJJ6IhD() => RazorInjectionAttribute.j1mvavfvOQrZlKYDj4jt == null;

    internal static RazorInjectionAttribute TFJDtufveBfXxsTQoy10() => RazorInjectionAttribute.j1mvavfvOQrZlKYDj4jt;
  }
}
