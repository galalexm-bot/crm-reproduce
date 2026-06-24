// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ConfigImportSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Настройки кастомного импорта</summary>
  [Serializable]
  public sealed class ConfigImportSettings : IConfigImportSettings, IImportSettings
  {
    internal static ConfigImportSettings Ba5NWSEyFU9HxhJY13A7;

    /// <summary>
    /// Конструктор настроек кастомного импорта, для вызова с дизайнера
    /// Импортируемый файл будет загружаться с локального файла
    /// </summary>
    public ConfigImportSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.TestResult = (ICollection<TestImportMessages>) new List<TestImportMessages>();
      this.FakeManifest = new BPMAppFakeManifest();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.CreateFileName();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Конструктор настроек кастомного импорта, для вызова с дизайнера
    /// Импортируемый файл будет загружаться с локального файла
    /// </summary>
    /// <param name="fileName">Имя файла импорта</param>
    public ConfigImportSettings(string fileName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.TestResult = (ICollection<TestImportMessages>) new List<TestImportMessages>();
      this.FakeManifest = new BPMAppFakeManifest();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            ConfigImportSettings.SXJBL3Eybf9sohkXs9Sb((object) fileName, ConfigImportSettings.acl2k2Eyo2qMdg53HpmG(-1204263869 ^ -1341583247 ^ 137431592));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          default:
            this.FileName = fileName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Сгенерировать название временного файла</summary>
    public void CreateFileName()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.FileName = ConfigImportSettings.buawlKEyhXv1AW3X8xsG().ToString();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public int ImportStep
    {
      get => this.\u003CImportStep\u003Ek__BackingField;
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
              this.\u003CImportStep\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public ICollection<TestImportMessages> TestResult { get; }

    /// <inheritdoc />
    public string FileName
    {
      get => this.\u003CFileName\u003Ek__BackingField;
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
              this.\u003CFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public ElmaStoreComponentManifest Manifest
    {
      get => this.\u003CManifest\u003Ek__BackingField;
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
              this.\u003CManifest\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public BPMAppFakeManifest FakeManifest { get; }

    internal static bool VKDZoUEyBBLuWbBWYoqv() => ConfigImportSettings.Ba5NWSEyFU9HxhJY13A7 == null;

    internal static ConfigImportSettings qBF70bEyWBXtY79laOH3() => ConfigImportSettings.Ba5NWSEyFU9HxhJY13A7;

    internal static object acl2k2Eyo2qMdg53HpmG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void SXJBL3Eybf9sohkXs9Sb([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static Guid buawlKEyhXv1AW3X8xsG() => Guid.NewGuid();
  }
}
