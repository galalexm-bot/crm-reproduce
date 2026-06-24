using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Serialization;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Extensions.Dynamic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Settings.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

[Serializable]
[Component(InjectProerties = false)]
[DefaultManager(typeof(EntityManagerMaker))]
[DataContract]
public abstract class Entity<IdT> : IEntity<IdT>, IEntity, IIdentified, IDynamicMetaObjectProvider, IEntityImplementorProvider
{
	internal class ReflectionDynamicMetaObject : DynamicMetaObject
	{
		private static object ONG1iHCzxiSDcVrQljl2;

		public ReflectionDynamicMetaObject(Expression parameter, object value) : base(parameter, BindingRestrictions.GetTypeRestriction(parameter, value.GetType()), value)
		{
		}

		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			int num = 1;
			int num2 = num;
			PropertyInfo property = default(PropertyInfo);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return base.BindGetMember(binder);
				case 1:
					property = base.LimitType.GetProperty(binder.Name);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (property == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return new DynamicMetaObject(Expression.Convert(Expression.Property(Expression.Convert(base.Expression, base.LimitType), property), binder.ReturnType), BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType));
			}
		}

		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			var self = Expression;

			var memberExpression = GetMemberExpression(self, binder.Name);

			var target =
				Expression.Convert(
					Expression.Assign(memberExpression, Expression.Convert(value.Expression, memberExpression.Type)),
					binder.ReturnType);
			var restrictions = BindingRestrictions.GetTypeRestriction(self, typeof(ExposedObject));

			return new DynamicMetaObject(target, restrictions);
		}

		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			//Discarded unreachable code: IL_0045, IL_0054
			int num = 8;
			int num2 = num;
			Expression[] array = default(Expression[]);
			Expression expression = default(Expression);
			MethodInfo method = default(MethodInfo);
			Expression[] arguments = default(Expression[]);
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (array.Length != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				default:
					expression = Expression.NewArrayInit(typeof(object), array);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 2;
					}
					break;
				case 8:
					method = typeof(ObjectExtensions).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309396558), BindingFlags.Static | BindingFlags.Public);
					num2 = 7;
					break;
				case 1:
					return new DynamicMetaObject(Expression.Call(method, arguments), BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType));
				case 3:
				case 5:
					arguments = new Expression[3]
					{
						Expression.Convert(base.Expression, base.LimitType),
						Expression.Constant(binder.Name),
						expression
					};
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					expression = Expression.Convert(Expression.Constant(null), typeof(object[]));
					num2 = 5;
					break;
				case 7:
					array = args.Select((DynamicMetaObject a) => a.Expression).ToArray();
					num2 = 4;
					break;
				}
			}
		}
		
		/// <summary>
		/// Generates the <see cref="Expression"/> for accessing a member by name.
		/// </summary>
		/// <param name="self">
		/// The <see cref="Expression"/> for accessing the <see cref="Exposed"/> instance.
		/// </param>
		/// <param name="memberName">
		/// The member name.
		/// </param>
		/// <returns>
		/// <see cref="MemberExpression"/> for accessing a member by name.
		/// </returns>
		/// <exception cref="MissingMemberException">
		/// </exception>
		private MemberExpression GetMemberExpression(Expression self, string memberName)
		{
			MemberExpression memberExpression = null;
			var type = ((ExposedObject)Value).SubjectType;
			var @this = isStatic
				? null
				: Expression.Convert(Expression.Field(Expression.Convert(self, typeof(ExposedObject)), "value"), type);
			var declaringType = type;

			do
			{
				var property = declaringType.GetProperty(memberName, GetBindingFlags());
				if (property != null)
				{
					memberExpression = Expression.Property(@this, property);
				}
				else
				{
					var field = declaringType.GetField(memberName, GetBindingFlags());
					if (field != null)
					{
						memberExpression = Expression.Field(@this, field);
					}
				}
			}
			while (memberExpression == null && (declaringType = declaringType.BaseType) != null);

			if (memberExpression == null)
			{
				throw new MissingMemberException(type.FullName, memberName);
			}

			return memberExpression;
		}


		internal static bool IlVLvNCz0p6nbtV1xf4Y()
		{
			return ONG1iHCzxiSDcVrQljl2 == null;
		}

		internal static object rJN857CzmAL78U6VGpY3()
		{
			return ONG1iHCzxiSDcVrQljl2;
		}
	}

	private static ConcurrentDictionary<string, List<PropertyInfo>> formatCache;

	private int? hashCode;

	[NonSerialized]
	[XmlIgnore]
	private Dictionary<Guid, TypeSettings> _loadedTypeSettings;

	private static object NvyMAlhuzeDfivaJhHGc;

	[DefaultValue(0)]
	[XmlElement("Id")]
	[DataMember]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_Entity), "P_Id_DisplayName")]
	public virtual IdT Id { get; set; }

	protected virtual Type EntityImplementorType => NHibernateProxyHelper.GuessClass((object)this);

	Type IEntityImplementorProvider.EntityImplementorType => EntityImplementorType;

	private IEntityManager Manager
	{
		get
		{
			//Discarded unreachable code: IL_00a4, IL_00b3
			int num = 3;
			int num2 = num;
			Type entityType = default(Type);
			Type typeWithoutProxy = default(Type);
			EntityMetadata entityMetadata = default(EntityMetadata);
			while (true)
			{
				Type type;
				switch (num2)
				{
				case 7:
					entityType = typeWithoutProxy;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					entityMetadata = MetadataLoader.LoadMetadata(typeWithoutProxy) as EntityMetadata;
					num2 = 7;
					continue;
				case 1:
					if (entityMetadata.Type == EntityMetadataType.InterfaceImplementation)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto default;
				default:
					return ModelHelper.GetEntityManager(entityType);
				case 4:
					if (entityMetadata == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 1;
				case 3:
					typeWithoutProxy = GetType().GetTypeWithoutProxy();
					num2 = 2;
					continue;
				case 6:
					type = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.ImplementationUid);
					if ((object)type != null)
					{
						break;
					}
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					type = typeWithoutProxy;
					break;
				}
				entityType = type;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public Entity()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		_loadedTypeSettings = new Dictionary<Guid, TypeSettings>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public virtual void Save()
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
				Manager.Save(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void Delete()
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
				Manager.Delete(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void Refresh()
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
				Manager.Refresh(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual bool IsNew()
	{
		return Manager.IsNew(this);
	}

	public virtual bool IsDirty()
	{
		return Manager.IsDirty(this);
	}

	public virtual Guid[] GetDirtyPropertyUids()
	{
		return Manager.GetDirtyPropertyUids(this);
	}

	public virtual object GetId()
	{
		return Id;
	}

	public virtual void SetId(object id)
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
				Id = (IdT)GetType().ConvertId(typeof(IdT), id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual object GetPropertyValue(Guid propertyUid)
	{
		return GetPropertyInfo(propertyUid).GetValue(this, null);
	}

	public virtual T GetPropertyValue<T>(Guid propertyUid)
	{
		return (T)GetPropertyValue(propertyUid);
	}

	public virtual void SetPropertyValue(Guid propertyUid, object value)
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
				GetPropertyInfo(propertyUid).SetValue(this, value, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual TSettings GetPropertySettings<TSettings>(Guid propertyUid) where TSettings : TypeSettings
	{
		return (TSettings)GetPropertySettings(propertyUid);
	}

	public virtual TypeSettings GetPropertySettings(Guid propertyUid)
	{
		return GetPropertySettings(propertyUid, null);
	}

	public virtual TypeSettings GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings)
	{
		//Discarded unreachable code: IL_0146, IL_0155, IL_01fe, IL_0236, IL_026b, IL_029d, IL_02ac
		int num = 6;
		int num2 = num;
		bool lockTaken = default(bool);
		TypeSettings typeSettings = default(TypeSettings);
		TypeSettings value = default(TypeSettings);
		Entity<IdT> obj = default(Entity<IdT>);
		IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
		TypeSettings result = default(TypeSettings);
		while (true)
		{
			switch (num2)
			{
			case 12:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				typeSettings = LoadPropertyInstanceSettings(propertyUid);
				num2 = 5;
				continue;
			case 4:
				return value;
			case 10:
				if (!_loadedTypeSettings.TryGetValue(propertyUid, out value))
				{
					obj = this;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 12;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 4;
					}
				}
				continue;
			case 3:
				return value;
			case 7:
				if (propertyMetadata.Settings != null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 1;
			case 2:
				propertyMetadata = GetPropertyMetadata(propertyUid);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 7;
				}
				continue;
			case 11:
				return typeSettings;
			case 8:
				if (defaultSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 10;
			case 5:
				if (typeSettings == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 11;
			case 1:
				return null;
			case 9:
				defaultSettings = propertyMetadata.Settings;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num3 = 3;
				while (true)
				{
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							return value;
						case 4:
							return result;
						default:
							_loadedTypeSettings[propertyUid] = value;
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
							{
								num4 = 1;
							}
							continue;
						case 6:
						case 7:
							value = ClassSerializationHelper.CloneObjectByXml(defaultSettings);
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num4 = 2;
							}
							continue;
						case 3:
							if (!_loadedTypeSettings.TryGetValue(propertyUid, out value))
							{
								num3 = 6;
								break;
							}
							goto case 5;
						case 5:
							result = value;
							num3 = 4;
							break;
						case 2:
							value.BindToEntity(this, propertyUid);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num4 = 0;
							}
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							Monitor.Exit(obj);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
							{
								num5 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public virtual TypeSettings LoadPropertyInstanceSettings(Guid propertyUid)
	{
		//Discarded unreachable code: IL_00bb, IL_0173, IL_0266, IL_0275, IL_02c1
		int num = 18;
		ITypeSettingsInstanceStore typeSettingsInstanceStore = default(ITypeSettingsInstanceStore);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		TypeSettings typeSettings = default(TypeSettings);
		TypeSettingsInstanceData.DataItem dataItem = default(TypeSettingsInstanceData.DataItem);
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_0);
		IEntity entity = default(IEntity);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (Locator.Initialized)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 1;
				case 20:
					if (typeSettingsInstanceStore.Settings == null)
					{
						num = 12;
						break;
					}
					goto case 8;
				case 4:
					if (typeSettingsInstanceStore == null)
					{
						num2 = 16;
						continue;
					}
					goto case 20;
				case 5:
					if (tablePartMetadata == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 19;
				case 9:
					return typeSettings;
				case 6:
					return null;
				case 8:
					dataItem = typeSettingsInstanceStore.Settings.Items.FirstOrDefault(_003C_003Ec__DisplayClass25_._003CLoadPropertyInstanceSettings_003Eb__0);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 21;
					}
					continue;
				case 10:
					typeSettings.BindToEntity(this, _003C_003Ec__DisplayClass25_.propertyUid);
					num = 9;
					break;
				case 1:
					return null;
				case 13:
					typeSettingsInstanceStore = TypeSettingsInstanceStoreManager.Instance.Load(this, createIfNotExists: false, loadIfNotLoaded: true);
					num2 = 4;
					continue;
				case 14:
					return dataItem.Settings;
				case 12:
				case 16:
					tablePartMetadata = ((ClassMetadata)MetadataLoader.LoadMetadata(GetType())) as TablePartMetadata;
					num2 = 5;
					continue;
				case 21:
					if (dataItem != null)
					{
						num2 = 22;
						continue;
					}
					goto case 12;
				case 11:
					typeSettings = ClassSerializationHelper.CloneObjectByXml(typeSettings);
					num2 = 10;
					continue;
				case 19:
					entity = GetPropertyValue(tablePartMetadata.ParentPropertyUid) as IEntity;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					continue;
				case 22:
					if (dataItem.Settings != null)
					{
						num2 = 3;
						continue;
					}
					goto case 12;
				default:
					if (entity != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 6;
				case 18:
					_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
					num2 = 17;
					continue;
				case 3:
					dataItem.Settings.BindToEntity(this, _003C_003Ec__DisplayClass25_.propertyUid);
					num2 = 14;
					continue;
				case 17:
					_003C_003Ec__DisplayClass25_.propertyUid = propertyUid;
					num2 = 2;
					continue;
				case 15:
					typeSettings = entity.LoadPropertyInstanceSettings(_003C_003Ec__DisplayClass25_.propertyUid);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 6;
					}
					continue;
				case 7:
					if (typeSettings != null)
					{
						num = 11;
						break;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	public virtual void SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings)
	{
		//Discarded unreachable code: IL_0076, IL_0085, IL_0179, IL_01c5, IL_01d4
		int num = 10;
		TypeSettingsInstanceData.DataItem dataItem = default(TypeSettingsInstanceData.DataItem);
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_0);
		ITypeSettingsInstanceStore typeSettingsInstanceStore = default(ITypeSettingsInstanceStore);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (Locator.Initialized)
					{
						num2 = 14;
						continue;
					}
					return;
				case 6:
					return;
				case 4:
					if (dataItem != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 9:
					_003C_003Ec__DisplayClass26_.propertyUid = propertyUid;
					num2 = 5;
					continue;
				case 7:
				case 15:
					dataItem.Settings = settings;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 3;
					}
					continue;
				case 13:
					typeSettingsInstanceStore = TypeSettingsInstanceStoreManager.Instance.Load(this, createIfNotExists: true, loadIfNotLoaded: true);
					num2 = 2;
					continue;
				case 3:
					typeSettingsInstanceStore.Settings.Items.Add(dataItem);
					num2 = 15;
					continue;
				case 11:
					return;
				case 14:
					_ = (ClassMetadata)MetadataLoader.LoadMetadata(GetType());
					num2 = 13;
					continue;
				case 1:
					return;
				case 8:
					dataItem = typeSettingsInstanceStore.Settings.Items.FirstOrDefault(_003C_003Ec__DisplayClass26_._003CSavePropertyInstanceSettings_003Eb__0);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (typeSettingsInstanceStore == null)
					{
						return;
					}
					num2 = 8;
					continue;
				case 10:
					_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
					num2 = 9;
					continue;
				case 12:
					goto end_IL_0012;
				}
				dataItem = new TypeSettingsInstanceData.DataItem
				{
					PropertyUid = _003C_003Ec__DisplayClass26_.propertyUid
				};
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			TypeSettingsInstanceStoreManager.Instance.Save(this, typeSettingsInstanceStore);
			num = 6;
		}
	}

	public virtual ITypeSettingsInstanceStore LoadSettingsInstanceStore(bool createIfNotExists, bool loadIfNotLoaded)
	{
		return TypeSettingsInstanceStoreManager.Instance.Load(this, createIfNotExists, loadIfNotLoaded);
	}

	public virtual IEnumerable<IEntity> GetContainedEntities()
	{
		List<IEntity> list = new List<IEntity>();
		ITypeSettingsInstanceStore typeSettingsInstanceStore = LoadSettingsInstanceStore(createIfNotExists: false, loadIfNotLoaded: false);
		if (typeSettingsInstanceStore != null)
		{
			list.Add(typeSettingsInstanceStore);
		}
		if (MetadataLoader.LoadMetadata(GetType()) is EntityMetadata entityMetadata)
		{
			{
				foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
				{
					IEnumerable source = null;
					object propertyValue = GetPropertyValue(tablePart.TablePartPropertyUid);
					AbstractPersistentCollection val = (AbstractPersistentCollection)((propertyValue is AbstractPersistentCollection) ? propertyValue : null);
					if (val == null && propertyValue is IInheritedSet inheritedSet)
					{
						ISet sourceSet = inheritedSet.GetSourceSet();
						val = (AbstractPersistentCollection)(object)((sourceSet is AbstractPersistentCollection) ? sourceSet : null);
					}
					if (val != null)
					{
						source = val.get_StoredSnapshot() as IEnumerable;
					}
					IEnumerable source2 = propertyValue as IEnumerable;
					list.AddRange((from i in source2.CastOrNull<IEntity>().EmptyIfNull().Union(source.CastOrNull<IEntity>().EmptyIfNull())
						where i != null
						select i).SelectMany((IEntity i) => new IEntity[1] { i }.Concat(i.GetContainedEntities())));
				}
				return list;
			}
		}
		return list;
	}

	public virtual IEntity GetRootEntity()
	{
		int num = 3;
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		IEntity entity = default(IEntity);
		IEntity result = default(IEntity);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					tablePartMetadata = MetadataLoader.LoadMetadata(GetType()) as TablePartMetadata;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (entity == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return entity.GetRootEntity();
				default:
					result = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (tablePartMetadata != null)
					{
						entity = GetPropertyValue(tablePartMetadata.ParentPropertyUid) as IEntity;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					break;
				case 5:
					return this;
				case 1:
					return result;
				}
				break;
			}
			num = 5;
		}
	}

	public virtual string ToString(string format)
	{
		//Discarded unreachable code: IL_016f, IL_017e
		int num = 1;
		int num2 = num;
		string key = default(string);
		List<PropertyInfo> value = default(List<PropertyInfo>);
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				formatCache[key] = value;
				num2 = 5;
				break;
			case 3:
				if (string.IsNullOrEmpty(format))
				{
					num2 = 6;
					break;
				}
				_003C_003Ec__DisplayClass31_.fmt = format;
				num2 = 9;
				break;
			case 2:
			case 5:
				return value.Aggregate(format, _003C_003Ec__DisplayClass31_._003CToString_003Eb__1);
			case 6:
				return string.Empty;
			case 7:
				value = GetType().GetReflectionProperties().Where(_003C_003Ec__DisplayClass31_._003CToString_003Eb__0).ToList();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 4;
				}
				break;
			case 8:
				if (formatCache.TryGetValue(key, out value))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 1:
				_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				key = GetType().FullName + format;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 8;
				}
				break;
			default:
				_003C_003Ec__DisplayClass31_._003C_003E4__this = this;
				num2 = 3;
				break;
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0085, IL_0094
		int num = 3;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				classMetadata = MetadataLoader.LoadMetadata(GetType()) as ClassMetadata;
				num2 = 2;
				break;
			case 2:
				if (classMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return base.ToString();
			case 1:
				return ToString(classMetadata.DisplayFormat);
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0096
		int num = 3;
		IEntity<IdT> entity = default(IEntity<IdT>);
		IdT id = default(IdT);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (this == obj)
					{
						num2 = 2;
						continue;
					}
					entity = obj as IEntity<IdT>;
					num = 9;
					break;
				case 5:
					id = Id;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (Id == null)
					{
						num2 = 8;
						continue;
					}
					goto case 4;
				case 1:
					if (!id.Equals(default(IdT)))
					{
						num2 = 5;
						continue;
					}
					goto case 7;
				case 9:
					if (entity != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 7;
				default:
					if (!id.Equals(entity.Id))
					{
						num = 7;
						break;
					}
					return TypeAssignable(obj);
				case 7:
				case 8:
					return false;
				case 2:
					return true;
				case 4:
					id = Id;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!hashCode.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return hashCode.Value;
			default:
				hashCode = ((Id == null || Id.Equals(default(IdT))) ? base.GetHashCode() : Id.GetHashCode());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected virtual IPropertyMetadata GetPropertyMetadata(Guid propertyUid)
	{
		return TryGetPropertyMetadata(propertyUid) ?? throw new MetadataException(string.Format(arg1: ((ClassMetadata)MetadataLoader.LoadMetadata(GetType())).FullTypeName, format: SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542794621)), arg0: propertyUid));
	}

	protected virtual IPropertyMetadata TryGetPropertyMetadata(Guid propertyUid)
	{
		//Discarded unreachable code: IL_006f, IL_007e, IL_008e, IL_009d
		int num = 8;
		ClassMetadata classMetadata = default(ClassMetadata);
		IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
		IEntityMetadata entityMetadata = default(IEntityMetadata);
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = default(_003C_003Ec__DisplayClass36_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(GetType());
					num2 = 5;
					break;
				case 11:
					propertyMetadata = entityMetadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().FirstOrDefault(_003C_003Ec__DisplayClass36_._003CTryGetPropertyMetadata_003Eb__1);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 6;
					}
					break;
				case 2:
				case 9:
					return propertyMetadata;
				default:
					entityMetadata = classMetadata as IEntityMetadata;
					num2 = 4;
					break;
				case 7:
					_003C_003Ec__DisplayClass36_.propertyUid = propertyUid;
					num2 = 6;
					break;
				case 10:
					if (propertyMetadata != null)
					{
						num2 = 2;
						break;
					}
					goto default;
				case 4:
					if (entityMetadata != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 1:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313145C6)), GetType().FullName));
				case 3:
					propertyMetadata = classMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass36_._003CTryGetPropertyMetadata_003Eb__0);
					num2 = 10;
					break;
				case 5:
					if (classMetadata != null)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				case 8:
					_003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
					num2 = 7;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	protected virtual PropertyInfo GetPropertyInfo(Guid propertyUid)
	{
		int num = 2;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(GetType());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				propertyMetadata = GetPropertyMetadata(propertyUid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				PropertyInfo reflectionProperty = GetType().GetReflectionProperty(propertyMetadata.Name);
				if (reflectionProperty == null)
				{
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1920998477)), propertyMetadata.Name, classMetadata.FullTypeName));
				}
				return reflectionProperty;
			}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool TypeAssignable([NotNull] object obj)
	{
		//Discarded unreachable code: IL_004f, IL_006e, IL_007d, IL_008d, IL_009c, IL_00d7, IL_00e1
		int num = 4;
		int num2 = num;
		Type type3 = default(Type);
		Type type4 = default(Type);
		while (true)
		{
			Type type2;
			Type type;
			switch (num2)
			{
			case 5:
				type2 = GetType();
				goto IL_0142;
			case 4:
				if (this is INHibernateProxy)
				{
					num2 = 3;
					continue;
				}
				goto case 5;
			case 8:
				if (obj is INHibernateProxy)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto default;
			default:
				type = obj.GetType();
				break;
			case 9:
				return type3.IsAssignableFrom(type4);
			case 6:
				return true;
			case 7:
				if (!type4.IsAssignableFrom(type3))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 6;
			case 2:
				if (type3 == type4)
				{
					num2 = 6;
					continue;
				}
				goto case 7;
			case 3:
				type2 = GetType().BaseType;
				goto IL_0142;
			case 1:
				{
					type = obj.GetType().BaseType;
					break;
				}
				IL_0142:
				type3 = type2;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 8;
				}
				continue;
			}
			type4 = type;
			num2 = 2;
		}
	}

	DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
	{
		return new ReflectionDynamicMetaObject(parameter, this);
	}

	static Entity()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				formatCache = new ConcurrentDictionary<string, List<PropertyInfo>>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool tdCLwXhIFYTeQrNan3ip()
	{
		return NvyMAlhuzeDfivaJhHGc == null;
	}

	internal static object OrrwTlhIBvmX4OvJE4Qs()
	{
		return NvyMAlhuzeDfivaJhHGc;
	}
}
