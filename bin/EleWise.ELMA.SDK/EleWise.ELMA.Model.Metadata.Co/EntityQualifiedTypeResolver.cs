using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Components;

[Component(Order = 1000)]
internal class EntityQualifiedTypeResolver : IQualifiedTypeResolverExtension
{
	private readonly Guid uid;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	internal static EntityQualifiedTypeResolver O9vvbQhBUaGnmkj9kbnx;

	public Guid Uid => uid;

	public EntityQualifiedTypeResolver(IMetadataRuntimeService metadataRuntimeService)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		aiBtvghBzZaKKZIsXVYy();
		uid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951441012));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.metadataRuntimeService = metadataRuntimeService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public bool CheckType(Type type)
	{
		return TypeOf<IEntity>.Raw.IsAssignableFrom(type);
	}

	public IEnumerable<byte> GetQualifiedTypeData(Type type)
	{
		return MetadataLoader.LoadMetadata(type, inherit: false, loadImplementation: false).Uid.ToByteArray();
	}

	public Type GetType(IEnumerable<byte> data)
	{
		return metadataRuntimeService.GetTypeByUid(new Guid(data.ToArray()));
	}

	internal static void aiBtvghBzZaKKZIsXVYy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FAOsemhBsq3Kn09TLwcq()
	{
		return O9vvbQhBUaGnmkj9kbnx == null;
	}

	internal static EntityQualifiedTypeResolver NyCP5thBcYo3v0UUOlLh()
	{
		return O9vvbQhBUaGnmkj9kbnx;
	}
}
