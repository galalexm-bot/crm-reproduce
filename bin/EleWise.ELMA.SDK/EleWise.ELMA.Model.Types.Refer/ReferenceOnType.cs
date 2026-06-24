using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.References;

[Serializable]
[XmlRoot("ReferenceOnType")]
public sealed class ReferenceOnType : IXsiType
{
	internal static ReferenceOnType T4DExtoUF5T5ytyZt2Z5;

	[XmlElement("TypeUid")]
	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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

	[XmlElement("SubTypeUid")]
	public Guid SubTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSubTypeUid_003Ek__BackingField;
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
					_003CSubTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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

	public ReferenceOnType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IRFrVPoUowuWaOGjyrYh();
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

	public ReferenceOnType(Guid typeUid)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		IRFrVPoUowuWaOGjyrYh();
		this._002Ector(typeUid, Guid.Empty);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ReferenceOnType(Guid typeUid, Guid subTypeUid)
	{
		//Discarded unreachable code: IL_002a
		IRFrVPoUowuWaOGjyrYh();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
			{
				SubTypeUid = subTypeUid;
				int num2 = 2;
				num = num2;
				break;
			}
			case 1:
				TypeUid = typeUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		int num = 2;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				ITypeDescriptor typeDescriptor = this.GetTypeDescriptor();
				if (typeDescriptor == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = TsqeHioUbqcT30m7XgPH(typeDescriptor);
				goto IL_005b;
			}
			case 1:
				obj = null;
				goto IL_005b;
			default:
				{
					obj = string.Empty;
					break;
				}
				IL_005b:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			break;
		}
		return (string)obj;
	}

	public override bool Equals(object o)
	{
		int num = 1;
		int num2 = num;
		ReferenceOnType referenceOnType = default(ReferenceOnType);
		while (true)
		{
			switch (num2)
			{
			default:
				if (referenceOnType != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
				if (jKUhbXoUhA2jwWQCIsPB(TypeUid, referenceOnType.TypeUid))
				{
					num2 = 3;
					continue;
				}
				break;
			case 1:
				referenceOnType = o as ReferenceOnType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return jKUhbXoUhA2jwWQCIsPB(SubTypeUid, referenceOnType.SubTypeUid);
			}
			break;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return BsVH9LoUGPlCkT8qYspO(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998456866), TypeUid, SubTypeUid).GetHashCode();
	}

	internal static void IRFrVPoUowuWaOGjyrYh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ypkLkSoUB3YKWX66sqPj()
	{
		return T4DExtoUF5T5ytyZt2Z5 == null;
	}

	internal static ReferenceOnType C7YfMboUWo0fF5ftwrkE()
	{
		return T4DExtoUF5T5ytyZt2Z5;
	}

	internal static object TsqeHioUbqcT30m7XgPH(object P_0)
	{
		return ((ITypeDescriptor)P_0).Name;
	}

	internal static bool jKUhbXoUhA2jwWQCIsPB(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object BsVH9LoUGPlCkT8qYspO(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
