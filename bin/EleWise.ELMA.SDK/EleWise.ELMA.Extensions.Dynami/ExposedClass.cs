using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.Dynamic;

public class ExposedClass : DynamicObject
{
	private Type m_type;

	private Dictionary<string, Dictionary<int, List<MethodInfo>>> m_staticMethods;

	private Dictionary<string, Dictionary<int, List<MethodInfo>>> m_genStaticMethods;

	internal static ExposedClass mAyQjGGxVAxfmPReyC95;

	private ExposedClass(Type type)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TkUZpWGxRyAVkIXBa09I();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				m_type = type;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num = 1;
				}
				continue;
			case 3:
				return;
			case 1:
				m_staticMethods = (from m in m_type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
					where !_003C_003Ec.Ks2gmZ8QAOKaM7n9YnHZ(m)
					group m by (string)_003C_003Ec.fEVxNM8Q75gsjdK6cQVe(m)).ToDictionary((IGrouping<string, MethodInfo> p) => p.Key, (IGrouping<string, MethodInfo> p) => (from r in p
					group r by ((Array)_003C_003Ec.aD5xCO8Qx1n3pEZiwQbS(r)).Length).ToDictionary((IGrouping<int, MethodInfo> r) => r.Key, (IGrouping<int, MethodInfo> r) => r.ToList()));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num = 0;
				}
				continue;
			}
			m_genStaticMethods = (from m in m_type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
				where _003C_003Ec.Ks2gmZ8QAOKaM7n9YnHZ(m)
				group m by (string)_003C_003Ec.fEVxNM8Q75gsjdK6cQVe(m)).ToDictionary((IGrouping<string, MethodInfo> p) => p.Key, (IGrouping<string, MethodInfo> p) => (from r in p
				group r by r.GetParameters().Length).ToDictionary((IGrouping<int, MethodInfo> r) => r.Key, (IGrouping<int, MethodInfo> r) => r.ToList()));
			num = 3;
		}
	}

	public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		//Discarded unreachable code: IL_00d3, IL_00e2, IL_01b6, IL_01c5, IL_01d5, IL_028b, IL_029a, IL_02a5, IL_0382, IL_0395, IL_03a4, IL_03cc, IL_03db
		int num = 17;
		Type[] array = default(Type[]);
		List<MethodInfo>.Enumerator enumerator = default(List<MethodInfo>.Enumerator);
		List<MethodInfo> list = default(List<MethodInfo>);
		MethodInfo current = default(MethodInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return true;
				case 19:
					if (m_staticMethods.ContainsKey((string)XnHbLJGxKZdJ6cIbEtvR(binder)))
					{
						num2 = 11;
						continue;
					}
					goto case 14;
				case 8:
					return true;
				case 14:
				case 15:
					result = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 18;
					}
					continue;
				case 16:
					if (array != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 10:
					enumerator = m_genStaticMethods[(string)XnHbLJGxKZdJ6cIbEtvR(binder)][args.Length].GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 5;
					}
					continue;
				case 11:
					if (!m_staticMethods[(string)XnHbLJGxKZdJ6cIbEtvR(binder)].ContainsKey(args.Length))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 13;
				case 6:
					if (m_staticMethods.ContainsKey(binder.Name))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 19;
				case 2:
					if (array.Length != 0)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 12:
					if (!m_staticMethods[binder.Name].ContainsKey(args.Length))
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 13:
					list = new List<MethodInfo>();
					num2 = 10;
					continue;
				case 7:
					array = null;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (ExposedObjectHelper.InvokeBestMethod(args, null, m_staticMethods[(string)XnHbLJGxKZdJ6cIbEtvR(binder)][args.Length], out result))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 19;
				case 5:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num3 = 2;
								}
								goto IL_02a9;
							}
							goto IL_0307;
							IL_0307:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
							{
								num3 = 0;
							}
							goto IL_02a9;
							IL_02a9:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 3:
									list.Add((MethodInfo)PkuA8PGxT70LdN3vwF7j(current, array));
									num3 = 4;
									continue;
								case 1:
									goto IL_0307;
								default:
									if (((Array)HrcQm7GxX4AgrYhEbwx9(current)).Length == array.Length)
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
										{
											num3 = 2;
										}
										continue;
									}
									break;
								case 2:
									goto end_IL_02c7;
								}
								break;
							}
							continue;
							end_IL_02c7:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				case 18:
					return false;
				case 17:
					break;
				case 4:
				case 9:
					if (array == null)
					{
						num2 = 6;
						continue;
					}
					goto case 19;
				case 1:
					if (!ExposedObjectHelper.InvokeBestMethod(args, null, list, out result))
					{
						num2 = 14;
						continue;
					}
					goto case 8;
				}
				break;
			}
			array = (Type[])tnLY5KGxqiKGhB2OdItP(binder);
			num = 16;
		}
	}

	public override bool TrySetMember(SetMemberBinder binder, object value)
	{
		//Discarded unreachable code: IL_0062, IL_0071
		int num = 5;
		int num2 = num;
		FieldInfo fieldInfo = default(FieldInfo);
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return true;
			case 2:
				fieldInfo = (FieldInfo)LdAUO7GxeIwRtoL1a0Ko(m_type, DprT56Gx2y2JMfGt2E1W(binder), BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				num2 = 6;
				continue;
			case 4:
				if (!IjBDwHGxn2D1ucZ7Ri37(propertyInfo, null))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 6:
				if (KncENhGxPrvUjmrAxbVg(fieldInfo, null))
				{
					num2 = 3;
					continue;
				}
				return false;
			case 1:
				return true;
			case 3:
				HSXQYKGx1pNOCcCoIfm1(fieldInfo, null, value);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				propertyInfo = (PropertyInfo)VIvaQZGxkhAGq3MuieLU(m_type, binder.Name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				num2 = 4;
				continue;
			}
			w736qSGxOvuQOeMQdSW2(propertyInfo, null, value, null);
			num2 = 7;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
			{
				num2 = 1;
			}
		}
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		//Discarded unreachable code: IL_00a7, IL_00dd
		int num = 8;
		PropertyInfo propertyInfo = default(PropertyInfo);
		FieldInfo fieldInfo = default(FieldInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					propertyInfo = (PropertyInfo)VIvaQZGxkhAGq3MuieLU(m_type, WqBJy0GxNOxEGWSg5MrC(binder), BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					break;
				case 4:
					result = propertyInfo.GetValue(null, null);
					num2 = 5;
					continue;
				case 6:
					return false;
				case 7:
					if (!(propertyInfo != null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 3:
					return true;
				case 9:
					result = null;
					num2 = 6;
					continue;
				case 5:
					return true;
				default:
					fieldInfo = (FieldInfo)LdAUO7GxeIwRtoL1a0Ko(m_type, WqBJy0GxNOxEGWSg5MrC(binder), BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (!KncENhGxPrvUjmrAxbVg(fieldInfo, null))
					{
						num2 = 9;
						continue;
					}
					break;
				}
				break;
			}
			result = jubmUsGx3PbvbwvbM2af(fieldInfo, null);
			num = 3;
		}
	}

	public static dynamic From(Type type)
	{
		return new ExposedClass(type);
	}

	internal static void TkUZpWGxRyAVkIXBa09I()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool gnGsgpGxSKQ3ocprhJ69()
	{
		return mAyQjGGxVAxfmPReyC95 == null;
	}

	internal static ExposedClass BEa1fjGxiUMdx5GB9aLR()
	{
		return mAyQjGGxVAxfmPReyC95;
	}

	internal static object tnLY5KGxqiKGhB2OdItP(object P_0)
	{
		return ExposedObjectHelper.GetTypeArgs((InvokeMemberBinder)P_0);
	}

	internal static object XnHbLJGxKZdJ6cIbEtvR(object P_0)
	{
		return ((InvokeMemberBinder)P_0).Name;
	}

	internal static object HrcQm7GxX4AgrYhEbwx9(object P_0)
	{
		return ((MethodBase)P_0).GetGenericArguments();
	}

	internal static object PkuA8PGxT70LdN3vwF7j(object P_0, object P_1)
	{
		return ((MethodInfo)P_0).MakeGenericMethod((Type[])P_1);
	}

	internal static object VIvaQZGxkhAGq3MuieLU(Type type, object P_1, BindingFlags bindingAttr)
	{
		return type.GetReflectionProperty((string)P_1, bindingAttr);
	}

	internal static bool IjBDwHGxn2D1ucZ7Ri37(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static void w736qSGxOvuQOeMQdSW2(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object DprT56Gx2y2JMfGt2E1W(object P_0)
	{
		return ((SetMemberBinder)P_0).Name;
	}

	internal static object LdAUO7GxeIwRtoL1a0Ko(Type type, object P_1, BindingFlags bindingAttr)
	{
		return type.GetReflectionField((string)P_1, bindingAttr);
	}

	internal static bool KncENhGxPrvUjmrAxbVg(object P_0, object P_1)
	{
		return (FieldInfo)P_0 != (FieldInfo)P_1;
	}

	internal static void HSXQYKGx1pNOCcCoIfm1(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static object WqBJy0GxNOxEGWSg5MrC(object P_0)
	{
		return ((GetMemberBinder)P_0).Name;
	}

	internal static object jubmUsGx3PbvbwvbM2af(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}
}
