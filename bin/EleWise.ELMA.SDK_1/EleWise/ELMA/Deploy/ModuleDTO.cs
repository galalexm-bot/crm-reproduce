// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ModuleDTO
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Deploy
{
  [XmlRoot]
  [Serializable]
  public class ModuleDTO
  {
    private static ModuleDTO q0PqVMEedNNbZU87HZGX;

    [XmlElement("Id")]
    public string Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    [XmlElement("Uid")]
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    [XmlElement("Title")]
    public string Title
    {
      get => this.\u003CTitle\u003Ek__BackingField;
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
              this.\u003CTitle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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

    [XmlElement("Description")]
    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
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

    [XmlElement("Version")]
    public string Version
    {
      get => this.\u003CVersion\u003Ek__BackingField;
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
              this.\u003CVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

    [XmlElement("Author")]
    public string Author
    {
      get => this.\u003CAuthor\u003Ek__BackingField;
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
              this.\u003CAuthor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

    [XmlElement("WebSite")]
    public string WebSite
    {
      get => this.\u003CWebSite\u003Ek__BackingField;
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
              this.\u003CWebSite\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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

    [XmlElement("HtmlDescription")]
    public string HtmlDescription
    {
      get => this.\u003CHtmlDescription\u003Ek__BackingField;
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
              this.\u003CHtmlDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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

    public static ModuleDTO CreateFrom(IModule module)
    {
      ModuleDTO from = new ModuleDTO();
      ModuleDTO.IUCPJCEegScjffLE7TRj((object) from, (object) module.Author);
      ModuleDTO.rPv3jFEejKlBYaUBSPnc((object) from, ModuleDTO.VpNrdBEe56xO1f4j5Urb((object) module));
      ModuleDTO.IfZZrjEeLBR411iwHqd2((object) from, ModuleDTO.UmX5PxEeYapbiXunPaNG((object) module));
      ModuleDTO.lWHooEEesGI4RYtky9bc((object) from, ModuleDTO.T04IbQEeU3Xl9V0bFTDE((object) module));
      from.Title = ModuleDTO.p4sMZTEezQLtXtjCOkoG(ModuleDTO.W0IRMmEecLYxyRNXmfSG((object) module)) ? module.Id : (string) ModuleDTO.W0IRMmEecLYxyRNXmfSG((object) module);
      ModuleDTO.GVt1DHEPBxMAKnVqlBNp((object) from, ModuleDTO.kZ1k7pEPFgO8vEv1wMD3((object) module));
      from.Version = (string) ModuleDTO.uxGamNEPWFuyA11V5XbT((object) module);
      ModuleDTO.LrEnSjEPofK7YRKEYDW1((object) from, (object) module.WebSite);
      return from;
    }

    public static ModuleDTO CreateFrom(IApplicationUnit unit)
    {
      ModuleDTO from = new ModuleDTO();
      ModuleDTO.IUCPJCEegScjffLE7TRj((object) from, ModuleDTO.rS0eplEPbPGFnRP5bpEC((object) unit));
      ModuleDTO.rPv3jFEejKlBYaUBSPnc((object) from, (object) unit.Description);
      ModuleDTO.lWHooEEesGI4RYtky9bc((object) from, ModuleDTO.T04IbQEeU3Xl9V0bFTDE((object) unit));
      ModuleDTO.CR5w2TEPhghBLkIwZPna((object) from, !ModuleDTO.p4sMZTEezQLtXtjCOkoG(ModuleDTO.W0IRMmEecLYxyRNXmfSG((object) unit)) ? (object) unit.Title : (object) unit.Id);
      ModuleDTO.GVt1DHEPBxMAKnVqlBNp((object) from, ModuleDTO.kZ1k7pEPFgO8vEv1wMD3((object) unit));
      ModuleDTO.vBedxNEPGMA4AgouP4P1((object) from, ModuleDTO.uxGamNEPWFuyA11V5XbT((object) unit));
      return from;
    }

    public ModuleDTO()
    {
      ModuleDTO.Re8LV8EPEQIgxNoVXh1V();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Gb0qHoEelOT2Qy6cJZpW() => ModuleDTO.q0PqVMEedNNbZU87HZGX == null;

    internal static ModuleDTO Igi9aTEer15313hC3Bqm() => ModuleDTO.q0PqVMEedNNbZU87HZGX;

    internal static void IUCPJCEegScjffLE7TRj([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).Author = (string) obj1;

    internal static object VpNrdBEe56xO1f4j5Urb([In] object obj0) => (object) ((IApplicationUnit) obj0).Description;

    internal static void rPv3jFEejKlBYaUBSPnc([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).Description = (string) obj1;

    internal static object UmX5PxEeYapbiXunPaNG([In] object obj0) => (object) ((IModule) obj0).HtmlDescription;

    internal static void IfZZrjEeLBR411iwHqd2([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).HtmlDescription = (string) obj1;

    internal static object T04IbQEeU3Xl9V0bFTDE([In] object obj0) => (object) ((IApplicationUnit) obj0).Id;

    internal static void lWHooEEesGI4RYtky9bc([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).Id = (string) obj1;

    internal static object W0IRMmEecLYxyRNXmfSG([In] object obj0) => (object) ((IApplicationUnit) obj0).Title;

    internal static bool p4sMZTEezQLtXtjCOkoG([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static Guid kZ1k7pEPFgO8vEv1wMD3([In] object obj0) => ((IApplicationUnit) obj0).Uid;

    internal static void GVt1DHEPBxMAKnVqlBNp([In] object obj0, Guid value) => ((ModuleDTO) obj0).Uid = value;

    internal static object uxGamNEPWFuyA11V5XbT([In] object obj0) => (object) ((IApplicationUnit) obj0).Version;

    internal static void LrEnSjEPofK7YRKEYDW1([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).WebSite = (string) obj1;

    internal static object rS0eplEPbPGFnRP5bpEC([In] object obj0) => (object) ((IApplicationUnit) obj0).Author;

    internal static void CR5w2TEPhghBLkIwZPna([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).Title = (string) obj1;

    internal static void vBedxNEPGMA4AgouP4P1([In] object obj0, [In] object obj1) => ((ModuleDTO) obj0).Version = (string) obj1;

    internal static void Re8LV8EPEQIgxNoVXh1V() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
