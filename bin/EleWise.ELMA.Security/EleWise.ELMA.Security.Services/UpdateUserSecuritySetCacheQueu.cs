using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Actors;
using EleWise.ELMA.Security.Events;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Listeners;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Service]
public class UpdateUserSecuritySetCacheQueueManager
{
	private class UUSSCGroupData
	{
		private static object j8iOiNpuK9STU6XhhqrU;

		public long Id
		{
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
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
					case 1:
						_003CId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public int? AddCount { get; set; }

		public long? UserId { get; set; }

		public long? OrgItemId { get; set; }

		public long? GroupId { get; set; }

		public UUSSCGroupData()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			z3jUPZpuOnbOaHaumXoT();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool bLe6rQput6hSr2ijlmYp()
		{
			return j8iOiNpuK9STU6XhhqrU == null;
		}

		internal static UUSSCGroupData smZGjqpuhp4m8l5WDXPT()
		{
			return (UUSSCGroupData)j8iOiNpuK9STU6XhhqrU;
		}

		internal static void z3jUPZpuOnbOaHaumXoT()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}
	}

	internal const string TableName = "UpdateUSSCQueue";

	internal const string UidColumnName = "Uid";

	internal const string CreationDateColumnName = "CreationDate";

	internal const string DataColumnName = "Data";

	private readonly ITransformationProvider transformationProvider;

	private readonly ILockManager lockManager;

	private readonly ISessionProvider sessionProvider;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly IEnumerable<ISecurityCacheSetIdAction> securityCacheSetIdAction;

	private readonly ISecurityCacheSetIdEventHandler securityCacheSetIdEventHandler;

	private readonly IActorModelRuntime actorModelRuntime;

	private static readonly ILogger Logger;

	internal static UpdateUserSecuritySetCacheQueueManager xSXDF12Ro2FRv5dWjgm;

