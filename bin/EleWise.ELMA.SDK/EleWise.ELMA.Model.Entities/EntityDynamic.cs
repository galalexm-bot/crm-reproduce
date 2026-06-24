using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Accessors;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Proxy;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Properties;
using NHibernate.Proxy;

namespace EleWise.ELMA.Model.Entities;

[Serializable]
[DebuggerTypeProxy(typeof(DynamicDebugView))]
[DefaultManager(typeof(EntityManagerMaker))]
[DataContract]
[Component(InjectProerties = false)]
public abstract class EntityDynamic<IdT> : Entity<IdT>, IValueContainerObjectInternal, IDynamicMetaObjectProvider, IEntityProxy, INHibernateProxy, IEntityDynamic
{
	private ILazyInitializer lazyInitializer;

	private static IDictionary<Guid, IGetter> titlePropertyGetters;

	internal static object g5bMWUh8x1AYkcmpahTm;

	ILazyInitializer HibernateLazyInitializer => lazyInitializer;

	Guid IEntityDynamic.TypeUid => TypeUid_034F;

	protected internal abstract Guid TypeUid_034F { get; }

	protected internal static ICreator<T, TData> ResolveCreator<T, TData, TClassData>(Func<T, TData> creator) where TData : class where TClassData : TData
	{
		return Creator<T>.ResolveCreator<TData, TClassData>(creator);
	}

	DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
	{
		return new MetaDynamic(parameter, this, (string name) => GetType().GetAccessor(name, declaredOnly: false));
	}

	IEnumerable<object> IValueContainerObjectInternal.GetData()
	{
		return GetData_034F();
	}

	protected internal virtual IEnumerable<object> GetData_034F()
	{
		return Enumerable.Empty<object>();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEnumerable<object> GetAccessors_034F()
	{
		return Enumerable.Empty<object>();
	}

	INHibernateProxy IEntityProxy.InitLazyInitializer(ILazyInitializer lazyInitializer)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Id = (IdT)lazyInitializer.get_Identifier();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				this.lazyInitializer = lazyInitializer;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return (INHibernateProxy)(object)this;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected internal static Guid GetTypeUid(EntityDynamic<IdT> entity, Guid uid)
	{
		ILazyInitializer obj = entity.lazyInitializer;
		return (((obj != null) ? obj.GetImplementation() : null) as IInheritable)?.TypeUid ?? uid;
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		IGetter orAdd = default(IGetter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return base.ToString();
			default:
				return (string)orAdd.Get((object)this);
			case 2:
				if (orAdd != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				orAdd = titlePropertyGetters.GetOrAdd(TypeUid_034F, (Func<Guid, IGetter>)delegate(Guid metadataUid)
				{
					//Discarded unreachable code: IL_008a, IL_0099
					int num3 = 3;
					PropertyMetadata titleProperty = default(PropertyMetadata);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return GetType().GetGetter(titleProperty.Name, declaredOnly: false);
							case 1:
								return null;
							case 3:
								break;
							case 2:
								if (titleProperty == null)
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
									{
										num4 = 1;
									}
									continue;
								}
								goto default;
							}
							break;
						}
						titleProperty = ((ClassMetadata)MetadataLoader.LoadMetadata(metadataUid)).GetTitleProperty();
						num3 = 2;
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool TypeAssignable([NotNull] object obj)
	{
		//Discarded unreachable code: IL_0039
		int num = 3;
		int num2 = num;
		Type type2 = default(Type);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				type2 = obj.GetType();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (type == type2)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 5:
				if (!type2.IsAssignableFrom(type))
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 4:
				return type.IsAssignableFrom(type2);
			case 1:
				return true;
			case 3:
				type = GetType();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected EntityDynamic()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityDynamic()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				continue;
			}
			titlePropertyGetters = PublishCacheContext.CreateCache(delegate(IDictionary<Guid, IGetter> c, Type t, Guid u)
			{
				c.Clear();
			});
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static bool In1cK1h80B180GwyTMIt()
	{
		return g5bMWUh8x1AYkcmpahTm == null;
	}

	internal static object wp8Iufh8mX7tjsUhXNDr()
	{
		return g5bMWUh8x1AYkcmpahTm;
	}
}
