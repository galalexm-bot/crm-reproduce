// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Design.DesignEnvironment
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.Components;
using EleWise.ELMA.Packaging.Components.Web;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Design
{
  /// <summary>Класс для работы с окружением дизайнера</summary>
  public static class DesignEnvironment
  {
    private static object lockObject;
    private static object syncObj;
    private static bool initialized;
    private static bool libsLoaded;
    private static string workDir;
    private static string libsDir;
    private static string importCommandDir;
    private static DesignEnvironment OWHqxsqsjLisbXR3tMQ;

    /// <summary>Рабочая папка</summary>
    public static string WorkDir
    {
      get
      {
        DesignEnvironment.w2tJuyKF95UwMQw0UrW();
        return DesignEnvironment.workDir;
      }
    }

    /// <summary>Папка для комманд импорта</summary>
    public static string ImportCommandDir
    {
      get
      {
        DesignEnvironment.w2tJuyKF95UwMQw0UrW();
        return DesignEnvironment.importCommandDir;
      }
    }

    /// <summary>Папка настроек</summary>
    public static string SettingsDir
    {
      get
      {
        DesignEnvironment.w2tJuyKF95UwMQw0UrW();
        return (string) DesignEnvironment.KQduuXKBZBP82Fdb83x();
      }
    }

    /// <summary>Путь до папки библиотек ELMA</summary>
    public static string LibsDir => (string) DesignEnvironment.rWsBB1KWvtIGZeIArHI(true);

    /// <summary>Получить папку с библиотеками</summary>
    /// <param name="loadLibs">Загружать ли в папку системные библиотеки</param>
    /// <returns></returns>
    public static string GetLibsDir(bool loadLibs)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 2:
              if (!loadLibs)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                continue;
              }
              goto case 4;
            case 3:
              goto label_3;
            case 4:
              DesignEnvironment.TwcQ7oKol2Ry0N1wyXs();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        DesignEnvironment.w2tJuyKF95UwMQw0UrW();
        num1 = 2;
      }
label_6:
      return DesignEnvironment.libsDir;
    }

    public static string GetSettingsDir()
    {
      int num = 3;
      string path;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            if (!Directory.Exists(path))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            obj = DesignEnvironment.j5KIq6Kb6SkdYdmg4xy();
            break;
          case 3:
            if (!ComponentManager.Initialized)
            {
              num = 2;
              continue;
            }
            obj = DesignEnvironment.nJe2W2KhAdZT546a0ON((object) ComponentManager.Current);
            break;
          default:
            goto label_4;
        }
        string str = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107970424);
        path = (string) DesignEnvironment.Ak4oEDKGkDXxKbI5HVJ(obj, (object) str);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
      }
label_4:
      return ((FileSystemInfo) DesignEnvironment.IE9MudKEj9ifS5DX5H9((object) path)).FullName;
label_5:
      return path;
    }

    private static void CheckInitialized()
    {
      int num1 = 2;
      object syncObj;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_50;
          case 1:
            syncObj = DesignEnvironment.syncObj;
            num1 = 5;
            continue;
          case 2:
            if (!DesignEnvironment.initialized)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
              continue;
            }
            goto label_23;
          case 3:
            goto label_52;
          case 4:
            goto label_4;
          case 5:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 4 : 3;
            continue;
          default:
            goto label_48;
        }
      }
label_50:
      return;
label_52:
      return;
label_48:
      return;
label_23:
      return;
