// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.GlobalValueTemplateGenerator.ElmaEnumParserGlobalValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator
{
  /// <summary>
  /// Получение значения по текстовому представлению содержимого для перечислений (enum)
  /// </summary>
  [Component]
  public class ElmaEnumParserGlobalValue : ElmaParserGlobalValue
  {
    internal static ElmaEnumParserGlobalValue eMQFVRB3CqTsobr3Zcu5;

    public override FormatedValue Parse(string[] propertyNames)
    {
      int num1 = 15;
      string propertyName1;
      string propertyName2;
      IEnumerator<IMetadata> enumerator1;
      Func<IMetadata, bool> func1;
      while (true)
      {
        int num2 = num1;
        IMetadataService metadataService;
        while (true)
        {
          switch (num2)
          {
            case 1:
              metadataService = (IMetadataService) ElmaEnumParserGlobalValue.dlXmL1B3SGoLZLLUqHjc();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 8 : 10;
              continue;
            case 2:
              if (!ElmaEnumParserGlobalValue.cMmHwnB3VgPCRILOlZbw(ElmaEnumParserGlobalValue.em1rb2B3uCsoJbBcqeKk((object) propertyNames[0]), ElmaEnumParserGlobalValue.u1xhFaB3Ia4bD1EwmmAu(--1418440330 ^ 1418390744)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 3:
              if (ElmaEnumParserGlobalValue.hQCJK7B3ZFpcv7dl7HF6((object) propertyNames[0]))
              {
                num2 = 13;
                continue;
              }
              goto case 2;
            case 4:
              goto label_13;
            case 5:
              if (ElmaEnumParserGlobalValue.hQCJK7B3ZFpcv7dl7HF6((object) propertyNames[1]))
              {
                num2 = 8;
                continue;
              }
              goto case 16;
            case 7:
              propertyName2 = propertyNames[2];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
              continue;
            case 10:
              if (metadataService != null)
              {
                IEnumerable<IMetadata> metadataList = metadataService.GetMetadataList();
                // ISSUE: reference to a compiler-generated field
                Func<IMetadata, bool> func2 = ElmaEnumParserGlobalValue.\u003C\u003Ec.\u003C\u003E9__0_0;
                Func<IMetadata, bool> func3;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  ElmaEnumParserGlobalValue.\u003C\u003Ec.\u003C\u003E9__0_0 = func3 = (Func<IMetadata, bool>) (m =>
                  {
                    int num3 = 2;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_3;
                        case 2:
                          if (!(m is EnumMetadata))
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
                            continue;
                          }
                          goto label_2;
                        default:
                          goto label_2;
                      }
                    }
label_2:
                    // ISSUE: reference to a compiler-generated method
                    return ElmaEnumParserGlobalValue.\u003C\u003Ec.lkfVCiQKC7n3fbQq3aRX((object) (EnumMetadata) m);
label_3:
                    return false;
                  });
                }
                else
                  goto label_66;
label_65:
                func1 = func3;
                enumerator1 = metadataList.GetEnumerator();
                num2 = 4;
                continue;
label_66:
                func3 = func2;
                goto label_65;
              }
              else
                goto label_12;
            case 11:
              goto label_62;
            case 12:
              propertyName1 = propertyNames[1];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 7 : 4;
              continue;
            case 14:
              if (((IEnumerable<string>) propertyNames).Count<string>() == 3)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 3;
                continue;
              }
              goto label_53;
            case 15:
              if (propertyNames != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 11 : 14;
                continue;
              }
              goto label_53;
            case 16:
              if (ElmaEnumParserGlobalValue.hQCJK7B3ZFpcv7dl7HF6((object) propertyNames[2]))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 7 : 9;
                continue;
              }
              goto case 12;
            default:
              goto label_53;
          }
        }
label_12:
        num1 = 11;
      }
label_13:
      FormatedValue formatedValue1;
      try
      {
label_42:
        if (enumerator1.MoveNext())
          goto label_44;
        else
          goto label_43;
label_14:
        EnumMetadata enumMetadata;
        List<EnumValueMetadata>.Enumerator enumerator2;
        EnumMetadataType enumMetadataType;
        IMetadata current1;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (ElmaEnumParserGlobalValue.cMmHwnB3VgPCRILOlZbw(ElmaEnumParserGlobalValue.e4BK4cB3ibfDt44Wg5pY((object) enumMetadata), (object) propertyName1))
              {
                num4 = 6;
                continue;
              }
              goto label_42;
            case 2:
              goto label_53;
            case 3:
              enumerator2 = enumMetadata.Values.GetEnumerator();
              num4 = 4;
              continue;
            case 4:
              goto label_22;
            case 5:
              enumMetadata = current1 as EnumMetadata;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 11 : 5;
              continue;
            case 6:
              enumMetadataType = ElmaEnumParserGlobalValue.Qy61GCB3R9NA246iEm95((object) enumMetadata);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 3;
              continue;
            case 7:
            case 9:
            case 10:
              goto label_42;
            case 8:
              if (!func1(current1))
              {
                num4 = 10;
                continue;
              }
              goto case 1;
            case 11:
              if (enumMetadata == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 9;
                continue;
              }
              goto case 8;
            default:
              goto label_44;
          }
        }
