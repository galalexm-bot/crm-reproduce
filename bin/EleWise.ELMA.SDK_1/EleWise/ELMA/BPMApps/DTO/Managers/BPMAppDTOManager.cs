// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.DTO.Managers.BPMAppDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.DTO.Managers
{
  public class BPMAppDTOManager : DTOManager, IBPMAppDTOManager, IConfigurationService
  {
    private readonly IBpmAppService bpmAppService;
    internal static BPMAppDTOManager Uve4QjfnrlHBf5GN1TbX;

    /// <summary>Ctor</summary>
    /// <param name="bpmAppService">Сервис управления BpmApp</param>
    public BPMAppDTOManager(IBpmAppService bpmAppService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.bpmAppService = bpmAppService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public virtual IEnumerable<BPMAppDTO> LoadAll() => this.bpmAppService.LoadAll();

    /// <inheritdoc />
    public virtual BPMAppDTO Save(
      BPMAppDTO bpmApp,
      byte[] helpFileContent,
      byte[] additionalFilesContent)
    {
      return this.bpmAppService.Save(bpmApp, helpFileContent, additionalFilesContent);
    }

    /// <inheritdoc />
    public virtual BPMAppDTO Save(BPMAppDTO bpmApp) => (BPMAppDTO) BPMAppDTOManager.x9sLnvfnjMZaODjesl7h((object) this.bpmAppService, (object) bpmApp);

    /// <inheritdoc />
    public virtual void Delete(long id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BPMAppDTOManager.PxXjdLfnYdx97Ej2mhIA((object) this.bpmAppService, id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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
    public virtual void LoadFiles(
      long id,
      out byte[] helpFileContent,
      out byte[] additionalFilesContent)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.bpmAppService.LoadFiles(id, out helpFileContent, out additionalFilesContent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool yOHBdUfng6c1ZF6jka5G() => BPMAppDTOManager.Uve4QjfnrlHBf5GN1TbX == null;

    internal static BPMAppDTOManager oGuRF0fn51QQxkuVFRHG() => BPMAppDTOManager.Uve4QjfnrlHBf5GN1TbX;

    internal static object x9sLnvfnjMZaODjesl7h([In] object obj0, [In] object obj1) => (object) ((IBpmAppService) obj0).Save((BPMAppDTO) obj1);

    internal static void PxXjdLfnYdx97Ej2mhIA([In] object obj0, long id) => ((IBpmAppService) obj0).Delete(id);
  }
}
