using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

public class EntitySerializationSelector
{
	public const string ToStringPropertyName = "$toString";

	private static EntitySerializationSelector UWjn7ABrFMbVIwYoIv9u;

	public Dictionary<string, EntitySerializationSelector> Properties { get; set; }

	public SelectionMode SelectionMode
	{
		[CompilerGenerated]
		get
		{
			return _003CSelectionMode_003Ek__BackingField;
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
					_003CSelectionMode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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

	public static EntitySerializationSelector GetFromParent(EntitySerializationSelector parentSelector, string propertyName)
	{
		//Discarded unreachable code: IL_0055
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (parentSelector != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			default:
				return null;
			case 1:
				if (parentSelector.Properties == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 4:
				break;
			}
			if (parentSelector.Properties.ContainsKey(propertyName))
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
			{
				num2 = 0;
			}
		}
		return parentSelector.Properties[propertyName];
	}

	public static EntitySerializationSelector CreateFromSelect(string selectPath, EntityMetadata entityMd)
	{
		//Discarded unreachable code: IL_00c7, IL_00d6, IL_00e5, IL_011a, IL_0129, IL_0138, IL_027e, IL_02a1, IL_036a, IL_044c, IL_050f
		int num = 29;
		int num2 = num;
		EntitySerializationSelector entitySerializationSelector = default(EntitySerializationSelector);
		IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		string selectPath2 = default(string);
		_003C_003Ef__AnonymousType20<string, string> anon = default(_003C_003Ef__AnonymousType20<string, string>);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		int num3 = default(int);
		_003C_003Ef__AnonymousType20<string, string>[] array = default(_003C_003Ef__AnonymousType20<string, string>[]);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			object obj2;
			switch (num2)
			{
			case 27:
				HVpE4jBrh7BQhlMFOsiJ(entitySerializationSelector, SelectionMode.Default);
				num2 = 4;
				continue;
			case 5:
				if (!QoV7OCBrblOuScDZy33Y(selectPath, n15C9UBro8cWD09enG23(-867826612 ^ -867805668)))
				{
					num2 = 30;
					continue;
				}
				goto case 25;
			case 20:
			case 24:
				propertyMetadata = entityMd.GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass2_._003CCreateFromSelect_003Eb__6);
				num2 = 18;
				continue;
			case 17:
				throw new ArgumentOutOfRangeException((string)n15C9UBro8cWD09enG23(0x1637C429 ^ 0x1636B179), (string)YEueUNBrQ1JM1h5Qq0h0(n15C9UBro8cWD09enG23(0x61EC0CB8 ^ 0x61ED792A), _003C_003Ec__DisplayClass2_.rootPropertyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3386958), xCPj4qBrffKC0HQOIpJn(entityMd)));
			case 19:
				if (!IcNJICBrGPXwynum58Td(selectPath2))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					entitySerializationSelector.Properties.Add(_003C_003Ec__DisplayClass2_.rootPropertyName, new EntitySerializationSelector
					{
						SelectionMode = SelectionMode.Default
					});
					num2 = 31;
				}
				continue;
			case 7:
				throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138097880), (string)HcmSmNBrvpke5QCFHISR(n15C9UBro8cWD09enG23(-1876063057 ^ -1876100739), selectPath2, n15C9UBro8cWD09enG23(-1710575414 ^ -1710504654)));
			case 18:
				if (propertyMetadata != null)
				{
					selectPath2 = anon.SelectPath;
					num2 = 11;
					continue;
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 17;
				}
				continue;
			case 22:
				obj2 = serviceNotNull.GetMetadata(XoQJC0BrCSTKVHfnUAe3(propertyMetadata)) as EntityMetadata;
				break;
			case 36:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 32;
				continue;
			case 2:
				entitySerializationSelector.SelectionMode = SelectionMode.All;
				num2 = 33;
				continue;
			case 21:
			{
				Dictionary<string, EntitySerializationSelector> properties = entitySerializationSelector.Properties;
				string rootPropertyName = _003C_003Ec__DisplayClass2_.rootPropertyName;
				EntitySerializationSelector entitySerializationSelector2 = new EntitySerializationSelector();
				HVpE4jBrh7BQhlMFOsiJ(entitySerializationSelector2, SelectionMode.Default);
				properties.Add(rootPropertyName, entitySerializationSelector2);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 9;
				}
				continue;
			}
			case 25:
				HVpE4jBrh7BQhlMFOsiJ(entitySerializationSelector, SelectionMode.All);
				num2 = 3;
				continue;
			case 6:
				if (!QoV7OCBrblOuScDZy33Y(_003C_003Ec__DisplayClass2_.rootPropertyName, n15C9UBro8cWD09enG23(-281842504 ^ -281929276)))
				{
					num2 = 20;
					continue;
				}
				goto case 21;
			default:
				if (num3 < array.Length)
				{
					num2 = 16;
					continue;
				}
				goto case 34;
			case 29:
				if (selectPath == null)
				{
					num2 = 28;
					continue;
				}
				if (entityMd != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 10;
			case 10:
				throw new ArgumentNullException((string)n15C9UBro8cWD09enG23(0x7E6E5A0B ^ 0x7E6F2F63));
			case 1:
				entitySerializationSelector = new EntitySerializationSelector();
				num2 = 5;
				continue;
			case 15:
				if (QoV7OCBrblOuScDZy33Y(_003C_003Ec__DisplayClass2_.rootPropertyName, n15C9UBro8cWD09enG23(0x3630F361 ^ 0x3630A131)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 6;
			case 9:
			case 23:
			case 31:
			case 33:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				continue;
			case 34:
				return entitySerializationSelector;
			case 12:
				entitySerializationSelector.Properties.Add(_003C_003Ec__DisplayClass2_.rootPropertyName, (EntitySerializationSelector)Q8f3S9Br8uO2HRre8aFK(selectPath2, entityMetadata));
				num2 = 23;
				continue;
			case 3:
				return entitySerializationSelector;
			case 30:
				if (!IcNJICBrGPXwynum58Td(selectPath))
				{
					num2 = 8;
					continue;
				}
				goto case 27;
			case 13:
				if (entityMetadata == null)
				{
					num2 = 19;
					continue;
				}
				goto case 12;
			case 28:
				throw new ArgumentNullException((string)n15C9UBro8cWD09enG23(-210725949 ^ -210639213));
			case 14:
			case 16:
				anon = array[num3];
				num2 = 36;
				continue;
			case 32:
				_003C_003Ec__DisplayClass2_.rootPropertyName = anon.Root;
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 2;
				}
				continue;
			case 11:
				if (!(propertyMetadata is TablePartMetadata))
				{
					num2 = 22;
					continue;
				}
				obj2 = propertyMetadata as EntityMetadata;
				break;
			case 35:
				num3 = 0;
				num2 = 26;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 16;
				}
				continue;
			case 4:
				return entitySerializationSelector;
			case 8:
			{
				object obj = Qg0iasBrECsXqmTVodp5(selectPath, new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307ECD21) }, StringSplitOptions.RemoveEmptyEntries);
				if (((Array)obj).Length != 0)
				{
					entitySerializationSelector.Properties = new Dictionary<string, EntitySerializationSelector>();
					HVpE4jBrh7BQhlMFOsiJ(entitySerializationSelector, SelectionMode.ByName);
				}
				serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				array = (from p in (IEnumerable<string>)obj
					where !_003C_003Ec.yyvlqcQ2sgMYs8cev2wE(p)
					select (string[])_003C_003Ec.bqwamTQ2ztB9uevo0gPS(p, new string[1] { (string)_003C_003Ec.vP0I6JQ2ce5tqpwMjUf9(0xE1229CF ^ 0xE124D9F) }, StringSplitOptions.RemoveEmptyEntries) into pl
					select new
					{
						r = pl[0],
						s = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398686964), (pl.Length > 1) ? pl.Skip(1).ToArray() : new string[0])
					} into t
					group t by t.r into g
					select new
					{
						Root = g.Key,
						SelectPath = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC11540), g.Select(t => t.s))
					}).ToArray();
				num2 = 35;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 20;
				}
				continue;
			}
			}
			entityMetadata = (EntityMetadata)obj2;
			num2 = 13;
		}
	}

	public EntitySerializationSelector GetSelector(string propertyName)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					if (SelectionMode == SelectionMode.Default)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 0;
						}
						continue;
					}
					if (SelectionMode != SelectionMode.ByName)
					{
						if (SelectionMode != SelectionMode.All)
						{
							return null;
						}
						goto end_IL_0012;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return (EntitySerializationSelector)n68csQBrZp5xR1102QdW(this, propertyName);
				default:
					return null;
				case 4:
					obj = n68csQBrZp5xR1102QdW(this, propertyName);
					if (obj != null)
					{
						break;
					}
					num2 = 3;
					continue;
				case 3:
					obj = new EntitySerializationSelector
					{
						SelectionMode = SelectionMode.Default
					};
					break;
				}
				return (EntitySerializationSelector)obj;
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public EntitySerializationSelector()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GDrwFEBruSRMCKZRtdKX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EHTpqNBrByqjDQld5Xuj()
	{
		return UWjn7ABrFMbVIwYoIv9u == null;
	}

	internal static EntitySerializationSelector q0qNAJBrWuVBvZIfp9gt()
	{
		return UWjn7ABrFMbVIwYoIv9u;
	}

	internal static object n15C9UBro8cWD09enG23(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool QoV7OCBrblOuScDZy33Y(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void HVpE4jBrh7BQhlMFOsiJ(object P_0, SelectionMode value)
	{
		((EntitySerializationSelector)P_0).SelectionMode = value;
	}

	internal static bool IcNJICBrGPXwynum58Td(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object Qg0iasBrECsXqmTVodp5(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object xCPj4qBrffKC0HQOIpJn(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object YEueUNBrQ1JM1h5Qq0h0(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static Guid XoQJC0BrCSTKVHfnUAe3(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static object HcmSmNBrvpke5QCFHISR(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object Q8f3S9Br8uO2HRre8aFK(object P_0, object P_1)
	{
		return CreateFromSelect((string)P_0, (EntityMetadata)P_1);
	}

	internal static object n68csQBrZp5xR1102QdW(object P_0, object P_1)
	{
		return GetFromParent((EntitySerializationSelector)P_0, (string)P_1);
	}

	internal static void GDrwFEBruSRMCKZRtdKX()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
