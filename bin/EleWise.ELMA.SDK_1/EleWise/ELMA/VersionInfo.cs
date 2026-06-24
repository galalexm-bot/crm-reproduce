// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.VersionInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Packaging;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA
{
  /// <summary>Класс для получения информации о версии сборки</summary>
  public static class VersionInfo
  {
    private static VersionInfo V2KJygC7n9lDkuMxrng;

    /// <summary>Номер версии файла сборки</summary>
    /// <typeparam name="T">Тип, для сборки которого возвращается версия</typeparam>
    public static Version GetVersion<T>() => VersionInfo.GetVersion(typeof (T));

    /// <summary>Номер версии файла сборки</summary>
    /// <param name="type">Тип, для сборки которого возвращается версия</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <see langword="null" />.</exception>
    public static Version GetVersion([NotNull] Type type)
    {
      int num = 3;
      AssemblyFileVersionAttribute versionAttribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            // ISSUE: type reference
            versionAttribute = (AssemblyFileVersionAttribute) ((IEnumerable<object>) VersionInfo.oyyviiCMVbNVVLiHGqU((object) type.Assembly, VersionInfo.imU4dgCyO3LP4dBaIIi(__typeref (AssemblyFileVersionAttribute)), false)).FirstOrDefault<object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          case 3:
            if (!(type == (Type) null))
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            goto label_6;
          default:
            if (versionAttribute == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 4 : 3;
              continue;
            }
            goto label_7;
        }
      }
label_2:
      throw new ArgumentNullException((string) VersionInfo.fcJU1FCmWflAlPV0qp1(-244066886 - -48452443 ^ -195615433));
label_6:
      return new Version(1, 0, 0, 0);
label_7:
      return new Version((string) VersionInfo.pMABvtCJjNXentJi4DD((object) versionAttribute));
    }

    /// <summary>Информационный номер версии файла сборки</summary>
    /// <typeparam name="T">Тип, для сборки которого возвращается версия</typeparam>
    public static string GetInfoVersion<T>() => VersionInfo.GetInfoVersion(typeof (T));

    /// <summary>Получить адрес страницы для активации демо-версии</summary>
    /// <param name="useStudentActivationUrl"></param>
    /// <param name="regKey"></param>
    /// <returns></returns>
    public static string GetDemoActivationUrl(bool useStudentActivationUrl, string regKey)
    {
      int num = 5;
      while (true)
      {
        CultureInfo cultureFromSettings;
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            goto label_8;
          case 3:
            goto label_5;
          case 4:
            if (cultureFromSettings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            }
            break;
          case 5:
            cultureFromSettings = SR.GetCultureFromSettings();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 4 : 4;
            continue;
          default:
            if (VersionInfo.QQxGRRCdH4bgiADqc3l(VersionInfo.tac6EkC9OZqQiD05lA7((object) cultureFromSettings), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538525102)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 3 : 3;
              continue;
            }
            break;
        }
        if (useStudentActivationUrl)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
        else
          goto label_8;
      }
label_5:
      return (string) VersionInfo.o8vb04CloUkP2E0xJ04(VersionInfo.fcJU1FCmWflAlPV0qp1(~-397266137 ^ 397276858), (object) regKey);
label_8:
      return (string) VersionInfo.o8vb04CloUkP2E0xJ04(VersionInfo.fcJU1FCmWflAlPV0qp1(1994213607 >> 4 ^ 124644914), (object) regKey);
label_9:
      return (string) VersionInfo.o8vb04CloUkP2E0xJ04(VersionInfo.fcJU1FCmWflAlPV0qp1(1051802738 - -1831968059 ^ -1411194213), (object) regKey);
    }

    /// <summary>Получить адрес страницы для активации версии CE</summary>
    /// <param name="regKey"></param>
    /// <returns></returns>
    public static string GetCEActivationUrl(string regKey)
    {
      int num = 3;
      while (true)
      {
        CultureInfo cultureInfo;
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (cultureInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
              continue;
            }
            break;
          case 3:
            cultureInfo = (CultureInfo) VersionInfo.X8pl7uCrxNKbMgu9PoK();
            num = 2;
            continue;
          case 4:
            goto label_2;
        }
        if (VersionInfo.QQxGRRCdH4bgiADqc3l(VersionInfo.tac6EkC9OZqQiD05lA7((object) cultureInfo), VersionInfo.fcJU1FCmWflAlPV0qp1(647913418 ^ 647906702)))
          num = 4;
        else
          goto label_3;
      }
label_2:
      return (string) VersionInfo.o8vb04CloUkP2E0xJ04(VersionInfo.fcJU1FCmWflAlPV0qp1(825385222 ^ 825383604), (object) regKey);
