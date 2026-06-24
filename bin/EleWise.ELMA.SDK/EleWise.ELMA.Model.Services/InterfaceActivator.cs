using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Services;

public static class InterfaceActivator
{
	private static Func<Type, string, bool, PropertyMetadata> getPropertyMetadata;

	private static InterfaceActivator udc9eIbZukjAvyD6p9mE;

	[NotNull]
	public static T Create<T>()
	{
		return (T)Create(typeof(T));
	}

	[NotNull]
	public static object Create(Type t)
	{
		//Discarded unreachable code: IL_0106, IL_0133, IL_0142, IL_0155, IL_0164, IL_01b7, IL_01ea, IL_026a
		int num = 8;
		IEntityManager entityManager = default(IEntityManager);
		object obj = default(object);
		string text = default(string);
		object result = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					return cHgc3tbZSIsWTD5SNNb2(t);
				case 1:
				case 2:
					if (!t.IsInheritOrSame<IEntity>())
					{
						num2 = 13;
						continue;
					}
					goto case 4;
				case 12:
					if (entityManager != null)
					{
						num2 = 6;
						continue;
					}
					break;
				case 4:
					entityManager = (IEntityManager)XR6TbgbZiMjBYw8GBceL(t);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 12;
					}
					continue;
				case 10:
					return obj;
				case 14:
					num2 = 3;
					continue;
				case 5:
					if (obj == null)
					{
						num2 = 14;
						continue;
					}
					goto case 10;
				case 7:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710501336));
				case 6:
					return W41RmvbZRqZpwawMEma1(entityManager);
				case 13:
					break;
				default:
					if (t.IsInheritOrSame<IEntity>())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 9;
				case 3:
					try
					{
						result = cHgc3tbZSIsWTD5SNNb2(t);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								hVKH3MbZXkLMyqkl4pyR(Logger.Log, text, ex);
								num4 = 2;
								continue;
							case 2:
								throw new Exception(text, ex);
							}
							text = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EEA3B9), P4KBdxbZKhdEBZrKpEUZ(t), t);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num4 = 0;
							}
						}
					}
				case 11:
					return result;
				case 8:
					if (!(t == null))
					{
						if (!t.IsClass)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto default;
					}
					num2 = 7;
					continue;
				}
				break;
			}
			obj = QNJtysbZqB8BJcacKZPO(t);
			num = 5;
		}
	}

	public static Type TypeOf(Type t)
	{
		//Discarded unreachable code: IL_0035
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Type type;
				switch (num2)
				{
				case 2:
					if (tDR0OZbZTOtRY3TGK42s(t, null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					if (t.IsInterface)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 1:
					throw new ArgumentNullException((string)h8gEYbbZk2mkV9vJETuE(0x637E299B ^ 0x637F4B79));
				case 3:
					return t;
				case 4:
					type = ((ComponentManager)L8jRQabZnAXUsSJ0g7mY()).GetExtensionPointTypes(t).FirstOrDefault();
					if ((object)type != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					type = t;
					break;
				}
				return type;
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public static Type TypeOf<T>()
	{
		return TypeOf(System.Reflection.TypeOf<T>.Raw);
	}

	public static IMetadata LoadMetadata(Type t, bool inherit = true, bool loadImplementation = true)
	{
		//Discarded unreachable code: IL_0072, IL_0081
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!tDR0OZbZTOtRY3TGK42s(t, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				throw new ArgumentNullException((string)h8gEYbbZk2mkV9vJETuE(0x57A5235E ^ 0x57A441BC));
			case 1:
				return MetadataLoader.LoadMetadata(t, inherit, loadImplementation);
			}
		}
	}

	public static IMetadata LoadMetadata<T>(bool inherit = true, bool loadImplementation = true)
	{
		return MetadataLoader.LoadMetadata(typeof(T), inherit, loadImplementation);
	}

	public static Guid UID(Type t, bool loadImplementation = true)
	{
		return aTIMMQbZOLAt3n6V42OU(MetadataLoader.LoadMetadata(t, inherit: false, loadImplementation));
	}

	public static Guid UID<T>(bool loadImplementation = true)
	{
		return MetadataLoader.LoadMetadata(typeof(T), inherit: false, loadImplementation).Uid;
	}

	public static Guid PropertyUid<T>(Expression<Func<T, object>> expr)
	{
		return PropertyUid(expr, inherit: false);
	}

	public static Guid PropertyUid<T>(Expression<Func<T, object>> expr, bool inherit)
	{
		return LoadPropertyMetadata(expr, inherit)?.Uid ?? Guid.Empty;
	}

	[Obsolete("Метод устарел. Используйте LinqUtils.NameOf<>", false)]
	public static string PropertyName<T>(Expression<Func<T, object>> expr)
	{
		return PropertyName(expr, inherit: false);
	}

	[Obsolete("Метод устарел. Используйте LinqUtils.NameOf<>", false)]
	public static string PropertyName<T>(Expression<Func<T, object>> expr, bool inherit)
	{
		PropertyMetadata propertyMetadata = LoadPropertyMetadata(expr, inherit);
		if (propertyMetadata == null)
		{
			return "";
		}
		return propertyMetadata.Name;
	}

	public static PropertyMetadata LoadPropertyMetadata<T>(Expression<Func<T, object>> expr)
	{
		return LoadPropertyMetadata(expr, inherit: false);
	}

	public static PropertyMetadata LoadPropertyMetadata<T>(Expression<Func<T, object>> expr, bool inherit)
	{
		return LoadPropertyMetadata(typeof(T), LinqUtils.NameOf(expr), inherit);
	}

	public static PropertyMetadata LoadPropertyMetadata<T>(string propName, bool inherit)
	{
		return LoadPropertyMetadata(typeof(T), propName, inherit);
	}

	public static PropertyMetadata LoadPropertyMetadata(Type type, string propName, bool inherit)
	{
		return getPropertyMetadata(type, propName, inherit);
	}

	private static PropertyMetadata GetPropertyMetadata(Type type, object propName, bool inherit)
	{
		//Discarded unreachable code: IL_0089
		int num = 1;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				case 1:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass16_.propName = (string)propName;
					num2 = 5;
					continue;
				case 4:
					if (classMetadata != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				case 3:
					return null;
				case 2:
					return classMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass16_._003CGetPropertyMetadata_003Eb__0);
				}
				break;
			}
			classMetadata = MetadataLoader.LoadMetadata(type, inherit) as ClassMetadata;
			num = 4;
		}
	}

	static InterfaceActivator()
	{
		int num = 5;
		int num2 = num;
		ParameterExpression parameterExpression3 = default(ParameterExpression);
		ParameterExpression parameterExpression2 = default(ParameterExpression);
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 1:
				parameterExpression3 = (ParameterExpression)VHoX3YbZeP9thEeWqPNa(typeof(bool), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3298914));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				parameterExpression2 = (ParameterExpression)VHoX3YbZeP9thEeWqPNa(tFkWtcbZ2xyC4xOVdlQV(typeof(Type).TypeHandle), h8gEYbbZk2mkV9vJETuE(0xE1229CF ^ 0xE1225ED));
				num2 = 3;
				continue;
			case 2:
				return;
			case 3:
				parameterExpression = (ParameterExpression)VHoX3YbZeP9thEeWqPNa(tFkWtcbZ2xyC4xOVdlQV(typeof(string).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107981816));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				SingletonReader.JJCZtPuTvSt();
				num2 = 4;
				continue;
			}
			getPropertyMetadata = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Type, string, bool, PropertyMetadata>>((Expression)TDvwQwbZ1XklBPtofDyP(null, (MethodInfo)iFYI1xbZPdjCNnGcaZby((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[3] { parameterExpression2, parameterExpression, parameterExpression3 }), new ParameterExpression[3] { parameterExpression2, parameterExpression, parameterExpression3 }));
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static object cHgc3tbZSIsWTD5SNNb2(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object XR6TbgbZiMjBYw8GBceL(Type entityType)
	{
		return ModelHelper.GetEntityManagerOrNull(entityType);
	}

	internal static object W41RmvbZRqZpwawMEma1(object P_0)
	{
		return ((IEntityManager)P_0).Create();
	}

	internal static object QNJtysbZqB8BJcacKZPO(Type type)
	{
		return Locator.GetService(type);
	}

	internal static object P4KBdxbZKhdEBZrKpEUZ(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static void hVKH3MbZXkLMyqkl4pyR(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool YYgZ1ZbZIfB430cGZALa()
	{
		return udc9eIbZukjAvyD6p9mE == null;
	}

	internal static InterfaceActivator QStiEabZVEiLCPl4u367()
	{
		return udc9eIbZukjAvyD6p9mE;
	}

	internal static bool tDR0OZbZTOtRY3TGK42s(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object h8gEYbbZk2mkV9vJETuE(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object L8jRQabZnAXUsSJ0g7mY()
	{
		return ComponentManager.Current;
	}

	internal static Guid aTIMMQbZOLAt3n6V42OU(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static Type tFkWtcbZ2xyC4xOVdlQV(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object VHoX3YbZeP9thEeWqPNa(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object iFYI1xbZPdjCNnGcaZby(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object TDvwQwbZ1XklBPtofDyP(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}
}
