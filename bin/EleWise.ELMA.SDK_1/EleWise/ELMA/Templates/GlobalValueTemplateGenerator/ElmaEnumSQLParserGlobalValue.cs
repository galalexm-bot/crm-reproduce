// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.GlobalValueTemplateGenerator.ElmaEnumSQLParserGlobalValue
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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator
{
  /// <summary>
  /// Получение значения по текстовому представлению содержимого для перечислений (enum) в SQL-запросе
  /// </summary>
  [Component]
  public class ElmaEnumSQLParserGlobalValue : ElmaParserGlobalValue
  {
    private static ElmaEnumSQLParserGlobalValue nJBrAJBNUhAu4V0xYXrn;

    public override FormatedValue Parse(string[] propertyNames)
    {
      int num1 = 6;
      string propertyName1;
      IEnumerator<IMetadata> enumerator1;
      string propertyName2;
      Func<IMetadata, bool> func1;
      while (true)
      {
        IMetadataService metadataService;
        switch (num1)
        {
          case 1:
            goto label_62;
          case 2:
          case 5:
          case 9:
            goto label_2;
          case 3:
            goto label_16;
          case 4:
            if (metadataService == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 0;
              continue;
            }
            IEnumerable<IMetadata> metadataList = metadataService.GetMetadataList();
            // ISSUE: reference to a compiler-generated field
            Func<IMetadata, bool> func2 = ElmaEnumSQLParserGlobalValue.\u003C\u003Ec.\u003C\u003E9__0_0;
            Func<IMetadata, bool> func3;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ElmaEnumSQLParserGlobalValue.\u003C\u003Ec.\u003C\u003E9__0_0 = func3 = (Func<IMetadata, bool>) (m =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (!(m is EnumMetadata))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_2;
                    case 2:
                      goto label_2;
                    default:
                      goto label_3;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return ElmaEnumSQLParserGlobalValue.\u003C\u003Ec.oIgy6kQKh9pEkXImgJEr((object) (EnumMetadata) m);
label_3:
                return false;
              });
            }
            else
              goto label_66;
label_65:
            func1 = func3;
            enumerator1 = metadataList.GetEnumerator();
            num1 = 3;
            continue;
label_66:
            func3 = func2;
            goto label_65;
          case 6:
            if (propertyNames == null)
            {
              num1 = 5;
              continue;
            }
            goto case 12;
          case 7:
            if (!ElmaEnumSQLParserGlobalValue.bCK40OBNziBN8QMP6aFZ((object) propertyNames[0]))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 8;
              continue;
            }
            goto label_2;
          case 8:
            if (ElmaEnumSQLParserGlobalValue.pLsHOhB3We9UrfctqFfV(ElmaEnumSQLParserGlobalValue.CQrkKQB3FpDrvGWE6mSj((object) propertyNames[0]), ElmaEnumSQLParserGlobalValue.J5nlWAB3Bhfrp3yHKX2V(-1380439818 << 3 ^ 1841300976)))
            {
              num1 = 11;
              continue;
            }
            goto label_2;
          case 10:
            if (ElmaEnumSQLParserGlobalValue.bCK40OBNziBN8QMP6aFZ((object) propertyNames[2]))
            {
              num1 = 2;
              continue;
            }
            break;
          case 11:
            if (!ElmaEnumSQLParserGlobalValue.bCK40OBNziBN8QMP6aFZ((object) propertyNames[1]))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 10 : 5;
              continue;
            }
            goto label_2;
          case 12:
            if (((IEnumerable<string>) propertyNames).Count<string>() == 3)
            {
              num1 = 7;
              continue;
            }
            goto label_2;
          case 13:
            propertyName1 = propertyNames[2];
            num1 = 14;
            continue;
          case 14:
            metadataService = (IMetadataService) ElmaEnumSQLParserGlobalValue.aTcQAZB3ogh2wTs1CYgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 4;
            continue;
        }
        propertyName2 = propertyNames[1];
        num1 = 13;
      }
label_2:
      return (FormatedValue) null;
