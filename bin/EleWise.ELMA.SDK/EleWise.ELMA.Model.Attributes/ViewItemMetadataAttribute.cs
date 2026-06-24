using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class ViewItemMetadataAttribute : Attribute
{
	private string uidStr;

	private Type type;

	private Guid? uid;

	internal static ViewItemMetadataAttribute B7Sc5tovfyamHatV4m9Z;

	public string UidStr
	{
		get
		{
			int num = 2;
			int num2 = num;
			Guid guid = default(Guid);
			string text;
			while (true)
			{
				switch (num2)
				{
				case 1:
					guid = Uid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					text = uidStr;
					if (text != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					text = guid.ToString();
					break;
				}
				break;
			}
			return text;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					uid = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					uidStr = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					type = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}
	}

	public Type Type
	{
		get
		{
			int num = 1;
			int num2 = num;
			Type typeByUid;
			while (true)
			{
				switch (num2)
				{
				case 1:
					typeByUid = type;
					if ((object)typeByUid == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(Uid);
					break;
				}
				break;
			}
			return typeByUid;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					type = value;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					uidStr = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					uid = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	public Guid Uid
	{
		get
		{
			//Discarded unreachable code: IL_00ba, IL_00c9, IL_00fb, IL_010a
			int num = 5;
			int num2 = num;
			Guid? guid = default(Guid?);
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (guid.HasValue)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				case 6:
					return Guid.Empty;
				case 2:
					return new Guid(uidStr);
				case 3:
					return guid.GetValueOrDefault();
				case 1:
					if (uidStr != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				default:
					if (qeAZLhovvyXrjP4YL9a6(type, null))
					{
						return InterfaceActivator.UID(type, loadImplementation: false);
					}
					num2 = 6;
					break;
				case 5:
					guid = uid;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 4;
					}
					break;
				}
			}
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					uid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					uidStr = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					type = null;
					num2 = 3;
					break;
				}
			}
		}
	}

	public static ICollection<Guid> GetUids(IMetadata metadata)
	{
		if (!(metadata is ClassMetadata))
		{
			if (metadata == null)
			{
				return null;
			}
			return new Guid[1] { metadata.Uid };
		}
		return MetadataLoader.GetBaseClasses(metadata as ClassMetadata, loadImplementation: false).Union(new IMetadata[1] { metadata }).SelectMany((IMetadata m) => (m is EntityMetadata) ? new Guid[2]
		{
			m.Uid,
			(m as EntityMetadata).ImplementationUid
		} : new Guid[1] { m.Uid })
			.ToArray();
	}

	public static bool IsAvailable<T>(IMetadata metadata)
	{
		return IsAvailable(typeof(T), GetUids(metadata));
	}

	public static bool IsAvailable(Type itemType, ICollection<Guid> uids)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0.uids = uids;
		ViewItemMetadataAttribute[] source = itemType.GetCustomAttributes(typeof(ViewItemMetadataAttribute), inherit: false).Cast<ViewItemMetadataAttribute>().ToArray();
		if (source.Any())
		{
			if (CS_0024_003C_003E8__locals0.uids != null)
			{
				return source.Any((ViewItemMetadataAttribute a) => CS_0024_003C_003E8__locals0.uids.Contains(_003C_003Ec__DisplayClass14_0.TqLAs6CGr1J8p6V0pgFy(a)));
			}
			return false;
		}
		return true;
	}

	public ViewItemMetadataAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a3VdxBov8HQ9aPynLJmB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool GQocu1ovQi6xUoJUYZgE()
	{
		return B7Sc5tovfyamHatV4m9Z == null;
	}

	internal static ViewItemMetadataAttribute y2xWbcovCfmvWxeeb0P6()
	{
		return B7Sc5tovfyamHatV4m9Z;
	}

	internal static bool qeAZLhovvyXrjP4YL9a6(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static void a3VdxBov8HQ9aPynLJmB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
