// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates
{
  [Service]
  public class TemplateLoader : IInitHandler
  {
    private static readonly Guid Guid;
    private string templatesPath;
    private Dictionary<string, TemplateFileInfo> dictTemplateFileInfo;
    private FileSystemWatcher _watcher;
    private static TemplateLoader m1LAkrB1er5EgvSjNrlP;

    public static TemplateLoader Instance => Locator.GetService<TemplateLoader>();

    /// <summary>Запущенное приложение</summary>
    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
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
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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

    /// <summary>Истчники шаблонов оповещений</summary>
    public IEnumerable<ITemplateDataSource> DataSources { get; set; }

    /// <summary>Менеджер данных, хранящих данные объектов</summary>
    public IBLOBDataManager BlobManager
    {
      get => this.\u003CBlobManager\u003Ek__BackingField;
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
              this.\u003CBlobManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    public void Init()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.dictTemplateFileInfo = new Dictionary<string, TemplateFileInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Завершение инициализации - здесь производится копирование шаблонов в файловую систему
    /// </summary>
    public void InitComplete()
    {
      int num = 7;
      string directoryName;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._watcher.EnableRaisingEvents = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 1;
            continue;
          case 2:
            goto label_8;
          case 3:
            if (this.RuntimeApplication != null)
            {
              num = 9;
              continue;
            }
            goto label_4;
          case 4:
            this.DoInitTemplates(false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 12 : 6;
            continue;
          case 5:
            TemplateLoader.Xtd5VjB1484TA7tNJU8m((object) this._watcher, (object) new FileSystemEventHandler(this.WatcherCreated));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
            continue;
          case 6:
            goto label_3;
          case 7:
            if (this.DataSources == null)
            {
              num = 6;
              continue;
            }
            goto case 3;
          case 8:
            if (!TemplateLoader.JpuDtyB1txd4T4MeQjoi((object) this.templatesPath))
            {
              num = 14;
              continue;
            }
            goto case 4;
          case 9:
            if (TemplateLoader.IGbQNAB1NJvigm29UoNK((object) this.RuntimeApplication) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 10:
            goto label_22;
          case 11:
            this.templatesPath = (string) TemplateLoader.RCll9kB1D9ERqVLQQj46((object) directoryName, TemplateLoader.OQCUdDB1aBNU99LDT8sT(-1120607109 - 305487170 ^ -1426089611));
            num = 8;
            continue;
          case 12:
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
            TemplateLoader.zW06N5B1wPOK4o0EvhCK((object) fileSystemWatcher, true);
            fileSystemWatcher.Path = EleWise.ELMA.SR.Dir;
            this._watcher = fileSystemWatcher;
            num = 13;
            continue;
          case 13:
            this._watcher.Created += new FileSystemEventHandler(this.WatcherCreated);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 3 : 5;
            continue;
          case 14:
            Directory.CreateDirectory(this.templatesPath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 4 : 0;
            continue;
          default:
            directoryName = Path.GetDirectoryName((string) TemplateLoader.C8yuHOB1pFLGFGeqvDdw(TemplateLoader.HrscTCB13ZmRDLVJejHU(TemplateLoader.IGbQNAB1NJvigm29UoNK((object) this.RuntimeApplication))));
            num = 11;
            continue;
        }
      }
label_8:
      return;
label_3:
      return;
label_22:
      return;
label_4:
      return;
label_2:;
    }

    protected void WatcherCreated(object sender, FileSystemEventArgs e)
    {
      int num1 = 2;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_23;
          case 1:
            goto label_2;
          case 2:
            disposable = (IDisposable) TemplateLoader.qcj8lPB16lF1idFQDvB9();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
            continue;
          default:
            goto label_20;
        }
      }
label_23:
      return;
label_20:
      return;
label_2:
      try
      {
        CallContextSessionOwner contextSessionOwner = (CallContextSessionOwner) TemplateLoader.xw2y6OB1HyPAdd0yyXQq();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              this.DoInitTemplates(true);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                num3 = 0;
              switch (num3)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            finally
            {
              int num4;
              if (contextSessionOwner == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
              else
                goto label_14;
label_11:
              switch (num4)
              {
                case 2:
                  break;
                default:
              }
label_14:
              contextSessionOwner.Dispose();
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
              {
                num4 = 0;
                goto label_11;
              }
              else
                goto label_11;
            }
        }
      }
      finally
      {
        int num5;
        if (disposable == null)
          num5 = 2;
        else
          goto label_21;
label_19:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_21:
        TemplateLoader.vIRVNVB1AEkljXABFdrY((object) disposable);
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        {
          num5 = 0;
          goto label_19;
        }
        else
          goto label_19;
      }
    }

    protected string GetTemplateFileName(string name, out TemplateFileInfo fileInfo)
    {
      int num = 12;
      string path;
      while (true)
      {
        CultureInfo cultureInfo;
        string key1;
        string key2;
        switch (num)
        {
          case 1:
            path = (string) TemplateLoader.RCll9kB1D9ERqVLQQj46((object) this.templatesPath, (object) (fileInfo.Name + (string) TemplateLoader.OQCUdDB1aBNU99LDT8sT(-1445902765 ^ -1980277732 ^ 539450177) + (string) TemplateLoader.fIIOHZB1MjyIlmaxSNwP((object) fileInfo)));
            num = 5;
            continue;
          case 2:
            if (!File.Exists(path))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 10 : 3;
              continue;
            }
            goto case 4;
          case 3:
            if (fileInfo != null)
            {
              num = 19;
              continue;
            }
            goto label_15;
          case 4:
            if (!TemplateLoader.xyRvRTB1Jyy2mDx1JQ8b((object) path))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 22 : 19;
              continue;
            }
            goto case 20;
          case 5:
            if (TemplateLoader.tVupqCB19IS4LjiODWub((object) path))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 16 : 2;
              continue;
            }
            goto label_11;
          case 6:
          case 9:
            if (!TemplateLoader.tVupqCB19IS4LjiODWub((object) path))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 7:
            key2 = string.Format((string) TemplateLoader.OQCUdDB1aBNU99LDT8sT(-1837662597 ^ -1837744481), (object) name, cultureInfo == null || ((string) TemplateLoader.BdTOdyB1x4FEbeeJBh3u((object) cultureInfo)).Equals(((CultureInfo) TemplateLoader.OZoCmDB10v9CBQydfpMy()).Name, StringComparison.OrdinalIgnoreCase) ? (object) string.Empty : TemplateLoader.BdTOdyB1x4FEbeeJBh3u((object) cultureInfo));
            num = 15;
            continue;
          case 8:
            path = Path.Combine(this.templatesPath, (string) TemplateLoader.xerTQcB1y5ACYRZMUxkN((object) fileInfo) + (string) TemplateLoader.DgRBkXB1mGLjcdTryPIr(TemplateLoader.OQCUdDB1aBNU99LDT8sT(323422137 << 2 ^ 1293770726), TemplateLoader.BdTOdyB1x4FEbeeJBh3u((object) cultureInfo)) + fileInfo.Extension);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 1;
            continue;
          case 10:
            path = Path.Combine(this.templatesPath, (string) TemplateLoader.xerTQcB1y5ACYRZMUxkN((object) fileInfo) + (string) TemplateLoader.DgRBkXB1mGLjcdTryPIr((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822841062), TemplateLoader.BdTOdyB1x4FEbeeJBh3u((object) cultureInfo)) + (string) TemplateLoader.OQCUdDB1aBNU99LDT8sT(-1426456882 ^ 2009939514 ^ -583695878) + (string) TemplateLoader.fIIOHZB1MjyIlmaxSNwP((object) fileInfo));
            num = 4;
            continue;
          case 11:
            cultureInfo = (CultureInfo) TemplateLoader.CbkLAoB17xC6OWEYlV6P();
            num = 7;
            continue;
          case 12:
            fileInfo = (TemplateFileInfo) null;
            num = 11;
            continue;
          case 13:
            if (!this.dictTemplateFileInfo.ContainsKey(key2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            }
            break;
          case 14:
            if (cultureInfo != null)
            {
              num = 8;
              continue;
            }
            goto case 4;
          case 15:
            key1 = (string) TemplateLoader.DgRBkXB1mGLjcdTryPIr(TemplateLoader.OQCUdDB1aBNU99LDT8sT(~210725948 ^ -210644171), (object) name);
            num = 13;
            continue;
          case 16:
            goto label_12;
          case 17:
            goto label_15;
          case 18:
            goto label_11;
          case 19:
            path = string.Empty;
            num = 14;
            continue;
          case 20:
            path = (string) TemplateLoader.RCll9kB1D9ERqVLQQj46((object) this.templatesPath, TemplateLoader.yA9oQTB1dKoLG5mk2et7(TemplateLoader.xerTQcB1y5ACYRZMUxkN((object) fileInfo), TemplateLoader.fIIOHZB1MjyIlmaxSNwP((object) fileInfo)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 6 : 6;
            continue;
          case 21:
            goto label_32;
          case 22:
            if (TemplateLoader.tVupqCB19IS4LjiODWub((object) path))
            {
              num = 9;
              continue;
            }
            goto case 20;
          default:
            if (!this.dictTemplateFileInfo.ContainsKey(key1))
            {
              num = 21;
              continue;
            }
            break;
        }
        fileInfo = this.dictTemplateFileInfo[!this.dictTemplateFileInfo.ContainsKey(key2) ? key1 : key2];
        num = 3;
      }
label_11:
      return "";
label_12:
      return path;
label_15:
      return "";
label_32:
      return "";
    }

    /// <summary>Инициализация шаблонов</summary>
    public void DoInitTemplates()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.DoInitTemplates(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Инициализация шаблонов</summary>
    /// <param name="forceUpdate">ПРинудительно обновить шаблоны в папке конфигурации</param>
    public void DoInitTemplates(bool forceUpdate)
    {
      int num1 = 6;
      string str;
      IEnumerator<ITemplateDataSource> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_47:
            if (forceUpdate)
            {
              num1 = 2;
              continue;
            }
            goto label_38;
          case 2:
            this.BlobManager.SetBLOB<string>(TemplateLoader.Guid, "EleWise.ELMA.Templates.TemplateLoader", str);
            num1 = 8;
            continue;
          case 3:
            forceUpdate = TemplateLoader.kfaPUuB1lgfuktLVixjX((object) this.BlobManager.GetBLOB<string>(TemplateLoader.Guid, "EleWise.ELMA.Templates.TemplateLoader"), (object) str);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 4;
            continue;
          case 4:
          case 9:
            this.dictTemplateFileInfo.Clear();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          case 5:
            if (forceUpdate)
            {
              num1 = 9;
              continue;
            }
            goto case 3;
          case 6:
            str = VersionInfo.GetVersion<EleWise.ELMA.SR>().ToString();
            num1 = 5;
            continue;
          case 7:
            try
            {
label_25:
              if (TemplateLoader.JsoLTkB1Y36uwgLXVoiY((object) enumerator1))
                goto label_34;
              else
                goto label_26;
label_8:
              IEnumerable<TemplateFileInfo> files;
              IEnumerator<TemplateFileInfo> enumerator2;
              ITemplateDataSource current1;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
label_36:
                    if (files != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 4 : 3;
                      continue;
                    }
                    goto label_25;
                  case 2:
                    goto label_47;
                  case 3:
                    try
                    {
                      files = current1.GetFiles();
                      int num3 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
                        num3 = 0;
                      switch (num3)
                      {
                        default:
                          goto label_36;
                      }
                    }
                    catch (Exception ex)
                    {
                      int num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
                        num4 = 0;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            TemplateLoader.vPZUotB1g1bUHCO9Xh4o(TemplateLoader.t6bMG2B1rk43UvZC7lf4(), TemplateLoader.DgRBkXB1mGLjcdTryPIr(TemplateLoader.OQCUdDB1aBNU99LDT8sT(-16752921 ^ -16703545), (object) current1.GetType().FullName), (object) ex);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_25;
                        }
                      }
                    }
                  case 4:
                    enumerator2 = files.GetEnumerator();
                    num2 = 6;
                    continue;
                  case 5:
                    goto label_34;
                  case 6:
                    goto label_10;
                  default:
                    goto label_25;
                }
              }
label_10:
              try
              {
label_16:
                if (TemplateLoader.JsoLTkB1Y36uwgLXVoiY((object) enumerator2))
                  goto label_13;
                else
                  goto label_17;
label_11:
                TemplateFileInfo current2;
                string key;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      key = (string) TemplateLoader.fODHPfB1jxQqlWCKF9Bd(TemplateLoader.OQCUdDB1aBNU99LDT8sT(~-397266137 ^ 397184060), TemplateLoader.xerTQcB1y5ACYRZMUxkN((object) current2), TemplateLoader.HK5CxAB15FcK5cxHTGip((object) current2));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_13;
                    case 3:
                      goto label_25;
                    case 4:
                      this.CheckTemplateFileInfo(current2, forceUpdate);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
                      continue;
                    case 5:
                      goto label_16;
                    default:
                      this.dictTemplateFileInfo[key] = current2;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 5;
                      continue;
                  }
                }
