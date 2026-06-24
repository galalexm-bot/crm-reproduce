using System;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Persister.Entity;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public static class SessionExtensions
{
	private static IRuntimeApplication runtimeApplication;

	internal static SessionExtensions rbcMxYWw3GC9BRxMn3Bx;

	private static IRuntimeApplication RuntimeApplication
	{
		get
		{
			int num = 1;
			int num2 = num;
			IRuntimeApplication obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = runtimeApplication;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (runtimeApplication = Locator.GetService<IRuntimeApplication>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	public static void Delete<TEntity>(this ISession session, object id) where TEntity : IEntity
	{
		Contract.ArgumentNotNull(session, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957822096));
		Contract.ArgumentNotNull(id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FEF823));
		string tableName = ((EntityMetadata)MetadataLoader.LoadMetadata(typeof(TEntity))).TableName;
		session.Delete(id, tableName);
	}

	public static void Delete(this ISession session, object id, string tableName)
	{
		int num = 6;
		int num2 = num;
		string text = default(string);
		Dialect dialect = default(Dialect);
		while (true)
		{
			switch (num2)
			{
			case 4:
				((IQuery)SqSwjAWw7Rh2n6OeqUjc(iowPdpWwAKodldlhLj8l(session, text), iXx7k5WwDxpwNIikuyXL(0x4DC2B14D ^ 0x4DC38237), id)).ExecuteUpdate();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				text = (string)iXx7k5WwDxpwNIikuyXL(0x1ECE530A ^ 0x1ECFFCD8) + (string)SrRq11WwHu2HjuJhNq87(dialect, tableName) + (string)iXx7k5WwDxpwNIikuyXL(0x5A4C7B29 ^ 0x5A4D577F) + (string)SrRq11WwHu2HjuJhNq87(dialect, iXx7k5WwDxpwNIikuyXL(0x76DD48E ^ 0x76D55D0)) + (string)iXx7k5WwDxpwNIikuyXL(0x48A7E34A ^ 0x48A5C27C);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				nUPYSsWwtTyrEbmtZBMB(session, iXx7k5WwDxpwNIikuyXL(-1870892489 ^ -1870890233));
				num2 = 5;
				break;
			case 1:
				dialect = ((ITransformationProvider)t5PFTVWw6AdjfZ4qc0Pb(pnS7LBWw4kRI0s59xvY9())).Dialect;
				num2 = 2;
				break;
			case 5:
				HcSIOqWwwYT1PE5gnnlY(tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A7BEBD));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			default:
				nUPYSsWwtTyrEbmtZBMB(id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548A9DF0));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public static bool IsDirtyEntity(this ISession session, object entity)
	{
		//Discarded unreachable code: IL_01e5
		int num = 12;
		int num2 = num;
		EntityEntry val2 = default(EntityEntry);
		ISessionImplementor val = default(ISessionImplementor);
		object obj = default(object);
		INHibernateProxy val3 = default(INHibernateProxy);
		string entityName = default(string);
		int[] array2 = default(int[]);
		while (true)
		{
			switch (num2)
			{
			case 7:
				val2 = (EntityEntry)PiWfEoWw0JZYrefGKAYS(val.get_PersistenceContext(), obj);
				num2 = 9;
				break;
			case 2:
				if (((ILazyInitializer)LJWjRNWwySBbBDe49hra(val3)).get_IsUninitialized())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					obj = DjTjZnWwJwV1ulN2sssL(l3ohuuWwM75bcmU3NL2j(val), val3);
					num2 = 7;
				}
				break;
			case 1:
				return false;
			case 11:
				val2 = (EntityEntry)PiWfEoWw0JZYrefGKAYS(val.get_PersistenceContext(), entity);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 10;
				}
				break;
			case 8:
			case 9:
				if (val2 == null)
				{
					num2 = 6;
					break;
				}
				entityName = val2.get_EntityName();
				num2 = 5;
				break;
			case 12:
				val = (ISessionImplementor)LCS7tPWwxrukUbCLtfyb(session);
				num2 = 11;
				break;
			default:
				if (!Wdh6h3WwmbbfVOlsZesg(entity))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 13;
			case 10:
				if (val2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 3:
				return array2.Length != 0;
			case 6:
				return false;
			case 4:
				if (array2 == null)
				{
					return false;
				}
				num2 = 3;
				break;
			case 13:
				val3 = (INHibernateProxy)((entity is INHibernateProxy) ? entity : null);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
			{
				IEntityPersister entityPersister = ((ISessionFactoryImplementor)IQRVCEWw96ES3BianepS(val)).GetEntityPersister(entityName);
				object[] array = (object[])v6EMecWwdVn2m2eqmpUG(val2);
				object[] propertyValues = entityPersister.GetPropertyValues(entity);
				array2 = (int[])AY5Ro3Wwl5doR5OnLp1j(entityPersister, propertyValues, array, entity, val);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 3;
				}
				break;
			}
			}
		}
	}

	public static bool IsDirtyEntity(this ISession session, IEntityPersister persister, object[] oldState, object[] currentState, object entity)
	{
		//Discarded unreachable code: IL_0099
		int num = 1;
		int num2 = num;
		int[] array = default(int[]);
		ISessionImplementor val = default(ISessionImplementor);
		while (true)
		{
			switch (num2)
			{
			default:
				array = (int[])AY5Ro3Wwl5doR5OnLp1j(persister, currentState, oldState, entity, val);
				num2 = 3;
				break;
			case 1:
				val = (ISessionImplementor)LCS7tPWwxrukUbCLtfyb(session);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return array.Length != 0;
			case 2:
				return false;
			case 3:
				if (array == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public static bool IsDirtyProperty(this ISession session, object entity, string propertyName)
	{
		int num = 1;
		INHibernateProxy val2 = default(INHibernateProxy);
		EntityEntry val = default(EntityEntry);
		ISessionImplementor sessionImplementation = default(ISessionImplementor);
		object obj = default(object);
		string text = default(string);
		int[] array = default(int[]);
		int value = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 5:
					val2 = (INHibernateProxy)((entity is INHibernateProxy) ? entity : null);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					val = (EntityEntry)PiWfEoWw0JZYrefGKAYS(l3ohuuWwM75bcmU3NL2j(sessionImplementation), obj);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					sessionImplementation = session.GetSessionImplementation();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return false;
				case 2:
					if (FBhrynWwrGh4pf9On01F(LJWjRNWwySBbBDe49hra(val2)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 6;
						}
					}
					else
					{
						obj = DjTjZnWwJwV1ulN2sssL(l3ohuuWwM75bcmU3NL2j(sessionImplementation), val2);
						num2 = 8;
					}
					continue;
				case 12:
					if (val != null)
					{
						text = (string)F0XmqhWwg20l9BFDQPft(val);
						num2 = 3;
						continue;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					return Array.IndexOf(array, value) != -1;
				case 9:
					if (NHibernateProxyHelper.IsProxy(entity))
					{
						num2 = 5;
						continue;
					}
					goto case 12;
				case 11:
					if (val == null)
					{
						num2 = 9;
						continue;
					}
					goto case 12;
				case 6:
					return false;
				case 7:
					if (array == null)
					{
						return false;
					}
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 10;
					}
					continue;
				default:
					val = ((IPersistenceContext)l3ohuuWwM75bcmU3NL2j(sessionImplementation)).GetEntry(entity);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
			object obj2 = tnx18eWw5B7qLKW9ikqv(IQRVCEWw96ES3BianepS(sessionImplementation), text);
			object[] array2 = (object[])v6EMecWwdVn2m2eqmpUG(val);
			object[] propertyValues = ((IEntityPersister)obj2).GetPropertyValues(entity);
			array = (int[])AY5Ro3Wwl5doR5OnLp1j(obj2, propertyValues, array2, entity, sessionImplementation);
			value = Array.IndexOf((string[])RQf7tEWwj2TtOdQWmwQv(obj2), propertyName);
			num = 7;
		}
	}

	public static object GetOriginalEntityProperty(this ISession session, object entity, string propertyName)
	{
		//Discarded unreachable code: IL_00b2, IL_01c3
		int num = 7;
		EntityEntry val2 = default(EntityEntry);
		INHibernateProxy val3 = default(INHibernateProxy);
		ISessionImplementor val = default(ISessionImplementor);
		int[] array2 = default(int[]);
		object obj = default(object);
		string text = default(string);
		object[] propertyValues = default(object[]);
		int num3 = default(int);
		object[] array = default(object[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					if (val2 != null)
					{
						num2 = 9;
						continue;
					}
					goto case 14;
				default:
					val3 = (INHibernateProxy)((entity is INHibernateProxy) ? entity : null);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 8;
					}
					continue;
				case 7:
					val = (ISessionImplementor)LCS7tPWwxrukUbCLtfyb(session);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					if (NHibernateProxyHelper.IsProxy(entity))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 6:
					val2 = (EntityEntry)PiWfEoWw0JZYrefGKAYS(l3ohuuWwM75bcmU3NL2j(val), entity);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					if (array2 != null)
					{
						num2 = 2;
						continue;
					}
					break;
				case 8:
					if (FBhrynWwrGh4pf9On01F(LJWjRNWwySBbBDe49hra(val3)))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 6;
						}
					}
					else
					{
						obj = DjTjZnWwJwV1ulN2sssL(l3ohuuWwM75bcmU3NL2j(val), val3);
						num2 = 3;
					}
					continue;
				case 3:
					goto end_IL_0012;
				case 14:
					return entity.GetPropertyValue(propertyName, null);
				case 9:
					text = (string)F0XmqhWwg20l9BFDQPft(val2);
					num2 = 11;
					continue;
				case 10:
					return entity.GetPropertyValue(propertyName, null);
				case 4:
					return propertyValues[num3];
				case 2:
					if (Array.IndexOf(array2, num3) != -1)
					{
						return array[num3];
					}
					break;
				case 1:
					if (val2 == null)
					{
						num2 = 5;
						continue;
					}
					goto case 12;
				case 11:
				{
					IEntityPersister entityPersister = ((ISessionFactoryImplementor)IQRVCEWw96ES3BianepS(val)).GetEntityPersister(text);
					array = (object[])v6EMecWwdVn2m2eqmpUG(val2);
					propertyValues = entityPersister.GetPropertyValues(entity);
					array2 = (int[])AY5Ro3Wwl5doR5OnLp1j(entityPersister, propertyValues, array, entity, val);
					num3 = Array.IndexOf((string[])RQf7tEWwj2TtOdQWmwQv(entityPersister), propertyName);
					num2 = 13;
					continue;
				}
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			val2 = ((IPersistenceContext)l3ohuuWwM75bcmU3NL2j(val)).GetEntry(obj);
			num = 12;
		}
	}

	public static object GetOriginalEntity(this ISession session, object entity)
	{
		//Discarded unreachable code: IL_00bd, IL_00cc, IL_01b3, IL_01c2, IL_01d2, IL_01e1, IL_022f, IL_023e
		int num = 10;
		object obj2 = default(object);
		IEntityPersister val4 = default(IEntityPersister);
		object[] array = default(object[]);
		INHibernateProxy val2 = default(INHibernateProxy);
		EntityEntry val3 = default(EntityEntry);
		IPersistenceContext val = default(IPersistenceContext);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!Wdh6h3WwmbbfVOlsZesg(entity))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 13;
				case 6:
					obj2 = uwZptiWwUBKttXQrhwa5(entity.GetType());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 14;
					}
					continue;
				case 16:
					return entity;
				case 14:
					EqJX4oWwsLlhdM0epWx2(val4, obj2, array);
					num2 = 2;
					continue;
				case 17:
					if (!FBhrynWwrGh4pf9On01F(LJWjRNWwySBbBDe49hra(val2)))
					{
						num = 15;
						break;
					}
					goto case 4;
				case 13:
					val2 = (INHibernateProxy)((entity is INHibernateProxy) ? entity : null);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 15;
					}
					continue;
				case 3:
					val4 = (IEntityPersister)GdhKZeWwYmRon9C16Ae2(session, entity);
					num2 = 7;
					continue;
				case 1:
					return entity;
				case 7:
					if (!IYSJwOWwLxOwS66nONo2(val4, entity))
					{
						val3 = (EntityEntry)PiWfEoWw0JZYrefGKAYS(val, entity);
						num = 8;
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return obj2;
				case 12:
					val3 = (EntityEntry)PiWfEoWw0JZYrefGKAYS(val, obj);
					num2 = 18;
					continue;
				case 10:
					if (entity != null)
					{
						num = 9;
						break;
					}
					goto case 5;
				case 8:
					if (val3 != null)
					{
						num2 = 11;
						continue;
					}
					goto default;
				case 5:
					return null;
				case 9:
					val = (IPersistenceContext)l3ohuuWwM75bcmU3NL2j(LCS7tPWwxrukUbCLtfyb(session));
					num2 = 3;
					continue;
				case 11:
				case 18:
				case 19:
					if (val3 != null)
					{
						array = (object[])v6EMecWwdVn2m2eqmpUG(val3);
						num2 = 6;
						continue;
					}
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 13;
					}
					continue;
				case 4:
					return entity;
				case 15:
					obj = DjTjZnWwJwV1ulN2sssL(val, val2);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static object iXx7k5WwDxpwNIikuyXL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void nUPYSsWwtTyrEbmtZBMB(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void HcSIOqWwwYT1PE5gnnlY(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object pnS7LBWw4kRI0s59xvY9()
	{
		return RuntimeApplication;
	}

	internal static object t5PFTVWw6AdjfZ4qc0Pb(object P_0)
	{
		return ((IRuntimeApplication)P_0).TransformationProvider;
	}

	internal static object SrRq11WwHu2HjuJhNq87(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object iowPdpWwAKodldlhLj8l(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object SqSwjAWw7Rh2n6OeqUjc(object P_0, object P_1, object P_2)
	{
		return ((IQuery)P_0).SetParameter((string)P_1, P_2);
	}

	internal static bool jiSfyNWwpxAR7iL43sWZ()
	{
		return rbcMxYWw3GC9BRxMn3Bx == null;
	}

	internal static SessionExtensions YitjVPWwa72Eao643rFr()
	{
		return rbcMxYWw3GC9BRxMn3Bx;
	}

	internal static object LCS7tPWwxrukUbCLtfyb(object P_0)
	{
		return ((ISession)P_0).GetSessionImplementation();
	}

	internal static object PiWfEoWw0JZYrefGKAYS(object P_0, object P_1)
	{
		return ((IPersistenceContext)P_0).GetEntry(P_1);
	}

	internal static bool Wdh6h3WwmbbfVOlsZesg(object P_0)
	{
		return NHibernateProxyHelper.IsProxy(P_0);
	}

	internal static object LJWjRNWwySBbBDe49hra(object P_0)
	{
		return ((INHibernateProxy)P_0).get_HibernateLazyInitializer();
	}

	internal static object l3ohuuWwM75bcmU3NL2j(object P_0)
	{
		return ((ISessionImplementor)P_0).get_PersistenceContext();
	}

	internal static object DjTjZnWwJwV1ulN2sssL(object P_0, object P_1)
	{
		return ((IPersistenceContext)P_0).Unproxy(P_1);
	}

	internal static object IQRVCEWw96ES3BianepS(object P_0)
	{
		return ((ISessionImplementor)P_0).get_Factory();
	}

	internal static object v6EMecWwdVn2m2eqmpUG(object P_0)
	{
		return ((EntityEntry)P_0).get_LoadedState();
	}

	internal static object AY5Ro3Wwl5doR5OnLp1j(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ((IEntityPersister)P_0).FindDirty((object[])P_1, (object[])P_2, P_3, (ISessionImplementor)P_4);
	}

	internal static bool FBhrynWwrGh4pf9On01F(object P_0)
	{
		return ((ILazyInitializer)P_0).get_IsUninitialized();
	}

	internal static object F0XmqhWwg20l9BFDQPft(object P_0)
	{
		return ((EntityEntry)P_0).get_EntityName();
	}

	internal static object tnx18eWw5B7qLKW9ikqv(object P_0, object P_1)
	{
		return ((ISessionFactoryImplementor)P_0).GetEntityPersister((string)P_1);
	}

	internal static object RQf7tEWwj2TtOdQWmwQv(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static object GdhKZeWwYmRon9C16Ae2(object P_0, object P_1)
	{
		return ((ISession)P_0).GetEntityPersister(P_1);
	}

	internal static bool IYSJwOWwLxOwS66nONo2(object P_0, object P_1)
	{
		return ((IEntityPersister)P_0).HasUninitializedLazyProperties(P_1);
	}

	internal static object uwZptiWwUBKttXQrhwa5(Type t)
	{
		return InterfaceActivator.Create(t);
	}

	internal static void EqJX4oWwsLlhdM0epWx2(object P_0, object P_1, object P_2)
	{
		((IEntityPersister)P_0).SetPropertyValues(P_1, (object[])P_2);
	}
}
