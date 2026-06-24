// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityTypeConverter
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
  public class ReferenceOnEntityTypeConverter : TypeConverter
  {
    internal static ReferenceOnEntityTypeConverter rNYWaFhISTPQg8SyvgmD;

    public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => false;

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (!ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(destinationType, ReferenceOnEntityTypeConverter.Q1GFqThIXiyQtPvjMk8H(__typeref (string))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 2:
            goto label_2;
          case 3:
            if (!ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(destinationType, (Type) null))
            {
              if (ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(destinationType, typeof (ReferenceOnEntityType)))
              {
                num = 4;
                continue;
              }
              goto case 1;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 2;
              continue;
            }
          case 4:
            goto label_8;
          default:
            goto label_7;
        }
      }
label_2:
      throw new ArgumentNullException((string) ReferenceOnEntityTypeConverter.eA4nVhhIKfZN6HmkTUcw(-1487388570 ^ -1487267718));
label_7:
      return ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(destinationType, typeof (Guid));
label_8:
      return true;
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(sourceType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
              continue;
            }
            // ISSUE: type reference
            if (ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(sourceType, ReferenceOnEntityTypeConverter.Q1GFqThIXiyQtPvjMk8H(__typeref (ReferenceOnEntityType))))
            {
              num = 4;
              continue;
            }
            break;
          case 3:
            goto label_7;
          case 4:
            goto label_8;
        }
        if (!(sourceType == typeof (string)))
          num = 3;
        else
          goto label_8;
      }
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654152551));
label_7:
      return ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(sourceType, typeof (Guid));
label_8:
      return true;
    }

    public override object ConvertTo(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value,
      Type destinationType)
    {
      int num1 = 7;
      ReferenceOnEntityType referenceOnEntityType1;
      ReferenceOnEntityType referenceOnEntityType2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              referenceOnEntityType2 = (ReferenceOnEntityType) value;
              num2 = 9;
              continue;
            case 3:
              goto label_3;
            case 4:
              referenceOnEntityType1 = (ReferenceOnEntityType) value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 3;
              continue;
            case 5:
              goto label_9;
            case 6:
              goto label_15;
            case 7:
              if (!ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(destinationType, (Type) null))
              {
                // ISSUE: type reference
                if (!(destinationType == ReferenceOnEntityTypeConverter.Q1GFqThIXiyQtPvjMk8H(__typeref (ReferenceOnEntityType))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                  continue;
                }
                goto label_6;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 6;
                continue;
              }
            case 8:
              goto label_12;
            case 9:
              if (referenceOnEntityType2 == null)
              {
                num2 = 8;
                continue;
              }
              goto label_21;
            case 10:
              // ISSUE: type reference
              if (destinationType == ReferenceOnEntityTypeConverter.Q1GFqThIXiyQtPvjMk8H(__typeref (string)))
              {
                num2 = 4;
                continue;
              }
              goto label_11;
            default:
              // ISSUE: type reference
              if (!(destinationType == ReferenceOnEntityTypeConverter.Q1GFqThIXiyQtPvjMk8H(__typeref (Guid))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 10 : 8;
                continue;
              }
              goto case 2;
          }
        }
label_3:
        if (referenceOnEntityType1 == null)
          num1 = 5;
        else
          goto label_10;
      }
label_6:
      return value;
label_9:
      return (object) null;
label_10:
      return (object) referenceOnEntityType1.ToString();
label_11:
      // ISSUE: type reference
      throw new NotSupportedException((string) ReferenceOnEntityTypeConverter.g5KQZOhIkQCHuQYjbcih(ReferenceOnEntityTypeConverter.eA4nVhhIKfZN6HmkTUcw(-2112703338 ^ -2112820032), (object) ReferenceOnEntityTypeConverter.Q1GFqThIXiyQtPvjMk8H(__typeref (ReferenceOnEntityType)).FullName, (object) destinationType.FullName));
label_12:
      Guid guid = Guid.Empty;
      goto label_22;
