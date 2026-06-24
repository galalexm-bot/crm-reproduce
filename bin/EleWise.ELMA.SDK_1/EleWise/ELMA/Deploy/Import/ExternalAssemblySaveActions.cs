// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExternalAssemblySaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import
{
  public class ExternalAssemblySaveActions : EntityImportSaveActions
  {
    /// <summary>
    /// Uid типа сущности ExternalAssembly (ImplementationUid)
    /// </summary>
    public static readonly Guid Uid;
    private static ExternalAssemblySaveActions G0NdHyEmBusNZvVaoLnh;

    public override bool IsSupported(Guid typeGuid) => ExternalAssemblySaveActions.PTOw8vEmbXg0XvB9OM1i(typeGuid, ExternalAssemblySaveActions.Uid);

    public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
    {
      if (entity is IExternalAssembly externalAssembly1)
      {
        IExternalAssemblyFilter filter = InterfaceActivator.Create<IExternalAssemblyFilter>();
        filter.HashCode = externalAssembly1.HashCode;
        IExternalAssembly externalAssembly = ExternalAssemblyManager.Instance.Find((IEntityFilter) filter, (FetchOptions) null).FirstOrDefault<IExternalAssembly>();
        if (externalAssembly != null)
        {
          Dictionary<string, string> dictionary = serviceData;
          Guid uid = externalAssembly1.Uid;
          string key = uid.ToString();
          uid = externalAssembly.Uid;
          string str = uid.ToString();
          dictionary[key] = str;
          externalAssembly1.Uid = externalAssembly.Uid;
        }
      }
      base.ExecSaveActions(entity, serviceData);
    }

    public ExternalAssemblySaveActions()
    {
      ExternalAssemblySaveActions.v4jVtNEmhYuMG51G3ljJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ExternalAssemblySaveActions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExternalAssemblySaveActions.v4jVtNEmhYuMG51G3ljJ();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ExternalAssemblySaveActions.Uid = new Guid((string) ExternalAssemblySaveActions.YpiAdWEmGTtTw3jsm4X8(825385222 ^ 825673800));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool PTOw8vEmbXg0XvB9OM1i([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool n8qmNtEmWMt1xq22NBEY() => ExternalAssemblySaveActions.G0NdHyEmBusNZvVaoLnh == null;

    internal static ExternalAssemblySaveActions wOLoB5Emoev45ZaXj8vu() => ExternalAssemblySaveActions.G0NdHyEmBusNZvVaoLnh;

    internal static void v4jVtNEmhYuMG51G3ljJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object YpiAdWEmGTtTw3jsm4X8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
