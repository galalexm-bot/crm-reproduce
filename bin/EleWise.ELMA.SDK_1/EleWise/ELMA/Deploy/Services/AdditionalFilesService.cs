// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.AdditionalFilesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Services
{
  /// <inheritdoc />
  [Service]
  internal class AdditionalFilesService : IAdditionalFilesService
  {
    private IExportImportFileService exportImportFileService;
    private readonly IRuntimeApplication runtimeApplication;
    private static AdditionalFilesService hQNaPfE4KdBOMBNNnXH5;

    /// <summary>Ctor</summary>
    /// <param name="exportImportFileService">Сервис передачи файлов экспорта-импорта</param>
    /// <param name="runtimeApplication">Среда исполнения приложения</param>
    public AdditionalFilesService(
      IExportImportFileService exportImportFileService,
      IRuntimeApplication runtimeApplication)
    {
      AdditionalFilesService.ExYOvME4kb72vFGtUEIT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.runtimeApplication = runtimeApplication;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          default:
            this.exportImportFileService = exportImportFileService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public string GetHelpFilePath(string fileName, string helpFileName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!string.IsNullOrEmpty(helpFileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) AdditionalFilesService.f7QhgOE4OBSy1C98hrBS(AdditionalFilesService.KmWRlnE4n5m7FtUYvT6t((object) this.exportImportFileService, (object) fileName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319190130)), (object) helpFileName);
label_3:
      return string.Empty;
    }

    /// <inheritdoc />
    public string GetStoreAdditionalFilesPath(ElmaStoreComponentManifest manifest)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AdditionalFilesService.X9LXvvE4eUQ00ig9rUc5((object) manifest, AdditionalFilesService.NvRy8BE42A5XepZJgJjV(1654249598 >> 2 ^ 413534233));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) AdditionalFilesService.mI0SGbE4aoLw7ltTv9md((object) Path.GetDirectoryName((string) AdditionalFilesService.YF6goUE4NoQPNlAp0Pfl(AdditionalFilesService.bmGA1UE41KPtN3yOcrwj(AdditionalFilesService.mnH0FCE4PQEnqy2JqCfb((object) this.runtimeApplication)))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574033396), AdditionalFilesService.EOIYUfE43LXDX4QVvpnR((object) manifest), AdditionalFilesService.x8f58SE4p8IisM3EMRM9((object) manifest));
    }

    /// <inheritdoc />
    public string GetStoreAdditionalFilesPathMessage(ElmaStoreComponentManifest manifest)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AdditionalFilesService.X9LXvvE4eUQ00ig9rUc5((object) manifest, AdditionalFilesService.NvRy8BE42A5XepZJgJjV(372753449 ^ 372750895));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138246069), (object) manifest.Title, (object) this.GetStoreAdditionalFilesPath(manifest));
    }

    internal static void ExYOvME4kb72vFGtUEIT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool e80SXxE4XpGhAyhwE3cj() => AdditionalFilesService.hQNaPfE4KdBOMBNNnXH5 == null;

    internal static AdditionalFilesService wnTW2ZE4TI6s1oqmW8EY() => AdditionalFilesService.hQNaPfE4KdBOMBNNnXH5;

    internal static object KmWRlnE4n5m7FtUYvT6t([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IExportImportFileService) obj0).CreateDeployFolderName((string) obj1, (string) obj2);

    internal static object f7QhgOE4OBSy1C98hrBS([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object NvRy8BE42A5XepZJgJjV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void X9LXvvE4eUQ00ig9rUc5([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object mnH0FCE4PQEnqy2JqCfb([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object bmGA1UE41KPtN3yOcrwj([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

    internal static object YF6goUE4NoQPNlAp0Pfl([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).FilePath;

    internal static object EOIYUfE43LXDX4QVvpnR([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

    internal static object x8f58SE4p8IisM3EMRM9([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Version;

    internal static object mI0SGbE4aoLw7ltTv9md(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) Path.Combine((string) obj0, (string) obj1, (string) obj2, (string) obj3);
    }
  }
}
