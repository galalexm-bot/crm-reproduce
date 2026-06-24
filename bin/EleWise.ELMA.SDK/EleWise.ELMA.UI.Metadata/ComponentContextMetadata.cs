using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
[DataContract]
public class ComponentContextMetadata : ClassMetadata
{
	private static ComponentContextMetadata xRiYR7BGVn6TxstqHbdr;

	public override void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_003e, IL_004d, IL_00a3, IL_00b2, IL_00bd, IL_0167, IL_019f
		int num = 5;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				base.LoadFromType(type, inherit);
				num2 = 6;
				continue;
			case 4:
				if (classMetadata != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 5:
				classMetadata = (ClassMetadata)DhhE52BGRN4jeNAN6bIa(type);
				num2 = 4;
				continue;
			case 6:
				return;
			case 2:
				enumerator = KIUY0lBGqAysKPhwa3Xi(this).GetProperties().Where(delegate(PropertyInfo p)
				{
					//Discarded unreachable code: IL_0035, IL_0044, IL_005d, IL_006c
					int num5 = 2;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						case 3:
							return p.CanWrite;
						case 1:
						case 4:
							return false;
						case 2:
							if (((Array)_003C_003Ec.RpJtn4QoOOCQk5hyUOLU(p)).Length != 0)
							{
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
								{
									num6 = 0;
								}
								break;
							}
							goto default;
						default:
							if (!_003C_003Ec.AuFm1TQo29bt79UOp87A(p))
							{
								num6 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num6 = 4;
								}
								break;
							}
							goto case 3;
						}
					}
				}).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num3 = 1;
						}
						goto IL_00c1;
					}
					goto IL_011e;
					IL_011e:
					current = enumerator.Current;
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num3 = 2;
					}
					goto IL_00c1;
					IL_00c1:
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 3:
							break;
						case 2:
							aGsA21BGXLI6cCKFdeFu(current, this, gXcMmDBGK0Dox9QEByvK(current, classMetadata, null), null);
							num3 = 3;
							continue;
						default:
							goto IL_011e;
						}
						break;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							iCXD9VBGTKnPy6WBj1jP(enumerator);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	internal static ClassMetadata FindMetadata(Type type)
	{
		//Discarded unreachable code: IL_0039
		int num = 5;
		int num2 = num;
		Type type2 = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return null;
			case 5:
				if (type.IsNested)
				{
					type2 = dLwLthBGk0omupUyhCHG(type);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 1:
				if (!(type2 == null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return null;
			default:
			{
				ComponentMetadata obj = MetadataLoader.LoadMetadata(type2) as ComponentMetadata;
				if (obj == null)
				{
					num2 = 2;
					break;
				}
				return (ClassMetadata)gTDeWJBGnKPo1suM05pa(obj.Content);
			}
			case 2:
				return null;
			}
		}
	}

	public ComponentContextMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object DhhE52BGRN4jeNAN6bIa(Type type)
	{
		return FindMetadata(type);
	}

	internal static Type KIUY0lBGqAysKPhwa3Xi(object P_0)
	{
		return P_0.GetType();
	}

	internal static object gXcMmDBGK0Dox9QEByvK(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void aGsA21BGXLI6cCKFdeFu(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static void iCXD9VBGTKnPy6WBj1jP(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool nY9ij8BGS9YqfaNU1hnU()
	{
		return xRiYR7BGVn6TxstqHbdr == null;
	}

	internal static ComponentContextMetadata ajaX0cBGiRv2QNfLFp8B()
	{
		return xRiYR7BGVn6TxstqHbdr;
	}

	internal static Type dLwLthBGk0omupUyhCHG(object P_0)
	{
		return ((MemberInfo)P_0).ReflectedType;
	}

	internal static object gTDeWJBGnKPo1suM05pa(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}
}
