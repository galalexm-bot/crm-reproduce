// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Parameter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Параметр дополнительного атрибута</summary>
  [Serializable]
  public class Parameter : IXmlSerializable
  {
    internal static Parameter J49hZlbtA5eXTVsGrYRU;

    public Parameter()
    {
      Parameter.rAPnXobt0OaMf9ArvysQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public Parameter(string name, object value)
    {
      Parameter.rAPnXobt0OaMf9ArvysQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Name = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Value = value;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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

    public object Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
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

    XmlSchema IXmlSerializable.GetSchema() => (XmlSchema) null;

    void IXmlSerializable.ReadXml(XmlReader reader)
    {
      int num1 = 41;
      while (true)
      {
        int num2 = num1;
        string attribute;
        uint num3;
        TypeConverter converter;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Parameter.DX4P50bwFI6Z275tMiPX((object) reader);
              num2 = 2;
              continue;
            case 2:
              goto label_105;
            case 3:
              if (num3 != 3465876478U)
              {
                num2 = 11;
                continue;
              }
              goto case 29;
            case 4:
            case 7:
            case 32:
            case 36:
            case 44:
            case 47:
            case 50:
            case 57:
            case 60:
            case 69:
            case 71:
            case 73:
            case 77:
            case 78:
            case 80:
            case 83:
            case 87:
            case 88:
            case 99:
            case 104:
            case 108:
              converter = TypeDescriptor.GetConverter(Parameter.YgrEk2btcXU1sGdOnGJT((object) attribute));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 38 : 79;
              continue;
            case 5:
              if (num3 != 3087237559U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 49 : 42;
                continue;
              }
              goto case 97;
            case 6:
            case 21:
              this.Value = (object) (short) Parameter.UTZRJCbtLA2I5GFZbw4E((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 48;
              continue;
            case 8:
              this.Value = (object) Parameter.J2cc3NbtYHbsg4HmN96y((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 31 : 63;
              continue;
            case 9:
            case 15:
            case 19:
            case 33:
            case 34:
            case 37:
            case 46:
            case 48:
            case 54:
            case 59:
            case 63:
            case 74:
            case 75:
            case 86:
            case 98:
              Parameter.DX4P50bwFI6Z275tMiPX((object) reader);
              num2 = 100;
              continue;
            case 10:
              if (Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, Parameter.eiNUZ5btmhodNEq1VCh2(1232639661 >> 3 ^ 154001747)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 70 : 4;
                continue;
              }
              goto case 4;
            case 11:
              if (num3 != 3777590079U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 36 : 12;
                continue;
              }
              goto case 56;
            case 12:
            case 45:
            case 100:
              if (Parameter.ESYxYJbt9xqkkGUl2u4B((object) reader) != XmlNodeType.Whitespace)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 1;
                continue;
              }
              goto case 65;
            case 13:
              if (Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643051174)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 14:
              if (Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837789727)))
              {
                num2 = 21;
                continue;
              }
              goto case 4;
            case 16:
              if (num3 != 2758855996U)
              {
                num2 = 5;
                continue;
              }
              goto case 76;
            case 17:
              if (!Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, Parameter.eiNUZ5btmhodNEq1VCh2(277947046 - -1479185048 ^ 1756972662)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 88 : 5;
                continue;
              }
              goto case 8;
            case 18:
              this.Value = (object) Parameter.UTZRJCbtLA2I5GFZbw4E((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 37 : 16;
              continue;
            case 20:
              if (Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, Parameter.eiNUZ5btmhodNEq1VCh2(-1120607109 - 305487170 ^ -1426230477)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 69 : 93;
                continue;
              }
              goto case 4;
            case 22:
              if (num3 <= 3450944805U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 5 : 16;
                continue;
              }
              goto case 85;
            case 23:
              if (num3 != 1102226759U)
              {
                num2 = 84;
                continue;
              }
              goto case 90;
            case 24:
              this.Value = (object) reader.ReadContentAsFloat();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 41 : 75;
              continue;
            case 25:
              goto label_70;
            case 26:
              this.Value = (object) (uint) Parameter.wK4V5MbtUDppGan7PTwc((object) reader);
              num2 = 59;
              continue;
            case 27:
              if (num3 != 2510089467U)
              {
                num2 = 108;
                continue;
              }
              goto case 61;
            case 28:
              num3 = Parameter.x2bXowbtlal9lCIjobV9((object) attribute);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 48 : 109;
              continue;
            case 29:
              if (!(attribute == (string) Parameter.eiNUZ5btmhodNEq1VCh2(-643786247 ^ -643667439)))
              {
                num2 = 47;
                continue;
              }
              goto case 26;
            case 30:
              goto label_58;
            case 31:
            case 93:
              this.Value = (object) Parameter.wK4V5MbtUDppGan7PTwc((object) reader);
              num2 = 98;
              continue;
            case 35:
              if (num3 != 2752958846U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 4 : 1;
                continue;
              }
              goto case 102;
            case 38:
              if (num3 != 2677843292U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 35 : 12;
                continue;
              }
              goto case 10;
            case 39:
              reader.Read();
              num2 = 30;
              continue;
            case 40:
              if (Parameter.Vn5HtgbtMWprJA8B2ZHQ((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 39 : 28;
                continue;
              }
              reader.ReadStartElement((string) Parameter.eiNUZ5btmhodNEq1VCh2(1470440286 ^ 1470601772));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 62 : 44;
              continue;
            case 41:
              goto label_102;
            case 42:
              Parameter.DPbAcHbtJjY8nPGw2GWF((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 11 : 53;
              continue;
            case 43:
              if (num3 > 2510089467U)
                goto case 38;
              else
                goto label_18;
            case 49:
              if (num3 == 3450944805U)
                goto case 17;
              else
                goto label_69;
            case 51:
              if (Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, Parameter.eiNUZ5btmhodNEq1VCh2(-675505729 ^ -675386865)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 96 : 9;
                continue;
              }
              goto case 4;
            case 52:
              Parameter.HTy4EYbtd35taJqqb3SV((object) reader, Parameter.eiNUZ5btmhodNEq1VCh2(-1822890472 ^ -1822932916));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 28 : 4;
              continue;
            case 53:
            case 62:
              if (Parameter.ESYxYJbt9xqkkGUl2u4B((object) reader) != XmlNodeType.Whitespace)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 94 : 51;
                continue;
              }
              goto case 42;
            case 55:
              if (num3 != 556808448U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 18 : 23;
                continue;
              }
              goto case 20;
            case 56:
              if (attribute == (string) Parameter.eiNUZ5btmhodNEq1VCh2(1149433385 + 173655049 ^ 1323190608))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 41 : 66;
                continue;
              }
              goto case 4;
            case 58:
            case 92:
              this.Value = (object) reader.ReadContentAsString();
              num2 = 86;
              continue;
            case 61:
              if (attribute == (string) Parameter.eiNUZ5btmhodNEq1VCh2(-1710575414 ^ -1710734342))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 67 : 35;
                continue;
              }
              goto case 4;
            case 64:
              if (!Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, Parameter.eiNUZ5btmhodNEq1VCh2(-630932142 - 1120244082 ^ -1751262974)))
              {
                num2 = 7;
                continue;
              }
              goto label_70;
            case 65:
              Parameter.DPbAcHbtJjY8nPGw2GWF((object) reader);
              num2 = 45;
              continue;
            case 66:
            case 81:
              goto label_22;
            case 67:
            case 105:
              this.Value = (object) reader.ReadContentAsDouble();
              num2 = 54;
              continue;
            case 68:
            case 70:
              this.Value = (object) (sbyte) Parameter.UTZRJCbtLA2I5GFZbw4E((object) reader);
              num2 = 46;
              continue;
            case 72:
              if (num3 != 2479764320U)
              {
                num2 = 27;
                continue;
              }
              goto case 14;
            case 76:
              if (!Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173791579)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 99 : 29;
                continue;
              }
              goto case 24;
            case 79:
              this.Value = Parameter.g2r4wXbtzDLsQLkQeZ9x((object) converter, Parameter.VeGQspbtgGsgnlrDCVer((object) reader));
              num2 = 33;
              continue;
            case 82:
              if (num3 != 3899788149U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 32 : 5;
                continue;
              }
              goto case 51;
            case 84:
              if (num3 == 1535340147U)
                goto case 13;
              else
                goto label_61;
            case 85:
              if (num3 <= 3777590079U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 3;
                continue;
              }
              goto case 107;
            case 89:
            case 96:
              goto label_72;
            case 90:
              if (Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, Parameter.eiNUZ5btmhodNEq1VCh2(1574260816 ^ 1574412954)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 18 : 58;
                continue;
              }
              goto case 4;
            case 91:
              if (num3 > 1535340147U)
                goto case 43;
              else
                goto label_89;
            case 94:
              if (Parameter.Vn5HtgbtMWprJA8B2ZHQ((object) reader))
              {
                num2 = 95;
                continue;
              }
              goto case 103;
            case 95:
              Parameter.DPbAcHbtJjY8nPGw2GWF((object) reader);
              num2 = 12;
              continue;
            case 97:
              if (!Parameter.tePKdcbtr3V8L0hXeqJW((object) attribute, Parameter.eiNUZ5btmhodNEq1VCh2(-2138958856 ^ -2139037650)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 22 : 73;
                continue;
              }
              goto case 18;
            case 101:
            case 110:
              this.Value = (object) Parameter.z9jw38btjg3X7KsgfomM((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 74 : 30;
              continue;
            case 102:
              if (attribute == (string) Parameter.eiNUZ5btmhodNEq1VCh2(-1998538950 ^ -1998437318))
              {
                num2 = 101;
                continue;
              }
              goto case 4;
            case 103:
              attribute = reader.GetAttribute((string) Parameter.eiNUZ5btmhodNEq1VCh2(222162814 ^ 222240200));
              num2 = 52;
              continue;
            case 107:
              if (num3 != 3825147585U)
              {
                num2 = 82;
                continue;
              }
              goto case 64;
            case 109:
              if (num3 <= 2752958846U)
              {
                num2 = 91;
                continue;
              }
              goto case 22;
            default:
              this.Value = (object) Parameter.c1NvwNbtsPPxhlSbjIC2(Parameter.VeGQspbtgGsgnlrDCVer((object) reader));
              num2 = 15;
              continue;
          }
        }
label_18:
        num1 = 72;
        continue;
label_22:
        this.Value = (object) (byte) reader.ReadContentAsInt();
        num1 = 9;
        continue;
label_61:
        num1 = 104;
        continue;
label_69:
        num1 = 80;
        continue;
label_70:
        this.Value = (object) Parameter.KhKUtibt5lWaYHv78X84(Parameter.VeGQspbtgGsgnlrDCVer((object) reader), 0);
        num1 = 19;
        continue;
label_72:
        this.Value = (object) (ushort) reader.ReadContentAsInt();
        num1 = 34;
        continue;
label_89:
        num1 = 55;
        continue;
label_102:
        this.Name = (string) Parameter.DA3DntbtyA533oco991s((object) reader, Parameter.eiNUZ5btmhodNEq1VCh2(1574260816 ^ 1574249360));
        num1 = 40;
      }
label_105:
      return;
label_58:;
    }

    void IXmlSerializable.WriteXml(XmlWriter writer)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        string str1;
        while (true)
        {
          Type type;
          string str2;
          object obj;
          switch (num2)
          {
            case 1:
              obj = (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979244993);
              break;
            case 2:
            case 59:
              str1 = type.AssemblyQualifiedName;
              num2 = 44;
              continue;
            case 3:
            case 31:
              if (!(type == TypeOf<byte>.Raw))
              {
                num2 = 32;
                continue;
              }
              goto label_42;
            case 4:
              str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(647913418 ^ 647802058);
              num2 = 61;
              continue;
            case 5:
            case 12:
              if (!(type == TypeOf<long>.Raw))
                goto case 41;
              else
                goto label_62;
            case 6:
            case 64:
              if (this.Value == null)
              {
                num2 = 26;
                continue;
              }
              goto case 45;
            case 7:
              if (Parameter.zcIHIEbwBFrQh1hFgdS5((object) this.Name))
              {
                num2 = 6;
                continue;
              }
              goto case 24;
            case 8:
            case 13:
            case 20:
            case 29:
            case 33:
            case 35:
            case 37:
            case 38:
            case 39:
            case 44:
            case 49:
            case 51:
            case 54:
            case 60:
            case 66:
              writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272440631), (string) Parameter.eiNUZ5btmhodNEq1VCh2(1994213607 >> 4 ^ 124639404), (string) null, str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 67 : 25;
              continue;
            case 9:
            case 28:
              if (!(type == TypeOf<double>.Raw))
              {
                num2 = 43;
                continue;
              }
              goto case 10;
            case 10:
              str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(~210725948 ^ -210607885);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 50 : 51;
              continue;
            case 11:
              str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(-630932142 - 1120244082 ^ -1751263178);
              num2 = 54;
              continue;
            case 14:
              Parameter.iyPd99bwG8rMKwv3m1Sx((object) writer);
              num2 = 52;
              continue;
            case 15:
              obj = Parameter.eiNUZ5btmhodNEq1VCh2(-2138160520 ^ -2138154910);
              break;
            case 16:
              if (!Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<short>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 47 : 5;
                continue;
              }
              goto case 62;
            case 17:
            case 27:
              if (!Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<char>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 19 : 18;
                continue;
              }
              goto case 46;
            case 18:
              goto label_42;
            case 19:
            case 42:
              if (Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<bool>.Raw))
              {
                num2 = 4;
                continue;
              }
              goto case 56;
            case 21:
              str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(--1333735954 ^ 1333641562);
              num2 = 13;
              continue;
            case 22:
              if (Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<int>.Raw))
              {
                num2 = 11;
                continue;
              }
              goto default;
            case 23:
              str2 = ((TypeConverter) Parameter.sw0LOUbwhYKimivdXQ87(type)).ConvertToString(this.Value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 53 : 5;
              continue;
            case 24:
              Parameter.nvXRmxbwWmDY1QcgU4yV((object) writer, Parameter.eiNUZ5btmhodNEq1VCh2(--1333735954 ^ 1333739986), (object) this.Name);
              num2 = 64;
              continue;
            case 25:
            case 47:
              if (Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<ushort>.Raw))
              {
                num2 = 34;
                continue;
              }
              goto case 22;
            case 26:
              goto label_63;
            case 30:
              goto label_33;
            case 32:
            case 65:
              if (Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<sbyte>.Raw))
              {
                num2 = 69;
                continue;
              }
              goto case 16;
            case 34:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882302254);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 35 : 66;
              continue;
            case 36:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317605862);
              num2 = 50;
              continue;
            case 40:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909246587);
              num2 = 29;
              continue;
            case 41:
              if (!Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<ulong>.Raw))
              {
                num2 = 59;
                continue;
              }
              goto label_33;
            case 43:
            case 63:
              if (!(type == TypeOf<Decimal>.Raw))
              {
                num2 = 31;
                continue;
              }
              goto case 21;
            case 45:
              Parameter.su2Ikobwob69qK5cEvPi((object) writer, Parameter.eiNUZ5btmhodNEq1VCh2(372753449 ^ 372728445));
              num2 = 68;
              continue;
            case 46:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710734808);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 33 : 9;
              continue;
            case 48:
              str2 = (string) null;
              num2 = 58;
              continue;
            case 50:
              str2 = (string) this.Value;
              num2 = 60;
              continue;
            case 52:
              goto label_58;
            case 53:
              writer.WriteValue(str2);
              num2 = 14;
              continue;
            case 55:
              str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(333888594 ^ 1075625116 ^ 1408824516);
              num2 = 39;
              continue;
            case 56:
              if (!Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<float>.Raw))
              {
                num2 = 28;
                continue;
              }
              goto case 40;
            case 57:
              str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(516838154 ^ 516727010);
              num2 = 38;
              continue;
            case 58:
              if (!Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<string>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 27 : 20;
                continue;
              }
              goto case 36;
            case 61:
              if ((bool) this.Value)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
                continue;
              }
              goto case 15;
            case 62:
              str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(1461625753 ^ 1461473283);
              num2 = 8;
              continue;
            case 67:
              if (str2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 23 : 11;
                continue;
              }
              goto case 53;
            case 68:
              type = this.Value.GetType();
              num2 = 48;
              continue;
            case 69:
              str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(-2106517564 ^ -2106334142);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 35 : 31;
              continue;
            default:
              if (!Parameter.fj6pyMbwb5MbY2I1m7og(type, TypeOf<uint>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 4 : 12;
                continue;
              }
              goto case 57;
          }
          str2 = (string) obj;
          num2 = 49;
        }