label_4:
      try
      {
        Monitor.Enter(syncObj, ref lockTaken);
        int num2 = 15;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
          num2 = 19;
        while (true)
        {
          string upper;
          string setting;
          string str;
          SHA1 shA1;
          object obj;
          switch (num2)
          {
            case 0:
              goto label_45;
            case 1:
label_16:
              setting = EleWise.ELMA.SR.GetSetting((string) DesignEnvironment.dy7d8qKikyrZ2LmNfsJ(1051802738 - -1831968059 ^ -1411216773));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 5 : 1;
              continue;
            case 2:
              DesignEnvironment.IE9MudKEj9ifS5DX5H9((object) DesignEnvironment.workDir);
              num2 = 10;
              continue;
            case 3:
              goto label_41;
            case 4:
              if (DesignEnvironment.HnlIVcKKdsXGHCPbXk3((object) DesignEnvironment.libsDir))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 3;
                continue;
              }
              goto case 18;
            case 5:
              if (DesignEnvironment.dU80sPKR2TpnM0yh7He((object) setting))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 12 : 13;
                continue;
              }
              obj = (object) setting;
              break;
            case 6:
              DesignEnvironment.IE9MudKEj9ifS5DX5H9((object) DesignEnvironment.importCommandDir);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 5 : 7;
              continue;
            case 7:
              DesignEnvironment.libsDir = Path.Combine(DesignEnvironment.workDir, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669233933));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 4 : 3;
              continue;
            case 8:
              try
              {
                str = (string) DesignEnvironment.VUKl2VKS5JLRRIHhFqj((object) ((string) DesignEnvironment.FNcFWnKVQlRbpuWbN4M(DesignEnvironment.iy0EVUKIQHv1pVBYm9l((object) shA1, DesignEnvironment.OTYi9UKuGbf2hTjtI5l(DesignEnvironment.EjvCfhKZu87sMFWXVR1(), (object) upper)))).Replace('/', '#'), '=', '@');
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_16;
                }
              }
              finally
              {
                int num4;
                if (shA1 == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
                else
                  goto label_29;
label_26:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_29:
                shA1.Dispose();
                num4 = 2;
                goto label_26;
              }
            case 9:
              shA1 = (SHA1) DesignEnvironment.HgDyfbK8O7uBfjt0BNK();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 8 : 7;
              continue;
            case 10:
              DesignEnvironment.UvMQ8aKTB7Sh68tOWwf(DesignEnvironment.Ak4oEDKGkDXxKbI5HVJ((object) DesignEnvironment.workDir, DesignEnvironment.dy7d8qKikyrZ2LmNfsJ(1917998801 >> 2 ^ 479510944)), DesignEnvironment.PagsYsKXZOakxwqTRpR(DesignEnvironment.dy7d8qKikyrZ2LmNfsJ(-70007027 ^ -70020315), (object) upper), DesignEnvironment.EjvCfhKZu87sMFWXVR1());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 14 : 3;
              continue;
            case 11:
              upper = ((string) DesignEnvironment.dUeYuIKvdD3Z1pR13If(DesignEnvironment.pdkhomKCUARnkLoJAd2(DesignEnvironment.GFEoEXKQv2sImBvcofo(DesignEnvironment.x3OZLxKftikTeyX4FyY())))).ToUpper();
              num2 = 9;
              continue;
            case 12:
              if (!Directory.Exists(DesignEnvironment.importCommandDir))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 6 : 1;
                continue;
              }
              goto case 7;
            case 13:
              obj = DesignEnvironment.TNJCNiKqfb8UqaC3ut2((object) Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DesignEnvironment.dy7d8qKikyrZ2LmNfsJ(-1598106783 - -968262081 ^ -629864746), DesignEnvironment.dy7d8qKikyrZ2LmNfsJ(132912447 ^ 132923711), (object) str);
              break;
            case 14:
              DesignEnvironment.importCommandDir = (string) DesignEnvironment.Ak4oEDKGkDXxKbI5HVJ((object) DesignEnvironment.workDir, DesignEnvironment.dy7d8qKikyrZ2LmNfsJ(-787452571 ^ -787465955));
              num2 = 12;
              continue;
            case 15:
              DesignEnvironment.initialized = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 11 : 11;
              continue;
            case 16:
              if (!DesignEnvironment.HnlIVcKKdsXGHCPbXk3((object) DesignEnvironment.workDir))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 2;
                continue;
              }
              goto case 14;
            case 17:
              goto label_28;
            case 18:
              DesignEnvironment.IE9MudKEj9ifS5DX5H9((object) DesignEnvironment.libsDir);
              num2 = 17;
              continue;
            case 19:
              if (DesignEnvironment.initialized)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              goto case 15;
            default:
              goto label_27;
          }
          DesignEnvironment.workDir = (string) obj;
          num2 = 16;
        }
label_45:
        return;
label_41:
        return;
label_28:
        return;
