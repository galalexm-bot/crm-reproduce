using System;
using System.Data;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class ReferenceOnEntityDecription : CLRTypeDescriptor<ReferenceOnEntity, ReferenceOnEntitySettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{1F289B26-0607-4BC7-ADC0-9ED814C80C90}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static ReferenceOnEntityDecription A1RNhEoASTHrP1Rhowa9;

	public override Guid Uid => UID;

	public override string Name => (string)e2IT5qoAXLWjbIRWFYBg(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3168376));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 2;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					fullTextPropertyDescriptor = (propertyDescriptor = new ReferenceOnEntityPropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				mapper.Type<ReferenceOnEntityNHType>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				TvNevkoAqARvKH74MQ6G(this, mapper, propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_ = (ReferenceOnEntitySettings)Pkh2TkoAK3LG9h9ba22R(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_006d, IL_008d, IL_00fd, IL_0135
		int num = 3;
		ReferenceOnEntity referenceOnEntity = default(ReferenceOnEntity);
		IEntity entity = default(IEntity);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		Guid guid = default(Guid);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (referenceOnEntity == null)
					{
						num2 = 9;
						continue;
					}
					entity = (IEntity)ursDnqoAThdBkA3gCnHv(referenceOnEntity);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					referenceOnEntity = value as ReferenceOnEntity;
					num = 2;
					break;
				case 13:
					if (settings != null)
					{
						num2 = 5;
						continue;
					}
					goto case 15;
				case 17:
					if (entityPropertyMetadata == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 16;
				case 16:
					guid = entity.GetPropertyValue<Guid>(entityPropertyMetadata.Uid);
					num2 = 7;
					continue;
				case 15:
				case 18:
					entityPropertyMetadata = (EntityPropertyMetadata)YRUoNcoAOsxp05cKVlTN(entityMetadata);
					num2 = 17;
					continue;
				case 10:
					if (nUOyGooAkWdL78XCjWME(entity))
					{
						num2 = 18;
						continue;
					}
					goto case 13;
				case 9:
					return base.SerializeSimple(value, valueType, settings);
				default:
					if (!(guid == Guid.Empty))
					{
						num2 = 4;
						continue;
					}
					goto case 11;
				case 6:
					if (entity == null)
					{
						num = 14;
						break;
					}
					guid = Guid.Empty;
					num2 = 12;
					continue;
				case 8:
					if (entityMetadata != null)
					{
						num2 = 10;
						continue;
					}
					goto default;
				case 12:
					entityMetadata = MetadataLoader.LoadMetadata(entity.GetType()) as EntityMetadata;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 8;
					}
					continue;
				case 11:
					return base.SerializeSimple(value, valueType, settings);
				case 4:
					return otUdMCoAejgAyCD5YhoU(v0Ogd0oA2byJahVEBCI1(-787452571 ^ -787288365), referenceOnEntity.ToString(), ReferenceOnEntity.Delimiter, guid);
				case 5:
					if (MAbNxxoAnRsPBjVu6C5u(settings) != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 15;
				case 14:
					return base.SerializeSimple(value, valueType, settings);
				}
				break;
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		int num = 2;
		int num2 = num;
		Guid objectTypeUId2 = default(Guid);
		string[] array = default(string[]);
		Guid objectTypeUId = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 5:
				objectTypeUId2 = y9lf37oANTDf5aV2jEt5(array[0]);
				num2 = 4;
				break;
			case 4:
				return new ReferenceOnEntity(y9lf37oANTDf5aV2jEt5(array[2]), objectTypeUId2);
			case 2:
				array = (string[])elutlyoA1j2PIFOn0yEl((string)value, rTncaXoAPiPAgS6WAcdP(ReferenceOnEntity.Delimiter));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (array.Length < 3)
				{
					if (array.Length < 2)
					{
						return base.DeserializeSimple(value, deserializeToType);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 5;
				}
				break;
			default:
				objectTypeUId = y9lf37oANTDf5aV2jEt5(array[0]);
				num2 = 3;
				break;
			case 3:
				return new ReferenceOnEntity(vwYAF1oA3gZSC49c0cSc(array[1]), objectTypeUId);
			}
		}
	}

	public override bool HasRealColumn(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return null;
	}

	public override TypeDbStructures GetDbStructures(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		int num = 4;
		TypeDbStructures typeDbStructures = default(TypeDbStructures);
		Column item2 = default(Column);
		ReferenceOnEntitySettings referenceOnEntitySettings = default(ReferenceOnEntitySettings);
		Column item = default(Column);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					jHfWo3oAaupIFpgMAfKQ(Pkh2TkoAK3LG9h9ba22R(propertyMetadata) is ReferenceOnEntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EE8F74));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					typeDbStructures.Columns.Add(item2);
					num2 = 8;
					continue;
				case 5:
					item2 = new Column((string)KhYvhQoAtkt5arcQoy2L(ontctGoADAnwxnK514bL(referenceOnEntitySettings)), new ColumnType(DbType.Int64));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 4;
					}
					continue;
				case 9:
					typeDbStructures.Columns.Add(item);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					gRX95NoAp4SCHDC8vwuk(propertyMetadata, v0Ogd0oA2byJahVEBCI1(0x76DD48E ^ 0x76D9DDC));
					num2 = 3;
					continue;
				case 2:
					break;
				case 8:
					item = new Column((string)dTRwRxoAw0COWfSj8M5B(ontctGoADAnwxnK514bL(referenceOnEntitySettings)), new ColumnType(DbType.Guid));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 9;
					}
					continue;
				case 1:
					return typeDbStructures;
				case 10:
					if (propertyMetadata.CalculateType != PropertyCalculateType.SQLFormula)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 1;
				case 7:
					referenceOnEntitySettings = (ReferenceOnEntitySettings)Pkh2TkoAK3LG9h9ba22R(propertyMetadata);
					num2 = 2;
					continue;
				case 3:
					gRX95NoAp4SCHDC8vwuk(Pkh2TkoAK3LG9h9ba22R(propertyMetadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFC95BC));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			typeDbStructures = new TypeDbStructures();
			num = 10;
		}
	}

	public override bool ApplyDbChanges(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		int num = 13;
		ReferenceOnEntitySettings referenceOnEntitySettings2 = default(ReferenceOnEntitySettings);
		string oldName = default(string);
		string newName2 = default(string);
		string oldName2 = default(string);
		string newName = default(string);
		Column column2 = default(Column);
		ReferenceOnEntitySettings referenceOnEntitySettings = default(ReferenceOnEntitySettings);
		Column column = default(Column);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 22:
					jHfWo3oAaupIFpgMAfKQ(oldPropertyMetadata.Settings is ReferenceOnEntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53E289F));
					num2 = 5;
					continue;
				case 2:
					referenceOnEntitySettings2 = (ReferenceOnEntitySettings)Pkh2TkoAK3LG9h9ba22R(oldPropertyMetadata);
					num2 = 3;
					continue;
				case 1:
					updater.TablesCreatedActions.Add(new DbRenameColumnAction((ITransformationProvider)sAwhh5oA7L6YyCgAJQ89(updater), (string)RjgYg1oAxleoxaunLeg4(propertyMetadata, entityMetadata), oldName, newName2));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					updater.TablesCreatedActions.Add(new DbRenameColumnAction((ITransformationProvider)sAwhh5oA7L6YyCgAJQ89(updater), (string)RjgYg1oAxleoxaunLeg4(propertyMetadata, entityMetadata), oldName2, newName));
					num2 = 4;
					continue;
				case 4:
					oldName = (string)dTRwRxoAw0COWfSj8M5B(referenceOnEntitySettings2.FieldName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					gRX95NoAp4SCHDC8vwuk(propertyMetadata, v0Ogd0oA2byJahVEBCI1(-951514650 ^ -951500620));
					num2 = 16;
					continue;
				case 15:
					break;
				case 17:
					return true;
				case 10:
					column2 = new Column((string)KhYvhQoAtkt5arcQoy2L(ontctGoADAnwxnK514bL(referenceOnEntitySettings)), new ColumnType(DbType.Int64));
					num2 = 18;
					continue;
				case 13:
					gRX95NoAp4SCHDC8vwuk(updater, v0Ogd0oA2byJahVEBCI1(-281842504 ^ -281986184));
					num2 = 12;
					continue;
				case 6:
					oldName2 = (string)KhYvhQoAtkt5arcQoy2L(ontctGoADAnwxnK514bL(referenceOnEntitySettings2));
					num2 = 8;
					continue;
				case 3:
					if (M8luAroA40Y3RjSHTASj(ontctGoADAnwxnK514bL(referenceOnEntitySettings)))
					{
						num2 = 14;
					}
					else if (!M8luAroA40Y3RjSHTASj(ontctGoADAnwxnK514bL(referenceOnEntitySettings2)))
					{
						if (!rYONHKoA0hLwfAsVVyFL(ontctGoADAnwxnK514bL(referenceOnEntitySettings2), referenceOnEntitySettings.FieldName))
						{
							return false;
						}
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 10;
						}
					}
					continue;
				default:
					newName2 = (string)dTRwRxoAw0COWfSj8M5B(ontctGoADAnwxnK514bL(referenceOnEntitySettings));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					updater.TablesCreatedActions.Add(new DbCreateColumnAction(updater.Transform, (string)RjgYg1oAxleoxaunLeg4(propertyMetadata, entityMetadata), column));
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 19;
					}
					continue;
				case 18:
					updater.TablesCreatedActions.Add(new DbCreateColumnAction((ITransformationProvider)sAwhh5oA7L6YyCgAJQ89(updater), (string)RjgYg1oAxleoxaunLeg4(propertyMetadata, entityMetadata), column2));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 21;
					}
					continue;
				case 16:
					gRX95NoAp4SCHDC8vwuk(Pkh2TkoAK3LG9h9ba22R(propertyMetadata), v0Ogd0oA2byJahVEBCI1(-1710575414 ^ -1710695140));
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 15;
					}
					continue;
				case 19:
					gRX95NoAp4SCHDC8vwuk(oldPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341A303F));
					num2 = 11;
					continue;
				case 21:
					column = new Column(ReferenceOnEntityNHType.GenerateObjectTypeName(referenceOnEntitySettings.FieldName), new ColumnType(DbType.Guid));
					num2 = 9;
					continue;
				case 20:
					return true;
				case 5:
					referenceOnEntitySettings = (ReferenceOnEntitySettings)Pkh2TkoAK3LG9h9ba22R(propertyMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					newName = (string)KhYvhQoAtkt5arcQoy2L(referenceOnEntitySettings.FieldName);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					gRX95NoAp4SCHDC8vwuk(Pkh2TkoAK3LG9h9ba22R(oldPropertyMetadata), v0Ogd0oA2byJahVEBCI1(-398663332 ^ -398553144));
					num2 = 22;
					continue;
				case 14:
					throw new MetadataException((string)G3uuWJoAAQMVoaTCunj8(e2IT5qoAXLWjbIRWFYBg(v0Ogd0oA2byJahVEBCI1(0x103FE975 ^ 0x103D8641)), CtGaaGoA6rGr1tgYynrg(entityMetadata), qOumWjoAH7WM5RaEhq1g(propertyMetadata)));
				}
				break;
			}
			jHfWo3oAaupIFpgMAfKQ(Pkh2TkoAK3LG9h9ba22R(propertyMetadata) is ReferenceOnEntitySettings, v0Ogd0oA2byJahVEBCI1(-345420348 ^ -345256440));
			num = 19;
		}
	}

	public ReferenceOnEntityDecription()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ReferenceOnEntityDecription()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)v0Ogd0oA2byJahVEBCI1(-1633514411 ^ -1633679129));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void TvNevkoAqARvKH74MQ6G(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<ReferenceOnEntity>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static object Pkh2TkoAK3LG9h9ba22R(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool Ss7nYAoAi0Y199x63BEi()
	{
		return A1RNhEoASTHrP1Rhowa9 == null;
	}

	internal static ReferenceOnEntityDecription XcBNTLoAROwBakQ0UWkJ()
	{
		return A1RNhEoASTHrP1Rhowa9;
	}

	internal static object e2IT5qoAXLWjbIRWFYBg(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object ursDnqoAThdBkA3gCnHv(object P_0)
	{
		return ((ReferenceOnEntity)P_0).Object;
	}

	internal static bool nUOyGooAkWdL78XCjWME(object P_0)
	{
		return ((IEntity)P_0).IsNew();
	}

	internal static EntitySerializationMode MAbNxxoAnRsPBjVu6C5u(object P_0)
	{
		return ((EntitySerializationSettings)P_0).Mode;
	}

	internal static object YRUoNcoAOsxp05cKVlTN(object P_0)
	{
		return ((EntityMetadata)P_0).GetUidProperty();
	}

	internal static object v0Ogd0oA2byJahVEBCI1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object otUdMCoAejgAyCD5YhoU(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object rTncaXoAPiPAgS6WAcdP(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object elutlyoA1j2PIFOn0yEl(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static Guid y9lf37oANTDf5aV2jEt5(object P_0)
	{
		return Guid.Parse((string)P_0);
	}

	internal static long vwYAF1oA3gZSC49c0cSc(object P_0)
	{
		return long.Parse((string)P_0);
	}

	internal static void gRX95NoAp4SCHDC8vwuk(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void jHfWo3oAaupIFpgMAfKQ(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object ontctGoADAnwxnK514bL(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static object KhYvhQoAtkt5arcQoy2L(object P_0)
	{
		return ReferenceOnEntityNHType.GenerateObjectIdName((string)P_0);
	}

	internal static object dTRwRxoAw0COWfSj8M5B(object P_0)
	{
		return ReferenceOnEntityNHType.GenerateObjectTypeName((string)P_0);
	}

	internal static bool M8luAroA40Y3RjSHTASj(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object CtGaaGoA6rGr1tgYynrg(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object qOumWjoAH7WM5RaEhq1g(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object G3uuWJoAAQMVoaTCunj8(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object sAwhh5oA7L6YyCgAJQ89(object P_0)
	{
		return ((IDbModelUpdater)P_0).Transform;
	}

	internal static object RjgYg1oAxleoxaunLeg4(object P_0, object P_1)
	{
		return ((EntityPropertyMetadata)P_0).GetTableName((EntityMetadata)P_1);
	}

	internal static bool rYONHKoA0hLwfAsVVyFL(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}
}
