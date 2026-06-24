// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.PatternLayoutExt
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using log4net.Layout;
using Microsoft.Win32;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Hosting;

namespace EleWise.ELMA.Logging
{
  public class PatternLayoutExt : PatternLayout
  {
    private static string version;
    private static string dbVersion;
    private static string serverSoftware;
    private static string os;
    private static string framework;
    private static string cpu;
    private static string hdd;
    private static bool? ki;
    private static string applicationDirectory;
    private static string configurationDirectory;
    private static PatternLayoutExt AoL253h9htG1u7sWULuF;

    private static T GetValue<T>(object resource, object property)
    {
      string property1 = (string) property;
      using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978341621) + property1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978341607) + (string) resource))
        return managementObjectSearcher.Get().Cast<ManagementObject>().Select<ManagementObject, object>((Func<ManagementObject, object>) (item => item[property1])).Cast<T>().FirstOrDefault<T>();
    }

    private static void GetValues<T1, T2>(
      object resource,
      object p1,
      object p2,
      out T1 v1,
      out T2 v2)
    {
      string p1_1 = (string) p1;
      string p2_1 = (string) p2;
      using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099744937) + p1_1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306450598) + p2_1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099744955) + (string) resource))
      {
        // ISSUE: object of a compiler-generated type is created
        var data = managementObjectSearcher.Get().Cast<ManagementObject>().Select(i => new \u003C\u003Ef__AnonymousType6<T1, T2>((T1) i[p1_1], (T2) i[p2_1])).FirstOrDefault();
        if (data != null)
        {
          v1 = data.v1;
          v2 = data.v2;
        }
        else
        {
          v1 = default (T1);
          v2 = default (T2);
        }
      }
    }

    private static void GetValues<T1, T2, T3>(
      object resource,
      object p1,
      object p2,
      object p3,
      out T1 v1,
      out T2 v2,
      out T3 v3)
    {
      string p1_1 = (string) p1;
      string p2_1 = (string) p2;
      string p3_1 = (string) p3;
      using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122004994) + p1_1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536802408) + p2_1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812026804) + p3_1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606664434) + (string) resource))
      {
        // ISSUE: object of a compiler-generated type is created
        var data = managementObjectSearcher.Get().Cast<ManagementObject>().Select(i => new \u003C\u003Ef__AnonymousType7<T1, T2, T3>((T1) i[p1_1], (T2) i[p2_1], (T3) i[p3_1])).FirstOrDefault();
        if (data != null)
        {
          v1 = data.v1;
          v2 = data.v2;
          v3 = data.v3;
        }
        else
        {
          v1 = default (T1);
          v2 = default (T2);
          v3 = default (T3);
        }
      }
    }

    private static string Format1024(Decimal mb)
    {
      int num1 = 1;
      Decimal num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = PatternLayoutExt.vqRhcVh9fERD9t6qaeTw(mb, 1024M);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return num2.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767822747));
    }

    /// <summary>Версия ELMA</summary>
    public static string Version
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              PatternLayoutExt.version = (string) PatternLayoutExt.e9n35jh9CnWCMYX9sYDv(PatternLayoutExt.FN9qweh9QKJ3TOh8furk(1669212571 ^ 1669184061), (object) VersionInfo.GetInfoVersion<EleWise.ELMA.SR>(), (object) VersionInfo.GetEdition(out ElmaEdition? _, out PatternLayoutExt.dbVersion));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            case 2:
              if (PatternLayoutExt.dbVersion == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
                continue;
              }
              goto label_7;
            case 3:
              if (PatternLayoutExt.version != null)
              {
                num = 2;
                continue;
              }
              goto case 1;
            default:
              goto label_7;
          }
        }
