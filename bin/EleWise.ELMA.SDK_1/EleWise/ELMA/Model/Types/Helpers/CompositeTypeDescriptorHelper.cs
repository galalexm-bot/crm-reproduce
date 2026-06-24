// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.CompositeTypeDescriptorHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Types.Helpers
{
  /// <summary>Helper для составных типов (сущности и перечисления)</summary>
  public static class CompositeTypeDescriptorHelper
  {
    /// <summary>
    /// Получить список дескрипторов типов, распределенных по группам (соотсветсвенно пространству имен)
    /// </summary>
    /// <param name="baseTypeDescriptor">Дескриптор базового типа</param>
    /// <param name="metadataList">Плоский список метаданных</param>
    /// <returns>Список дескрипторов</returns>
    public static IEnumerable<ITypeDescriptor> GetDescriptorsByGroups(
      ITypeDescriptor baseTypeDescriptor,
      List<NamedMetadata> metadataList)
    {
      List<ITypeDescriptor> descriptors = new List<ITypeDescriptor>();
      MetadataTreeHelper.GroupNode metadataGroup = MetadataTreeHelper.BuildTree(metadataList.OfType<ICodeItemMetadata>());
      CompositeTypeDescriptorHelper.FillDescriptors((object) baseTypeDescriptor, descriptors, (object) metadataGroup);
      return (IEnumerable<ITypeDescriptor>) descriptors;
    }

    private static void FillDescriptors(
      object baseTypeDescriptor,
      List<ITypeDescriptor> descriptors,
      object metadataGroup)
    {
      foreach (MetadataTreeHelper.GroupNode groupNode in ((MetadataTreeHelper.GroupNode) metadataGroup).GroupNodes)
      {
        SubTypeGroupDescriptor typeGroupDescriptor = new SubTypeGroupDescriptor(SR.T(groupNode.Name), (ITypeDescriptor) baseTypeDescriptor);
        descriptors.Add((ITypeDescriptor) typeGroupDescriptor);
        CompositeTypeDescriptorHelper.FillDescriptors(baseTypeDescriptor, typeGroupDescriptor.SubTypes, (object) groupNode);
      }
      foreach (MetadataTreeHelper.MetadataNode metadataNode in ((MetadataTreeHelper.GroupNode) metadataGroup).MetadataNodes)
      {
        ICodeItemMetadata metadata = metadataNode.Metadata;
        SubTypeDescriptor subTypeDescriptor = new SubTypeDescriptor((ITypeDescriptor) baseTypeDescriptor, metadata.Uid, metadataNode.Name);
        descriptors.Add((ITypeDescriptor) subTypeDescriptor);
      }
    }
  }
}
