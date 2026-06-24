// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RangeValueAttribute
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
  public class RangeValueAttribute : RangeAttribute
  {
    internal static RangeValueAttribute za5lclog1JypZFGOqSsH;

    private static string GetMessage(object minimum, object maximum)
    {
      int num1 = 6;
      string message;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 10:
              if (minimum != null)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 3:
              if (maximum != null)
              {
                num2 = 4;
                continue;
              }
              goto label_8;
            case 4:
              message = EleWise.ELMA.SR.T((string) RangeValueAttribute.eBEQSZogpCeDDicEP8b3(-1217523399 ^ -1217514421), maximum);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            case 5:
              if (minimum == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
                continue;
              }
              goto case 8;
            case 6:
              message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345413570));
              num2 = 5;
              continue;
            case 7:
              goto label_6;
            case 8:
              if (maximum != null)
              {
                num2 = 9;
                continue;
              }
              goto case 1;
            case 9:
              message = EleWise.ELMA.SR.T((string) RangeValueAttribute.eBEQSZogpCeDDicEP8b3(-1598106783 - -968262081 ^ -629837772), minimum, maximum);
              num2 = 11;
              continue;
            default:
              goto label_8;
          }
        }
label_6:
        message = EleWise.ELMA.SR.T((string) RangeValueAttribute.eBEQSZogpCeDDicEP8b3(236071375 ^ 236063865), minimum);
        num1 = 2;
      }
label_8:
      return message;
    }

    public RangeValueAttribute(long minimum, long maximum)
    {
      RangeValueAttribute.EEW3TIoga5UJXuumYJTv();
      // ISSUE: explicit constructor call
      base.\u002Ector((double) minimum, (double) maximum);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            RangeValueAttribute.QZpQeyogDFCaTj5nv9dL((object) this, (object) RangeValueAttribute.GetMessage((object) minimum, (object) maximum));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public RangeValueAttribute(long minimum, long maximum, string message)
    {
      RangeValueAttribute.EEW3TIoga5UJXuumYJTv();
      // ISSUE: explicit constructor call
      base.\u002Ector((double) minimum, (double) maximum);
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RangeValueAttribute.QZpQeyogDFCaTj5nv9dL((object) this, (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          case 2:
            message = (string) RangeValueAttribute.hJYkkLogwIpQFgbJ03BN((object) minimum, (object) maximum);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
            continue;
          case 3:
            if (RangeValueAttribute.VuCHSxogtilFULqrSxmp((object) message))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    public RangeValueAttribute(short minimum, short maximum)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: type reference
      // ISSUE: explicit constructor call
      base.\u002Ector(RangeValueAttribute.Df49i0og4pLnolBa0GlG(__typeref (short)), minimum.ToString(), maximum.ToString());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            RangeValueAttribute.QZpQeyogDFCaTj5nv9dL((object) this, RangeValueAttribute.hJYkkLogwIpQFgbJ03BN((object) minimum, (object) maximum));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public RangeValueAttribute(short minimum, short maximum, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: type reference
      // ISSUE: explicit constructor call
      base.\u002Ector(RangeValueAttribute.Df49i0og4pLnolBa0GlG(__typeref (short)), minimum.ToString(), maximum.ToString());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!string.IsNullOrEmpty(message))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 4 : 1;
              continue;
            }
            goto case 3;
          case 2:
            goto label_3;
          case 3:
            message = (string) RangeValueAttribute.hJYkkLogwIpQFgbJ03BN((object) minimum, (object) maximum);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          default:
            RangeValueAttribute.QZpQeyogDFCaTj5nv9dL((object) this, (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    public RangeValueAttribute(int minimum, int maximum)
    {
      RangeValueAttribute.EEW3TIoga5UJXuumYJTv();
      // ISSUE: explicit constructor call
      base.\u002Ector(minimum, maximum);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            RangeValueAttribute.QZpQeyogDFCaTj5nv9dL((object) this, RangeValueAttribute.hJYkkLogwIpQFgbJ03BN((object) minimum, (object) maximum));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public RangeValueAttribute(int minimum, int maximum, string message)
    {
      RangeValueAttribute.EEW3TIoga5UJXuumYJTv();
      // ISSUE: explicit constructor call
      base.\u002Ector(minimum, maximum);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (RangeValueAttribute.VuCHSxogtilFULqrSxmp((object) message))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_3;
          case 3:
            RangeValueAttribute.QZpQeyogDFCaTj5nv9dL((object) this, (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 0;
            continue;
          default:
            message = (string) RangeValueAttribute.hJYkkLogwIpQFgbJ03BN((object) minimum, (object) maximum);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 3;
            continue;
        }
      }
label_3:;
    }

    public RangeValueAttribute(double minimum, double maximum)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(minimum, maximum);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            RangeValueAttribute.QZpQeyogDFCaTj5nv9dL((object) this, (object) RangeValueAttribute.GetMessage((object) minimum, (object) maximum));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public RangeValueAttribute(double minimum, double maximum, string message)
    {
      RangeValueAttribute.EEW3TIoga5UJXuumYJTv();
      // ISSUE: explicit constructor call
      base.\u002Ector(minimum, maximum);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (RangeValueAttribute.VuCHSxogtilFULqrSxmp((object) message))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 0;
              continue;
            }
            break;
          case 2:
            message = RangeValueAttribute.GetMessage((object) minimum, (object) maximum);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_3;
        }
        this.ErrorMessage = message;
        num = 3;
      }
label_3:;
    }

    public RangeValueAttribute(Type type, string minimum, string maximum)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(type, minimum, maximum);
      int num = 4;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            minimum = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 2:
          case 6:
            RangeValueAttribute.QZpQeyogDFCaTj5nv9dL((object) this, RangeValueAttribute.hJYkkLogwIpQFgbJ03BN((object) minimum, (object) maximum));
            num = 5;
            continue;
          case 3:
            maximum = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
            continue;
          case 4:
            if (RangeValueAttribute.VuCHSxogtilFULqrSxmp((object) minimum))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
              continue;
            }
            goto default;
          case 5:
            goto label_6;
          default:
            if (!string.IsNullOrEmpty(maximum))
            {
              num = 6;
              continue;
            }
            goto case 3;
        }
      }
