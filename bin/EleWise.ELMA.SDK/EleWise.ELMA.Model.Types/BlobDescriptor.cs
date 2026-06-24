using System;
using System.Data;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class BlobDescriptor : CLRTypeDescriptor<byte[], BlobSettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{1911B22D-0CE2-4743-832F-6A44CB0357FE}";

	public static readonly Guid UID;

	private static BlobDescriptor bpEZ4Vo7ENUYtkDTs3bF;

	public override Guid Uid => UID;

	public override string Name => (string)coDbkYo78ehpTeK21EjB(DyeBhlo7via361CO4kUw(-1411196499 ^ -1411358767));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				mapper.Length(int.MaxValue);
				num2 = 3;
				break;
			case 2:
				urjxZVo7CgHuL6QDGbyH(this, mapper, propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				mapper.Type<FixedBinaryUserType>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (value is byte[])
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 1:
				return zPA71Ho7ZAa8b8Ys3mj4(BitConverter.ToString((byte[])value), DyeBhlo7via361CO4kUw(-576149596 ^ -576149048), "");
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_0103, IL_0171
		int num = 8;
		int num2 = num;
		byte[] array = default(byte[]);
		int num4 = default(int);
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 11:
				array = new byte[num4];
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				throw new ArgumentOutOfRangeException((string)DyeBhlo7via361CO4kUw(-420743386 ^ -420757854), (string)coDbkYo78ehpTeK21EjB(DyeBhlo7via361CO4kUw(0x92F12D5 ^ 0x92D944B)));
			case 9:
				num4 = K1yldjo7VjYZF7ty3Afn(text) / 2;
				num2 = 11;
				break;
			case 10:
				if (HNIRtUo7I3YZVYKHDGYj(deserializeToType, oJspKro7uFr0cRY86MHX(typeof(object).TypeHandle)))
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 12;
					}
					break;
				}
				goto IL_00a8;
			case 3:
			case 5:
				array[num3] = SR9wE4o7iVGFnORNPR5O(E7Zv7Fo7SKKMhKvKsDdq(text, num3 * 2, 2), 16);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				num3 = 0;
				num2 = 6;
				break;
			case 1:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (num3 < num4)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 13;
			case 8:
				if (value == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 7;
					}
					break;
				}
				if (!(deserializeToType == null))
				{
					if (HNIRtUo7I3YZVYKHDGYj(deserializeToType, oJspKro7uFr0cRY86MHX(typeof(byte[]).TypeHandle)))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 10;
						}
						break;
					}
					goto IL_00a8;
				}
				num2 = 4;
				break;
			case 13:
				return array;
			case 4:
				throw new ArgumentNullException((string)DyeBhlo7via361CO4kUw(-1710575414 ^ -1710556850));
			case 7:
				{
					throw new ArgumentNullException((string)DyeBhlo7via361CO4kUw(-35995181 ^ -36009819));
				}
				IL_00a8:
				text = value.ToString();
				num2 = 9;
				break;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary, int.MaxValue);
	}

	public BlobDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		F938Hwo7RVNUFhxmD0tR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static BlobDescriptor()
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
				F938Hwo7RVNUFhxmD0tR();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)DyeBhlo7via361CO4kUw(-210725949 ^ -210627375));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void urjxZVo7CgHuL6QDGbyH(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<byte[]>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool W28pCdo7ffeWYOSjGBJF()
	{
		return bpEZ4Vo7ENUYtkDTs3bF == null;
	}

	internal static BlobDescriptor AI8Nmxo7QA5chlb8bSJy()
	{
		return bpEZ4Vo7ENUYtkDTs3bF;
	}

	internal static object DyeBhlo7via361CO4kUw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object coDbkYo78ehpTeK21EjB(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object zPA71Ho7ZAa8b8Ys3mj4(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static Type oJspKro7uFr0cRY86MHX(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool HNIRtUo7I3YZVYKHDGYj(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static int K1yldjo7VjYZF7ty3Afn(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object E7Zv7Fo7SKKMhKvKsDdq(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static byte SR9wE4o7iVGFnORNPR5O(object P_0, int P_1)
	{
		return Convert.ToByte((string)P_0, P_1);
	}

	internal static void F938Hwo7RVNUFhxmD0tR()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
