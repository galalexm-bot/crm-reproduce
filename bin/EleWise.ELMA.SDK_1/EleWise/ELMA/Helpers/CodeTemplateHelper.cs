// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.CodeTemplateHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Класс, содержащий шаблоны кода</summary>
  public static class CodeTemplateHelper
  {
    internal static CodeTemplateHelper YLeZ3bh5kcyui20snxuL;

    /// <summary>Получить шаблон Razor-кода</summary>
    /// <param name="typeName">Имя типа модели</param>
    /// <param name="nameSpace">Пространство имен типа модели</param>
    /// <returns>Razor-код</returns>
    public static string GetPanelRazorTemplate(string typeName, string nameSpace)
    {
      int num = 1;
      string[] source1;
      while (true)
      {
        switch (num)
        {
          case 1:
            source1 = new string[2]
            {
              nameSpace,
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123736304)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      string str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021503181);
      object obj1 = (object) typeName ?? CodeTemplateHelper.P192iSh52kpIBXi5OHv2(1514961705 ^ 1515185173);
      IEnumerable<string> source2 = ((IEnumerable<string>) source1).Where<string>((Func<string, bool>) (n => n != null));
      // ISSUE: reference to a compiler-generated field
      Func<string, string> func1 = CodeTemplateHelper.\u003C\u003Ec.\u003C\u003E9__0_1;
      Func<string, string> keySelector;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        CodeTemplateHelper.\u003C\u003Ec.\u003C\u003E9__0_1 = keySelector = (Func<string, string>) (n => n);
      }
      else
        goto label_4;
label_6:
      IOrderedEnumerable<string> source3 = source2.OrderBy<string, string>(keySelector);
      // ISSUE: reference to a compiler-generated field
      Func<string, string> func2 = CodeTemplateHelper.\u003C\u003Ec.\u003C\u003E9__0_2;
      Func<string, string> selector;
      if (func2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        CodeTemplateHelper.\u003C\u003Ec.\u003C\u003E9__0_2 = selector = (Func<string, string>) (n => (string) CodeTemplateHelper.\u003C\u003Ec.r0DomCvxOsNDPUAIak71(-1921202237 ^ -1921445341) + n + (string) CodeTemplateHelper.\u003C\u003Ec.r0DomCvxOsNDPUAIak71(-345420348 ^ -345419168));
      }
      else
        goto label_7;
label_9:
      string str2 = string.Concat(source3.Select<string, string>(selector));
      object obj2 = CodeTemplateHelper.UcrYKVh5eeqS0tcnDWDh(CodeTemplateHelper.P192iSh52kpIBXi5OHv2(2045296739 + 1688595713 ^ -561171928));
      return (string) CodeTemplateHelper.gNKtCmh5Poivhc50OJoI((object) str1, obj1, (object) str2, obj2);
label_7:
      selector = func2;
      goto label_9;
label_4:
      keySelector = func1;
      goto label_6;
    }

    /// <summary>Получить шаблон Razor-кода свойства</summary>
    /// <param name="typeName">Имя типа модели</param>
    /// <param name="nameSpace">Пространство имен типа модели</param>
    /// <param name="isEditor">Свойство для редактирования</param>
    /// <returns>Razor-код</returns>
    public static string GetPropertyRazorTemplate(
      string typeName,
      string nameSpace,
      bool? isEditor)
    {
      string[] source = new string[3]
      {
        nameSpace,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886577385),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334967967)
      };
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1671969600), (object) (typeName ?? z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61229779)), (object) string.Concat(((IEnumerable<string>) source).Where<string>((Func<string, bool>) (n => n != null)).OrderBy<string, string>((Func<string, string>) (n => n)).Select<string, string>((Func<string, string>) (n => (string) CodeTemplateHelper.\u003C\u003Ec.tLPaenvx2LYID0nmDobf(CodeTemplateHelper.\u003C\u003Ec.r0DomCvxOsNDPUAIak71(-1978478350 ^ -1978202862), (object) n, CodeTemplateHelper.\u003C\u003Ec.r0DomCvxOsNDPUAIak71(1669371371 ^ 1669368399))))), isEditor.HasValue ? (isEditor.Value ? (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408868424)) : (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334952881))) : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979234373));
    }

    internal static object P192iSh52kpIBXi5OHv2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object UcrYKVh5eeqS0tcnDWDh([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object gNKtCmh5Poivhc50OJoI(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static bool iWVtCah5nKNOEFbyDhus() => CodeTemplateHelper.YLeZ3bh5kcyui20snxuL == null;

    internal static CodeTemplateHelper YwXMm2h5OCxpVi4f5n2R() => CodeTemplateHelper.YLeZ3bh5kcyui20snxuL;
  }
}
