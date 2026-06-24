using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class EntityActionsMetadata : EnumMetadata
{
	internal static EntityActionsMetadata dEJ0Dpb6z1Oa3q9XFYF2;

	protected override void LoadValuesFromType(Type type, bool inherit)
	{
		//Discarded unreachable code: IL_0074, IL_0083, IL_00b4, IL_00c3, IL_01c3, IL_0203, IL_0212, IL_021e, IL_022e, IL_023c, IL_032d, IL_0365, IL_0374
		int num = 2;
		int num2 = num;
		BindingFlags bindingFlags = default(BindingFlags);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current2 = default(PropertyInfo);
		EnumValueMetadata enumValueMetadata2 = default(EnumValueMetadata);
		IEnumerator<FieldInfo> enumerator2 = default(IEnumerator<FieldInfo>);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		FieldInfo current = default(FieldInfo);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 2:
				bindingFlags = BindingFlags.Static | BindingFlags.Public;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				bindingFlags |= BindingFlags.DeclaredOnly;
				num2 = 4;
				continue;
			case 1:
				if (inherit)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 8:
				try
				{
					while (true)
					{
						IL_0115:
						int num5;
						if (!EFK8F6bHorBWUcsGpvjY(enumerator))
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num5 = 0;
							}
							goto IL_00d2;
						}
						goto IL_0162;
						IL_0162:
						current2 = enumerator.Current;
						num5 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num5 = 4;
						}
						goto IL_00d2;
						IL_00d2:
						while (true)
						{
							switch (num5)
							{
							case 4:
								enumValueMetadata2 = new EnumValueMetadata();
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num5 = 2;
								}
								continue;
							case 1:
								goto IL_0115;
							case 5:
								base.Values.Add(enumValueMetadata2);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
								{
									num5 = 0;
								}
								continue;
							case 3:
								goto IL_0162;
							case 2:
							{
								enumValueMetadata2.LoadFromMember(current2);
								int num6 = 5;
								num5 = num6;
								continue;
							}
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					int num7;
					if (enumerator == null)
					{
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num7 = 1;
						}
						goto IL_01c7;
					}
					goto IL_01dd;
					IL_01dd:
					S7y5KubHbXQ9CbRGZbXU(enumerator);
					num7 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num7 = 2;
					}
					goto IL_01c7;
					IL_01c7:
					switch (num7)
					{
					case 1:
						goto end_IL_01a2;
					case 2:
						goto end_IL_01a2;
					}
					goto IL_01dd;
					end_IL_01a2:;
				}
				break;
			case 7:
				try
				{
					while (true)
					{
						IL_02f1:
						int num3;
						if (!EFK8F6bHorBWUcsGpvjY(enumerator2))
						{
							num3 = 4;
							goto IL_0240;
						}
						goto IL_0286;
						IL_0240:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							case 3:
								enumValueMetadata.LoadFromMember(current);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num3 = 5;
								}
								continue;
							case 2:
								break;
							default:
								enumValueMetadata = new EnumValueMetadata();
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num3 = 3;
								}
								continue;
							case 5:
								base.Values.Add(enumValueMetadata);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								goto IL_02f1;
							}
							break;
						}
						goto IL_0286;
						IL_0286:
						current = enumerator2.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num3 = 0;
						}
						goto IL_0240;
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								enumerator2.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
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
			default:
				enumerator = ((IEnumerable<PropertyInfo>)tkweqZbHWSbi3jshIKIB(type, bindingFlags)).Where((PropertyInfo fi) => _003C_003Ec.MeUwwCCwpkHNG93QHuoO(fi, _003C_003Ec.dd8GVlCw3FjbDpSScpd4(typeof(UidAttribute).TypeHandle), false)).GetEnumerator();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 5;
				}
				continue;
			case 6:
				break;
			}
			enumerator2 = ((IEnumerable<FieldInfo>)F3s9wgbHhrW1XoLUUD3m(type, bindingFlags)).Where((FieldInfo fi) => _003C_003Ec.MeUwwCCwpkHNG93QHuoO(fi, _003C_003Ec.dd8GVlCw3FjbDpSScpd4(typeof(UidAttribute).TypeHandle), false)).GetEnumerator();
			num2 = 7;
		}
	}

	public EntityActionsMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object tkweqZbHWSbi3jshIKIB(Type type, BindingFlags bindingAttr)
	{
		return type.GetReflectionProperties(bindingAttr);
	}

	internal static bool EFK8F6bHorBWUcsGpvjY(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void S7y5KubHbXQ9CbRGZbXU(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object F3s9wgbHhrW1XoLUUD3m(Type type, BindingFlags bindingAttr)
	{
		return type.GetReflectionFields(bindingAttr);
	}

	internal static bool jL58QVbHFxBfsrIk78vr()
	{
		return dEJ0Dpb6z1Oa3q9XFYF2 == null;
	}

	internal static EntityActionsMetadata TbZHfsbHBiF8oQKkJ5v7()
	{
		return dEJ0Dpb6z1Oa3q9XFYF2;
	}
}
