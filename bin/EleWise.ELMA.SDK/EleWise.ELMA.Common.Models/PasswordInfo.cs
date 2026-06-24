using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Common.Models;

[Serializable]
[XmlRoot("Password")]
[Component]
public class PasswordInfo : IXsiType, ICloneable
{
	[NonSerialized]
	private static IEnumerable<IPasswordResolver> resolvers;

	[NonSerialized]
	private IPasswordResolver passwordResolver;

	private Guid passwordType;

	internal static PasswordInfo N3caOsfS8CcaKsxgatuw;

	[XmlIgnore]
	private IEnumerable<IPasswordResolver> Resolvers => resolvers ?? (resolvers = Locator.GetServiceNotNull<IEnumerable<IPasswordResolver>>());

	public string Hash
	{
		[CompilerGenerated]
		get
		{
			return _003CHash_003Ek__BackingField;
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
					_003CHash_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

	public string Salt
	{
		[CompilerGenerated]
		get
		{
			return _003CSalt_003Ek__BackingField;
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
					_003CSalt_003Ek__BackingField = value;
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

	protected bool Equals(PasswordInfo other)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (other == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (this == other)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 2;
					}
					break;
				}
				return nROdsYfSIvMgQ2j58dMZ(other.Hash, Hash);
			default:
				return false;
			case 2:
				return true;
			}
		}
	}

	internal void InitPasswordResolver(Guid? passwordType)
	{
		if (passwordResolver != null)
		{
			return;
		}
		if (passwordType.HasValue)
		{
			this.passwordType = passwordType.Value;
		}
		if (passwordResolver == null)
		{
			passwordResolver = Resolvers.FirstOrDefault((IPasswordResolver r) => W4UWy4fSk9TQv0xngBdb(Cd698cfST7coYy8gpOsy(r), this.passwordType));
		}
	}

	internal PasswordInfo(string password, Guid passwordType)
	{
		//Discarded unreachable code: IL_001e, IL_009b, IL_00aa
		UB9gQwfSVWRij1t8iZ3U();
		base._002Ector();
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Hash = (string)eYli0MfSiQRmyj8WpKLi(passwordResolver, password, Salt);
				num2 = 2;
				break;
			default:
				Salt = (string)GLXX8AfSSSpXJ9aD5lgh(passwordResolver);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 3:
				if (passwordResolver == null)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 5:
				InitPasswordResolver(passwordType);
				num2 = 3;
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

	internal PasswordInfo(string hash, string salt, Guid passwordType)
	{
		//Discarded unreachable code: IL_001a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				InitPasswordResolver(passwordType);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num = 0;
				}
				break;
			case 4:
			{
				Hash = hash;
				int num2 = 3;
				num = num2;
				break;
			}
			case 2:
				this.passwordType = passwordType;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				Salt = salt;
				num = 2;
				break;
			}
		}
	}

	internal bool Check(string password)
	{
		//Discarded unreachable code: IL_006d, IL_007c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (passwordResolver != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return false;
			case 1:
				return KjvJpefSRNmSKIe7IlOr(passwordResolver, Hash, Salt, password);
			}
		}
	}

	internal string GetPassword()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				IPasswordResolver obj = passwordResolver;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)CRDku4fSqgUAB9jRIAve(obj, Hash, Salt);
			}
			default:
				return null;
			}
		}
	}

	public PasswordInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public object Clone()
	{
		return new PasswordInfo(Hash, Salt, passwordType);
	}

	public bool IsEmpty()
	{
		return string.IsNullOrEmpty(Hash);
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return false;
			case 1:
				if (this == obj)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					if (!NVRsiXfSX5ils1yY4rg2(obj.GetType(), GgxF3wfSKSYBmIIDqtP4(typeof(PasswordInfo).TypeHandle)))
					{
						return Equals((PasswordInfo)obj);
					}
					num2 = 3;
				}
				break;
			case 3:
				return false;
			case 2:
				if (obj != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			default:
				return true;
			}
		}
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = Hash;
				if (text == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				text = string.Empty;
				break;
			}
			break;
		}
		return (text.GetHashCode() * 397) ^ (Salt ?? string.Empty).GetHashCode();
	}

	internal static bool nROdsYfSIvMgQ2j58dMZ(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool BMNBdtfSZsuCFGD3s36l()
	{
		return N3caOsfS8CcaKsxgatuw == null;
	}

	internal static PasswordInfo IuA8a3fSueQUxC5ylx3t()
	{
		return N3caOsfS8CcaKsxgatuw;
	}

	internal static void UB9gQwfSVWRij1t8iZ3U()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object GLXX8AfSSSpXJ9aD5lgh(object P_0)
	{
		return ((IPasswordResolver)P_0).GenerateSalt();
	}

	internal static object eYli0MfSiQRmyj8WpKLi(object P_0, object P_1, object P_2)
	{
		return ((IPasswordResolver)P_0).Encrypt((string)P_1, (string)P_2);
	}

	internal static bool KjvJpefSRNmSKIe7IlOr(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IPasswordResolver)P_0).Check((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object CRDku4fSqgUAB9jRIAve(object P_0, object P_1, object P_2)
	{
		return ((IPasswordResolver)P_0).Decrypt((string)P_1, (string)P_2);
	}

	internal static Type GgxF3wfSKSYBmIIDqtP4(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool NVRsiXfSX5ils1yY4rg2(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid Cd698cfST7coYy8gpOsy(object P_0)
	{
		return ((IPasswordResolver)P_0).Uid;
	}

	internal static bool W4UWy4fSk9TQv0xngBdb(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
