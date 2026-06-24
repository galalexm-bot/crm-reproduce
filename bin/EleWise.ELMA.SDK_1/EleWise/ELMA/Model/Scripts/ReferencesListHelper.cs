// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ReferencesListHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// Класс-помощник для работы со строковыми списками используемых сборок в скрипт-модуле
  /// </summary>
  internal static class ReferencesListHelper
  {
    private static ReferencesListHelper qVicLobuFgW2DpXZg29U;

    /// <summary>Разобрать строку со сборками ELMA</summary>
    /// <param name="referenceString">Строка со сборками ELMA</param>
    /// <returns>Объект с информацией о списке сборок</returns>
    internal static ElmaReferencesList ParseElmaReferenceString(string referenceString)
    {
      int num = 1;
      bool marker;
      IEnumerable<string> references;
      while (true)
      {
        string str1;
        switch (num)
        {
          case 1:
            string str2 = referenceString;
            if (str2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            }
            str1 = str2;
            break;
          case 2:
            object obj = ReferencesListHelper.j2qky4buoUdG5qAA1QPo((object) referenceString);
            marker = ((IEnumerable<string>) obj).Contains<string>((string) ReferencesListHelper.lp92CububYEX4wBBZFMe(-812025778 ^ -811872308));
            references = ReferencesListHelper.FilterOutMarkers((IEnumerable<string>) obj);
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            str1 = string.Empty;
            break;
        }
        referenceString = str1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 0;
      }
label_2:
      return new ElmaReferencesList(marker, references);
    }

    /// <summary>Получить используемые сборки в виде коллекции строк</summary>
    /// <param name="referenceString">Строка со сборками</param>
    /// <returns>Коллекция имён используемых сборок</returns>
    internal static IEnumerable<string> GetReferences(string referenceString)
    {
      referenceString = referenceString ?? string.Empty;
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<string>) ReferencesListHelper.SplitReferences((object) referenceString)).Select<string, string>((Func<string, string>) (x => (string) ReferencesListHelper.\u003C\u003Ec.byyLlUCerglbEZtTJ99u((object) x)));
    }

    /// <summary>
    /// Получить используемые сборки ELMA в виде коллекции строк
    /// Внимание! Игнорирует дополнительные макеры в списке - применять, когда флаг ручного управления не интересен.
    /// </summary>
    /// <param name="referenceString">Строка со сборками ELMA</param>
    /// <returns>Коллекция имён используемых сборок</returns>
    internal static IEnumerable<string> GetElmaReferences(string referenceString)
    {
      referenceString = referenceString ?? string.Empty;
      return ReferencesListHelper.FilterOutMarkers(ReferencesListHelper.GetReferences(referenceString));
    }

    /// <summary>
    /// Собрать коллекцию имён сборок в строку используемых сборок
    /// </summary>
    /// <param name="references">Коллекция имён сборок</param>
    /// <returns>Строка используемых сборок</returns>
    internal static string StringifyReferences(IEnumerable<string> references) => string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146490369), (IEnumerable<string>) references.OrderBy<string, string>((Func<string, string>) (x => (string) ReferencesListHelper.\u003C\u003Ec.LtoOBBCeg7sII6PWogSK((object) x))));

    /// <summary>
    /// Собрать коллекцию имён сборок и флаг ручного управления сборками ELMA в строку используемых сборок ELMA
    /// </summary>
    /// <param name="elmaReferencesList">Объект с информацией о списке сборок</param>
    /// <returns>Строка используемых сборок ELMA</returns>
    internal static string StringifyElmaReferences(ElmaReferencesList elmaReferencesList) => ReferencesListHelper.StringifyReferences(Enumerable.Empty<string>().If<string>(ReferencesListHelper.vsIs7ybuhpRZImt836fJ((object) elmaReferencesList), (Func<IEnumerable<string>, IEnumerable<string>>) (c => c.Concat<string>((IEnumerable<string>) new string[1]
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597165364)
    }))).Union<string>(elmaReferencesList.References));

    private static string[] SplitReferences(object referencesString) => (string[]) ReferencesListHelper.zdHfwCbuEDsZ5BF6f1ej(referencesString, ReferencesListHelper.UyqBxTbuGKpKoaUMoXgo(ReferencesListHelper.lp92CububYEX4wBBZFMe(-649342099 - -1150814748 ^ 501451093)), StringSplitOptions.RemoveEmptyEntries);

    private static IEnumerable<string> FilterOutMarkers(IEnumerable<string> collection) => collection.Where<string>((Func<string, bool>) (x => !ReferencesListHelper.\u003C\u003Ec.ERWoSTCejx4u8ZfyqIrd((object) x, ReferencesListHelper.\u003C\u003Ec.GqmwFoCe5QjXVuLfw8jm(-1334993905 ^ -1335347817))));

    internal static object j2qky4buoUdG5qAA1QPo([In] object obj0) => (object) ReferencesListHelper.SplitReferences(obj0);

    internal static object lp92CububYEX4wBBZFMe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool jBLux6buB3GwZqXjMqLj() => ReferencesListHelper.qVicLobuFgW2DpXZg29U == null;

    internal static ReferencesListHelper i1KSUUbuWBadWmKVTUK6() => ReferencesListHelper.qVicLobuFgW2DpXZg29U;

    internal static bool vsIs7ybuhpRZImt836fJ([In] object obj0) => ((ElmaReferencesList) obj0).AllReferencesMarker;

    internal static object UyqBxTbuGKpKoaUMoXgo([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object zdHfwCbuEDsZ5BF6f1ej([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);
  }
}
