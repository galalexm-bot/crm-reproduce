using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers.EQL;

[Component(Order = 2)]
public class EntityMetadataSearcher : IEntityMetadataSearcher
{
	internal static EntityMetadataSearcher WxhSochvaPt3CBQ6yB8A;

	public string DisplayName => SR.T((string)epTKlvhvwhG1IjkYDXkP(-309639236 ^ -309823400));

	public EntityMetadata FindEntityMetadata(Guid uid)
	{
		return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(uid) as EntityMetadata;
	}

	public EntityMetadata FindEntityMetadata(string className)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass1_.className = className;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<EntityMetadata>()
					.FirstOrDefault(_003C_003Ec__DisplayClass1_._003CFindEntityMetadata_003Eb__0);
			}
		}
	}

	public IEnumerable<EntityMetadata> GetEntityMetadataList()
	{
		return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<EntityMetadata>();
	}

	public EntityMetadataSearcher()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xppKVYhvDnIvtn3EQQbw()
	{
		return WxhSochvaPt3CBQ6yB8A == null;
	}

	internal static EntityMetadataSearcher asHr45hvtO3y2XmFLWmv()
	{
		return WxhSochvaPt3CBQ6yB8A;
	}

	internal static object epTKlvhvwhG1IjkYDXkP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