label_27:;
      }
      finally
      {
        int num5;
        if (!lockTaken)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
        else
          goto label_46;
label_44:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_46:
        DesignEnvironment.bLnYdcKkgJZNr81hpUd(syncObj);
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        {
          num5 = 2;
          goto label_44;
        }
        else
          goto label_44;
      }
    }

    private static void LoadLibs()
    {
      int num1 = 3;
      IServerInfoManager service;
      bool lockTaken;
      object lockObject;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_8;
          case 2:
            if (!DesignEnvironment.libsLoaded)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            }
            goto label_61;
          case 3:
            if (DesignEnvironment.VZljJ1Knf9384OS83vV())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 2 : 2;
              continue;
            }
            goto label_65;
          case 4:
            if (service == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 3 : 6;
              continue;
            }
            lockObject = DesignEnvironment.lockObject;
            num1 = 7;
            continue;
          case 5:
            goto label_79;
          case 6:
            goto label_7;
          case 7:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 8 : 9;
            continue;
          case 8:
            goto label_10;
          case 9:
            goto label_14;
          default:
            service = Locator.GetService<IServerInfoManager>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 3 : 4;
            continue;
        }
      }
label_8:
      return;
label_79:
      return;
label_7:
      return;
label_10:
      return;
label_65:
      return;
label_61:
      return;
