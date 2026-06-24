// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.AutoDeployService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис авторазвертывания компонентов ELMA</summary>
  [Service]
  public class AutoDeployService : IAutoDeployService, IAutoDeployWithResultService
  {
    /// <summary>Основное расширение для файла авторазвертывания.</summary>
    public const string AutoDeployExtension = ".elma4deploy";
    /// <summary>Устаревшая маска файлов авторазвертывания.</summary>
    [Obsolete("Константа устарела. Используйте массив AutoDeployMasks.", true)]
    public const string AutoDeployMask = "*.elma3deploy";
    /// <summary>
    /// Расширения файлов автодеплоя, принимаемые сервисом авторазвертывания.
    /// </summary>
    public static readonly string[] AllowedAutoDeployExtensions;
    /// <summary>Маски для файлов автодеплоя.</summary>
    public static readonly string[] AutoDeployMasks;
    private static readonly EleWise.ELMA.Logging.ILogger DeployLog;
    internal static AutoDeployService K4cWdEEHVcMEgNoaS6PX;

    private string DefaultAutoDeployPath()
    {
      int num1 = 2;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!AutoDeployService.NW3HeNEHXbyNJ1Ku4KHP((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              str = (string) AutoDeployService.PKUS72EHKKn6swMQ9jxy(AutoDeployService.WV9tFuEHRwCCp4TYNLwd((object) Locator.GetServiceNotNull<PackageService>()), AutoDeployService.NOqQvoEHqpypsttIQ10j(-1872275253 >> 6 ^ -29027467));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_7;
            default:
              goto label_6;
          }
        }
label_6:
        AutoDeployService.R4eZwKEHTNTlOAWr5Bbj((object) str);
        num1 = 3;
      }
label_7:
      return str;
    }

    private string DefaultSubmodulesPath(string mainPath)
    {
      int num = 1;
      string path;
      while (true)
      {
        switch (num)
        {
          case 1:
            path = (string) AutoDeployService.PKUS72EHKKn6swMQ9jxy((object) mainPath, AutoDeployService.NOqQvoEHqpypsttIQ10j(2045296739 + 1688595713 ^ -561372342));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            AutoDeployService.R4eZwKEHTNTlOAWr5Bbj((object) path);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 1;
            continue;
          default:
            if (!Directory.Exists(path))
            {
              num = 3;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return path;
    }

    private string GetModulePath(string mainPath, string deployFile)
    {
      int num = 4;
      string modulePath;
      while (true)
      {
        switch (num)
        {
          case 2:
            AutoDeployService.R4eZwKEHTNTlOAWr5Bbj((object) modulePath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
            continue;
          case 3:
            if (AutoDeployService.NW3HeNEHXbyNJ1Ku4KHP((object) modulePath))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 4:
            modulePath = (string) AutoDeployService.PKUS72EHKKn6swMQ9jxy((object) mainPath, (object) ((string) AutoDeployService.irB9GcEHkLRx4w9RFEXZ((object) deployFile) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272622863) + AutoDeployService.jNWBr6EHnfuZdCBXT5P1().ToString((string) AutoDeployService.NOqQvoEHqpypsttIQ10j(-1886646897 ^ -1886879709))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return modulePath;
    }

    private string GetSubmodulePath(string mainPath, AutoDeployService.ManifestItem manifest)
    {
      int num = 1;
      string path;
      while (true)
      {
        switch (num)
        {
          case 1:
            path = (string) AutoDeployService.PKUS72EHKKn6swMQ9jxy((object) mainPath, AutoDeployService.wtJZyUEHeZHPAxYcd2jK(AutoDeployService.NOqQvoEHqpypsttIQ10j(-680446928 - -370807692 ^ -309721256), AutoDeployService.oPEcFbEHOmiXeFTUix9x((object) manifest), AutoDeployService.I5GCs4EH2NX4MsLi0ifu((object) manifest)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            Directory.CreateDirectory(path);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 2 : 2;
            continue;
          default:
            if (!AutoDeployService.NW3HeNEHXbyNJ1Ku4KHP((object) path))
            {
              num = 3;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return path;
    }

    /// <inheritdoc />
    public void RunAutoDeploy()
    {
      int num = 2;
      string autoDeployPath;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RunAutoDeploy(autoDeployPath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 2:
            autoDeployPath = this.DefaultAutoDeployPath();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <inheritdoc />
    public void RunAutoDeploy(string autoDeployPath)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNullOrEmpty(autoDeployPath, (string) AutoDeployService.NOqQvoEHqpypsttIQ10j(372753449 ^ 372460143));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.RunDeploy(autoDeployPath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public IEnumerable<IDeployResult> RunAutoDeployWithResult(string autoDeployPath)
    {
      Contract.ArgumentNotNullOrEmpty(autoDeployPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575919646));
      return this.RunDeploy(autoDeployPath);
    }

    private IEnumerable<IDeployResult> RunDeploy(string autoDeployPath)
    {
      AutoDeployService.DeployLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978245484));
      List<IDeployResult> results = new List<IDeployResult>();
      try
      {
        ICollection<IDeployResult> moduleDeployResults;
        List<AutoDeployService.ManifestList> source = this.BuildTree(autoDeployPath, out moduleDeployResults);
        results.AddRange((IEnumerable<IDeployResult>) moduleDeployResults);
        // ISSUE: reference to a compiler-generated method
        List<AutoDeployService.ManifestList> designerItems = source.Where<AutoDeployService.ManifestList>((Func<AutoDeployService.ManifestList, bool>) (manifestList => manifestList.All.Any<AutoDeployService.ManifestItem>((Func<AutoDeployService.ManifestItem, bool>) (item => (string) AutoDeployService.\u003C\u003Ec.cObD3i8Nx0qPLVnFK04G((object) item) == ModuleMetadataItemHeaderManager.WebDesignerPackageName)))).ToList<AutoDeployService.ManifestList>();
        source.Where<AutoDeployService.ManifestList>((Func<AutoDeployService.ManifestList, bool>) (manifestList => !designerItems.Contains(manifestList))).GroupBy<AutoDeployService.ManifestList, string>((Func<AutoDeployService.ManifestList, string>) (t => t.DeployDirectory)).Where<IGrouping<string, AutoDeployService.ManifestList>>((Func<IGrouping<string, AutoDeployService.ManifestList>, bool>) (group => group != null && group.Any<AutoDeployService.ManifestList>() && !string.IsNullOrEmpty(group.Key))).ForEach<IGrouping<string, AutoDeployService.ManifestList>>((Action<IGrouping<string, AutoDeployService.ManifestList>>) (group =>
        {
          AutoDeployService.ManifestDeployLogger localDeployLog = new AutoDeployService.ManifestDeployLogger(group.Key);
          try
          {
            group.ForEach<AutoDeployService.ManifestList>((Action<AutoDeployService.ManifestList>) (manifest =>
            {
              int num = 6;
              List<AutoDeployService.ManifestItem> sortedManifestList;
              while (true)
              {
                switch (num)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    AutoDeployService.\u003C\u003Ec__DisplayClass24_2.Xug4xy8N4T0K8gErTfD0((object) localDeployLog, AutoDeployService.\u003C\u003Ec__DisplayClass24_2.dMK3y08NwkWLBt7Gkck9(132912447 ^ 132769723), EleWise.ELMA.Logging.LogLevel.Information);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 4;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    AutoDeployService.\u003C\u003Ec__DisplayClass24_2.Xug4xy8N4T0K8gErTfD0((object) localDeployLog, AutoDeployService.\u003C\u003Ec__DisplayClass24_2.dMK3y08NwkWLBt7Gkck9(-1088304168 ^ -1088145120), EleWise.ELMA.Logging.LogLevel.Information);
                    num = 3;
                    continue;
                  case 3:
                    this.RunImport(sortedManifestList, localDeployLog);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 7 : 3;
                    continue;
                  case 4:
                    sortedManifestList = this.GetSortedManifestList((IEnumerable<AutoDeployService.ManifestItem>) manifest.All);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 2;
                    continue;
                  case 5:
                    this.CutTree(manifest, localDeployLog);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
                    continue;
                  case 6:
                    // ISSUE: reference to a compiler-generated method
                    localDeployLog.InnerLog((string) AutoDeployService.\u003C\u003Ec__DisplayClass24_2.dMK3y08NwkWLBt7Gkck9(1232639661 >> 3 ^ 153805037), EleWise.ELMA.Logging.LogLevel.Information);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 5 : 2;
                    continue;
                  case 7:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    AutoDeployService.\u003C\u003Ec__DisplayClass24_2.Xug4xy8N4T0K8gErTfD0((object) localDeployLog, AutoDeployService.\u003C\u003Ec__DisplayClass24_2.dMK3y08NwkWLBt7Gkck9(1597012150 ^ 1597344646), EleWise.ELMA.Logging.LogLevel.Information);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_10;
                }
              }
label_2:
              return;
label_10:;
            }));
          }
          finally
          {
            localDeployLog.CompleteDeploy();
            results.Add((IDeployResult) new AutoDeployService.StandardAutoDeployResult(localDeployLog.HasErrors, localDeployLog.LogPath));
          }
        }));
        if (designerItems.Count != 0)
          ThreadStarter.StartNewThread((ThreadStart) (() =>
          {
            int num1 = 1;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_4;
                case 1:
                  List<AutoDeployService.ManifestList> manifestListList = designerItems;
                  Action<AutoDeployService.ManifestList> action1 = closure_0;
                  Action<AutoDeployService.ManifestList> action2 = action1 == null ? (closure_0 = (Action<AutoDeployService.ManifestList>) (designerItem =>
                  {
                    int num2 = 1;
                    AutoDeployService.ManifestItem manifestItem;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          manifestItem = designerItem.All.First<AutoDeployService.ManifestItem>();
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                          continue;
                        case 2:
                          goto label_2;
                        default:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          this.InstallModule((string) AutoDeployService.\u003C\u003Ec__DisplayClass24_0.vWnDlB8N2e1GLquvk1ZU((object) manifestItem), (string) AutoDeployService.\u003C\u003Ec__DisplayClass24_0.gjfJ8r8NeiFfHdCOQaOQ((object) designerItem));
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 2;
                          continue;
                      }
                    }
label_2:;
                  })) : action1;
                  manifestListList.ForEach(action2);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_2;
              }
            }
label_4:
            return;
label_2:;
          }));
      }
      catch (Exception ex)
      {
        AutoDeployService.DeployLog.Error((object) ex);
        results.Add((IDeployResult) new AutoDeployService.ExceptionAutoDeployResult(ex));
      }
      AutoDeployService.DeployLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917029378));
      return (IEnumerable<IDeployResult>) results;
    }

    /// <summary>Запустить авторазвертывание для выбраных компонентов</summary>
    private void RunImport(
      List<AutoDeployService.ManifestItem> manifests,
      AutoDeployService.ManifestDeployLogger localDeployLog)
    {
      if (manifests == null || manifests.Count == 0)
        return;
      ModuleManager moduleManager = ComponentManager.Current.ModuleManager as ModuleManager;
      if (moduleManager == null)
      {
        localDeployLog.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335291229));
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        List<ModuleManager.StoreComponentConfigurationInfo> componentsInfo = moduleManager.GetInstalledComponentInfos().Where<ModuleManager.StoreComponentConfigurationInfo>((Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i => AutoDeployService.\u003C\u003Ec.wFhLHD8N0fDYIs2ESyKZ((object) i) != null)).ToList<ModuleManager.StoreComponentConfigurationInfo>();
        List<ModuleManager.StoreComponentConfigurationInfo> list = componentsInfo.Where<ModuleManager.StoreComponentConfigurationInfo>((Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i =>
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (AutoDeployService.\u003C\u003Ec.QRhN0d8NmBPvLJ1bGGeo((object) i) != AutoDeployComponentStatus.Step1)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (AutoDeployService.\u003C\u003Ec.QRhN0d8NmBPvLJ1bGGeo((object) i) != AutoDeployComponentStatus.Step0)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                  continue;
                }
                goto label_5;
              default:
                goto label_4;
            }
          }
label_4:
          return i.DeployStatus == AutoDeployComponentStatus.Step2;
label_5:
          return true;
        })).ToList<ModuleManager.StoreComponentConfigurationInfo>();
        if (list.Count<ModuleManager.StoreComponentConfigurationInfo>() > 1)
        {
          localDeployLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283152385));
          list.ForEach((Action<ModuleManager.StoreComponentConfigurationInfo>) (i =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  AutoDeployService.\u003C\u003Ec__DisplayClass25_0.c8WARi83FloG4crGqeVA((object) moduleManager, (object) i, AutoDeployComponentStatus.Failed);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          list.RemoveAll((Predicate<ModuleManager.StoreComponentConfigurationInfo>) (i => true));
        }
        ModuleManager.StoreComponentConfigurationInfo componentInStep = list.FirstOrDefault<ModuleManager.StoreComponentConfigurationInfo>();
        bool flag = componentInStep != null;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (componentInStep != null && manifests.All<AutoDeployService.ManifestItem>((Func<AutoDeployService.ManifestItem, bool>) (ad => AutoDeployService.\u003C\u003Ec__DisplayClass25_0.F08rt283of9al6s8e6GN(AutoDeployService.\u003C\u003Ec__DisplayClass25_0.WInWMM83BumMFntwBWfp((object) ad), AutoDeployService.\u003C\u003Ec__DisplayClass25_0.zitm3k83WV9xdt9M4WK3((object) componentInStep)))))
        {
          localDeployLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822660350));
          moduleManager.UpdateAutoDeployComponentInfo(componentInStep, AutoDeployComponentStatus.Failed);
          flag = false;
        }
        if (!flag)
        {
          List<AutoDeployService.ManifestItem> removeList1 = new List<AutoDeployService.ManifestItem>();
          manifests.ForEach((Action<AutoDeployService.ManifestItem>) (ad =>
          {
            int num1 = 3;
            AutoDeployService.ManifestItem ad1;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_8;
                case 1:
                  if (!componentsInfo.Any<ModuleManager.StoreComponentConfigurationInfo>((Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i =>
                  {
                    int num2 = 1;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (AutoDeployService.\u003C\u003Ec__DisplayClass25_2.eOcqSD83SuXinByhZaaf(AutoDeployService.\u003C\u003Ec__DisplayClass25_2.QE5dFr83IeBsn4Mp08fB((object) i), AutoDeployService.\u003C\u003Ec__DisplayClass25_2.Y1FV4383VClWOuxWdZWA((object) ad1)))
                          {
                            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_5;
                        default:
                          goto label_4;
                      }
                    }
label_4:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    return AutoDeployService.\u003C\u003Ec__DisplayClass25_2.yxR7aD83KsR7O60ZiLxq(AutoDeployService.\u003C\u003Ec__DisplayClass25_2.VCRTOf83icJZoswe2AR8((object) ad1), AutoDeployService.\u003C\u003Ec__DisplayClass25_2.qyMGc083qi20Si4sVk1T(AutoDeployService.\u003C\u003Ec__DisplayClass25_2.HSo3av83ROJDXClAeF7N((object) i)));
label_5:
                    return false;
                  })))
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                    continue;
                  }
                  goto case 5;
                case 2:
                  ad1 = ad;
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
                  continue;
                case 3:
                  num1 = 2;
                  continue;
                case 4:
                  goto label_2;
                case 5:
                  removeList1.Add(ad1);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 4 : 4;
                  continue;
                default:
                  goto label_9;
              }
            }
