using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public class UidInitializeAction : ModelAction
{
	private EntityMetadata metadata;

	private EntityPropertyMetadata uidPropertyMetadata;

	private ISession session;

	internal static UidInitializeAction LNis9xohdwbF8JVOsC4W;

	public UidInitializeAction(IDbModelUpdater updater, EntityMetadata metadata, EntityPropertyMetadata uidPropertyMetadata, ISession session)
	{
		//Discarded unreachable code: IL_001b, IL_0020
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(updater);
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				this.uidPropertyMetadata = uidPropertyMetadata;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num = 4;
				}
				break;
			case 2:
				this.metadata = metadata;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num = 0;
				}
				break;
			default:
				FSVgiEoh5WAYQjv45gSS(uidPropertyMetadata, o91EVAohgNLqJbCi4Ka0(--1360331293 ^ 0x511757B3));
				num = 6;
				break;
			case 6:
				FSVgiEoh5WAYQjv45gSS(session, o91EVAohgNLqJbCi4Ka0(0x7C1EE318 ^ 0x7C1EEA28));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num = 2;
				}
				break;
			case 4:
				this.session = session;
				num = 5;
				break;
			case 5:
				return;
			case 3:
				Contract.ArgumentNotNull(metadata, (string)o91EVAohgNLqJbCi4Ka0(-1870892489 ^ -1870906615));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_00ad, IL_00bc, IL_00c7, IL_0171, IL_0180, IL_01ad, IL_01bc
		int num = 1;
		int num2 = num;
		IEnumerator<IEntity> enumerator = default(IEnumerator<IEntity>);
		Type typeByUid = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 3:
				enumerator = ((IEnumerable)sVvFcPohLHf1Ju3j46FK(session.CreateCriteria(typeByUid).Add((ICriterion)(object)Restrictions.Or((ICriterion)Pca8XdohY96vW6kjPBaR(o91EVAohgNLqJbCi4Ka0(-1217523399 ^ -1217495381)), (ICriterion)(object)Restrictions.Eq((string)o91EVAohgNLqJbCi4Ka0(-2106517564 ^ -2106492842), (object)Guid.Empty))))).Cast<IEntity>().GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!veMLVoohs1JWM5yDvOyN(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num3 = 1;
							}
							goto IL_00cb;
						}
						goto IL_00e1;
						IL_00e1:
						IEntity current = enumerator.Current;
						Wl4AvAohUpTfDgQ7XPA8(current, fBxPggohjvGnLtZiygso(uidPropertyMetadata), Guid.NewGuid());
						current.Save();
						num3 = 2;
						goto IL_00cb;
						IL_00cb:
						switch (num3)
						{
						case 1:
							return;
						case 2:
							continue;
						}
						goto IL_00e1;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						int num4 = 2;
						num5 = num4;
						goto IL_0156;
					}
					goto IL_018b;
					IL_0156:
					switch (num5)
					{
					case 2:
						goto end_IL_013d;
					case 1:
						goto end_IL_013d;
					}
					goto IL_018b;
					IL_018b:
					HGXto2ohceKJOOPbRkMx(enumerator);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num5 = 1;
					}
					goto IL_0156;
					end_IL_013d:;
				}
			default:
				typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(fBxPggohjvGnLtZiygso(metadata));
				num2 = 3;
				break;
			case 1:
				base.Execute();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object o91EVAohgNLqJbCi4Ka0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void FSVgiEoh5WAYQjv45gSS(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool U8jUl9ohlaLO5SlBeyiZ()
	{
		return LNis9xohdwbF8JVOsC4W == null;
	}

	internal static UidInitializeAction SSvZBwohrXsMQ6w69ImC()
	{
		return LNis9xohdwbF8JVOsC4W;
	}

	internal static Guid fBxPggohjvGnLtZiygso(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object Pca8XdohY96vW6kjPBaR(object P_0)
	{
		return Restrictions.IsNull((string)P_0);
	}

	internal static object sVvFcPohLHf1Ju3j46FK(object P_0)
	{
		return ((ICriteria)P_0).List();
	}

	internal static void Wl4AvAohUpTfDgQ7XPA8(object P_0, Guid propertyUid, object P_2)
	{
		((IEntity)P_0).SetPropertyValue(propertyUid, P_2);
	}

	internal static bool veMLVoohs1JWM5yDvOyN(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void HGXto2ohceKJOOPbRkMx(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
