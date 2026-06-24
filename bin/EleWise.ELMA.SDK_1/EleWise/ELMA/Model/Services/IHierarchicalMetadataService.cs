// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IHierarchicalMetadataService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services
{
  [ExtensionPoint(ComponentType.All)]
  public interface IHierarchicalMetadataService
  {
    string ProcessingParentForForm(
      Guid propertyUid,
      Guid propertyTypeUid,
      Guid propertySubTypeUid,
      RelationType? relationType,
      EntityMetadata entityMd);

    List<KeyValuePair<string, int>> ProcessingChildsForForm(
      Guid propertyUid,
      Guid propertyTypeUid,
      Guid propertySubTypeUid,
      RelationType? relationType,
      EntityMetadata entityMd);

    /// <summary>
    /// Может ли быть родителем в общем случае (для дизайнера)
    /// </summary>
    Dictionary<Guid, string> CanBeParentForChild(
      Guid propertyUid,
      Guid propertyTypeUid,
      Guid propertySubTypeUid,
      RelationType? relationType,
      ClassMetadata entityMd);

    /// <summary>
    /// Может ли быть зависимым в общем случае (для дизайнера)
    /// </summary>
    bool CanBeChild(Guid propertyTypeUid, Guid propertySubTypeUid, RelationType? relationType);

    /// <summary>Может ли быть родителем</summary>
    Dictionary<Guid, string> CanBeParentForChild(
      PropertyMetadata propertyMetadata,
      ClassMetadata entityMd);

    /// <summary>Может ли быть зависимым</summary>
    bool CanBeChild(PropertyMetadata propertyMetadata);

    Dictionary<long, string> GetAllHierarchicalEntities(
      IEntityMetadata metadata,
      long? parentId,
      int indent,
      int deep);
  }
}
