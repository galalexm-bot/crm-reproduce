// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers.MetadataMapperConfigurator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers
{
  /// <summary>Конфигуратор мапперов для метаданных</summary>
  internal sealed class MetadataMapperConfigurator : DefaultMapperConfigurator
  {
    private readonly Type metadataTypeRaw;
    private readonly Type[] abstractMetadataTypes;
    private readonly ISearchMetadataService searchMetadataService;
    private static MetadataMapperConfigurator VYHO8Yhxuexv5Qg2Gb43;

    /// <summary>Ctor</summary>
    /// <param name="searchMetadataService">Сервис поиска метаданных</param>
    public MetadataMapperConfigurator(ISearchMetadataService searchMetadataService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.metadataTypeRaw = TypeOf<IMetadata>.Raw;
      this.abstractMetadataTypes = new Type[10]
      {
        TypeOf<AbstractMetadata>.Raw,
        TypeOf<NamedMetadata>.Raw,
        TypeOf<INamedMetadata>.Raw,
        TypeOf<ICodeItemMetadata>.Raw,
        TypeOf<IOrderedMetadata>.Raw,
        TypeOf<ITablePartMetadata>.Raw,
        TypeOf<IPropertyMetadata>.Raw,
        TypeOf<IGroupedMetadata>.Raw,
        TypeOf<IEntityMetadata>.Raw,
        TypeOf<IMetadata>.Raw
      };
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.searchMetadataService = searchMetadataService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override IEnumerable<IInternalMapperConfiguration> Init()
    {
      DataClassMetadata[] array = this.searchMetadataService.GetPublishedDataClasses().ToArray<DataClassMetadata>();
      List<IInternalMapperConfiguration> metadataMappers = new List<IInternalMapperConfiguration>();
      this.ProcessMetadataList(ComponentManager.Current.GetExtensionPointTypes<IXsiType>().Where<Type>((Func<Type, bool>) (t => this.metadataTypeRaw.IsAssignableFrom(t))).Concat<Type>((IEnumerable<Type>) this.abstractMetadataTypes), array, metadataMappers);
      return (IEnumerable<IInternalMapperConfiguration>) metadataMappers;
    }

    private void ProcessMetadataList(
      IEnumerable<Type> metadataTypes,
      DataClassMetadata[] dataClassMetadatas,
      List<IInternalMapperConfiguration> metadataMappers)
    {
      foreach (Type metadataType in metadataTypes)
      {
        string metadataTypeName = metadataType.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309804130);
        // ISSUE: reference to a compiler-generated method
        DataClassMetadata dataClassMetadata = ((IEnumerable<DataClassMetadata>) dataClassMetadatas).FirstOrDefault<DataClassMetadata>((Func<DataClassMetadata, bool>) (t => MetadataMapperConfigurator.\u003C\u003Ec__DisplayClass5_0.cVHO6mvw9qga0j28nprf((object) t.Name, (object) metadataTypeName)));
        if (dataClassMetadata != null)
        {
          Type type = DefaultMapperConfigurator.DefaultMapperTypeInternal.MakeGenericType(metadataType);
          metadataMappers.Add((IInternalMapperConfiguration) Activator.CreateInstance(type, (object) dataClassMetadata.TypeRef));
        }
      }
    }

    internal static bool O6NSVihxIU6o2h3itahu() => MetadataMapperConfigurator.VYHO8Yhxuexv5Qg2Gb43 == null;

    internal static MetadataMapperConfigurator hYr3ELhxVHOe0w5L4Nk8() => MetadataMapperConfigurator.VYHO8Yhxuexv5Qg2Gb43;
  }
}
