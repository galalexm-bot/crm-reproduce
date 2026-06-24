using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Components;

[Component]
internal sealed class ObjectsLinkedFinder : LinkedFinderBase
{
	private readonly IMetadataService metadataService;

	internal static ObjectsLinkedFinder Yf5hNmfG3BiKpScRfM7n;

	public ObjectsLinkedFinder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
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
			metadataService = MetadataServiceContext.Service;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
			{
				num = 1;
			}
		}
	}

	public override FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		FindLinkedObjectsResult findLinkedObjectsResult = new FindLinkedObjectsResult();
		using IEnumerator<ILinkedObject> enumerator = objectsToSearch.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.objectInfo = enumerator.Current;
			IMetadata metadata = GetMetadata(CS_0024_003C_003E8__locals0.objectInfo.Uid, context, findLinkedObjectsResult);
			if (metadata == null || !(metadata is ClassMetadata classMetadata))
			{
				continue;
			}
			FillObj(findLinkedObjectsResult, context, classMetadata.BaseClassUid);
			FillProperties(classMetadata, context, findLinkedObjectsResult);
			FillDependencies(classMetadata.Uid, context, findLinkedObjectsResult);
			if (!(classMetadata is EntityMetadata))
			{
				continue;
			}
			foreach (EntityMetadata item in metadataService.GetMetadataList().Where(delegate(IMetadata m)
			{
				int num = 1;
				int num2 = num;
				EntityMetadata entityMetadata = default(EntityMetadata);
				while (true)
				{
					switch (num2)
					{
					case 2:
						return _003C_003Ec__DisplayClass2_0.VGkRl08dxlMfAnSZpWPg(_003C_003Ec__DisplayClass2_0.Q153R88d72EdkJ8TnwLF(entityMetadata), CS_0024_003C_003E8__locals0.objectInfo.Uid);
					default:
						if (_003C_003Ec__DisplayClass2_0.ym3pt38dAJce8Mg93OoR(entityMetadata) == EntityMetadataType.InterfaceExtension)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num2 = 2;
							}
							break;
						}
						goto IL_0040;
					case 1:
						{
							if ((entityMetadata = m as EntityMetadata) != null)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num2 = 0;
								}
								break;
							}
							goto IL_0040;
						}
						IL_0040:
						return false;
					}
				}
			}).OfType<EntityMetadata>())
			{
				FillProperties(item, context, findLinkedObjectsResult);
			}
		}
		return findLinkedObjectsResult;
	}

	protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
	{
		//Discarded unreachable code: IL_0056, IL_0088, IL_00c0, IL_00cf
		IMetadata metadata = default(IMetadata);
		switch (1)
		{
		default:
			return metadata;
		case 1:
			try
			{
				metadata = metadataService.GetMetadata(metadataId, loadImplementation: false) as NamedMetadata;
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => metadata, 
					_ => metadata, 
				};
			}
			catch (TypeNotFoundException)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return metadata;
					case 0:
						return metadata;
					case 1:
						metadata = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
	}

	internal static bool A5op3vfGph6Wxk1bH792()
	{
		return Yf5hNmfG3BiKpScRfM7n == null;
	}

	internal static ObjectsLinkedFinder WXu7iEfGaDFQJfqUlXVR()
	{
		return Yf5hNmfG3BiKpScRfM7n;
	}
}
