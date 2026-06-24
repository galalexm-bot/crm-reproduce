// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.DropDownItemTypeConverter
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

namespace EleWise.ELMA.Model.Common
{
  public class DropDownItemTypeConverter : TypeConverter
  {
    private static DropDownItemTypeConverter m6L1bwhKaXjc0BkKLkMQ;

    public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => false;

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!DropDownItemTypeConverter.qdWlSMhKwdyP5bOEtX8h(destinationType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          case 3:
            goto label_7;
          case 4:
            goto label_8;
          default:
            // ISSUE: type reference
            if (DropDownItemTypeConverter.qdWlSMhKwdyP5bOEtX8h(destinationType, DropDownItemTypeConverter.JUOlMghK6uAr6ecpRgO0(__typeref (DropDownItem))))
            {
              num = 4;
              continue;
            }
            goto label_7;
        }
      }
label_4:
      throw new ArgumentNullException((string) DropDownItemTypeConverter.rTLXE7hK4OxZ3SkGJmUk(-1255365154 ^ 596875508 ^ -1765972682));
label_7:
      // ISSUE: type reference
      return DropDownItemTypeConverter.qdWlSMhKwdyP5bOEtX8h(destinationType, DropDownItemTypeConverter.JUOlMghK6uAr6ecpRgO0(__typeref (string)));
label_8:
      return true;
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (!DropDownItemTypeConverter.qdWlSMhKwdyP5bOEtX8h(sourceType, typeof (DropDownItem)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 3:
            if (!DropDownItemTypeConverter.qdWlSMhKwdyP5bOEtX8h(sourceType, (Type) null))
            {
              num = 2;
              continue;
            }
            goto label_6;
          default:
            goto label_2;
        }
      }
label_2:
      return sourceType == typeof (string);
label_3:
      return true;
label_6:
      throw new ArgumentNullException((string) DropDownItemTypeConverter.rTLXE7hK4OxZ3SkGJmUk(-1867198571 ^ -1867081813));
    }

    public override object ConvertTo(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value,
      Type destinationType)
    {
      int num = 1;
      DropDownItem dropDownItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(destinationType == (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          case 3:
            dropDownItem = (DropDownItem) value;
            num = 8;
            continue;
          case 4:
            goto label_13;
          case 5:
            goto label_12;
          case 6:
            goto label_7;
          case 7:
            goto label_11;
          case 8:
            if (dropDownItem != null)
            {
              num = 5;
              continue;
            }
            goto label_11;
          default:
            // ISSUE: type reference
            if (DropDownItemTypeConverter.qdWlSMhKwdyP5bOEtX8h(destinationType, DropDownItemTypeConverter.JUOlMghK6uAr6ecpRgO0(__typeref (DropDownItem))))
            {
              num = 6;
              continue;
            }
            // ISSUE: type reference
            if (!DropDownItemTypeConverter.qdWlSMhKwdyP5bOEtX8h(destinationType, DropDownItemTypeConverter.JUOlMghK6uAr6ecpRgO0(__typeref (string))))
            {
              num = 4;
              continue;
            }
            goto case 3;
        }
      }
label_2:
      throw new ArgumentNullException((string) DropDownItemTypeConverter.rTLXE7hK4OxZ3SkGJmUk(333888594 ^ 1075625116 ^ 1408784594));
label_7:
      return value;
label_11:
      return (object) null;
label_12:
      return (object) dropDownItem.ToString();
label_13:
      throw new NotSupportedException((string) DropDownItemTypeConverter.Ywlj8ihKHdUROHVYi6yI((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413412937), (object) typeof (DropDownItem).FullName, (object) destinationType.FullName));
    }

    public override object ConvertFrom(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value)
    {
      int num = 3;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (DropDownItemTypeConverter.qdWlSMhKwdyP5bOEtX8h(type, DropDownItemTypeConverter.JUOlMghK6uAr6ecpRgO0(__typeref (string))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 4;
              continue;
            }
            goto label_8;
          case 2:
            type = value.GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          case 3:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 2;
              continue;
            }
            goto label_5;
          case 4:
            goto label_7;
          case 5:
            goto label_2;
          case 6:
            goto label_5;
          default:
            // ISSUE: type reference
            if (!DropDownItemTypeConverter.qdWlSMhKwdyP5bOEtX8h(type, DropDownItemTypeConverter.JUOlMghK6uAr6ecpRgO0(__typeref (DropDownItem))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return value;
label_5:
      return (object) null;
label_7:
      return (object) new DropDownItem((string) value);
label_8:
      // ISSUE: type reference
      throw new NotSupportedException((string) DropDownItemTypeConverter.Ywlj8ihKHdUROHVYi6yI(DropDownItemTypeConverter.rTLXE7hK4OxZ3SkGJmUk(1581325282 << 3 ^ -234191034), (object) type.FullName, (object) DropDownItemTypeConverter.JUOlMghK6uAr6ecpRgO0(__typeref (DropDownItem)).FullName));
    }

    public DropDownItemTypeConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qdWlSMhKwdyP5bOEtX8h([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object rTLXE7hK4OxZ3SkGJmUk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type JUOlMghK6uAr6ecpRgO0([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool A7WLRhhKDUH68dv1xV9r() => DropDownItemTypeConverter.m6L1bwhKaXjc0BkKLkMQ == null;

    internal static DropDownItemTypeConverter erMZ08hKtPap0ZphNBbw() => DropDownItemTypeConverter.m6L1bwhKaXjc0BkKLkMQ;

    internal static object Ywlj8ihKHdUROHVYi6yI([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