	private static TimeSpan WaitTimeSpan
	{
		get
		{
			//Discarded unreachable code: IL_002e
			int num = 1;
			int num2 = num;
			int num3;
			int setting = default(int);
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = 0;
					break;
				case 1:
					setting = SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1586242415 ^ -1586265017), 0);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (setting <= 0)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					num3 = setting;
					break;
				}
				break;
			}
			return qKXbx92PZoUtrICVNyY(num3);
		}
	}

	public UpdateUserSecuritySetCacheQueueManager(ITransformationProvider transformationProvider, ILockManager lockManager, ISessionProvider sessionProvider, IUnitOfWorkManager unitOfWorkManager, IEnumerable<ISecurityCacheSetIdAction> securityCacheSetIdAction, ISecurityCacheSetIdEventHandler securityCacheSetIdEventHandler, IActorModelRuntime actorModelRuntime)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.transformationProvider = transformationProvider;
		this.lockManager = lockManager;
		this.sessionProvider = sessionProvider;
		this.unitOfWorkManager = unitOfWorkManager;
		this.securityCacheSetIdAction = securityCacheSetIdAction;
		this.securityCacheSetIdEventHandler = securityCacheSetIdEventHandler;
		this.actorModelRuntime = actorModelRuntime;
	}

	internal void ExecuteFullUpdate(bool needlock = true)
	{
		//Discarded unreachable code: IL_00d5, IL_01e8, IL_026c, IL_02a4, IL_02c0
		int num = 7;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			default:
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				disposable = (IDisposable)ypkejD2CI0CHAI3rD4p(lockManager, YERVJL2vveBTIjoatqh(0x1A9A1A63 ^ 0x1A9A4343));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				try
				{
					Et6sCU2U8IRWbtfXosj(Logger, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x487E82CC ^ 0x487EDBA0));
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							transformationProvider.ExecuteNonQuery(string.Format((string)YERVJL2vveBTIjoatqh(0x6547C338 ^ 0x65479A8E), ((Dialect)JXVCry2oJpQuSbuG2Rc(transformationProvider)).QuoteIfNeeded((string)YERVJL2vveBTIjoatqh(-219609047 ^ -219590159))));
							num3 = 2;
							continue;
						case 1:
							Logger.Debug(YERVJL2vveBTIjoatqh(0x23D92C6F ^ 0x23D97659));
							num3 = 2;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
							{
								num3 = 3;
							}
							continue;
						case 2:
						{
							object obj = Qb00w62KlMsBPi4O2CR(zlie3r2JRnSI86oWXlB(sessionProvider, ""), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xC66FB14 ^ 0xC66A2EE));
							kbQ1oF2tC3oiiHaDnv1(obj, 0);
							KanBxL2hvCatg3FkdXC(obj, false);
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
							{
								num3 = 1;
							}
							continue;
						}
						case 3:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							cPKBpi2OStl9kB9oZZy(Logger, YERVJL2vveBTIjoatqh(0x1B47BFA1 ^ 0x1B47E5CF), ex);
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							throw new TransactionRollbackException((string)YERVJL2vveBTIjoatqh(0x61EAE816 ^ 0x61EAB2B6), ex);
						}
					}
				}
				finally
				{
					if (needlock)
					{
						int num5 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								disposable.Dispose();
								num5 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				break;
			case 7:
				disposable = null;
				num2 = 6;
				continue;
			case 6:
				if (!needlock)
				{
					num2 = 2;
					continue;
				}
				goto case 3;
			case 8:
				ujl9NY2qkL8L4dONYQW(securityCacheSetIdEventHandler, new SecurityCacheSetIdEventArgs
				{
					FullUpdate = true
				});
				num2 = 5;
				continue;
			case 4:
				break;
			}
			securityCacheSetIdAction.ForEach(delegate(ISecurityCacheSetIdAction a)
			{
				_003C_003Ec.XjRFyPpuF3WxcfFOdw7n(a);
			});
			num2 = 8;
		}
	}

	private string GetParameter(Dictionary<EleWise.ELMA.Security.Models.IUser, byte> users, Dictionary<IUserGroup, GroupUpdate> groups, Dictionary<IOrganizationItem, OrganizationItemUpdate> organizationItems)
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.list = (long[] l) => string.Concat(l.Select((long i) => (string)_003C_003Ec.b38LwfpuE893J5E4qjss(i, _003C_003Ec.lvhRkqpu0QTnVPKTYSlT(0x31C71464 ^ 0x31C70EAA))));
		Func<KeyValuePair<EleWise.ELMA.Security.Models.IUser, byte>, string> selector = (KeyValuePair<EleWise.ELMA.Security.Models.IUser, byte> u) => u.Key.Id + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD0A160);
		Func<KeyValuePair<IUserGroup, GroupUpdate>, string> selector2 = (KeyValuePair<IUserGroup, GroupUpdate> g) => g.Key.Id + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-764392425 ^ -764321505) + _003C_003Ec__DisplayClass18_.list(g.Value.AddUsers) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417CACD6) + _003C_003Ec__DisplayClass18_.list(g.Value.RemoveUsers) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2104667969 ^ -2104721993) + _003C_003Ec__DisplayClass18_.list(g.Value.AddOrganizationItems) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x9D1442B ^ 0x9D06923) + _003C_003Ec__DisplayClass18_.list(g.Value.RemoveOrganizationItems) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1889123947 ^ -1889047395) + _003C_003Ec__DisplayClass18_.list(g.Value.AddGroups) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51BB29A6 ^ 0x51BA04AE) + _003C_003Ec__DisplayClass18_.list(g.Value.RemoveGroups) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816887841 ^ -816881119);
		Func<KeyValuePair<IOrganizationItem, OrganizationItemUpdate>, string> selector3 = (KeyValuePair<IOrganizationItem, OrganizationItemUpdate> oi) => oi.Key.Id + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x335D4787 ^ 0x335C6A8F) + _003C_003Ec__DisplayClass18_.list(oi.Value.AddUsers) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1618182 ^ 0x160AC8A) + _003C_003Ec__DisplayClass18_.list(oi.Value.RemoveUsers) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x84482CB ^ 0x844A735);
		return string.Concat(groups.EmptyIfNull().Select(selector2).Concat(organizationItems.EmptyIfNull().Select(selector3))
			.Concat(users.EmptyIfNull().Select(selector)));
	}

	internal void ExecuteUpdate(Dictionary<EleWise.ELMA.Security.Models.IUser, byte> users, Dictionary<IUserGroup, GroupUpdate> groups, Dictionary<IOrganizationItem, OrganizationItemUpdate> organizationItems, Guid auditUid)
	{
		if ((users == null || users.Count == 0) && (groups == null || groups.Count == 0) && (organizationItems == null || organizationItems.Count == 0))
		{
			return;
		}
		string parameter = GetParameter(users, groups, organizationItems);
		if (WaitTimeSpan == TimeSpan.Zero)
		{
			ExecuteUpdateInternal(parameter, auditUid);
			return;
		}
		Guid guid = Guid.NewGuid();
		Logger.DebugFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5EE4A7B ^ 0x5EE108B), guid, parameter);
		transformationProvider.Insert(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD0DD46), new string[3]
		{
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C28ED7),
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x23D92C6F ^ 0x23D97775),
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x715714F9 ^ 0x71574FCF)
		}, new object[3]
		{
			guid,
			new SqlExpressionParameter(transformationProvider.Dialect.CurrentTimestamp),
			parameter
		});
		try
		{
			actorModelRuntime.GetActor<IUpdateUserSecuritySetCacheQueueManagerActor>(0L).RegisterExecute(WaitTimeSpan);
		}
		catch (Exception message)
		{
			Logger.Warn(message);
		}
		securityCacheSetIdAction.ForEach(delegate(ISecurityCacheSetIdAction a)
		{
			a.Execute();
		});
	}

	internal void Execute()
	{
		//Discarded unreachable code: IL_00cf, IL_014a, IL_025a, IL_0269, IL_037d, IL_038c, IL_03ea, IL_03f9, IL_0555, IL_0574, IL_05a0, IL_05af, IL_074b, IL_0817, IL_084f, IL_085e, IL_08b0, IL_0909, IL_0941, IL_0950
		int num = 3;
		int num2 = num;
		CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
		IDataReader dataReader = default(IDataReader);
		KeyValuePair<DateTime, List<Guid>> keyValuePair = default(KeyValuePair<DateTime, List<Guid>>);
		Dictionary<DateTime, List<Guid>> dictionary = default(Dictionary<DateTime, List<Guid>>);
		List<Guid> value = default(List<Guid>);
		DateTime key = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Et6sCU2U8IRWbtfXosj(Logger, YERVJL2vveBTIjoatqh(-1580392499 ^ -1580383373));
				num2 = 4;
				break;
			case 2:
				callContextSessionOwner = (CallContextSessionOwner)beBkdl2c5PxKTqhDGQA();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				Et6sCU2U8IRWbtfXosj(Logger, YERVJL2vveBTIjoatqh(-1518425080 ^ -1518405814));
				num2 = 2;
				break;
			case 4:
				return;
			default:
				try
				{
					IUnitOfWork unitOfWork = (IUnitOfWork)XVHJsT2Ga4P8lYCif8y(unitOfWorkManager, string.Empty, true, IsolationLevel.Unspecified);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							IDisposable disposable = lockManager.Lock((string)YERVJL2vveBTIjoatqh(-208231202 ^ -208207938));
							int num4 = 2;
							int num5 = num4;
							while (true)
							{
								switch (num5)
								{
								default:
									goto end_IL_0111;
								case 2:
									try
									{
										List<string> list = new List<string>();
										int num6 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											case 2:
												return;
											case 9:
												dataReader = transformationProvider.ExecuteQuery((string)Wnhk0H208QZfwNZkTM2(YERVJL2vveBTIjoatqh(-930147978 ^ -930133286), new object[4]
												{
													Sg99gy2FO3PcFRVuKIR(JXVCry2oJpQuSbuG2Rc(transformationProvider), YERVJL2vveBTIjoatqh(0x417D81DE ^ 0x417D8E40)),
													Sg99gy2FO3PcFRVuKIR(JXVCry2oJpQuSbuG2Rc(transformationProvider), YERVJL2vveBTIjoatqh(-730071140 ^ -730094422)),
													Sg99gy2FO3PcFRVuKIR(JXVCry2oJpQuSbuG2Rc(transformationProvider), YERVJL2vveBTIjoatqh(-1084772212 ^ -1084757098)),
													((Dialect)JXVCry2oJpQuSbuG2Rc(transformationProvider)).QuoteIfNeeded((string)YERVJL2vveBTIjoatqh(-1365352774 ^ -1365375134))
												}));
												num6 = 8;
												continue;
											case 1:
												transformationProvider.ExecuteNonQuery((string)ekBKmT2QPd9TZUCc82D(YERVJL2vveBTIjoatqh(-784481839 ^ -784491065), Sg99gy2FO3PcFRVuKIR(JXVCry2oJpQuSbuG2Rc(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C2D891)), Sg99gy2FO3PcFRVuKIR(JXVCry2oJpQuSbuG2Rc(transformationProvider), YERVJL2vveBTIjoatqh(-163225536 ^ -163234982)), mqehU42V58HcQIpUGB2(CgCFge24gVUmodIkWsE(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E5BC59F ^ 0x3E5B9E85))), new Dictionary<string, object> { 
												{
													SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CD4C8A0 ^ 0x4CD493BA),
													keyValuePair.Key
												} });
												num6 = 10;
												continue;
											case 3:
												Et6sCU2U8IRWbtfXosj(Logger, YERVJL2vveBTIjoatqh(0x62C4BCE8 ^ 0x62C4E0EC));
												num6 = 2;
												continue;
											case 11:
											case 12:
												ExecuteUpdateInternal(string.Concat(list), Guid.NewGuid());
												num6 = 13;
												continue;
											case 6:
												if (NHI7M42IAPRXsbHUgQu(dictionary) <= 1)
												{
													num6 = 5;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
													{
														num6 = 7;
													}
													continue;
												}
												goto case 1;
											case 4:
												if (NHI7M42IAPRXsbHUgQu(dictionary) != 0)
												{
													num6 = 12;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
													{
														num6 = 2;
													}
													continue;
												}
												goto case 3;
											case 8:
												try
												{
													while (true)
													{
														int num7;
														if (!dataReader.Read())
														{
															num7 = 4;
															goto IL_0408;
														}
														goto IL_04d5;
														IL_0408:
														while (true)
														{
															int num8;
															switch (num7)
															{
															default:
																value.Add(jJTrsM2sAMxORLE22wJ(JXVCry2oJpQuSbuG2Rc(transformationProvider), a189Eo2E5eLJw4KsyAT(dataReader, YERVJL2vveBTIjoatqh(-208231202 ^ -208229568))));
																num7 = 0;
																if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
																{
																	num7 = 1;
																}
																continue;
															case 6:
																value = (dictionary[key] = new List<Guid>());
																num7 = 0;
																if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
																{
																	num7 = 0;
																}
																continue;
															case 1:
																break;
															case 3:
																if (!dictionary.TryGetValue(key, out value))
																{
																	num8 = 6;
																	goto IL_0404;
																}
																goto default;
															case 5:
																goto IL_04d5;
															case 2:
																key = GdsLTH2M99bwBMmsBQQ(a189Eo2E5eLJw4KsyAT(dataReader, YERVJL2vveBTIjoatqh(0x7A093321 ^ 0x7A09683B)));
																num8 = 3;
																goto IL_0404;
															case 4:
																goto end_IL_04a1;
																IL_0404:
																num7 = num8;
																continue;
															}
															break;
														}
														continue;
														IL_04d5:
														list.Add((string)P4MFFY2DqXWoBl1vXHf(a189Eo2E5eLJw4KsyAT(dataReader, YERVJL2vveBTIjoatqh(-1826813434 ^ -1826795216))));
														num7 = 2;
														goto IL_0408;
														continue;
														end_IL_04a1:
														break;
													}
												}
												finally
												{
													int num9;
													if (dataReader == null)
													{
														num9 = 0;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
														{
															num9 = 0;
														}
														goto IL_0559;
													}
													goto IL_057e;
													IL_057e:
													pcw2Gv2YW6ShCuxmAnU(dataReader);
													num9 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
													{
														num9 = 1;
													}
													goto IL_0559;
													IL_0559:
													switch (num9)
													{
													default:
														goto end_IL_0534;
													case 0:
														goto end_IL_0534;
													case 2:
														break;
													case 1:
														goto end_IL_0534;
													}
													goto IL_057e;
													end_IL_0534:;
												}
												goto case 4;
											default:
												dictionary = new Dictionary<DateTime, List<Guid>>();
												num6 = 9;
												continue;
											case 13:
												keyValuePair = dictionary.OrderByDescending((KeyValuePair<DateTime, List<Guid>> p) => p.Key).First();
												num6 = 2;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
												{
													num6 = 6;
												}
												continue;
											case 7:
											case 10:
												transformationProvider.ExecuteNonQuery(string.Format((string)YERVJL2vveBTIjoatqh(-1858473711 ^ -1858491063), ((Dialect)JXVCry2oJpQuSbuG2Rc(transformationProvider)).QuoteIfNeeded((string)YERVJL2vveBTIjoatqh(-1429500015 ^ -1429481911)), Sg99gy2FO3PcFRVuKIR(transformationProvider.Dialect, YERVJL2vveBTIjoatqh(--1983795824 ^ 0x763E5DEE)), string.Join((string)YERVJL2vveBTIjoatqh(-1027693337 ^ -1027691143), keyValuePair.Value.Select((Guid g, int i) => (string)vBqeWg2fUPENV45TrSJ(CgCFge24gVUmodIkWsE(transformationProvider), YERVJL2vveBTIjoatqh(0x32A45635 ^ 0x32A44855), i)))), keyValuePair.Value.Select((Guid g, int i) => new KeyValuePair<string, object>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-208231202 ^ -208225602) + i, g)).ToDictionary((KeyValuePair<string, object> p) => p.Key, (KeyValuePair<string, object> p) => p.Value));
												num6 = 5;
												continue;
											case 5:
												break;
											}
											break;
										}
									}
									catch (Exception ex)
									{
										int num10 = 2;
										while (true)
										{
											switch (num10)
											{
											case 3:
												return;
											case 2:
												KXoOh82drrplBf4lFi0(unitOfWork);
												num10 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
												{
													num10 = 1;
												}
												break;
											default:
												ltsFqo2gBRk95yOQepP(Logger, ex, YERVJL2vveBTIjoatqh(-1580392499 ^ -1580383379), Array.Empty<object>());
												num10 = 3;
												break;
											case 1:
												cPKBpi2OStl9kB9oZZy(OYirGd2T78Wf5vtU7J8(), YERVJL2vveBTIjoatqh(-1027693337 ^ -1027670457), ex);
												num10 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
												{
													num10 = 0;
												}
												break;
											}
										}
									}
									finally
									{
										if (disposable != null)
										{
											int num11 = 1;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
											{
												num11 = 1;
											}
											while (true)
											{
												switch (num11)
												{
												case 1:
													pcw2Gv2YW6ShCuxmAnU(disposable);
													num11 = 0;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
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
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0111;
								}
								unitOfWork.Commit();
								num5 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
								{
									num5 = 0;
								}
								continue;
								end_IL_0111:
								break;
							}
						}
						finally
						{
							if (unitOfWork != null)
							{
								int num12 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
								{
									num12 = 1;
								}
								while (true)
								{
									switch (num12)
									{
									case 1:
										pcw2Gv2YW6ShCuxmAnU(unitOfWork);
										num12 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
										{
											num12 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						break;
					}
				}
				finally
				{
					if (callContextSessionOwner != null)
					{
						int num13 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
						{
							num13 = 0;
						}
						while (true)
						{
							switch (num13)
							{
							default:
								pcw2Gv2YW6ShCuxmAnU(callContextSessionOwner);
								num13 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
								{
									num13 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 1;
			}
		}
	}

	private void ExecuteUpdateInternal(string param, Guid auditUid)
	{
		//Discarded unreachable code: IL_038b, IL_046f, IL_04c7, IL_053b, IL_05bc, IL_05c8, IL_05f1, IL_0692, IL_06b9, IL_06c3, IL_06d2, IL_0760, IL_076f, IL_0796, IL_07a5, IL_07d7, IL_0928, IL_0968, IL_0977, IL_0983, IL_0992, IL_0bd7, IL_0c07, IL_0c16, IL_0c22, IL_0c31
		int num = 5;
		SecurityCacheSetIdEventArgs securityCacheSetIdEventArgs = default(SecurityCacheSetIdEventArgs);
		IDisposable disposable = default(IDisposable);
		List<Tuple<long, long>> list9 = default(List<Tuple<long, long>>);
		List<Tuple<long, long>> list4 = default(List<Tuple<long, long>>);
		List<Tuple<long, long>> list5 = default(List<Tuple<long, long>>);
		List<Tuple<long, long>> list3 = default(List<Tuple<long, long>>);
		List<Tuple<long, long>> list2 = default(List<Tuple<long, long>>);
		List<Tuple<long, long>> list12 = default(List<Tuple<long, long>>);
		List<Tuple<long, long>> list = default(List<Tuple<long, long>>);
		List<Tuple<long, long>> list11 = default(List<Tuple<long, long>>);
		ISession val = default(ISession);
		string text = default(string);
		IEnumerator<UUSSCGroupData> enumerator = default(IEnumerator<UUSSCGroupData>);
		UUSSCGroupData current = default(UUSSCGroupData);
		long? num8 = default(long?);
		int? addCount = default(int?);
		long num9 = default(long);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					securityCacheSetIdEventHandler.PostCacheSet(securityCacheSetIdEventArgs);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					disposable = lockManager.Lock((string)YERVJL2vveBTIjoatqh(-1027693337 ^ -1027670585));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					try
					{
						lqig1X28uJb9gQQchKS(Logger, YERVJL2vveBTIjoatqh(0x4D765E72 ^ 0x4D760290), new object[1] { param });
						int num3 = 14;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
						{
							num3 = 12;
						}
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 4:
								securityCacheSetIdEventArgs.GroupRemoveGroups = list9;
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
								{
									num3 = 1;
								}
								continue;
							case 10:
								list4 = new List<Tuple<long, long>>();
								num3 = 22;
								continue;
							case 7:
								list5 = new List<Tuple<long, long>>();
								num4 = 9;
								goto IL_00d8;
							case 3:
								securityCacheSetIdEventArgs.GroupAddGroups = list3;
								num4 = 4;
								goto IL_00d8;
							case 8:
								list2 = new List<Tuple<long, long>>();
								num3 = 11;
								continue;
							case 16:
								securityCacheSetIdEventArgs.GroupRemoveUsers = list12;
								num3 = 12;
								continue;
							case 11:
								list12 = new List<Tuple<long, long>>();
								num3 = 7;
								continue;
							case 5:
								securityCacheSetIdEventArgs.GroupRemoveOrganizationItems = list;
								num3 = 3;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
								{
									num3 = 3;
								}
								continue;
							case 18:
								securityCacheSetIdEventArgs.OrganizationItemRemoveUsers = list11;
								num3 = 19;
								continue;
							case 14:
								val = (ISession)zlie3r2JRnSI86oWXlB(sessionProvider, "");
								num3 = 20;
								continue;
							case 22:
								list11 = new List<Tuple<long, long>>();
								num3 = 6;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
								{
									num3 = 3;
								}
								continue;
							case 2:
								list9 = new List<Tuple<long, long>>();
								num3 = 10;
								continue;
							case 6:
								text = string.Format((string)YERVJL2vveBTIjoatqh(0x738E3073 ^ 0x738E6DA1), ((Dialect)JXVCry2oJpQuSbuG2Rc(transformationProvider)).QuoteIfNeeded((string)YERVJL2vveBTIjoatqh(0x40944BC4 ^ 0x40945BD4)), Sg99gy2FO3PcFRVuKIR(transformationProvider.Dialect, YERVJL2vveBTIjoatqh(0x3E5BC59F ^ 0x3E5B9B5B)), Sg99gy2FO3PcFRVuKIR(JXVCry2oJpQuSbuG2Rc(transformationProvider), YERVJL2vveBTIjoatqh(-2119527672 ^ -2119528430)), Sg99gy2FO3PcFRVuKIR(JXVCry2oJpQuSbuG2Rc(transformationProvider), YERVJL2vveBTIjoatqh(0x51BB29A6 ^ 0x51BB6CA0)), ((Dialect)JXVCry2oJpQuSbuG2Rc(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD946FDB ^ 0xD947FC3)), Sg99gy2FO3PcFRVuKIR(JXVCry2oJpQuSbuG2Rc(transformationProvider), YERVJL2vveBTIjoatqh(0x7A093321 ^ 0x7A096DF9)), Sg99gy2FO3PcFRVuKIR(JXVCry2oJpQuSbuG2Rc(transformationProvider), YERVJL2vveBTIjoatqh(0xD946FDB ^ 0xD943123)));
								num3 = 21;
								continue;
							case 15:
								try
								{
									while (true)
									{
										int num5;
										if (!jbpKfQ2bxVux6IENEXc(enumerator))
										{
											num5 = 18;
											goto IL_0395;
										}
										goto IL_0609;
										IL_04f7:
										num5 = 2;
										goto IL_0395;
										IL_0609:
										current = enumerator.Current;
										int num6 = 35;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
										{
											num6 = 9;
										}
										goto IL_0399;
										IL_0395:
										num6 = num5;
										goto IL_0399;
										IL_0399:
										while (true)
										{
											List<Tuple<long, long>> list7;
											List<Tuple<long, long>> list10;
											List<Tuple<long, long>> list8;
											List<Tuple<long, long>> list6;
											long item;
											long id;
											long item2;
											long item3;
											switch (num6)
											{
											case 4:
												num8 = current.GroupId;
												num6 = 16;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
												{
													num6 = 19;
												}
												continue;
											case 22:
												addCount = current.AddCount;
												num6 = 25;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
												{
													num6 = 37;
												}
												continue;
											case 31:
												if (!num8.HasValue)
												{
													num6 = 5;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
													{
														num6 = 33;
													}
													continue;
												}
												goto case 22;
											case 24:
											case 25:
											case 28:
											case 33:
											case 34:
												break;
											case 20:
												if (!num8.HasValue)
												{
													goto IL_04f7;
												}
												goto case 26;
											case 39:
												num9 = -1L;
												num6 = 4;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
												{
													num6 = 40;
												}
												continue;
											case 17:
											case 21:
												num8 = current.GroupId;
												num6 = 16;
												continue;
											case 26:
												addCount = current.AddCount;
												num6 = 29;
												continue;
											case 19:
												num9 = -1L;
												num6 = 12;
												continue;
											case 12:
												if (num8 == num9)
												{
													num6 = 7;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
													{
														num6 = 1;
													}
													continue;
												}
												goto case 11;
											case 30:
												num7 = 0;
												num6 = 3;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
												{
													num6 = 2;
												}
												continue;
											case 1:
												list7 = list;
												goto IL_08aa;
											case 15:
												list10 = list12;
												goto IL_086d;
											case 37:
												num7 = 0;
												num6 = 2;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
												{
													num6 = 23;
												}
												continue;
											case 14:
												list8 = list11;
												goto IL_0840;
											case 7:
												num8 = current.UserId;
												num6 = 31;
												continue;
											case 38:
												goto IL_0609;
											case 3:
												if (!(addCount > num7))
												{
													num6 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
													{
														num6 = 0;
													}
													continue;
												}
												list7 = list5;
												goto IL_08aa;
											case 32:
												num7 = 0;
												num6 = 8;
												continue;
											case 10:
												if (!(addCount > num7))
												{
													num6 = 15;
													continue;
												}
												list10 = list2;
												goto IL_086d;
											case 16:
												if (num8.HasValue)
												{
													num6 = 27;
													continue;
												}
												break;
											case 9:
												list6 = list9;
												goto IL_08d7;
											case 8:
												if (addCount > num7)
												{
													num6 = 6;
													continue;
												}
												goto case 9;
											case 23:
												if (!(addCount > num7))
												{
													goto IL_0717;
												}
												list8 = list4;
												goto IL_0840;
											default:
												addCount = current.AddCount;
												num6 = 21;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
												{
													num6 = 30;
												}
												continue;
											case 11:
											case 13:
												num8 = current.UserId;
												num6 = 20;
												continue;
											case 35:
												goto IL_077a;
											case 40:
												if (num8 != num9)
												{
													num6 = 13;
													continue;
												}
												goto case 4;
											case 36:
												if (num8.HasValue)
												{
													goto default;
												}
												goto IL_07ed;
											case 2:
											case 5:
												num8 = current.OrgItemId;
												num6 = 36;
												continue;
											case 27:
												addCount = current.AddCount;
												num6 = 20;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
												{
													num6 = 32;
												}
												continue;
											case 29:
												num7 = 0;
												num6 = 10;
												continue;
											case 6:
												list6 = list3;
												goto IL_08d7;
											case 18:
												goto end_IL_04d1;
												IL_08aa:
												item = aLbNRU2yeZIQ6cxjUOw(current);
												num8 = current.OrgItemId;
												list7.Add(new Tuple<long, long>(item, num8.Value));
												num6 = 24;
												continue;
												IL_08d7:
												id = current.Id;
												num8 = current.GroupId;
												list6.Add(new Tuple<long, long>(id, num8.Value));
												num6 = 28;
												continue;
												IL_0840:
												item2 = aLbNRU2yeZIQ6cxjUOw(current);
												num8 = current.UserId;
												list8.Add(new Tuple<long, long>(item2, num8.Value));
												num6 = 34;
												continue;
												IL_086d:
												item3 = aLbNRU2yeZIQ6cxjUOw(current);
												num8 = current.UserId;
												list10.Add(new Tuple<long, long>(item3, num8.Value));
												num6 = 19;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
												{
													num6 = 25;
												}
												continue;
											}
											break;
										}
										continue;
										IL_07ed:
										num5 = 17;
										goto IL_0395;
										IL_077a:
										num8 = current.OrgItemId;
										num5 = 39;
										goto IL_0395;
										IL_0717:
										num5 = 14;
										goto IL_0395;
										continue;
										end_IL_04d1:
										break;
									}
								}
								finally
								{
									int num10;
									if (enumerator == null)
									{
										num10 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
										{
											num10 = 0;
										}
										goto IL_092c;
									}
									goto IL_0942;
									IL_0942:
									pcw2Gv2YW6ShCuxmAnU(enumerator);
									num10 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
									{
										num10 = 1;
									}
									goto IL_092c;
									IL_092c:
									switch (num10)
									{
									default:
										goto end_IL_0907;
									case 2:
										break;
									case 0:
										goto end_IL_0907;
									case 1:
										goto end_IL_0907;
									}
									goto IL_0942;
									end_IL_0907:;
								}
								goto case 13;
							case 21:
								enumerator = ((IQuery)fuaNvW23MZ3NdiKgVfh(k2tBo72r1CZIgHHJZup(val.CreateSQLQuery(text), new AliasToBeanResultTransformer(typeof(UUSSCGroupData))), false)).List<UUSSCGroupData>().GetEnumerator();
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
								{
									num3 = 15;
								}
								continue;
							case 12:
								securityCacheSetIdEventArgs.GroupAddOrganizationItems = list5;
								num3 = 5;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								securityCacheSetIdEventArgs.OrganizationItemAddUsers = list4;
								num3 = 18;
								continue;
							default:
								list3 = new List<Tuple<long, long>>();
								num3 = 2;
								continue;
							case 9:
								list = new List<Tuple<long, long>>();
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
								{
									num3 = 0;
								}
								continue;
							case 13:
								securityCacheSetIdEventArgs.GroupAddUsers = list2;
								num3 = 16;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
								{
									num3 = 9;
								}
								continue;
							case 20:
								KanBxL2hvCatg3FkdXC(kbQ1oF2tC3oiiHaDnv1(((IQuery)Qb00w62KlMsBPi4O2CR(val, YERVJL2vveBTIjoatqh(0x487E82CC ^ 0x487EDFEA))).SetParameter<string>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x335D4787 ^ 0x335D1AE1), param).SetParameter<Guid>((string)YERVJL2vveBTIjoatqh(-1943394692 ^ -1943373054), auditUid), 0), false);
								num3 = 17;
								continue;
							case 17:
								Et6sCU2U8IRWbtfXosj(Logger, YERVJL2vveBTIjoatqh(-1687496463 ^ -1687517853));
								num3 = 8;
								continue;
							case 19:
								break;
								IL_00d8:
								num3 = num4;
								continue;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num11 = 3;
						while (true)
						{
							switch (num11)
							{
							default:
								return;
							case 3:
								cPKBpi2OStl9kB9oZZy(OYirGd2T78Wf5vtU7J8(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xC66FB14 ^ 0xC66A1B4), ex);
								num11 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
								{
									num11 = 1;
								}
								break;
							case 2:
								ExecuteFullUpdate(needlock: false);
								num11 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
								{
									num11 = 0;
								}
								break;
							case 1:
							{
								cPKBpi2OStl9kB9oZZy(Logger, YERVJL2vveBTIjoatqh(0x45F3B9A1 ^ 0x45F3E6BD), ex);
								int num12 = 2;
								num11 = num12;
								break;
							}
							case 0:
								return;
							}
						}
					}
					finally
					{
						int num13;
						if (disposable == null)
						{
							num13 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
							{
								num13 = 0;
							}
							goto IL_0bdb;
						}
						goto IL_0bf1;
						IL_0bf1:
						disposable.Dispose();
						num13 = 2;
						goto IL_0bdb;
						IL_0bdb:
						switch (num13)
						{
						default:
							goto end_IL_0bb6;
						case 1:
							break;
						case 0:
							goto end_IL_0bb6;
						case 2:
							goto end_IL_0bb6;
						}
						goto IL_0bf1;
						end_IL_0bb6:;
					}
					break;
				case 1:
					return;
				case 5:
					securityCacheSetIdEventArgs = new SecurityCacheSetIdEventArgs();
					num2 = 4;
					continue;
				case 3:
					break;
				}
				break;
			}
			securityCacheSetIdAction.ForEach(delegate(ISecurityCacheSetIdAction a)
			{
				_003C_003Ec.XjRFyPpuF3WxcfFOdw7n(a);
			});
			num = 2;
		}
	}

	static UpdateUserSecuritySetCacheQueueManager()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				XpllwH2S9OOZiA4M0RS();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				Logger = (ILogger)X9AqrI29aSdlgtkD71Q(YERVJL2vveBTIjoatqh(-2037738356 ^ -2037724198));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static TimeSpan qKXbx92PZoUtrICVNyY(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static bool sjGY542wmPjBf5VUVyf()
	{
		return xSXDF12Ro2FRv5dWjgm == null;
	}

	internal static UpdateUserSecuritySetCacheQueueManager yvdPqK224m8n3l8DWKb()
	{
		return xSXDF12Ro2FRv5dWjgm;
	}

	internal static object YERVJL2vveBTIjoatqh(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ypkejD2CI0CHAI3rD4p(object P_0, object P_1)
	{
		return ((ILockManager)P_0).Lock((string)P_1);
	}

	internal static void Et6sCU2U8IRWbtfXosj(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static object JXVCry2oJpQuSbuG2Rc(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object zlie3r2JRnSI86oWXlB(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object Qb00w62KlMsBPi4O2CR(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static object kbQ1oF2tC3oiiHaDnv1(object P_0, int P_1)
	{
		return ((IQuery)P_0).SetTimeout(P_1);
	}

	internal static int KanBxL2hvCatg3FkdXC(object P_0, bool P_1)
	{
		return ((IQuery)P_0).ExecuteUpdate(P_1);
	}

	internal static void cPKBpi2OStl9kB9oZZy(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void ujl9NY2qkL8L4dONYQW(object P_0, object P_1)
	{
		((ISecurityCacheSetIdEventHandler)P_0).PostCacheSet((SecurityCacheSetIdEventArgs)P_1);
	}

	internal static object beBkdl2c5PxKTqhDGQA()
	{
		return CallContextSessionOwner.Create();
	}

	internal static object XVHJsT2Ga4P8lYCif8y(object P_0, object P_1, bool P_2, IsolationLevel P_3)
	{
		return ((IUnitOfWorkManager)P_0).Create((string)P_1, P_2, P_3);
	}

	internal static object Sg99gy2FO3PcFRVuKIR(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object Wnhk0H208QZfwNZkTM2(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object a189Eo2E5eLJw4KsyAT(object P_0, object P_1)
	{
		return ((IDataRecord)P_0)[(string)P_1];
	}

	internal static object P4MFFY2DqXWoBl1vXHf(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static DateTime GdsLTH2M99bwBMmsBQQ(object P_0)
	{
		return Convert.ToDateTime(P_0);
	}

	internal static Guid jJTrsM2sAMxORLE22wJ(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetGuid(P_1);
	}

	internal static void pcw2Gv2YW6ShCuxmAnU(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int NHI7M42IAPRXsbHUgQu(object P_0)
	{
		return ((Dictionary<DateTime, List<Guid>>)P_0).Count;
	}

	internal static object CgCFge24gVUmodIkWsE(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object mqehU42V58HcQIpUGB2(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object ekBKmT2QPd9TZUCc82D(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void KXoOh82drrplBf4lFi0(object P_0)
	{
		((IUnitOfWork)P_0).Rollback();
	}

	internal static object OYirGd2T78Wf5vtU7J8()
	{
		return EleWise.ELMA.Logging.Logger.Log;
	}

	internal static void ltsFqo2gBRk95yOQepP(object P_0, object P_1, object P_2, object P_3)
	{
		((ILogger)P_0).Error((Exception)P_1, (string)P_2, (object[])P_3);
	}

	internal static void lqig1X28uJb9gQQchKS(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).DebugFormat((string)P_1, (object[])P_2);
	}

	internal static object k2tBo72r1CZIgHHJZup(object P_0, object P_1)
	{
		return ((IQuery)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static object fuaNvW23MZ3NdiKgVfh(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static long aLbNRU2yeZIQ6cxjUOw(object P_0)
	{
		return ((UUSSCGroupData)P_0).Id;
	}

	internal static bool jbpKfQ2bxVux6IENEXc(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void XpllwH2S9OOZiA4M0RS()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object X9AqrI29aSdlgtkD71Q(object P_0)
	{
		return EleWise.ELMA.Logging.Logger.GetLogger((string)P_0);
	}

	internal static object vBqeWg2fUPENV45TrSJ(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}
}
