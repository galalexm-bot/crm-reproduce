// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.ModuleImportSettings
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
using System.Runtime.Serialization;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <summary>
  /// Реализация настроек импорта, расширенная под тестирование импорта модулей
  /// </summary>
  [DataContract]
  [Serializable]
  internal sealed class ModuleImportSettings : IConfigImportSettings, IImportSettings
  {
    [DataMember]
    private IConfigImportSettings originalSettings;
    internal static ModuleImportSettings nwerhZEMgPREj4gNbC4K;

    /// <summary>Ctor</summary>
    /// <param name="testSettings">Настройки тестового этапа</param>
    public ModuleImportSettings(TestModuleImportSettings testSettings)
    {
      ModuleImportSettings.N0PCkWEMYB5VSgxfNNDY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            ModuleImportSettings.vnvYSlEMLDDKobXElLmR((object) testSettings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874290967));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.originalSettings = (IConfigImportSettings) ModuleImportSettings.AlFBQaEMUoXoBvYbI21x((object) testSettings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          default:
            this.Compatible = !ModuleImportSettings.daO6vHEMsIXpP4o4DWL1((object) testSettings);
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    [IgnoreDataMember]
    public BPMAppFakeManifest FakeManifest => this.originalSettings.FakeManifest;

    /// <inheritdoc />
    [IgnoreDataMember]
    public ICollection<TestImportMessages> TestResult => this.originalSettings.TestResult;

    /// <inheritdoc />
    [IgnoreDataMember]
    public string FileName
    {
      get => (string) ModuleImportSettings.zODXuYEMcuTA7yrCRVJE((object) this.originalSettings);
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
              ModuleImportSettings.PtgO9iEMz3IaZ9NLyL1y((object) this.originalSettings, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
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
    [IgnoreDataMember]
    public int ImportStep
    {
      get => ModuleImportSettings.ATrEn4EJFiYGcm4FZGx3((object) this.originalSettings);
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
              ModuleImportSettings.cipOIJEJBkSxl4QxycoY((object) this.originalSettings, value);
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

    /// <inheritdoc />
    [IgnoreDataMember]
    public ElmaStoreComponentManifest Manifest
    {
      get => (ElmaStoreComponentManifest) ModuleImportSettings.oXs4ZEEJWvK6EsDngxx0((object) this.originalSettings);
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
              ModuleImportSettings.pSGgVXEJonJWSN3pQ5xx((object) this.originalSettings, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    /// <summary>Совместима ли конфигурация</summary>
    public bool Compatible { get; }

    internal static void N0PCkWEMYB5VSgxfNNDY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void vnvYSlEMLDDKobXElLmR([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object AlFBQaEMUoXoBvYbI21x([In] object obj0) => (object) ((TestModuleImportSettings) obj0).OriginalSettings;

    internal static bool daO6vHEMsIXpP4o4DWL1([In] object obj0) => ((TestModuleImportSettings) obj0).Incompatible;

    internal static bool xR46d2EM5gYMTD87FTdP() => ModuleImportSettings.nwerhZEMgPREj4gNbC4K == null;

    internal static ModuleImportSettings B3SdovEMjXhZ0CFeIe0x() => ModuleImportSettings.nwerhZEMgPREj4gNbC4K;

    internal static object zODXuYEMcuTA7yrCRVJE([In] object obj0) => (object) ((IConfigImportSettings) obj0).FileName;

    internal static void PtgO9iEMz3IaZ9NLyL1y([In] object obj0, [In] object obj1) => ((IConfigImportSettings) obj0).FileName = (string) obj1;

    internal static int ATrEn4EJFiYGcm4FZGx3([In] object obj0) => ((IImportSettings) obj0).ImportStep;

    internal static void cipOIJEJBkSxl4QxycoY([In] object obj0, int value) => ((IImportSettings) obj0).ImportStep = value;

    internal static object oXs4ZEEJWvK6EsDngxx0([In] object obj0) => (object) ((IConfigImportSettings) obj0).Manifest;

    internal static void pSGgVXEJonJWSN3pQ5xx([In] object obj0, [In] object obj1) => ((IConfigImportSettings) obj0).Manifest = (ElmaStoreComponentManifest) obj1;
  }
}