label_15:
      throw new ArgumentNullException((string) ReferenceOnEntityTypeConverter.eA4nVhhIKfZN6HmkTUcw(-1146510045 ^ -1146356417));
label_21:
      guid = ReferenceOnEntityTypeConverter.xI3fRXhITpa5Qy0ARItf((object) referenceOnEntityType2);
label_22:
      return (object) guid;
    }

    public override object ConvertFrom(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value)
    {
      int num1 = 11;
      Type type;
      Guid result;
      while (true)
      {
        int num2 = num1;
        string input;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_20;
            case 2:
              if (!ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(type, typeof (Guid)))
              {
                if (!ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(type, typeof (string)))
                {
                  num2 = 8;
                  continue;
                }
                goto case 13;
              }
              else
              {
                num2 = 5;
                continue;
              }
            case 3:
              // ISSUE: type reference
              if (!ReferenceOnEntityTypeConverter.nHkIDvhIqwi5TtvrrttW(type, ReferenceOnEntityTypeConverter.Q1GFqThIXiyQtPvjMk8H(__typeref (ReferenceOnEntityType))))
              {
                num2 = 2;
                continue;
              }
              goto label_13;
            case 4:
              if (ReferenceOnEntityTypeConverter.IpRkNthIn3FvqUfJXhly((object) input))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                continue;
              }
              goto case 12;
            case 5:
              goto label_10;
            case 7:
              goto label_7;
            case 9:
              goto label_13;
            case 10:
              goto label_21;
            case 11:
              if (value != null)
              {
                num2 = 10;
                continue;
              }
              goto label_20;
            case 12:
              if (!Guid.TryParse(input, out result))
              {
                num2 = 6;
                continue;
              }
              goto label_7;
            case 13:
              input = (string) value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 4;
              continue;
            default:
              goto label_8;
          }
        }
label_21:
        type = value.GetType();
        num1 = 3;
      }
label_7:
      ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType();
      ReferenceOnEntityTypeConverter.kwZB7ThIOnmP6N6qCsi6((object) referenceOnEntityType, result);
      return (object) referenceOnEntityType;
label_8:
      // ISSUE: type reference
      throw new NotSupportedException((string) ReferenceOnEntityTypeConverter.g5KQZOhIkQCHuQYjbcih(ReferenceOnEntityTypeConverter.eA4nVhhIKfZN6HmkTUcw(516838154 ^ 516688732), (object) type.FullName, (object) ReferenceOnEntityTypeConverter.Q1GFqThIXiyQtPvjMk8H(__typeref (ReferenceOnEntityType)).FullName));
label_10:
      return (object) new ReferenceOnEntityType()
      {
        TypeUid = (Guid) value
      };
label_13:
      return value;
label_20:
      return (object) null;
    }

    public ReferenceOnEntityTypeConverter()
    {
      ReferenceOnEntityTypeConverter.B737lEhI2OC7f31IhqkX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool nHkIDvhIqwi5TtvrrttW([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object eA4nVhhIKfZN6HmkTUcw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type Q1GFqThIXiyQtPvjMk8H([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool GJqvkthIik1jWwKE7MQg() => ReferenceOnEntityTypeConverter.rNYWaFhISTPQg8SyvgmD == null;

    internal static ReferenceOnEntityTypeConverter VBd72dhIRpootl11CLbr() => ReferenceOnEntityTypeConverter.rNYWaFhISTPQg8SyvgmD;

    internal static Guid xI3fRXhITpa5Qy0ARItf([In] object obj0) => ((ReferenceOnEntityType) obj0).TypeUid;

    internal static object g5KQZOhIkQCHuQYjbcih([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool IpRkNthIn3FvqUfJXhly([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void kwZB7ThIOnmP6N6qCsi6([In] object obj0, Guid value) => ((ReferenceOnEntityType) obj0).TypeUid = value;

    internal static void B737lEhI2OC7f31IhqkX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
