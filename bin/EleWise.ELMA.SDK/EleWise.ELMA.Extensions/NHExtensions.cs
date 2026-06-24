using System;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Model.Entities;
using Iesi.Collections;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Persister.Entity;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class NHExtensions
{
	private static NHExtensions qD8wFpG4OWmFcVB7ti09;

	public static IEntityPersister GetEntityPersister(this ISession session, object entity)
	{
		//Discarded unreachable code: IL_0080, IL_00b2, IL_00f9, IL_0108
		int num = 6;
		int num2 = num;
		string text = default(string);
		ISessionImplementor sessionImplementation = default(ISessionImplementor);
		Type type = default(Type);
		IEntityPersister result = default(IEntityPersister);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				text = (string)r2kfgVG43K4tWHkGq4Ct(kID9bJG4NFwugK8CmH7D(sessionImplementation), type);
				num2 = 2;
				continue;
			case 1:
				return result;
			case 2:
				try
				{
					result = (IEntityPersister)Dg8c1fG4phtyKbnHIZj7(sessionImplementation.get_Factory(), text);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num3 = 0;
					}
					return (IEntityPersister)(num3 switch
					{
						0 => result, 
						_ => result, 
					});
				}
				catch (MappingException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new InvalidOperationException(SR.T((string)Mfd2bgG4aZOXIjAtk3Dm(0x53CB464B ^ 0x53C8B9CF), entity.GetType().AssemblyQualifiedName));
					}
				}
			case 6:
				sessionImplementation = session.GetSessionImplementation();
				num2 = 5;
				continue;
			case 5:
			{
				IEntityImplementorProvider obj2 = entity as IEntityImplementorProvider;
				if (obj2 == null)
				{
					num2 = 3;
					continue;
				}
				obj = oSvWdaG4PJGIXIXVQxy9(obj2);
				goto IL_014c;
			}
			case 3:
				obj = null;
				goto IL_014c;
			case 4:
				{
					obj = aBxlk4G41O7MGEUe7yBc(entity);
					break;
				}
				IL_014c:
				if (obj == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			type = (Type)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
			{
				num2 = 0;
			}
		}
	}

	public static bool IsInitialized<T>(this ISet<T> collection)
	{
		return IsCollectionInitialized(collection);
	}

	public static bool IsInitialized(this ISet collection)
	{
		return UGoGtEG4D9T88nvPX2gN(collection);
	}

	private static bool IsCollectionInitialized(object collection)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0069
		int num = 2;
		int num2 = num;
		IInheritedSet inheritedSet = default(IInheritedSet);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (inheritedSet == null)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 3:
				return true;
			case 1:
				inheritedSet = collection as IInheritedSet;
				num2 = 5;
				break;
			case 2:
				if (collection != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				return gDJhvgG4teL3l1SUcD16(inheritedSet);
			case 4:
				return Mmv8VOG4wRh2IRxBnJBh(collection);
			}
		}
	}

	internal static Type oSvWdaG4PJGIXIXVQxy9(object P_0)
	{
		return ((IEntityImplementorProvider)P_0).EntityImplementorType;
	}

	internal static Type aBxlk4G41O7MGEUe7yBc(object P_0)
	{
		return NHibernateProxyHelper.GuessClass(P_0);
	}

	internal static object kID9bJG4NFwugK8CmH7D(object P_0)
	{
		return ((ISessionImplementor)P_0).get_Factory();
	}

	internal static object r2kfgVG43K4tWHkGq4Ct(object P_0, Type P_1)
	{
		return ((ISessionFactoryImplementor)P_0).TryGetGuessEntityName(P_1);
	}

	internal static object Dg8c1fG4phtyKbnHIZj7(object P_0, object P_1)
	{
		return ((ISessionFactoryImplementor)P_0).GetEntityPersister((string)P_1);
	}

	internal static object Mfd2bgG4aZOXIjAtk3Dm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool DFRsUPG42ODEbjURJBVO()
	{
		return qD8wFpG4OWmFcVB7ti09 == null;
	}

	internal static NHExtensions j71EnDG4exVO9XpFgn0f()
	{
		return qD8wFpG4OWmFcVB7ti09;
	}

	internal static bool UGoGtEG4D9T88nvPX2gN(object P_0)
	{
		return IsCollectionInitialized(P_0);
	}

	internal static bool gDJhvgG4teL3l1SUcD16(object P_0)
	{
		return ((IInheritedSet)P_0).WasInitialized;
	}

	internal static bool Mmv8VOG4wRh2IRxBnJBh(object P_0)
	{
		return NHibernateUtil.IsInitialized(P_0);
	}
}