label_6:;
    }

    public RangeValueAttribute(Type type, string minimum, string maximum, string message)
    {
      RangeValueAttribute.EEW3TIoga5UJXuumYJTv();
      // ISSUE: explicit constructor call
      base.\u002Ector(type, minimum, maximum);
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num1 = 0;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            if (string.IsNullOrEmpty(maximum))
            {
              num1 = 7;
              continue;
            }
            goto case 6;
          case 2:
            minimum = (string) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          case 4:
            message = (string) RangeValueAttribute.hJYkkLogwIpQFgbJ03BN((object) minimum, (object) maximum);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 4 : 5;
            continue;
          case 5:
            RangeValueAttribute.QZpQeyogDFCaTj5nv9dL((object) this, (object) message);
            num2 = 3;
            break;
          case 6:
            if (string.IsNullOrEmpty(message))
            {
              num2 = 4;
              break;
            }
            goto case 5;
          case 7:
            maximum = (string) null;
            num1 = 6;
            continue;
          default:
            if (RangeValueAttribute.VuCHSxogtilFULqrSxmp((object) minimum))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 2;
              continue;
            }
            goto case 1;
        }
        num1 = num2;
      }
label_4:;
    }

    internal static object eBEQSZogpCeDDicEP8b3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool t89nsTogNI4g1qebdHpU() => RangeValueAttribute.za5lclog1JypZFGOqSsH == null;

    internal static RangeValueAttribute m9IhDhog3nPjf58YMsRT() => RangeValueAttribute.za5lclog1JypZFGOqSsH;

    internal static void EEW3TIoga5UJXuumYJTv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void QZpQeyogDFCaTj5nv9dL([In] object obj0, [In] object obj1) => ((ValidationAttribute) obj0).ErrorMessage = (string) obj1;

    internal static bool VuCHSxogtilFULqrSxmp([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object hJYkkLogwIpQFgbJ03BN([In] object obj0, [In] object obj1) => (object) RangeValueAttribute.GetMessage(obj0, obj1);

    internal static Type Df49i0og4pLnolBa0GlG([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
