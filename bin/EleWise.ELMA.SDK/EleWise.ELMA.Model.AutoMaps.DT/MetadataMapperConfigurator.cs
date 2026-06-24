using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers;

internal sealed class MetadataMapperConfigurator : DefaultMapperConfigurator
{
	private readonly Type metadataTypeRaw;

	private readonly Type[] abstractMetadataTypes;

	private readonly ISearchMetadataService searchMetadataService;

	private static MetadataMapperConfigurator VYHO8Yhxuexv5Qg2Gb43;

	public MetadataMapperConfigurator(ISearchMetadataService searchMetadataService)
	{
		//Discarded unreachable code: IL_009d, IL_00a2
		SingletonReader.JJCZtPuTvSt();
		metadataTypeRaw = TypeOf<IMetadata>.Raw;
		abstractMetadataTypes = new Type[10]
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
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.searchMetadataService = searchMetadataService;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<IInternalMapperConfiguration> Init()
	{
		DataClassMetadata[] dataClassMetadatas = searchMetadataService.GetPublishedDataClasses().ToArray();
		List<IInternalMapperConfiguration> list = new List<IInternalMapperConfiguration>();
		IEnumerable<Type> first = from t in ComponentManager.Current.GetExtensionPointTypes<IXsiType>()
			where metadataTypeRaw.IsAssignableFrom(t)
			select t;
		ProcessMetadataList(first.Concat(abstractMetadataTypes), dataClassMetadatas, list);
		return list;
	}

	private void ProcessMetadataList(IEnumerable<Type> metadataTypes, DataClassMetadata[] dataClassMetadatas, List<IInternalMapperConfiguration> metadataMappers)
	{
		foreach (Type metadataType in metadataTypes)
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			CS_0024_003C_003E8__locals0.metadataTypeName = metadataType.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309804130);
			DataClassMetadata dataClassMetadata = dataClassMetadatas.FirstOrDefault((DataClassMetadata t) => _003C_003Ec__DisplayClass5_0.cVHO6mvw9qga0j28nprf(t.Name, CS_0024_003C_003E8__locals0.metadataTypeName));
			if (dataClassMetadata != null)
			{
				Type type = DefaultMapperConfigurator.DefaultMapperTypeInternal.MakeGenericType(metadataType);
				metadataMappers.Add((IInternalMapperConfiguration)Activator.CreateInstance(type, dataClassMetadata.TypeRef));
			}
		}
	}

	internal static bool O6NSVihxIU6o2h3itahu()
	{
		return VYHO8Yhxuexv5Qg2Gb43 == null;
	}

	internal static MetadataMapperConfigurator hYr3ELhxVHOe0w5L4Nk8()
	{
		return VYHO8Yhxuexv5Qg2Gb43;
	}
}