label_14:
      try
      {
        Monitor.Enter(lockObject, ref lockTaken);
        int num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
          num2 = 5;
        string str1;
        AssemblyHashInfo[] assemblyHashInfoArray;
        int index;
        AssemblyHashInfo assemblyHashInfo1;
        byte[] numArray;
        bool flag1;
        bool flag2;
        string str2;
        string path;
        IEnumerator<string> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: type reference
              str2 = Path.Combine((string) DesignEnvironment.dUeYuIKvdD3Z1pR13If((object) DesignEnvironment.YjWh2jKaUlmYSudhYGs(__typeref (EleWise.ELMA.SR)).Assembly.Location), (string) DesignEnvironment.whmlkxKDBqOyYImOZvM((object) assemblyHashInfo1));
              num2 = 10;
              continue;
            case 2:
              if (DesignEnvironment.zwGfPRKtJ5vxbqxyoZB((object) str1))
              {
                num2 = 9;
                continue;
              }
              goto case 12;
            case 3:
              DesignEnvironment.libsLoaded = true;
              num2 = 25;
              continue;
            case 4:
            case 29:
label_26:
              if (flag1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 19 : 27;
                continue;
              }
              goto case 24;
            case 5:
              if (!DesignEnvironment.libsLoaded)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 15 : 7;
                continue;
              }
              goto label_71;
            case 6:
              str1 = (string) DesignEnvironment.Ak4oEDKGkDXxKbI5HVJ((object) DesignEnvironment.libsDir, (object) assemblyHashInfo1.AssemblyName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 9 : 26;
              continue;
            case 7:
            case 31:
              if (!(flag1 & flag2))
              {
                num2 = 29;
                continue;
              }
              goto case 20;
            case 8:
            case 15:
              object obj = DesignEnvironment.NxySP6KOeewKasPj7Ex((object) service);
              PackageService packageService = ((ComponentManager) DesignEnvironment.aaPjafK2gk3nfxkghm2()).PackageService;
              WebComponent component = DesignEnvironment.NGArInKeCB2eWSWdGhl((object) packageService) ? packageService.GetComponent((string) DesignEnvironment.dy7d8qKikyrZ2LmNfsJ(333888594 ^ 1075625116 ^ 1408914540)) as WebComponent : (WebComponent) null;
              path = (string) null;
              if (component != null && DesignEnvironment.W65h9FKPbj3xrSPA1my((object) component))
                path = (string) DesignEnvironment.fjZyAxK1FS0Y7GaIEfE((object) component);
              flag2 = !DesignEnvironment.lNkTZTKNhjcmd5OgAR3((object) path) && DesignEnvironment.HnlIVcKKdsXGHCPbXk3((object) path);
              assemblyHashInfoArray = (AssemblyHashInfo[]) obj;
              num2 = 21;
              continue;
            case 9:
              DesignEnvironment.yRQ0A7K7m0MSJbMSICI((object) str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 12 : 10;
              continue;
            case 10:
              if (DesignEnvironment.zwGfPRKtJ5vxbqxyoZB((object) str2))
              {
                num2 = 16;
                continue;
              }
              goto case 7;
            case 11:
            case 18:
              if (index < assemblyHashInfoArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 12:
              DesignEnvironment.tAeQWFKxFnCGgTtJ0CX((object) str1, (object) numArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 12 : 24;
              continue;
            case 13:
              try
              {
label_54:
                if (DesignEnvironment.vI99b4K6NwE218iqsaF((object) enumerator))
                  goto label_59;
                else
                  goto label_55;
label_52:
                string current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      AssemblyHashInfo assemblyHashInfo2 = new AssemblyHashInfo();
                      DesignEnvironment.syvRRmK3xiAZpjj02mw((object) assemblyHashInfo2, (object) current);
                      flag1 = DesignEnvironment.iE9jTHKwPkGVnmnfeeX(DesignEnvironment.sZY9HjKpoeEBZNJ3EIF((object) assemblyHashInfo2), (object) assemblyHashInfo1.HashCode);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 4 : 1;
                      continue;
                    case 2:
                    case 3:
                      goto label_26;
                    case 4:
                      if (!flag1)
                      {
                        num3 = 5;
                        continue;
                      }
                      goto label_54;
                    case 5:
                      File.Copy(current, str1, true);
                      num3 = 2;
                      continue;
                    case 6:
                      goto label_59;
                    default:
                      goto label_54;
                  }
                }
label_55:
                num3 = 3;
                goto label_52;
label_59:
                current = enumerator.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                {
                  num3 = 0;
                  goto label_52;
                }
                else
                  goto label_52;
              }
              finally
              {
                int num4;
                if (enumerator == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                else
                  goto label_66;
label_64:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_66:
                DesignEnvironment.kBfxQGKHkfZrFKLtAsL((object) enumerator);
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                {
                  num4 = 1;
                  goto label_64;
                }
                else
                  goto label_64;
              }
            case 14:
              if (!flag1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 33 : 2;
                continue;
              }
              goto case 7;
            case 16:
              AssemblyHashInfo assemblyHashInfo3 = new AssemblyHashInfo();
              DesignEnvironment.syvRRmK3xiAZpjj02mw((object) assemblyHashInfo3, (object) str2);
              flag1 = DesignEnvironment.iE9jTHKwPkGVnmnfeeX(DesignEnvironment.sZY9HjKpoeEBZNJ3EIF((object) assemblyHashInfo3), DesignEnvironment.sZY9HjKpoeEBZNJ3EIF((object) assemblyHashInfo1));
              num2 = 14;
              continue;
            case 19:
              if (!flag1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 7;
                continue;
              }
              goto case 1;
            case 20:
              enumerator = Directory.EnumerateFiles(path, (string) DesignEnvironment.whmlkxKDBqOyYImOZvM((object) assemblyHashInfo1), SearchOption.AllDirectories).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 13 : 11;
              continue;
            case 21:
              index = 0;
              num2 = 18;
              continue;
            case 22:
              goto label_74;
            case 23:
              if (numArray == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 30 : 21;
                continue;
              }
              goto case 2;
            case 24:
            case 30:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 11 : 7;
              continue;
            case 25:
              goto label_68;
            case 26:
              if (File.Exists(str1))
              {
                num2 = 32;
                continue;
              }
              goto case 19;
            case 27:
              numArray = (byte[]) DesignEnvironment.MMSTWiKA5WAjM6pLud6((object) service, (object) assemblyHashInfo1.AssemblyName);
              num2 = 23;
              continue;
            case 28:
              flag1 = true;
              num2 = 6;
              continue;
            case 32:
              AssemblyHashInfo assemblyHashInfo4 = new AssemblyHashInfo();
              DesignEnvironment.syvRRmK3xiAZpjj02mw((object) assemblyHashInfo4, (object) str1);
              flag1 = (string) DesignEnvironment.sZY9HjKpoeEBZNJ3EIF((object) assemblyHashInfo4) != (string) DesignEnvironment.sZY9HjKpoeEBZNJ3EIF((object) assemblyHashInfo1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 19 : 12;
              continue;
            case 33:
              DesignEnvironment.e0C1NUK4rBDLH3MlVyH((object) str2, (object) str1, true);
              num2 = 31;
              continue;
            default:
              assemblyHashInfo1 = assemblyHashInfoArray[index];
              num2 = 28;
              continue;
          }
        }
label_74:
        return;
label_68:
        return;
label_71:;
      }
      finally
      {
        if (lockTaken)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_81;
              default:
                Monitor.Exit(lockObject);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_81:;
      }
    }

    private static bool IsAssembly(object fileName)
    {
      switch (1)
      {
        case 1:
          bool flag;
          try
          {
            DesignEnvironment.BDAKr0K0dacVy6R31Qu(fileName);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
              num = 0;
            switch (num)
            {
              default:
                goto label_12;
            }
          }
          catch (FileNotFoundException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_13;
                default:
                  flag = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
                  continue;
              }
            }
          }
          catch (BadImageFormatException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_13;
                default:
                  flag = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_13:
          return flag;
      }
