using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.DTO.Models;

[Serializable]
public class BPMAppDTO : EntityDTO<long>, ISerializable
{
	internal static BPMAppDTO hWpPpqfnAmXqOEQLKdRq;

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string AppId
	{
		[CompilerGenerated]
		get
		{
			return _003CAppId_003Ek__BackingField;
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
					_003CAppId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
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

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return _003CTitle_003Ek__BackingField;
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
					_003CTitle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ElmaStoreComponentManifest ComponentManifest
	{
		[CompilerGenerated]
		get
		{
			return _003CComponentManifest_003Ek__BackingField;
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
					_003CComponentManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BPMAppManifest AppManifest
	{
		[CompilerGenerated]
		get
		{
			return _003CAppManifest_003Ek__BackingField;
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
					_003CAppManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
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

	public BPMAppFakeManifest AppFakeManifest
	{
		[CompilerGenerated]
		get
		{
			return _003CAppFakeManifest_003Ek__BackingField;
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
					_003CAppFakeManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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

	public bool Installed
	{
		[CompilerGenerated]
		get
		{
			return _003CInstalled_003Ek__BackingField;
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
					_003CInstalled_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public byte[] IconData
	{
		[CompilerGenerated]
		get
		{
			return _003CIconData_003Ek__BackingField;
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
					_003CIconData_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string IconFileName
	{
		[CompilerGenerated]
		get
		{
			return _003CIconFileName_003Ek__BackingField;
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
					_003CIconFileName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
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

	public string[] CertificateThumbprints
	{
		[CompilerGenerated]
		get
		{
			return _003CCertificateThumbprints_003Ek__BackingField;
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
					_003CCertificateThumbprints_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BPMAppDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected BPMAppDTO(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_00ad, IL_00bc, IL_00c7, IL_0181, IL_01b9, IL_01c8
		sUlZJrfn0MW4K5vTCqHT();
		base._002Ector();
		int num = 3;
		object obj = default(object);
		string xml = default(string);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				obj = ClassSerializationHelper.DeserializeObjectByXml(GetType(), xml);
				num = 2;
				break;
			case 0:
				return;
			case 3:
				xml = (string)jr4LWqfnmUnrjZnIbcup(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889502008), typeof(string));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num = 0;
				}
				break;
			case 5:
				try
				{
					while (true)
					{
						int num2;
						if (!HUnsZ1fnJ0qtmBoHQUiK(enumerator))
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
							{
								num2 = 2;
							}
							goto IL_00cb;
						}
						goto IL_010b;
						IL_010b:
						current = enumerator.Current;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						goto IL_00cb;
						IL_00cb:
						while (true)
						{
							switch (num2)
							{
							case 3:
								return;
							case 1:
								goto IL_010b;
							case 2:
								WiEFwofnM46GOWk1g9q8(current, this, fRKAeRfnygZoPfhB74vn(current, obj, null), null);
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num2 = 0;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								nQwHPQfn9325gVa8pjgA(enumerator);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				if (obj == null)
				{
					return;
				}
				num = 4;
				break;
			case 4:
				enumerator = obj.GetType().GetProperties().Where(delegate(PropertyInfo p)
				{
					//Discarded unreachable code: IL_005a, IL_0069, IL_009b
					int num4 = 1;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						case 1:
							if (!p.CanRead)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num5 = 0;
								}
								break;
							}
							goto case 2;
						case 2:
							if (!_003C_003Ec.mBmoPO8zvAdpoAePIKql(p))
							{
								num5 = 4;
								break;
							}
							goto case 3;
						case 3:
							return AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) == null;
						default:
							return false;
						}
					}
				})
					.GetEnumerator();
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
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
				ETtpcsfnll2fqpmUEAGE(info, WAr9Lrfnd6mDTnY8v0qg(-538519530 ^ -538544994), ClassSerializationHelper.SerializeObjectByXml(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool mK7fuLfn7SufrGgHbNVE()
	{
		return hWpPpqfnAmXqOEQLKdRq == null;
	}

	internal static BPMAppDTO bhLNZ2fnxegxa3P4g2YK()
	{
		return hWpPpqfnAmXqOEQLKdRq;
	}

	internal static void sUlZJrfn0MW4K5vTCqHT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object jr4LWqfnmUnrjZnIbcup(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static object fRKAeRfnygZoPfhB74vn(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void WiEFwofnM46GOWk1g9q8(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool HUnsZ1fnJ0qtmBoHQUiK(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void nQwHPQfn9325gVa8pjgA(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object WAr9Lrfnd6mDTnY8v0qg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void ETtpcsfnll2fqpmUEAGE(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