label_8:
            return;
label_2:
            return;
label_9:;
          }));
          removeList1.ForEach((Action<AutoDeployService.ManifestItem>) (r =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  manifests.Remove(r);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          if (manifests.Count == 0)
            return;
          List<AutoDeployService.ManifestItem> removeList2 = new List<AutoDeployService.ManifestItem>();
          manifests.ForEach((Action<AutoDeployService.ManifestItem>) (ad =>
          {
            int num3 = 3;
            AutoDeployService.ManifestItem ad2;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  goto label_7;
                case 2:
                  ad2 = ad;
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                  continue;
                case 3:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 0;
                  continue;
                case 4:
                  removeList2.Add(ad2);
                  num3 = 5;
                  continue;
                case 5:
                  goto label_2;
                default:
                  if (!componentsInfo.Any<ModuleManager.StoreComponentConfigurationInfo>((Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i =>
                  {
                    int num4 = 1;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (!((string) AutoDeployService.\u003C\u003Ec__DisplayClass25_4.oyQ2U783P1xj0clLis8w((object) i) == (string) AutoDeployService.\u003C\u003Ec__DisplayClass25_4.m6HYbJ8318mgNSmfsvec((object) ad2)))
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                            continue;
                          }
                          goto case 3;
                        case 2:
                          goto label_4;
                        case 3:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (!AutoDeployService.\u003C\u003Ec__DisplayClass25_4.vrriO883pVGd5Klqs2wO((object) ad2.Version, AutoDeployService.\u003C\u003Ec__DisplayClass25_4.qVfXBh833I3ej7DGIvRh(AutoDeployService.\u003C\u003Ec__DisplayClass25_4.n6QFDr83NgReuqsvh3pb((object) i))))
                          {
                            num4 = 4;
                            continue;
                          }
                          goto case 5;
                        case 5:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (AutoDeployService.\u003C\u003Ec__DisplayClass25_4.ILq4Hx83tmlAKpyCgDrf(AutoDeployService.\u003C\u003Ec__DisplayClass25_4.GJZrdk83awoPec0WuvDY((object) ad2), AutoDeployService.\u003C\u003Ec__DisplayClass25_4.qQuvB083D5qx5rED7N1V((object) i)))
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 1;
                            continue;
                          }
                          goto label_5;
                        default:
                          goto label_5;
                      }
                    }
label_4:
                    // ISSUE: reference to a compiler-generated method
                    return AutoDeployService.\u003C\u003Ec__DisplayClass25_4.BcmsKm83wP4D2I1aOcqE((object) i) == AutoDeployComponentStatus.Failed;
label_5:
                    return false;
                  })))
                  {
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
                    continue;
                  }
                  goto case 4;
              }
            }
label_7:
            return;
label_2:;
          }));
          removeList2.ForEach((Action<AutoDeployService.ManifestItem>) (r =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  manifests.Remove(r);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          if (manifests.Count == 0)
            return;
          AutoDeployService.ManifestItem manifestItem = manifests.FirstOrDefault<AutoDeployService.ManifestItem>();
          if (manifestItem == null)
            return;
          ElmaStoreComponentManifest adManifest = manifestItem.Manifest;
          // ISSUE: reference to a compiler-generated method
          ModuleManager.StoreComponentConfigurationInfo configurationInfo = componentsInfo.FirstOrDefault<ModuleManager.StoreComponentConfigurationInfo>((Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i => AutoDeployService.\u003C\u003Ec__DisplayClass25_5.BJL6aN837WDRXFFdq55P((object) i.Id, (object) adManifest.Id)));
          if (configurationInfo == null)
            configurationInfo = new ModuleManager.StoreComponentConfigurationInfo((IModuleManager) moduleManager)
            {
              Id = adManifest.Id,
              Title = adManifest.Title,
              Status = StoreComponentStatus.Allowed,
              SemanticDeployVersion = adManifest.SemanticVersion,
              Manifest = adManifest
            };
          ModuleManager.StoreComponentConfigurationInfo info = configurationInfo;
          ConfigImportSettings importSettings = this.NewConfigImportSettings();
          this.UploadFile(manifestItem.ElmaFile, importSettings);
          info.SemanticDeployVersion = adManifest.SemanticVersion;
          moduleManager.UpdateAutoDeployComponentInfo(info, adManifest.SemanticVersion);
          List<TestImportMessages> source = this.TestConfiguration(importSettings);
          if (source.Any<TestImportMessages>((Func<TestImportMessages, bool>) (m =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  if (AutoDeployService.\u003C\u003Ec.EZmjoX8NyahWvoNrTGCK((object) m) != TestImportMessagesType.Error)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_3;
                default:
                  goto label_2;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            return AutoDeployService.\u003C\u003Ec.EZmjoX8NyahWvoNrTGCK((object) m) == TestImportMessagesType.Warning;
label_3:
            return true;
          })))
          {
            localDeployLog.Info((object) (adManifest.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1596993940) + adManifest.Version + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112472302)));
            source.Where<TestImportMessages>((Func<TestImportMessages, bool>) (m =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (AutoDeployService.\u003C\u003Ec.EZmjoX8NyahWvoNrTGCK((object) m) != TestImportMessagesType.Error)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              return AutoDeployService.\u003C\u003Ec.EZmjoX8NyahWvoNrTGCK((object) m) == TestImportMessagesType.Warning;
label_5:
              return true;
            })).ForEach<TestImportMessages>((Action<TestImportMessages>) (m =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    AutoDeployService.\u003C\u003Ec__DisplayClass25_0.xpKhom83hag7EI90TixH((object) localDeployLog, AutoDeployService.\u003C\u003Ec__DisplayClass25_0.YJfDUp83bsplWYkjl9lA((object) m));
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            moduleManager.UpdateAutoDeployComponentInfo(info, AutoDeployComponentStatus.Failed, adManifest.SemanticVersion);
            manifests.Remove(manifestItem);
            this.RunImport(manifests, localDeployLog);
          }
          else
            this.RunImportStep0(importSettings, info, localDeployLog);
          manifests.Remove(manifestItem);
          if (!manifests.Any<AutoDeployService.ManifestItem>())
            return;
          this.RunImport(manifests, localDeployLog);
        }
        else
        {
          localDeployLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766083958));
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          AutoDeployService.ManifestItem manifestItem = manifests.First<AutoDeployService.ManifestItem>((Func<AutoDeployService.ManifestItem, bool>) (ad => AutoDeployService.\u003C\u003Ec__DisplayClass25_0.JVhNyF83GCNp5hpKrmOR(AutoDeployService.\u003C\u003Ec__DisplayClass25_0.WInWMM83BumMFntwBWfp((object) ad), AutoDeployService.\u003C\u003Ec__DisplayClass25_0.zitm3k83WV9xdt9M4WK3((object) componentInStep))));
          ElmaStoreComponentManifest manifest = manifestItem.Manifest;
          ModuleManager.StoreComponentConfigurationInfo info = componentInStep;
          if (manifest.SemanticVersion > info.SemanticDeployVersion)
          {
            localDeployLog.Info((object) (manifest.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813618931) + manifest.Version + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322792426)));
            moduleManager.UpdateAutoDeployComponentInfo(info, AutoDeployComponentStatus.Step0, manifest.SemanticVersion);
          }
          if (manifest.SemanticVersion > info.SemanticDeployVersion)
          {
            localDeployLog.Info((object) (manifest.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852851418) + manifest.Version + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -69746214)));
            moduleManager.UpdateAutoDeployComponentInfo(info, AutoDeployComponentStatus.Failed, manifest.SemanticVersion);
            manifests.Remove(manifestItem);
            this.RunImport(manifests, localDeployLog);
          }
          ConfigImportSettings importSettings = this.NewConfigImportSettings();
          this.UploadFile(manifestItem.ElmaFile, importSettings);
          switch (componentInStep.DeployStatus)
          {
            case AutoDeployComponentStatus.Step0:
              this.RunImportStep0(importSettings, info, localDeployLog);
              break;
            case AutoDeployComponentStatus.Step1:
              this.RunImportStep1(importSettings, info, false, localDeployLog);
              break;
            case AutoDeployComponentStatus.Step2:
              this.RunImportStep2(importSettings, info, false, localDeployLog);
              manifests.Remove(manifestItem);
              this.RunImport(manifests, localDeployLog);
              break;
          }
        }
      }
    }

    /// <summary>
    /// Удаление из дерева компонентов те комплексные bpmapp'ы, у которых не осталось вложеных
    /// </summary>
    private void RemoveEmptyComplexBpmApp(
      AutoDeployService.ManifestList manifestList,
      AutoDeployService.ManifestDeployLogger localDeployLog)
    {
      int num1 = 1;
      AutoDeployService.ManifestDeployLogger localDeployLog1;
      AutoDeployService.ManifestList manifestList1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 2:
            int num2;
            int num3;
            do
            {
              num2 = manifestList1.All.Count<AutoDeployService.ManifestItem>();
              List<AutoDeployService.ManifestItem> all = manifestList1.All;
              // ISSUE: reference to a compiler-generated field
              Func<AutoDeployService.ManifestItem, bool> func = AutoDeployService.\u003C\u003Ec.\u003C\u003E9__26_0;
              Func<AutoDeployService.ManifestItem, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                AutoDeployService.\u003C\u003Ec.\u003C\u003E9__26_0 = predicate = (Func<AutoDeployService.ManifestItem, bool>) (i =>
                {
                  int num4 = 2;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                      case 3:
                        goto label_7;
                      case 2:
                        if (i.Manifest.BpmApps == null)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
                          continue;
                        }
                        break;
                      case 4:
                        goto label_6;
                    }
                    // ISSUE: reference to a compiler-generated method
                    if (AutoDeployService.\u003C\u003Ec.KfxWUO8NMHvIUrIjweFS((object) i.Manifest.BpmApps) <= 0)
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 3;
                    else
                      break;
                  }
label_6:
                  // ISSUE: reference to a compiler-generated method
                  return AutoDeployService.\u003C\u003Ec.pB7m3Z8NJq9RwGgCsVYW((object) i.Childs) == 0;
label_7:
                  return false;
                });
              }
              else
                goto label_12;
label_7:
              List<AutoDeployService.ManifestItem> list = all.Where<AutoDeployService.ManifestItem>(predicate).ToList<AutoDeployService.ManifestItem>();
              if (list != null)
                list.Distinct<AutoDeployService.ManifestItem>().ForEach<AutoDeployService.ManifestItem>((Action<AutoDeployService.ManifestItem>) (mi =>
                {
                  int num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        AutoDeployService.\u003C\u003Ec__DisplayClass26_0.CsKJsn83dotFVvdmN3kh((object) localDeployLog1, AutoDeployService.\u003C\u003Ec__DisplayClass26_0.SNlsJS839Pe5mTKXU8M1(AutoDeployService.\u003C\u003Ec__DisplayClass26_0.xFFBql83yLCFfVbdUe4c(874012245 ^ 874360065), AutoDeployService.\u003C\u003Ec__DisplayClass26_0.W8NoHp83MmBTw0IjiXpW((object) mi), AutoDeployService.\u003C\u003Ec__DisplayClass26_0.udTdpo83JOHBoQj6OkGm((object) mi)));
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_2;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        AutoDeployService.\u003C\u003Ec__DisplayClass26_0.DptfGj83lP8TA9ysTZvu((object) manifestList1, (object) mi);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 2;
                        continue;
                    }
                  }
label_2:;
                }));
              num3 = manifestList1.All.Count<AutoDeployService.ManifestItem>();
              continue;
