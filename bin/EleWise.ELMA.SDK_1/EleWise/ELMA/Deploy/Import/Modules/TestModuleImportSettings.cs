// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.TestModuleImportSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <summary>
  /// Реализация настроек импорта, расширенная под тестирование импорта модулей
  /// </summary>
  internal sealed class TestModuleImportSettings : IConfigImportSettings, IImportSettings
  {
    private static TestModuleImportSettings hoF6IhEJSFpUM9v1Ydir;

    /// <summary>Ctor</summary>
    /// <param name="settings">Базовые настройки импорта</param>
    /// <param name="moduleMetadataContext">Дополнительный контекст метаданных</param>
    public TestModuleImportSettings(
      IConfigImportSettings settings,
      IReadOnlyCollection<ModuleVersion> moduleMetadataContext)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210732723));
      Contract.ArgumentNotNull((object) moduleMetadataContext, z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825663576));
      this.OriginalSettings = settings;
      this.ModuleMetadataContext = moduleMetadataContext;
    }

    /// <inheritdoc />
    public BPMAppFakeManifest FakeManifest => (BPMAppFakeManifest) TestModuleImportSettings.S5uLJGEJqXLIVP5vbHHD((object) this.OriginalSettings);

    /// <inheritdoc />
    public ICollection<TestImportMessages> TestResult => this.OriginalSettings.TestResult;

    /// <inheritdoc />
    public string FileName
    {
      get => (string) TestModuleImportSettings.flGZO9EJKjXf1Fa271LP((object) this.OriginalSettings);
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
              TestModuleImportSettings.wNWeQCEJXsGCiUUx2xuj((object) this.OriginalSettings, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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
    public int ImportStep
    {
      get => TestModuleImportSettings.Twp6nNEJT2RG6xWfIwgE((object) this.OriginalSettings);
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
              TestModuleImportSettings.FmZDPeEJk2VWLS6J8MI7((object) this.OriginalSettings, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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
      get => (ElmaStoreComponentManifest) TestModuleImportSettings.VKe07aEJnbHOlwiR4BRU((object) this.OriginalSettings);
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
              this.OriginalSettings.Manifest = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор заголовка модуля</summary>
    public Guid? ModuleHeaderUid { get; set; }

    /// <summary>Метаданные протестированного модуля</summary>
    public ModuleInfoMetadata ModuleMetadata
    {
      get => this.\u003CModuleMetadata\u003Ek__BackingField;
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
              this.\u003CModuleMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    /// <summary>
    /// Дополнительный контекст метаданных для тестирования импорта модуля
    /// </summary>
    public IReadOnlyCollection<ModuleVersion> ModuleMetadataContext { get; set; }

    /// <summary>Наличие ошибок в результате тестирования</summary>
    public bool HasErrors => this.TestResult.Any<TestImportMessages>((Func<TestImportMessages, bool>) (tr => TestModuleImportSettings.\u003C\u003Ec.xfB7AD86uFaAI2axEaKp((object) tr) == TestImportMessagesType.Error));

    /// <summary>Оригинальные настройки</summary>
    public IConfigImportSettings OriginalSettings { get; }

    /// <summary>
    /// Признак несовместимости модуля с редакцией системы или лицензированием
    /// </summary>
    public bool Incompatible
    {
      get => this.\u003CIncompatible\u003Ek__BackingField;
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
              this.\u003CIncompatible\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    internal static object S5uLJGEJqXLIVP5vbHHD([In] object obj0) => (object) ((IConfigImportSettings) obj0).FakeManifest;

    internal static bool iGSmBUEJiII1ehlAjRtQ() => TestModuleImportSettings.hoF6IhEJSFpUM9v1Ydir == null;

    internal static TestModuleImportSettings nqXY2REJRBL43IhnmWfJ() => TestModuleImportSettings.hoF6IhEJSFpUM9v1Ydir;

    internal static object flGZO9EJKjXf1Fa271LP([In] object obj0) => (object) ((IConfigImportSettings) obj0).FileName;

    internal static void wNWeQCEJXsGCiUUx2xuj([In] object obj0, [In] object obj1) => ((IConfigImportSettings) obj0).FileName = (string) obj1;

    internal static int Twp6nNEJT2RG6xWfIwgE([In] object obj0) => ((IImportSettings) obj0).ImportStep;

    internal static void FmZDPeEJk2VWLS6J8MI7([In] object obj0, int value) => ((IImportSettings) obj0).ImportStep = value;

    internal static object VKe07aEJnbHOlwiR4BRU([In] object obj0) => (object) ((IConfigImportSettings) obj0).Manifest;
  }
}
