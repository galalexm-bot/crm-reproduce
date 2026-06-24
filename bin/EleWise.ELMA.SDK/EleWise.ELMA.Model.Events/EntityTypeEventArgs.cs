using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Events;

public class EntityTypeEventArgs : AuditEventArgs
{
	private EntityMetadata _metadata;

	private static EntityTypeEventArgs xq5beVoB7itg6sXTcpgR;

	[JsonIgnore]
	public Type EntityType
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityType_003Ek__BackingField;
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
					_003CEntityType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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

	[JsonIgnore]
	public EntityMetadata Metadata
	{
		get
		{
			int num = 1;
			int num2 = num;
			EntityMetadata entityMetadata = default(EntityMetadata);
			EntityMetadata entityMetadata2;
			while (true)
			{
				switch (num2)
				{
				default:
					entityMetadata = (_metadata = (EntityMetadata)MetadataLoader.LoadMetadata(EntityType));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					entityMetadata2 = _metadata;
					if (entityMetadata2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					entityMetadata2 = entityMetadata;
					break;
				}
				break;
			}
			return entityMetadata2;
		}
	}

	[JsonIgnore]
	public override IDictionary<string, object> ExtendedProperties
	{
		get
		{
			IDictionary<string, object> extendedProperties = base.ExtendedProperties;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D624C)] = Metadata;
			return extendedProperties;
		}
	}

	public EntityTypeEventArgs(Type entityType)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_00fa, IL_0109
		QI0yRYoBmIOfFOoY1I4L();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 1;
		}
		UidAttribute attribute = default(UidAttribute);
		while (true)
		{
			switch (num)
			{
			case 3:
				EntityType = entityType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 4:
				return;
			case 6:
				auditObject = (IAuditObject)xkfKm1oBJkQ63AZwNOp1(Locator.GetServiceNotNull<EntityAuditObjectProvider>(), kMngdpoBMBH7W3fBmGaD(attribute));
				num = 4;
				break;
			case 1:
				Contract.ArgumentNotNull(entityType, (string)kSHM8foBy5btNJIwEbXj(-1108654032 ^ -1108632668));
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 3;
				}
				break;
			default:
				attribute = AttributeHelper<UidAttribute>.GetAttribute(entityType, inherited: true);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num = 5;
				}
				break;
			case 5:
				if (attribute == null)
				{
					num = 2;
					break;
				}
				goto case 6;
			}
		}
	}

	public EntityTypeEventArgs(Guid entityTypeUid)
	{
		//Discarded unreachable code: IL_001e
		QI0yRYoBmIOfFOoY1I4L();
		base._002Ector();
		int num = 2;
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
				auditObject = (IAuditObject)xkfKm1oBJkQ63AZwNOp1(Locator.GetServiceNotNull<EntityAuditObjectProvider>(), entityTypeUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				EntityType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityTypeUid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0058, IL_0067
		int num = 4;
		EntityTypeEventArgs entityTypeEventArgs = default(EntityTypeEventArgs);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return false;
				case 5:
					if (!base.Equals(obj))
					{
						goto end_IL_0012;
					}
					goto default;
				default:
					return oiwwHroB9NflGHG7PQ0l(entityTypeEventArgs.EntityType, EntityType);
				case 2:
					return false;
				case 4:
					entityTypeEventArgs = obj as EntityTypeEventArgs;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					if (entityTypeEventArgs != null)
					{
						num2 = 5;
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public override int GetHashCode()
	{
		return (base.GetHashCode() * 397) ^ (yhUrt4oBd81EpoF4CDBp(EntityType, null) ? EntityType.GetHashCode() : 0);
	}

	internal static void QI0yRYoBmIOfFOoY1I4L()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object kSHM8foBy5btNJIwEbXj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid kMngdpoBMBH7W3fBmGaD(object P_0)
	{
		return ((UidAttribute)P_0).Uid;
	}

	internal static object xkfKm1oBJkQ63AZwNOp1(object P_0, Guid uid)
	{
		return ((EntityAuditObjectProvider)P_0).GetObject(uid);
	}

	internal static bool BMMBY9oBxwtPHvkrXwmk()
	{
		return xq5beVoB7itg6sXTcpgR == null;
	}

	internal static EntityTypeEventArgs hmEbRHoB0ejc1qYjdFPh()
	{
		return xq5beVoB7itg6sXTcpgR;
	}

	internal static bool oiwwHroB9NflGHG7PQ0l(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool yhUrt4oBd81EpoF4CDBp(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}
}
