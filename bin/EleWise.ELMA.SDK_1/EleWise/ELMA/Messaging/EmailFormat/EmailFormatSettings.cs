// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.EmailFormat.EmailFormatSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Messaging.EmailFormat
{
  /// <summary>Настройка форматов для электронных писем</summary>
  public class EmailFormatSettings : GlobalSettingsBase
  {
    public List<EmailFormatInfo> _formats;
    internal static EmailFormatSettings jTm3kGhy4EAoMomJQ3Dl;

    public EmailFormatSettings()
    {
      EmailFormatSettings.r0pXeBhyAgU6Vd6neGCS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._formats = new List<EmailFormatInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    [HiddenInput(DisplayValue = false)]
    public List<EmailFormatInfo> Formats
    {
      get
      {
        if (this._formats.Count == 0)
          this.Init();
        return this._formats;
      }
      set => this._formats = value;
    }

    public void Init()
    {
      int num1 = 3;
      EmailFormatSettings emailFormatSettings;
      List<IEmailFormat> emailFormats;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            this._formats.RemoveAll((Predicate<EmailFormatInfo>) (i =>
            {
              int num2 = 2;
              EmailFormatInfo i1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    i1 = i;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                    continue;
                  case 2:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return emailFormats.All<IEmailFormat>((Func<IEmailFormat, bool>) (c => EmailFormatSettings.\u003C\u003Ec__DisplayClass5_2.SvWjSmv6NZ57mNr8RtFM(EmailFormatSettings.\u003C\u003Ec__DisplayClass5_2.shEqLYv6P4mPAANrnK7v((object) c), EmailFormatSettings.\u003C\u003Ec__DisplayClass5_2.Tu42NXv61hZMvTpGQDWt((object) i1))));
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          case 2:
            emailFormatSettings = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 3;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 2;
            continue;
          case 4:
            emailFormats = ((ComponentManager) EmailFormatSettings.jmQdkMhy7iP1xFc60DqT()).GetExtensionPoints<IEmailFormat>().ToList<IEmailFormat>();
            num1 = 5;
            continue;
          case 5:
            emailFormats.ForEach((Action<IEmailFormat>) (c =>
            {
              int num3 = 3;
              while (true)
              {
                int num4 = num3;
                EmailFormatInfo emailFormatInfo1;
                IEmailFormat c1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_5;
                    case 1:
                      emailFormatSettings._formats.Add(emailFormatInfo1);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                      continue;
                    case 2:
                      c1 = c;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 1;
                      continue;
                    case 3:
                      goto label_8;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!emailFormatSettings._formats.All<EmailFormatInfo>((Func<EmailFormatInfo, bool>) (i => EmailFormatSettings.\u003C\u003Ec__DisplayClass5_1.LE8pirv6nYE1AqCUhY4k(EmailFormatSettings.\u003C\u003Ec__DisplayClass5_1.cfOFQTv6T78uVy63ucXN((object) i), EmailFormatSettings.\u003C\u003Ec__DisplayClass5_1.J8pxo2v6kl5LPdWfja77((object) c1)))))
                      {
                        num4 = 5;
                        continue;
                      }
                      goto case 6;
                    case 5:
                      goto label_3;
                    case 6:
                      EmailFormatInfo emailFormatInfo2 = new EmailFormatInfo();
                      // ISSUE: reference to a compiler-generated method
                      emailFormatInfo2.Name = (string) EmailFormatSettings.\u003C\u003Ec__DisplayClass5_0.aPCxVWv6iYeZg0nTUhtO((object) c1);
                      // ISSUE: reference to a compiler-generated method
                      EmailFormatSettings.\u003C\u003Ec__DisplayClass5_0.WOV0qkv6RHr1H41HnmTX((object) emailFormatInfo2, (object) c1.SubjectPrefix);
                      emailFormatInfo1 = emailFormatInfo2;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                      continue;
                    default:
                      goto label_11;
                  }
                }
label_8:
                num3 = 2;
              }
label_5:
              return;
label_3:
              return;
label_11:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    public string SerializedFormats
    {
      get
      {
        object separator = EmailFormatSettings.gfDyqshyx4g8lXqocvJI(~289714581 ^ -289727818);
        List<EmailFormatInfo> formats = this._formats;
        Func<EmailFormatInfo, string> func = EmailFormatSettings.\u003C\u003Ec.\u003C\u003E9__7_0;
        Func<EmailFormatInfo, string> selector;
        if (func == null)
          EmailFormatSettings.\u003C\u003Ec.\u003C\u003E9__7_0 = selector = (Func<EmailFormatInfo, string>) (v => ClassSerializationHelper.SerializeObjectByXml((object) v));
        else
          goto label_1;
label_3:
        IEnumerable<string> values = formats.Select<EmailFormatInfo, string>(selector);
        return string.Join((string) separator, values);
label_1:
        selector = func;
        goto label_3;
      }
      set
      {
        int num = 3;
        string[] source;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_5;
            case 2:
              this.Init();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
              continue;
            case 3:
              if (EmailFormatSettings.MkmS9xhy0kRyxHqFZBGd((object) value))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 2;
                continue;
              }
              source = value.Split(new string[1]
              {
                (string) EmailFormatSettings.gfDyqshyx4g8lXqocvJI(-867826612 ^ -867807088)
              }, StringSplitOptions.RemoveEmptyEntries);
              num = 4;
              continue;
            case 4:
              this._formats = ((IEnumerable<string>) source).Select<string, EmailFormatInfo>((Func<string, EmailFormatInfo>) (v => ClassSerializationHelper.DeserializeObjectByXml<EmailFormatInfo>(v))).ToList<EmailFormatInfo>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            default:
              goto label_9;
          }
        }
label_2:
        return;
label_5:
        return;
label_9:;
      }
    }

    internal static void r0pXeBhyAgU6Vd6neGCS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool VhJp60hy6tfyQWH8l3Ft() => EmailFormatSettings.jTm3kGhy4EAoMomJQ3Dl == null;

    internal static EmailFormatSettings smCDCKhyHFStDsXXXLWm() => EmailFormatSettings.jTm3kGhy4EAoMomJQ3Dl;

    internal static object jmQdkMhy7iP1xFc60DqT() => (object) ComponentManager.Current;

    internal static object gfDyqshyx4g8lXqocvJI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool MkmS9xhy0kRyxHqFZBGd([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
