using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
[XmlRoot("EntityValue")]
public class EntityWrapper : IXsiType
{
	internal static EntityWrapper y4UPuSbQILRyuOVNYdEP;

	[XmlElement("Id")]
	public object Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[XmlElement("TypeUid")]
	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public EntityWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GGFkA7bQi1Jj26WVOStK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EntityWrapper(IEntity entity)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		GGFkA7bQi1Jj26WVOStK();
		base._002Ector();
		int num = 4;
		IMetadata metadata = default(IMetadata);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				TypeUid = TrNY2IbQqLUKeqZaKfMT(metadata);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num = 0;
				}
				break;
			case 1:
				metadata = MetadataLoader.LoadMetadata(entity.GetType());
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 4:
				Id = SW5qHPbQRmOiTm8eXdGX(entity);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				if (metadata == null)
				{
					return;
				}
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	internal static bool bhnC5BbQV04roHdTNq23()
	{
		return y4UPuSbQILRyuOVNYdEP == null;
	}

	internal static EntityWrapper pljdHYbQSbdMr70nqCKt()
	{
		return y4UPuSbQILRyuOVNYdEP;
	}

	internal static void GGFkA7bQi1Jj26WVOStK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object SW5qHPbQRmOiTm8eXdGX(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static Guid TrNY2IbQqLUKeqZaKfMT(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}
}