label_7:
        return PatternLayoutExt.version;
      }
    }

    /// <summary>Приложение WEB-сервера</summary>
    public static string ServerSoftware
    {
      get
      {
        int num = 1;
        FileVersionInfo fileVersionInfo;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (PatternLayoutExt.serverSoftware != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              PatternLayoutExt.serverSoftware = (string) PatternLayoutExt.kg06tLh9u89qYk5IjwCF((object) fileVersionInfo) + (string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(874012245 ^ 874237341) + (string) PatternLayoutExt.rNGkvWh9IPqauR4VTboE((object) fileVersionInfo) + (string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-1088304168 ^ -1088312078) + (!PatternLayoutExt.lM9MsNh9ViWXg1PXaytx() ? (string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(647913418 ^ 647875608) : (string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(~541731958 ^ -541704085)) + (string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-87337865 ^ -87340085);
              num = 3;
              continue;
            case 4:
              fileVersionInfo = (FileVersionInfo) PatternLayoutExt.Sd8YyHh9ZoCJeAX7co5X(PatternLayoutExt.iftolIh98OGUwsoiR1uD(PatternLayoutExt.fO2Kxvh9vWe29RySeABi()));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return PatternLayoutExt.serverSoftware;
      }
    }

    /// <summary>Приложение базы данных</summary>
    public static string DataBaseSoftware
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (PatternLayoutExt.version == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              PatternLayoutExt.Am3Npwh9S6NcRAm4yJwg();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 2 : 1;
              continue;
          }
        }
label_2:
        return PatternLayoutExt.dbVersion;
      }
    }

    /// <summary>Версия операционной системы</summary>
    public static string OS
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (PatternLayoutExt.os == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 2:
              goto label_12;
            default:
              goto label_2;
          }
        }
label_2:
        try
        {
          string v1;
          string v2;
          string v3;
          PatternLayoutExt.GetValues<string, string, string>(PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-2138958856 ^ -2138996726), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647875562), PatternLayoutExt.FN9qweh9QKJ3TOh8furk(813604817 ^ 813501411), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858920235), out v1, out v2, out v3);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
            num2 = 0;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_12;
              default:
                PatternLayoutExt.os = (string) PatternLayoutExt.T1EUqHh9iohRemjarotd((object) new string[6]
                {
                  v1,
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77660965),
                  v2,
                  (string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(1199946765 ^ 1199943695),
                  v3,
                  (string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(1052221104 - 768835541 ^ 283378023)
                });
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
                continue;
            }
          }
        }
        catch
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
label_12:
        return PatternLayoutExt.os;
      }
    }

    /// <summary>Версия .Net Framework</summary>
    public static string Framework
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (PatternLayoutExt.framework == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                continue;
              }
              goto label_21;
            case 2:
              goto label_21;
            default:
              goto label_2;
          }
        }
label_2:
        try
        {
          RegistryKey registryKey = (RegistryKey) PatternLayoutExt.qPiE5uh9qDYiWN5fMMQE(PatternLayoutExt.wbi14Hh9RiHgsocwxd3q(RegistryHive.LocalMachine, RegistryView.Registry32), PatternLayoutExt.FN9qweh9QKJ3TOh8furk(516838154 ^ 516802392));
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
            num2 = 0;
          switch (num2)
          {
            case 1:
              break;
            default:
              try
              {
                PatternLayoutExt.framework = (string) PatternLayoutExt.flcC1Jh9XpPv4plJDJsD(PatternLayoutExt.arXRwuh9Ko92SIFeE4Ue((object) registryKey, PatternLayoutExt.FN9qweh9QKJ3TOh8furk(1199946765 ^ 1199914361)));
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                  num3 = 0;
                switch (num3)
                {
                }
              }
              finally
              {
                if (registryKey != null)
                {
                  int num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                    num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        PatternLayoutExt.c71LOGh9T1qNoVQN3JuF((object) registryKey);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_15;
                    }
                  }
                }
label_15:;
              }
              break;
          }
        }
        catch
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
            num5 = 0;
          switch (num5)
          {
          }
        }
