using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Loader;
using NHibernate.Loader.Criteria;
using NHibernate.Persister.Entity;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class PublicClientCacheTokenManager : EntityManager<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, long>
{
	private static readonly string SessionPropName;

	private static readonly string TokenKeyPropName;

	private readonly ITransformationProvider transformationProvider;

	private static PublicClientCacheTokenManager NvdEAvsgwLtrwoqZPBI;

	public new static PublicClientCacheTokenManager Instance => Locator.GetServiceNotNull<PublicClientCacheTokenManager>();

	public PublicClientCacheTokenManager(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eCUbius3A9mg4ZCbZok();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.transformationProvider = transformationProvider;
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
			{
				num = 1;
			}
		}
	}

	public bool SetData(long cacheTokenId, long[] data)
	{
		//Discarded unreachable code: IL_004c, IL_01d0, IL_01df, IL_020b, IL_02cf, IL_030f, IL_031e, IL_033b, IL_037b, IL_038a, IL_0396, IL_03a5
		int num = 2;
		int num2 = num;
		IStatelessSession val = default(IStatelessSession);
		string text = default(string);
		int num5 = default(int);
		string text2 = default(string);
		long num7 = default(long);
		long[] array = default(long[]);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					ITransaction val2 = (ITransaction)XtB4ALsz8WOCOQ2AtOW(val);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							((IQuery)WYMjACYkd1k7YpjDl2H(val, text)).SetParameter<long>((string)ibYj9Ysb70gG5mTpOAb(0x38328F00 ^ 0x38323434), cacheTokenId).ExecuteUpdate(cleanUpCache: false);
							int num4 = 2;
							while (true)
							{
								switch (num4)
								{
								case 5:
									num5++;
									num4 = 7;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
									{
										num4 = 9;
									}
									break;
								case 3:
								{
									num5 = 0;
									int num6 = 4;
									num4 = num6;
									break;
								}
								case 8:
									val2.Commit();
									num4 = 7;
									break;
								case 6:
									BidljHYpUGG9kVtpUyb(((IQuery)val.CreateSQLQuery(text2)).SetParameter<long>((string)ibYj9Ysb70gG5mTpOAb(0xAEB118D ^ 0xAEBAAB9), cacheTokenId).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x432996D0 ^ 0x43292D96), num7), false);
									num4 = 5;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
									{
										num4 = 5;
									}
									break;
								default:
									num7 = array[num5];
									num4 = 6;
									break;
								case 2:
									array = data;
									num4 = 3;
									break;
								case 7:
									result = true;
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
									{
										num4 = 1;
									}
									break;
								case 4:
								case 9:
									if (num5 >= array.Length)
									{
										num4 = 8;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
										{
											num4 = 7;
										}
										break;
									}
									goto default;
								case 1:
									return result;
								}
							}
						}
						catch (Exception exception)
						{
							int num8 = 2;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
							{
								num8 = 3;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									val2.Rollback();
									num8 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
									{
										num8 = 1;
									}
									break;
								case 2:
									((ILogger)QfmvUxY5b1yW41AuNxV(this)).Error(AXtT5xYAcT0PE9QT7YW(ibYj9Ysb70gG5mTpOAb(0x65F93013 ^ 0x65F98B49)), exception);
									num8 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
									{
										num8 = 0;
									}
									break;
								case 3:
									result = false;
									num8 = 2;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
									{
										num8 = 2;
									}
									break;
								case 1:
									return result;
								}
							}
						}
						finally
						{
							int num9;
							if (val2 == null)
							{
								num9 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
								{
									num9 = 0;
								}
								goto IL_02d3;
							}
							goto IL_02e9;
							IL_02e9:
							((IDisposable)val2).Dispose();
							num9 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
							{
								num9 = 1;
							}
							goto IL_02d3;
							IL_02d3:
							switch (num9)
							{
							default:
								goto end_IL_02ae;
							case 2:
								break;
							case 0:
								goto end_IL_02ae;
							case 1:
								goto end_IL_02ae;
							}
							goto IL_02e9;
							end_IL_02ae:;
						}
					}
				}
				finally
				{
					int num10;
					if (val == null)
					{
						num10 = 2;
						goto IL_033f;
					}
					goto IL_0355;
					IL_033f:
					switch (num10)
					{
					default:
						goto end_IL_032a;
					case 1:
						break;
					case 2:
						goto end_IL_032a;
					case 0:
						goto end_IL_032a;
					}
					goto IL_0355;
					IL_0355:
					DJIb3VYWabM6cimlDX6(val);
					num10 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
					{
						num10 = 0;
					}
					goto IL_033f;
					end_IL_032a:;
				}
			default:
				return result;
			case 2:
			{
				object obj = bBAueosy0IJEsckx4tf(Locator.GetServiceNotNull<SessionFactoryHolder>());
				text = (string)sEs7RhsfP5e7jwfaru6(ibYj9Ysb70gG5mTpOAb(-2037738356 ^ -2037764446), D6T9bxs9PBOLgoWOA56(gquXOtsS4NLGsTNVrAu(transformationProvider), ibYj9Ysb70gG5mTpOAb(-1712587919 ^ -1712635637)), D6T9bxs9PBOLgoWOA56(gquXOtsS4NLGsTNVrAu(transformationProvider), ibYj9Ysb70gG5mTpOAb(0x71BC7C31 ^ 0x71BCC6AD)));
				text2 = string.Format((string)ibYj9Ysb70gG5mTpOAb(0x4A799728 ^ 0x4A792D86), D6T9bxs9PBOLgoWOA56(gquXOtsS4NLGsTNVrAu(transformationProvider), ibYj9Ysb70gG5mTpOAb(0x3E79A885 ^ 0x3E7912FF)), D6T9bxs9PBOLgoWOA56(gquXOtsS4NLGsTNVrAu(transformationProvider), ibYj9Ysb70gG5mTpOAb(0x432996D0 ^ 0x43292C4C)), D6T9bxs9PBOLgoWOA56(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6AA79E0 ^ 0x6AAC2C0)));
				val = (IStatelessSession)aHDCh7s140e8kiO3dIG(obj);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	public bool UpdateData(long cacheTokenId, long[] updated, long[] deleted)
	{
		//Discarded unreachable code: IL_0173, IL_01f6, IL_0205, IL_022a, IL_0239, IL_03c2, IL_03ed, IL_048b, IL_04e4, IL_051c, IL_052b
		int num = 2;
		int num2 = num;
		string text = default(string);
		string text2 = default(string);
		IStatelessSession val = default(IStatelessSession);
		long num8 = default(long);
		int num5 = default(int);
		long num6 = default(long);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				ISessionFactory sessionFactory = Locator.GetServiceNotNull<SessionFactoryHolder>().SessionFactory;
				text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--561310391 ^ 0x2174513D), D6T9bxs9PBOLgoWOA56(transformationProvider.Dialect, ibYj9Ysb70gG5mTpOAb(-1027693337 ^ -1027727715)), ((Dialect)gquXOtsS4NLGsTNVrAu(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-219609047 ^ -219565387)), D6T9bxs9PBOLgoWOA56(gquXOtsS4NLGsTNVrAu(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816887841 ^ -816841473)));
				text2 = string.Format((string)ibYj9Ysb70gG5mTpOAb(0x7A093321 ^ 0x7A09898F), D6T9bxs9PBOLgoWOA56(transformationProvider.Dialect, ibYj9Ysb70gG5mTpOAb(0xA4E904F ^ 0xA4E2A35)), D6T9bxs9PBOLgoWOA56(gquXOtsS4NLGsTNVrAu(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-192929954 ^ -192895550)), D6T9bxs9PBOLgoWOA56(gquXOtsS4NLGsTNVrAu(transformationProvider), ibYj9Ysb70gG5mTpOAb(-179348817 ^ -179314289)));
				val = (IStatelessSession)aHDCh7s140e8kiO3dIG(sessionFactory);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 1:
				try
				{
					ITransaction val2 = val.BeginTransaction();
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							long[] array = updated.Union(deleted).ToArray();
							int num4 = 7;
							while (true)
							{
								int num7;
								switch (num4)
								{
								case 12:
									num8 = array[num5];
									num7 = 13;
									goto IL_019f;
								case 3:
									SQvhKGYXZvqW4FcW1yq(val2);
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
									{
										num4 = 0;
									}
									break;
								case 4:
								case 11:
									if (num5 < array.Length)
									{
										num4 = 8;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
										{
											num4 = 2;
										}
										break;
									}
									goto case 2;
								case 13:
									BidljHYpUGG9kVtpUyb(((IQuery)WYMjACYkd1k7YpjDl2H(val, text2)).SetParameter<long>((string)ibYj9Ysb70gG5mTpOAb(--561310391 ^ 0x21745183), cacheTokenId).SetParameter<long>((string)ibYj9Ysb70gG5mTpOAb(0x2E78F5A0 ^ 0x2E784EE6), num8), false);
									num4 = 6;
									break;
								case 7:
									num5 = 0;
									num4 = 11;
									break;
								case 16:
									num5++;
									num7 = 4;
									goto IL_019f;
								case 9:
								case 15:
									if (num5 >= array.Length)
									{
										num4 = 3;
										break;
									}
									goto case 12;
								case 6:
									num5++;
									num4 = 15;
									break;
								case 14:
									BidljHYpUGG9kVtpUyb(((IQuery)WYMjACYkd1k7YpjDl2H(val, text)).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1618182 ^ 0x1613AB6), cacheTokenId).SetParameter<long>((string)ibYj9Ysb70gG5mTpOAb(0x2CFDCC80 ^ 0x2CFD77C6), num6), false);
									num7 = 16;
									goto IL_019f;
								case 5:
									num5 = 0;
									num4 = 9;
									break;
								case 1:
								case 8:
									num6 = array[num5];
									num4 = 14;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
									{
										num4 = 10;
									}
									break;
								default:
									result = true;
									num4 = 10;
									break;
								case 2:
									array = updated;
									num4 = 5;
									break;
								case 10:
									{
										return result;
									}
									IL_019f:
									num4 = num7;
									break;
								}
							}
						}
						catch (Exception ex)
						{
							int num9 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
							{
								num9 = 1;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									uBLmgXYifNXiLev2Npq(val2);
									num9 = 3;
									break;
								case 2:
									rVyS6GYne2LAjuUHqj0(QfmvUxY5b1yW41AuNxV(this), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x22A54A05 ^ 0x22A5F15F)), ex);
									num9 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
									{
										num9 = 0;
									}
									break;
								case 1:
									result = false;
									num9 = 2;
									break;
								case 3:
									return result;
								}
							}
						}
						finally
						{
							if (val2 != null)
							{
								int num10 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
								{
									num10 = 0;
								}
								while (true)
								{
									switch (num10)
									{
									case 1:
										((IDisposable)val2).Dispose();
										num10 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
										{
											num10 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
					}
				}
				finally
				{
					if (val != null)
					{
						int num11 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
						{
							num11 = 1;
						}
						while (true)
						{
							switch (num11)
							{
							case 1:
								DJIb3VYWabM6cimlDX6(val);
								num11 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
								{
									num11 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			default:
				return result;
			}
		}
	}

	public long CountDeleted(Guid objectTypeUid, DateTime? from, string eqlQuery, DetachedCriteria subCriteria)
	{
		if (string.IsNullOrWhiteSpace(eqlQuery) || subCriteria == null)
		{
			return 0L;
		}
		long contextCacheId = GetContextCacheId(objectTypeUid, eqlQuery);
		if (contextCacheId == 0L)
		{
			return 0L;
		}
		return Convert.ToInt64(GetDeletedSqlQuery(objectTypeUid, subCriteria, contextCacheId, isCount: false).UniqueResult());
	}

	public IEnumerable<IEntityModelHistoryItem> FindDeleted(Guid objectTypeUid, DateTime? from, string eqlQuery, DetachedCriteria subCriteria)
	{
		if (string.IsNullOrWhiteSpace(eqlQuery) || subCriteria == null)
		{
			return new IEntityModelHistoryItem[0];
		}
		long contextCacheId = GetContextCacheId(objectTypeUid, eqlQuery);
		if (contextCacheId == 0L)
		{
			return new IEntityModelHistoryItem[0];
		}
		IList list = GetDeletedSqlQuery(objectTypeUid, subCriteria, contextCacheId, isCount: false).List();
		List<IEntityModelHistoryItem> list2 = new List<IEntityModelHistoryItem>();
		foreach (object item in list)
		{
			list2.Add(new EntityModelHistoryItem
			{
				ObjectId = Convert.ToInt64(item),
				ActionTypeUid = DefaultEntityActions.DeleteGuid,
				ObjectTypeUid = objectTypeUid,
				CreationDate = DateTime.Now
			});
		}
		return list2;
	}

	[Transaction]
	public virtual long DeleteExpired(DateTime expireDateTime)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (jiO26xY73afI2K5qj18(base.SecurityService, PermissionProvider.APIAdminPermission))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return 0L;
			default:
				return base.Session.Delete(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD03F60), GetFetchType(null).FullName), (object)expireDateTime, (IType)(object)NHibernateUtil.DateTime);
			}
		}
	}

	public bool Promote(Guid tokenKey, EleWise.ELMA.Security.Models.API.IPublicClientSession storedSession)
	{
		int num = 3;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicClientCacheToken publicClientCacheToken = default(EleWise.ELMA.Security.Models.API.IPublicClientCacheToken);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (publicClientCacheToken == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
					{
						num2 = 0;
					}
					break;
				}
				publicClientCacheToken.LastAccess = pj66QrY6IQbdtf4AlcI();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				publicClientCacheToken = FindByTokenSession(tokenKey, storedSession);
				num2 = 2;
				break;
			case 4:
				return true;
			case 1:
				return false;
			default:
				Save(publicClientCacheToken);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private static long GetContextCacheId(Guid objectTypeUid, object eqlQuery)
	{
		//Discarded unreachable code: IL_00b8, IL_00f6, IL_0105, IL_013d, IL_014c, IL_019c, IL_01b3, IL_01c2
		switch (1)
		{
		case 1:
			try
			{
				EleWise.ELMA.API.Models.IPublicClientSession orDefault = ContextVars.GetOrDefault<EleWise.ELMA.API.Models.IPublicClientSession>((string)ibYj9Ysb70gG5mTpOAb(-426925384 ^ -426959228));
				int num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
				{
					num = 1;
				}
				long result = default(long);
				IPublicCacheService serviceNotNull = default(IPublicCacheService);
				EleWise.ELMA.API.Models.IPublicClientCacheToken cacheToken = default(EleWise.ELMA.API.Models.IPublicClientCacheToken);
				while (true)
				{
					switch (num)
					{
					case 5:
						return result;
					case 7:
						return result;
					case 8:
						return result;
					case 1:
						if (orDefault != null)
						{
							num = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 9;
					case 9:
						result = 0L;
						num = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
						{
							num = 6;
						}
						continue;
					default:
						serviceNotNull = Locator.GetServiceNotNull<IPublicCacheService>();
						num = 3;
						continue;
					case 3:
						if (serviceNotNull.IsCacheValid(qapmdcYlvWEXK2lVpY8(orDefault), (string)bBVcfeYNQBHOs5UL1Ck(serviceNotNull, objectTypeUid, eqlQuery), out cacheToken))
						{
							num = 6;
							continue;
						}
						break;
					case 6:
					{
						result = Lw4d5rYZ2bZyAFKICUr(cacheToken);
						int num2 = 5;
						num = num2;
						continue;
					}
					case 2:
						break;
					}
					result = 0L;
					num = 8;
				}
			}
			catch (VariableNotFoundException)
			{
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
			}
			break;
		}
		return 0L;
	}

	private IQuery GetDeletedSqlQuery(Guid objectTypeUid, DetachedCriteria subCriteria, long tokenId, bool isCount)
	{
		//Discarded unreachable code: IL_00dc, IL_014e, IL_015d, IL_016e, IL_017d, IL_0188, IL_0256, IL_028e, IL_029d, IL_02d3, IL_02e2, IL_035a, IL_03c0, IL_0502
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		int num = 7;
		CriteriaImpl criteriaImpl = default(CriteriaImpl);
		TypedValue val3 = default(TypedValue);
		QueryParameters val2 = default(QueryParameters);
		int num4 = default(int);
		int num3 = default(int);
		CriteriaQueryTranslator val5 = default(CriteriaQueryTranslator);
		ISessionFactoryImplementor val6 = default(ISessionFactoryImplementor);
		ISQLQuery val4 = default(ISQLQuery);
		IEnumerator<KeyValuePair<string, TypedValue>> enumerator = default(IEnumerator<KeyValuePair<string, TypedValue>>);
		KeyValuePair<string, TypedValue> current = default(KeyValuePair<string, TypedValue>);
		object obj = default(object);
		SqlString val = default(SqlString);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					criteriaImpl = GetCriteriaImpl(subCriteria);
					num2 = 4;
					continue;
				case 18:
					val3 = val2.get_NamedParameters()[(string)QOtMQjYPYObTpBicMJj(ibYj9Ysb70gG5mTpOAb(-930147978 ^ -930108294), num4)];
					num2 = 11;
					continue;
				case 26:
					num3++;
					num2 = 16;
					continue;
				case 4:
					val5 = new CriteriaQueryTranslator(val6, criteriaImpl, (string)UJTbgxYBbFMsRtsVYlw(subCriteria), (string)pDwgPSYucJnYQ0jkbXO(subCriteria));
					num2 = 14;
					continue;
				case 11:
					rJckbVYCJ7VuvcutbFg(val4, num4, z3TPJeYvbh7J7HVdFF1(val3), val3.get_Type());
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
					{
						num2 = 3;
					}
					continue;
				case 27:
					try
					{
						while (true)
						{
							IL_020a:
							int num5;
							if (!SflvI2YKYhcEweHMpH8(enumerator))
							{
								num5 = 3;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
								{
									num5 = 1;
								}
								goto IL_018c;
							}
							goto IL_01e7;
							IL_01e7:
							current = enumerator.Current;
							num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
							{
								num5 = 0;
							}
							goto IL_018c;
							IL_018c:
							while (true)
							{
								switch (num5)
								{
								default:
									E1cLYnYJ9LsmMU6ySAL(val4, current.Key, z3TPJeYvbh7J7HVdFF1(current.Value), TyTMvGYooXTXCd6Sn3s(current.Value));
									num5 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
									{
										num5 = 1;
									}
									continue;
								case 2:
									break;
								case 1:
									goto IL_020a;
								case 3:
									goto end_IL_020a;
								}
								break;
							}
							goto IL_01e7;
							continue;
							end_IL_020a:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									enumerator.Dispose();
									num6 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
									{
										num6 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 2:
				case 15:
					if (xFYIfaYtdiZDiLlMOjX(val2) == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 17;
				case 5:
				case 25:
					if (num4 >= EhxrWBYUaKYyQDCSLcm(val2.get_NamedParameters()))
					{
						num2 = 15;
						continue;
					}
					goto case 18;
				case 9:
				case 16:
					if (num3 < ((Array)xFYIfaYtdiZDiLlMOjX(val2)).Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				default:
					return (IQuery)LukvIqYO2cnUbbxJEYr(val4, false);
				case 7:
					obj = tAGyVwYxsUue0BgOZdc(ModelHelper.GetEntityType(objectTypeUid));
					num2 = 6;
					continue;
				case 1:
				case 23:
					rJckbVYCJ7VuvcutbFg(val4, num3, ((object[])xFYIfaYtdiZDiLlMOjX(val2))[num3], ((object[])K0tsK4Yholr4MoOk4R5(val2))[num3]);
					num = 26;
					break;
				case 6:
					val6 = (ISessionFactoryImplementor)bBAueosy0IJEsckx4tf(Locator.GetServiceNotNull<SessionFactoryHolder>());
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
					{
						num2 = 19;
					}
					continue;
				case 17:
					num3 = 0;
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					num4 = 0;
					num2 = 25;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
					{
						num2 = 3;
					}
					continue;
				case 14:
					val = (SqlString)Bd2mCxYj0WuwpOTre6v((object)new CriteriaJoinWalker((IOuterJoinLoadable)R5IG3nYL3nhNtZ3UIbj(tWk0hCYeOCBrNsJ49Hr(OWODLfYmcy5pmiAP34k(this)), subCriteria.get_EntityOrClassName(), obj), val5, val6, (ICriteria)(object)val5.get_RootCriteria(), (string)UJTbgxYBbFMsRtsVYlw(subCriteria), ((ISessionImplementor)tWk0hCYeOCBrNsJ49Hr(OWODLfYmcy5pmiAP34k(this))).get_EnabledFilters()));
					num2 = 20;
					continue;
				case 22:
					val2 = (QueryParameters)V4xyVGYwqkT4BjoUSAd(val5);
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
					{
						num2 = 24;
					}
					continue;
				case 12:
					if (((Array)uovBQXY2p849LiKbI9j(val4)).Length != 0)
					{
						num = 10;
						break;
					}
					goto case 13;
				case 3:
					num4++;
					num2 = 5;
					continue;
				case 10:
				case 21:
					enumerator = val2.get_NamedParameters().GetEnumerator();
					num2 = 27;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
					{
						num2 = 14;
					}
					continue;
				case 28:
					val4 = (ISQLQuery)RHM02AYR2bhJSOpeeME(OWODLfYmcy5pmiAP34k(this), text);
					num2 = 22;
					continue;
				case 24:
					if (val2.get_NamedParameters() != null)
					{
						num2 = 12;
						continue;
					}
					goto case 2;
				case 20:
					text = (string)J6cKdZYa3OB9paT0SK0(ibYj9Ysb70gG5mTpOAb(-434542700 ^ -434513124), new object[5]
					{
						w2fNrgYH6q3OQY0gneW(isCount ? ibYj9Ysb70gG5mTpOAb(-1615559191 ^ -1615578859) : "", ((Dialect)gquXOtsS4NLGsTNVrAu(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CD4C8A0 ^ 0x4CD47380)), isCount ? ibYj9Ysb70gG5mTpOAb(-95913524 ^ -95879498) : ""),
						D6T9bxs9PBOLgoWOA56(gquXOtsS4NLGsTNVrAu(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-905821499 ^ -905774913)),
						D6T9bxs9PBOLgoWOA56(transformationProvider.Dialect, ibYj9Ysb70gG5mTpOAb(0x2121ECF9 ^ 0x21215665)),
						tokenId,
						val
					});
					num2 = 28;
					continue;
				}
				break;
			}
		}
	}

	private CriteriaImpl GetCriteriaImpl(DetachedCriteria subCriteria)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (CriteriaImpl)M3cQ19YqAmoeCWrvvxi(subCriteria, OWODLfYmcy5pmiAP34k(this));
	}

	public EleWise.ELMA.Security.Models.API.IPublicClientCacheToken FindByTokenSession(Guid tokenKey, EleWise.ELMA.Security.Models.API.IPublicClientSession session)
	{
		//Discarded unreachable code: IL_0051
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				if (session == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
					{
						num2 = 0;
					}
					break;
				}
				object obj = evVcf7YG11p3thjbJ5p(this, new FetchOptions(0, 1), GetFetchType(null), null, null);
				((ICriteria)obj).Add((ICriterion)Yjwe6gYFMvV1pqRyrje(TokenKeyPropName, tokenKey));
				((ICriteria)obj).Add((ICriterion)Yjwe6gYFMvV1pqRyrje(SessionPropName, session));
				return ((ICriteria)obj).UniqueResult<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken>();
			}
			default:
				return null;
			case 2:
				if (D43VPTYcMBtXNJntjrK(tokenKey, Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	static PublicClientCacheTokenManager()
	{
		int num = 2;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				TokenKeyPropName = LinqUtils.NameOf(Expression.Lambda<Func<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, object>>((Expression)VRwfKcYs28j4f1oD9d2(fl6UqNYDHlU16rwHtJe(parameterExpression, (MethodInfo)gNdfbSYEmHuYG0bIC2j((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Ge9vWAYMCoe2iv0sv8b(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				SessionPropName = LinqUtils.NameOf(Expression.Lambda<Func<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, object>>((Expression)fl6UqNYDHlU16rwHtJe(parameterExpression, (MethodInfo)gNdfbSYEmHuYG0bIC2j((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				parameterExpression = (ParameterExpression)Q43MHUY0NircZZhtsfY(Ge9vWAYMCoe2iv0sv8b(typeof(EleWise.ELMA.Security.Models.API.IPublicClientCacheToken).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37FE8EDE ^ 0x37FEA56C));
				num2 = 5;
				break;
			case 1:
				parameterExpression = (ParameterExpression)Q43MHUY0NircZZhtsfY(typeof(EleWise.ELMA.Security.Models.API.IPublicClientCacheToken), ibYj9Ysb70gG5mTpOAb(0x432996D0 ^ 0x4329BD62));
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 2:
				eCUbius3A9mg4ZCbZok();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void eCUbius3A9mg4ZCbZok()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool CHXawas8nCA17w3dUbk()
	{
		return NvdEAvsgwLtrwoqZPBI == null;
	}

	internal static PublicClientCacheTokenManager PiuyS3srqa4y6RHPhUD()
	{
		return NvdEAvsgwLtrwoqZPBI;
	}

	internal static object bBAueosy0IJEsckx4tf(object P_0)
	{
		return ((SessionFactoryHolder)P_0).SessionFactory;
	}

	internal static object ibYj9Ysb70gG5mTpOAb(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object gquXOtsS4NLGsTNVrAu(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object D6T9bxs9PBOLgoWOA56(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object sEs7RhsfP5e7jwfaru6(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object aHDCh7s140e8kiO3dIG(object P_0)
	{
		return ((ISessionFactory)P_0).OpenStatelessSession();
	}

	internal static object XtB4ALsz8WOCOQ2AtOW(object P_0)
	{
		return ((IStatelessSession)P_0).BeginTransaction();
	}

	internal static object WYMjACYkd1k7YpjDl2H(object P_0, object P_1)
	{
		return ((IStatelessSession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static int BidljHYpUGG9kVtpUyb(object P_0, bool P_1)
	{
		return ((IQuery)P_0).ExecuteUpdate(P_1);
	}

	internal static object QfmvUxY5b1yW41AuNxV(object P_0)
	{
		return ((EntityManager<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, long>)P_0).Logger;
	}

	internal static object AXtT5xYAcT0PE9QT7YW(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void DJIb3VYWabM6cimlDX6(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void SQvhKGYXZvqW4FcW1yq(object P_0)
	{
		((ITransaction)P_0).Commit();
	}

	internal static void rVyS6GYne2LAjuUHqj0(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void uBLmgXYifNXiLev2Npq(object P_0)
	{
		((ITransaction)P_0).Rollback();
	}

	internal static bool jiO26xY73afI2K5qj18(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}

	internal static DateTime pj66QrY6IQbdtf4AlcI()
	{
		return DateTime.Now;
	}

	internal static Guid qapmdcYlvWEXK2lVpY8(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicClientSession)P_0).AuthToken;
	}

	internal static object bBVcfeYNQBHOs5UL1Ck(object P_0, Guid P_1, object P_2)
	{
		return ((IPublicCacheService)P_0).GetTokenValue(P_1, (string)P_2);
	}

	internal static long Lw4d5rYZ2bZyAFKICUr(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicClientCacheToken)P_0).Id;
	}

	internal static object tAGyVwYxsUue0BgOZdc(Type P_0)
	{
		return InterfaceActivator.Create(P_0);
	}

	internal static object UJTbgxYBbFMsRtsVYlw(object P_0)
	{
		return ((DetachedCriteria)P_0).get_EntityOrClassName();
	}

	internal static object pDwgPSYucJnYQ0jkbXO(object P_0)
	{
		return ((DetachedCriteria)P_0).get_Alias();
	}

	internal static object OWODLfYmcy5pmiAP34k(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object tWk0hCYeOCBrNsJ49Hr(object P_0)
	{
		return ((ISession)P_0).GetSessionImplementation();
	}

	internal static object R5IG3nYL3nhNtZ3UIbj(object P_0, object P_1, object P_2)
	{
		return ((ISessionImplementor)P_0).GetEntityPersister((string)P_1, P_2);
	}

	internal static object Bd2mCxYj0WuwpOTre6v(object P_0)
	{
		return ((JoinWalker)P_0).get_SqlString();
	}

	internal static object w2fNrgYH6q3OQY0gneW(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object J6cKdZYa3OB9paT0SK0(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object RHM02AYR2bhJSOpeeME(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object V4xyVGYwqkT4BjoUSAd(object P_0)
	{
		return ((CriteriaQueryTranslator)P_0).GetQueryParameters();
	}

	internal static object uovBQXY2p849LiKbI9j(object P_0)
	{
		return ((IQuery)P_0).get_NamedParameters();
	}

	internal static object QOtMQjYPYObTpBicMJj(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object z3TPJeYvbh7J7HVdFF1(object P_0)
	{
		return ((TypedValue)P_0).get_Value();
	}

	internal static object rJckbVYCJ7VuvcutbFg(object P_0, int P_1, object P_2, object P_3)
	{
		return ((IQuery)P_0).SetParameter(P_1, P_2, (IType)P_3);
	}

	internal static int EhxrWBYUaKYyQDCSLcm(object P_0)
	{
		return ((ICollection<KeyValuePair<string, TypedValue>>)P_0).Count;
	}

	internal static object TyTMvGYooXTXCd6Sn3s(object P_0)
	{
		return ((TypedValue)P_0).get_Type();
	}

	internal static object E1cLYnYJ9LsmMU6ySAL(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IQuery)P_0).SetParameter((string)P_1, P_2, (IType)P_3);
	}

	internal static bool SflvI2YKYhcEweHMpH8(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object xFYIfaYtdiZDiLlMOjX(object P_0)
	{
		return ((QueryParameters)P_0).get_PositionalParameterValues();
	}

	internal static object K0tsK4Yholr4MoOk4R5(object P_0)
	{
		return ((QueryParameters)P_0).get_PositionalParameterTypes();
	}

	internal static object LukvIqYO2cnUbbxJEYr(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static object M3cQ19YqAmoeCWrvvxi(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).GetExecutableCriteria((ISession)P_1);
	}

	internal static bool D43VPTYcMBtXNJntjrK(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object evVcf7YG11p3thjbJ5p(object P_0, object P_1, Type P_2, object P_3, object P_4)
	{
		return ((EntityManager<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, long>)P_0).CreateCriteria((FetchOptions)P_1, P_2, (string)P_3, (IEntityFilter)P_4);
	}

	internal static object Yjwe6gYFMvV1pqRyrje(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object Q43MHUY0NircZZhtsfY(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object gNdfbSYEmHuYG0bIC2j(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object fl6UqNYDHlU16rwHtJe(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type Ge9vWAYMCoe2iv0sv8b(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object VRwfKcYs28j4f1oD9d2(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}
}
