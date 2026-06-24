using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.Dynamic;

public class ExposedObject : DynamicObject
{
	/// <summary>
	/// The <see langword="object"/> that is being exposed.
	/// <see langword="null"/> if static members of a <see cref="Type"/> are being exposed.
	/// </summary>	
	private object m_object;

	private Type m_type;

	private Dictionary<string, Dictionary<int, List<MethodInfo>>> m_instanceMethods;

	private Dictionary<string, Dictionary<int, List<MethodInfo>>> m_genInstanceMethods;

	public object Object => m_object;

	private ExposedObject(object obj)
	{
		m_object = obj;
		m_type = obj.GetType();
		
		m_instanceMethods = (from m in m_type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
			where !<>c.kAmPVb8QJCsQGyyNobTM(m)
			group m by m.Name).ToDictionary((IGrouping<string, MethodInfo> p) => p.Key, (IGrouping<string, MethodInfo> p) => (from r in p
			group r by ((Array)_003C_003Ec.CT9cT88Q9ZK6KBVu8j03(r)).Length).ToDictionary((IGrouping<int, MethodInfo> r) => r.Key, (IGrouping<int, MethodInfo> r) => r.ToList()));
		
		m_genInstanceMethods = (from m in m_type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
			where m.IsGenericMethod
			group m by m.Name).ToDictionary((IGrouping<string, MethodInfo> p) => p.Key, (IGrouping<string, MethodInfo> p) => (from r in p
			group r by ((Array)_003C_003Ec.CT9cT88Q9ZK6KBVu8j03(r)).Length).ToDictionary((IGrouping<int, MethodInfo> r) => r.Key, (IGrouping<int, MethodInfo> r) => r.ToList()));
	}

	public static dynamic New<T>()
	{
		return New(typeof(T));
	}

	public static dynamic New(Type type)
	{
		return new ExposedObject(Activator.CreateInstance(type));
	}

	public static dynamic From(object obj)
	{
		return new ExposedObject(obj);
	}

	public static T Cast<T>(ExposedObject t)
	{
		return (T)t.m_object;
	}