label_13:
                current2 = enumerator2.Current;
                num5 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
                {
                  num5 = 4;
                  goto label_11;
                }
                else
                  goto label_11;
label_17:
                num5 = 3;
                goto label_11;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_24;
                      default:
                        TemplateLoader.vIRVNVB1AEkljXABFdrY((object) enumerator2);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_24:;
              }
label_26:
              num2 = 2;
              goto label_8;
label_34:
              current1 = enumerator1.Current;
              num2 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
              {
                num2 = 3;
                goto label_8;
              }
              else
                goto label_8;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      enumerator1.Dispose();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_45;
                  }
                }
              }
label_45:;
            }
          case 8:
            goto label_43;
          default:
            enumerator1 = this.DataSources.GetEnumerator();
            num1 = 7;
            continue;
        }
      }
label_43:
      return;
label_38:;
    }

    /// <summary>Загрузить шаблон и вернуть локальный путь до него</summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public string LoadTemplate(string name)
    {
      int num1 = 1;
      string str;
      while (true)
      {
        int num2 = num1;
        TemplateFileInfo fileInfo;
        string templateFileName;
        while (true)
        {
          switch (num2)
          {
            case 1:
              templateFileName = this.GetTemplateFileName(name, out fileInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_11;
            case 3:
              if (fileInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 2;
                continue;
              }
              goto label_12;
            case 4:
              goto label_4;
            case 5:
              str = (string) TemplateLoader.UcIKopB1UobxuyXxm0lB((object) str, TemplateLoader.OQCUdDB1aBNU99LDT8sT(1218962250 ^ 1218967950), (object) fileInfo.Extension);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 6;
              continue;
            case 6:
              TemplateLoader.ixnFHgB1sNp4S0N5D2EW((object) templateFileName, (object) str, true);
              num2 = 4;
              continue;
            default:
              if (!TemplateLoader.xyRvRTB1Jyy2mDx1JQ8b((object) templateFileName))
              {
                num2 = 3;
                continue;
              }
              goto label_11;
          }
        }
label_12:
        str = (string) TemplateLoader.ewPwGwB1L8NjleXp6od0();
        num1 = 5;
      }
label_4:
      return str;
label_11:
      return "";
    }

    /// <summary>Загрузить шаблон и вернуть поток с его содержимым</summary>
    /// <param name="name">Имя шаблона.</param>
    /// <returns>Возвращает поток, если шаблон существует. Вернёт null, если шаблон не найден.</returns>
    public Stream GetTemplateStream(string name)
    {
      int num1 = 3;
      string templateFileName;
      while (true)
      {
        int num2 = num1;
        TemplateFileInfo fileInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              if (!TemplateLoader.xyRvRTB1Jyy2mDx1JQ8b((object) templateFileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 3:
              goto label_3;
            case 4:
              goto label_5;
            default:
              if (fileInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 4 : 4;
                continue;
              }
              goto label_4;
          }
        }
label_3:
        templateFileName = this.GetTemplateFileName(name, out fileInfo);
        num1 = 2;
      }
label_4:
      return (Stream) null;
label_5:
      return (Stream) new FileStream(templateFileName, FileMode.Open);
    }

    /// <summary>Загрузить шаблон в путь path</summary>
    /// <param name="name"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public bool LoadTemplate(string name, string path)
    {
      int num = 3;
      TemplateFileInfo fileInfo;
      string templateFileName;
      while (true)
      {
        switch (num)
        {
          case 1:
            File.Copy(templateFileName, path, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!TemplateLoader.xyRvRTB1Jyy2mDx1JQ8b((object) templateFileName))
            {
              num = 5;
              continue;
            }
            goto label_8;
          case 3:
            templateFileName = this.GetTemplateFileName(name, out fileInfo);
            num = 2;
            continue;
          case 4:
            goto label_8;
          case 5:
            if (fileInfo != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
              continue;
            }
            goto label_8;
          default:
            goto label_7;
        }
      }
label_7:
      return true;
label_8:
      return false;
    }

    /// <summary>Сохранить шаблон</summary>
    /// <param name="info"></param>
    /// <param name="fileName"></param>
    public void Save(TemplateFileInfo info, string fileName)
    {
      int num1 = 1;
      Stream manifestResourceStream;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!TemplateLoader.CT0IgrB1zaHLKl4H4XyR(TemplateLoader.xZW3q1B1csUalOwMWheO((object) info), (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_58;
          case 3:
            if (TemplateLoader.xyRvRTB1Jyy2mDx1JQ8b(TemplateLoader.QICxImBNF3WOEwkV71G0((object) info)))
            {
              num1 = 7;
              continue;
            }
            break;
          case 4:
            goto label_4;
          case 5:
            goto label_35;
          case 6:
            goto label_29;
          case 7:
            manifestResourceStream = info.Assembly.GetManifestResourceStream(info.FullName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 4;
            continue;
          case 8:
            fileStream = new FileStream((string) TemplateLoader.QICxImBNF3WOEwkV71G0((object) info), FileMode.Open, FileAccess.Read);
            num1 = 5;
            continue;
        }
        if (TemplateLoader.tVupqCB19IS4LjiODWub(TemplateLoader.QICxImBNF3WOEwkV71G0((object) info)))
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 8 : 8;
        else
          goto label_19;
      }
label_58:
      return;
label_29:
      return;
label_4:
      try
      {
        if (manifestResourceStream == null)
          return;
        int num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
          num2 = 4;
        FileStream destination;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_45;
            case 1:
              goto label_10;
            case 2:
              destination = new FileStream(fileName, FileMode.Create);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_44;
            case 4:
              if (TemplateLoader.xWLaagBNBatmWIKoXCR5((object) manifestResourceStream) <= 0L)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            default:
              goto label_39;
          }
        }
label_45:
        return;
label_44:
        return;
label_39:
        return;
label_10:
        try
        {
          manifestResourceStream.CopyTo((Stream) destination);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
            num3 = 0;
          switch (num3)
          {
            case 0:
              return;
            default:
              return;
          }
        }
        finally
        {
          int num4;
          if (destination == null)
            num4 = 2;
          else
            goto label_16;
label_15:
          switch (num4)
          {
            case 1:
              break;
            default:
          }
label_16:
          TemplateLoader.vIRVNVB1AEkljXABFdrY((object) destination);
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
          {
            num4 = 0;
            goto label_15;
          }
          else
            goto label_15;
        }
      }
      finally
      {
        if (manifestResourceStream != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                TemplateLoader.vIRVNVB1AEkljXABFdrY((object) manifestResourceStream);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                continue;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
label_35:
      try
      {
        if (TemplateLoader.xWLaagBNBatmWIKoXCR5((object) fileStream) <= 0L)
          return;
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
          num6 = 0;
        FileStream destination;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_41;
            case 2:
              goto label_21;
            default:
              destination = new FileStream(fileName, FileMode.Create);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
              continue;
          }
        }
label_21:
        return;
label_41:
        try
        {
          fileStream.CopyTo((Stream) destination);
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
            num7 = 0;
          switch (num7)
          {
            case 0:
              return;
            default:
              return;
          }
        }
        finally
        {
          if (destination != null)
          {
            int num8 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
              num8 = 1;
            while (true)
            {
              switch (num8)
              {
                case 1:
                  TemplateLoader.vIRVNVB1AEkljXABFdrY((object) destination);
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_52;
              }
            }
          }
label_52:;
        }
      }
      finally
      {
        int num9;
        if (fileStream == null)
          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
        else
          goto label_59;
label_56:
        switch (num9)
        {
          case 2:
            break;
          default:
        }
label_59:
        fileStream.Dispose();
        num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        {
          num9 = 0;
          goto label_56;
        }
        else
          goto label_56;
      }
label_19:;
    }

    /// <summary>
    /// Проверить, есть ли обновление указанного шаблона. Если есть - сохранить или заменить файл
    /// </summary>
    /// <param name="fileInfo">Информация о файле шаблонов оповещений</param>
    protected virtual void CheckTemplateFileInfo(TemplateFileInfo fileInfo)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CheckTemplateFileInfo(fileInfo, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Проверить, есть ли обновление указанного шаблона. Если есть - сохранить или заменить файл
    /// </summary>
    /// <param name="fileInfo">Информация о файле шаблонов оповещений</param>
    /// <param name="forceReplace">Заменить существующие шаблоны на системные</param>
    private void CheckTemplateFileInfo(TemplateFileInfo fileInfo, bool forceReplace)
    {
      switch (1)
      {
        case 1:
          try
          {
            int num1;
            if (TemplateLoader.JpuDtyB1txd4T4MeQjoi((object) this.templatesPath))
              num1 = 9;
            else
              goto label_13;
label_3:
            int num2 = num1;
label_4:
            string fileName;
            string path;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  this.Save(fileInfo, fileName);
                  num2 = 6;
                  continue;
                case 2:
                  this.Save(fileInfo, fileName);
                  num2 = 10;
                  continue;
                case 3:
                  goto label_13;
                case 4:
                  TemplateLoader.oLy9mCBNbjUxMwOeWdRQ((object) fileName, (object) path);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
                  continue;
                case 5:
                  goto label_21;
                case 6:
                  goto label_20;
                case 7:
                  goto label_16;
                case 8:
                  if (TemplateLoader.tVupqCB19IS4LjiODWub((object) path))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 7 : 4;
                    continue;
                  }
                  goto case 4;
                case 9:
                case 13:
                  goto label_18;
                case 10:
                  goto label_17;
                case 11:
                  if (!forceReplace)
                  {
                    num2 = 5;
                    continue;
                  }
                  break;
                case 12:
                  if (TemplateLoader.tVupqCB19IS4LjiODWub((object) fileName))
                  {
                    num2 = 11;
                    continue;
                  }
                  goto case 2;
              }
              path = (string) TemplateLoader.RCll9kB1D9ERqVLQQj46((object) this.templatesPath, TemplateLoader.UcIKopB1UobxuyXxm0lB(TemplateLoader.xerTQcB1y5ACYRZMUxkN((object) fileInfo), string.IsNullOrEmpty((string) TemplateLoader.HK5CxAB15FcK5cxHTGip((object) fileInfo)) ? (object) "" : TemplateLoader.DgRBkXB1mGLjcdTryPIr(TemplateLoader.OQCUdDB1aBNU99LDT8sT(1319452732 ^ 1319371070), TemplateLoader.HK5CxAB15FcK5cxHTGip((object) fileInfo)), TemplateLoader.OQCUdDB1aBNU99LDT8sT(-1886646897 ^ -1886565365)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 8 : 2;
            }
label_21:
            break;
label_20:
            break;
label_17:
            break;
label_16:
            File.Delete(path);
            num1 = 4;
            goto label_3;
label_18:
            fileName = (string) TemplateLoader.RCll9kB1D9ERqVLQQj46((object) this.templatesPath, TemplateLoader.cOIwgFBNohAbxUUGgvUK(TemplateLoader.xerTQcB1y5ACYRZMUxkN((object) fileInfo), !TemplateLoader.xyRvRTB1Jyy2mDx1JQ8b(TemplateLoader.HK5CxAB15FcK5cxHTGip((object) fileInfo)) ? TemplateLoader.DgRBkXB1mGLjcdTryPIr(TemplateLoader.OQCUdDB1aBNU99LDT8sT(1917998801 >> 2 ^ 479581366), TemplateLoader.HK5CxAB15FcK5cxHTGip((object) fileInfo)) : (object) "", TemplateLoader.OQCUdDB1aBNU99LDT8sT(-1217523399 ^ -1217441737), TemplateLoader.fIIOHZB1MjyIlmaxSNwP((object) fileInfo)));
            num1 = 12;
            goto label_3;
label_13:
            TemplateLoader.WjJy5tBNWlg2uSDOl0jd((object) this.templatesPath);
            num2 = 13;
            goto label_4;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_15;
                default:
                  TemplateLoader.vPZUotB1g1bUHCO9Xh4o((object) Logger.Log, TemplateLoader.DgRBkXB1mGLjcdTryPIr(TemplateLoader.OQCUdDB1aBNU99LDT8sT(-812025778 ^ -811993410), TemplateLoader.xerTQcB1y5ACYRZMUxkN((object) fileInfo)), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
                  continue;
              }
            }
label_15:
            break;
          }
      }
    }

    public TemplateLoader()
    {
      TemplateLoader.XPTimPBNh3BuYMqIUltA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TemplateLoader()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TemplateLoader.Guid = new Guid((string) TemplateLoader.OQCUdDB1aBNU99LDT8sT(1149433385 + 173655049 ^ 1323170732));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool PXQv2aB1PBpZa3WVO81T() => TemplateLoader.m1LAkrB1er5EgvSjNrlP == null;

    internal static TemplateLoader bakgZhB11jN457NKVLCW() => TemplateLoader.m1LAkrB1er5EgvSjNrlP;

    internal static object IGbQNAB1NJvigm29UoNK([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object HrscTCB13ZmRDLVJejHU([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

    internal static object C8yuHOB1pFLGFGeqvDdw([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).FilePath;

    internal static object OQCUdDB1aBNU99LDT8sT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RCll9kB1D9ERqVLQQj46([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool JpuDtyB1txd4T4MeQjoi([In] object obj0) => Directory.Exists((string) obj0);

    internal static void zW06N5B1wPOK4o0EvhCK([In] object obj0, [In] bool obj1) => ((FileSystemWatcher) obj0).IncludeSubdirectories = obj1;

    internal static void Xtd5VjB1484TA7tNJU8m([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Changed += (FileSystemEventHandler) obj1;

    internal static object qcj8lPB16lF1idFQDvB9() => (object) ELMAContext.CreateIsolated();

    internal static object xw2y6OB1HyPAdd0yyXQq() => (object) CallContextSessionOwner.Create();

    internal static void vIRVNVB1AEkljXABFdrY([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object CbkLAoB17xC6OWEYlV6P() => (object) EleWise.ELMA.SR.GetCurrentCulture();

    internal static object BdTOdyB1x4FEbeeJBh3u([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object OZoCmDB10v9CBQydfpMy() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static object DgRBkXB1mGLjcdTryPIr([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object xerTQcB1y5ACYRZMUxkN([In] object obj0) => (object) ((TemplateFileInfo) obj0).Name;

    internal static object fIIOHZB1MjyIlmaxSNwP([In] object obj0) => (object) ((TemplateFileInfo) obj0).Extension;

    internal static bool xyRvRTB1Jyy2mDx1JQ8b([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool tVupqCB19IS4LjiODWub([In] object obj0) => File.Exists((string) obj0);

    internal static object yA9oQTB1dKoLG5mk2et7([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool kfaPUuB1lgfuktLVixjX([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object t6bMG2B1rk43UvZC7lf4() => (object) Logger.Log;

    internal static void vPZUotB1g1bUHCO9Xh4o([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object HK5CxAB15FcK5cxHTGip([In] object obj0) => (object) ((TemplateFileInfo) obj0).CultureName;

    internal static object fODHPfB1jxQqlWCKF9Bd([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool JsoLTkB1Y36uwgLXVoiY([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object ewPwGwB1L8NjleXp6od0() => (object) IOExtensions.GetTempFileName();

    internal static object UcIKopB1UobxuyXxm0lB([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void ixnFHgB1sNp4S0N5D2EW([In] object obj0, [In] object obj1, [In] bool obj2) => File.Copy((string) obj0, (string) obj1, obj2);

    internal static object xZW3q1B1csUalOwMWheO([In] object obj0) => (object) ((TemplateFileInfo) obj0).Assembly;

    internal static bool CT0IgrB1zaHLKl4H4XyR([In] object obj0, [In] object obj1) => (Assembly) obj0 != (Assembly) obj1;

    internal static object QICxImBNF3WOEwkV71G0([In] object obj0) => (object) ((TemplateFileInfo) obj0).FullPath;

    internal static long xWLaagBNBatmWIKoXCR5([In] object obj0) => ((Stream) obj0).Length;

    internal static object WjJy5tBNWlg2uSDOl0jd([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object cOIwgFBNohAbxUUGgvUK(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static void oLy9mCBNbjUxMwOeWdRQ([In] object obj0, [In] object obj1) => File.Move((string) obj0, (string) obj1);

    internal static void XPTimPBNh3BuYMqIUltA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