label_12:
              predicate = func;
              goto label_7;
            }
            while (num2 != num3);
            num1 = 3;
            continue;
          case 3:
            goto label_8;
          case 4:
            manifestList1 = manifestList;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 2;
            continue;
          default:
            localDeployLog1 = localDeployLog;
            num1 = 4;
            continue;
        }
      }
label_8:;
    }

    /// <summary>Обрезки дерева по зависимостям и версиям</summary>
    /// <param name="manifestList"></param>
    /// <param name="localDeployLog">Сборщик информации о деплое</param>
    private void CutTree(
      AutoDeployService.ManifestList manifestList,
      AutoDeployService.ManifestDeployLogger localDeployLog)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        int num3;
        Dictionary<ElmaStoreComponentManifest, bool> dictionary;
        List<string> errors1;
        List<string> warnings;
        List<ElmaStoreComponentManifest> incompatible1;
        List<ElmaStoreComponentManifest>.Enumerator enumerator;
        List<ElmaStoreComponentManifest> list1;
        int num4;
        AutoDeployService.ManifestDeployLogger localDeployLog1;
        AutoDeployService.ManifestList manifestList1;
        List<AutoDeployService.ManifestItem> incompatible;
        List<ElmaStoreComponentManifest> componentsToInstall;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            case 2:
              if (incompatible1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 7 : 2;
                continue;
              }
              goto case 22;
            case 3:
              incompatible = new List<AutoDeployService.ManifestItem>();
              num2 = 13;
              continue;
            case 4:
              this.RemoveEmptyComplexBpmApp(manifestList1, localDeployLog1);
              num2 = 6;
              continue;
            case 5:
label_5:
              ManifestValidationHelper.Check(dictionary, out errors1, out warnings, out incompatible1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 2;
              continue;
            case 6:
              int num5;
              int num6;
              do
              {
                num5 = manifestList1.All.Count<AutoDeployService.ManifestItem>();
                List<AutoDeployService.ManifestItem> all = manifestList1.All;
                // ISSUE: reference to a compiler-generated field
                Func<AutoDeployService.ManifestItem, ElmaStoreComponentManifest> func = AutoDeployService.\u003C\u003Ec.\u003C\u003E9__27_6;
                Func<AutoDeployService.ManifestItem, ElmaStoreComponentManifest> selector;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  AutoDeployService.\u003C\u003Ec.\u003C\u003E9__27_6 = selector = (Func<AutoDeployService.ManifestItem, ElmaStoreComponentManifest>) (i => (ElmaStoreComponentManifest) AutoDeployService.\u003C\u003Ec.IRBpym8NdQqXDcD4ScPp((object) i));
                }
                else
                  goto label_50;
label_38:
                List<ElmaStoreComponentManifest> incompatible2;
                List<string> errors2;
                ManifestValidationHelper.CheckByDependencies(all.Select<AutoDeployService.ManifestItem, ElmaStoreComponentManifest>(selector).ToList<ElmaStoreComponentManifest>(), list1, out incompatible2, out errors2);
                if (incompatible2 != null)
                {
                  List<ElmaStoreComponentManifest> list2 = incompatible2.Distinct<ElmaStoreComponentManifest>().ToList<ElmaStoreComponentManifest>();
                  Action<ElmaStoreComponentManifest> action;
                  Action<ElmaStoreComponentManifest> action1 = action;
                  Action<ElmaStoreComponentManifest> action2 = action1 == null ? (action = (Action<ElmaStoreComponentManifest>) (mi =>
                  {
                    int num7 = 2;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          AutoDeployService.\u003C\u003Ec__DisplayClass27_0.hQfIqG8pFgR7fnxfMW4P((object) manifestList1, (object) mi);
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                          continue;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          AutoDeployService.\u003C\u003Ec__DisplayClass27_0.Tdooko83UYHLNvTc7Dfj((object) localDeployLog1, (object) EleWise.ELMA.SR.T((string) AutoDeployService.\u003C\u003Ec__DisplayClass27_0.B73LbJ83jJUdpd5VvrhR(-1638402543 ^ -1638792635), AutoDeployService.\u003C\u003Ec__DisplayClass27_0.L2bcOY83cXfkwv4sFp2E((object) mi), AutoDeployService.\u003C\u003Ec__DisplayClass27_0.C2GpKu83z7IS6ArHoAvo((object) mi)));
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
                          continue;
                        default:
                          goto label_5;
                      }
                    }
label_2:
                    return;
label_5:;
                  })) : action1;
                  list2.ForEach(action2);
                  AutoDeployService.l3eGbYEHP1DTHug84kr8((object) localDeployLog1, (object) string.Join(Environment.NewLine, (IEnumerable<string>) errors2));
                }
                num6 = manifestList1.All.Count<AutoDeployService.ManifestItem>();
                continue;
label_50:
                selector = func;
                goto label_38;
              }
              while (num5 != num6);
              num2 = 15;
              continue;
            case 7:
            case 12:
              if (num3 == manifestList1.All.Count<AutoDeployService.ManifestItem>())
              {
                num2 = 9;
                continue;
              }
              goto label_22;
            case 8:
              goto label_45;
            case 9:
              if (num4 == manifestList1.All.Count<AutoDeployService.ManifestItem>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 8 : 24;
                continue;
              }
              goto case 14;
            case 10:
              num3 = manifestList1.All.Count<AutoDeployService.ManifestItem>();
              num2 = 17;
              continue;
            case 11:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 3;
              continue;
            case 13:
              manifestList1.All.GroupBy<AutoDeployService.ManifestItem, string>((Func<AutoDeployService.ManifestItem, string>) (i => i.Id)).ForEach<IGrouping<string, AutoDeployService.ManifestItem>>((Action<IGrouping<string, AutoDeployService.ManifestItem>>) (mGroup =>
              {
                if (mGroup == null || mGroup.Count<AutoDeployService.ManifestItem>() <= 1)
                  return;
                // ISSUE: reference to a compiler-generated method
                SemanticVersion versionMax = mGroup.Max<AutoDeployService.ManifestItem, SemanticVersion>((Func<AutoDeployService.ManifestItem, SemanticVersion>) (g => (SemanticVersion) AutoDeployService.\u003C\u003Ec.HG56YA8N9fGAQRAa21pH((object) g)));
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                AutoDeployService.ManifestItem iMax = mGroup.FirstOrDefault<AutoDeployService.ManifestItem>((Func<AutoDeployService.ManifestItem, bool>) (g => AutoDeployService.\u003C\u003Ec__DisplayClass27_2.kh94jN8pQQF6qKQ5ovFT(AutoDeployService.\u003C\u003Ec__DisplayClass27_2.DI23sL8pfB7XmVdpLODk((object) g), (object) versionMax)));
                incompatible.AddRange(mGroup.Where<AutoDeployService.ManifestItem>((Func<AutoDeployService.ManifestItem, bool>) (g => g != iMax)));
              }));
              num2 = 18;
              continue;
            case 14:
              num4 = manifestList1.All.Count<AutoDeployService.ManifestItem>();
              num2 = 4;
              continue;
            case 15:
              goto label_21;
            case 16:
              list1 = Locator.GetServiceNotNull<IModuleDTOManager>().GetInstalledComponentManifests().ToList<ElmaStoreComponentManifest>();
              num2 = 11;
              continue;
            case 17:
              List<AutoDeployService.ManifestItem> all1 = manifestList1.All;
              // ISSUE: reference to a compiler-generated field
              Func<AutoDeployService.ManifestItem, ElmaStoreComponentManifest> func1 = AutoDeployService.\u003C\u003Ec.\u003C\u003E9__27_8;
              Func<AutoDeployService.ManifestItem, ElmaStoreComponentManifest> selector1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                AutoDeployService.\u003C\u003Ec.\u003C\u003E9__27_8 = selector1 = (Func<AutoDeployService.ManifestItem, ElmaStoreComponentManifest>) (i => (ElmaStoreComponentManifest) AutoDeployService.\u003C\u003Ec.IRBpym8NdQqXDcD4ScPp((object) i));
              }
              else
                goto label_52;
label_44:
              componentsToInstall = all1.Select<AutoDeployService.ManifestItem, ElmaStoreComponentManifest>(selector1).ToList<ElmaStoreComponentManifest>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 7 : 8;
              continue;
label_52:
              selector1 = func1;
              goto label_44;
            case 18:
              incompatible.Distinct<AutoDeployService.ManifestItem>().ToList<AutoDeployService.ManifestItem>().ForEach((Action<AutoDeployService.ManifestItem>) (mi =>
              {
                int num8 = 2;
                while (true)
                {
                  switch (num8)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      AutoDeployService.\u003C\u003Ec__DisplayClass27_0.CiPSVK83sGKe75ryv1vU((object) manifestList1, (object) mi);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      AutoDeployService.\u003C\u003Ec__DisplayClass27_0.Tdooko83UYHLNvTc7Dfj((object) localDeployLog1, (object) EleWise.ELMA.SR.T((string) AutoDeployService.\u003C\u003Ec__DisplayClass27_0.B73LbJ83jJUdpd5VvrhR(-1921202237 ^ -1921436671), AutoDeployService.\u003C\u003Ec__DisplayClass27_0.qivPI583YbyOcFZ3SIv2((object) mi), AutoDeployService.\u003C\u003Ec__DisplayClass27_0.aImfuR83LbKkF3WEbWQs((object) mi)));
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_5;
                  }
                }
label_2:
                return;
label_5:;
              }));
              num2 = 14;
              continue;
            case 19:
              manifestList1 = manifestList;
              num2 = 16;
              continue;
            case 20:
              enumerator = componentsToInstall.GetEnumerator();
              num2 = 23;
              continue;
            case 21:
              goto label_22;
            case 22:
              incompatible1.Distinct<ElmaStoreComponentManifest>().ToList<ElmaStoreComponentManifest>().ForEach((Action<ElmaStoreComponentManifest>) (mi =>
              {
                int num9 = 2;
                while (true)
                {
                  switch (num9)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      AutoDeployService.\u003C\u003Ec__DisplayClass27_0.hQfIqG8pFgR7fnxfMW4P((object) manifestList1, (object) mi);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      AutoDeployService.\u003C\u003Ec__DisplayClass27_0.Tdooko83UYHLNvTc7Dfj((object) localDeployLog1, (object) EleWise.ELMA.SR.T((string) AutoDeployService.\u003C\u003Ec__DisplayClass27_0.B73LbJ83jJUdpd5VvrhR(1597012150 ^ 1597344894), AutoDeployService.\u003C\u003Ec__DisplayClass27_0.L2bcOY83cXfkwv4sFp2E((object) mi), AutoDeployService.\u003C\u003Ec__DisplayClass27_0.C2GpKu83z7IS6ArHoAvo((object) mi)));
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_5;
                  }
                }
label_2:
                return;
label_5:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 19 : 25;
              continue;
            case 23:
              try
              {
label_10:
                if (enumerator.MoveNext())
                  goto label_8;
                else
                  goto label_11;
label_7:
                ElmaStoreComponentManifest current;
                int num10;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      dictionary.Add(current, false);
                      num10 = 2;
                      continue;
                    case 2:
                      goto label_10;
                    case 3:
                      goto label_5;
                    default:
                      goto label_8;
                  }
                }
label_8:
                current = enumerator.Current;
                num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                {
                  num10 = 1;
                  goto label_7;
                }
                else
                  goto label_7;
label_11:
                num10 = 3;
                goto label_7;
              }
              finally
              {
                enumerator.Dispose();
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                  num11 = 0;
                switch (num11)
                {
                  default:
                }
              }
            case 24:
              goto label_46;
            case 25:
              AutoDeployService.l3eGbYEHP1DTHug84kr8((object) localDeployLog1, (object) string.Join((string) AutoDeployService.aWVUCHEH1JrRmbJ8vw14(), errors1.Concat<string>((IEnumerable<string>) warnings)));
              num2 = 12;
              continue;
            default:
              localDeployLog1 = localDeployLog;
              num2 = 19;
              continue;
          }
        }
label_21:
        this.RemoveEmptyComplexBpmApp(manifestList1, localDeployLog1);
        num1 = 21;
        continue;
label_22:
        num1 = 10;
        continue;
