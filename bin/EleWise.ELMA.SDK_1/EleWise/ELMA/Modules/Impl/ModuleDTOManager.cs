// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.ModuleDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Modules.Impl
{
  /// <summary>Работа с компонентами ElmaStore в дизайнере</summary>
  public class ModuleDTOManager : DTOManager, IModuleDTOManager, IConfigurationService
  {
    internal static ModuleDTOManager AeC5Wu1HuelR5AkqCZE;

    /// <summary>Получить манифесты установленных компонентов</summary>
    /// <returns></returns>
    public virtual IEnumerable<ElmaStoreComponentManifest> GetInstalledComponentManifests() => Locator.GetServiceNotNull<ModuleManager>().GetInstalledComponentManifests();

    /// <summary>Получить манифест системного компонента</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual ElmaStoreComponentManifest GetManifest(string id, out bool installed)
    {
      int num1 = 6;
      ManifestStoreComponentInfo storeComponentInfo;
      object manifest;
      while (true)
      {
        int num2 = num1;
        string id1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              manifest = ModuleDTOManager.vW8eIv1xxPF3HGtLTrW((object) storeComponentInfo);
              if (manifest == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              storeComponentInfo = Locator.GetServiceNotNull<PackageService>().GetStoreComponentsInfo(true).OfType<ManifestStoreComponentInfo>().FirstOrDefault<ManifestStoreComponentInfo>((Func<ManifestStoreComponentInfo, bool>) (c =>
              {
                int num3 = 4;
                while (true)
                {
                  object obj1;
                  switch (num3)
                  {
                    case 1:
                      goto label_4;
                    case 2:
                      goto label_5;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      obj1 = ModuleDTOManager.\u003C\u003Ec__DisplayClass1_0.sOCckufMnt5L9c8e18Mv((object) c);
                      break;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      object obj2 = ModuleDTOManager.\u003C\u003Ec__DisplayClass1_0.ME0sfHfMkm02F2uOtCOw((object) c);
                      if (obj2 == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 3;
                        continue;
                      }
                      obj1 = obj2;
                      break;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!ModuleDTOManager.\u003C\u003Ec__DisplayClass1_0.YB2syHfM26KrlPwxlOR5(ModuleDTOManager.\u003C\u003Ec__DisplayClass1_0.Sln6udfMOkih4Mryam5M((object) c), (object) id1))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 0;
                        continue;
                      }
                      goto label_4;
                  }
                  if (obj1 != null)
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                  else
                    goto label_5;
                }
label_4:
                return true;
label_5:
                return false;
              }));
              num2 = 3;
              continue;
            case 3:
              goto label_9;
            case 4:
              installed = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 1;
              continue;
            case 5:
              id1 = id;
              num2 = 4;
              continue;
            case 6:
              num2 = 5;
              continue;
            case 7:
              installed = storeComponentInfo.IsInstalled;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
              continue;
            default:
              goto label_13;
          }
        }
label_9:
        if (storeComponentInfo != null)
          num1 = 7;
        else
          goto label_14;
      }
label_3:
      return (ElmaStoreComponentManifest) manifest;
label_13:
      return (ElmaStoreComponentManifest) ModuleDTOManager.yPK2Ct10h0yNndkV14w((object) storeComponentInfo);
label_14:
      return (ElmaStoreComponentManifest) null;
    }

    /// <summary>Получить пакеты компонента</summary>
    /// <param name="componentId"></param>
    /// <returns></returns>
    public virtual IEnumerable<PackageManifest> GetComponentPackages(string componentId) => Locator.GetServiceNotNull<ModuleManager>().GetComponentPackages(componentId);

    public ModuleDTOManager()
    {
      ModuleDTOManager.HQNSsS1mTTsiB4xJZPo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object vW8eIv1xxPF3HGtLTrW([In] object obj0) => (object) ((ManifestStoreComponentInfo) obj0).InstalledManifest;

    internal static object yPK2Ct10h0yNndkV14w([In] object obj0) => (object) ((ManifestStoreComponentInfo) obj0).LastManifest;

    internal static bool pUkviv1AUTA82fRBNE6() => ModuleDTOManager.AeC5Wu1HuelR5AkqCZE == null;

    internal static ModuleDTOManager r0tByk17gMlFG1K20p0() => ModuleDTOManager.AeC5Wu1HuelR5AkqCZE;

    internal static void HQNSsS1mTTsiB4xJZPo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
