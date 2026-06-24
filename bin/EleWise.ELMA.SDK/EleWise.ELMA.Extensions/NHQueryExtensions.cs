using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using NHibernate.Impl;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class NHQueryExtensions
{
	internal static NHQueryExtensions DOM0oqG6yNSigv2j4stt;

	public static SqlSubQuery GetNamedSubQuery(this ISession session, string name)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		SqlQueryImpl val = default(SqlQueryImpl);
		while (true)
		{
			switch (num2)
			{
			case 1:
				val = (SqlQueryImpl)session.GetNamedQuery(name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978215776), name));
			}
			if (val == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return new SqlSubQuery(val, session);
		}
	}

	public static SqlSubQuery CreateSQLSubQuery(this ISession session, string queryString)
	{
		return new SqlSubQuery(queryString, session);
	}

	public static AbstractCriterion Sql(SqlString sql, object[] values, IType[] types)
	{
		return (AbstractCriterion)(object)new AliasesSQLCriterion(sql, values, types);
	}

	public static AbstractCriterion Sql(SqlString sql)
	{
		return Sql(sql, new object[0], (IType[])(object)new IType[0]);
	}

	public static AbstractCriterion Sql(string sql, object[] values, IType[] types)
	{
		return (AbstractCriterion)pWnsh2G69Qj1ebgwFhaR(SqlString.Parse(sql), values, types);
	}

	public static AbstractCriterion Sql(string sql)
	{
		return (AbstractCriterion)IXWhu1G6dE4BEZwYalsf(sql, new object[0], new IType[0]);
	}

	public static CustomPropertyProjection PropertyProjection(Type rootType, string fullentityName, string propertyName, bool forOrder, out string realProperty, out EntityMetadata realMetadata, out EntityPropertyMetadata realPropertyMetadata)
	{
		//Discarded unreachable code: IL_020b, IL_021a
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		Tuple<CustomPropertyProjection, string, EntityMetadata, EntityPropertyMetadata> orAdd = default(Tuple<CustomPropertyProjection, string, EntityMetadata, EntityPropertyMetadata>);
		while (true)
		{
			switch (num2)
			{
			case 5:
				_003C_003Ec__DisplayClass6_.forOrder = forOrder;
				num2 = 10;
				break;
			case 10:
				if (!LQ41AWG6lViUjC4k8CHB(_003C_003Ec__DisplayClass6_.rootType, null))
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 9;
			case 7:
				_003C_003Ec__DisplayClass6_.fullentityName = fullentityName;
				num2 = 8;
				break;
			case 4:
				realMetadata = orAdd.Item3;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				realProperty = orAdd.Item2;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 4;
				}
				break;
			default:
				_003C_003Ec__DisplayClass6_.rootType = rootType;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 7;
				}
				break;
			case 9:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234037878));
			case 11:
				orAdd = ContextVars.GetOrAdd((string)qKx8cWG6g54BmXDgLpPJ(new string[7]
				{
					(string)U1f6FgG6r4S6dhxM9Prd(-889460160 ^ -889198354),
					_003C_003Ec__DisplayClass6_.rootType.AssemblyQualifiedName,
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x745CADE),
					_003C_003Ec__DisplayClass6_.fullentityName,
					_003C_003Ec__DisplayClass6_.propertyName,
					(string)U1f6FgG6r4S6dhxM9Prd(-957824448 ^ -957835620),
					_003C_003Ec__DisplayClass6_.forOrder.ToString()
				}), _003C_003Ec__DisplayClass6_._003CPropertyProjection_003Eb__0);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				_003C_003Ec__DisplayClass6_.propertyName = propertyName;
				num2 = 5;
				break;
			case 3:
				return orAdd.Item1;
			case 2:
				realPropertyMetadata = orAdd.Item4;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public static void ExecuteWithTimeout(this ISession session, int timeout, Action action)
	{
		//Discarded unreachable code: IL_0049, IL_0068, IL_0077, IL_00c9, IL_00dc, IL_00eb
		int num = 1;
		int num2 = num;
		int? currentContextTimeout = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				currentContextTimeout = CustomBatcher.SetCurrentContextTimeout(timeout);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				int num3;
				if (action == null)
				{
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num3 = 1;
					}
					goto IL_004d;
				}
				goto IL_0082;
				IL_0082:
				action();
				num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num3 = 1;
				}
				goto IL_004d;
				IL_004d:
				switch (num3)
				{
				case 2:
					return;
				case 1:
					return;
				}
				goto IL_0082;
			}
			finally
			{
				CustomBatcher.SetCurrentContextTimeout(currentContextTimeout);
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	public static void LockWithWait(this ISession session, object obj)
	{
		//Discarded unreachable code: IL_007b, IL_00c1, IL_00d6, IL_0146, IL_0168, IL_0197, IL_01a6, IL_0204, IL_02a0, IL_02b1, IL_02bb, IL_02ca, IL_0370, IL_037f
		int num = 17;
		int? num3 = default(int?);
		DateTime dateTime = default(DateTime);
		int? num7 = default(int?);
		DateTime dateTime2 = default(DateTime);
		IEntity entity = default(IEntity);
		object obj4 = default(object);
		int num6 = default(int);
		IRuntimeApplication runtimeApplication = default(IRuntimeApplication);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				int num4;
				int? num5;
				switch (num2)
				{
				case 17:
					if (session == null)
					{
						num2 = 16;
						continue;
					}
					if (obj != null)
					{
						num2 = 5;
						continue;
					}
					goto case 9;
				case 8:
					return;
				case 13:
					obj2 = null;
					goto IL_038f;
				case 1:
					if (num3.Value <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					num4 = num3.Value;
					goto IL_03c5;
				case 2:
					dateTime = eUrvZNG6jcn2KiLyU46x();
					num = 3;
					break;
				default:
					num4 = 30;
					goto IL_03c5;
				case 6:
					num7 = null;
					num = 10;
					break;
				case 9:
					throw new ArgumentNullException((string)U1f6FgG6r4S6dhxM9Prd(0x4785BC0D ^ 0x47851F85));
				case 5:
					if (rCn7nOG65RgJ0qdFVdxE())
					{
						num = 14;
						break;
					}
					goto case 13;
				case 12:
					try
					{
						session.Lock(obj, LockMode.Upgrade);
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
						return;
					}
					catch (GenericADOException)
					{
						int num9 = 6;
						while (true)
						{
							object obj3;
							switch (num9)
							{
							case 6:
								if (!UQR7NUG6YqwRbTH1hMtm(DateTime.Now, dateTime2))
								{
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num9 = 0;
									}
									continue;
								}
								goto case 4;
							case 4:
								entity = obj as IEntity;
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
								{
									num9 = 0;
								}
								continue;
							case 2:
								obj3 = null;
								goto IL_0231;
							default:
								if (entity == null)
								{
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num9 = 2;
									}
									continue;
								}
								obj3 = LoJCUSG6LdBC9ocyUMvL(entity);
								goto IL_0231;
							case 3:
								throw new ObtainObjectLockException(obj.GetType().FullName, (obj4 != null) ? obj4 : obj.ToString());
							case 1:
								qa6ZZZG6U1u3esJ9tRFB(1000);
								num9 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
								{
									num9 = 4;
								}
								continue;
							case 5:
								break;
								IL_0231:
								obj4 = obj3;
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num9 = 3;
								}
								continue;
							}
							break;
						}
					}
					goto case 11;
				case 10:
					num5 = num7;
					goto IL_03b2;
				case 3:
					dateTime2 = dateTime.AddSeconds(num6);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					num = 12;
					break;
				case 16:
					throw new ArgumentNullException((string)U1f6FgG6r4S6dhxM9Prd(-1978478350 ^ -1978476094));
				case 15:
					if (runtimeApplication == null)
					{
						num = 6;
						break;
					}
					num5 = runtimeApplication.GetCommandTimeout();
					goto IL_03b2;
				case 7:
					if (!num3.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 1;
				case 14:
					{
						obj2 = Locator.GetService<IRuntimeApplication>();
						goto IL_038f;
					}
					IL_038f:
					runtimeApplication = (IRuntimeApplication)obj2;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 15;
					}
					continue;
					IL_03c5:
					num6 = num4;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 2;
					}
					continue;
					IL_03b2:
					num3 = num5;
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	public static void LockWithWait(this ISession session, object obj, int timeout)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				_003C_003Ec__DisplayClass9_.obj = obj;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				_003C_003Ec__DisplayClass9_.session = session;
				num2 = 4;
				break;
			case 3:
				_003C_003Ec__DisplayClass9_.session.ExecuteWithTimeout(timeout, _003C_003Ec__DisplayClass9_._003CLockWithWait_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static object LoadAndLockWithWait<T>(this ISession session, object id)
	{
		//IL_0086: Expected O, but got Unknown
		int? num = (Locator.Initialized ? Locator.GetService<IRuntimeApplication>() : null)?.GetCommandTimeout();
		int num2 = ((num.HasValue && num.Value > 0) ? num.Value : 30);
		DateTime dateTime = DateTime.Now.AddSeconds(num2);
		while (true)
		{
			try
			{
				return session.Load<T>(id, LockMode.Upgrade);
			}
			catch (GenericADOException val)
			{
				GenericADOException exception = val;
				Logger.Log.Log(LogLevel.Debug, (Exception)(object)exception, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475594793), dateTime));
				if (DateTime.Now > dateTime)
				{
					throw new ObtainObjectLockException(typeof(T).FullName, id);
				}
				Thread.Sleep(1000);
			}
		}
	}

	private static CustomPropertyProjection PropertyProjectionNonCache(Type rootType, object fullentityName, object propertyName, bool forOrder, out string realProperty, out EntityMetadata realMetadata, out EntityPropertyMetadata realPropertyMetadata)
	{
		//Discarded unreachable code: IL_0099, IL_013b, IL_0230, IL_023a, IL_027e, IL_028d
		int num = 18;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		_003C_003Ec__DisplayClass11_1 _003C_003Ec__DisplayClass11_2 = default(_003C_003Ec__DisplayClass11_1);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		string propertyName2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 25:
					return null;
				case 18:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num = 17;
					break;
				case 22:
					entityMetadata2 = ((IMetadataService)db9iKxG6sFuQ4BYCpCkF()).GetMetadataList().OfType<EntityMetadata>().FirstOrDefault(_003C_003Ec__DisplayClass11_._003CPropertyProjectionNonCache_003Eb__0);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 21;
					}
					continue;
				case 21:
					if (entityMetadata2 != null)
					{
						_003C_003Ec__DisplayClass11_.rootMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(rootType);
						num2 = 13;
						continue;
					}
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 15;
					}
					continue;
				case 27:
					if (propertyMetadata == null)
					{
						num2 = 8;
						continue;
					}
					realProperty = (string)GQ4glRGHbbOw4sGAFY4B(propertyMetadata);
					num2 = 2;
					continue;
				case 11:
					realPropertyMetadata = null;
					num2 = 9;
					continue;
				case 5:
					propertyMetadata = entityMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass11_2._003CPropertyProjectionNonCache_003Eb__4);
					num2 = 27;
					continue;
				case 16:
					if (!m6Oe6IG6zEO1PlN70OWX(_003C_003Ec__DisplayClass11_.propertyName, U1f6FgG6r4S6dhxM9Prd(-2138160520 ^ -2138177510)))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 12;
						}
						continue;
					}
					obj = DhuB8FGHFSkm2Une0y4i(rootType);
					goto IL_0464;
				case 3:
					return null;
				case 7:
					realPropertyMetadata = entityPropertyMetadata;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 14;
					}
					continue;
				case 26:
					if (entityPropertyMetadata != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 3;
				case 10:
					_003C_003Ec__DisplayClass11_2.settings = entityPropertyMetadata.Settings as PropertySettings;
					num2 = 20;
					continue;
				case 15:
					obj = _003C_003Ec__DisplayClass11_.propertyName;
					goto IL_0464;
				case 12:
					entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(aiOUYYG6cAAokS1pyZFW(entityMetadata));
					num2 = 28;
					continue;
				case 20:
					if (_003C_003Ec__DisplayClass11_2.settings == null)
					{
						num2 = 24;
						continue;
					}
					goto case 5;
				case 14:
					_003C_003Ec__DisplayClass11_2 = new _003C_003Ec__DisplayClass11_1();
					num2 = 10;
					continue;
				default:
					entityPropertyMetadata = (EntityPropertyMetadata)entityMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CPropertyProjectionNonCache_003Eb__3);
					num2 = 26;
					continue;
				case 8:
					return null;
				case 17:
					_003C_003Ec__DisplayClass11_.fullentityName = (string)fullentityName;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 29:
					realProperty = "";
					num = 11;
					break;
				case 19:
					if (entityMetadata == null)
					{
						num2 = 6;
						continue;
					}
					goto case 12;
				case 9:
					realMetadata = null;
					num2 = 22;
					continue;
				case 23:
					if (Hu6G57GHoyRqgUXADq4K(b4Rc3QGHWRQOaVX474iN(Locator.GetServiceNotNull<IMetadataRuntimeService>(), entityPropertyMetadata.TypeUid, raukyWGHB0cU4bVW6qHV(entityPropertyMetadata)), entityMetadata, entityPropertyMetadata))
					{
						num2 = 4;
						continue;
					}
					goto case 14;
				case 2:
					return new CustomPropertyProjection(propertyMetadata.Name, _003C_003Ec__DisplayClass11_.fullentityName, (string)hVTnfrGHhvIRl6cwPVBO(entityMetadata2), propertyMetadata, forOrder);
				case 24:
					return new CustomPropertyProjection(propertyName2, _003C_003Ec__DisplayClass11_.fullentityName, (string)hVTnfrGHhvIRl6cwPVBO(entityMetadata2), entityPropertyMetadata, forOrder);
				case 4:
					return new CustomPropertyProjection(propertyName2, _003C_003Ec__DisplayClass11_.fullentityName, (string)hVTnfrGHhvIRl6cwPVBO(entityMetadata2), entityPropertyMetadata, forOrder);
				case 6:
					return null;
				case 13:
					entityMetadata = (EntityMetadata)ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217785259) + aiOUYYG6cAAokS1pyZFW(_003C_003Ec__DisplayClass11_.rootMetadata), _003C_003Ec__DisplayClass11_._003CPropertyProjectionNonCache_003Eb__1).FirstOrDefault(_003C_003Ec__DisplayClass11_._003CPropertyProjectionNonCache_003Eb__2);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 19;
					}
					continue;
				case 28:
					realMetadata = entityMetadata;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					{
						_003C_003Ec__DisplayClass11_.propertyName = (string)propertyName;
						num2 = 29;
						continue;
					}
					IL_0464:
					propertyName2 = (string)obj;
					num2 = 23;
					continue;
				}
				break;
			}
		}
	}

	private static List<ClassMetadata> GetChildMetadata(object metadata)
	{
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses((ClassMetadata)metadata);
		childClasses.Insert(0, (ClassMetadata)metadata);
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses((ClassMetadata)metadata);
		childClasses.AddRange(baseClasses);
		return childClasses;
	}

	internal static bool deJ26XG6MAkq2hXL6dQa()
	{
		return DOM0oqG6yNSigv2j4stt == null;
	}

	internal static NHQueryExtensions G1yGslG6J2HKYYBg31ZR()
	{
		return DOM0oqG6yNSigv2j4stt;
	}

	internal static object pWnsh2G69Qj1ebgwFhaR(object P_0, object P_1, object P_2)
	{
		return Sql((SqlString)P_0, (object[])P_1, (IType[])P_2);
	}

	internal static object IXWhu1G6dE4BEZwYalsf(object P_0, object P_1, object P_2)
	{
		return Sql((string)P_0, (object[])P_1, (IType[])P_2);
	}

	internal static bool LQ41AWG6lViUjC4k8CHB(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object U1f6FgG6r4S6dhxM9Prd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qKx8cWG6g54BmXDgLpPJ(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static bool rCn7nOG65RgJ0qdFVdxE()
	{
		return Locator.Initialized;
	}

	internal static DateTime eUrvZNG6jcn2KiLyU46x()
	{
		return DateTime.Now;
	}

	internal static bool UQR7NUG6YqwRbTH1hMtm(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static object LoJCUSG6LdBC9ocyUMvL(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void qa6ZZZG6U1u3esJ9tRFB(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static object db9iKxG6sFuQ4BYCpCkF()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid aiOUYYG6cAAokS1pyZFW(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool m6Oe6IG6zEO1PlN70OWX(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object DhuB8FGHFSkm2Une0y4i(Type type)
	{
		return NHibernateHelper.GetCriteriaTypeUidPropertyName(type);
	}

	internal static Guid raukyWGHB0cU4bVW6qHV(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object b4Rc3QGHWRQOaVX474iN(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static bool Hu6G57GHoyRqgUXADq4K(object P_0, object P_1, object P_2)
	{
		return ((ITypeDescriptor)P_0).HasRealColumn((EntityMetadata)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static object GQ4glRGHbbOw4sGAFY4B(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object hVTnfrGHhvIRl6cwPVBO(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}
}