label_45:
        IEnumerable<ElmaStoreComponentManifest> source = list1.Where<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, bool>) (c =>
        {
          int num12 = 1;
          ElmaStoreComponentManifest c1;
          while (true)
          {
            switch (num12)
            {
              case 1:
                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              default:
                c1 = c;
                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 2;
                continue;
            }
          }
label_3:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return !componentsToInstall.Any<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, bool>) (ci => AutoDeployService.\u003C\u003Ec__DisplayClass27_4.rMwV3L8pRfUZEcI7OQ3j(AutoDeployService.\u003C\u003Ec__DisplayClass27_4.XjNwsZ8piqyLM6O7esT1((object) ci), AutoDeployService.\u003C\u003Ec__DisplayClass27_4.XjNwsZ8piqyLM6O7esT1((object) c1))));
        })).Distinct<ElmaStoreComponentManifest>();
        // ISSUE: reference to a compiler-generated field
        Func<ElmaStoreComponentManifest, bool> func2 = AutoDeployService.\u003C\u003Ec.\u003C\u003E9__27_11;
        Func<ElmaStoreComponentManifest, bool> elementSelector;
        if (func2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          AutoDeployService.\u003C\u003Ec.\u003C\u003E9__27_11 = elementSelector = (Func<ElmaStoreComponentManifest, bool>) (c => true);
        }
        else
          goto label_51;
label_48:
        dictionary = source.ToDictionary<ElmaStoreComponentManifest, ElmaStoreComponentManifest, bool>((Func<ElmaStoreComponentManifest, ElmaStoreComponentManifest>) (c => c), elementSelector);
        num1 = 20;
        continue;
label_51:
        elementSelector = func2;
        goto label_48;
      }
label_46:;
    }

    /// <summary>
    /// Получение всех невалидированых автоустанавливаемых компонентов с учетом ограничений
    /// </summary>
    private List<AutoDeployService.ManifestList> BuildTree(
      string autoDeployPath,
      out ICollection<IDeployResult> moduleDeployResults)
    {
      ITagService serviceNotNull = Locator.GetServiceNotNull<ITagService>();
      moduleDeployResults = (ICollection<IDeployResult>) new List<IDeployResult>();
      Dictionary<AutoDeployFile, string> autoDeployFilesDict = new Dictionary<AutoDeployFile, string>();
      foreach (string str in ((IEnumerable<string>) AutoDeployService.AutoDeployMasks).SelectMany<string, string>((Func<string, IEnumerable<string>>) (mask => (IEnumerable<string>) Directory.GetFiles(autoDeployPath, mask))))
      {
        string deployFile = str;
        int num1 = 0;
        while (num1++ < 10)
        {
          try
          {
            List<AutoDeployFile> autoDeployFileList = XmlSerializer<List<AutoDeployFile>>.DeserializeFromFile(deployFile);
            if (autoDeployFileList != null)
            {
              autoDeployFileList.ForEach((Action<AutoDeployFile>) (adFile =>
              {
                int num3 = 2;
                AutoDeployFile adFile1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      adFile1 = adFile;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
                      continue;
                    case 3:
                      goto label_2;
                    case 4:
                      autoDeployFilesDict[adFile1] = this.GetModulePath(autoDeployPath, deployFile);
                      num3 = 3;
                      continue;
                    default:
                      if (!autoDeployFilesDict.Keys.Any<AutoDeployFile>((Func<AutoDeployFile, bool>) (adF =>
                      {
                        int num4 = 1;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              if (AutoDeployService.\u003C\u003Ec__DisplayClass28_2.RDFJDM8pNch69GNYsRAk(AutoDeployService.\u003C\u003Ec__DisplayClass28_2.l1hQx18p1XYZBMhwtuEM((object) adF), AutoDeployService.\u003C\u003Ec__DisplayClass28_2.l1hQx18p1XYZBMhwtuEM((object) adFile1)))
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
                                continue;
                              }
                              goto label_3;
                            default:
                              goto label_2;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        return AutoDeployService.\u003C\u003Ec__DisplayClass28_2.HNFMai8ppyHxfjEOaCC6((object) adF.SemanticVersion, AutoDeployService.\u003C\u003Ec__DisplayClass28_2.CAK34b8p3WDY29WN48uP((object) adFile1));
label_3:
                        return false;
                      })))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 3 : 4;
                        continue;
                      }
                      goto label_8;
                  }
                }
label_2:
                return;
label_8:;
              }));
              break;
            }
            break;
          }
          catch (IOException ex)
          {
            AutoDeployService.DeployLog.Warn((object) ex.Message);
            Thread.Sleep(300);
          }
          catch (Exception ex)
          {
            AutoDeployService.DeployLog.Error((object) ex);
            break;
          }
        }
      }
      List<AutoDeployService.ManifestList> manifestListList = new List<AutoDeployService.ManifestList>();
      List<string> elmaFiles = ((IEnumerable<string>) Directory.GetFiles(autoDeployPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112471180))).ToList<string>();
      ((IEnumerable<string>) ElmaStoreComponentFile.SupportedComponentMask).ForEach<string>((Action<string>) (mask =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              elmaFiles.AddRange((IEnumerable<string>) Directory.GetFiles(autoDeployPath, mask));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      foreach (string str1 in elmaFiles)
      {
        AutoDeployService.ManifestList manifests = new AutoDeployService.ManifestList();
        string manifestFile = Path.Combine(autoDeployPath, Path.ChangeExtension(Path.GetFileName(str1), z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272333167)));
        string str2 = ((IEnumerable<string>) new string[1]
        {
          manifestFile
        }).Union<string>(((IEnumerable<string>) ElmaStoreComponentFile.SupportedComponentExtension).Select<string, string>((Func<string, string>) (ext => Path.ChangeExtension(manifestFile, ext)))).FirstOrDefault<string>(new Func<string, bool>(File.Exists));
        ElmaStoreComponentManifest manifest = (ElmaStoreComponentManifest) null;
        if (string.IsNullOrEmpty(str2))
        {
          try
          {
            manifest = ElmaStoreComponentsBuilder.Read(str1);
            if (manifest != null)
              ManifestBuilder.SerializeByXmlToFile<ElmaStoreComponentManifest>((object) manifest, manifestFile);
          }
          catch (Exception ex)
          {
            AutoDeployService.DeployLog.Error((object) ex);
          }
        }
        else
        {
          try
          {
            manifest = ManifestBuilder.DeserializeByXml<ElmaStoreComponentManifest>(File.ReadAllText(manifestFile));
          }
          catch (Exception ex)
          {
            AutoDeployService.DeployLog.Error((object) ex);
          }
        }
        if (manifest != null)
        {
          AutoDeployFile key = autoDeployFilesDict.Keys.FirstOrDefault<AutoDeployFile>((Func<AutoDeployFile, bool>) (adF =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (AutoDeployService.\u003C\u003Ec__DisplayClass28_4.uPPlVn8p0hvHl6fxwUrB(AutoDeployService.\u003C\u003Ec__DisplayClass28_4.euCoxh8p762Walb1jT9k((object) adF), AutoDeployService.\u003C\u003Ec__DisplayClass28_4.wnalgw8pxFRwP5QLFaRT((object) manifest)))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_5;
                default:
                  goto label_4;
              }
            }
label_4:
            // ISSUE: reference to a compiler-generated method
            return (SemanticVersion) AutoDeployService.\u003C\u003Ec__DisplayClass28_4.jJEqJX8pmhbGdlPNdpBY((object) adF) == manifest.SemanticVersion;
label_5:
            return false;
          }));
          if (key != null && serviceNotNull.ValidateTags(manifest))
          {
            string str3 = autoDeployFilesDict[key];
            bool flag = manifest.Id != ModuleMetadataItemHeaderManager.WebDesignerPackageName;
            if (flag)
            {
              IDeployResult deployResult = this.InstallModule(str1, str3);
              if (deployResult != null)
              {
                moduleDeployResults.Add(deployResult);
                continue;
              }
            }
            AutoDeployService.ManifestItem parent = new AutoDeployService.ManifestItem()
            {
              ElmaFile = str1,
              ManifestFile = manifestFile,
              Manifest = manifest
            };
            manifests.DeployDirectory = str3;
            manifests.Add(parent, (AutoDeployService.ManifestItem) null);
            if (((manifest.BpmApps == null ? 0 : (manifest.BpmApps.Any<BpmAppManifest>() ? 1 : 0)) & (flag ? 1 : 0)) != 0)
              this.ExtractComplexBpmApp(parent, manifests, 0, this.DefaultSubmodulesPath(str3));
            manifestListList.Add(manifests);
          }
        }
      }
      return manifestListList;
    }

    private IDeployResult InstallModule(string componentPath, string deployFileDir)
    {
      int num1 = 4;
      IDeployResult deployResult;
      AutoDeployService.ManifestDeployLogger localDeployLogger;
      while (true)
      {
        int num2 = num1;
        IModuleFileDeployService moduleFileDeployService;
        string componentPath1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_19;
            case 2:
              moduleFileDeployService = Locator.GetServiceNotNull<IModuleFileDeployService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
              continue;
            case 3:
              componentPath1 = componentPath;
              num2 = 2;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 3;
              continue;
            case 5:
label_5:
              AutoDeployService.zTFFxPEHNLZQw4YKiTA8((object) localDeployLogger);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            case 6:
              try
              {
                Locator.GetServiceNotNull<ISecurityService>().RunBySystemUser((System.Action) (() =>
                {
                  int num3 = 1;
                  TaskAwaiter taskAwaiter;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        taskAwaiter = AutoDeployService.\u003C\u003Ec__DisplayClass29_0.eNtdAt8p99RVkuGoHF8v((object) moduleFileDeployService.Deploy(new BinaryFile(componentPath1), (EleWise.ELMA.Logging.ILogger) localDeployLogger));
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_2;
                      default:
                        taskAwaiter.GetResult();
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 1;
                        continue;
                    }
                  }
label_2:;
                }));
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    goto label_5;
                }
              }
              catch (ModuleValidationException ex)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      deployResult = (IDeployResult) null;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_8;
                  }
                }
              }
              catch (Exception ex)
              {
                AutoDeployService.zTFFxPEHNLZQw4YKiTA8((object) localDeployLogger);
                deployResult = (IDeployResult) new AutoDeployService.ExceptionAutoDeployResult(ex);
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_8;
                }
              }
            default:
              goto label_7;
          }
        }
label_19:
        localDeployLogger = new AutoDeployService.ManifestDeployLogger(deployFileDir);
        num1 = 6;
      }
label_7:
      return (IDeployResult) new AutoDeployService.StandardAutoDeployResult(localDeployLogger.HasErrors, (string) AutoDeployService.KHq1BEEH3SVlp8VHoye5((object) localDeployLogger));
label_8:
      return deployResult;
    }

    private void ExtractComplexBpmApp(
      AutoDeployService.ManifestItem parent,
      AutoDeployService.ManifestList manifests,
      int level,
      string submodulesPath)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        List<AutoDeployService.ManifestItem> source;
        int num3;
        ITagService serviceNotNull;
        AutoDeployService autoDeployService;
        AutoDeployService.ManifestList manifests1;
        int level1;
        string submodulesPath1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              submodulesPath1 = submodulesPath;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 12 : 9;
              continue;
            case 2:
              source.ForEach((Action<AutoDeployService.ManifestItem>) (manifestItem =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      autoDeployService.ExtractComplexBpmApp(manifestItem, manifests1, level1, autoDeployService.GetSubmodulePath(submodulesPath1, manifestItem));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 7 : 1;
              continue;
            case 3:
              level1 = level;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
              continue;
            case 4:
              if (level1 > 100)
              {
                num2 = 6;
                continue;
              }
              source = new List<AutoDeployService.ManifestItem>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 9 : 14;
              continue;
            case 5:
label_3:
              if (!source.Any<AutoDeployService.ManifestItem>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 8 : 5;
                continue;
              }
              goto case 2;
            case 6:
              goto label_10;
            case 7:
              goto label_73;
            case 8:
              goto label_71;
            case 9:
              autoDeployService = this;
              num2 = 13;
              continue;
            case 10:
              goto label_8;
            case 11:
              level1 = num3 + 1;
              num2 = 4;
              continue;
            case 12:
              num3 = level1;
              num2 = 11;
              continue;
            case 13:
              manifests1 = manifests;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 3 : 0;
              continue;
            case 14:
              serviceNotNull = Locator.GetServiceNotNull<ITagService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            default:
              try
              {
                ZipFile zipFile = new ZipFile((FileStream) AutoDeployService.EgCQnbEHaBLQNeA5O7kD((object) parent.ElmaFile));
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                  num5 = 0;
                IEnumerator enumerator;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_21;
                    case 2:
                      goto label_3;
                    default:
                      enumerator = zipFile.GetEnumerator();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
                      continue;
                  }
                }
label_21:
                try
                {
label_29:
                  if (AutoDeployService.WjTNqFEHmyuN4l9PdKJN((object) enumerator))
                    goto label_28;
                  else
                    goto label_30;
label_22:
                  int num6;
                  int num7 = num6;
label_23:
                  ZipEntry current;
                  ElmaStoreComponentManifest manifest;
                  string elmaFile;
                  Stream packageStream;
                  byte[] buffer;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        if (AutoDeployService.RwWhQgEHtqd4bO8LLo0p((object) current) != null)
                          goto case 6;
                        else
                          goto label_57;
                      case 2:
                        if (AutoDeployService.el39dPEHDAcwTC17mG5u((object) current))
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
                          continue;
                        }
                        goto label_29;
                      case 3:
                        num7 = 2;
                        continue;
                      case 4:
                        goto label_3;
                      case 5:
                        buffer = new byte[4096];
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 9;
                        continue;
                      case 6:
                        if (AutoDeployService.dgvyvNEHwRjMh09Anw8G((object) current.Name, AutoDeployService.NOqQvoEHqpypsttIQ10j(-1867198571 ^ -1867489361)))
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 4 : 15;
                          continue;
                        }
                        goto label_29;
                      case 7:
                        goto label_29;
                      case 8:
                        goto label_28;
                      case 9:
                        AutoDeployService.kQxNmfEH6xGgXBIqWvGO((object) elmaFile, (object) (System.Action) (() =>
                        {
                          int num8 = 1;
                          FileStream fileStream;
                          while (true)
                          {
                            switch (num8)
                            {
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                fileStream = (FileStream) AutoDeployService.\u003C\u003Ec__DisplayClass30_1.tvQVFH8pUh93hpNktiMq((object) elmaFile);
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                                continue;
                              case 2:
                                goto label_11;
                              default:
                                goto label_2;
                            }
                          }
label_11:
                          return;
label_2:
                          try
                          {
                            // ISSUE: reference to a compiler-generated method
                            AutoDeployService.\u003C\u003Ec__DisplayClass30_1.N6tD6D8pskPw3Yc9rXea((object) packageStream, (object) fileStream, (object) buffer);
                            int num9 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
                              num9 = 0;
                            switch (num9)
                            {
                            }
                          }
                          finally
                          {
                            int num10;
                            if (fileStream == null)
                              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 2;
                            else
                              goto label_12;
label_9:
                            switch (num10)
                            {
                              case 1:
                                break;
                              default:
                            }
label_12:
                            // ISSUE: reference to a compiler-generated method
                            AutoDeployService.\u003C\u003Ec__DisplayClass30_1.HwAjlZ8pcPFYxPW6MedC((object) fileStream);
                            num10 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                            {
                              num10 = 0;
                              goto label_9;
                            }
                            else
                              goto label_9;
                          }
                        }));
                        num7 = 14;
                        continue;
                      case 10:
                        if (manifest != null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 13 : 0;
                          continue;
                        }
                        goto label_29;
                      case 11:
                      case 15:
                        packageStream = (Stream) AutoDeployService.XXqqjREH4Pd3I6vEX0vH((object) zipFile, (object) current);
                        num7 = 12;
                        continue;
                      case 12:
                        elmaFile = (string) AutoDeployService.PKUS72EHKKn6swMQ9jxy((object) submodulesPath1, (object) Path.GetFileName((string) AutoDeployService.RwWhQgEHtqd4bO8LLo0p((object) current)));
                        num7 = 5;
                        continue;
                      case 13:
                        goto label_35;
                      case 14:
                        if (AutoDeployService.pv8nP9EHHR977VViicvI((object) elmaFile))
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_29;
                      default:
                        manifest = ElmaStoreComponentsBuilder.Read(elmaFile);
                        num7 = 10;
                        continue;
                    }
                  }
