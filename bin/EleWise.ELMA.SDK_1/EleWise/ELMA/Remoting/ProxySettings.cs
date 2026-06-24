// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.ProxySettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.Remoting
{
  /// <summary>Настройки прокси-сервера</summary>
  public class ProxySettings
  {
    private static IWebProxy defaultProxy;
    private static ProxySettings bUTo2NKdxP4egvGv9ON;

    static ProxySettings()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ProxySettings.B0H8SbKgZK7XHgfNGWO();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ProxySettings.defaultProxy = (IWebProxy) ProxySettings.wsJmSMK5UBVD9VtHZrk();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    public ProxySettings()
    {
      ProxySettings.B0H8SbKgZK7XHgfNGWO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Тип прокси-сервера</summary>
    public ProxyType Type
    {
      get => this.\u003CType\u003Ek__BackingField;
      set
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    /// <summary>Адрес</summary>
    public string Address
    {
      get => this.\u003CAddress\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CAddress\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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

    /// <summary>Порт</summary>
    public int Port
    {
      get => this.\u003CPort\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPort\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    /// <summary>Имя пользователя</summary>
    public string UserName
    {
      get => this.\u003CUserName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUserName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
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

    /// <summary>Пароль</summary>
    public string Password
    {
      get => this.\u003CPassword\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPassword\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    /// <summary>Использовать адреса исключений</summary>
    public bool UseExceptions
    {
      get => this.\u003CUseExceptions\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUseExceptions\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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

    /// <summary>Адреса исключений</summary>
    public string Exceptions
    {
      get => this.\u003CExceptions\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CExceptions\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
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

    /// <summary>Использовать поведение 100-Continue</summary>
    public bool Expect100Сontinue
    {
      get => this.\u003CExpect100Сontinue\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CExpect100Сontinue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    /// <summary>Имя конфигурационного файла</summary>
    public string ConfigFileName
    {
      get
      {
        int num = 3;
        string directoryName;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_4;
            case 2:
              if (directoryName != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 3:
              directoryName = Path.GetDirectoryName(((AppDomainSetup) ProxySettings.EyJj4BKYnHF9bnLojOI(ProxySettings.M32ZRnKjLu5L14icTna())).ConfigurationFile);
              num = 2;
              continue;
            default:
              goto label_5;
          }
        }
label_4:
        return (string) null;
label_5:
        return (string) ProxySettings.UQkDwiKU2GVAj1Cblba((object) directoryName, ProxySettings.i6XIkgKLZoQXKXTxcpX(1470998129 - 231418599 ^ 1239559974));
      }
    }

    private void LoadDefault()
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        WebProxy webProxy;
        StringBuilder stringBuilder;
        int index;
        FieldInfo field;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
            case 15:
              this.UseExceptions = ProxySettings.qsEfJRXWlLcTJAJy7Ig((object) webProxy);
              num2 = 19;
              continue;
            case 3:
              if (!(field != (FieldInfo) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 14 : 26;
                continue;
              }
              goto case 22;
            case 4:
            case 16:
              ProxySettings.lSuEF4XoQFSYG5WoB9s((object) stringBuilder, ProxySettings.coLGJyXh3ocxUkmbidi((object) ((string) ProxySettings.C7xsSyXb8S0QDZh9wFX((object) webProxy)[index]).Replace((string) ProxySettings.i6XIkgKLZoQXKXTxcpX(589593376 ^ -1977315327 ^ -1459555241), ""), ProxySettings.i6XIkgKLZoQXKXTxcpX(132912447 ^ 132923869), (object) ""));
              num2 = 8;
              continue;
            case 5:
              if (!ProxySettings.xmCMKMKzv0FdC6pkC02(ProxySettings.snoVPJKciiDBxelO0Yh((object) webProxy), (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 12 : 15;
                continue;
              }
              goto case 20;
            case 6:
              goto label_34;
            case 7:
            case 26:
              if (webProxy != null)
              {
                num2 = 5;
                continue;
              }
              goto label_24;
            case 8:
              ++index;
              num2 = 29;
              continue;
            case 9:
              this.Exceptions = stringBuilder.ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 9 : 18;
              continue;
            case 10:
              field = ProxySettings.defaultProxy.GetType().GetField((string) ProxySettings.i6XIkgKLZoQXKXTxcpX(1113862659 ^ 1113876171), BindingFlags.Instance | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 3;
              continue;
            case 11:
              index = 0;
              num2 = 28;
              continue;
            case 12:
              stringBuilder = new StringBuilder();
              num2 = 11;
              continue;
            case 13:
              if (ProxySettings.defaultProxy != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
                continue;
              }
              goto case 21;
            case 14:
              this.Type = ProxyType.NotUse;
              num2 = 13;
              continue;
            case 18:
              goto label_23;
            case 19:
              if (webProxy.BypassList != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 23 : 27;
                continue;
              }
              goto label_25;
            case 20:
              this.Address = (string) ProxySettings.QvpWnpXF1yJpCrJJE5W(ProxySettings.snoVPJKciiDBxelO0Yh((object) webProxy));
              num2 = 24;
              continue;
            case 21:
              this.Port = 8080;
              num2 = 25;
              continue;
            case 22:
              webProxy = (WebProxy) ProxySettings.G1MmsoKsUGKLPIZsVRt((object) field, (object) ProxySettings.defaultProxy);
              num2 = 7;
              continue;
            case 23:
              ProxySettings.lSuEF4XoQFSYG5WoB9s((object) stringBuilder, ProxySettings.i6XIkgKLZoQXKXTxcpX(~541731958 ^ -541751467));
              num2 = 4;
              continue;
            case 24:
              this.Port = ProxySettings.y3IdMFXBDghCV23fjxI(ProxySettings.snoVPJKciiDBxelO0Yh((object) webProxy));
              num2 = 2;
              continue;
            case 25:
              goto label_6;
            case 27:
              if (webProxy.BypassList.Length != 0)
                goto case 12;
              else
                goto label_33;
            case 28:
            case 29:
              if (index < ProxySettings.C7xsSyXb8S0QDZh9wFX((object) webProxy).Length)
              {
                num2 = 17;
                continue;
              }
              goto case 9;
            default:
              if (index <= 0)
              {
                num2 = 16;
                continue;
              }
              goto case 23;
          }
        }
label_16:
        webProxy = (WebProxy) null;
        num1 = 10;
        continue;
label_33:
        num1 = 6;
      }
label_34:
      return;
label_23:
      return;
label_6:
      return;
label_25:
      return;
label_24:;
    }

    /// <summary>Загрузить настройки</summary>
    public void Load()
    {
      int num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_78;
          case 2:
            goto label_3;
          case 3:
            if (!ProxySettings.O1qfaCXG8NeZuQNR9rB((object) this.ConfigFileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 2 : 2;
            continue;
          case 4:
            this.LoadDefault();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 3 : 1;
            continue;
          default:
            goto label_71;
        }
      }
label_2:
      return;
label_78:
      return;
label_71:
      return;
label_3:
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        ProxySettings.Kgio1LXEImOBXSw6Ttl((object) xmlDocument, (object) this.ConfigFileName);
        XmlNode xmlNode1 = (XmlNode) ProxySettings.sNnJ6GXf5Dde5SMMmUm((object) xmlDocument);
        int num2 = 2;
        while (true)
        {
          int num3;
          XmlNode xmlNode2;
          string str;
          uint num4;
          switch (num2)
          {
            case 2:
            case 13:
              if (xmlNode1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 52 : 32;
                continue;
              }
              goto case 66;
            case 5:
              this.Exceptions = (string) ProxySettings.qc3sftX8yxhi5hvr5WK((object) xmlNode2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 10 : 14;
              continue;
            case 6:
            case 29:
              if (num4 != 1879400691U)
              {
                num2 = 57;
                continue;
              }
              goto case 49;
            case 9:
              if (num4 != 3804576966U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 55 : 49;
                continue;
              }
              goto case 35;
            case 10:
              this.Password = "";
              num2 = 3;
              continue;
            case 11:
              if (!(str == (string) ProxySettings.i6XIkgKLZoQXKXTxcpX(1021410165 ^ 1021390495)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 2 : 4;
                continue;
              }
              goto case 23;
            case 12:
            case 61:
              this.Address = (string) ProxySettings.qc3sftX8yxhi5hvr5WK((object) xmlNode2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 48 : 16;
              continue;
            case 15:
            case 38:
              if (num4 > 3804576966U)
              {
                num3 = 60;
                break;
              }
              goto case 31;
            case 16:
              // ISSUE: type reference
              this.Type = (ProxyType) ProxySettings.g7vJJvXVMgE4wFatpd5(ProxySettings.tkVsUXXI2mDFciihQQs(__typeref (ProxyType)), (object) xmlNode2.InnerText);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 50 : 46;
              continue;
            case 17:
              if (!ProxySettings.uetht4Xu67RbMXraJYk((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195593063)))
              {
                num2 = 64;
                continue;
              }
              goto case 58;
            case 19:
              goto label_6;
            case 20:
              xmlNode1 = xmlNode1.NextSibling;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 3 : 13;
              continue;
            case 22:
              str = (string) ProxySettings.F8VcC3XQIV2xNSdPAC8((object) xmlNode2);
              num2 = 25;
              continue;
            case 23:
              this.Expect100Сontinue = ProxySettings.fa98qXXqvrZSC2j9YEm(ProxySettings.qc3sftX8yxhi5hvr5WK((object) xmlNode2));
              num2 = 8;
              continue;
            case 24:
              if (num4 > 750979128U)
              {
                num2 = 29;
                continue;
              }
              goto case 27;
            case 25:
              num4 = ProxySettings.oqEac0XZIewFDnbONGm((object) str);
              num2 = 39;
              continue;
            case 27:
              if (num4 != 106918010U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 36 : 42;
                continue;
              }
              goto case 11;
            case 30:
            case 47:
              if (xmlNode2 == null)
              {
                num2 = 37;
                continue;
              }
              goto case 46;
            case 31:
              if (num4 != 3512062061U)
              {
                num2 = 9;
                continue;
              }
              goto case 43;
            case 32:
              if (!ProxySettings.uetht4Xu67RbMXraJYk((object) str, ProxySettings.i6XIkgKLZoQXKXTxcpX(87862435 ^ 87882097)))
              {
                num2 = 7;
                continue;
              }
              goto case 5;
            case 35:
              if (!ProxySettings.uetht4Xu67RbMXraJYk((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138171400)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 15 : 21;
                continue;
              }
              goto case 44;
            case 36:
            case 60:
              if (num4 != 4091627583U)
              {
                num2 = 54;
                continue;
              }
              goto case 32;
            case 37:
              goto label_76;
            case 39:
              if (num4 > 2620727545U)
              {
                num2 = 38;
                continue;
              }
              goto case 24;
            case 40:
              if (!(str == (string) ProxySettings.i6XIkgKLZoQXKXTxcpX(95909607 + 343705423 ^ 439593878)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                continue;
              }
              goto case 41;
            case 41:
              if (ProxySettings.uGRS0BXCRoxCfUpbg3e(ProxySettings.bOC8VSXiDC8nM0Ixvj9(ProxySettings.qc3sftX8yxhi5hvr5WK((object) xmlNode2)), (object) ""))
              {
                num2 = 53;
                continue;
              }
              goto case 10;
            case 42:
              if (num4 != 750979128U)
              {
                num2 = 51;
                continue;
              }
              goto case 40;
            case 43:
              if (!ProxySettings.uetht4Xu67RbMXraJYk((object) str, ProxySettings.i6XIkgKLZoQXKXTxcpX(-1921202237 ^ -1921188059)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 45 : 10;
                continue;
              }
              goto case 16;
            case 44:
              this.Port = ProxySettings.CVPHPnXSfFXLG4XNEiV((object) xmlNode2.InnerText);
              num2 = 26;
              continue;
            case 46:
              if (ProxySettings.qc3sftX8yxhi5hvr5WK((object) xmlNode2) != null)
              {
                num2 = 22;
                continue;
              }
              goto default;
            case 49:
              if (ProxySettings.uetht4Xu67RbMXraJYk((object) str, ProxySettings.i6XIkgKLZoQXKXTxcpX(-630932142 - 1120244082 ^ -1751155058)))
              {
                num2 = 61;
                continue;
              }
              goto default;
            case 52:
            case 62:
              if (xmlNode1 != null)
              {
                xmlNode2 = (XmlNode) ProxySettings.sNnJ6GXf5Dde5SMMmUm((object) xmlNode1);
                num2 = 30;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 19 : 10;
              continue;
            case 53:
              this.Password = (string) ProxySettings.NTA28lXR5sFeTcZGvuU((object) xmlNode2.InnerText);
              num2 = 28;
              continue;
            case 54:
              if (num4 != 4132699186U)
              {
                num2 = 34;
                continue;
              }
              goto case 56;
            case 56:
              if (!(str == (string) ProxySettings.i6XIkgKLZoQXKXTxcpX(-1334993905 ^ -1334982213)))
              {
                num3 = 18;
                break;
              }
              goto case 65;
            case 57:
              if (num4 != 2620727545U)
              {
                num2 = 33;
                continue;
              }
              goto case 17;
            case 58:
              this.UserName = (string) ProxySettings.qc3sftX8yxhi5hvr5WK((object) xmlNode2);
              num2 = 63;
              continue;
            case 65:
              this.UseExceptions = ProxySettings.fa98qXXqvrZSC2j9YEm(ProxySettings.qc3sftX8yxhi5hvr5WK((object) xmlNode2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
              continue;
            case 66:
              if (!ProxySettings.uGRS0BXCRoxCfUpbg3e(ProxySettings.F8VcC3XQIV2xNSdPAC8((object) xmlNode1), ProxySettings.i6XIkgKLZoQXKXTxcpX(-488881205 ^ -488892637)))
              {
                num2 = 62;
                continue;
              }
              goto case 20;
            default:
              xmlNode2 = (XmlNode) ProxySettings.DYYlBSXKd6Bx1QLjR5s((object) xmlNode2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 13 : 47;
              continue;
          }
          num2 = num3;
        }
label_76:
        return;
label_6:
        throw new Exception((string) ProxySettings.W4db9fXvkRxUmJG5Ebi(ProxySettings.i6XIkgKLZoQXKXTxcpX(222162814 ^ 222149244)));
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_72;
            default:
              Logger.Log.Error(ProxySettings.i6XIkgKLZoQXKXTxcpX(-1822890472 ^ -1822904312), ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
              continue;
          }
        }
label_72:;
      }
    }

    /// <summary>Сохранить настройки</summary>
    public void Save()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            XmlDocument xmlDocument = new XmlDocument();
            if (ProxySettings.O1qfaCXG8NeZuQNR9rB((object) this.ConfigFileName))
              ProxySettings.EytpswXX8IcuDGXeBVT((object) this.ConfigFileName);
            ProxySettings.yHQQqEXkQ9f0hdjk661((object) xmlDocument, (object) (XmlDeclaration) ProxySettings.KBge4qXTI800W5igJV3((object) xmlDocument, ProxySettings.i6XIkgKLZoQXKXTxcpX(95909607 + 343705423 ^ 439592962), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812044688), (object) null));
            XmlElement element1 = xmlDocument.CreateElement((string) ProxySettings.i6XIkgKLZoQXKXTxcpX(44884861 ^ 44873621));
            ProxySettings.yHQQqEXkQ9f0hdjk661((object) xmlDocument, (object) element1);
            XmlNode element2 = (XmlNode) xmlDocument.CreateElement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477145796));
            element2.InnerText = this.Type.ToString();
            ProxySettings.yHQQqEXkQ9f0hdjk661((object) element1, (object) element2);
            XmlNode xmlNode1 = (XmlNode) ProxySettings.VL2Y08XnENwU1Oj2GGa((object) xmlDocument, ProxySettings.i6XIkgKLZoQXKXTxcpX(372753449 ^ 372740423));
            ProxySettings.AHoY1qXObhO87CSqd6Q((object) xmlNode1, (object) this.Address);
            ProxySettings.yHQQqEXkQ9f0hdjk661((object) element1, (object) xmlNode1);
            XmlNode xmlNode2 = (XmlNode) ProxySettings.VL2Y08XnENwU1Oj2GGa((object) xmlDocument, ProxySettings.i6XIkgKLZoQXKXTxcpX(-1852837372 ^ -1852856444));
            ProxySettings.AHoY1qXObhO87CSqd6Q((object) xmlNode2, (object) this.Port.ToString());
            ProxySettings.yHQQqEXkQ9f0hdjk661((object) element1, (object) xmlNode2);
            XmlNode xmlNode3 = (XmlNode) ProxySettings.VL2Y08XnENwU1Oj2GGa((object) xmlDocument, ProxySettings.i6XIkgKLZoQXKXTxcpX(1012087039 ^ 1012100467));
            xmlNode3.InnerText = this.UserName;
            ProxySettings.yHQQqEXkQ9f0hdjk661((object) element1, (object) xmlNode3);
            XmlNode element3 = (XmlNode) xmlDocument.CreateElement((string) ProxySettings.i6XIkgKLZoQXKXTxcpX(-2107978722 ^ -2107991618));
            ProxySettings.AHoY1qXObhO87CSqd6Q((object) element3, ProxySettings.v1iYXBX2Q7URvEoUWh7((object) this.Password) ? (object) "" : ProxySettings.TW35l5XedWThrAKQIQv((object) this.Password));
            ProxySettings.yHQQqEXkQ9f0hdjk661((object) element1, (object) element3);
            XmlNode newChild = (XmlNode) ProxySettings.VL2Y08XnENwU1Oj2GGa((object) xmlDocument, ProxySettings.i6XIkgKLZoQXKXTxcpX(-882126494 ^ -882146090));
            ProxySettings.AHoY1qXObhO87CSqd6Q((object) newChild, (object) this.UseExceptions.ToString());
            element1.AppendChild(newChild);
            XmlNode xmlNode4 = (XmlNode) ProxySettings.VL2Y08XnENwU1Oj2GGa((object) xmlDocument, ProxySettings.i6XIkgKLZoQXKXTxcpX(132912447 ^ 132923629));
            ProxySettings.AHoY1qXObhO87CSqd6Q((object) xmlNode4, (object) this.Exceptions);
            ProxySettings.yHQQqEXkQ9f0hdjk661((object) element1, (object) xmlNode4);
            XmlNode xmlNode5 = (XmlNode) ProxySettings.VL2Y08XnENwU1Oj2GGa((object) xmlDocument, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629866296));
            ProxySettings.AHoY1qXObhO87CSqd6Q((object) xmlNode5, (object) this.Expect100Сontinue.ToString());
            ProxySettings.yHQQqEXkQ9f0hdjk661((object) element1, (object) xmlNode5);
            ProxySettings.l5g1C9XPpg2HX7PpIaW((object) xmlDocument, (object) this.ConfigFileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_6:
      return;
label_3:;
    }

    /// <summary>Сгенерировать прокси</summary>
    /// <returns></returns>
    public IWebProxy GenerateProxy()
    {
      int num1 = 3;
      WebProxy proxy;
      while (true)
      {
        int num2 = num1;
        NetworkCredential networkCredential;
        List<string> stringList;
        ProxyType type;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              stringList = new List<string>((IEnumerable<string>) ProxySettings.DG1mJJXNx0uMHPtRYCo((object) this.Exceptions, ProxySettings.vqxyZXX1Njc9vSKvUus((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501451093)), StringSplitOptions.RemoveEmptyEntries));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 4 : 5;
              continue;
            case 2:
              if (type != ProxyType.UseDefault)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 6 : 1;
                continue;
              }
              goto label_20;
            case 3:
              goto label_5;
            case 4:
              ProxySettings.bdy6WdX6IGOTc1QkY6h((object) networkCredential, (object) this.Password);
              num2 = 8;
              continue;
            case 5:
              index = 0;
              num2 = 11;
              continue;
            case 6:
              if (type == ProxyType.Custom)
              {
                proxy = new WebProxy(this.Address, this.Port);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 10 : 13;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 10 : 19;
              continue;
            case 7:
            case 12:
              if (!ProxySettings.p5cQOsX3vliWkgOCKC9((object) stringList[index].Trim((char[]) ProxySettings.vqxyZXX1Njc9vSKvUus(ProxySettings.i6XIkgKLZoQXKXTxcpX(-1886646897 ^ -1886626877))), (object) string.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 9 : 8;
                continue;
              }
              goto case 24;
            case 8:
              ProxySettings.GuQm7yXH60mbr9qGnLd((object) proxy, (object) networkCredential);
              num2 = 18;
              continue;
            case 9:
            case 25:
              ++index;
              num2 = 14;
              continue;
            case 10:
              ProxySettings.sXY0chXtmMYPwtUNGfA((object) proxy, ProxySettings.PGtdWuXDadiS9dIMWnu((object) stringList));
              num2 = 17;
              continue;
            case 11:
            case 14:
            case 20:
              if (index < stringList.Count)
              {
                num2 = 7;
                continue;
              }
              goto case 23;
            case 13:
              proxy.BypassProxyOnLocal = this.UseExceptions;
              num2 = 22;
              continue;
            case 15:
              ProxySettings.v1p7oxX42eLTcswc3Eb((object) networkCredential, (object) this.UserName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 4 : 2;
              continue;
            case 16:
              goto label_7;
            case 17:
              ProxySettings.GDFHDNXwX8Ekoq8IKhj((object) proxy, false);
              num2 = 21;
              continue;
            case 18:
              ProxySettings.eF9ssvXAhjQLU5MXP4l(this.Expect100Сontinue);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 16 : 14;
              continue;
            case 19:
              goto label_8;
            case 21:
              networkCredential = new NetworkCredential();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 15 : 1;
              continue;
            case 22:
              if (this.Exceptions != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
                continue;
              }
              goto case 17;
            case 23:
              if (ProxySettings.iFh92JXaOJim7hg2HwJ((object) stringList) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 3 : 10;
                continue;
              }
              goto case 17;
            case 24:
              ProxySettings.FC6hvtXpXnt0YRoBTR8((object) stringList, index);
              num2 = 20;
              continue;
            default:
              goto label_20;
          }
        }
label_5:
        type = this.Type;
        num1 = 2;
      }
label_7:
      return (IWebProxy) proxy;
label_8:
      return (IWebProxy) null;
label_20:
      return ProxySettings.defaultProxy;
    }

    internal static void B0H8SbKgZK7XHgfNGWO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object wsJmSMK5UBVD9VtHZrk() => (object) WebRequest.DefaultWebProxy;

    internal static bool E7sRbuKl2ZZD0Zb0ZpZ() => ProxySettings.bUTo2NKdxP4egvGv9ON == null;

    internal static ProxySettings nqXkW5KrB0vWw7LhLFS() => ProxySettings.bUTo2NKdxP4egvGv9ON;

    internal static object M32ZRnKjLu5L14icTna() => (object) AppDomain.CurrentDomain;

    internal static object EyJj4BKYnHF9bnLojOI([In] object obj0) => (object) ((AppDomain) obj0).SetupInformation;

    internal static object i6XIkgKLZoQXKXTxcpX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object UQkDwiKU2GVAj1Cblba([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object G1MmsoKsUGKLPIZsVRt([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

    internal static object snoVPJKciiDBxelO0Yh([In] object obj0) => (object) ((WebProxy) obj0).Address;

    internal static bool xmCMKMKzv0FdC6pkC02([In] object obj0, [In] object obj1) => (Uri) obj0 != (Uri) obj1;

    internal static object QvpWnpXF1yJpCrJJE5W([In] object obj0) => (object) ((Uri) obj0).Host;

    internal static int y3IdMFXBDghCV23fjxI([In] object obj0) => ((Uri) obj0).Port;

    internal static bool qsEfJRXWlLcTJAJy7Ig([In] object obj0) => ((WebProxy) obj0).BypassProxyOnLocal;

    internal static object lSuEF4XoQFSYG5WoB9s([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object C7xsSyXb8S0QDZh9wFX([In] object obj0) => (object) ((WebProxy) obj0).BypassList;

    internal static object coLGJyXh3ocxUkmbidi([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool O1qfaCXG8NeZuQNR9rB([In] object obj0) => System.IO.File.Exists((string) obj0);

    internal static void Kgio1LXEImOBXSw6Ttl([In] object obj0, [In] object obj1) => ((XmlDocument) obj0).Load((string) obj1);

    internal static object sNnJ6GXf5Dde5SMMmUm([In] object obj0) => (object) ((XmlNode) obj0).FirstChild;

    internal static object F8VcC3XQIV2xNSdPAC8([In] object obj0) => (object) ((XmlNode) obj0).Name;

    internal static bool uGRS0BXCRoxCfUpbg3e([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object W4db9fXvkRxUmJG5Ebi([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object qc3sftX8yxhi5hvr5WK([In] object obj0) => (object) ((XmlNode) obj0).InnerText;

    internal static uint oqEac0XZIewFDnbONGm([In] object obj0) => \u003CPrivateImplementationDetails\u003E.ComputeStringHash((string) obj0);

    internal static bool uetht4Xu67RbMXraJYk([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static System.Type tkVsUXXI2mDFciihQQs([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object g7vJJvXVMgE4wFatpd5([In] System.Type obj0, [In] object obj1) => System.Enum.Parse(obj0, (string) obj1);

    internal static int CVPHPnXSfFXLG4XNEiV([In] object obj0) => int.Parse((string) obj0);

    internal static object bOC8VSXiDC8nM0Ixvj9([In] object obj0) => (object) ((string) obj0).Trim();

    internal static object NTA28lXR5sFeTcZGvuU([In] object obj0) => (object) EncryptionHelper.DecryptPwd((string) obj0);

    internal static bool fa98qXXqvrZSC2j9YEm([In] object obj0) => Convert.ToBoolean((string) obj0);

    internal static object DYYlBSXKd6Bx1QLjR5s([In] object obj0) => (object) ((XmlNode) obj0).NextSibling;

    internal static void EytpswXX8IcuDGXeBVT([In] object obj0) => System.IO.File.Delete((string) obj0);

    internal static object KBge4qXTI800W5igJV3([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((XmlDocument) obj0).CreateXmlDeclaration((string) obj1, (string) obj2, (string) obj3);

    internal static object yHQQqEXkQ9f0hdjk661([In] object obj0, [In] object obj1) => (object) ((XmlNode) obj0).AppendChild((XmlNode) obj1);

    internal static object VL2Y08XnENwU1Oj2GGa([In] object obj0, [In] object obj1) => (object) ((XmlDocument) obj0).CreateElement((string) obj1);

    internal static void AHoY1qXObhO87CSqd6Q([In] object obj0, [In] object obj1) => ((XmlNode) obj0).InnerText = (string) obj1;

    internal static bool v1iYXBX2Q7URvEoUWh7([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object TW35l5XedWThrAKQIQv([In] object obj0) => (object) EncryptionHelper.EncryptPwd((string) obj0);

    internal static void l5g1C9XPpg2HX7PpIaW([In] object obj0, [In] object obj1) => ((XmlDocument) obj0).Save((string) obj1);

    internal static object vqxyZXX1Njc9vSKvUus([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object DG1mJJXNx0uMHPtRYCo([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);

    internal static bool p5cQOsX3vliWkgOCKC9([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static void FC6hvtXpXnt0YRoBTR8([In] object obj0, [In] int obj1) => ((List<string>) obj0).RemoveAt(obj1);

    internal static int iFh92JXaOJim7hg2HwJ([In] object obj0) => ((List<string>) obj0).Count;

    internal static object PGtdWuXDadiS9dIMWnu([In] object obj0) => (object) ((List<string>) obj0).ToArray();

    internal static void sXY0chXtmMYPwtUNGfA([In] object obj0, [In] object obj1) => ((WebProxy) obj0).BypassList = (string[]) obj1;

    internal static void GDFHDNXwX8Ekoq8IKhj([In] object obj0, [In] bool obj1) => ((WebProxy) obj0).UseDefaultCredentials = obj1;

    internal static void v1p7oxX42eLTcswc3Eb([In] object obj0, [In] object obj1) => ((NetworkCredential) obj0).UserName = (string) obj1;

    internal static void bdy6WdX6IGOTc1QkY6h([In] object obj0, [In] object obj1) => ((NetworkCredential) obj0).Password = (string) obj1;

    internal static void GuQm7yXH60mbr9qGnLd([In] object obj0, [In] object obj1) => ((WebProxy) obj0).Credentials = (ICredentials) obj1;

    internal static void eF9ssvXAhjQLU5MXP4l([In] bool obj0) => ServicePointManager.Expect100Continue = obj0;
  }
}
