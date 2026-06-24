using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types;

[Component]
public abstract class PlatformTypeDescriptorProvider : IPlatformTypeDescriptorProvider
{
	internal static PlatformTypeDescriptorProvider Ea2Ea0oJbHMiIiL5IaLY;

	public abstract IEnumerable<ITypeDescriptor> GetTypeDescriptors();

	protected ITypeDescriptor CreateEntityDescriptor(Guid uid)
	{
		//Discarded unreachable code: IL_008a, IL_0094, IL_00a3, IL_00c4
		int num = 3;
		int num2 = num;
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IMetadataService serviceOrNull = default(IMetadataService);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				if (typeDescriptor == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 8;
					}
					continue;
				}
				return new SubTypeDescriptor(typeDescriptor, HRZpaFoJfnIHSGATd2J0(entityMetadata), (string)eNP5aBoJQnn9WxJRku0P(entityMetadata));
			case 5:
				return null;
			default:
				serviceOrNull = MetadataServiceContext.ServiceOrNull;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				obj = null;
				break;
			case 1:
				if (serviceOrNull != null)
				{
					num2 = 7;
					continue;
				}
				goto case 4;
			case 2:
				if (entityMetadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 8:
				return null;
			case 3:
				entityMetadata = GetEntityMetadata(uid);
				num2 = 2;
				continue;
			case 7:
				obj = jo77uioJELBTeRei9YMB(serviceOrNull, EntityDescriptor.UID, Guid.Empty);
				break;
			}
			typeDescriptor = (ITypeDescriptor)obj;
			num2 = 6;
		}
	}

	protected ITypeDescriptor CreateEntityDescriptor<T>()
	{
		Guid uid = AttributeHelper<UidAttribute>.GetAttribute(typeof(T), inherited: true)?.Uid ?? Guid.Empty;
		return CreateEntityDescriptor(uid);
	}

	private EntityMetadata GetEntityMetadata(Guid uid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass3_.uid = uid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			return ((IMetadataService)NVBiGkoJCK0XSkNqeeiD()).GetMetadataList().OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return m.Type == EntityMetadataType.Entity;
					case 1:
						if (_003C_003Ec.QgbUjoCVz7kIAquHqLCb(m) == EntityMetadataType.Interface)
						{
							return true;
						}
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			})
				.FirstOrDefault(_003C_003Ec__DisplayClass3_._003CGetEntityMetadata_003Eb__1);
		}
	}

	protected PlatformTypeDescriptorProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object jo77uioJELBTeRei9YMB(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static Guid HRZpaFoJfnIHSGATd2J0(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object eNP5aBoJQnn9WxJRku0P(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool Oxs8cdoJhMe08j6f3rah()
	{
		return Ea2Ea0oJbHMiIiL5IaLY == null;
	}

	internal static PlatformTypeDescriptorProvider GxeTGGoJGmgvJqyPHdmc()
	{
		return Ea2Ea0oJbHMiIiL5IaLY;
	}

	internal static object NVBiGkoJCK0XSkNqeeiD()
	{
		return MetadataServiceContext.Service;
	}
}
