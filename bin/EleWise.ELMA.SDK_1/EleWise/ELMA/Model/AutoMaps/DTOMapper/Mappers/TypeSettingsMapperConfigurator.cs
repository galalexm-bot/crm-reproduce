// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers.TypeSettingsMapperConfigurator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers
{
  /// <summary>Конфигуратор мапперов для настроек типов</summary>
  internal sealed class TypeSettingsMapperConfigurator : DefaultMapperConfigurator
  {
    private readonly Type typeSettingsTypeRaw;
    private readonly ISearchMetadataService searchMetadataService;
    private static TypeSettingsMapperConfigurator QcDPRwhxSOgEn3QKGHgf;

    /// <summary>Ctor</summary>
    /// <param name="searchMetadataService">Сервис поиска метаданных</param>
    public TypeSettingsMapperConfigurator(ISearchMetadataService searchMetadataService)
    {
      TypeSettingsMapperConfigurator.fPhMaEhxq7koV0u0lTw5();
      this.typeSettingsTypeRaw = TypeOf<TypeSettings>.Raw;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.searchMetadataService = searchMetadataService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public override IEnumerable<IInternalMapperConfiguration> Init()
    {
      DataClassMetadata[] array = this.searchMetadataService.GetPublishedDataClasses().ToArray<DataClassMetadata>();
      List<IInternalMapperConfiguration> mapperConfigurationList = new List<IInternalMapperConfiguration>();
      foreach (Type type1 in ComponentManager.Current.GetExtensionPointTypes<IXsiType>().Where<Type>((Func<Type, bool>) (t => this.typeSettingsTypeRaw.IsAssignableFrom(t))))
      {
        string typeSettingsTypeName = type1.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45049695);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        DataClassMetadata dataClassMetadata = ((IEnumerable<DataClassMetadata>) array).FirstOrDefault<DataClassMetadata>((Func<DataClassMetadata, bool>) (a => TypeSettingsMapperConfigurator.\u003C\u003Ec__DisplayClass3_0.QLl49GvwjORHmbS9yvPB(TypeSettingsMapperConfigurator.\u003C\u003Ec__DisplayClass3_0.gUyeklvw5mTsvrVCSdXv((object) a), (object) typeSettingsTypeName)));
        if (dataClassMetadata != null)
        {
          Type type2 = DefaultMapperConfigurator.DefaultMapperTypeInternal.MakeGenericType(type1);
          mapperConfigurationList.Add((IInternalMapperConfiguration) Activator.CreateInstance(type2, (object) dataClassMetadata.TypeRef));
        }
      }
      return (IEnumerable<IInternalMapperConfiguration>) mapperConfigurationList;
    }

    internal static void fPhMaEhxq7koV0u0lTw5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool eNQbdwhxiw4TJNtLOdoG() => TypeSettingsMapperConfigurator.QcDPRwhxSOgEn3QKGHgf == null;

    internal static TypeSettingsMapperConfigurator aVm5FmhxRZJEnwkZIjSI() => TypeSettingsMapperConfigurator.QcDPRwhxSOgEn3QKGHgf;
  }
}
