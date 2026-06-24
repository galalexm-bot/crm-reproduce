// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.MethodImplementationNameAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  [AttributeUsage(AttributeTargets.Method)]
  public class MethodImplementationNameAttribute : Attribute
  {
    private static MethodImplementationNameAttribute nHHhnNoQSUKQMWpd0Tpm;

    public MethodImplementationNameAttribute(string methodName)
    {
      MethodImplementationNameAttribute.ExWmj9oQqaxapPrDdOxh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.MethodName = methodName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string MethodName
    {
      get => this.\u003CMethodName\u003Ek__BackingField;
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
              this.\u003CMethodName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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

    internal static void ExWmj9oQqaxapPrDdOxh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pB978goQiRWTsIxeROni() => MethodImplementationNameAttribute.nHHhnNoQSUKQMWpd0Tpm == null;

    internal static MethodImplementationNameAttribute oi22PVoQR1qhYDjrg7uy() => MethodImplementationNameAttribute.nHHhnNoQSUKQMWpd0Tpm;
  }
}