label_12:
      return true;
    }

    private static void CopyFileIfChanged(object newFileName, object oldFileName)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        FileStream inputStream;
        while (true)
        {
          switch (num2)
          {
            case 1:
              inputStream = new FileStream((string) newFileName, FileMode.Open, FileAccess.Read);
              num2 = 6;
              continue;
            case 2:
              DesignEnvironment.yRQ0A7K7m0MSJbMSICI(oldFileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_24;
            case 4:
              goto label_3;
            case 5:
              if (File.Exists((string) newFileName))
              {
                if (DesignEnvironment.zwGfPRKtJ5vxbqxyoZB(oldFileName))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
                  continue;
                }
                goto label_28;
              }
              else
              {
                num2 = 4;
                continue;
              }
            case 6:
              goto label_4;
            case 7:
              goto label_28;
            default:
              goto label_32;
          }
        }
label_4:
        try
        {
          FileStream fileStream = new FileStream((string) oldFileName, FileMode.Open, FileAccess.Read);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
            num3 = 0;
          switch (num3)
          {
            default:
              try
              {
                if (DesignEnvironment.Compare((object) new MD5CryptoServiceProvider().ComputeHash((Stream) inputStream), (object) (byte[]) DesignEnvironment.jnCQZBKmeWmkMRAb5Je((object) new MD5CryptoServiceProvider(), (object) fileStream)))
                  return;
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                  num4 = 1;
                switch (num4)
                {
                  case 2:
                    return;
                }
              }
              finally
              {
                if (fileStream != null)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_19;
                      default:
                        fileStream.Dispose();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_19:;
              }
              break;
          }
        }
        finally
        {
          if (inputStream != null)
          {
            int num6 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
              num6 = 0;
            while (true)
            {
              switch (num6)
              {
                case 1:
                  DesignEnvironment.kBfxQGKHkfZrFKLtAsL((object) inputStream);
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_26;
              }
            }
          }
label_26:;
        }
label_28:
        if (DesignEnvironment.zwGfPRKtJ5vxbqxyoZB(oldFileName))
        {
          num1 = 2;
          continue;
        }
label_32:
        File.Copy((string) newFileName, (string) oldFileName);
        num1 = 3;
      }
label_24:
      return;
label_3:;
    }

    private static bool Compare(object a, object b)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              if (a.Length != b.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
                continue;
              }
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_5;
            case 5:
              if ((int) (byte) a[index] != (int) (byte) b[index])
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 6 : 6;
                continue;
              }
              goto label_11;
            case 6:
              goto label_10;
            default:
              if (index >= a.Length)
              {
                num2 = 3;
                continue;
              }
              goto case 5;
          }
        }
label_11:
        ++index;
        num1 = 4;
      }
label_5:
      return true;
label_10:
      return false;
