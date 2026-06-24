// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RequiredFieldAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Validation
{
  [AttributeUsage(AttributeTargets.All)]
  public class RequiredFieldAttribute : RequiredAttribute
  {
    internal static RequiredFieldAttribute i1G1ZJo5GX34hqBVmYUd;

    public RequiredFieldAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            RequiredFieldAttribute.tQacMRo5CoX4gi1CSQtt((object) this, (object) EleWise.ELMA.SR.T((string) RequiredFieldAttribute.bbcwvmo5Q2GBP36J268x(1251470110 >> 2 ^ 312859581)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public RequiredFieldAttribute(string message)
    {
      RequiredFieldAttribute.rffO02o5v8vKdTHMOZp7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (!string.IsNullOrEmpty(message))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 3:
            message = (string) RequiredFieldAttribute.F8YYYIo584LBCWsG3yPc(RequiredFieldAttribute.bbcwvmo5Q2GBP36J268x(-1217523399 ^ -1217515453));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
            continue;
          case 4:
            goto label_4;
          default:
            RequiredFieldAttribute.tQacMRo5CoX4gi1CSQtt((object) this, (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 4;
            continue;
        }
      }
label_4:;
    }

    internal static object bbcwvmo5Q2GBP36J268x(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void tQacMRo5CoX4gi1CSQtt([In] object obj0, [In] object obj1) => ((ValidationAttribute) obj0).ErrorMessage = (string) obj1;

    internal static bool pw4DsQo5Eq9EC0buptNE() => RequiredFieldAttribute.i1G1ZJo5GX34hqBVmYUd == null;

    internal static RequiredFieldAttribute B33OHCo5fq45FOeveLl8() => RequiredFieldAttribute.i1G1ZJo5GX34hqBVmYUd;

    internal static void rffO02o5v8vKdTHMOZp7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object F8YYYIo584LBCWsG3yPc([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
