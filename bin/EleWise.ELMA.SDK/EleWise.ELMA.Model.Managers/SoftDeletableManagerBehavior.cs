using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

[Component(Order = 8)]
public class SoftDeletableManagerBehavior : EntityManagerBehavior
{
	private ConcurrentDictionary<Type, bool> cacheInstanceSettings;

	internal static SoftDeletableManagerBehavior tBLDbnhGJxi6RJcN4l0F;

	public RunWithSoftDeletableService RunWithSoftDeletableService
	{
		[CompilerGenerated]
		get
		{
			return _003CRunWithSoftDeletableService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CRunWithSoftDeletableService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void OnLoad(object target)
	{
		//Discarded unreachable code: IL_0079, IL_0088, IL_00f6, IL_0128, IL_0137, IL_0147, IL_0156, IL_02c5
		int num = 16;
		object obj = default(object);
		IEntity entity = default(IEntity);
		ISoftDeletable softDeletable = default(ISoftDeletable);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		IInstanceSettingsPermission instanceSettingsPermission = default(IInstanceSettingsPermission);
		bool value = default(bool);
		IMetadata metadata = default(IMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 10:
					obj = wO6wY0hGr2hqUi9qU7sf(entity);
					num = 19;
					break;
				case 8:
					if (!AAKfBfhGgcw0FB0JBOyC(softDeletable))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 14:
					return;
				case 11:
					if (target != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					return;
				case 19:
					softDeletable = entity as ISoftDeletable;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 13;
					}
					continue;
				case 16:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 15;
					continue;
				case 13:
					if (softDeletable == null)
					{
						num2 = 3;
						continue;
					}
					goto case 8;
				case 7:
					cacheInstanceSettings.TryAdd(_003C_003Ec__DisplayClass5_.type, instanceSettingsPermission != null);
					num = 17;
					break;
				case 5:
					value = instanceSettingsPermission != null;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					instanceSettingsPermission = ((ComponentManager)HxQCo6hG5Zk8NcUgftvI()).GetExtensionPoints<IInstanceSettingsPermission>(useCache: false).FirstOrDefault(_003C_003Ec__DisplayClass5_._003COnLoad_003Eb__0);
					num2 = 5;
					continue;
				case 21:
					return;
				case 18:
					if (entity != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 4:
					if (!cacheInstanceSettings.TryGetValue(_003C_003Ec__DisplayClass5_.type, out value))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 17;
				case 6:
					return;
				case 9:
					entity = (target as IEntity).CastAsRealType();
					num2 = 18;
					continue;
				case 15:
					if (RunWithSoftDeletableService.Turned)
					{
						return;
					}
					num2 = 11;
					continue;
				case 20:
					return;
				case 2:
					_003C_003Ec__DisplayClass5_.type = Fu31DchGl2BFkAG7S3Fo(target);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 10;
					}
					continue;
				case 3:
					return;
				case 17:
					if (value)
					{
						metadata = MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass5_.type, inherit: false, loadImplementation: false);
						num = 12;
						break;
					}
					num2 = 21;
					continue;
				case 12:
				{
					ObjectIsDeletedException ex = new ObjectIsDeletedException(SR.T((string)hd2RX9hGjAFp7kQemDMM(0x57A5235E ^ 0x57A605F4), entity.ToString(), obj));
					yG49ashGYgMY6xHlGHLP(ex, obj);
					ckKrvRhGUv1RlscCbckp(ex, (metadata != null) ? BeGr8thGLN9OI83gcAPO(metadata) : Guid.Empty);
					throw ex;
				}
				}
				break;
			}
		}
	}

	public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0095, IL_00a4, IL_012a, IL_01b6, IL_01c5, IL_0271, IL_02a4, IL_02ec, IL_02fb
		//IL_028a: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		ITransformationProvider service = default(ITransformationProvider);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 13:
				return;
			case 3:
				if (!G0VFDEhGsp3kaptSPeuA(RunWithSoftDeletableService))
				{
					num2 = 2;
					break;
				}
				return;
			case 5:
				mlqDGWhEGlhEIbNLJDDN(criteria, Restrictions.EqProperty(Projections.SqlFunction((string)LTNECahEosRNTUFmKobM(service.Dialect), (IType)(object)NHibernateUtil.Boolean, (IProjection[])(object)new IProjection[2]
				{
					(IProjection)rwbKdehEbepLyl9VDT9Q(hd2RX9hGjAFp7kQemDMM(--1360331293 ^ 0x51174AF7)),
					(IProjection)svYXjNhEhExaHabZYriu(0)
				}), Projections.Constant((object)0)));
				num2 = 10;
				break;
			case 7:
				return;
			case 1:
				service = Locator.GetService<ITransformationProvider>();
				num2 = 9;
				break;
			case 10:
				return;
			case 8:
				mlqDGWhEGlhEIbNLJDDN(criteria, UkTX2FhECG1Xujy3PypQ(pepbixhEEQkNI0dLx2Tt(hd2RX9hGjAFp7kQemDMM(-1886646897 ^ -1886501531)), TJif9whEQOp7EXKBkRLm(jEToSxhEfCwNH0vuPyJm(hd2RX9hGjAFp7kQemDMM(-2099751081 ^ -2099634243), true))));
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				if (service == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 5;
			case 4:
				return;
			case 2:
				type = null;
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 9;
				}
				break;
			default:
				if (wfFlAShEWwmbyicwU9mb(filter))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				if (!U8OZFChEBLGMsxYiLDOp(type.GetInterface(typeof(ISoftDeletable).FullName), null))
				{
					if (filter != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 6;
				}
				break;
			case 11:
				try
				{
					type = criteria.GetRootEntityTypeIfAvailable();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (HibernateException val)
				{
					HibernateException val2 = val;
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							MVOt3nhEFwaPCdqXBFCN(E3mlIZhGckZBnSKP64Zf(), epgRmPhGzMqOSHKbbx1U(val2), val2);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}
				goto case 12;
			}
		}
	}

	public SoftDeletableManagerBehavior()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		aCZ1AChEvEDfC5u08ShL();
		cacheInstanceSettings = new ConcurrentDictionary<Type, bool>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool o3J1nqhG9yn7ATvGmmvi()
	{
		return tBLDbnhGJxi6RJcN4l0F == null;
	}

	internal static SoftDeletableManagerBehavior v47WEohGdLWR0UcZGnEH()
	{
		return tBLDbnhGJxi6RJcN4l0F;
	}

	internal static Type Fu31DchGl2BFkAG7S3Fo(object P_0)
	{
		return EntityHelper.GetType(P_0);
	}

	internal static object wO6wY0hGr2hqUi9qU7sf(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static bool AAKfBfhGgcw0FB0JBOyC(object P_0)
	{
		return ((ISoftDeletable)P_0).IsDeleted;
	}

	internal static object HxQCo6hG5Zk8NcUgftvI()
	{
		return ComponentManager.Current;
	}

	internal static object hd2RX9hGjAFp7kQemDMM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void yG49ashGYgMY6xHlGHLP(object P_0, object P_1)
	{
		((ObjectIsDeletedException)P_0).ObjectId = P_1;
	}

	internal static Guid BeGr8thGLN9OI83gcAPO(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static void ckKrvRhGUv1RlscCbckp(object P_0, Guid value)
	{
		((ObjectIsDeletedException)P_0).ObjectType = value;
	}

	internal static bool G0VFDEhGsp3kaptSPeuA(object P_0)
	{
		return ((RunWithSoftDeletableService)P_0).Turned;
	}

	internal static object E3mlIZhGckZBnSKP64Zf()
	{
		return Logger.Log;
	}

	internal static object epgRmPhGzMqOSHKbbx1U(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void MVOt3nhEFwaPCdqXBFCN(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool U8OZFChEBLGMsxYiLDOp(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool wfFlAShEWwmbyicwU9mb(object P_0)
	{
		return ((IEntityFilter)P_0).DisableSoftDeletable;
	}

	internal static object LTNECahEosRNTUFmKobM(object P_0)
	{
		return ((Dialect)P_0).GetIsNullFunctionName();
	}

	internal static object rwbKdehEbepLyl9VDT9Q(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object svYXjNhEhExaHabZYriu(object P_0)
	{
		return Projections.Constant(P_0);
	}

	internal static object mlqDGWhEGlhEIbNLJDDN(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object pepbixhEEQkNI0dLx2Tt(object P_0)
	{
		return Restrictions.IsNull((string)P_0);
	}

	internal static object jEToSxhEfCwNH0vuPyJm(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object TJif9whEQOp7EXKBkRLm(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static object UkTX2FhECG1Xujy3PypQ(object P_0, object P_1)
	{
		return Restrictions.Or((ICriterion)P_0, (ICriterion)P_1);
	}

	internal static void aCZ1AChEvEDfC5u08ShL()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