label_12:
      return false;
    }

    static DesignEnvironment()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DesignEnvironment.GX52oIKyrsShxTMfTp2();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            DesignEnvironment.syncObj = new object();
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            DesignEnvironment.lockObject = new object();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void w2tJuyKF95UwMQw0UrW() => DesignEnvironment.CheckInitialized();

    internal static object KQduuXKBZBP82Fdb83x() => (object) DesignEnvironment.GetSettingsDir();

    internal static object rWsBB1KWvtIGZeIArHI(bool loadLibs) => (object) DesignEnvironment.GetLibsDir(loadLibs);

    internal static void TwcQ7oKol2Ry0N1wyXs() => DesignEnvironment.LoadLibs();

    internal static bool bSpHXjqcTgZwijGepKO() => DesignEnvironment.OWHqxsqsjLisbXR3tMQ == null;

    internal static DesignEnvironment crMoeVqze5lidwdQIFN() => DesignEnvironment.OWHqxsqsjLisbXR3tMQ;

    internal static object j5KIq6Kb6SkdYdmg4xy() => (object) DesignEnvironment.WorkDir;

    internal static object nJe2W2KhAdZT546a0ON([In] object obj0) => (object) ((ComponentManager) obj0).WorkDirectory;

    internal static object Ak4oEDKGkDXxKbI5HVJ([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object IE9MudKEj9ifS5DX5H9([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object x3OZLxKftikTeyX4FyY() => (object) AppDomain.CurrentDomain;

    internal static object GFEoEXKQv2sImBvcofo([In] object obj0) => (object) ((AppDomain) obj0).SetupInformation;

    internal static object pdkhomKCUARnkLoJAd2([In] object obj0) => (object) ((AppDomainSetup) obj0).ConfigurationFile;

    internal static object dUeYuIKvdD3Z1pR13If([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object HgDyfbK8O7uBfjt0BNK() => (object) SHA1.Create();

    internal static object EjvCfhKZu87sMFWXVR1() => (object) Encoding.UTF8;

    internal static object OTYi9UKuGbf2hTjtI5l([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static object iy0EVUKIQHv1pVBYm9l([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static object FNcFWnKVQlRbpuWbN4M([In] object obj0) => (object) Convert.ToBase64String((byte[]) obj0);

    internal static object VUKl2VKS5JLRRIHhFqj([In] object obj0, [In] char obj1, [In] char obj2) => (object) ((string) obj0).Replace(obj1, obj2);

    internal static object dy7d8qKikyrZ2LmNfsJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool dU80sPKR2TpnM0yh7He([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object TNJCNiKqfb8UqaC3ut2([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2, (string) obj3);

    internal static bool HnlIVcKKdsXGHCPbXk3([In] object obj0) => Directory.Exists((string) obj0);

    internal static object PagsYsKXZOakxwqTRpR([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void UvMQ8aKTB7Sh68tOWwf([In] object obj0, [In] object obj1, [In] object obj2) => File.WriteAllText((string) obj0, (string) obj1, (Encoding) obj2);

    internal static void bLnYdcKkgJZNr81hpUd([In] object obj0) => Monitor.Exit(obj0);

    internal static bool VZljJ1Knf9384OS83vV() => Locator.Initialized;

    internal static object NxySP6KOeewKasPj7Ex([In] object obj0) => (object) ((IServerInfoManager) obj0).GetBinaryHashInfos();

    internal static object aaPjafK2gk3nfxkghm2() => (object) ComponentManager.Current;

    internal static bool NGArInKeCB2eWSWdGhl([In] object obj0) => ((PackageService) obj0).Initialized;

    internal static bool W65h9FKPbj3xrSPA1my([In] object obj0) => ((ElmaComponent) obj0).IsInstalled();

    internal static object fjZyAxK1FS0Y7GaIEfE([In] object obj0) => (object) ((ElmaComponent) obj0).ComponentRoot;

    internal static bool lNkTZTKNhjcmd5OgAR3([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void syvRRmK3xiAZpjj02mw([In] object obj0, [In] object obj1) => ((AssemblyHashInfo) obj0).EvaluteMD5((string) obj1);

    internal static object sZY9HjKpoeEBZNJ3EIF([In] object obj0) => (object) ((AssemblyHashInfo) obj0).HashCode;

    internal static Type YjWh2jKaUlmYSudhYGs([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object whmlkxKDBqOyYImOZvM([In] object obj0) => (object) ((AssemblyHashInfo) obj0).AssemblyName;

    internal static bool zwGfPRKtJ5vxbqxyoZB([In] object obj0) => File.Exists((string) obj0);

    internal static bool iE9jTHKwPkGVnmnfeeX([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void e0C1NUK4rBDLH3MlVyH([In] object obj0, [In] object obj1, [In] bool obj2) => File.Copy((string) obj0, (string) obj1, obj2);

    internal static bool vI99b4K6NwE218iqsaF([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void kBfxQGKHkfZrFKLtAsL([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object MMSTWiKA5WAjM6pLud6([In] object obj0, [In] object obj1) => (object) ((IServerInfoManager) obj0).GetAssemblyRaw((string) obj1);

    internal static void yRQ0A7K7m0MSJbMSICI([In] object obj0) => File.Delete((string) obj0);

    internal static void tAeQWFKxFnCGgTtJ0CX([In] object obj0, [In] object obj1) => File.WriteAllBytes((string) obj0, (byte[]) obj1);

    internal static object BDAKr0K0dacVy6R31Qu([In] object obj0) => (object) AssemblyName.GetAssemblyName((string) obj0);

    internal static object jnCQZBKmeWmkMRAb5Je([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static void GX52oIKyrsShxTMfTp2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