label_22:
        try
        {
label_25:
          if (enumerator2.MoveNext())
            goto label_34;
          else
            goto label_26;
label_23:
          EnumValueMetadata current2;
          int? intValue;
          string str;
          int num5;
          while (true)
          {
            switch (num5)
            {
              case 1:
              case 8:
                goto label_25;
              case 2:
                if (!((string) ElmaEnumParserGlobalValue.e4BK4cB3ibfDt44Wg5pY((object) current2) == propertyName2))
                {
                  num5 = 8;
                  continue;
                }
                goto case 10;
              case 3:
label_35:
                str = (string) ElmaEnumParserGlobalValue.CTY1hhB3qHrtPwZMJVWN((object) this, current2.Uid);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 8 : 14;
                continue;
              case 4:
                goto label_34;
              case 5:
                str = intValue.ToString();
                num5 = 6;
                continue;
              case 6:
              case 12:
              case 14:
                FormatedValue formatedValue2 = new FormatedValue();
                ElmaEnumParserGlobalValue.RgrMWSB3KKfUTEejinm6((object) formatedValue2, (object) str);
                formatedValue1 = formatedValue2;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                continue;
              case 7:
                goto label_42;
              case 9:
                if (enumMetadataType != EnumMetadataType.Enum)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 4 : 11;
                  continue;
                }
                goto case 13;
              case 10:
                str = "";
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 9;
                continue;
              case 11:
                switch (enumMetadataType)
                {
                  case EnumMetadataType.ExtendableEnum:
                  case EnumMetadataType.EnumExtension:
                    goto label_35;
                  default:
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 12;
                    continue;
                }
              case 13:
                intValue = current2.IntValue;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 5 : 1;
                continue;
              default:
                goto label_54;
            }
          }
label_26:
          num5 = 7;
          goto label_23;
label_34:
          current2 = enumerator2.Current;
          num5 = 2;
          goto label_23;
        }
        finally
        {
          enumerator2.Dispose();
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
            num6 = 0;
          switch (num6)
          {
            default:
          }
        }
label_43:
        num4 = 2;
        goto label_14;
label_44:
        current1 = enumerator1.Current;
        num4 = 5;
        goto label_14;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num7 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
            num7 = 0;
          while (true)
          {
            switch (num7)
            {
              case 1:
                ElmaEnumParserGlobalValue.Apu1iRB3X4OdYIGG0HoE((object) enumerator1);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                continue;
              default:
                goto label_52;
            }
          }
        }
label_52:;
      }
label_54:
      return formatedValue1;
label_53:
      return (FormatedValue) null;
label_62:
      return (FormatedValue) null;
    }

    public ElmaEnumParserGlobalValue()
    {
      ElmaEnumParserGlobalValue.DI7W9jB3TuACSka2ZaO2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool hQCJK7B3ZFpcv7dl7HF6([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object em1rb2B3uCsoJbBcqeKk([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object u1xhFaB3Ia4bD1EwmmAu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool cMmHwnB3VgPCRILOlZbw([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object dlXmL1B3SGoLZLLUqHjc() => (object) MetadataServiceContext.ServiceOrNull;

    internal static object e4BK4cB3ibfDt44Wg5pY([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static EnumMetadataType Qy61GCB3R9NA246iEm95([In] object obj0) => ((EnumMetadata) obj0).Type;

    internal static object CTY1hhB3qHrtPwZMJVWN([In] object obj0, Guid guid) => (object) ((ElmaParserGlobalValue) obj0).ParseGuid(guid);

    internal static void RgrMWSB3KKfUTEejinm6([In] object obj0, [In] object obj1) => ((FormatedValue) obj0).Value = obj1;

    internal static void Apu1iRB3X4OdYIGG0HoE([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool F5GYgZB3vnHXPFABJ0JZ() => ElmaEnumParserGlobalValue.eMQFVRB3CqTsobr3Zcu5 == null;

    internal static ElmaEnumParserGlobalValue DjKxGJB387a5REbiW77k() => ElmaEnumParserGlobalValue.eMQFVRB3CqTsobr3Zcu5;

    internal static void DI7W9jB3TuACSka2ZaO2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