label_21:
        return PatternLayoutExt.framework;
      }
    }

    /// <summary>Процессор</summary>
    public static string CPU
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (PatternLayoutExt.cpu == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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
        return PatternLayoutExt.cpu;
label_3:
        try
        {
          PatternLayoutExt.cpu = PatternLayoutExt.GetValue<string>(PatternLayoutExt.FN9qweh9QKJ3TOh8furk(1669371371 ^ 1669529943), PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-1710575414 ^ -1710570742));
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
            num2 = 0;
          switch (num2)
          {
            default:
              goto label_2;
          }
        }
        catch
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_2;
          }
        }
      }
    }

    /// <summary>Использование оперативной памяти</summary>
    public static string Memory
    {
      get
      {
        string memory;
        switch (1)
        {
          case 1:
            try
            {
              ulong v1;
              ulong v2;
              PatternLayoutExt.GetValues<ulong, ulong>((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876025507), PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-1334993905 ^ -1334966063), PatternLayoutExt.FN9qweh9QKJ3TOh8furk(1149433385 + 173655049 ^ 1323249460), out v1, out v2);
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                num = 0;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_9;
                  default:
                    memory = (string) PatternLayoutExt.f2lFDSh9OsklxKxyCYDV(PatternLayoutExt.yghX92h9kAfpHGBAb2hu((Decimal) (v1 / 1024UL)), PatternLayoutExt.FN9qweh9QKJ3TOh8furk(381945751 ^ 1158627804 ^ 1405821467), PatternLayoutExt.yghX92h9kAfpHGBAb2hu(PatternLayoutExt.Sg8xhph9n2UhcxPXCVj8(v2 / 1024UL)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516802108));
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
                    continue;
                }
              }
            }
            catch
            {
              int num = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    memory = (string) null;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_9;
                }
              }
            }
        }
label_9:
        return memory;
      }
    }

    /// <summary>Использование жесткого диска</summary>
    public static string HDD
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (PatternLayoutExt.hdd == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 2:
              goto label_12;
            default:
              goto label_4;
          }
        }