label_35:
                  try
                  {
                    int num11;
                    if (!serviceNotNull.ValidateTags(manifest))
                      num11 = 2;
                    else
                      goto label_41;
label_37:
                    string fileName;
                    AutoDeployService.ManifestItem manifestItem1;
                    while (true)
                    {
                      switch (num11)
                      {
                        case 1:
                          if (manifest.BpmApps.Any<BpmAppManifest>())
                          {
                            num11 = 8;
                            continue;
                          }
                          goto label_29;
                        case 2:
                        case 6:
                          goto label_29;
                        case 3:
                          ManifestBuilder.SerializeByXmlToFile<ElmaStoreComponentManifest>((object) manifest, fileName);
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 3 : 7;
                          continue;
                        case 4:
                          goto label_41;
                        case 5:
                          manifests1.Add(manifestItem1, parent);
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                          continue;
                        case 7:
                          AutoDeployService.ManifestItem manifestItem2 = new AutoDeployService.ManifestItem();
                          AutoDeployService.OfJearEHAAdIBdNrOlXl((object) manifestItem2, (object) elmaFile);
                          AutoDeployService.S5bYQREH7cN23w1tnCca((object) manifestItem2, (object) fileName);
                          AutoDeployService.gV1OoCEHxmRhFhdytSU3((object) manifestItem2, (object) manifest);
                          manifestItem1 = manifestItem2;
                          num11 = 5;
                          continue;
                        case 8:
                          source.Add(manifestItem1);
                          num11 = 6;
                          continue;
                        default:
                          if (manifest.BpmApps != null)
                          {
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
                            continue;
                          }
                          goto label_29;
                      }
                    }
label_41:
                    fileName = Path.ChangeExtension(elmaFile, (string) AutoDeployService.NOqQvoEHqpypsttIQ10j(1925118608 << 2 ^ -889226662));
                    num11 = 3;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
                    {
                      num11 = 2;
                      goto label_37;
                    }
                    else
                      goto label_37;
                  }
                  catch (Exception ex)
                  {
                    int num12 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                      num12 = 1;
                    while (true)
                    {
                      switch (num12)
                      {
                        case 1:
                          AutoDeployService.nMJMoUEH0eDCbhCnTPxp((object) AutoDeployService.DeployLog, (object) ex);
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_29;
                      }
                    }
                  }
label_57:
                  num6 = 11;
                  goto label_22;
label_28:
                  current = (ZipEntry) enumerator.Current;
                  num6 = 3;
                  goto label_22;
label_30:
                  num7 = 4;
                  goto label_23;
                }
                finally
                {
                  IDisposable disposable = enumerator as IDisposable;
                  int num13 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
                    num13 = 1;
                  while (true)
                  {
                    switch (num13)
                    {
                      case 1:
                        if (disposable != null)
                        {
                          num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_66;
                      case 2:
                        goto label_66;
                      default:
                        AutoDeployService.giHBgjEHyf9EtQfU73UZ((object) disposable);
                        num13 = 2;
                        continue;
                    }
                  }
label_66:;
                }
              }
              catch (Exception ex)
              {
                int num14 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
                  num14 = 0;
                while (true)
                {
                  switch (num14)
                  {
                    case 1:
                      goto label_3;
                    default:
                      AutoDeployService.nMJMoUEH0eDCbhCnTPxp((object) AutoDeployService.DeployLog, (object) ex);
                      num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
          }
        }
label_8:
        num1 = 9;
      }
label_73:
      return;
label_71:
      return;
label_10:
      throw new NestingLevelException((ElmaStoreComponentManifest) AutoDeployService.eEg7RYEHp9enp1ZOpsPr((object) parent));
    }

    private ConfigImportSettings NewConfigImportSettings() => new ConfigImportSettings();

    private void RunImportStep0(
      ConfigImportSettings importSettings,
      ModuleManager.StoreComponentConfigurationInfo info,
      AutoDeployService.ManifestDeployLogger localDeployLog)
    {
      int num = 2;
      while (true)
      {
        ModuleManager moduleManager;
        switch (num)
        {
          case 1:
            AutoDeployService.Qj7YjFEH9janHmOe7nDE((object) importSettings, 0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 3;
            continue;
          case 2:
            AutoDeployService.JqyCBIEHJGP42TxqAQkb((object) localDeployLog, (object) ((string) AutoDeployService.NOqQvoEHqpypsttIQ10j(1994213607 >> 4 ^ 124339438) + info.Id + (string) AutoDeployService.NOqQvoEHqpypsttIQ10j(1218962250 ^ 1218947688) + (string) AutoDeployService.xKpfDTEHM189vcR3v33Y((object) info)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
            continue;
          case 3:
            moduleManager = ((ComponentManager) AutoDeployService.HRO8ZqEHdwn904xXTMVA()).ModuleManager as ModuleManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 7;
            continue;
          case 4:
            goto label_5;
          case 5:
          case 6:
            this.ImportConfiguration(importSettings, info, localDeployLog);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 2 : 4;
            continue;
          case 7:
            if (moduleManager == null)
            {
              num = 6;
              continue;
            }
            break;
        }
        AutoDeployService.oXIRq5EHldEscgOZlows((object) moduleManager, (object) info, AutoDeployComponentStatus.Step0);
        num = 5;
      }
label_5:;
    }

    private void RunImportStep1(
      ConfigImportSettings importSettings,
      ModuleManager.StoreComponentConfigurationInfo info,
      bool needRestart,
      AutoDeployService.ManifestDeployLogger localDeployLog)
    {
      int num = 11;
      ModuleManager moduleManager;
      while (true)
      {
        switch (num)
        {
          case 1:
            AutoDeployService.oXIRq5EHldEscgOZlows((object) moduleManager, (object) info, AutoDeployComponentStatus.Step1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 4 : 4;
            continue;
          case 2:
            Locator.GetServiceNotNull<WebHostEnvironmentManager>().RestartHost();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 4 : 12;
            continue;
          case 3:
          case 4:
            if (!needRestart)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 5:
            goto label_8;
          case 6:
            AutoDeployService.JqyCBIEHJGP42TxqAQkb((object) localDeployLog, AutoDeployService.n8PorTEHgLB56ynpr3o4(AutoDeployService.NOqQvoEHqpypsttIQ10j(-643786247 ^ -643561107), AutoDeployService.E9Lm23EHrhMrUMuVHPw5((object) info), AutoDeployService.NOqQvoEHqpypsttIQ10j(-2138958856 ^ -2138940710), AutoDeployService.xKpfDTEHM189vcR3v33Y((object) info)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 2;
            continue;
          case 7:
            goto label_15;
          case 8:
            if (moduleManager == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 3;
              continue;
            }
            goto case 1;
          case 9:
            moduleManager = AutoDeployService.Kfq8epEH57Y9qFGongHo((object) ComponentManager.Current) as ModuleManager;
            num = 8;
            continue;
          case 10:
            importSettings.ImportStep = 1;
            num = 9;
            continue;
          case 11:
            localDeployLog.Info(AutoDeployService.n8PorTEHgLB56ynpr3o4(AutoDeployService.NOqQvoEHqpypsttIQ10j(--1333735954 ^ 1333502568), AutoDeployService.E9Lm23EHrhMrUMuVHPw5((object) info), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536785224), AutoDeployService.xKpfDTEHM189vcR3v33Y((object) info)));
            num = 10;
            continue;
          case 12:
            AutoDeployService.mp0bQjEHjeGXgJXn4777(10000);
            num = 7;
            continue;
          default:
            this.ImportConfiguration(importSettings, info, localDeployLog);
            num = 5;
            continue;
        }
      }
label_8:
      return;
label_15:;
    }

    private void RunImportStep2(
      ConfigImportSettings importSettings,
      ModuleManager.StoreComponentConfigurationInfo info,
      bool needRestart,
      AutoDeployService.ManifestDeployLogger localDeployLog)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        ModuleManager moduleManager;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              if (!needRestart)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 3 : 9;
                continue;
              }
              goto case 2;
            case 2:
              AutoDeployService.JqyCBIEHJGP42TxqAQkb((object) localDeployLog, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597302874) + (string) AutoDeployService.E9Lm23EHrhMrUMuVHPw5((object) info) + (string) AutoDeployService.NOqQvoEHqpypsttIQ10j(2045296739 + 1688595713 ^ -561060794) + info.DeployVersion));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 4 : 2;
              continue;
            case 4:
              AutoDeployService.J4jttoEHYjjyqvlNEvch((object) Locator.GetServiceNotNull<WebHostEnvironmentManager>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            case 5:
              goto label_13;
            case 6:
              AutoDeployService.Qj7YjFEH9janHmOe7nDE((object) importSettings, 2);
              num2 = 12;
              continue;
            case 7:
              goto label_10;
            case 8:
              goto label_5;
            case 9:
              this.ImportConfiguration(importSettings, info, localDeployLog);
              num2 = 8;
              continue;
            case 10:
              AutoDeployService.oXIRq5EHldEscgOZlows((object) moduleManager, (object) info, AutoDeployComponentStatus.Step2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
              continue;
            case 11:
              if (moduleManager == null)
              {
                num2 = 3;
                continue;
              }
              goto case 10;
            case 12:
              moduleManager = ((ComponentManager) AutoDeployService.HRO8ZqEHdwn904xXTMVA()).ModuleManager as ModuleManager;
              num2 = 11;
              continue;
            default:
              AutoDeployService.mp0bQjEHjeGXgJXn4777(10000);
              num2 = 5;
              continue;
          }
        }
label_10:
        AutoDeployService.JqyCBIEHJGP42TxqAQkb((object) localDeployLog, (object) ((string) AutoDeployService.NOqQvoEHqpypsttIQ10j(-1255365154 ^ 596875508 ^ -1766085128) + (string) AutoDeployService.E9Lm23EHrhMrUMuVHPw5((object) info) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477158152) + info.DeployVersion));
        num1 = 6;
      }
label_13:
      return;
