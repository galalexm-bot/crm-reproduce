using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using EleWise.ELMA.Common;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class BinaryFileDescriptor : CLRTypeDescriptor<BinaryFile, BinaryFileSettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{289F266B-2805-457E-BCE0-B0BCD4D38143}";

	public const int DbColumnLength = 250;

	public static readonly Guid UID;

	internal static BinaryFileDescriptor CYUZcuo7MTNNWbDZmEJo;

	public override Guid Uid => UID;

	public override string Name => (string)aQIeOco7Yo2E5XjFOmeB(gvd4Wxo7jSDjyfUOqlB2(0x5DD55050 ^ 0x5DD7D944));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override CopyAction CopyAction => CopyAction.ByRef;

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					POV1sCo7dLpqwRlJ8OtT(this, mapper, propertyMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					NhZSwxo7llfQaxDNFhVt(mapper, 250);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			mapper.Type<BinaryFileType>();
			num = 3;
		}
	}

	private static SerializableDictionary<string, object> BinaryFileInDictionary(object valueEntity)
	{
		if (valueEntity == null)
		{
			return new SerializableDictionary<string, object>
			{
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767713175),
					string.Empty
				},
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099764073),
					string.Empty
				},
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53EE41B),
					string.Empty
				}
			};
		}
		string value;
		try
		{
			value = (((BinaryFile)valueEntity).Id.IsNullOrEmpty() ? string.Empty : DataAccessManager.FileManager.FileSize(((BinaryFile)valueEntity).Id).ToString());
		}
		catch (FileNotFoundException)
		{
			value = string.Empty;
		}
		return new SerializableDictionary<string, object>
		{
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675482067),
				((BinaryFile)valueEntity).Uid
			},
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852866108),
				((BinaryFile)valueEntity).Name
			},
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70187368),
				value
			}
		};
	}

	public static BinaryFile Download(Guid uid)
	{
		//Discarded unreachable code: IL_0063, IL_0095, IL_00d7, IL_00e6
		int num = 1;
		int num2 = num;
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					object obj = Yc55IJo7g7TnsFIGLMFF(Nyo6Ovo7rILmHkbZbdqD(), uid.ToString());
					_ = ((BinaryFile)obj).Name;
					binaryFile = (BinaryFile)obj;
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => binaryFile, 
						_ => binaryFile, 
					};
				}
				catch (FileNotFoundException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return binaryFile;
						}
						binaryFile = (BinaryFile)ri5KlUo75uUcN6UbD1Zx(Locator.GetServiceNotNull<ICacheFilesService>(), uid);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num4 = 1;
						}
					}
				}
			case 1:
				if (uid != Guid.Empty)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				break;
			}
			break;
		}
		return null;
	}

	public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		return true;
	}

	public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.String, 250);
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_00bc, IL_00cb, IL_00da, IL_00ea, IL_00f9, IL_0203
		int num = 1;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string text = default(string);
		SimpleTypeSettings simpleTypeSettings = default(SimpleTypeSettings);
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 1:
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (propertyMetadata != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 8:
				return;
			case 9:
				return;
			case 12:
				return;
			case 13:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 15;
				}
				break;
			case 15:
				text = (string)iR71Ygo7c2n49ElOhHji(gvd4Wxo7jSDjyfUOqlB2(-2099751081 ^ -2099585417), TDIs12o7sWvTSaDy57d1(serviceNotNull.Dialect, yTd33ao7UUv8WW8mv4po(simpleTypeSettings)));
				num2 = 14;
				break;
			default:
				throw new ArgumentNullException((string)gvd4Wxo7jSDjyfUOqlB2(0x638095EB ^ 0x6380DCD5));
			case 10:
				if (value is BinaryFile)
				{
					binaryFile = (BinaryFile)value;
					num2 = 6;
				}
				else
				{
					num2 = 8;
				}
				break;
			case 6:
				if (string.IsNullOrEmpty(binaryFile.SecondId))
				{
					num2 = 7;
					break;
				}
				goto case 11;
			case 14:
				criteria.Add((ICriterion)PkT1dWoxBg7RsLeHIA87(text, new object[2]
				{
					HB3Ymao7zTpKrkWp0FIR(binaryFile),
					Nq45rloxFj8unxfITlvS(binaryFile)
				}, new IType[2]
				{
					(IType)NHibernateUtil.String,
					(IType)NHibernateUtil.String
				}));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			case 11:
				simpleTypeSettings = LwRXfCo7LmTA3LmImNCw(propertyMetadata) as SimpleTypeSettings;
				num2 = 16;
				break;
			case 16:
				if (simpleTypeSettings == null)
				{
					return;
				}
				num2 = 13;
				break;
			case 2:
				throw new ArgumentNullException((string)gvd4Wxo7jSDjyfUOqlB2(-1146510045 ^ -1146491791));
			case 3:
				if (criteria == null)
				{
					num2 = 9;
					break;
				}
				goto case 10;
			case 5:
				return;
			case 7:
				OAVvLCoxGxAj1rqVdDc5(criteria, oJNhqsoxhA9fnVuUx3da(mkNnRboxWuoX2O6FL34R(alias) ? propertyMetadata.Name : alY2Iqoxb8KWuNJNwxfQ(gvd4Wxo7jSDjyfUOqlB2(-195614443 ^ -195597545), alias, rUIVRioxoffAgKTmGbJ8(propertyMetadata)), value));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public override TypeSerializationDescriptor GetSerializeDescriptor(ClassMetadata metadata, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00a1
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		string description = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass21_.propertyMetadata = propertyMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (mkNnRboxWuoX2O6FL34R(XlynWfoxEMy43m1fFGIX(_003C_003Ec__DisplayClass21_.propertyMetadata)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				}
				obj = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16590965), _003C_003Ec__DisplayClass21_.propertyMetadata.DisplayName, i1oeGtoxfFcUcCNukoQf(this, _003C_003Ec__DisplayClass21_.propertyMetadata));
				goto IL_0105;
			case 3:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 2;
				break;
			case 1:
				obj = "";
				goto IL_0105;
			case 5:
				return new TypeSerializationDescriptorBuilder().Description(description).Item(_003C_003Ec__DisplayClass21_._003CGetSerializeDescriptor_003Eb__0).Descriptor;
			case 4:
				{
					_003C_003Ec__DisplayClass21_.descr = (string)((!mkNnRboxWuoX2O6FL34R(XlynWfoxEMy43m1fFGIX(_003C_003Ec__DisplayClass21_.propertyMetadata))) ? c7sYShoxCaBDpp2XchFs(gvd4Wxo7jSDjyfUOqlB2(0x3A5D5EF ^ 0x3A75C67), XlynWfoxEMy43m1fFGIX(_003C_003Ec__DisplayClass21_.propertyMetadata), wIWcJkoxQL8801H4xG8m(_003C_003Ec__DisplayClass21_.propertyMetadata), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E0F222), GetPropertyTypeDisplayName(_003C_003Ec__DisplayClass21_.propertyMetadata))) : "");
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_0105:
				description = (string)obj;
				num2 = 4;
				break;
			}
		}
	}

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538537688));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31322854));
		}
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		object value = property.GetValue(obj, null);
		return new SerializableDictionary<string, object> { [propertyMetadata.Name] = SerializeSimple(value, property.PropertyType, settings) };
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return BinaryFileInDictionary(value as BinaryFile);
			default:
				throw new ArgumentNullException((string)gvd4Wxo7jSDjyfUOqlB2(-889460160 ^ -889625604));
			case 1:
				if (!OeDeOUoxvsE369qUm70F(valueType, null))
				{
					if (!dBqNWRox8VKbJqiHm58o(typeof(BinaryFile).TypeHandle).IsAssignableFrom(valueType))
					{
						return base.SerializeSimple(value, valueType, settings);
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public override void Deserialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		if (obj != null && values != null)
		{
			if (metadata == null)
			{
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234318290));
			}
			if (propertyMetadata == null)
			{
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672105367));
			}
			obj = obj.CastAsRealType();
			PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
			if (!(property == null) && property.CanWrite && values.TryGetValue(propertyMetadata.Name, out var value))
			{
				property.SetValue(obj, DeserializeSimple(value, TypeOf<BinaryFile>.Raw), null);
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_005e, IL_006d, IL_0096, IL_00a5, IL_0141, IL_0150
		int num = 10;
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		BinaryFile result2 = default(BinaryFile);
		Guid result = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (dictionary != null)
					{
						num2 = 8;
						continue;
					}
					goto default;
				case 3:
					return result2;
				case 2:
					break;
				default:
					return null;
				case 8:
					Guid.TryParse(dictionary[(string)gvd4Wxo7jSDjyfUOqlB2(0x53CB464B ^ 0x53CB29D9)].ToString(), out result);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					throw new ArgumentNullException((string)gvd4Wxo7jSDjyfUOqlB2(--1360331293 ^ 0x51154B99));
				case 9:
					if (!dBqNWRox8VKbJqiHm58o(typeof(BinaryFile).TypeHandle).IsAssignableFrom(deserializeToType))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 5;
				case 5:
					if ((result2 = value as BinaryFile) == null)
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 10:
					if (!(deserializeToType == null))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 4;
				case 1:
					return EdTNFsoxZgNLos1Mbemy(result);
				case 6:
					return base.DeserializeSimple(value, deserializeToType);
				}
				break;
			}
			dictionary = value as IDictionary<string, object>;
			num = 7;
		}
	}

	public BinaryFileDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KEWIHXoxuHyChdPfULqq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static BinaryFileDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12469576));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				KEWIHXoxuHyChdPfULqq();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void POV1sCo7dLpqwRlJ8OtT(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<BinaryFile>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static void NhZSwxo7llfQaxDNFhVt(object P_0, int length)
	{
		((INHibernatePropertyTypeMapper)P_0).Length(length);
	}

	internal static bool SYhvXFo7Jp9uNgkQU05t()
	{
		return CYUZcuo7MTNNWbDZmEJo == null;
	}

	internal static BinaryFileDescriptor BxtUcto79Bo7LDwrTHW4()
	{
		return CYUZcuo7MTNNWbDZmEJo;
	}

	internal static object Nyo6Ovo7rILmHkbZbdqD()
	{
		return DataAccessManager.FileManager;
	}

	internal static object Yc55IJo7g7TnsFIGLMFF(object P_0, object P_1)
	{
		return ((IFileManager)P_0).LoadFile((string)P_1);
	}

	internal static object ri5KlUo75uUcN6UbD1Zx(object P_0, Guid uid)
	{
		return ((ICacheFilesService)P_0).GetBinaryFile(uid);
	}

	internal static object gvd4Wxo7jSDjyfUOqlB2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aQIeOco7Yo2E5XjFOmeB(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object LwRXfCo7LmTA3LmImNCw(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object yTd33ao7UUv8WW8mv4po(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static object TDIs12o7sWvTSaDy57d1(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object iR71Ygo7c2n49ElOhHji(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object HB3Ymao7zTpKrkWp0FIR(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static object Nq45rloxFj8unxfITlvS(object P_0)
	{
		return ((BinaryFile)P_0).SecondId;
	}

	internal static object PkT1dWoxBg7RsLeHIA87(object P_0, object P_1, object P_2)
	{
		return Expression.Sql((string)P_0, (object[])P_1, (IType[])P_2);
	}

	internal static bool mkNnRboxWuoX2O6FL34R(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object rUIVRioxoffAgKTmGbJ8(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object alY2Iqoxb8KWuNJNwxfQ(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object oJNhqsoxhA9fnVuUx3da(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object OAVvLCoxGxAj1rqVdDc5(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object XlynWfoxEMy43m1fFGIX(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object i1oeGtoxfFcUcCNukoQf(object P_0, object P_1)
	{
		return ((TypeDescriptor)P_0).GetPropertyTypeDisplayName((PropertyMetadata)P_1);
	}

	internal static object wIWcJkoxQL8801H4xG8m(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static object c7sYShoxCaBDpp2XchFs(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool OeDeOUoxvsE369qUm70F(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type dBqNWRox8VKbJqiHm58o(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object EdTNFsoxZgNLos1Mbemy(Guid uid)
	{
		return Download(uid);
	}

	internal static void KEWIHXoxuHyChdPfULqq()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