label_4:
        try
        {
          DriveInfo[] source = (DriveInfo[]) PatternLayoutExt.klu64Uh92PXbhYTsbCn3();
          int num2 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
            num2 = 0;
          while (true)
          {
            switch (num2)
            {
              case 1:
                PatternLayoutExt.hdd = string.Join((string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(222162814 ^ 222159740), ((IEnumerable<DriveInfo>) source).Where<DriveInfo>((Func<DriveInfo, bool>) (d => PatternLayoutExt.\u003C\u003Ec.MkKCQHvHV01B8Q9HgV0f((object) d) == DriveType.Fixed)).Select<DriveInfo, string>((Func<DriveInfo, string>) (drive => (string) PatternLayoutExt.\u003C\u003Ec.icd6n2vHkVoZ4NQZx5Fg((object) new object[8]
                {
                  PatternLayoutExt.\u003C\u003Ec.IKWsIFvHi86qnQXgAI0u(PatternLayoutExt.\u003C\u003Ec.vHRfHtvHScPA5S7nFFDI((object) drive), (object) new char[1]
                  {
                    '\\'
                  }),
                  (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70047478),
                  PatternLayoutExt.\u003C\u003Ec.QsT86kvHRE58huKrDxsn((object) drive),
                  PatternLayoutExt.\u003C\u003Ec.PAZjnQvHqwOdM0FmA0ZJ(-1217523399 ^ -1217520325),
                  PatternLayoutExt.\u003C\u003Ec.dxehsfvHXU1ojDT5H0GA(PatternLayoutExt.\u003C\u003Ec.YJOKYdvHKmEqJoXr9XHb(drive.AvailableFreeSpace / 1048576L)),
                  PatternLayoutExt.\u003C\u003Ec.PAZjnQvHqwOdM0FmA0ZJ(2045296739 + 1688595713 ^ -561067724),
                  (object) (PatternLayoutExt.\u003C\u003Ec.cqUI4WvHTMa3pkx0KO6v((object) drive) / 1073741824L),
                  PatternLayoutExt.\u003C\u003Ec.PAZjnQvHqwOdM0FmA0ZJ(2008901894 << 3 ^ -1108441328)
                }))));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
                continue;
              default:
                goto label_12;
            }
          }
        }
        catch
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
label_12:
        return PatternLayoutExt.hdd;
      }
    }

    /// <summary>Использование конструктора интерфейсов</summary>
    public static bool? KI
    {
      get
      {
        if (!PatternLayoutExt.ki.HasValue)
        {
          try
          {
            PatternLayoutExt.ki = new bool?(Locator.GetService<IFeatureFlagService>().Enabled(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597036220), false));
          }
          catch
          {
          }
        }
        return PatternLayoutExt.ki;
      }
    }

    /// <summary>Директория установки приложения</summary>
    public static string ApplicationDirectory
    {
      get
      {
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 2:
              if (PatternLayoutExt.applicationDirectory == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
                continue;
              }
              goto case 6;
            case 3:
              PatternLayoutExt.applicationDirectory = (string) PatternLayoutExt.IpP22Vh9esRTwGXKuxnL(PatternLayoutExt.FN9qweh9QKJ3TOh8furk(87862435 ^ 88029667));
              num = 2;
              continue;
            case 5:
              if (PatternLayoutExt.applicationDirectory != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 4;
                continue;
              }
              goto case 3;
            case 6:
              PatternLayoutExt.applicationDirectory = (string) PatternLayoutExt.cYRuwBh9PT7fa81FaBuM((object) PatternLayoutExt.applicationDirectory, (object) new char[1]
              {
                '\\'
              });
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return PatternLayoutExt.applicationDirectory;
      }
    }

    /// <summary>Директория конфигурации</summary>
    public static string ConfigurationDirectory
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (PatternLayoutExt.configurationDirectory == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return PatternLayoutExt.configurationDirectory;
label_5:
        try
        {
          string str = (string) PatternLayoutExt.gtFCPbh939ljGcQ3WD7A(PatternLayoutExt.HgrmLGh9NyIgq9db1kik(PatternLayoutExt.doI751h91La32g2v7N5X(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088404330)));
          int num2 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
            num2 = 1;
          while (true)
          {
            object obj;
            switch (num2)
            {
              case 1:
                if (PatternLayoutExt.W1gHBBh9pc0fDSjAu4BZ((object) str))
                {
                  num2 = 3;
                  continue;
                }
                goto case 2;
              case 2:
                obj = PatternLayoutExt.pmhGYlh9DVtH10NXkcQm(PatternLayoutExt.c427uwh9aUGHTm7b9Rxm((object) AppDomain.CurrentDomain), (object) str);
                break;
              case 3:
                obj = (object) str;
                break;
              default:
                goto label_4;
            }
            PatternLayoutExt.configurationDirectory = (string) PatternLayoutExt.HWodNRh9tKmIjq5ksyuY(obj);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
          }
        }
        catch
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_4;
          }
        }
      }
    }

    public override string Header
    {
      get
      {
        string header;
        switch (1)
        {
          case 1:
            try
            {
              StringBuilder stringBuilder = new StringBuilder();
              int num1 = 17;
              while (true)
              {
                int num2 = num1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      stringBuilder.Append((string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-710283084 ^ -537863435 ^ 173718531)).Append((string) PatternLayoutExt.zUiWjvh900GrCnTWYkor()).AppendLine();
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 3 : 15;
                      continue;
                    case 2:
                      PatternLayoutExt.EVHplBh9H8KFlVN1h4we((object) ((StringBuilder) PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218523860))).Append((string) PatternLayoutExt.gO8dATh9yxfPjD0f08Bl()));
                      num2 = 13;
                      continue;
                    case 3:
                      PatternLayoutExt.EVHplBh9H8KFlVN1h4we(PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu(PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317565712)), (object) PatternLayoutExt.CPU));
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 3 : 11;
                      continue;
                    case 4:
                      goto label_32;
                    case 5:
                      PatternLayoutExt.EVHplBh9H8KFlVN1h4we((object) stringBuilder);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 6 : 4;
                      continue;
                    case 6:
                      PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder, PatternLayoutExt.oqLsvZh9MjtCG56MOC2T((object) this));
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 10 : 1;
                      continue;
                    case 7:
                      PatternLayoutExt.EVHplBh9H8KFlVN1h4we(PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu(PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813501041)), PatternLayoutExt.nfO9Cdh96IML2qCEQDxD()));
                      num2 = 16;
                      continue;
                    case 8:
                    case 20:
                      if (PatternLayoutExt.gO8dATh9yxfPjD0f08Bl() != null)
                        goto case 2;
                      else
                        goto label_6;
                    case 9:
                      ((StringBuilder) PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853069324))).Append((string) PatternLayoutExt.J7heD6h97GF36u6N70O5()).AppendLine();
                      num2 = 14;
                      continue;
                    case 10:
                      header = stringBuilder.ToString();
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 4;
                      continue;
                    case 11:
                      PatternLayoutExt.EVHplBh9H8KFlVN1h4we(PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu(PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder, PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-87337865 ^ -87506343)), (object) PatternLayoutExt.Memory));
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
                      continue;
                    case 12:
                      ((StringBuilder) PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397302408)), PatternLayoutExt.u3UYWdh9mPdrb6chR7mA())).AppendLine();
                      num2 = 8;
                      continue;
                    case 13:
                    case 19:
                      object obj1 = PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105295526));
                      bool? ki = PatternLayoutExt.KI;
                      object obj2;
                      if (!ki.HasValue)
                      {
                        obj2 = PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-2107978722 ^ -2107976620);
                      }
                      else
                      {
                        ki = PatternLayoutExt.KI;
                        obj2 = (object) ki.Value.ToString();
                      }
                      ((StringBuilder) PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu(obj1, obj2)).AppendLine();
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 3 : 5;
                      continue;
                    case 14:
                      PatternLayoutExt.EVHplBh9H8KFlVN1h4we((object) ((StringBuilder) PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder, PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-105199646 ^ -105295330))).Append((string) PatternLayoutExt.W5YLP9h9x0AA2mnTg1JN()));
                      num2 = 3;
                      continue;
                    case 15:
                      if (PatternLayoutExt.u3UYWdh9mPdrb6chR7mA() == null)
                      {
                        num2 = 20;
                        continue;
                      }
                      goto case 12;
                    case 16:
                      if (PatternLayoutExt.DataBaseSoftware != null)
                      {
                        num2 = 18;
                        continue;
                      }
                      goto case 9;
                    case 17:
                      ((StringBuilder) PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder.Append((string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(-1088304168 ^ -1088266594)), (object) DateTime.Now.ToString((string) PatternLayoutExt.FN9qweh9QKJ3TOh8furk(589593376 ^ -1977315327 ^ -1459388849)))).AppendLine();
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                      continue;
                    case 18:
                      PatternLayoutExt.EVHplBh9H8KFlVN1h4we(PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu(PatternLayoutExt.ukKOxDh9wRx4jHC7MgMu((object) stringBuilder, PatternLayoutExt.FN9qweh9QKJ3TOh8furk(1470998129 - 231418599 ^ 1239543372)), PatternLayoutExt.L9sJFlh9AeZiDxOukeXX()));
                      num2 = 9;
                      continue;
                    default:
                      goto label_15;
                  }
                }