label_5:;
    }

    /// <summary>Запуск импорта файла с конфигурацией</summary>
    private void ImportConfiguration(
      ConfigImportSettings importSettings,
      ModuleManager.StoreComponentConfigurationInfo info,
      AutoDeployService.ManifestDeployLogger localDeployLog)
    {
      int num1 = 22;
      while (true)
      {
        int num2 = num1;
        ConfigImportSettings importSettings1;
        AutoDeployService.ManifestDeployLogger localDeployLog1;
        while (true)
        {
          ModuleManager moduleManager1;
          ModuleManager moduleManager2;
          List<DeployLogMessage> importLog;
          IExportImportFileManager serviceNotNull;
          Guid importUid;
          IDeployManager deployManager;
          switch (num2)
          {
            case 0:
              goto label_49;
            case 1:
            case 32:
              importLog = deployManager.GetImportLog(importUid);
              num2 = 10;
              continue;
            case 2:
              importUid = Guid.Empty;
              num2 = 19;
              continue;
            case 3:
              serviceNotNull.DeleteFiles((string) AutoDeployService.APmZXaEHUBZXK5EnIhLK((object) importSettings1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 7;
              continue;
            case 4:
              goto label_44;
            case 5:
              deployManager = Locator.GetServiceNotNull<IDeployManager>();
              num2 = 2;
              continue;
            case 6:
              List<DeployLogMessage> source1 = importLog;
              // ISSUE: reference to a compiler-generated field
              Func<DeployLogMessage, bool> func1 = AutoDeployService.\u003C\u003Ec.\u003C\u003E9__35_5;
              Func<DeployLogMessage, bool> predicate1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                AutoDeployService.\u003C\u003Ec.\u003C\u003E9__35_5 = predicate1 = (Func<DeployLogMessage, bool>) (m => AutoDeployService.\u003C\u003Ec.IAQQjB8NgvMgyGb4P8yP((object) m));
              }
              else
                goto label_52;
label_46:
              if (source1.Any<DeployLogMessage>(predicate1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 13 : 28;
                continue;
              }
              break;
label_52:
              predicate1 = func1;
              goto label_46;
            case 7:
              moduleManager2 = ((ComponentManager) AutoDeployService.HRO8ZqEHdwn904xXTMVA()).ModuleManager as ModuleManager;
              num2 = 12;
              continue;
            case 8:
              goto label_17;
            case 9:
              // ISSUE: reference to a compiler-generated method
              if (!importLog.Any<DeployLogMessage>((Func<DeployLogMessage, bool>) (m => AutoDeployService.\u003C\u003Ec.tpHVJE8NrBt81e9BZeGI((object) m) == DeployLogMessageType.Error)))
              {
                if (importSettings1.ImportStep != 0)
                {
                  num2 = 15;
                  continue;
                }
                goto case 26;
              }
              else
              {
                num2 = 24;
                continue;
              }
            case 10:
              // ISSUE: reference to a compiler-generated method
              if (!importLog.Any<DeployLogMessage>((Func<DeployLogMessage, bool>) (m => AutoDeployService.\u003C\u003Ec.TtMQgZ8NlU6v9c1cJDEx((object) m))))
              {
                num2 = 13;
                continue;
              }
              goto case 25;
            case 11:
              goto label_36;
            case 12:
              if (moduleManager2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                continue;
              }
              goto case 23;
            case 13:
              AutoDeployService.mp0bQjEHjeGXgJXn4777(1000);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
              continue;
            case 14:
            case 15:
              if (AutoDeployService.M8CoEOEHsiUNqJZ9ePYD((object) importSettings1) != 1)
                break;
              goto label_19;
            case 16:
              serviceNotNull.DeleteFiles((string) AutoDeployService.APmZXaEHUBZXK5EnIhLK((object) importSettings1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 30 : 13;
              continue;
            case 17:
              goto label_14;
            case 18:
              goto label_5;
            case 19:
              AutoDeployService.EHMLoMEHL8QvEi9cUkIJ((object) Locator.GetServiceNotNull<ISecurityService>(), (object) (System.Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      importUid = deployManager.ImportConfiguration((IConfigImportSettings) importSettings1);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 32;
              continue;
            case 20:
              List<DeployLogMessage> deployLogMessageList = importLog;
              Action<DeployLogMessage> action;
              Action<DeployLogMessage> action1 = action;
              Action<DeployLogMessage> action2 = action1 == null ? (action = (Action<DeployLogMessage>) (m =>
              {
                int num4 = 2;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      AutoDeployService.\u003C\u003Ec__DisplayClass35_0.a92FQB8abaXLMJ7kqbjs((object) localDeployLog1, (object) m.MessageText);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (AutoDeployService.\u003C\u003Ec__DisplayClass35_0.T6Kd858aoCimxbiymFpE((object) m) == DeployLogMessageType.Error)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_6;
                    default:
                      goto label_7;
                  }
                }
label_2:
                return;
label_7:
                return;
label_6:;
              })) : action1;
              deployLogMessageList.ForEach(action2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 16 : 12;
              continue;
            case 21:
              goto label_25;
            case 22:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 21 : 10;
              continue;
            case 23:
              AutoDeployService.oXIRq5EHldEscgOZlows((object) moduleManager2, (object) info, AutoDeployComponentStatus.Complete);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 4 : 0;
              continue;
            case 24:
              AutoDeployService.l3eGbYEHP1DTHug84kr8((object) localDeployLog1, AutoDeployService.n8PorTEHgLB56ynpr3o4(AutoDeployService.NOqQvoEHqpypsttIQ10j(-2138958856 ^ -2138668334), AutoDeployService.E9Lm23EHrhMrUMuVHPw5((object) info), AutoDeployService.NOqQvoEHqpypsttIQ10j(-812025778 ^ -812043924), (object) info.DeployVersion));
              num2 = 20;
              continue;
            case 25:
              serviceNotNull = Locator.GetServiceNotNull<IExportImportFileManager>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 9;
              continue;
            case 26:
              // ISSUE: reference to a compiler-generated method
              if (!importLog.Any<DeployLogMessage>((Func<DeployLogMessage, bool>) (m => AutoDeployService.\u003C\u003Ec.IAQQjB8NgvMgyGb4P8yP((object) m))))
              {
                num2 = 14;
                continue;
              }
              goto case 29;
            case 27:
              if (moduleManager1 == null)
              {
                num2 = 8;
                continue;
              }
              goto case 33;
            case 28:
              ConfigImportSettings importSettings2 = importSettings1;
              ModuleManager.StoreComponentConfigurationInfo info1 = info;
              List<DeployLogMessage> source2 = importLog;
              // ISSUE: reference to a compiler-generated field
              Func<DeployLogMessage, bool> func2 = AutoDeployService.\u003C\u003Ec.\u003C\u003E9__35_6;
              Func<DeployLogMessage, bool> predicate2;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                AutoDeployService.\u003C\u003Ec.\u003C\u003E9__35_6 = predicate2 = (Func<DeployLogMessage, bool>) (m => AutoDeployService.\u003C\u003Ec.OX8L3H8N5UCFjVeLakX7((object) m));
              }
              else
                goto label_54;
label_51:
              int num5 = source2.Any<DeployLogMessage>(predicate2) ? 1 : 0;
              AutoDeployService.ManifestDeployLogger localDeployLog2 = localDeployLog1;
              this.RunImportStep2(importSettings2, info1, num5 != 0, localDeployLog2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 18;
              continue;
label_54:
              predicate2 = func2;
              goto label_51;
            case 29:
              ConfigImportSettings importSettings3 = importSettings1;
              ModuleManager.StoreComponentConfigurationInfo info2 = info;
              List<DeployLogMessage> source3 = importLog;
              // ISSUE: reference to a compiler-generated field
              Func<DeployLogMessage, bool> func3 = AutoDeployService.\u003C\u003Ec.\u003C\u003E9__35_4;
              Func<DeployLogMessage, bool> predicate3;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                AutoDeployService.\u003C\u003Ec.\u003C\u003E9__35_4 = predicate3 = (Func<DeployLogMessage, bool>) (m => AutoDeployService.\u003C\u003Ec.OX8L3H8N5UCFjVeLakX7((object) m));
              }
              else
                goto label_53;
label_42:
              int num6 = source3.Any<DeployLogMessage>(predicate3) ? 1 : 0;
              AutoDeployService.ManifestDeployLogger localDeployLog3 = localDeployLog1;
              this.RunImportStep1(importSettings3, info2, num6 != 0, localDeployLog3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 17 : 1;
              continue;
label_53:
              predicate3 = func3;
              goto label_42;
            case 30:
              moduleManager1 = AutoDeployService.Kfq8epEH57Y9qFGongHo(AutoDeployService.HRO8ZqEHdwn904xXTMVA()) as ModuleManager;
              num2 = 27;
              continue;
            case 31:
              goto label_21;
            case 33:
              moduleManager1.UpdateAutoDeployComponentInfo(info, AutoDeployComponentStatus.Failed);
              num2 = 11;
              continue;
            default:
              goto label_40;
          }
          localDeployLog1.Info(AutoDeployService.n8PorTEHgLB56ynpr3o4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858653971), (object) info.Id, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418454952), (object) info.DeployVersion));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 3 : 0;
        }
label_19:
        num1 = 6;
        continue;
label_21:
        localDeployLog1 = localDeployLog;
        num1 = 5;
        continue;
label_25:
        importSettings1 = importSettings;
        num1 = 31;
      }
label_49:
      return;
label_44:
      return;
label_17:
      return;
label_36:
      return;
label_14:
      return;
label_5:
      return;
label_40:;
    }

    /// <summary>Запуск тестирования файла с конфигурацией</summary>
    private List<TestImportMessages> TestConfiguration(ConfigImportSettings importSettings)
    {
      List<TestImportMessages> source = new List<TestImportMessages>();
      IDeployManager deployManager = Locator.GetServiceNotNull<IDeployManager>();
      Guid testUid = Guid.Empty;
      Locator.GetServiceNotNull<ISecurityService>().RunBySystemUser((System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              testUid = deployManager.TestConfiguration((IConfigImportSettings) importSettings);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      while (true)
      {
        source.AddRange((IEnumerable<TestImportMessages>) deployManager.GetTestLog(testUid));
        if (!source.Any<TestImportMessages>((Func<TestImportMessages, bool>) (m => m.Type == TestImportMessagesType.Finish)))
          Thread.Sleep(1000);
        else
          break;
      }
      return source;
    }

    private void UploadFile(string localFileName, ConfigImportSettings importSettings)
    {
      int num1 = 2;
      IExportImportFileService serviceNotNull;
      string str;
      FileStream fileStream;
      long num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            serviceNotNull = Locator.GetServiceNotNull<IExportImportFileService>();
            num1 = 3;
            continue;
          case 2:
            str = (string) AutoDeployService.APmZXaEHUBZXK5EnIhLK((object) importSettings);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
            continue;
          case 3:
            AutoDeployService.GGwyc7EHcrnMRSFMRucG((object) serviceNotNull, (object) str);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 4;
            continue;
          case 4:
            num2 = 0L;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_29;
          case 6:
            goto label_4;
          default:
            fileStream = new FileStream(localFileName, FileMode.Open, FileAccess.Read);
            num1 = 6;
            continue;
        }
      }
label_29:
      return;
label_4:
      try
      {
        long num3 = AutoDeployService.cm5T2iEHz2woyumPFvjq((object) serviceNotNull);
        int num4 = 14;
        while (true)
        {
          byte[] numArray;
          long length1;
          long length2;
          long num5;
          switch (num4)
          {
            case 1:
              if (num2 == long.MaxValue)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 12 : 4;
                continue;
              }
              goto case 6;
            case 2:
              length2 = fileStream.Length;
              num4 = 5;
              continue;
            case 3:
              num5 = length2 - num2 * num3;
              break;
            case 4:
              numArray = new byte[length1];
              num4 = 7;
              continue;
            case 6:
              if ((num2 + 1L) * num3 >= length2)
              {
                num4 = 3;
                continue;
              }
              num5 = num3;
              break;
            case 7:
              AutoDeployService.VTjvT1EAFSOhAdjWcNH9((object) fileStream, (object) numArray, 0, numArray.Length);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 5 : 8;
              continue;
            case 8:
              AutoDeployService.i9UNsOEABK2KFXZgmeYD((object) serviceNotNull, (object) str, (object) numArray);
              num4 = 9;
              continue;
            case 9:
              ++num2;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            case 10:
              if (length1 <= 0L)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 13 : 7;
                continue;
              }
              goto case 4;
            case 11:
              goto label_28;
            case 12:
              goto label_24;
            case 13:
              goto label_21;
            case 14:
              length1 = num3;
              num4 = 2;
              continue;
            default:
              if (length1 <= 0L)
              {
                num4 = 11;
                continue;
              }
              goto case 1;
          }
          length1 = num5;
          num4 = 10;
        }
label_28:
        return;
label_24:
        return;
label_21:;
      }
      finally
      {
        int num6;
        if (fileStream == null)
          num6 = 2;
        else
          goto label_30;
label_27:
        switch (num6)
        {
          case 1:
            break;
          default:
        }
label_30:
        AutoDeployService.giHBgjEHyf9EtQfU73UZ((object) fileStream);
        num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        {
          num6 = 0;
          goto label_27;
        }
        else
          goto label_27;
      }
    }

    /// <summary>
    /// Построить упорядоченный по внутренним зависимостям список манифестов для импорта
    /// </summary>
    /// <param name="items">Список манифестов</param>
    /// <returns>Отсортированное перечисление</returns>
    private List<AutoDeployService.ManifestItem> GetSortedManifestList(
      IEnumerable<AutoDeployService.ManifestItem> items)
    {
      List<string> stringList = new List<string>();
      HashSet<string> visited = new HashSet<string>();
      // ISSUE: reference to a compiler-generated method
      HashSet<string> hashSet1 = items.Select<AutoDeployService.ManifestItem, string>((Func<AutoDeployService.ManifestItem, string>) (h => ((ElmaStoreComponentManifest) AutoDeployService.\u003C\u003Ec.IRBpym8NdQqXDcD4ScPp((object) h)).Id)).ToHashSet<string>();
      Dictionary<string, ISet<string>> dependencies = new Dictionary<string, ISet<string>>();
      // ISSUE: reference to a compiler-generated method
      items.Select<AutoDeployService.ManifestItem, ElmaStoreComponentManifest>((Func<AutoDeployService.ManifestItem, ElmaStoreComponentManifest>) (i => (ElmaStoreComponentManifest) AutoDeployService.\u003C\u003Ec.IRBpym8NdQqXDcD4ScPp((object) i))).ToList<ElmaStoreComponentManifest>();
      foreach (AutoDeployService.ManifestItem manifestItem in items)
      {
        string id = manifestItem.Manifest.Id;
        if (manifestItem.Manifest.Dependencies != null)
        {
          // ISSUE: reference to a compiler-generated method
          HashSet<string> hashSet2 = manifestItem.Manifest.Dependencies.Select<ElmaStoreComponentDependency, string>((Func<ElmaStoreComponentDependency, string>) (d => (string) AutoDeployService.\u003C\u003Ec.A3y6UJ8Njx1J1guH1f3H((object) d))).ToHashSet<string>();
          hashSet2.IntersectWith((IEnumerable<string>) hashSet1);
          if (hashSet2.Count > 0)
          {
            dependencies.Add(id, (ISet<string>) hashSet2);
            continue;
          }
        }
        visited.Add(id);
        stringList.Add(id);
      }
      foreach (KeyValuePair<string, ISet<string>> keyValuePair in dependencies)
        this.Visit(keyValuePair.Key, (IDictionary<string, ISet<string>>) dependencies, (ISet<string>) visited, (ICollection<string>) stringList);
      // ISSUE: reference to a compiler-generated method
      Dictionary<string, AutoDeployService.ManifestItem> dic = items.ToDictionary<AutoDeployService.ManifestItem, string, AutoDeployService.ManifestItem>((Func<AutoDeployService.ManifestItem, string>) (i => (string) AutoDeployService.\u003C\u003Ec.cObD3i8Nx0qPLVnFK04G((object) i)), (Func<AutoDeployService.ManifestItem, AutoDeployService.ManifestItem>) (i => i));
      return stringList.Select<string, AutoDeployService.ManifestItem>((Func<string, AutoDeployService.ManifestItem>) (uid => dic[uid])).ToList<AutoDeployService.ManifestItem>();
    }

    private void Visit(
      string node,
      IDictionary<string, ISet<string>> dependencies,
      ISet<string> visited,
      ICollection<string> result)
    {
      if (visited.Contains(node))
        return;
      visited.Add(node);
      foreach (string node1 in (IEnumerable<string>) dependencies[node])
        this.Visit(node1, dependencies, visited, result);
      result.Add(node);
    }

    public AutoDeployService()
    {
      AutoDeployService.tDGONYEAWDCHFufLy5cA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static AutoDeployService()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AutoDeployService.AllowedAutoDeployExtensions = new string[2]
            {
              (string) AutoDeployService.NOqQvoEHqpypsttIQ10j(-1638402543 ^ -1638701213),
              (string) AutoDeployService.NOqQvoEHqpypsttIQ10j(1669371371 ^ 1669596261)
            };
            num = 4;
            continue;
          case 2:
            AutoDeployService.tDGONYEAWDCHFufLy5cA();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
            continue;
          case 3:
            AutoDeployService.DeployLog = Logger.GetLogger((string) AutoDeployService.NOqQvoEHqpypsttIQ10j(1149433385 + 173655049 ^ 1322792916));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            AutoDeployService.AutoDeployMasks = ((IEnumerable<string>) AutoDeployService.AllowedAutoDeployExtensions).Select<string, string>((Func<string, string>) (ext => (string) AutoDeployService.\u003C\u003Ec.dA7XpI8NLeNGrgciJdgM(AutoDeployService.\u003C\u003Ec.C5mb4P8NYcy0HbRWmvKL(-16752921 ^ -16773961), (object) ext))).ToArray<string>();
            num = 3;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal static object WV9tFuEHRwCCp4TYNLwd([In] object obj0) => (object) ((PackageService) obj0).LocalRepositoryPath;

    internal static object NOqQvoEHqpypsttIQ10j(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object PKUS72EHKKn6swMQ9jxy([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool NW3HeNEHXbyNJ1Ku4KHP([In] object obj0) => Directory.Exists((string) obj0);

    internal static object R4eZwKEHTNTlOAWr5Bbj([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static bool FqyNh6EHSPVLus1REA4t() => AutoDeployService.K4cWdEEHVcMEgNoaS6PX == null;

    internal static AutoDeployService ah0h7UEHiajwFF08qnsQ() => AutoDeployService.K4cWdEEHVcMEgNoaS6PX;

    internal static object irB9GcEHkLRx4w9RFEXZ([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static DateTime jNWBr6EHnfuZdCBXT5P1() => DateTime.Now;

    internal static object oPEcFbEHOmiXeFTUix9x([In] object obj0) => (object) ((AutoDeployService.ManifestItem) obj0).Id;

    internal static object I5GCs4EH2NX4MsLi0ifu([In] object obj0) => (object) ((AutoDeployService.ManifestItem) obj0).Version;

    internal static object wtJZyUEHeZHPAxYcd2jK([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void l3eGbYEHP1DTHug84kr8([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Logging.ILogger) obj0).Warn(obj1);

    internal static object aWVUCHEH1JrRmbJ8vw14() => (object) Environment.NewLine;

    internal static void zTFFxPEHNLZQw4YKiTA8([In] object obj0) => ((AutoDeployService.ManifestDeployLogger) obj0).CompleteDeploy();

    internal static object KHq1BEEH3SVlp8VHoye5([In] object obj0) => (object) ((AutoDeployService.ManifestDeployLogger) obj0).LogPath;

    internal static object eEg7RYEHp9enp1ZOpsPr([In] object obj0) => (object) ((AutoDeployService.ManifestItem) obj0).Manifest;

    internal static object EgCQnbEHaBLQNeA5O7kD([In] object obj0) => (object) File.OpenRead((string) obj0);

    internal static bool el39dPEHDAcwTC17mG5u([In] object obj0) => ((ZipEntry) obj0).IsFile;

    internal static object RwWhQgEHtqd4bO8LLo0p([In] object obj0) => (object) ((ZipEntry) obj0).Name;

    internal static bool dgvyvNEHwRjMh09Anw8G([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object XXqqjREH4Pd3I6vEX0vH([In] object obj0, [In] object obj1) => (object) ((ZipFile) obj0).GetInputStream((ZipEntry) obj1);

    internal static void kQxNmfEH6xGgXBIqWvGO([In] object obj0, [In] object obj1) => FS.CreateFile((string) obj0, (System.Action) obj1);

    internal static bool pv8nP9EHHR977VViicvI([In] object obj0) => File.Exists((string) obj0);

    internal static void OfJearEHAAdIBdNrOlXl([In] object obj0, [In] object obj1) => ((AutoDeployService.ManifestItem) obj0).ElmaFile = (string) obj1;

    internal static void S5bYQREH7cN23w1tnCca([In] object obj0, [In] object obj1) => ((AutoDeployService.ManifestItem) obj0).ManifestFile = (string) obj1;

    internal static void gV1OoCEHxmRhFhdytSU3([In] object obj0, [In] object obj1) => ((AutoDeployService.ManifestItem) obj0).Manifest = (ElmaStoreComponentManifest) obj1;

    internal static void nMJMoUEH0eDCbhCnTPxp([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1);

    internal static bool WjTNqFEHmyuN4l9PdKJN([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void giHBgjEHyf9EtQfU73UZ([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object xKpfDTEHM189vcR3v33Y([In] object obj0) => (object) ((ModuleManager.StoreComponentConfigurationInfo) obj0).DeployVersion;

    internal static void JqyCBIEHJGP42TxqAQkb([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Logging.ILogger) obj0).Info(obj1);

    internal static void Qj7YjFEH9janHmOe7nDE([In] object obj0, int value) => ((ConfigImportSettings) obj0).ImportStep = value;

    internal static object HRO8ZqEHdwn904xXTMVA() => (object) ComponentManager.Current;

    internal static void oXIRq5EHldEscgOZlows(
      [In] object obj0,
      [In] object obj1,
      AutoDeployComponentStatus status)
    {
      ((ModuleManager) obj0).UpdateAutoDeployComponentInfo((ModuleManager.StoreComponentConfigurationInfo) obj1, status);
    }

    internal static object E9Lm23EHrhMrUMuVHPw5([In] object obj0) => (object) ((ModuleManager.StoreComponentConfigurationInfo) obj0).Id;

    internal static object n8PorTEHgLB56ynpr3o4(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object Kfq8epEH57Y9qFGongHo([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static void mp0bQjEHjeGXgJXn4777([In] int obj0) => Thread.Sleep(obj0);

    internal static void J4jttoEHYjjyqvlNEvch([In] object obj0) => ((WebHostEnvironmentManager) obj0).RestartHost();

    internal static void EHMLoMEHL8QvEi9cUkIJ([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunBySystemUser((System.Action) obj1);

    internal static object APmZXaEHUBZXK5EnIhLK([In] object obj0) => (object) ((ConfigImportSettings) obj0).FileName;

    internal static int M8CoEOEHsiUNqJZ9ePYD([In] object obj0) => ((ConfigImportSettings) obj0).ImportStep;

    internal static void GGwyc7EHcrnMRSFMRucG([In] object obj0, [In] object obj1) => ((IExportImportFileService) obj0).DeleteFiles((string) obj1);

    internal static long cm5T2iEHz2woyumPFvjq([In] object obj0) => ((IExportImportFileService) obj0).GetBufferLength();

    internal static int VTjvT1EAFSOhAdjWcNH9([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Read((byte[]) obj1, obj2, obj3);

    internal static void i9UNsOEABK2KFXZgmeYD([In] object obj0, [In] object obj1, [In] object obj2) => ((IExportImportFileService) obj0).AddToFile((string) obj1, (byte[]) obj2);

    internal static void tDGONYEAWDCHFufLy5cA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class ManifestList
    {
      internal static object Bb8swn819axCoYAcM5k3;

      public List<AutoDeployService.ManifestItem> All { get; }

      /// <summary>Папка, в которую помещены файлы манифеста</summary>
      public string DeployDirectory
      {
        get => this.\u003CDeployDirectory\u003Ek__BackingField;
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
                this.\u003CDeployDirectory\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

      public void Remove(AutoDeployService.ManifestItem item)
      {
        int num = 7;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_7;
            case 3:
              AutoDeployService.ManifestList.EBkCPR81gUm27JSuVjF5(AutoDeployService.ManifestList.jUWRY881rM30vfwHTCZT((object) item), (object) item);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
            case 4:
              this.All.Remove(item);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            case 5:
              goto label_2;
            case 6:
              if (!this.All.Contains(item))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 2;
                continue;
              }
              goto case 4;
            case 7:
              item.Childs.ToList<AutoDeployService.ManifestItem>().ForEach(new Action<AutoDeployService.ManifestItem>(this.Remove));
              num = 6;
              continue;
            default:
              if (AutoDeployService.ManifestList.jUWRY881rM30vfwHTCZT((object) item) == null)
              {
                num = 5;
                continue;
              }
              goto case 3;
          }
        }
label_7:
        return;
label_2:;
      }

      public void Remove(ElmaStoreComponentManifest manifest)
      {
        int num = 2;
        ElmaStoreComponentManifest manifest1;
        while (true)
        {
          switch (num)
          {
            case 1:
              manifest1 = manifest;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 2:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_2;
            default:
              this.All.Where<AutoDeployService.ManifestItem>((Func<AutoDeployService.ManifestItem, bool>) (i => i.Manifest == manifest1)).ToList<AutoDeployService.ManifestItem>().ForEach(new Action<AutoDeployService.ManifestItem>(this.Remove));
              num = 3;
              continue;
          }
        }
label_2:;
      }

      public void Add(AutoDeployService.ManifestItem item, AutoDeployService.ManifestItem parent)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.All.Contains(item))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 2:
              goto label_9;
            case 3:
              goto label_8;
            case 5:
              this.All.Add(item);
              num = 4;
              continue;
            case 6:
              AutoDeployService.ManifestList.aiPM4s815DTK7UsvGJZr((object) parent, (object) item);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 0;
              continue;
            default:
              if (parent == null)
              {
                num = 3;
                continue;
              }
              goto case 6;
          }
        }
label_9:
        return;
label_8:;
      }

      public ManifestList()
      {
        AutoDeployService.ManifestList.vbj9aW81jpVPnWdqE8yE();
        this.All = new List<AutoDeployService.ManifestItem>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool a9UWo781dlMoiW5u7p6p() => AutoDeployService.ManifestList.Bb8swn819axCoYAcM5k3 == null;

      internal static AutoDeployService.ManifestList uGN2TN81ltsFiu8ukNXk() => (AutoDeployService.ManifestList) AutoDeployService.ManifestList.Bb8swn819axCoYAcM5k3;

      internal static object jUWRY881rM30vfwHTCZT([In] object obj0) => (object) ((AutoDeployService.ManifestItem) obj0).Parent;

      internal static void EBkCPR81gUm27JSuVjF5([In] object obj0, [In] object obj1) => ((AutoDeployService.ManifestItem) obj0).RemoveChild((AutoDeployService.ManifestItem) obj1);

      internal static void aiPM4s815DTK7UsvGJZr([In] object obj0, [In] object obj1) => ((AutoDeployService.ManifestItem) obj0).AddChild((AutoDeployService.ManifestItem) obj1);

      internal static void vbj9aW81jpVPnWdqE8yE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    private class ManifestItem
    {
      public List<AutoDeployService.ManifestItem> Childs;
      private static object bsGgaP81YpS6wiyl3G6b;

      public string ElmaFile
      {
        get => this.\u003CElmaFile\u003Ek__BackingField;
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
                this.\u003CElmaFile\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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

      public string ManifestFile
      {
        get => this.\u003CManifestFile\u003Ek__BackingField;
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
                this.\u003CManifestFile\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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

      public string Id
      {
        get
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                if (this.Manifest == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
                  continue;
                }
                goto label_2;
              default:
                goto label_2;
            }
          }
label_2:
          return (string) AutoDeployService.ManifestItem.Rl1o3R81spJLQgaQ1GY7((object) this.Manifest);
label_3:
          return "";
        }
      }

      public SemanticVersion Version => (SemanticVersion) AutoDeployService.ManifestItem.Hy94Kj81cGJo7B1R84BS((object) this.Manifest);

      public AutoDeployService.ManifestItem Parent
      {
        get => this.\u003CParent\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CParent\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

      public void AddChild(AutoDeployService.ManifestItem child)
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                this.Childs.Add(child);
                num2 = 4;
                continue;
              case 2:
                goto label_8;
              case 3:
                if (child != null)
                  break;
                goto label_7;
              case 4:
                goto label_3;
            }
            child.Parent = this;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
          }
label_7:
          num1 = 2;
        }
label_8:
        return;
label_3:;
      }

      public void RemoveChild(AutoDeployService.ManifestItem child)
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_6;
              case 1:
                if (!this.Childs.Contains(child))
                {
                  num2 = 2;
                  continue;
                }
                goto case 5;
              case 2:
                goto label_4;
              case 3:
                goto label_3;
              case 4:
                if (child != null)
                  goto case 1;
                else
                  goto label_9;
              case 5:
                AutoDeployService.ManifestItem.R7jkJM81zmtSnrEXvGTp((object) child, (object) null);
                num2 = 6;
                continue;
              case 6:
                this.Childs.Remove(child);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                continue;
              default:
                goto label_12;
            }
          }
label_9:
          num1 = 3;
        }
label_6:
        return;
label_4:
        return;
label_3:
        return;
label_12:;
      }

      public ManifestItem()
      {
        AutoDeployService.ManifestItem.DwFCwK8NFJXp0jT3tb99();
        this.Childs = new List<AutoDeployService.ManifestItem>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool opeMSW81Lwhpahgu8055() => AutoDeployService.ManifestItem.bsGgaP81YpS6wiyl3G6b == null;

      internal static AutoDeployService.ManifestItem Cl6YDx81UdlaZCstxrv2() => (AutoDeployService.ManifestItem) AutoDeployService.ManifestItem.bsGgaP81YpS6wiyl3G6b;

      internal static object Rl1o3R81spJLQgaQ1GY7([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

      internal static object Hy94Kj81cGJo7B1R84BS([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).SemanticVersion;

      internal static void R7jkJM81zmtSnrEXvGTp([In] object obj0, [In] object obj1) => ((AutoDeployService.ManifestItem) obj0).Parent = (AutoDeployService.ManifestItem) obj1;

      internal static void DwFCwK8NFJXp0jT3tb99() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    private class StandardAutoDeployResult : IDeployResult
    {
      private readonly object logPath;
      private static object QukqkU8NB3eir13hA2Xh;

      public StandardAutoDeployResult(bool hasErrors, string logPath)
      {
        AutoDeployService.StandardAutoDeployResult.P4x6Wg8NbB9L1sQDqQRt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.HasErrors = hasErrors;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              this.logPath = (object) logPath;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
              continue;
          }
        }
label_3:;
      }

      public bool HasErrors { get; }

      public string GetLog() => (string) AutoDeployService.StandardAutoDeployResult.q1Wrq68NG7ZymTDPXsYR(this.logPath, AutoDeployService.StandardAutoDeployResult.Qx26Vk8NhAi1mXuq9NHB());

      internal static void P4x6Wg8NbB9L1sQDqQRt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool Tj60HK8NWHMa3OwnXlkP() => AutoDeployService.StandardAutoDeployResult.QukqkU8NB3eir13hA2Xh == null;

      internal static AutoDeployService.StandardAutoDeployResult btbfVg8No9RZDqG30bfm() => (AutoDeployService.StandardAutoDeployResult) AutoDeployService.StandardAutoDeployResult.QukqkU8NB3eir13hA2Xh;

      internal static object Qx26Vk8NhAi1mXuq9NHB() => (object) Encoding.UTF8;

      internal static object q1Wrq68NG7ZymTDPXsYR([In] object obj0, [In] object obj1) => (object) File.ReadAllText((string) obj0, (Encoding) obj1);
    }

    private class ExceptionAutoDeployResult : IDeployResult
    {
      private readonly object exception;
      internal static object zLoWZf8NE9CGUpTclYTT;

      public ExceptionAutoDeployResult(Exception exception)
      {
        AutoDeployService.ExceptionAutoDeployResult.NxMlnt8NCjmT6H7PO3oh();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.exception = (object) exception;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public bool HasErrors => true;

      public string GetLog() => this.exception.ToString();

      internal static void NxMlnt8NCjmT6H7PO3oh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool fO4WvN8NfVIEsekLn2xW() => AutoDeployService.ExceptionAutoDeployResult.zLoWZf8NE9CGUpTclYTT == null;

      internal static AutoDeployService.ExceptionAutoDeployResult CyTHry8NQwmDjFgR7FFS() => (AutoDeployService.ExceptionAutoDeployResult) AutoDeployService.ExceptionAutoDeployResult.zLoWZf8NE9CGUpTclYTT;
    }

    private class ManifestDeployLogger : EleWise.ELMA.Logging.ILogger
    {
      private readonly object deployDirectory;
      private readonly object builder;
      private static object rnjaZ08Nv5ywfDiCaoT7;

      public event EventHandler ConfigurationChanged
      {
        add
        {
          int num = 2;
          EventHandler eventHandler1;
          EventHandler comparand;
          EventHandler eventHandler2;
          while (true)
          {
            switch (num)
            {
              case 1:
                comparand = eventHandler1;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                continue;
              case 2:
                eventHandler1 = this.ConfigurationChanged;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
                continue;
              case 3:
                if (eventHandler1 == comparand)
                {
                  num = 5;
                  continue;
                }
                goto case 1;
              case 4:
                eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
                num = 3;
                continue;
              case 5:
                goto label_2;
              default:
                eventHandler2 = (EventHandler) AutoDeployService.ManifestDeployLogger.d66f818NuYQ004THq5kD((object) comparand, (object) value);
                num = 4;
                continue;
            }
          }
label_2:;
        }
        remove
        {
          int num = 2;
          EventHandler eventHandler1;
          EventHandler comparand;
          EventHandler eventHandler2;
          while (true)
          {
            switch (num)
            {
              case 1:
                comparand = eventHandler1;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                continue;
              case 2:
                eventHandler1 = this.ConfigurationChanged;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                continue;
              case 3:
                goto label_2;
              case 4:
                if (eventHandler1 == comparand)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 3 : 3;
                  continue;
                }
                goto case 1;
              case 5:
                eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.ConfigurationChanged, eventHandler2, comparand);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 4 : 2;
                continue;
              default:
                eventHandler2 = comparand - value;
                num = 5;
                continue;
            }
          }
label_2:;
        }
      }

      public string LogPath => (string) AutoDeployService.ManifestDeployLogger.hw1gDp8NVTLnWdklcQYf(this.deployDirectory, AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(1505778440 - 1981636111 ^ -475631305));

      public bool HasErrors
      {
        get => this.\u003CHasErrors\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CHasErrors\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

      public ManifestDeployLogger(string deployDirectory)
      {
        AutoDeployService.ManifestDeployLogger.oVYv148NSaMtbeGYJw1E();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              AutoDeployService.ManifestDeployLogger.gbwa6l8NijhyktRWITHJ((object) deployDirectory, AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(~-397266137 ^ 396902094));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
              continue;
            case 3:
              this.builder = (object) new StringBuilder();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
              continue;
            default:
              this.deployDirectory = (object) deployDirectory;
              num = 3;
              continue;
          }
        }
label_2:;
      }

      /// <summary>Запись в лог (только внутренний)</summary>
      public void InnerLog(string logItem, EleWise.ELMA.Logging.LogLevel level)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              AutoDeployService.ManifestDeployLogger.rZdMOP8NXSRbArcnsetN(this.builder, AutoDeployService.ManifestDeployLogger.ltU6CZ8NKakO6P8Lg4mE((object) new string[5]
              {
                (string) AutoDeployService.ManifestDeployLogger.Dl8lRF8NRsWp8Q3kjFbH(level),
                (string) AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(-16752921 ^ -16771131),
                AutoDeployService.ManifestDeployLogger.aaIGEE8NqBjp5Ga9KQ9O().ToString((string) AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(~1767720452 ^ -1767822187)),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516853932),
                logItem
              }));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void CompleteDeploy()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              File.WriteAllText(this.LogPath, this.builder.ToString());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool IsEnabled(EleWise.ELMA.Logging.LogLevel level) => true;

      public void Log(EleWise.ELMA.Logging.LogLevel level, Exception exception, string format, params object[] args)
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.InnerLog(format, level);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
              continue;
            case 3:
              this.HasErrors = ((this.HasErrors ? 1 : 0) | (level == EleWise.ELMA.Logging.LogLevel.Error ? 1 : (level == EleWise.ELMA.Logging.LogLevel.Fatal ? 1 : 0))) != 0;
              num = 2;
              continue;
            default:
              AutoDeployService.DeployLog.Log(level, exception, format, args);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
              continue;
          }
        }
label_2:;
      }

      private static string StringifyLogLevel(EleWise.ELMA.Logging.LogLevel level)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              switch (level)
              {
                case EleWise.ELMA.Logging.LogLevel.Verbose:
                  goto label_4;
                case EleWise.ELMA.Logging.LogLevel.Trace:
                  goto label_5;
                case EleWise.ELMA.Logging.LogLevel.Debug:
                  goto label_6;
                case EleWise.ELMA.Logging.LogLevel.Information:
                  goto label_7;
                case EleWise.ELMA.Logging.LogLevel.Warning:
                  goto label_8;
                case EleWise.ELMA.Logging.LogLevel.Error:
                  goto label_9;
                case EleWise.ELMA.Logging.LogLevel.Fatal:
                  goto label_10;
                default:
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                  continue;
              }
            case 2:
              goto label_4;
            default:
              goto label_11;
          }
        }
label_4:
        return (string) AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(-1598106783 - -968262081 ^ -630068380);
label_5:
        return (string) AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(333888594 ^ 1075625116 ^ 1409203866);
label_6:
        return (string) AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(1052221104 - 768835541 ^ 283156665);
label_7:
        return (string) AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(-1822890472 ^ -1822664600);
label_8:
        return (string) AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(-2138958856 ^ -2138657402);
label_9:
        return z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306225704);
label_10:
        return (string) AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(-1204263869 ^ -1341583247 ^ 137743016);
label_11:
        throw new InvalidOperationException((string) AutoDeployService.ManifestDeployLogger.WBJtwc8NIy0burxTLt7m(1514961705 ^ 1514718593));
      }

      internal static object d66f818NuYQ004THq5kD([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

      internal static bool hYraZy8N83aPLh7Rp8Oh() => AutoDeployService.ManifestDeployLogger.rnjaZ08Nv5ywfDiCaoT7 == null;

      internal static AutoDeployService.ManifestDeployLogger mAVD2s8NZmFekE2HtarI() => (AutoDeployService.ManifestDeployLogger) AutoDeployService.ManifestDeployLogger.rnjaZ08Nv5ywfDiCaoT7;

      internal static object WBJtwc8NIy0burxTLt7m(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object hw1gDp8NVTLnWdklcQYf([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

      internal static void oVYv148NSaMtbeGYJw1E() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static void gbwa6l8NijhyktRWITHJ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

      internal static object Dl8lRF8NRsWp8Q3kjFbH(EleWise.ELMA.Logging.LogLevel level) => (object) AutoDeployService.ManifestDeployLogger.StringifyLogLevel(level);

      internal static DateTime aaIGEE8NqBjp5Ga9KQ9O() => DateTime.Now;

      internal static object ltU6CZ8NKakO6P8Lg4mE([In] object obj0) => (object) string.Concat((string[]) obj0);

      internal static object rZdMOP8NXSRbArcnsetN([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);
    }
  }
}
