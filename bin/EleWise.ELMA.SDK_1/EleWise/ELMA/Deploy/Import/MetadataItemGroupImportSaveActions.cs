// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.MetadataItemGroupImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>
  /// 
  /// </summary>
  public class MetadataItemGroupImportSaveActions : EntityImportSaveActions
  {
    /// <summary>UID типа сущности matadataItemHeader</summary>
    public static readonly Guid UID;
    private static MetadataItemGroupImportSaveActions Sbxhm4EyGrk9fqcGePcD;

    public override bool IsSupported(Guid typeGuid) => MetadataItemGroupImportSaveActions.bP8mZMEyQlNVcNL85HAJ(typeGuid, MetadataItemGroupImportSaveActions.UID);

    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      Guid result = Guid.Empty;
      if (propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479462786)) && propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852874190)] != null)
        Guid.TryParse(((Dictionary<string, object>) propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132941065)])[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978482848)].ToString(), out result);
      if (result != Guid.Empty)
      {
        string keyString = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239864986) + (object) result;
        if (data.ServiceData.ContainsKey(keyString) && !Guid.TryParse(data.ServiceData[keyString], out Guid _))
        {
          List<IMetadataItemGroup> list = EntityManager<IMetadataItemGroup>.Instance.Find((Expression<Func<IMetadataItemGroup, bool>>) (metadataItemGroup => metadataItemGroup.Namespace == data.ServiceData[keyString])).ToList<IMetadataItemGroup>();
          if (list.Count > 0 && list[0] != null)
            ((Dictionary<string, object>) propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909140823)])[z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909155571)] = (object) list[0].Uid.ToString();
        }
      }
      return true;
    }

    public MetadataItemGroupImportSaveActions()
    {
      MetadataItemGroupImportSaveActions.hdm9tqEyCaM1jlCHf0jL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static MetadataItemGroupImportSaveActions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            MetadataItemGroupImportSaveActions.hdm9tqEyCaM1jlCHf0jL();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            MetadataItemGroupImportSaveActions.UID = new Guid((string) MetadataItemGroupImportSaveActions.ywuGPJEyvKobvidd3Yi9(272623989 ^ 272319565));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool bP8mZMEyQlNVcNL85HAJ([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool J3dNUSEyEPJCnwk2LSYq() => MetadataItemGroupImportSaveActions.Sbxhm4EyGrk9fqcGePcD == null;

    internal static MetadataItemGroupImportSaveActions YywwvmEyfo91TG7OFlrm() => MetadataItemGroupImportSaveActions.Sbxhm4EyGrk9fqcGePcD;

    internal static void hdm9tqEyCaM1jlCHf0jL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object ywuGPJEyvKobvidd3Yi9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
