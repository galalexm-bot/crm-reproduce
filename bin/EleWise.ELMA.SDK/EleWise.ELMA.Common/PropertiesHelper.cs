using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common;

public class PropertiesHelper
{
	private Func<PropertyInfo, bool> condition;

	internal static PropertiesHelper BDkuDPfVEYDjJMeUetNn;

	public Type Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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

	public Dictionary<string, Func<object, object>> GetActions { get; private set; }

	public Dictionary<string, Action<object, object>> SetActions { get; private set; }

	public PropertyInfo[] PropertyInfos
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyInfos_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CPropertyInfos_003Ek__BackingField = value;
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

	public Func<PropertyInfo, bool> Condition
	{
		get
		{
			return condition;
		}
		private set
		{
			condition = value;
			foreach (PropertyInfo item in PropertyInfos.Where((PropertyInfo propertyInfo) => condition(propertyInfo)))
			{
				GetActions[item.Name] = GetValueGetter(item);
				SetActions[item.Name] = GetValueSetter(item);
			}
		}
	}

	public PropertiesHelper(Type type)
	{
		//Discarded unreachable code: IL_0057, IL_005c
		Hm3wnCfVCwKCxlPw8tOe();
		condition = (PropertyInfo a) => true;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				SetActions = new Dictionary<string, Action<object, object>>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num = 3;
				}
				break;
			case 1:
				Type = type;
				num = 2;
				break;
			case 4:
				return;
			case 2:
				GetActions = new Dictionary<string, Func<object, object>>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				PropertyInfos = (PropertyInfo[])PLETk9fVvI8e9USCHH5h(Type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
				num = 4;
				break;
			}
		}
	}

	public PropertiesHelper(Type type, Expression<Func<PropertyInfo, bool>> propertiesSelectCondition)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(type);
		Condition = ((propertiesSelectCondition != null) ? propertiesSelectCondition.Compile() : ((Func<PropertyInfo, bool>)((PropertyInfo a) => true)));
	}

	public void GetValues(PropertiesContainer properties, object obj)
	{
		//Discarded unreachable code: IL_002f, IL_00e9, IL_00f8, IL_0149, IL_015c, IL_016b
		int num = 2;
		int num2 = num;
		Dictionary<string, Func<object, object>>.Enumerator enumerator = default(Dictionary<string, Func<object, object>>.Enumerator);
		Func<object, object> value = default(Func<object, object>);
		KeyValuePair<string, Func<object, object>> current = default(KeyValuePair<string, Func<object, object>>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_0103:
						int num4;
						if (!enumerator.MoveNext())
						{
							int num3 = 3;
							num4 = num3;
							goto IL_003d;
						}
						goto IL_0063;
						IL_003d:
						while (true)
						{
							switch (num4)
							{
							case 3:
								return;
							case 5:
								break;
							case 1:
								if (value == null)
								{
									num4 = 6;
									continue;
								}
								goto default;
							default:
								properties[current.Key] = value(obj.CastAs(Type));
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num4 = 1;
								}
								continue;
							case 4:
								value = current.Value;
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num4 = 0;
								}
								continue;
							case 2:
							case 6:
								goto IL_0103;
							}
							break;
						}
						goto IL_0063;
						IL_0063:
						current = enumerator.Current;
						num4 = 4;
						goto IL_003d;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 2:
				enumerator = GetActions.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void SetValues(PropertiesContainer properties, object obj)
	{
		//Discarded unreachable code: IL_002e, IL_0038, IL_0079, IL_0088, IL_012f, IL_0167, IL_0176
		int num = 2;
		int num2 = num;
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current = default(string);
		Action<object, object> value = default(Action<object, object>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							goto IL_003c;
						}
						goto IL_00f6;
						IL_003c:
						while (true)
						{
							switch (num3)
							{
							case 5:
								if (!SetActions.TryGetValue(current, out value))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 3;
							case 3:
								value(bsvjAMfV8UpZoYKiXZyo(obj, Type), H5TG8QfVZqp7IbCPTVVf(properties, current));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								goto IL_00f6;
							case 4:
								return;
							}
							break;
						}
						continue;
						IL_00f6:
						current = enumerator.Current;
						num3 = 5;
						goto IL_003c;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								enumerator.Dispose();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 2:
				enumerator = properties.GetProperties().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual Func<object, object> GetValueGetter(PropertyInfo propertyInfo)
	{
		if (!propertyInfo.CanRead)
		{
			return null;
		}
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137977225));
		return Expression.Lambda<Func<object, object>>(Expression.Convert(Expression.Call(Expression.Convert(parameterExpression, Type), propertyInfo.GetGetMethod()), typeof(object)), new ParameterExpression[1] { parameterExpression }).Compile();
	}

	protected virtual Action<object, object> GetValueSetter(PropertyInfo propertyInfo)
	{
		if (!propertyInfo.CanWrite)
		{
			return null;
		}
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951473554));
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECC4BE8));
		return Expression.Lambda<Action<object, object>>(Expression.Call(Expression.Convert(parameterExpression, Type), propertyInfo.GetSetMethod(), Expression.Convert(parameterExpression2, propertyInfo.PropertyType)), new ParameterExpression[2] { parameterExpression, parameterExpression2 }).Compile();
	}

	internal static bool HqJAU2fVfNCsA2QGIJsC()
	{
		return BDkuDPfVEYDjJMeUetNn == null;
	}

	internal static PropertiesHelper ESf4ctfVQUwLWmIeytDp()
	{
		return BDkuDPfVEYDjJMeUetNn;
	}

	internal static void Hm3wnCfVCwKCxlPw8tOe()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object PLETk9fVvI8e9USCHH5h(Type type, BindingFlags bindingAttr)
	{
		return type.GetReflectionProperties(bindingAttr);
	}

	internal static object bsvjAMfV8UpZoYKiXZyo(object P_0, Type neededType)
	{
		return P_0.CastAs(neededType);
	}

	internal static object H5TG8QfVZqp7IbCPTVVf(object P_0, object P_1)
	{
		return ((PropertiesContainer)P_0)[(string)P_1];
	}
}