label_3:
      return (string) VersionInfo.o8vb04CloUkP2E0xJ04(VersionInfo.fcJU1FCmWflAlPV0qp1(-105199646 ^ -105186326), (object) regKey);
    }

    /// <summary>Информационный номер версии файла сборки</summary>
    /// <param name="type">Тип, для сборки которого возвращается версия</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <see langword="null" />.</exception>
    public static string GetInfoVersion([NotNull] Type type)
    {
      int num = 3;
      AssemblyInformationalVersionAttribute versionAttribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            // ISSUE: type reference
            versionAttribute = (AssemblyInformationalVersionAttribute) ((IEnumerable<object>) VersionInfo.oyyviiCMVbNVVLiHGqU((object) type.Assembly, VersionInfo.imU4dgCyO3LP4dBaIIi(__typeref (AssemblyInformationalVersionAttribute)), false)).FirstOrDefault<object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 3:
            if (!VersionInfo.kJ4olECgvwuJXKj99GS(type, (Type) null))
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 4:
            goto label_8;
          case 5:
            goto label_7;
          default:
            if (versionAttribute != null)
            {
              num = 5;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return VersionInfo.GetVersion(type).ToString();
label_7:
      return (string) VersionInfo.aLWNUCC5DRTVI5y1piJ((object) versionAttribute);
label_8:
      throw new ArgumentNullException((string) VersionInfo.fcJU1FCmWflAlPV0qp1(~-306453669 ^ 306450566));
    }

    /// <summary>Получить короткий номер файла сборки (в виде 3.1)</summary>
    /// <typeparam name="T">Тип, для сборки которого возвращается версия</typeparam>
    public static string GetShortVersion<T>() => VersionInfo.GetVersion<T>().ToString(2);

    /// <summary>Получить тип редакции системы</summary>
    /// <returns></returns>
    public static ElmaEdition? GetEditionType()
    {
      ElmaEdition? editionType;
      VersionInfo.GetEdition(out editionType);
      return editionType;
    }

    /// <summary>Получить редакцию системы</summary>
    /// <returns></returns>
    public static string GetEdition() => VersionInfo.GetEdition(out ElmaEdition? _);

    /// <summary>Получить редакцию системы</summary>
    /// <returns></returns>
    public static string GetEdition(out ElmaEdition? editionType) => VersionInfo.GetEdition(out editionType, out string _);

    /// <summary>Получить редакцию системы</summary>
    /// <returns></returns>
    public static string GetEdition(out ElmaEdition? editionType, out string dbVersion)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            dbVersion = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
            continue;
          case 3:
            dbVersion = (string) null;
            num = 4;
            continue;
          case 4:
            goto label_6;
          case 5:
            editionType = new ElmaEdition?(ElmaEdition.CE);
            num = 2;
            continue;
          case 6:
            if (VersionInfo.OysxoxCj2VgoCr6Joox())
            {
              num = 5;
              continue;
            }
            break;
        }
        editionType = new ElmaEdition?();
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 2;
      }
label_2:
      return (string) VersionInfo.hSQXFKCYuVS0oixx4RG(ElmaEdition.CE);
label_6:
      return "";
    }

    internal static object fcJU1FCmWflAlPV0qp1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type imU4dgCyO3LP4dBaIIi([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object oyyviiCMVbNVVLiHGqU([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((Assembly) obj0).GetCustomAttributes(obj1, obj2);

    internal static object pMABvtCJjNXentJi4DD([In] object obj0) => (object) ((AssemblyFileVersionAttribute) obj0).Version;

    internal static bool I4PcLjCxmEiSB0wBksy() => VersionInfo.V2KJygC7n9lDkuMxrng == null;

    internal static VersionInfo oGwLVYC0552PMtOr3EO() => VersionInfo.V2KJygC7n9lDkuMxrng;

    internal static object tac6EkC9OZqQiD05lA7([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static bool QQxGRRCdH4bgiADqc3l([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object o8vb04CloUkP2E0xJ04([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object X8pl7uCrxNKbMgu9PoK() => (object) SR.GetCultureFromSettings();

    internal static bool kJ4olECgvwuJXKj99GS([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object aLWNUCC5DRTVI5y1piJ([In] object obj0) => (object) ((AssemblyInformationalVersionAttribute) obj0).InformationalVersion;

    internal static bool OysxoxCj2VgoCr6Joox() => ComponentManager.Initialized;

    internal static object hSQXFKCYuVS0oixx4RG(ElmaEdition edition) => (object) LicensedUnitBase.Providers.GetVersionName(edition);
  }
}
