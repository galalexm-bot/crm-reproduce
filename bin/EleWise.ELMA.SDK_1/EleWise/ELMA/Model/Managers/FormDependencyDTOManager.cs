// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.FormDependencyDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.UI.DTO.Managers;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers
{
  public class FormDependencyDTOManager : 
    DTOManager,
    IFormDependencyDTOManager,
    IConfigurationService
  {
    private readonly IFormMetadataItemHeaderDTOManager formMetadataItemHeaderDtoManager;
    internal static FormDependencyDTOManager AGclduhGiOCcFHobVOSw;

    /// <summary>Ctor</summary>
    /// <param name="formMetadataItemHeaderDtoManager"></param>
    public FormDependencyDTOManager(
      IFormMetadataItemHeaderDTOManager formMetadataItemHeaderDtoManager)
    {
      FormDependencyDTOManager.oCYdH8hGKVFvjBIPtmgv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.formMetadataItemHeaderDtoManager = formMetadataItemHeaderDtoManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public virtual IEnumerable<IFormDependencyData> LoadByDependObjectUid(Guid uid) => (IEnumerable<IFormDependencyData>) FormDependencyHelper.LoadByDependObjectUid(uid).ToList<IFormDependencyData>();

    public virtual IEnumerable<IFormDependencyData> LoadByBaseUids(IEnumerable<Guid> baseUids) => (IEnumerable<IFormDependencyData>) FormDependencyHelper.LoadByBaseUids(baseUids).ToList<IFormDependencyData>();

    public virtual IEnumerable<IFormDependencyData> LoadByUsesObjectUid(Guid uid) => FormDependencyHelper.LoadByUsesObjectUid(uid);

    public virtual string GetInterfaceFormDisplayInfo(Guid objectUid, Guid formUid) => (string) FormDependencyDTOManager.R9AfQwhGn4urQMJRLF2t((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787474209), objectUid == PageMetadata.TypeUid ? FormDependencyDTOManager.vwQFj2hGTsqaRE2ySnrx(FormDependencyDTOManager.Vd176khGXypaEVYiU7Mm(-1867198571 ^ -1866995317)) : (object) EleWise.ELMA.SR.T((string) FormDependencyDTOManager.Vd176khGXypaEVYiU7Mm(-643786247 ^ -643579915)), FormDependencyDTOManager.hyW3QlhGkLtk3uKeqjx0((object) this.formMetadataItemHeaderDtoManager, formUid));

    internal static void oCYdH8hGKVFvjBIPtmgv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Mb0JeIhGRQcXLvlB47Zm() => FormDependencyDTOManager.AGclduhGiOCcFHobVOSw == null;

    internal static FormDependencyDTOManager l2I4IEhGq46JmynukyDi() => FormDependencyDTOManager.AGclduhGiOCcFHobVOSw;

    internal static object Vd176khGXypaEVYiU7Mm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vwQFj2hGTsqaRE2ySnrx([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object hyW3QlhGkLtk3uKeqjx0([In] object obj0, Guid uid) => (object) ((IFormMetadataItemHeaderDTOManager) obj0).GetDisplayName(uid);

    internal static object R9AfQwhGn4urQMJRLF2t([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
