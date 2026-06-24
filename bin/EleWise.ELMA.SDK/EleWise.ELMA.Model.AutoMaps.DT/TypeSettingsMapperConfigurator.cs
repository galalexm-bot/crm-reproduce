using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers;

internal sealed class TypeSettingsMapperConfigurator : DefaultMapperConfigurator
{
	private readonly Type typeSettingsTypeRaw;

	private readonly ISearchMetadataService searchMetadataService;

	private static TypeSettingsMapperConfigurator QcDPRwhxSOgEn3QKGHgf;

	public TypeSettingsMapperConfigurator(ISearchMetadataService searchMetadataService)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		fPhMaEhxq7koV0u0lTw5();
		typeSettingsTypeRaw = TypeOf<TypeSettings>.Raw;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.searchMetadataService = searchMetadataService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override IEnumerable<IInternalMapperConfiguration> Init()
	{
		DataClassMetadata[] source = searchMetadataService.GetPublishedDataClasses().ToArray();
		List<IInternalMapperConfiguration> list = new List<IInternalMapperConfiguration>();
		foreach (Type item in from t in ComponentManager.Current.GetExtensionPointTypes<IXsiType>()
			where typeSettingsTypeRaw.IsAssignableFrom(t)
			select t)
		{
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
			CS_0024_003C_003E8__locals0.typeSettingsTypeName = item.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AF675F);
			DataClassMetadata dataClassMetadata = source.FirstOrDefault((DataClassMetadata a) => _003C_003Ec__DisplayClass3_0.QLl49GvwjORHmbS9yvPB(_003C_003Ec__DisplayClass3_0.gUyeklvw5mTsvrVCSdXv(a), CS_0024_003C_003E8__locals0.typeSettingsTypeName));
			if (dataClassMetadata != null)
			{
				Type type = DefaultMapperConfigurator.DefaultMapperTypeInternal.MakeGenericType(item);
				list.Add((IInternalMapperConfiguration)Activator.CreateInstance(type, dataClassMetadata.TypeRef));
			}
		}
		return list;
	}

	internal static void fPhMaEhxq7koV0u0lTw5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool eNQbdwhxiw4TJNtLOdoG()
	{
		return QcDPRwhxSOgEn3QKGHgf == null;
	}

	internal static TypeSettingsMapperConfigurator aVm5FmhxRZJEnwkZIjSI()
	{
		return QcDPRwhxSOgEn3QKGHgf;
	}
}
