// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.ViewItemsAnalyzerHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Dependencies.Analyzers
{
  /// <summary>Помощник для анализаторов элементов представлений</summary>
  internal static class ViewItemsAnalyzerHelper
  {
    private static IEnumerable<IAdditionalProcessMetadataExtension> additionalProcessMetadataExtensions;

    private static IEnumerable<IAdditionalProcessMetadataExtension> AdditionalProcessMetadataExtensions => ViewItemsAnalyzerHelper.additionalProcessMetadataExtensions ?? (ViewItemsAnalyzerHelper.additionalProcessMetadataExtensions = Locator.GetServiceNotNull<IEnumerable<IAdditionalProcessMetadataExtension>>());

    /// <summary>Анализ, когда нет родительских свойств</summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="rootMetadata">Корневые медатанные</param>
    /// <param name="options">Настройки</param>
    /// <param name="enumDependencies">Зависимости от перечислений</param>
    /// <param name="entityDependencies">Зависимости отсущностей</param>
    /// <param name="dataClassDependencies">Зависимости от структур обмена данными</param>
    /// <returns>Метаданные объекта свойства и метаданные свойства</returns>
    internal static (ClassMetadata, IPropertyMetadata) CaseZeroPropertyParents(
      Guid propertyUid,
      ClassMetadata rootMetadata,
      DependencyServiceOptions options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
      // ISSUE: reference to a compiler-generated method
      PropertyMetadata propertyMetadata = rootMetadata.Properties.Find((Predicate<PropertyMetadata>) (p => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass3_0.VfIdgtvonVyQSYwfhhkt(p.Uid, propertyUid)));
      if (propertyMetadata == null || propertyMetadata.SubTypeUid == Guid.Empty)
        return ((ClassMetadata) null, (IPropertyMetadata) null);
      IMetadata metadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid);
      if (metadata != null)
      {
        DependencyServiceHelper.ProcessMetadata(rootMetadata.ModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies);
        ViewItemsAnalyzerHelper.ProcessAdditionalMetadata((object) propertyMetadata, rootMetadata.ModuleUid, (object) options, enumDependencies, entityDependencies, dataClassDependencies);
      }
      return (metadata as ClassMetadata, (IPropertyMetadata) propertyMetadata);
    }

    /// <summary>Анализ, когда одно родительское свойство</summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="propertyParents">Родительские свойства</param>
    /// <param name="rootMetadata">Корневые медатанные</param>
    /// <param name="options">Настройки</param>
    /// <param name="enumDependencies">Зависимости от перечислений</param>
    /// <param name="entityDependencies">Зависимости отсущностей</param>
    /// <param name="dataClassDependencies">Зависимости от структур обмена данными</param>
    /// <returns>Метаданные объекта свойства и метаданные свойства</returns>
    internal static (ClassMetadata, IPropertyMetadata) CaseOnePropertyParents(
      Guid propertyUid,
      Guid[] propertyParents,
      ClassMetadata rootMetadata,
      DependencyServiceOptions options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
      Guid parentUid = propertyParents[0];
      if (parentUid == Guid.Empty)
        return ((ClassMetadata) null, (IPropertyMetadata) null);
      Guid moduleUid = rootMetadata.ModuleUid;
      // ISSUE: reference to a compiler-generated method
      PropertyMetadata propertyMetadata1 = rootMetadata.Properties.Find((Predicate<PropertyMetadata>) (property => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass4_0.OURSqFvo1QRhZP3Rmx8V((object) property) == parentUid));
      if (propertyMetadata1 != null)
      {
        if (!(MetadataServiceContext.Service.GetMetadata(propertyMetadata1.SubTypeUid) is ClassMetadata metadata2))
          return ((ClassMetadata) null, (IPropertyMetadata) null);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PropertyMetadata propertyMetadata2 = metadata2.Properties.Find((Predicate<PropertyMetadata>) (property => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass4_0.PRhflmvoNMHmHM4GvaEN(ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass4_0.OURSqFvo1QRhZP3Rmx8V((object) property), propertyUid)));
        if (propertyMetadata2 == null)
        {
          if (!(metadata2 is EntityMetadata) || !(metadata2.BaseClassUid != Guid.Empty))
            return ((ClassMetadata) null, (IPropertyMetadata) null);
          while (MetadataServiceContext.Service.GetMetadata(metadata2.BaseClassUid) is ClassMetadata metadata2)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            propertyMetadata2 = metadata2.Properties.Find((Predicate<PropertyMetadata>) (property => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass4_0.PRhflmvoNMHmHM4GvaEN(ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass4_0.OURSqFvo1QRhZP3Rmx8V((object) property), propertyUid)));
            if (propertyMetadata2 != null || metadata2.BaseClassUid == Guid.Empty)
              break;
          }
        }
        if (propertyMetadata2 == null)
          return ((ClassMetadata) null, (IPropertyMetadata) null);
        DependencyServiceHelper.ProcessMetadata(moduleUid, (IMetadata) metadata2, options, enumDependencies, entityDependencies, dataClassDependencies, (IPropertyMetadata) propertyMetadata2);
        IMetadata metadata3 = (IMetadata) null;
        if (propertyMetadata2.SubTypeUid != Guid.Empty)
        {
          metadata3 = MetadataServiceContext.Service.GetMetadata(propertyMetadata2.SubTypeUid);
          if (metadata3 != null)
          {
            DependencyServiceHelper.ProcessMetadata(moduleUid, metadata3, options, enumDependencies, entityDependencies, dataClassDependencies);
            ViewItemsAnalyzerHelper.ProcessAdditionalMetadata((object) propertyMetadata2, moduleUid, (object) options, enumDependencies, entityDependencies, dataClassDependencies);
          }
        }
        return (metadata3 as ClassMetadata, (IPropertyMetadata) propertyMetadata2);
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (MetadataServiceContext.Service.GetMetadataList().FirstOrDefault<IMetadata>((Func<IMetadata, bool>) (m => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass4_0.PRhflmvoNMHmHM4GvaEN(ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass4_0.wEGRnBvo3dIXaqKhuyih((object) m), parentUid))) is ClassMetadata classMetadata)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PropertyMetadata propertyMetadata3 = classMetadata.Properties.Find((Predicate<PropertyMetadata>) (property => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass4_0.PRhflmvoNMHmHM4GvaEN(ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass4_0.OURSqFvo1QRhZP3Rmx8V((object) property), propertyUid)));
        if (propertyMetadata3 != null)
        {
          DependencyServiceHelper.ProcessMetadata(moduleUid, (IMetadata) classMetadata, options, enumDependencies, entityDependencies, dataClassDependencies, (IPropertyMetadata) propertyMetadata3);
          IMetadata metadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata3.SubTypeUid);
          if (metadata != null)
          {
            DependencyServiceHelper.ProcessMetadata(moduleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies);
            ViewItemsAnalyzerHelper.ProcessAdditionalMetadata((object) propertyMetadata3, moduleUid, (object) options, enumDependencies, entityDependencies, dataClassDependencies);
          }
          return (metadata as ClassMetadata, (IPropertyMetadata) propertyMetadata3);
        }
      }
      return ((ClassMetadata) null, (IPropertyMetadata) null);
    }

    /// <summary>Анализ, когда много родительских свойств</summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="propertyParents">Родительские свойства</param>
    /// <param name="rootMetadata">Корневые медатанные</param>
    /// <param name="options">Настройки</param>
    /// <param name="enumDependencies">Зависимости от перечислений</param>
    /// <param name="entityDependencies">Зависимости отсущностей</param>
    /// <param name="dataClassDependencies">Зависимости от структур обмена данными</param>
    /// <returns>Метаданные объекта свойства и метаданные свойства</returns>
    internal static (ClassMetadata, IPropertyMetadata) CaseDefaultPropertyParents(
      Guid propertyUid,
      Guid[] propertyParents,
      ClassMetadata rootMetadata,
      DependencyServiceOptions options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
      Guid moduleUid = rootMetadata.ModuleUid;
      ClassMetadata classMetadata = rootMetadata;
      foreach (Guid propertyParent in propertyParents)
      {
        Guid parentUid = propertyParent;
        IPropertyMetadata propertyMetadata;
        if (classMetadata is EntityMetadata entityMetadata)
        {
          // ISSUE: reference to a compiler-generated method
          propertyMetadata = entityMetadata.GetPropertiesAndTablePartsWithoutSort().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_1.OLuZvLvo0qq67WyB0ur6((object) prop) == parentUid));
          if (propertyMetadata == null && (entityMetadata.Type == EntityMetadataType.Interface || entityMetadata.Type == EntityMetadataType.InterfaceExtension))
          {
            while (MetadataServiceContext.Service.GetMetadata(classMetadata.BaseClassUid) is EntityMetadata metadata)
            {
              classMetadata = (ClassMetadata) metadata;
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata = metadata.GetPropertiesAndTablePartsWithoutSort().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_1.tjteSZvomkqTnVae934e(ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_1.OLuZvLvo0qq67WyB0ur6((object) prop), parentUid)));
              if (propertyMetadata != null || classMetadata.BaseClassUid == Guid.Empty)
                break;
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          propertyMetadata = (IPropertyMetadata) classMetadata.Properties.Find((Predicate<PropertyMetadata>) (prop => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_1.tjteSZvomkqTnVae934e(ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_1.o7PtNavoyNohMLMKCJbG((object) prop), parentUid)));
        }
        if (propertyMetadata != null)
        {
          if (rootMetadata != classMetadata)
            DependencyServiceHelper.ProcessMetadata(moduleUid, (IMetadata) classMetadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata);
          if (propertyMetadata is TablePartMetadata tablePartMetadata)
          {
            classMetadata = (ClassMetadata) tablePartMetadata;
          }
          else
          {
            if (!(MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid) is ClassMetadata metadata))
              return ((ClassMetadata) null, (IPropertyMetadata) null);
            DependencyServiceHelper.ProcessMetadata(moduleUid, (IMetadata) metadata, options, enumDependencies, entityDependencies, dataClassDependencies);
            classMetadata = metadata;
          }
        }
        else
        {
          if (!(classMetadata is DataClassMetadata dataClassMetadata) || dataClassMetadata.IncludeList.Count == 0)
            return ((ClassMetadata) null, (IPropertyMetadata) null);
          if (!DependencyServiceHelper.SkipDependency((IMetadata) dataClassMetadata, moduleUid, options))
            DependencyServiceHelper.AddClassDependency<DataClassDependency, DataClassMetadata>((IDictionary<Guid, DataClassDependency>) dataClassDependencies, dataClassMetadata.Uid, dataClassMetadata, (Func<DataClassMetadata, DataClassDependency>) (m => m.GetSignature(true)));
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          DataClassDependency dataClassDependency = dataClassMetadata.IncludeList.FirstOrDefault<DataClassDependency>((Func<DataClassDependency, bool>) (i => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_1.tjteSZvomkqTnVae934e(ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_1.d3rdaEvoMZH47aHSXtt0((object) i), parentUid)));
          if (dataClassDependency == null)
            return ((ClassMetadata) null, (IPropertyMetadata) null);
          if (!(MetadataServiceContext.Service.GetMetadata(dataClassDependency.HeaderUid) is DataClassMetadata metadata))
            return ((ClassMetadata) null, (IPropertyMetadata) null);
          DependencyServiceHelper.ProcessMetadata(moduleUid, (IMetadata) metadata, options, enumDependencies, entityDependencies, dataClassDependencies);
          classMetadata = (ClassMetadata) metadata;
        }
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IPropertyMetadata propertyMetadata1 = !(classMetadata is EntityMetadata entityMetadata1) ? (IPropertyMetadata) classMetadata.Properties.Find((Predicate<PropertyMetadata>) (prop => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_0.LlEGw5vo4cycP9IhjdlS(ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_0.p87teTvo6xIQ9mEyIoSv((object) prop), propertyUid))) : entityMetadata1.GetPropertiesAndTablePartsWithoutSort().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_0.LlEGw5vo4cycP9IhjdlS(ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass5_0.PUZtHrvowEiNGe1Iwmr8((object) prop), propertyUid)));
      if (propertyMetadata1 == null)
        return ((ClassMetadata) null, (IPropertyMetadata) null);
      IMetadata metadata1 = (IMetadata) null;
      if (propertyMetadata1.SubTypeUid != Guid.Empty)
      {
        metadata1 = MetadataServiceContext.Service.GetMetadata(propertyMetadata1.SubTypeUid);
        if (metadata1 != null)
        {
          DependencyServiceHelper.ProcessMetadata(moduleUid, metadata1, options, enumDependencies, entityDependencies, dataClassDependencies);
          ViewItemsAnalyzerHelper.ProcessAdditionalMetadata((object) propertyMetadata1, moduleUid, (object) options, enumDependencies, entityDependencies, dataClassDependencies);
        }
      }
      switch (classMetadata)
      {
        case EntityMetadata metadata2:
          Guid metadataUid = metadata2.Type == EntityMetadataType.Interface || metadata2.Type == EntityMetadataType.InterfaceExtension ? metadata2.ImplementationUid : metadata2.Uid;
          DependencyServiceHelper.AddClassDependency<EntityDependency, EntityMetadata>((IDictionary<Guid, EntityDependency>) entityDependencies, metadataUid, metadata2, (Func<EntityMetadata, EntityDependency>) (m => m.GetSignature(true)), propertyMetadata1);
          break;
        case DataClassMetadata dataClassMetadata1:
          if (!DependencyServiceHelper.SkipDependency((IMetadata) dataClassMetadata1, moduleUid, options))
          {
            DependencyServiceHelper.AddClassDependency<DataClassDependency, DataClassMetadata>((IDictionary<Guid, DataClassDependency>) dataClassDependencies, dataClassMetadata1.Uid, dataClassMetadata1, (Func<DataClassMetadata, DataClassDependency>) (m => m.GetSignature(true)), propertyMetadata1);
            break;
          }
          break;
      }
      return (metadata1 as ClassMetadata, propertyMetadata1);
    }

    private static void ProcessAdditionalMetadata(
      object propertyMetadata,
      Guid currentModuleUid,
      object options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
      IPropertyMetadata propertyMetadata1 = (IPropertyMetadata) propertyMetadata;
      // ISSUE: reference to a compiler-generated method
      (propertyMetadata1 != null ? ViewItemsAnalyzerHelper.AdditionalProcessMetadataExtensions.FirstOrDefault<IAdditionalProcessMetadataExtension>((Func<IAdditionalProcessMetadataExtension, bool>) (e => ViewItemsAnalyzerHelper.\u003C\u003Ec__DisplayClass6_0.oG60AIvoYshTqY0Q42NA((object) e, (object) propertyMetadata1))) : (IAdditionalProcessMetadataExtension) null)?.ProcessMetadata(propertyMetadata1, currentModuleUid, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
    }
  }
}
