// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.EmailFormat.EmailFormatSettingsModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Messaging.EmailFormat
{
  [Component]
  public class EmailFormatSettingsModule : GlobalSettingsModuleBase<EmailFormatSettings>
  {
    public static Guid UID;
    private static EmailFormatSettingsModule PIPfKbhy9mLDB5t3ylMW;

    public override Guid ModuleGuid => EmailFormatSettingsModule.UID;

    /// <summary>Название модуля</summary>
    public override string ModuleName => (string) EmailFormatSettingsModule.OyRARdhygtSqUNxBeefw(EmailFormatSettingsModule.QNXJg1hyrPja1gbXjV5M(--1360331293 ^ 1360431643));

    public string GetPrefix(string emailFormatName)
    {
      int num = 2;
      EmailFormatInfo emailFormatInfo;
      string emailFormatName1;
      while (true)
      {
        switch (num)
        {
          case 1:
            emailFormatName1 = emailFormatName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 3;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
            continue;
          case 3:
            if (this.Settings == null)
            {
              num = 4;
              continue;
            }
            goto case 7;
          case 4:
          case 6:
            goto label_8;
          case 5:
            if (emailFormatInfo != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 8 : 3;
              continue;
            }
            goto label_13;
          case 7:
            if (this.Settings.Formats != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 8:
            goto label_12;
          default:
            // ISSUE: reference to a compiler-generated method
            emailFormatInfo = this.Settings.Formats.FirstOrDefault<EmailFormatInfo>((Func<EmailFormatInfo, bool>) (i => (string) EmailFormatSettingsModule.\u003C\u003Ec__DisplayClass5_0.dor3vqv6HbYrwDIHVZ3c((object) i) == emailFormatName1));
            num = 5;
            continue;
        }
      }
label_8:
      return (string) null;
label_12:
      return (string) EmailFormatSettingsModule.yKXZ8why5O1XvQw3AsIB((object) emailFormatInfo);
label_13:
      return (string) null;
    }

    public EmailFormatSettingsModule()
    {
      EmailFormatSettingsModule.kc95kChyjlhcw91uFVbY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EmailFormatSettingsModule()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EmailFormatSettingsModule.UID = new Guid((string) EmailFormatSettingsModule.QNXJg1hyrPja1gbXjV5M(-1290212282 ^ -644262414 ^ 1786917352));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 2:
            EmailFormatSettingsModule.kc95kChyjlhcw91uFVbY();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object QNXJg1hyrPja1gbXjV5M(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OyRARdhygtSqUNxBeefw([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool UGoBGIhydWM01voGoIpx() => EmailFormatSettingsModule.PIPfKbhy9mLDB5t3ylMW == null;

    internal static EmailFormatSettingsModule C5alQKhyleiFIcB3b41p() => EmailFormatSettingsModule.PIPfKbhy9mLDB5t3ylMW;

    internal static object yKXZ8why5O1XvQw3AsIB([In] object obj0) => (object) ((EmailFormatInfo) obj0).SubjectPrefix;

    internal static void kc95kChyjlhcw91uFVbY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