	public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		//Discarded unreachable code: IL_00ed, IL_01f3, IL_0202, IL_020d, IL_02da, IL_02ed, IL_02fc, IL_030c, IL_031b, IL_032b, IL_033a, IL_03c2, IL_03d1, IL_0413, IL_0422
		int num = 7;
		int num2 = num;
		Type[] array = default(Type[]);
		List<MethodInfo> list = default(List<MethodInfo>);
		List<MethodInfo>.Enumerator enumerator = default(List<MethodInfo>.Enumerator);
		MethodInfo current = default(MethodInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (array.Length == 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			case 10:
				list = new List<MethodInfo>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 11;
				}
				break;
			case 20:
				if (ExposedObjectHelper.InvokeBestMethod(args, m_object, m_instanceMethods[(string)jZpDA4Gx6uQ35ZNi3VUe(binder)][args.Length], out result))
				{
					num2 = 9;
					break;
				}
				goto case 15;
			case 13:
				if (!m_instanceMethods.ContainsKey(binder.Name))
				{
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 10;
					}
					break;
				}
				goto default;
			case 8:
				if (!ExposedObjectHelper.InvokeBestMethod(args, m_object, list, out result))
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 11:
				enumerator = m_genInstanceMethods[(string)jZpDA4Gx6uQ35ZNi3VUe(binder)][args.Length].GetEnumerator();
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 16;
				}
				break;
			case 14:
				if (m_instanceMethods[binder.Name].ContainsKey(args.Length))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 4;
			case 9:
				return true;
			case 15:
			case 17:
				if (!m_instanceMethods.ContainsKey((string)jZpDA4Gx6uQ35ZNi3VUe(binder)))
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 14;
			case 16:
				try
				{
					while (true)
					{
						IL_0288:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num3 = 0;
							}
							goto IL_0211;
						}
						goto IL_0275;
						IL_0275:
						current = enumerator.Current;
						num3 = 4;
						goto IL_0211;
						IL_0211:
						while (true)
						{
							switch (num3)
							{
							case 1:
								list.Add((MethodInfo)SOpO7bGxATxgLMt3ogvX(current, array));
								num3 = 2;
								continue;
							case 4:
								if (((Array)mVMjXhGxHQeGcFnffHKy(current)).Length == array.Length)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto IL_0288;
							case 3:
								goto IL_0275;
							case 2:
								goto IL_0288;
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
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 8;
			case 3:
				array = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			case 19:
				return false;
			case 7:
				array = (Type[])xducfiGx4gSffTQQEwJf(binder);
				num2 = 6;
				break;
			default:
				if (!m_instanceMethods[(string)jZpDA4Gx6uQ35ZNi3VUe(binder)].ContainsKey(args.Length))
				{
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 15;
					}
					break;
				}
				goto case 20;
			case 5:
				return true;
			case 4:
			case 12:
				result = null;
				num2 = 19;
				break;
			case 1:
			case 18:
				if (array == null)
				{
					num2 = 13;
					break;
				}
				goto case 15;
			case 6:
				if (array == null)
				{
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 18;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override bool TrySetMember(SetMemberBinder binder, object value)
	{
		var property = this.type.GetProperty(binder.Name, Flags);

		if (property != null)
		{
			property.SetValue(this.instance, value);

			return true;
		}

		var field = this.type.GetField(binder.Name, Flags);

		if (field != null)
		{
			field.SetValue(this.instance, value);

			return true;
		}

		return base.TrySetMember(binder, value);
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		//Discarded unreachable code: IL_0101
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
				case 2:
					return true;
				case 6:
					result = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return true;
				case 1:
					result = B3ZSNIGxJuYtNtK2j1pb(propertyInfo, m_object, null);
					num2 = 4;
					break;
				default:
					return false;
				case 5:
					result = W1hUQDGx9YbEajYWmQ0M(fieldInfo, m_object);
					num2 = 2;
					break;
				case 7:
					if (!BhuNW1GxxrlNka24Dyo5(propertyInfo, null))
					{
						goto end_IL_0012;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					if (!(fieldInfo != null))
					{
						num2 = 6;
						break;
					}
					goto case 5;
				case 8:
					propertyInfo = (PropertyInfo)uT0siLGx7VgcZFItKWQK(m_object.GetType(), ndliLfGxMMDUUEUmd3xb(binder), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 7;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			fieldInfo = (FieldInfo)G94HZ3GxmNTQH6LnJt2v(m_object.GetType(), ndliLfGxMMDUUEUmd3xb(binder), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			num = 3;
		}
	}

	public override bool TryConvert(ConvertBinder binder, out object result)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				result = m_object;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return true;
			}
		}
	}

	internal static void lbuoVPGxttqNRoPFjuqF()
	{
		SingletonReader.JJCZtPuTvSt();
	}
	
	internal static object xducfiGx4gSffTQQEwJf(object P_0)
	{
		return ExposedObjectHelper.GetTypeArgs((InvokeMemberBinder)P_0);
	}

	internal static object jZpDA4Gx6uQ35ZNi3VUe(object P_0)
	{
		return ((InvokeMemberBinder)P_0).Name;
	}

	internal static object mVMjXhGxHQeGcFnffHKy(object P_0)
	{
		return ((MethodBase)P_0).GetGenericArguments();
	}

	internal static object SOpO7bGxATxgLMt3ogvX(object P_0, object P_1)
	{
		return ((MethodInfo)P_0).MakeGenericMethod((Type[])P_1);
	}

	internal static object uT0siLGx7VgcZFItKWQK(Type type, object P_1, BindingFlags bindingAttr)
	{
		return type.GetReflectionProperty((string)P_1, bindingAttr);
	}

	internal static bool BhuNW1GxxrlNka24Dyo5(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static void iCb7wVGx011Lb6pDdTt4(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object G94HZ3GxmNTQH6LnJt2v(Type type, object P_1, BindingFlags bindingAttr)
	{
		return type.GetReflectionField((string)P_1, bindingAttr);
	}

	internal static bool jqBDKeGxyMkg3IDcs9eb(object P_0, object P_1)
	{
		return (FieldInfo)P_0 != (FieldInfo)P_1;
	}

	internal static object ndliLfGxMMDUUEUmd3xb(object P_0)
	{
		return ((GetMemberBinder)P_0).Name;
	}

	internal static object B3ZSNIGxJuYtNtK2j1pb(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object W1hUQDGx9YbEajYWmQ0M(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}
}