label_33:
        str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(1142330761 ^ 1541959139 ^ 536611956);
        num1 = 20;
        continue;
label_42:
        str1 = (string) Parameter.eiNUZ5btmhodNEq1VCh2(-1290212282 ^ -644262414 ^ 1786989270);
        num1 = 37;
        continue;
label_62:
        num1 = 55;
      }
label_63:
      return;
label_58:;
    }

    internal static void rAPnXobt0OaMf9ArvysQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hDGLCfbt7K2SJXL0Zdeg() => Parameter.J49hZlbtA5eXTVsGrYRU == null;

    internal static Parameter BuY1FHbtxeZ2WNE7VkOM() => Parameter.J49hZlbtA5eXTVsGrYRU;

    internal static object eiNUZ5btmhodNEq1VCh2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object DA3DntbtyA533oco991s([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static bool Vn5HtgbtMWprJA8B2ZHQ([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static bool DPbAcHbtJjY8nPGw2GWF([In] object obj0) => ((XmlReader) obj0).Read();

    internal static XmlNodeType ESYxYJbt9xqkkGUl2u4B([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static void HTy4EYbtd35taJqqb3SV([In] object obj0, [In] object obj1) => ((XmlReader) obj0).ReadStartElement((string) obj1);

    internal static uint x2bXowbtlal9lCIjobV9([In] object obj0) => \u003CPrivateImplementationDetails\u003E.ComputeStringHash((string) obj0);

    internal static bool tePKdcbtr3V8L0hXeqJW([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object VeGQspbtgGsgnlrDCVer([In] object obj0) => (object) ((XmlReader) obj0).ReadContentAsString();

    internal static char KhKUtibt5lWaYHv78X84([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static bool z9jw38btjg3X7KsgfomM([In] object obj0) => ((XmlReader) obj0).ReadContentAsBoolean();

    internal static Decimal J2cc3NbtYHbsg4HmN96y([In] object obj0) => ((XmlReader) obj0).ReadContentAsDecimal();

    internal static int UTZRJCbtLA2I5GFZbw4E([In] object obj0) => ((XmlReader) obj0).ReadContentAsInt();

    internal static long wK4V5MbtUDppGan7PTwc([In] object obj0) => ((XmlReader) obj0).ReadContentAsLong();

    internal static ulong c1NvwNbtsPPxhlSbjIC2([In] object obj0) => Convert.ToUInt64((string) obj0);

    internal static Type YgrEk2btcXU1sGdOnGJT([In] object obj0) => Type.GetType((string) obj0);

    internal static object g2r4wXbtzDLsQLkQeZ9x([In] object obj0, [In] object obj1) => ((TypeConverter) obj0).ConvertFromString((string) obj1);

    internal static void DX4P50bwFI6Z275tMiPX([In] object obj0) => ((XmlReader) obj0).ReadEndElement();

    internal static bool zcIHIEbwBFrQh1hFgdS5([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void nvXRmxbwWmDY1QcgU4yV([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteAttributeString((string) obj1, (string) obj2);

    internal static void su2Ikobwob69qK5cEvPi([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteStartElement((string) obj1);

    internal static bool fj6pyMbwb5MbY2I1m7og([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object sw0LOUbwhYKimivdXQ87([In] Type obj0) => (object) TypeDescriptor.GetConverter(obj0);

    internal static void iyPd99bwG8rMKwv3m1Sx([In] object obj0) => ((XmlWriter) obj0).WriteEndElement();
  }
}
