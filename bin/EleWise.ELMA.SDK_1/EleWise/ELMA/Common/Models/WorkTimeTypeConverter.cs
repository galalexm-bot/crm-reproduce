// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.WorkTimeTypeConverter
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

namespace EleWise.ELMA.Common.Models
{
  public class WorkTimeTypeConverter : TypeConverter
  {
    internal static WorkTimeTypeConverter AR16CufS6JHkZQ1288wN;

    public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => false;

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
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
              goto label_11;
            case 2:
              if (WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(destinationType, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
                continue;
              }
              // ISSUE: type reference
              if (WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(destinationType, WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (WorkTime))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 3 : 6;
                continue;
              }
              goto case 3;
            case 3:
              // ISSUE: type reference
              if (WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(destinationType, WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (long))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 5;
                continue;
              }
              goto label_7;
            case 4:
              goto label_5;
            case 5:
            case 6:
              goto label_6;
            default:
              goto label_7;
          }
        }
label_7:
        // ISSUE: type reference
        if (!WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(destinationType, WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (long?))))
          num1 = 4;
        else
          goto label_6;
      }
label_5:
      // ISSUE: type reference
      return WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(destinationType, WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (string)));
label_6:
      return true;
label_11:
      throw new ArgumentNullException((string) WorkTimeTypeConverter.DLpG5AfSxBkKSwDwcgOk(-1146510045 ^ -1146356417));
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_10;
          case 2:
            if (!WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(sourceType, typeof (long?)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 4:
            // ISSUE: type reference
            if (WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(sourceType, WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (WorkTime))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
              continue;
            }
            goto case 6;
          case 5:
            if (!WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(sourceType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 4 : 1;
              continue;
            }
            goto label_4;
          case 6:
            // ISSUE: type reference
            if (sourceType == WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (long)))
            {
              num = 3;
              continue;
            }
            goto case 2;
          case 7:
            goto label_4;
          default:
            goto label_9;
        }
      }
label_4:
      throw new ArgumentNullException((string) WorkTimeTypeConverter.DLpG5AfSxBkKSwDwcgOk(901793403 ^ 901914181));
label_9:
      // ISSUE: type reference
      return WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(sourceType, WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (string)));
label_10:
      return true;
    }

    public override object ConvertTo(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value,
      Type destinationType)
    {
      int num1 = 1;
      WorkTime workTime;
      TypeConverter converter;
      long? nullable1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(destinationType, (Type) null))
              {
                // ISSUE: type reference
                if (WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(destinationType, WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (WorkTime))))
                {
                  num2 = 12;
                  continue;
                }
                workTime = (WorkTime) value;
                num2 = 15;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
              continue;
            case 2:
              nullable1 = new long?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 3 : 3;
              continue;
            case 3:
              goto label_21;
            case 4:
              goto label_25;
            case 5:
              goto label_13;
            case 6:
              if (workTime.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 4;
                continue;
              }
              goto label_22;
            case 7:
              if (workTime.HasValue)
              {
                num2 = 10;
                continue;
              }
              goto case 2;
            case 8:
              // ISSUE: type reference
              if (destinationType == WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (string)))
              {
                num2 = 9;
                continue;
              }
              goto label_14;
            case 9:
              converter = TypeDescriptor.GetConverter(typeof (long));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 8 : 14;
              continue;
            case 10:
              goto label_29;
            case 11:
              goto label_22;
            case 12:
              goto label_15;
            case 13:
              goto label_12;
            case 14:
              if (workTime.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 5 : 1;
                continue;
              }
              goto label_12;
            case 15:
              if (WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(destinationType, typeof (long)))
              {
                num2 = 6;
                continue;
              }
              if (destinationType == typeof (long?))
                goto case 7;
              else
                goto label_28;
            default:
              goto label_9;
          }
        }
label_28:
        num1 = 8;
      }
label_9:
      throw new ArgumentNullException((string) WorkTimeTypeConverter.DLpG5AfSxBkKSwDwcgOk(-1350312861 << 3 ^ 2082257668));
label_12:
      return (object) null;
label_13:
      return WorkTimeTypeConverter.ue1hUrfSmhufTcfjMRIj((object) converter, (object) context, (object) culture, (object) workTime.Value);
