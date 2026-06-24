// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Helpers.GenerateNameHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Helpers
{
  /// <summary>Помошник генерации названий создаваемой базы данных</summary>
  public static class GenerateNameHelper
  {
    private static int maximumPrefixLength;
    private static int partOfGuidLength;
    private static readonly string foreignKeyPrefix;
    private static readonly string primaryKeyPrefix;
    internal static GenerateNameHelper rWCumdoE3UvA1uGVanEU;

    /// <summary>Создать имя внешнего ключа</summary>
    /// <param name="prefix">Префикс</param>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Имя колонки</param>
    /// <returns>Имя</returns>
    public static string GenerateForeignKeyName(string prefix, string tableName, string columnName)
    {
      int num1 = 4;
      Guid guid;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              GenerateNameHelper.GUL1StoEtdommX8dDAOb((object) columnName, GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(1051276242 - 990076387 ^ 61090463));
              num2 = 5;
              continue;
            case 2:
              goto label_3;
            case 3:
              Contract.CheckArgument(GenerateNameHelper.WWpBgvoEwWOllIfrY0PV((object) prefix) <= GenerateNameHelper.maximumPrefixLength, (string) GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(322893104 - -1992822529 ^ -1979265901));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            case 4:
              GenerateNameHelper.GUL1StoEtdommX8dDAOb((object) prefix, GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(-53329496 >> 4 ^ -3181598));
              num2 = 3;
              continue;
            case 5:
              goto label_7;
            default:
              Contract.ArgumentNotNullOrEmpty(tableName, (string) GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(516838154 ^ 516922280));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 1;
              continue;
          }
        }
label_7:
        guid = GenerateNameHelper.spRCY7oE6NCmVa4hgTUj(GenerateNameHelper.yqhWDRoE4iivOfxfQE4a((object) GenerateNameHelper.foreignKeyPrefix, (object) tableName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710497400), (object) columnName));
        num1 = 2;
      }
label_3:
      return (string) GenerateNameHelper.Vr1CYMoEAqK23fsWETOO((object) prefix, GenerateNameHelper.LP5YkGoEHbjNOFbBF7Mj((object) guid.ToString((string) GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(-2099751081 ^ -2099729121)), 0, GenerateNameHelper.partOfGuidLength));
    }

    /// <summary>Создать имя внешнего ключа</summary>
    /// <param name="prefix">Префикс</param>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnNames">Имена колонок</param>
    /// <returns>Имя</returns>
    public static string GenerateForeignKeyName(
      string prefix,
      string tableName,
      IEnumerable<string> columnNames)
    {
      Contract.ArgumentNotNullOrEmpty(prefix, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210582469));
      Contract.CheckArgument(prefix.Length <= GenerateNameHelper.maximumPrefixLength, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70089086));
      Contract.ArgumentNotNullOrEmpty(tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345471642));
      Guid deterministicGuid = (GenerateNameHelper.foreignKeyPrefix + tableName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712427253) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606707618), columnNames)).GetDeterministicGuid();
      return prefix + deterministicGuid.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647931266)).Substring(0, GenerateNameHelper.partOfGuidLength);
    }

    /// <summary>Создать имя первичного ключа</summary>
    /// <param name="prefix">Префикс</param>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Имя колонки</param>
    /// <returns>Имя</returns>
    public static string GeneratePrimaryKeyName(string prefix, string tableName, string columnName)
    {
      int num = 1;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            GenerateNameHelper.GUL1StoEtdommX8dDAOb((object) prefix, GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(-1088304168 ^ -1088185312));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            guid = GenerateNameHelper.spRCY7oE6NCmVa4hgTUj(GenerateNameHelper.yqhWDRoE4iivOfxfQE4a((object) GenerateNameHelper.primaryKeyPrefix, (object) tableName, GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(-105199646 ^ -105146720), (object) columnName));
            num = 3;
            continue;
          case 3:
            goto label_7;
          case 4:
            GenerateNameHelper.GUL1StoEtdommX8dDAOb((object) tableName, GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(2045296739 + 1688595713 ^ -561027642));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 5 : 3;
            continue;
          case 5:
            GenerateNameHelper.GUL1StoEtdommX8dDAOb((object) columnName, GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(1178210108 ^ 1178333260));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 2;
            continue;
          default:
            GenerateNameHelper.cmIJDLoE7ZqoDJRfh8up(GenerateNameHelper.WWpBgvoEwWOllIfrY0PV((object) prefix) <= GenerateNameHelper.maximumPrefixLength, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217406565));
            num = 4;
            continue;
        }
      }
label_7:
      return prefix + (string) GenerateNameHelper.LP5YkGoEHbjNOFbBF7Mj((object) guid.ToString((string) GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(-1858887263 ^ -1858905111)), 0, GenerateNameHelper.partOfGuidLength);
    }

    static GenerateNameHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            GenerateNameHelper.KwKxBEoEx8Vp2cm2ApkK();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 2:
            GenerateNameHelper.foreignKeyPrefix = (string) GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(-787452571 ^ -787335827);
            num = 3;
            continue;
          case 3:
            GenerateNameHelper.primaryKeyPrefix = (string) GenerateNameHelper.h0cUYToEDtok2gT8g4ZJ(-218496594 ^ -218605124);
            num = 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            GenerateNameHelper.partOfGuidLength = 24;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 0;
            continue;
          default:
            GenerateNameHelper.maximumPrefixLength = 5;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 5;
            continue;
        }
      }
label_2:;
    }

    internal static object h0cUYToEDtok2gT8g4ZJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void GUL1StoEtdommX8dDAOb([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static int WWpBgvoEwWOllIfrY0PV([In] object obj0) => ((string) obj0).Length;

    internal static object yqhWDRoE4iivOfxfQE4a(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static Guid spRCY7oE6NCmVa4hgTUj([In] object obj0) => ((string) obj0).GetDeterministicGuid();

    internal static object LP5YkGoEHbjNOFbBF7Mj([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object Vr1CYMoEAqK23fsWETOO([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool dxV1OboEpYPgJjncdevG() => GenerateNameHelper.rWCumdoE3UvA1uGVanEU == null;

    internal static GenerateNameHelper b1pAZWoEaN9XqGFudmHE() => GenerateNameHelper.rWCumdoE3UvA1uGVanEU;

    internal static void cmIJDLoE7ZqoDJRfh8up(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static void KwKxBEoEx8Vp2cm2ApkK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
