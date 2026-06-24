// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.Managers.IFormMetadataItemDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.UI.DTO.Models;

namespace EleWise.ELMA.UI.DTO.Managers
{
  public interface IFormMetadataItemDTOManager : IConfigurationService
  {
    FormMetadataItemDTO Load(long id);

    FormMetadataItemDTO Save(FormMetadataItemDTO objDto);

    void Publish(long headerId, string comment, bool forEmulation);

    void Publish(long[] headerIds, string comment);
  }
}
