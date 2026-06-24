using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

public class PropertyMetadataReference : IEntity, IIdentified
{
	internal static PropertyMetadataReference uF8pW6B5xckAFytNDNMp;

	public Guid MetadataGuid
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataGuid_003Ek__BackingField;
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
					_003CMetadataGuid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
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

	public Guid PropertyMetadataGuid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyMetadataGuid_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CPropertyMetadataGuid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PropertyMetadataReference()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QZSY9nB5yNXVXCEk0KvH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PropertyMetadataReference(Guid? metadataGuid, Guid? propertyMetadataGuid)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		if (metadataGuid.HasValue && propertyMetadataGuid.HasValue)
		{
			MetadataGuid = metadataGuid.Value;
		}
		PropertyMetadataGuid = propertyMetadataGuid.Value;
	}

	public PropertyMetadataReference(IEntityMetadata metadata, IPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QZSY9nB5yNXVXCEk0KvH();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				if (propertyMetadata != null)
				{
					num = 2;
					break;
				}
				return;
			case 1:
				if (metadata != null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num = 0;
					}
					break;
				}
				return;
			case 4:
				PropertyMetadataGuid = PjBlVbB5Mdh2alnG96a5(propertyMetadata);
				num = 3;
				break;
			case 2:
				MetadataGuid = metadata.Uid;
				num = 4;
				break;
			case 3:
				return;
			}
		}
	}

	public IPropertyMetadata GetPropertyMetadata()
	{
		//Discarded unreachable code: IL_00d3, IL_00fd, IL_0135, IL_0144
		IPropertyMetadata result = default(IPropertyMetadata);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(MetadataGuid) as EntityMetadata;
				int num = 4;
				while (true)
				{
					switch (num)
					{
					default:
						return result;
					case 0:
						return result;
					case 2:
						return result;
					case 3:
						result = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => lVNLyAB59vo593Fr7Zfi(pnhtU5B5JkvjX9KEfwxh(p), PropertyMetadataGuid));
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num = 0;
						}
						break;
					case 4:
						if (entityMetadata == null)
						{
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num = 0;
							}
							break;
						}
						goto case 3;
					case 1:
					{
						result = null;
						int num2 = 2;
						num = num2;
						break;
					}
					}
				}
			}
			catch (Exception)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					}
					result = null;
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num3 = 1;
					}
				}
			}
		}
	}

	public object GetId()
	{
		throw new NotImplementedException();
	}

	public void SetId(object id)
	{
		throw new NotImplementedException();
	}

	public string ToString(string format)
	{
		throw new NotImplementedException();
	}

	public object GetPropertyValue(Guid propertyUid)
	{
		throw new NotImplementedException();
	}

	public T GetPropertyValue<T>(Guid propertyUid)
	{
		throw new NotImplementedException();
	}

	public void SetPropertyValue(Guid propertyUid, object value)
	{
		throw new NotImplementedException();
	}

	public TSettings GetPropertySettings<TSettings>(Guid propertyUid) where TSettings : TypeSettings
	{
		throw new NotImplementedException();
	}

	public TypeSettings GetPropertySettings(Guid propertyUid)
	{
		throw new NotImplementedException();
	}

	public TypeSettings GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings)
	{
		throw new NotImplementedException();
	}

	public TypeSettings LoadPropertyInstanceSettings(Guid propertyUid)
	{
		throw new NotImplementedException();
	}

	public void SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings)
	{
		throw new NotImplementedException();
	}

	public ITypeSettingsInstanceStore LoadSettingsInstanceStore(bool createIfNotExists, bool loadIfNotLoaded)
	{
		throw new NotImplementedException();
	}

	public IEnumerable<IEntity> GetContainedEntities()
	{
		throw new NotImplementedException();
	}

	public IEntity GetRootEntity()
	{
		throw new NotImplementedException();
	}

	public void Save()
	{
		throw new NotImplementedException();
	}

	public void Delete()
	{
		throw new NotImplementedException();
	}

	public void Refresh()
	{
		throw new NotImplementedException();
	}

	public bool IsNew()
	{
		throw new NotImplementedException();
	}

	public bool IsDirty()
	{
		throw new NotImplementedException();
	}

	public Guid[] GetDirtyPropertyUids()
	{
		throw new NotImplementedException();
	}

	internal static void QZSY9nB5yNXVXCEk0KvH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JZ09t1B50fU62O08mZgf()
	{
		return uF8pW6B5xckAFytNDNMp == null;
	}

	internal static PropertyMetadataReference qBk6rJB5mkU9mmHnRUf3()
	{
		return uF8pW6B5xckAFytNDNMp;
	}

	internal static Guid PjBlVbB5Mdh2alnG96a5(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static Guid pnhtU5B5JkvjX9KEfwxh(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool lVNLyAB59vo593Fr7Zfi(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
