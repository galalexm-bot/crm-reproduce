using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 1500)]
public class PasswordDescriptor : CLRTypeDescriptor<PasswordInfo, PasswordSettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{D31DFDF6-102D-4B74-8B3E-5EE97AA9FA7D}";

	public static readonly Guid UID;

	private static PasswordDescriptor bCVWWmo4iKJgk30ZBDm5;

	public override Guid Uid => UID;

	public override string Name => (string)h3mC74o4kyTUKG5bT6aQ(cYW7R3o4TTr4FYrHTvWG(-1217523399 ^ -1217515017));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override bool IsAvailibleEditPropertyInTable => true;

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				zoB7sRo4K2pP9YCbKTlW(this, mapper, propertyMetadata);
				num2 = 2;
				break;
			default:
				mapper.Type<PasswordNHType>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_ = (PasswordSettings)D0DWTBo4XFU6bgLp1wyl(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public override bool IsVisibleForMetadata(ClassMetadata classMetadata)
	{
		return !(classMetadata is EntityFilterMetadata);
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_0098, IL_00ab, IL_00ba
		int num = 2;
		int num2 = num;
		PasswordInfo passwordInfo = default(PasswordInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				if (passwordInfo != null)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 3:
				return true;
			case 1:
				passwordInfo = val as PasswordInfo;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 5:
				return true;
			case 4:
				return passwordInfo.IsEmpty();
			}
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(value is PasswordInfo passwordInfo))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					break;
				}
				return new SerializableDictionary<string, object>
				{
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63A9C922),
						ujcdrNo4nWaSE1aKCDG0(passwordInfo)
					},
					{
						(string)cYW7R3o4TTr4FYrHTvWG(-281842504 ^ -281992090),
						Nej4Smo4O9R5dmQRJ64h(passwordInfo)
					}
				};
			default:
				return new SerializableDictionary<string, object>
				{
					{
						(string)cYW7R3o4TTr4FYrHTvWG(-1751176224 ^ -1751300566),
						string.Empty
					},
					{
						(string)cYW7R3o4TTr4FYrHTvWG(0x10E41EDB ^ 0x10E65605),
						string.Empty
					}
				};
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_0049, IL_00fc
		int num = 1;
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		string hash = default(string);
		string salt = default(string);
		PasswordInfo result = default(PasswordInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (dictionary != null)
					{
						num2 = 8;
						continue;
					}
					goto case 5;
				case 9:
					return new PasswordInfo(hash, salt, Guid.Empty);
				case 5:
					return null;
				case 8:
					hash = dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29101911)].ToString();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					throw new ArgumentNullException((string)cYW7R3o4TTr4FYrHTvWG(-3333094 ^ -3314274));
				case 1:
					if (!SWqqZDo42lW0HrCTTQMS(deserializeToType, null))
					{
						if (!typeof(PasswordInfo).IsAssignableFrom(deserializeToType))
						{
							return base.DeserializeSimple(value, deserializeToType);
						}
						num2 = 4;
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 3:
					return result;
				case 7:
					dictionary = value as IDictionary<string, object>;
					num = 6;
					break;
				case 2:
					salt = dictionary[(string)cYW7R3o4TTr4FYrHTvWG(0x61EC0CB8 ^ 0x61EE4466)].ToString();
					num2 = 9;
					continue;
				case 4:
					if ((result = value as PasswordInfo) == null)
					{
						num = 7;
						break;
					}
					goto case 3;
				}
				break;
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
		int num = 6;
		TypeDbStructures typeDbStructures = default(TypeDbStructures);
		PasswordSettings passwordSettings = default(PasswordSettings);
		Column item2 = default(Column);
		Column item = default(Column);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					return typeDbStructures;
				case 8:
					passwordSettings = (PasswordSettings)D0DWTBo4XFU6bgLp1wyl(propertyMetadata);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					typeDbStructures = new TypeDbStructures();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					gobaAso4P0vhyNLt7dyl(D0DWTBo4XFU6bgLp1wyl(propertyMetadata) is PasswordSettings, cYW7R3o4TTr4FYrHTvWG(0x7EC153F ^ 0x7EE7B33));
					num = 8;
					break;
				case 3:
					item2 = new Column((string)WmydVGo4p540Xw3jZ8Fs(i7v12Lo4N07fa5EVZTQR(passwordSettings)), new ColumnType(DbType.String, 64));
					num = 2;
					break;
				case 6:
					oajRTRo4eluc7yeg8V1n(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870906523));
					num = 5;
					break;
				case 7:
					item = new Column((string)Jyu1Txo43SXfZmk7DivE(i7v12Lo4N07fa5EVZTQR(passwordSettings)), new ColumnType(DbType.String, 2000));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					if (UP2oF7o41SqvT54E2Qsf(propertyMetadata) != PropertyCalculateType.SQLFormula)
					{
						num2 = 7;
						continue;
					}
					goto case 10;
				case 5:
					oajRTRo4eluc7yeg8V1n(D0DWTBo4XFU6bgLp1wyl(propertyMetadata), cYW7R3o4TTr4FYrHTvWG(0x4785BC0D ^ 0x4787D1DB));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					typeDbStructures.Columns.Add(item2);
					num2 = 10;
					continue;
				case 9:
					typeDbStructures.Columns.Add(item);
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public override bool ApplyDbChanges(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		//Discarded unreachable code: IL_0282, IL_03d6
		int num = 12;
		Column column2 = default(Column);
		PasswordSettings passwordSettings2 = default(PasswordSettings);
		string newName2 = default(string);
		PasswordSettings passwordSettings = default(PasswordSettings);
		string oldName2 = default(string);
		string oldName = default(string);
		string newName = default(string);
		Column column = default(Column);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 24:
					updater.TablesCreatedActions.Add(new DbCreateColumnAction((ITransformationProvider)sF6dBgo4wi7FhmdpqqOf(updater), (string)WO5T7Wo44gC9NiRNwZtN(propertyMetadata, entityMetadata), column2));
					num2 = 4;
					continue;
				case 18:
					throw new MetadataException(string.Format((string)h3mC74o4kyTUKG5bT6aQ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957698700)), PrCIuQo4DkwZyHWpuZJH(entityMetadata), Kuxe93o4tqKFP8l1TTMf(propertyMetadata)));
				case 13:
					if (!SDW6xEo4a4QZVaLeNFeF(i7v12Lo4N07fa5EVZTQR(passwordSettings2)))
					{
						num = 20;
						break;
					}
					goto case 14;
				case 9:
					newName2 = (string)WmydVGo4p540Xw3jZ8Fs(i7v12Lo4N07fa5EVZTQR(passwordSettings));
					num2 = 7;
					continue;
				case 7:
					updater.TablesCreatedActions.Add(new DbRenameColumnAction(updater.Transform, (string)WO5T7Wo44gC9NiRNwZtN(propertyMetadata, entityMetadata), oldName2, newName2));
					num2 = 16;
					continue;
				case 11:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138174678));
					num2 = 19;
					continue;
				case 5:
					passwordSettings2 = (PasswordSettings)D0DWTBo4XFU6bgLp1wyl(oldPropertyMetadata);
					num2 = 10;
					continue;
				case 17:
					oajRTRo4eluc7yeg8V1n(D0DWTBo4XFU6bgLp1wyl(oldPropertyMetadata), cYW7R3o4TTr4FYrHTvWG(0x5DD55050 ^ 0x5DD73EC4));
					num2 = 15;
					continue;
				case 10:
					if (!SDW6xEo4a4QZVaLeNFeF(i7v12Lo4N07fa5EVZTQR(passwordSettings)))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 18;
				case 8:
					oldName2 = (string)WmydVGo4p540Xw3jZ8Fs(i7v12Lo4N07fa5EVZTQR(passwordSettings2));
					num = 9;
					break;
				case 3:
					updater.TablesCreatedActions.Add(new DbRenameColumnAction((ITransformationProvider)sF6dBgo4wi7FhmdpqqOf(updater), (string)WO5T7Wo44gC9NiRNwZtN(propertyMetadata, entityMetadata), oldName, newName));
					num2 = 8;
					continue;
				case 19:
					oajRTRo4eluc7yeg8V1n(D0DWTBo4XFU6bgLp1wyl(propertyMetadata), cYW7R3o4TTr4FYrHTvWG(-576149596 ^ -576009614));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					gobaAso4P0vhyNLt7dyl(oldPropertyMetadata.Settings is PasswordSettings, cYW7R3o4TTr4FYrHTvWG(-889460160 ^ -889617264));
					num2 = 23;
					continue;
				case 23:
					passwordSettings = (PasswordSettings)D0DWTBo4XFU6bgLp1wyl(propertyMetadata);
					num2 = 5;
					continue;
				default:
					gobaAso4P0vhyNLt7dyl(D0DWTBo4XFU6bgLp1wyl(propertyMetadata) is PasswordSettings, cYW7R3o4TTr4FYrHTvWG(0x12441CA4 ^ 0x124672A8));
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 13;
					}
					continue;
				case 16:
					return true;
				case 14:
					column = new Column((string)Jyu1Txo43SXfZmk7DivE(passwordSettings.FieldName), new ColumnType(DbType.String, 2000));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 2;
					}
					continue;
				case 21:
					column2 = new Column((string)WmydVGo4p540Xw3jZ8Fs(i7v12Lo4N07fa5EVZTQR(passwordSettings)), new ColumnType(DbType.String, 64));
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 24;
					}
					continue;
				case 6:
					oldName = PasswordNHType.GenerateHashName((string)i7v12Lo4N07fa5EVZTQR(passwordSettings2));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return true;
				case 20:
					if (!((string)i7v12Lo4N07fa5EVZTQR(passwordSettings2) != passwordSettings.FieldName))
					{
						return false;
					}
					num2 = 6;
					continue;
				case 22:
					Contract.ArgumentNotNull(oldPropertyMetadata, (string)cYW7R3o4TTr4FYrHTvWG(0x1637C429 ^ 0x1635AA43));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 17;
					}
					continue;
				case 2:
					updater.TablesCreatedActions.Add(new DbCreateColumnAction((ITransformationProvider)sF6dBgo4wi7FhmdpqqOf(updater), (string)WO5T7Wo44gC9NiRNwZtN(propertyMetadata, entityMetadata), column));
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 20;
					}
					continue;
				case 12:
					oajRTRo4eluc7yeg8V1n(updater, cYW7R3o4TTr4FYrHTvWG(0x12A5FAC7 ^ 0x12A7AD07));
					num2 = 11;
					continue;
				case 1:
					newName = (string)Jyu1Txo43SXfZmk7DivE(i7v12Lo4N07fa5EVZTQR(passwordSettings));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	public PasswordDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CliNx3o46yY9kcwx0jll();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PasswordDescriptor()
	{
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
			case 2:
				CliNx3o46yY9kcwx0jll();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)cYW7R3o4TTr4FYrHTvWG(-475857671 ^ -476015783));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void zoB7sRo4K2pP9YCbKTlW(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<PasswordInfo>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static object D0DWTBo4XFU6bgLp1wyl(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool exg6T4o4RMCeDhWe61Mn()
	{
		return bCVWWmo4iKJgk30ZBDm5 == null;
	}

	internal static PasswordDescriptor R3vDvno4qQqJFhN9OppK()
	{
		return bCVWWmo4iKJgk30ZBDm5;
	}

	internal static object cYW7R3o4TTr4FYrHTvWG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object h3mC74o4kyTUKG5bT6aQ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object ujcdrNo4nWaSE1aKCDG0(object P_0)
	{
		return ((PasswordInfo)P_0).Hash;
	}

	internal static object Nej4Smo4O9R5dmQRJ64h(object P_0)
	{
		return ((PasswordInfo)P_0).Salt;
	}

	internal static bool SWqqZDo42lW0HrCTTQMS(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void oajRTRo4eluc7yeg8V1n(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void gobaAso4P0vhyNLt7dyl(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static PropertyCalculateType UP2oF7o41SqvT54E2Qsf(object P_0)
	{
		return ((PropertyMetadata)P_0).CalculateType;
	}

	internal static object i7v12Lo4N07fa5EVZTQR(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static object Jyu1Txo43SXfZmk7DivE(object P_0)
	{
		return PasswordNHType.GenerateHashName((string)P_0);
	}

	internal static object WmydVGo4p540Xw3jZ8Fs(object P_0)
	{
		return PasswordNHType.GenerateSaltName((string)P_0);
	}

	internal static bool SDW6xEo4a4QZVaLeNFeF(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object PrCIuQo4DkwZyHWpuZJH(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object Kuxe93o4tqKFP8l1TTMf(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object sF6dBgo4wi7FhmdpqqOf(object P_0)
	{
		return ((IDbModelUpdater)P_0).Transform;
	}

	internal static object WO5T7Wo44gC9NiRNwZtN(object P_0, object P_1)
	{
		return ((EntityPropertyMetadata)P_0).GetTableName((EntityMetadata)P_1);
	}

	internal static void CliNx3o46yY9kcwx0jll()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