label_6:
                num1 = 19;
                continue;
label_15:
                PatternLayoutExt.obFtx7h94BeNlyWmahD8((object) stringBuilder, PatternLayoutExt.Am3Npwh9S6NcRAm4yJwg());
                num1 = 7;
              }
            }
            catch
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
                num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    header = base.Header;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_32;
                }
              }
            }
        }
label_32:
        return header;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              PatternLayoutExt.gxYifnh9JNrWLdLSqIZS((object) this, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public PatternLayoutExt()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Decimal vqRhcVh9fERD9t6qaeTw([In] Decimal obj0, [In] Decimal obj1) => obj0 / obj1;

    internal static bool ntSOash9GZ1qCjxJhrgf() => PatternLayoutExt.AoL253h9htG1u7sWULuF == null;

    internal static PatternLayoutExt S5bKnNh9EeAesWnUYuYZ() => PatternLayoutExt.AoL253h9htG1u7sWULuF;

    internal static object FN9qweh9QKJ3TOh8furk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object e9n35jh9CnWCMYX9sYDv([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object fO2Kxvh9vWe29RySeABi() => (object) Process.GetCurrentProcess();

    internal static object iftolIh98OGUwsoiR1uD([In] object obj0) => (object) ((Process) obj0).MainModule;

    internal static object Sd8YyHh9ZoCJeAX7co5X([In] object obj0) => (object) ((ProcessModule) obj0).FileVersionInfo;

    internal static object kg06tLh9u89qYk5IjwCF([In] object obj0) => (object) ((FileVersionInfo) obj0).ProductName;

    internal static object rNGkvWh9IPqauR4VTboE([In] object obj0) => (object) ((FileVersionInfo) obj0).ProductVersion;

    internal static bool lM9MsNh9ViWXg1PXaytx() => Environment.Is64BitProcess;

    internal static object Am3Npwh9S6NcRAm4yJwg() => (object) PatternLayoutExt.Version;

    internal static object T1EUqHh9iohRemjarotd([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object wbi14Hh9RiHgsocwxd3q([In] RegistryHive obj0, [In] RegistryView obj1) => (object) RegistryKey.OpenBaseKey(obj0, obj1);

    internal static object qPiE5uh9qDYiWN5fMMQE([In] object obj0, [In] object obj1) => (object) ((RegistryKey) obj0).OpenSubKey((string) obj1);

    internal static object arXRwuh9Ko92SIFeE4Ue([In] object obj0, [In] object obj1) => ((RegistryKey) obj0).GetValue((string) obj1);

    internal static object flcC1Jh9XpPv4plJDJsD([In] object obj0) => (object) Convert.ToString(obj0);

    internal static void c71LOGh9T1qNoVQN3JuF([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object yghX92h9kAfpHGBAb2hu(Decimal mb) => (object) PatternLayoutExt.Format1024(mb);

    internal static Decimal Sg8xhph9n2UhcxPXCVj8([In] ulong obj0) => (Decimal) obj0;

    internal static object f2lFDSh9OsklxKxyCYDV(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object klu64Uh92PXbhYTsbCn3() => (object) DriveInfo.GetDrives();

    internal static object IpP22Vh9esRTwGXKuxnL([In] object obj0) => (object) HostingEnvironment.MapPath((string) obj0);

    internal static object cYRuwBh9PT7fa81FaBuM([In] object obj0, [In] object obj1) => (object) ((string) obj0).TrimEnd((char[]) obj1);

    internal static object doI751h91La32g2v7N5X() => (object) ConfigurationManager.ConnectionStrings;

    internal static object HgrmLGh9NyIgq9db1kik([In] object obj0, [In] object obj1) => (object) ((ConnectionStringSettingsCollection) obj0)[(string) obj1];

    internal static object gtFCPbh939ljGcQ3WD7A([In] object obj0) => (object) ((ConnectionStringSettings) obj0).ConnectionString;

    internal static bool W1gHBBh9pc0fDSjAu4BZ([In] object obj0) => Path.IsPathRooted((string) obj0);

    internal static object c427uwh9aUGHTm7b9Rxm([In] object obj0) => (object) ((AppDomain) obj0).BaseDirectory;

    internal static object pmhGYlh9DVtH10NXkcQm([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object HWodNRh9tKmIjq5ksyuY([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object ukKOxDh9wRx4jHC7MgMu([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object obFtx7h94BeNlyWmahD8([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static object nfO9Cdh96IML2qCEQDxD() => (object) PatternLayoutExt.ServerSoftware;

    internal static object EVHplBh9H8KFlVN1h4we([In] object obj0) => (object) ((StringBuilder) obj0).AppendLine();

    internal static object L9sJFlh9AeZiDxOukeXX() => (object) PatternLayoutExt.DataBaseSoftware;

    internal static object J7heD6h97GF36u6N70O5() => (object) PatternLayoutExt.OS;

    internal static object W5YLP9h9x0AA2mnTg1JN() => (object) PatternLayoutExt.Framework;

    internal static object zUiWjvh900GrCnTWYkor() => (object) PatternLayoutExt.HDD;

    internal static object u3UYWdh9mPdrb6chR7mA() => (object) PatternLayoutExt.ApplicationDirectory;

    internal static object gO8dATh9yxfPjD0f08Bl() => (object) PatternLayoutExt.ConfigurationDirectory;

    internal static object oqLsvZh9MjtCG56MOC2T([In] object obj0) => (object) __nonvirtual (((LayoutSkeleton) obj0).Header);

    internal static void gxYifnh9JNrWLdLSqIZS([In] object obj0, [In] object obj1) => __nonvirtual (((LayoutSkeleton) obj0).Header) = (string) obj1;
  }
}
