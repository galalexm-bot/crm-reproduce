// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.DTO.Managers.IWebApplicationDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.Files.DTO.Managers
{
  /// <summary>Менеджер файлов в WebApplication</summary>
  public interface IWebApplicationDTOManager : IConfigurationService
  {
    IEnumerable<string> GetViewsTree(string prefix, bool isProperty);

    IEnumerable<WebFileDTO> GetFilePlaces(
      string partialViewName,
      IPropertyMetadata propertyMetadata);

    void SaveFiles(IEnumerable<ConfigurationFileDTO> filePlace);

    void CopyFiles(string oldPartialViewName, string newPartialViewName, bool isProperty);

    IEnumerable<string> GetExportViewsTree();

    bool CheckViewExists(string partialViewName, bool isProperty);
  }
}
