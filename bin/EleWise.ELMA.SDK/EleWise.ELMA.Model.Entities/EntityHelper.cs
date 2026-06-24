using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

public static class EntityHelper
{
	private static EntityHelper Cuc4LhhZ9JGW8YqS4uPy;

	public static bool Equals<T>(T obj1, T obj2) where T : IIdentified
	{
		if (object.Equals(obj1, obj2))
		{
			return true;
		}
		if (obj1 == null)
		{
			return false;
		}
		if (obj2 == null)
		{
			return false;
		}
		return object.Equals(obj1.GetId(), obj2.GetId());
	}

	public static Type GetType(object target)
	{
		//Discarded unreachable code: IL_0076, IL_0085
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		Type result = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ntax5thZr3BCIrIfmg28(target))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				result = qtb9K9hZ5HituavwvYmc(nRqfeOhZgKFEDGSN46CF((object)(INHibernateProxy)target));
				num2 = 4;
				continue;
			case 3:
			case 4:
				return result;
			case 2:
				break;
			}
			result = target.GetType();
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
			{
				num2 = 3;
			}
		}
	}

	public static T Cast<T, S>(this S source) where S : IEntity
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (NHibernateProxyHelper.IsProxy((object)source))
		{
			return (T)((INHibernateProxy)(object)source).get_HibernateLazyInitializer().GetImplementation();
		}
		return (T)(object)source;
	}

	public static IEntityManager GetEntityManager(Type entityType)
	{
		//Discarded unreachable code: IL_0050, IL_005f
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)uR3QWBhZYWuq1oo4OOB7(0x1C9495B4 ^ 0x1C944620));
			case 1:
				return ModelHelper.GetEntityManager(entityType);
			case 2:
				if (!Tv0i8HhZj91qevs5WPQC(entityType, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static bool HasCustomFormViews(IEntity entity, ViewType viewType, bool? inTab = null)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.viewType = viewType;
		CS_0024_003C_003E8__locals0.inTab = inTab;
		EntityMetadata entityMetadata = ((entity != null) ? Metadata<EntityMetadata>(entity) : null);
		if (entityMetadata != null && entityMetadata.FormViews != null)
		{
			return entityMetadata.FormViews.Any(delegate(FormView v)
			{
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (!CS_0024_003C_003E8__locals0.inTab.Value)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto IL_0087;
					case 2:
						if (CS_0024_003C_003E8__locals0.inTab.HasValue)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0087;
					case 1:
						return _003C_003Ec__DisplayClass4_0.wx48ZACzbapZdTdVRaY6(v);
					case 3:
						{
							if (_003C_003Ec__DisplayClass4_0.LLwr2nCzoW7X3wiZ5eFh(v) != CS_0024_003C_003E8__locals0.viewType)
							{
								return false;
							}
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num2 = 2;
							}
							break;
						}
						IL_0087:
						return v.ViewInTab;
					}
				}
			});
		}
		return false;
	}

	public static FormView GetCustomFormView(IEntity entity, ViewType viewType, bool? inTab = null)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.viewType = viewType;
		CS_0024_003C_003E8__locals0.inTab = inTab;
		if (HasCustomFormViews(entity, CS_0024_003C_003E8__locals0.viewType, CS_0024_003C_003E8__locals0.inTab))
		{
			return Metadata<EntityMetadata>(entity).FormViews.First(delegate(FormView v)
			{
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (_003C_003Ec__DisplayClass5_0.FYE3o3CzQg8a18mqkgqq(v) != CS_0024_003C_003E8__locals0.viewType)
						{
							return false;
						}
						num2 = 2;
						break;
					default:
						if (!CS_0024_003C_003E8__locals0.inTab.Value)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0078;
					case 1:
						return _003C_003Ec__DisplayClass5_0.PAyWrLCzCWFGyM0puQf1(v);
					case 2:
						{
							if (CS_0024_003C_003E8__locals0.inTab.HasValue)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num2 = 0;
								}
								break;
							}
							goto IL_0078;
						}
						IL_0078:
						return _003C_003Ec__DisplayClass5_0.jgCDpRCzvrXf9rg5ha8Q(v);
					}
				}
			});
		}
		return null;
	}

	public static T Metadata<T>(IEntity entity) where T : class, IMetadata
	{
		return MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()) as T;
	}

	public static PropertyInfo GetProperty<T>(string path)
	{
		try
		{
			if (string.IsNullOrEmpty(path))
			{
				return null;
			}
			string[] array = path.Split(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A5399A) }, StringSplitOptions.None);
			Type typeFromHandle = typeof(T);
			PropertyInfo reflectionProperty = typeFromHandle.GetReflectionProperty(array[0]);
			typeFromHandle = reflectionProperty.PropertyType;
			for (int i = 1; i < array.Length; i++)
			{
				reflectionProperty = typeFromHandle.GetReflectionProperty(array[i]);
				typeFromHandle = reflectionProperty.PropertyType;
			}
			return reflectionProperty;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
			return null;
		}
	}

	public static string GetTitleOrDefault<TSource>(this TSource source, Func<TSource, string> defaultValue = null) where TSource : IEntity
	{
		_003C_003Ec__DisplayClass8_0<TSource> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0<TSource>();
		CS_0024_003C_003E8__locals0.source = source;
		IEntityTitle entityTitle = ComponentManager.Current.GetExtensionPoints<IEntityTitle>().FirstOrDefault((IEntityTitle p) => p.CheckType(CS_0024_003C_003E8__locals0.source));
		if (entityTitle != null)
		{
			return entityTitle.Title(CS_0024_003C_003E8__locals0.source);
		}
		string text = CS_0024_003C_003E8__locals0.source.ToString();
		if (!text.IsNullOrEmpty())
		{
			return text;
		}
		if (defaultValue == null)
		{
			return SR.Untitled;
		}
		return defaultValue(CS_0024_003C_003E8__locals0.source);
	}

	internal static bool ntax5thZr3BCIrIfmg28(object P_0)
	{
		return NHibernateProxyHelper.IsProxy(P_0);
	}

	internal static object nRqfeOhZgKFEDGSN46CF(object P_0)
	{
		return ((INHibernateProxy)P_0).get_HibernateLazyInitializer();
	}

	internal static Type qtb9K9hZ5HituavwvYmc(object P_0)
	{
		return ((ILazyInitializer)P_0).get_PersistentClass();
	}

	internal static bool SbCXvGhZd5ppu6Ya8vmi()
	{
		return Cuc4LhhZ9JGW8YqS4uPy == null;
	}

	internal static EntityHelper I0PFMthZloYVKbBgrFtX()
	{
		return Cuc4LhhZ9JGW8YqS4uPy;
	}

	internal static bool Tv0i8HhZj91qevs5WPQC(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object uR3QWBhZYWuq1oo4OOB7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
