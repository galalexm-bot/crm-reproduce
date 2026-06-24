// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.Enums.EnumHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.Enums
{
  public static class EnumHelper
  {
    internal static EnumHelper ADQIb4SO5STHoRCWEcq;

    public static string GetDescription(this Enum value)
    {
      int num = 1;
      DescriptionAttribute[] descriptionAttributeArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            descriptionAttributeArray = (DescriptionAttribute[]) EnumHelper.Xe7eExSN1SUeQwaAuCh(EnumHelper.PVUuBCSPb1q5UAIEtFe(value.GetType(), (object) value.ToString()), EnumHelper.dkow1mS1CPcOlaCmhnU(__typeref (DescriptionAttribute)), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (descriptionAttributeArray.Length == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 2 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return value.ToString();
label_5:
      return descriptionAttributeArray[0].Description;
    }

    public static IEnumerable<string> ToListNames(this Enum value, bool useDescriptionAttribute = false)
    {
      if (value == null)
        return (IEnumerable<string>) null;
      Type type = value.GetType();
      return ((IEnumerable<string>) type.GetReflectionEnumNames()).Select<string, string>((Func<string, string>) (e =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!useDescriptionAttribute)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return e;
label_5:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (string) EnumHelper.\u003C\u003Ec__DisplayClass1_0.OGq6p6fxZgxeDghtIus8((Enum) EnumHelper.\u003C\u003Ec__DisplayClass1_0.GPjr4ffx8GIcNqvqrekw(type, (object) e.ToString((IFormatProvider) CultureInfo.InvariantCulture), true));
      }));
    }

    public static string GetDisplayName(this MoreOrLess value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (value)
            {
              case MoreOrLess.Equal:
                goto label_5;
              case MoreOrLess.NotEqual:
                goto label_9;
              case MoreOrLess.Less:
                goto label_6;
              case MoreOrLess.More:
                goto label_4;
              case MoreOrLess.LessOrEqual:
                goto label_8;
              case MoreOrLess.MoreOrEqual:
                goto label_7;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                continue;
            }
          case 2:
            goto label_4;
          default:
            goto label_10;
        }
      }
label_4:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672211000));
label_5:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(1218962250 ^ 1218948522));
label_6:
      return EleWise.ELMA.SR.T((string) EnumHelper.dAb0shS3bQcpjwmdKUQ(1012087039 ^ 1012102673));
label_7:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(~541731958 ^ -541745801));
label_8:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(-87337865 ^ -87352493));
label_9:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(~-122002947 ^ 122016072));
label_10:
      return (string) null;
    }

    public static string GetDisplayName(this AndOr value)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              goto label_3;
            case 2:
              if (value == AndOr.And)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                continue;
              }
              goto label_6;
            case 4:
              goto label_5;
            default:
              goto label_6;
          }
        }
label_6:
        if (value != AndOr.Or)
          num1 = 4;
        else
          goto label_4;
      }
label_3:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(-1638402543 ^ -1638418097));
label_4:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(-867826612 ^ -867808472));
label_5:
      return (string) null;
    }

    public static string GetDisplayName(this MathOperators value)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            switch (value)
            {
              case MathOperators.Plus:
                goto label_2;
              case MathOperators.Minus:
                goto label_3;
              case MathOperators.Multiply:
                goto label_5;
              case MathOperators.Divide:
                goto label_4;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
                continue;
            }
          default:
            goto label_2;
        }
      }
label_2:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123617008));
label_3:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106501050));
label_4:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561061124));
label_5:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740353410));
label_6:
      return (string) null;
    }

    public static string GetEnumCode(this MoreOrLess value)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            switch (value)
            {
              case MoreOrLess.Equal:
                goto label_3;
              case MoreOrLess.NotEqual:
                goto label_7;
              case MoreOrLess.Less:
                goto label_4;
              case MoreOrLess.More:
                goto label_2;
              case MoreOrLess.LessOrEqual:
                goto label_6;
              case MoreOrLess.MoreOrEqual:
                goto label_5;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                continue;
            }
          default:
            goto label_2;
        }
      }
label_2:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(1505778440 - 1981636111 ^ -475876551));
label_3:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(1925118608 << 2 ^ -889461174));
label_4:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(-138018305 ^ -137998791));
label_5:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767705033));
label_6:
      return EleWise.ELMA.SR.T((string) EnumHelper.dAb0shS3bQcpjwmdKUQ(-1255365154 ^ 596875508 ^ -1765838088));
label_7:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(-1852837372 ^ -1852850724));
label_8:
      return (string) null;
    }

    public static string GetEnumCode(this AndOr value)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_2;
          case 2:
            if (value == AndOr.And)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
              continue;
            }
            goto case 4;
          case 4:
            if (value != AndOr.Or)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_4;
        }
      }
label_2:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(-951514650 ^ -951499080));
label_3:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(-420743386 ^ -420759486));
label_4:
      return (string) null;
    }

    public static string GetEnumCode(this MathOperators value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (value)
            {
              case MathOperators.Plus:
                goto label_2;
              case MathOperators.Minus:
                goto label_3;
              case MathOperators.Multiply:
                goto label_5;
              case MathOperators.Divide:
                goto label_4;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                continue;
            }
          case 2:
            goto label_2;
          default:
            goto label_6;
        }
      }
label_2:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(-1867198571 ^ -1867218869));
label_3:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(236071375 ^ 236070819));
label_4:
      return (string) EnumHelper.xv2PqUSpX7pnDRpipOU(EnumHelper.dAb0shS3bQcpjwmdKUQ(~538519529 ^ -538535950));
label_5:
      return EleWise.ELMA.SR.T((string) EnumHelper.dAb0shS3bQcpjwmdKUQ(2045296739 + 1688595713 ^ -561061234));
label_6:
      return (string) null;
    }

    internal static object PVUuBCSPb1q5UAIEtFe(Type type, [In] object obj1) => (object) type.GetReflectionField((string) obj1);

    internal static Type dkow1mS1CPcOlaCmhnU([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Xe7eExSN1SUeQwaAuCh([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static bool jTCsrqS2iZxYuhSOouH() => EnumHelper.ADQIb4SO5STHoRCWEcq == null;

    internal static EnumHelper YWbJ07SehV3tChK1J1a() => EnumHelper.ADQIb4SO5STHoRCWEcq;

    internal static object dAb0shS3bQcpjwmdKUQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xv2PqUSpX7pnDRpipOU([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
