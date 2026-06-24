using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Db;

internal abstract class AbstractObservedContextPropertyUpdateHandler : IInitHandler
{
	private class ContextVarInfoExt : WorkflowInstanceManager.ContextVarInfo
	{
		internal static object rbqbf5ZE2JyZdZ3ZHlh8;

		public Guid EntityTypeUid
		{
			[CompilerGenerated]
			get
			{
				return _003CEntityTypeUid_003Ek__BackingField;
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
						_003CEntityTypeUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid SubTypeUid
		{
			[CompilerGenerated]
			get
			{
				return _003CSubTypeUid_003Ek__BackingField;
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
						_003CSubTypeUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ContextVarInfoExt()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			KScdHpZEieCc30yIJ626();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool VUsrT4ZEoVQN1YsBrIHk()
		{
			return rbqbf5ZE2JyZdZ3ZHlh8 == null;
		}

		internal static ContextVarInfoExt aYlWufZEF8P9VcPdhEEr()
		{
			return (ContextVarInfoExt)rbqbf5ZE2JyZdZ3ZHlh8;
		}

		internal static void KScdHpZEieCc30yIJ626()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private readonly Guid uid;

	private readonly string key;

	private List<Guid> currentObservedTypeUids;

	private List<Guid> previousObservedTypeUids;

	private List<Guid> addedObservedTypeUids;

	private ITransformationProvider transformationProvider;

	private ISessionProvider sessionProvider;

	private IRuntimeApplication runtimeApplication;

	private IEnumerable<IWorkflowContextPropertyObserver> observers;

	internal static AbstractObservedContextPropertyUpdateHandler xrVQnAOZuXCcwigwlH6l;

	protected ITransformationProvider Transform
	{
		get
		{
			int num = 2;
			int num2 = num;
			ITransformationProvider obj;
			ITransformationProvider transformationProvider = default(ITransformationProvider);
			while (true)
			{
				switch (num2)
				{
				case 2:
					obj = this.transformationProvider;
					if (obj == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					transformationProvider = (this.transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = transformationProvider;
					break;
				}
				break;
			}
			return obj;
		}
	}

	protected ISessionProvider SessionProvider
	{
		get
		{
			int num = 2;
			int num2 = num;
			ISessionProvider sessionProvider = default(ISessionProvider);
			ISessionProvider obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					sessionProvider = (this.sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.sessionProvider;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				default:
					obj = sessionProvider;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public virtual int? ChunkSize => null;

	public AbstractObservedContextPropertyUpdateHandler(IEnumerable<IWorkflowContextPropertyObserver> observers, IRuntimeApplication runtimeApplication)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		uid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x759F1D2));
		key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130065562);
		base._002Ector();
		this.observers = observers;
		this.runtimeApplication = runtimeApplication;
	}

	public void Init()
	{
	}

	public virtual void InitComplete()
	{
		//Discarded unreachable code: IL_00b1, IL_0143, IL_0180, IL_018f, IL_01c5
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		List<Guid> list = default(List<Guid>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 8:
				return;
			case 6:
				_003C_003Ec__DisplayClass18_.currentUids = GetCurrentObservedSubTypeUids();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass18_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 7:
				try
				{
					Transform.BeginTransaction();
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						default:
							zqgv00OZCRQMfAnZ6k1h(Transform);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
							{
								num3 = 2;
							}
							break;
						case 1:
							z6mkW8OZpxW0gdL3hpHy(Transform, 0, new Action(_003C_003Ec__DisplayClass18_._003CInitComplete_003Eb__6));
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				catch
				{
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							throw;
						}
						g9O8OlOZMwLMe28HaDlT(Transform);
						num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
						{
							num4 = 1;
						}
					}
				}
			case 1:
				if (!CheckNeedRecreate())
				{
					return;
				}
				num2 = 6;
				break;
			case 3:
				_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
				num2 = 2;
				break;
			case 4:
				list = (from md in GetAddedObservedSubTypeUids().SelectMany((Guid uid) => MetadataLoader.GetChildClasses(uid, loadImplementation: false, includeRoot: true))
					select md.Uid).ToList();
				num2 = 5;
				break;
			case 5:
			{
				List<ContextVarInfoExt> source = ((ICriteria)zryrH2OZQLefuRVyq4VT(TsitCoOZ3VQnlgoXXe6O(((ICriteria)skqx8fOZWk3djxt6GwwF(((ICriteria)GEdw8AOZ98yYIHvxu8iA(GEdw8AOZ98yYIHvxu8iA(gL8h6oOZLgknNKm1yGD2(mGZmloOZH7dqDy2vu71V(SessionProvider, ""), InterfaceActivator.TypeOf<IProcessHeader>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393909108)), lxg4fgOZfsKs9Brpw3c1(-43932417 ^ -43925447), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130106360), (JoinType)0), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542165006), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516545794), (JoinType)0)).Add((ICriterion)(object)Restrictions.IsNotNull((string)lxg4fgOZfsKs9Brpw3c1(0x1C663DA1 ^ 0x1C6658BD))), Restrictions.In((string)lxg4fgOZfsKs9Brpw3c1(0x63D6C913 ^ 0x63D74ADD), (ICollection)observers.SelectMany((IWorkflowContextPropertyObserver o) => o.GetAllObservedTypeUids()).Distinct().ToList()))).Add((ICriterion)lVejlDOZjdqNNQPTjyfa(lxg4fgOZfsKs9Brpw3c1(-1574607501 ^ -1574639979), list)), new IProjection[1] { (IProjection)p8DoZPOZqhk1SofV1FAw(p8DoZPOZqhk1SofV1FAw(p8DoZPOZqhk1SofV1FAw(p8DoZPOZqhk1SofV1FAw(p8DoZPOZqhk1SofV1FAw(p8DoZPOZqhk1SofV1FAw(p8DoZPOZqhk1SofV1FAw(p8DoZPOZqhk1SofV1FAw(LVKQRmOZRfaN2lwklddL(), WNN8RAOZ6fR23NV3eHgk(lxg4fgOZfsKs9Brpw3c1(0x361628FF ^ 0x36164DC7)), lxg4fgOZfsKs9Brpw3c1(0x1843E01F ^ 0x1843AF6F)), WNN8RAOZ6fR23NV3eHgk(lxg4fgOZfsKs9Brpw3c1(0xDF4D1F8 ^ 0xDF4B4BE)), lxg4fgOZfsKs9Brpw3c1(-1638225214 ^ -1638215770)), WNN8RAOZ6fR23NV3eHgk(lxg4fgOZfsKs9Brpw3c1(-947937941 ^ -947914731)), lxg4fgOZfsKs9Brpw3c1(-1386448964 ^ -1386474958)), WNN8RAOZ6fR23NV3eHgk(lxg4fgOZfsKs9Brpw3c1(0x4FD00585 ^ 0x4FD1864B)), lxg4fgOZfsKs9Brpw3c1(0x34EA50D4 ^ 0x34EBD4D0)), Projections.Property((string)lxg4fgOZfsKs9Brpw3c1(0x2F44D93A ^ 0x2F455ADC)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028830267)), Projections.Property((string)lxg4fgOZfsKs9Brpw3c1(0x101D10F ^ 0x101B4A7)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125920318)), Projections.Property((string)lxg4fgOZfsKs9Brpw3c1(-1895853023 ^ -1895829001)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD303932)), WNN8RAOZ6fR23NV3eHgk(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F9DE4)), lxg4fgOZfsKs9Brpw3c1(0x46EA3D1 ^ 0x46EC5F5)) }), new AliasToBeanResultTransformer(QiS2oLOZTY9MJhtudUoX(typeof(ContextVarInfoExt).TypeHandle)))).List<ContextVarInfoExt>().ToList();
				_003C_003Ec__DisplayClass18_.joinCount = 1;
				_003C_003Ec__DisplayClass18_.process = _003C_003Ec__DisplayClass18_._003CInitComplete_003Eb__3;
				_003C_003Ec__DisplayClass18_.queryList = new List<string>();
				(from k in source
					group k by new { k.ProcessHeaderId, k.ContextName }).ToList().ForEach(_003C_003Ec__DisplayClass18_._003CInitComplete_003Eb__5);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
				{
					num2 = 7;
				}
				break;
			}
			}
		}
	}

	private string GetSql(ContextVarInfoExt info, TableSelect select)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(select, (string)lxg4fgOZfsKs9Brpw3c1(-865213812 ^ -865311030));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				iiYTQNOZkrjMbF5bP2it(info, lxg4fgOZfsKs9Brpw3c1(-980570076 ^ -980667362));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return (string)R3bWT6OZrOAMoZc4dpOP(lxg4fgOZfsKs9Brpw3c1(0x1C663DA1 ^ 0x1C67B9F7), new object[11]
			{
				ttHqGWOZU6TaNLW7qngM(info),
				k7u2dAOZ2xUqcLrHDd8k(PkpwKqOZVIQ2TWFIbvdn(Transform), ygm4HTOZ7mvAeg0RonPF(Transform.Dialect, hRPx1LOZG7k3pQXuJ6Ds(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF41BE8), wFcHnNOZACuyllKY6wDx(info)))),
				k7u2dAOZ2xUqcLrHDd8k(PkpwKqOZVIQ2TWFIbvdn(Transform), ygm4HTOZ7mvAeg0RonPF(PkpwKqOZVIQ2TWFIbvdn(Transform), hRPx1LOZG7k3pQXuJ6Ds(lxg4fgOZfsKs9Brpw3c1(0xF400DF8 ^ 0xF40C7E8), info.SubTypeUid))),
				woNvUrOZowF6jIPsVW2m(PkpwKqOZVIQ2TWFIbvdn(Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C667B27)),
				woNvUrOZowF6jIPsVW2m(PkpwKqOZVIQ2TWFIbvdn(Transform), lxg4fgOZfsKs9Brpw3c1(0xA7339EE ^ 0xA736144)),
				k7u2dAOZ2xUqcLrHDd8k(PkpwKqOZVIQ2TWFIbvdn(Transform), ygm4HTOZ7mvAeg0RonPF(Transform.Dialect, hRPx1LOZG7k3pQXuJ6Ds(lxg4fgOZfsKs9Brpw3c1(-642713667 ^ -642761299), rGjB5NOZFhQcR3rseSCL(info)))),
				k7u2dAOZ2xUqcLrHDd8k(PkpwKqOZVIQ2TWFIbvdn(Transform), ((Dialect)PkpwKqOZVIQ2TWFIbvdn(Transform)).QuoteString((string)hRPx1LOZG7k3pQXuJ6Ds(lxg4fgOZfsKs9Brpw3c1(-1430645277 ^ -1430593549), info.SubTypeUid))),
				mZmoLkOZifMYunuFtJXk(select),
				Transform.Dialect.QuoteIfNeeded((string)Is3q6MOZI7JSwlrbj9sn(select)),
				string.Join((string)lxg4fgOZfsKs9Brpw3c1(-398691253 ^ -398648155), select.Joins),
				(twaLJXOZacKWEFwc2oPv(select.Clauses) > 0) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885061207), string.Join((string)lxg4fgOZfsKs9Brpw3c1(-885093259 ^ -885061241), select.Clauses)) : ""
			});
		}
	}

	private bool CheckNeedRecreate()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (gcYlUPOZe40nOj6AJsPf(runtimeApplication.GetType(), QiS2oLOZTY9MJhtudUoX(typeof(RuntimeApplication).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				if (F4GfiXOZNQlYiyapyfqa(runtimeApplication))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
				return GetAddedObservedSubTypeUids().Any();
			}
			break;
		}
		return false;
	}

	private List<Guid> ReadPrevObserveredTypeUids()
	{
		List<Guid> result = new List<Guid>();
		try
		{
			List<Guid> bLOB = DataAccessManager.BLOBManager.GetBLOB<List<Guid>>(uid, key);
			if (bLOB != null)
			{
				return bLOB;
			}
			Transform.ExecuteNonQuery(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539505275), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002088973))));
			return result;
		}
		catch (GenericADOException)
		{
			return result;
		}
	}

	private void SaveObservedTypeUids(List<Guid> uids)
	{
		DataAccessManager.BLOBManager.SetBLOB(uid, key, uids);
	}

	private List<Guid> GetCurrentObservedSubTypeUids()
	{
		List<Guid> obj = currentObservedTypeUids ?? observers.SelectMany((IWorkflowContextPropertyObserver ob) => ob.GetAllBaseObservedSubTypeUids()).Distinct().ToList();
		List<Guid> result = obj;
		currentObservedTypeUids = obj;
		return result;
	}

	private List<Guid> GetPreviousObservedSubTypeUids()
	{
		List<Guid> obj = previousObservedTypeUids ?? ReadPrevObserveredTypeUids();
		List<Guid> result = obj;
		previousObservedTypeUids = obj;
		return result;
	}

	private List<Guid> GetAddedObservedSubTypeUids()
	{
		List<Guid> obj = addedObservedTypeUids ?? GetCurrentObservedSubTypeUids().Except(GetPreviousObservedSubTypeUids()).ToList();
		List<Guid> result = obj;
		addedObservedTypeUids = obj;
		return result;
	}

	internal static bool WX40e0OZD1KvZtEJ0VMj()
	{
		return xrVQnAOZuXCcwigwlH6l == null;
	}

	internal static AbstractObservedContextPropertyUpdateHandler TI1SXVOZnWY9R77qjrda()
	{
		return xrVQnAOZuXCcwigwlH6l;
	}

	internal static object mGZmloOZH7dqDy2vu71V(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object gL8h6oOZLgknNKm1yGD2(object P_0, Type P_1, object P_2)
	{
		return ((ISession)P_0).CreateCriteria(P_1, (string)P_2);
	}

	internal static object lxg4fgOZfsKs9Brpw3c1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GEdw8AOZ98yYIHvxu8iA(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3);
	}

	internal static object skqx8fOZWk3djxt6GwwF(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object lVejlDOZjdqNNQPTjyfa(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static object LVKQRmOZRfaN2lwklddL()
	{
		return Projections.ProjectionList();
	}

	internal static object WNN8RAOZ6fR23NV3eHgk(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object p8DoZPOZqhk1SofV1FAw(object P_0, object P_1, object P_2)
	{
		return ((ProjectionList)P_0).Add((IProjection)P_1, (string)P_2);
	}

	internal static object TsitCoOZ3VQnlgoXXe6O(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static Type QiS2oLOZTY9MJhtudUoX(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object zryrH2OZQLefuRVyq4VT(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static void z6mkW8OZpxW0gdL3hpHy(object P_0, int P_1, object P_2)
	{
		((ITransformationProvider)P_0).ExecuteWithTimeout(P_1, (Action)P_2);
	}

	internal static void zqgv00OZCRQMfAnZ6k1h(object P_0)
	{
		((ITransformationProviderBase)P_0).CommitTransaction();
	}

	internal static void g9O8OlOZMwLMe28HaDlT(object P_0)
	{
		((ITransformationProvider)P_0).RollbackTransaction();
	}

	internal static void iiYTQNOZkrjMbF5bP2it(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static long ttHqGWOZU6TaNLW7qngM(object P_0)
	{
		return ((WorkflowInstanceManager.ContextVarInfo)P_0).ProcessHeaderId;
	}

	internal static object PkpwKqOZVIQ2TWFIbvdn(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static Guid wFcHnNOZACuyllKY6wDx(object P_0)
	{
		return ((ContextVarInfoExt)P_0).EntityTypeUid;
	}

	internal static object hRPx1LOZG7k3pQXuJ6Ds(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object ygm4HTOZ7mvAeg0RonPF(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteString((string)P_1);
	}

	internal static object k7u2dAOZ2xUqcLrHDd8k(object P_0, object P_1)
	{
		return ((Dialect)P_0).CharToGuidFromSqlWithoutQuote((string)P_1);
	}

	internal static object woNvUrOZowF6jIPsVW2m(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static Guid rGjB5NOZFhQcR3rseSCL(object P_0)
	{
		return ((WorkflowInstanceManager.ContextVarInfo)P_0).PropertyUid;
	}

	internal static object mZmoLkOZifMYunuFtJXk(object P_0)
	{
		return ((TableSelect)P_0).Property;
	}

	internal static object Is3q6MOZI7JSwlrbj9sn(object P_0)
	{
		return ((TableSelect)P_0).TableName;
	}

	internal static int twaLJXOZacKWEFwc2oPv(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object R3bWT6OZrOAMoZc4dpOP(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static bool gcYlUPOZe40nOj6AJsPf(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool F4GfiXOZNQlYiyapyfqa(object P_0)
	{
		return ((IRuntimeApplication)P_0).IsFirstServerInCluster;
	}
}
