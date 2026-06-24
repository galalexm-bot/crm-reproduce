using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db;

public static class DbModelHelper
{
	internal static DbModelHelper NNWd6noo1nnqZUUGOseg;

	public static Column GetColumnForIdentifier(EntityMetadata metadata)
	{
		bool autoIncrement;
		return GetColumnForIdentifier(metadata, out autoIncrement);
	}

	public static Column GetDefaultColumnForIdentifier()
	{
		int num = 1;
		int num2 = num;
		ITypeDescriptor idType = default(ITypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				bool autoIncrement;
				return GetColumnForIdentifier(null, string.Empty, idType, out autoIncrement);
			}
			case 1:
				idType = (ITypeDescriptor)tEOwy5ooa51VulDNCxZg(YuQ1NVoop0x4gZ77SWoJ(), Int64Descriptor.UID);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Column GetColumnForIdentifier(EntityMetadata metadata, out bool autoIncrement)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		ITypeDescriptor idTypeDescriptor = default(ITypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 2:
				idTypeDescriptor = MetadataServiceContext.Service.GetIdTypeDescriptor(metadata.IdTypeUid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				throw new DbModelException((string)VD3XCvoo4Ppa3TcqxWRg(io85huooDIcprnrEf3KY(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979365353)), iYYZCDootY10D2PcCuQq(metadata), CnnDxRoow56VjoosdRlN(metadata)));
			case 3:
				return GetColumnForIdentifier(metadata, iYYZCDootY10D2PcCuQq(metadata), idTypeDescriptor, out autoIncrement);
			case 1:
				if (idTypeDescriptor != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public static TypeDbStructures GetPropertyDbStructures(EntityMetadata metadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0041
		int num = 1;
		int num2 = num;
		IDbTypeInfo dbTypeInfo = default(IDbTypeInfo);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return new TypeDbStructures();
			case 2:
				return (TypeDbStructures)OXkbD6ooHcJ1wjVqUdZq(dbTypeInfo, metadata, propertyMetadata);
			default:
				if (dbTypeInfo != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 1:
				dbTypeInfo = (IDbTypeInfo)IdbODvoo6hsFTacy8LLT(metadata, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool ApplyPropertyDbChanges(IDbModelUpdater updater, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		int num = 2;
		int num2 = num;
		IDbTypeInfo dbTypeInfo = default(IDbTypeInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (dbTypeInfo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return dbTypeInfo.ApplyDbChanges(updater, metadata, propertyMetadata, oldPropertyMetadata);
			case 2:
				dbTypeInfo = (IDbTypeInfo)IdbODvoo6hsFTacy8LLT(metadata, propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return false;
			}
		}
	}

	private static IDbTypeInfo GetDbTypeInfo(object metadata, object propertyMetadata)
	{
		//Discarded unreachable code: IL_00a2
		int num = 1;
		int num2 = num;
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		IDbTypeInfo dbTypeInfo = default(IDbTypeInfo);
		while (true)
		{
			switch (num2)
			{
			case 5:
				vh443Xoo7oZoWZddVE6n(lDwQTUooxqbx6H0jRLNU(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D7FAA), iYYZCDootY10D2PcCuQq(metadata), ((NamedMetadata)propertyMetadata).Name, typeDescriptor.GetType().FullName));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				continue;
			case 7:
				vh443Xoo7oZoWZddVE6n(Logger.Log, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218608320), iYYZCDootY10D2PcCuQq(metadata), qrm7s9ooA3VXCt1hnk04(propertyMetadata), ((PropertyMetadata)propertyMetadata).TypeUid));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				return null;
			case 3:
				return dbTypeInfo;
			case 6:
				return null;
			case 4:
				if (dbTypeInfo != null)
				{
					num2 = 3;
					continue;
				}
				goto case 5;
			case 1:
				typeDescriptor = ((IMetadataService)YuQ1NVoop0x4gZ77SWoJ()).GetTypeDescriptor(((PropertyMetadata)propertyMetadata).TypeUid, ((PropertyMetadata)propertyMetadata).SubTypeUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (typeDescriptor != null)
			{
				dbTypeInfo = typeDescriptor as IDbTypeInfo;
				num2 = 4;
				continue;
			}
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
			{
				num2 = 7;
			}
		}
	}

	private static Column GetColumnForIdentifier(object metadata, object metadataFullTypeName, object idType, out bool autoIncrement)
	{
		//Discarded unreachable code: IL_0066, IL_0075
		int num = 5;
		int num2 = num;
		IDbTypeInfo dbTypeInfo = default(IDbTypeInfo);
		Column column = default(Column);
		SimpleTypeSettings simpleTypeSettings = default(SimpleTypeSettings);
		TypeDbStructures typeDbStructures = default(TypeDbStructures);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (dbTypeInfo != null)
				{
					num2 = 9;
					break;
				}
				goto case 8;
			case 8:
				throw new DbModelException((string)VD3XCvoo4Ppa3TcqxWRg(SR.T((string)tCXrUPoo03l05VBcM3WB(-345420348 ^ -345308248)), metadataFullTypeName, idType.GetType().FullName));
			case 9:
				autoIncrement = MLqsKXoom1KnsLRW5UYi(dbTypeInfo);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 2;
				}
				break;
			case 11:
				throw new DbModelException((string)VD3XCvoo4Ppa3TcqxWRg(io85huooDIcprnrEf3KY(tCXrUPoo03l05VBcM3WB(-1867198571 ^ -1867087795)), metadataFullTypeName, idType.GetType().FullName));
			case 7:
				return column;
			case 3:
				simpleTypeSettings = (SimpleTypeSettings)QyYecZooMr2MfUvb4QdD(HH1DLPooyItm0RxcdgFH(idType));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 10;
				}
				break;
			case 10:
				IKbVhUooJc18ueiif8Vt(simpleTypeSettings, tCXrUPoo03l05VBcM3WB(-289714582 ^ -289681612));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				IDbTypeInfo dbTypeInfo2 = dbTypeInfo;
				EntityPropertyMetadata entityPropertyMetadata = new EntityPropertyMetadata();
				jvmyGtoo9biOjW53aXWT(entityPropertyMetadata, simpleTypeSettings);
				typeDbStructures = (TypeDbStructures)OXkbD6ooHcJ1wjVqUdZq(dbTypeInfo2, metadata, entityPropertyMetadata);
				num2 = 6;
				break;
			}
			case 6:
				if (typeDbStructures == null)
				{
					num2 = 2;
				}
				else if (aAGqWwoodEGrLfcpBp2t(typeDbStructures.Columns) == 1)
				{
					column = typeDbStructures.Columns[0];
					num2 = 12;
				}
				else
				{
					num2 = 11;
				}
				break;
			case 5:
				dbTypeInfo = idType as IDbTypeInfo;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				throw new DbModelException(string.Format((string)io85huooDIcprnrEf3KY(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269C10D4)), metadataFullTypeName, idType.GetType().FullName));
			case 1:
				typeDbStructures.PrimaryKeys.Add(new PrimaryKey
				{
					TableName = ((EntityMetadata)metadata).TableName,
					Columns = new List<string> { (string)hg569PoolGbvMkZ3cmMY(column) }
				});
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 4;
				}
				break;
			case 12:
				if (metadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	internal static bool LDcKBLooNEo4dGLaW0Cq()
	{
		return NNWd6noo1nnqZUUGOseg == null;
	}

	internal static DbModelHelper d97y9Xoo3FgImwDh3lKE()
	{
		return NNWd6noo1nnqZUUGOseg;
	}

	internal static object YuQ1NVoop0x4gZ77SWoJ()
	{
		return MetadataServiceContext.Service;
	}

	internal static object tEOwy5ooa51VulDNCxZg(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).GetIdTypeDescriptor(typeUid);
	}

	internal static object io85huooDIcprnrEf3KY(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object iYYZCDootY10D2PcCuQq(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static Guid CnnDxRoow56VjoosdRlN(object P_0)
	{
		return ((EntityMetadata)P_0).IdTypeUid;
	}

	internal static object VD3XCvoo4Ppa3TcqxWRg(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object IdbODvoo6hsFTacy8LLT(object P_0, object P_1)
	{
		return GetDbTypeInfo(P_0, P_1);
	}

	internal static object OXkbD6ooHcJ1wjVqUdZq(object P_0, object P_1, object P_2)
	{
		return ((IDbTypeInfo)P_0).GetDbStructures((EntityMetadata)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static object qrm7s9ooA3VXCt1hnk04(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void vh443Xoo7oZoWZddVE6n(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static object lDwQTUooxqbx6H0jRLNU()
	{
		return Logger.Log;
	}

	internal static object tCXrUPoo03l05VBcM3WB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool MLqsKXoom1KnsLRW5UYi(object P_0)
	{
		return ((IDbTypeInfo)P_0).AutoIncrementSupported;
	}

	internal static Type HH1DLPooyItm0RxcdgFH(object P_0)
	{
		return ((ITypeDescriptor)P_0).SettingsType;
	}

	internal static object QyYecZooMr2MfUvb4QdD(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void IKbVhUooJc18ueiif8Vt(object P_0, object P_1)
	{
		((SimpleTypeSettings)P_0).FieldName = (string)P_1;
	}

	internal static void jvmyGtoo9biOjW53aXWT(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static int aAGqWwoodEGrLfcpBp2t(object P_0)
	{
		return ((List<Column>)P_0).Count;
	}

	internal static object hg569PoolGbvMkZ3cmMY(object P_0)
	{
		return ((Column)P_0).Name;
	}
}
