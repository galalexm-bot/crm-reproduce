// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ModuleTester
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Логика тестирования модулей</summary>
  internal sealed class ModuleTester
  {
    private readonly IModuleMetadataExtractorService metadataExtractorService;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private readonly Action<IConfigImportSettings, string> testAction;
    private static ModuleTester SHCxDeExDHA1IetFlNLB;

    /// <summary>Ctor</summary>
    /// <param name="metadataExtractorService">Сервис извлечения данных о модулях из nuget пакетов</param>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    /// <param name="testAction">Делегат синхронной проверки конфигурации</param>
    public ModuleTester(
      IModuleMetadataExtractorService metadataExtractorService,
      IModuleMetadataLoader moduleMetadataLoader,
      Action<IConfigImportSettings, string> testAction)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.metadataExtractorService = metadataExtractorService;
      this.moduleMetadataLoader = moduleMetadataLoader;
      this.testAction = testAction;
    }

    /// <summary>Событие генерации сообщения</summary>
    public event Action<TestImportMessages> MessageAdded;

    /// <summary>Выполнить проверку модулей</summary>
    /// <param name="configImportSettings">Список конфигураций модулей</param>
    /// <param name="activateKey">Ключ активации</param>
    internal IReadOnlyCollection<IConfigImportSettings> TestModules(
      IEnumerable<IConfigImportSettings> configImportSettings,
      string activateKey)
    {
      List<IConfigImportSettings> configImportSettingsList = new List<IConfigImportSettings>();
      List<EleWise.ELMA.Model.Metadata.ModuleVersion> moduleMetadataContext = new List<EleWise.ELMA.Model.Metadata.ModuleVersion>();
      foreach (IConfigImportSettings configImportSetting in configImportSettings)
      {
        ElmaStoreComponentManifest manifest = configImportSetting.Manifest;
        Version moduleNewVersion;
        if (!Version.TryParse(manifest.Version, out moduleNewVersion))
        {
          Action<TestImportMessages> messageAdded = this.MessageAdded;
          if (messageAdded != null)
            messageAdded(new TestImportMessages(TestImportMessagesType.InfoCommon, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902093701), (object) manifest.Title, (object) manifest.Version)));
        }
        else
        {
          Action<TestImportMessages> messageAdded1 = this.MessageAdded;
          if (messageAdded1 != null)
            messageAdded1(new TestImportMessages(TestImportMessagesType.InfoCommon, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939608558), (object) manifest.Title, (object) manifest.Version)));
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (manifest != null && manifest.ModuleUid != Guid.Empty && this.moduleMetadataLoader.GetModuleVersionHeaders(manifest.ModuleUid).Any<ModuleVersionHeader>((Func<ModuleVersionHeader, bool>) (header => ModuleTester.\u003C\u003Ec__DisplayClass7_0.xcnIHl8D8jAtHABNqmp1(ModuleTester.\u003C\u003Ec__DisplayClass7_0.koDJLy8DvavGn8sV6LZN((object) header), (object) moduleNewVersion))))
          {
            Action<TestImportMessages> messageAdded2 = this.MessageAdded;
            if (messageAdded2 != null)
              messageAdded2(new TestImportMessages(TestImportMessagesType.InfoCommon, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195840003), (object) manifest.Title)));
          }
          else if (!((IEnumerable<Guid>) new Guid[25]
          {
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099553573)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515157469)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112767530)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360400325)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333542586)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487188458)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859079575)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112774034)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643592875)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767789377)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309832740)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886447649)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239511118)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479697316)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876000525)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082336164)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541664127)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870693021)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70203219)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561143160)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61261271)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405638487)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574322660)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1200008549)),
            new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993378005))
          }).Contains<Guid>(manifest.ModuleUid))
          {
            if (manifest != null && manifest.ModuleUid != Guid.Empty)
            {
              TestModuleImportSettings moduleImportSettings = new TestModuleImportSettings(configImportSetting, (IReadOnlyCollection<EleWise.ELMA.Model.Metadata.ModuleVersion>) moduleMetadataContext);
              this.testAction((IConfigImportSettings) moduleImportSettings, activateKey);
              if (moduleImportSettings.HasErrors)
                throw ModuleDeployException.TestError(manifest.Id, manifest.Title, string.Empty);
              if (moduleImportSettings.ModuleMetadata != null)
              {
                configImportSettingsList.Add((IConfigImportSettings) new ModuleImportSettings(moduleImportSettings));
                moduleMetadataContext.Add(ModuleTester.ModuleVersion((object) moduleImportSettings));
                if (moduleImportSettings.Incompatible)
                {
                  Action<TestImportMessages> messageAdded3 = this.MessageAdded;
                  if (messageAdded3 != null)
                    messageAdded3(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104966048), (object) manifest.Title)));
                }
              }
            }
            else
            {
              this.testAction(configImportSetting, activateKey);
              configImportSettingsList.Add(configImportSetting);
              moduleMetadataContext.AddRange(this.metadataExtractorService.ExtractModules(configImportSetting));
            }
          }
        }
      }
      return (IReadOnlyCollection<IConfigImportSettings>) configImportSettingsList;
    }

    private static EleWise.ELMA.Model.Metadata.ModuleVersion ModuleVersion(object settings)
    {
      int num = 2;
      ModuleInfoMetadata moduleMetadata;
      Version version1;
      Guid desaExHzOuQjrtQlsg;
      while (true)
      {
        Version result;
        Version version2;
        switch (num)
        {
          case 1:
            version2 = result;
            break;
          case 2:
            object obj = ModuleTester.Uqv4mJEx4Bi5yWTcsqTs(settings);
            moduleMetadata = ((TestModuleImportSettings) settings).ModuleMetadata;
            if (Version.TryParse((string) ModuleTester.Kiv28oEx6D4boVJ39bKG(obj), out result))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
              continue;
            }
            goto case 3;
          case 3:
            version2 = ModuleVersionHeader.DefaultVersion;
            break;
          case 4:
            desaExHzOuQjrtQlsg = ModuleTester.ToDESAExHZOuQJrtQLsg(moduleMetadata.Uid, (object) version1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
        version1 = version2;
        num = 4;
      }
label_8:
      return new EleWise.ELMA.Model.Metadata.ModuleVersion(moduleMetadata, new ModuleVersionHeader(moduleMetadata.GetSignature(), desaExHzOuQjrtQlsg, ModuleTester.qYyN9lExA7EHQ7T6GqvV((object) moduleMetadata), version1, ModuleTester.iali47Ex7seibiPFdvXn(settings) ? ModuleStatus.Disabled : ModuleStatus.Enabled, ModuleTester.iali47Ex7seibiPFdvXn(settings) ? ModuleDisabledReason.Dependency : ModuleDisabledReason.Unknown));
    }

    internal static object Uqv4mJEx4Bi5yWTcsqTs([In] object obj0) => (object) ((TestModuleImportSettings) obj0).Manifest;

    internal static object Kiv28oEx6D4boVJ39bKG([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Version;

    internal static Guid ToDESAExHZOuQJrtQLsg(Guid headerUid, [In] object obj1) => ModuleVersionHeader.DefaultVersionUid(headerUid, (Version) obj1);

    internal static Guid qYyN9lExA7EHQ7T6GqvV([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool iali47Ex7seibiPFdvXn([In] object obj0) => ((TestModuleImportSettings) obj0).Incompatible;

    internal static bool hSJyToExt4Zc5FFBONRU() => ModuleTester.SHCxDeExDHA1IetFlNLB == null;

    internal static ModuleTester r2aMmgExw1RjPlPUPdER() => ModuleTester.SHCxDeExDHA1IetFlNLB;
  }
}
