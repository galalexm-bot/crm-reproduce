// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.EntityReferences
{
  public class ReferenceOnEntityConverter : TypeConverter
  {
    private static ReferenceOnEntityConverter R5XnQphIeuPStn8Uc1qS;

    public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => false;

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            // ISSUE: type reference
            if (!ReferenceOnEntityConverter.DT9bNShI3MsnIE90moUy(destinationType, ReferenceOnEntityConverter.bXgYx2hIN2WdaaxJLiwG(__typeref (ReferenceOnEntity))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          case 3:
            if (!(destinationType == (Type) null))
            {
              num = 2;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_2:
      return ReferenceOnEntityConverter.DT9bNShI3MsnIE90moUy(destinationType, typeof (string));
label_3:
      return true;
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16644357));
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            goto label_2;
          case 3:
            if (ReferenceOnEntityConverter.DT9bNShI3MsnIE90moUy(sourceType, typeof (ReferenceOnEntity)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          case 4:
            if (!(sourceType == (Type) null))
            {
              num = 3;
              continue;
            }
            goto label_2;
          default:
            goto label_7;
        }
      }
label_2:
      throw new ArgumentNullException((string) ReferenceOnEntityConverter.j3EVB5hIpXnLsLuFeCwu(~1767720452 ^ -1767841339));
label_7:
      // ISSUE: type reference
      return sourceType == ReferenceOnEntityConverter.bXgYx2hIN2WdaaxJLiwG(__typeref (string));
label_8:
      return true;
    }

    public override object ConvertTo(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value,
      Type destinationType)
    {
      int num = 1;
      ReferenceOnEntity referenceOnEntity;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(destinationType == (Type) null))
            {
              if (!ReferenceOnEntityConverter.DT9bNShI3MsnIE90moUy(destinationType, typeof (ReferenceOnEntity)))
              {
                num = 3;
                continue;
              }
              goto label_13;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
              continue;
            }
          case 2:
            referenceOnEntity = (ReferenceOnEntity) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 5 : 5;
            continue;
          case 3:
            // ISSUE: type reference
            if (ReferenceOnEntityConverter.DT9bNShI3MsnIE90moUy(destinationType, ReferenceOnEntityConverter.bXgYx2hIN2WdaaxJLiwG(__typeref (string))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 1;
              continue;
            }
            goto label_10;
          case 4:
            goto label_13;
          case 5:
            if (referenceOnEntity == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 6;
              continue;
            }
            goto label_9;
          case 6:
            goto label_8;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751288836));
label_8:
      return (object) null;
label_9:
      return (object) referenceOnEntity.ToString();
label_10:
      // ISSUE: type reference
      throw new NotSupportedException((string) ReferenceOnEntityConverter.Coq7GBhIaYIe79THRI6c(ReferenceOnEntityConverter.j3EVB5hIpXnLsLuFeCwu(-1088304168 ^ -1088187506), (object) ReferenceOnEntityConverter.bXgYx2hIN2WdaaxJLiwG(__typeref (ReferenceOnEntity)).FullName, (object) destinationType.FullName));
label_13:
      return value;
    }

    public override object ConvertFrom(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value)
    {
      int num1 = 2;
      Type type;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              type = value.GetType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 3 : 5;
              continue;
            case 2:
              if (value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
                continue;
              }
              goto label_5;
            case 3:
              goto label_5;
            case 4:
              goto label_9;
            case 5:
              goto label_12;
            case 6:
              // ISSUE: type reference
              if (ReferenceOnEntityConverter.DT9bNShI3MsnIE90moUy(type, ReferenceOnEntityConverter.bXgYx2hIN2WdaaxJLiwG(__typeref (string))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            default:
              goto label_3;
          }
        }
label_12:
        // ISSUE: type reference
        if (!ReferenceOnEntityConverter.DT9bNShI3MsnIE90moUy(type, ReferenceOnEntityConverter.bXgYx2hIN2WdaaxJLiwG(__typeref (ReferenceOnEntity))))
          num1 = 6;
        else
          goto label_9;
      }
label_3:
      return (object) new ReferenceOnEntity((string) value);
label_4:
      throw new NotSupportedException((string) ReferenceOnEntityConverter.Coq7GBhIaYIe79THRI6c(ReferenceOnEntityConverter.j3EVB5hIpXnLsLuFeCwu(712480695 ^ 712364001), (object) type.FullName, (object) typeof (ReferenceOnEntity).FullName));
label_5:
      return (object) null;
label_9:
      return value;
    }

    public ReferenceOnEntityConverter()
    {
      ReferenceOnEntityConverter.mpbb3EhIDmRTf30SKrxr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type bXgYx2hIN2WdaaxJLiwG([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool DT9bNShI3MsnIE90moUy([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool f5R1nehIPe0k8PYRDDwj() => ReferenceOnEntityConverter.R5XnQphIeuPStn8Uc1qS == null;

    internal static ReferenceOnEntityConverter PyvpLPhI1hmDw1BGsgAH() => ReferenceOnEntityConverter.R5XnQphIeuPStn8Uc1qS;

    internal static object j3EVB5hIpXnLsLuFeCwu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Coq7GBhIaYIe79THRI6c([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void mpbb3EhIDmRTf30SKrxr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