label_14:
      // ISSUE: type reference
      throw new NotSupportedException(string.Format((string) WorkTimeTypeConverter.DLpG5AfSxBkKSwDwcgOk(--1360331293 ^ 1360484939), (object) WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (WorkTime)).FullName, (object) destinationType.FullName));
label_15:
      return value;
label_21:
      long? nullable2 = nullable1;
      goto label_30;
label_22:
      long num3 = 0;
      goto label_26;
label_25:
      num3 = workTime.Value;
label_26:
      return (object) num3;
label_29:
      nullable2 = new long?(workTime.Value);
label_30:
      return (object) nullable2;
    }

    public override object ConvertFrom(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value)
    {
      int num1 = 3;
      WorkTime workTime;
      Type type;
      while (true)
      {
        int num2 = num1;
        string text;
        long num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              workTime.Value = num3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 7 : 6;
              continue;
            case 2:
              workTime = new WorkTime();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 12 : 15;
              continue;
            case 3:
              if (value == null)
              {
                num2 = 2;
                continue;
              }
              type = value.GetType();
              num2 = 13;
              continue;
            case 4:
              workTime = new WorkTime();
              num2 = 12;
              continue;
            case 5:
              workTime = new WorkTime();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 18 : 18;
              continue;
            case 6:
              goto label_18;
            case 7:
              goto label_25;
            case 8:
              goto label_20;
            case 9:
              // ISSUE: type reference
              if (!(type == WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (long))))
              {
                // ISSUE: type reference
                if (type == WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (string)))
                {
                  num2 = 10;
                  continue;
                }
                goto label_26;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 5 : 1;
                continue;
              }
            case 10:
              text = (string) value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 14;
              continue;
            case 11:
              goto label_27;
            case 12:
              goto label_16;
            case 13:
              // ISSUE: type reference
              if (!WorkTimeTypeConverter.G9ktJFfS70ojUrPgEMlK(type, WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (WorkTime))))
              {
                num2 = 9;
                continue;
              }
              goto label_27;
            case 14:
              if (!string.IsNullOrEmpty(text))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 13 : 16;
                continue;
              }
              goto case 4;
            case 15:
              workTime.HasValue = false;
              num2 = 8;
              continue;
            case 16:
              // ISSUE: type reference
              num3 = (long) TypeDescriptor.GetConverter(WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (long))).ConvertFromString(context, culture, text);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            case 17:
              goto label_6;
            case 18:
              workTime.Value = (long) value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 17;
              continue;
            default:
              workTime = new WorkTime();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
              continue;
          }
        }
label_16:
        workTime.HasValue = false;
        num1 = 6;
      }
label_6:
      return (object) workTime;
label_18:
      return (object) workTime;
label_20:
      return (object) workTime;
label_25:
      return (object) workTime;
label_26:
      // ISSUE: type reference
      throw new NotSupportedException(string.Format((string) WorkTimeTypeConverter.DLpG5AfSxBkKSwDwcgOk(1470440286 ^ 1470593800), (object) type.FullName, (object) WorkTimeTypeConverter.Hhq5wmfS0Lt20e2PmO5f(__typeref (WorkTime)).FullName));
label_27:
      return value;
    }

    public WorkTimeTypeConverter()
    {
      WorkTimeTypeConverter.dHZWXMfSy9neDSsCwYUW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool G9ktJFfS70ojUrPgEMlK([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object DLpG5AfSxBkKSwDwcgOk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type Hhq5wmfS0Lt20e2PmO5f([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool AEyhgmfSHnPIOE7hCpOW() => WorkTimeTypeConverter.AR16CufS6JHkZQ1288wN == null;

    internal static WorkTimeTypeConverter pkZ9T7fSArqUeEFu6LSQ() => WorkTimeTypeConverter.AR16CufS6JHkZQ1288wN;

    internal static object ue1hUrfSmhufTcfjMRIj(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((TypeConverter) obj0).ConvertToString((ITypeDescriptorContext) obj1, (CultureInfo) obj2, obj3);
    }

    internal static void dHZWXMfSy9neDSsCwYUW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
