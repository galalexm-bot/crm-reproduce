using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

public class GroupPermission
{
	private static GroupPermission JdBgUVid6coRYdkJ8vC;

	public virtual IUserGroup Group
	{
		[CompilerGenerated]
		get
		{
			return _003CGroup_003Ek__BackingField;
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
					_003CGroup_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Guid PermissionId
	{
		[CompilerGenerated]
		get
		{
			return _003CPermissionId_003Ek__BackingField;
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
					_003CPermissionId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool Equals(GroupPermission other)
	{
		//Discarded unreachable code: IL_009f, IL_00ae, IL_00eb
		int num = 2;
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return guid.Equals(eF7spmi3nMv5YeuaK3P(this));
				default:
					return false;
				case 3:
					return true;
				case 2:
					if (other != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 6:
					guid = eF7spmi3nMv5YeuaK3P(other);
					num = 5;
					break;
				case 4:
					return false;
				case 1:
					if (this != other)
					{
						if (!KZrqG7irSXio9iOQ74r(CZu0OJi81EcTwAbaUf2(other), CZu0OJi81EcTwAbaUf2(this)))
						{
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 6;
					}
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public override bool Equals(object obj)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return false;
			case 3:
				return true;
			case 2:
				if (obj != null)
				{
					if (this == obj)
					{
						num2 = 3;
						break;
					}
					if (!qjIgj5ibRxMrkDeK2Sc(obj.GetType(), cU0oJRiyhkdq7IQliC2(typeof(GroupPermission).TypeHandle)))
					{
						return V7PjgviSLCPjqapRcmj(this, (GroupPermission)obj);
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 1;
					}
				}
				break;
			default:
				return false;
			}
		}
	}

	public override int GetHashCode()
	{
		//Discarded unreachable code: IL_004f
		int num = 1;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (CZu0OJi81EcTwAbaUf2(this) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = CZu0OJi81EcTwAbaUf2(this).GetHashCode();
				break;
			default:
				num3 = 0;
				break;
			}
			break;
		}
		return (num3 * 397) ^ eF7spmi3nMv5YeuaK3P(this).GetHashCode();
	}

	public GroupPermission()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gci9g2i9Gvj0WZejXLN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool NuFXCJiT2FRwJCbjS6x()
	{
		return JdBgUVid6coRYdkJ8vC == null;
	}

	internal static GroupPermission TfWrQ9igpIdVYiDk5nM()
	{
		return JdBgUVid6coRYdkJ8vC;
	}

	internal static object CZu0OJi81EcTwAbaUf2(object P_0)
	{
		return ((GroupPermission)P_0).Group;
	}

	internal static bool KZrqG7irSXio9iOQ74r(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static Guid eF7spmi3nMv5YeuaK3P(object P_0)
	{
		return ((GroupPermission)P_0).PermissionId;
	}

	internal static Type cU0oJRiyhkdq7IQliC2(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool qjIgj5ibRxMrkDeK2Sc(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool V7PjgviSLCPjqapRcmj(object P_0, object P_1)
	{
		return ((GroupPermission)P_0).Equals((GroupPermission)P_1);
	}

	internal static void gci9g2i9Gvj0WZejXLN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