label_16:
      FormatedValue formatedValue;
      try
      {
label_47:
        if (ElmaEnumSQLParserGlobalValue.LEZvUCB3EEyTYTbtMRb3((object) enumerator1))
          goto label_38;
        else
          goto label_48;
label_17:
        List<EnumValueMetadata>.Enumerator enumerator2;
        EnumMetadataType type;
        IMetadata current1;
        EnumMetadata enumMetadata;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (func1(current1))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 6 : 7;
                continue;
              }
              goto label_47;
            case 2:
              goto label_38;
            case 3:
              if (enumMetadata == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 4:
              goto label_18;
            case 5:
              enumerator2 = enumMetadata.Values.GetEnumerator();
              num3 = 4;
              continue;
            case 6:
              enumMetadata = current1 as EnumMetadata;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 3;
              continue;
            case 7:
              if (ElmaEnumSQLParserGlobalValue.pLsHOhB3We9UrfctqFfV((object) enumMetadata.Name, (object) propertyName2))
              {
                num3 = 9;
                continue;
              }
              goto label_47;
            case 8:
              goto label_2;
            case 9:
              type = enumMetadata.Type;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 5 : 5;
              continue;
            default:
              goto label_47;
          }
        }
label_18:
        try
        {
label_22:
          if (enumerator2.MoveNext())
            goto label_21;
          else
            goto label_23;
label_19:
          EnumValueMetadata current2;
          int num4;
          while (true)
          {
            int? intValue;
            string str;
            switch (num4)
            {
              case 1:
                goto label_22;
              case 2:
                if (type != EnumMetadataType.Enum)
                {
                  num4 = 5;
                  continue;
                }
                break;
              case 3:
                str = intValue.ToString();
                num4 = 13;
                continue;
              case 4:
                goto label_21;
              case 5:
                switch (type)
                {
                  case EnumMetadataType.ExtendableEnum:
                  case EnumMetadataType.EnumExtension:
                    goto label_29;
                  default:
                    num4 = 12;
                    continue;
                }
              case 6:
                goto label_47;
              case 7:
label_29:
                str = (string) ElmaEnumSQLParserGlobalValue.TeSyfZB3GkgtRcdmKfMs((object) this, ElmaEnumSQLParserGlobalValue.n1aUuQB3hERUUeGBIkLp((object) current2));
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 11 : 0;
                continue;
              case 8:
                goto label_3;
              case 9:
                str = "";
                num4 = 2;
                continue;
              case 10:
                if (ElmaEnumSQLParserGlobalValue.pLsHOhB3We9UrfctqFfV(ElmaEnumSQLParserGlobalValue.Ecq48dB3b6FoPiyfcCYZ((object) current2), (object) propertyName1))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 6 : 9;
                  continue;
                }
                goto label_22;
              case 11:
              case 12:
              case 13:
                formatedValue = new FormatedValue()
                {
                  Value = (object) str
                };
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 8 : 5;
                continue;
            }
            intValue = current2.IntValue;
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 3;
          }
label_21:
          current2 = enumerator2.Current;
          num4 = 10;
          goto label_19;
label_23:
          num4 = 6;
          goto label_19;
        }
        finally
        {
          enumerator2.Dispose();
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
            num5 = 0;
          switch (num5)
          {
            default:
          }
        }
label_38:
        current1 = enumerator1.Current;
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        {
          num3 = 6;
          goto label_17;
        }
        else
          goto label_17;
label_48:
        num3 = 8;
        goto label_17;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
            num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 1:
                ElmaEnumSQLParserGlobalValue.joN837B3fMbYPCfXInHO((object) enumerator1);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                continue;
              default:
                goto label_56;
            }
          }
        }
label_56:;
      }
label_3:
      return formatedValue;
label_62:
      return (FormatedValue) null;
    }

    public ElmaEnumSQLParserGlobalValue()
    {
      ElmaEnumSQLParserGlobalValue.h3AU0EB3QbAtXNDnL8OB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool bCK40OBNziBN8QMP6aFZ([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object CQrkKQB3FpDrvGWE6mSj([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object J5nlWAB3Bhfrp3yHKX2V(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool pLsHOhB3We9UrfctqFfV([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object aTcQAZB3ogh2wTs1CYgs() => (object) MetadataServiceContext.ServiceOrNull;

    internal static object Ecq48dB3b6FoPiyfcCYZ([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static Guid n1aUuQB3hERUUeGBIkLp([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object TeSyfZB3GkgtRcdmKfMs([In] object obj0, Guid guid) => (object) ((ElmaParserGlobalValue) obj0).ParseGuid(guid);

    internal static bool LEZvUCB3EEyTYTbtMRb3([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void joN837B3fMbYPCfXInHO([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool eHUc7wBNsSFLDGWdKhis() => ElmaEnumSQLParserGlobalValue.nJBrAJBNUhAu4V0xYXrn == null;

    internal static ElmaEnumSQLParserGlobalValue MmeWmDBNcBc5Ds65Banp() => ElmaEnumSQLParserGlobalValue.nJBrAJBNUhAu4V0xYXrn;

    internal static void h3AU0EB3QbAtXNDnL8OB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
