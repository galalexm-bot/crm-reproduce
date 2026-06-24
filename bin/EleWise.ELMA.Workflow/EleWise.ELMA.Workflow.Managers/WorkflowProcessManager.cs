using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using AutoMapper;
using EleWise.ELMA.Cache;
using EleWise.ELMA.CodeAnalyzers;
using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.CodeAnalyzers;
using EleWise.ELMA.Workflow.CodeGeneration;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Db;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Services;
using EleWise.ELMA.Workflow.Types;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis.Diagnostics;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class WorkflowProcessManager : WorkflowProcessManager<IWorkflowProcess>
{
	private class DictionaryResultTransformer : IResultTransformer
	{
		internal static object qwXNulZCLfB3WRL70TIi;

		public object TransformTuple(object[] tuple, string[] aliases)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 0;
					}
					break;
				default:
					_003C_003Ec__DisplayClass0_.tuple = tuple;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return aliases.Select(_003C_003Ec__DisplayClass0_._003CTransformTuple_003Eb__0).ToDictionary((KeyValuePair<string, object> p) => p.Key, (KeyValuePair<string, object> p) => p.Value);
				}
			}
		}

		public IList TransformList(IList collection)
		{
			return collection;
		}

		public DictionaryResultTransformer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			R8uZYGZCW7HasuZ2hgoB();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool biW98JZCf43Ky0UXVvJZ()
		{
			return qwXNulZCLfB3WRL70TIi == null;
		}

		internal static DictionaryResultTransformer w3wlWNZC9asXRYWVcNMy()
		{
			return (DictionaryResultTransformer)qwXNulZCLfB3WRL70TIi;
		}

		internal static void R8uZYGZCW7HasuZ2hgoB()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static Dictionary<string, ConcurrentDictionary<long, object>> workflowProcessXmlSerializableTypeCaches;

	private readonly object workflowProcessXmlSerializableTypeCachesLock;

	private static WorkflowProcessManager PqtHfl9XyjRI6Ks4wha;

	public new static WorkflowProcessManager Instance => Locator.GetServiceNotNull<WorkflowProcessManager>();

	public static IWorkflowProcessManager GetManager(Type processEntityType)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 8;
		ImplementationUidAttribute attribute = default(ImplementationUidAttribute);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					attribute = AttributeHelper<ImplementationUidAttribute>.GetAttribute(processEntityType, inherited: false);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					throw new InvalidOperationException(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7FC569), JvZ6Jb9H8va9UAuZ0mF(attribute)));
				case 1:
				case 5:
					return (IWorkflowProcessManager)Locator.GetServiceNotNull(HSZOSg99kdRP5oXQtMB(typeof(IWorkflowProcessManager<>).TypeHandle).MakeGenericType(processEntityType));
				case 8:
					break;
				default:
					if (attribute == null)
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				case 6:
					processEntityType = i87FlE9LIRNqnJPZAvR(serviceNotNull, JvZ6Jb9H8va9UAuZ0mF(attribute), false);
					num2 = 2;
					continue;
				case 2:
					if (!GNb5oO9fBPfNgV7bWkP(processEntityType, null))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 7:
					serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
					num2 = 4;
					continue;
				}
				break;
			}
			rIy75s9n0NlYdWa21Oh(processEntityType, rcKd4K9DNLdDnI6QLxt(0x1C7F6FED ^ 0x1C7FC5B3));
			num = 7;
		}
	}

	public static IWorkflowProcessManager<TProcess> GetManager<TProcess>() where TProcess : class, IWorkflowProcess
	{
		return (IWorkflowProcessManager<TProcess>)Locator.GetServiceNotNull(typeof(IWorkflowProcessManager<>).MakeGenericType(typeof(TProcess)));
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_00a9
		int num = 3;
		int num2 = num;
		IWorkflowProcessFilter workflowProcessFilter = default(IWorkflowProcessFilter);
		bool? nonZeroVersion = default(bool?);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (workflowProcessFilter != null)
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
					{
						num2 = 7;
					}
					break;
				}
				return;
			case 3:
				w94EjH9WKyI9k4ysNyr(this, criteria, filter);
				num2 = 2;
				break;
			case 8:
				return;
			case 7:
				nonZeroVersion = workflowProcessFilter.NonZeroVersion;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				flag = true;
				num2 = 4;
				break;
			case 4:
				if (nonZeroVersion == flag)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				jwa0339jWodxGHPCK7n(criteria, Restrictions.Gt(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14388564), (object)0L));
				num2 = 6;
				break;
			case 6:
				return;
			case 2:
				workflowProcessFilter = filter as IWorkflowProcessFilter;
				num2 = 5;
				break;
			}
		}
	}

	public long? GetPublishedVersionId(long headerId)
	{
		string key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111180711) + headerId;
		long? value;
		if (base.CacheService != null)
		{
			long? num = (value = base.CacheService.Get<long?>(key));
			if (num.HasValue)
			{
				goto IL_0086;
			}
		}
		value = base.ProcessHeaderManager.Load(headerId).Published?.Id ?? (-1);
		if (base.CacheService != null)
		{
			base.CacheService.Insert(key, value);
		}
		goto IL_0086;
		IL_0086:
		if (!value.HasValue || value.Value <= 0)
		{
			return null;
		}
		return value.Value;
	}

	public IEnumerable<ProcessMetricsContainer> GetPublishedProcessMetrics()
	{
		ICriteria val = CreateCriteria();
		val.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516546692), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498834183));
		val.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516529900), (object)WorkflowProcessStatus.Deleted)));
		val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F6ADD0)));
		val.Add((ICriterion)(object)Restrictions.EqProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895887439), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x68374C)));
		val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12FC85E)));
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539445123)) });
		return val.List<ProcessMetricsContainer>();
	}

	internal void LoadWorkflowProcessXmlSerializableTypes(IWorkflowProcess process)
	{
		//Discarded unreachable code: IL_00c2, IL_0197, IL_01cf, IL_01de
		int num = 1;
		int num2 = num;
		object obj = default(object);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 7:
				obj = workflowProcessXmlSerializableTypeCachesLock;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				_003C_003Ec__DisplayClass10_.process = process;
				num2 = 4;
				continue;
			case 2:
				lockTaken = false;
				num2 = 5;
				continue;
			case 1:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							if (workflowProcessXmlSerializableTypeCaches == null)
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						case 1:
							workflowProcessXmlSerializableTypeCaches = ((ComponentManager)hKsMrc9RVuCIiP3GU32()).GetExtensionPoints<IWorkflowProcessXmlSerializableType>().Cast<WorkflowProcessXmlSerializableType>().ToDictionary((WorkflowProcessXmlSerializableType p) => (string)_003C_003Ec.dCRZ08ZCpZ85wqUhIse5(p), (WorkflowProcessXmlSerializableType p) => p.DataCache);
							num3 = 2;
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								Monitor.Exit(obj);
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
								{
									num4 = 0;
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
			case 4:
				if (workflowProcessXmlSerializableTypeCaches == null)
				{
					num2 = 7;
					continue;
				}
				break;
			case 3:
				return;
			case 6:
				break;
			}
			((ICriteria)o7lgTr9Tr8jwMPAllwt(fUJVrK93R78XhXtighB(jwa0339jWodxGHPCK7n(Jks1s796doeapCPOZkv(this, null), rEv6xS9qX6oJbyq3Sja(_003C_003Ec__DisplayClass10_.process.Id)), (from p in workflowProcessXmlSerializableTypeCaches.Where(_003C_003Ec__DisplayClass10_._003CLoadWorkflowProcessXmlSerializableTypes_003Eb__0)
				select ((SimpleProjection)Projections.Property(p.Key)).As(p.Key)).ToArray()), new DictionaryResultTransformer())).UniqueResult<Dictionary<string, object>>().ForEach(_003C_003Ec__DisplayClass10_._003CLoadWorkflowProcessXmlSerializableTypes_003Eb__2);
			num2 = 3;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal IEnumerable<ProcessWithScriptModuleWrapper> GetProcessesWithClientScriptModules()
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-961162596 ^ -961185408))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F2E16)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74ABEC53)).Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B5B3D1)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148469283))
			.Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF401D60)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x350CF72)) }).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessWithScriptModuleWrapper)))
			.List<ProcessWithScriptModuleWrapper>();
	}

	internal IEnumerable<IWorkflowProcess> GetProcessesWithClientScriptAndForms()
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA5A4D0))).Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614C5EE1))).List<IWorkflowProcess>();
	}

	public WorkflowProcessManager()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		qpEIMF9Q8k4Tt4Vgn5u();
		workflowProcessXmlSerializableTypeCachesLock = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object rcKd4K9DNLdDnI6QLxt(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void rIy75s9n0NlYdWa21Oh(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Guid JvZ6Jb9H8va9UAuZ0mF(object P_0)
	{
		return ((ImplementationUidAttribute)P_0).Uid;
	}

	internal static Type i87FlE9LIRNqnJPZAvR(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataRuntimeService)P_0).GetTypeByUid(P_1, P_2);
	}

	internal static bool GNb5oO9fBPfNgV7bWkP(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type HSZOSg99kdRP5oXQtMB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool IiNtB79du0aEqwxVOpl()
	{
		return PqtHfl9XyjRI6Ks4wha == null;
	}

	internal static WorkflowProcessManager y1RGeA9uNMV3JGYb2dV()
	{
		return PqtHfl9XyjRI6Ks4wha;
	}

	internal static void w94EjH9WKyI9k4ysNyr(object P_0, object P_1, object P_2)
	{
		((WorkflowProcessManager<IWorkflowProcess>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static object jwa0339jWodxGHPCK7n(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object hKsMrc9RVuCIiP3GU32()
	{
		return ComponentManager.Current;
	}

	internal static object Jks1s796doeapCPOZkv(object P_0, object P_1)
	{
		return ((EntityManager<IWorkflowProcess, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object rEv6xS9qX6oJbyq3Sja(object P_0)
	{
		return Restrictions.IdEq(P_0);
	}

	internal static object fUJVrK93R78XhXtighB(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static object o7lgTr9Tr8jwMPAllwt(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static void qpEIMF9Q8k4Tt4Vgn5u()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
[DeveloperApi(DeveloperApiType.Manager)]
public abstract class WorkflowProcessManager<TProcess> : EntityManager<TProcess, long>, IWorkflowProcessManager<TProcess>, IWorkflowProcessManager where TProcess : class, IWorkflowProcess
{
	private static IWorkflowProcessDependencyService workflowProcessDependencyService;

	protected const string CacheKeyPublishedId = "WorkflowProcess_PublishedId_";

	protected const string CacheKeyLastPublishTime = "WorkflowProcess_LastPublishTime";

	private static object QPZ2Je9p24G3suT1den;

	public new IAuthenticationService AuthenticationService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationService_003Ek__BackingField;
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
					_003CAuthenticationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ProcessHeaderManager ProcessHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderManager_003Ek__BackingField;
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
					_003CProcessHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
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

	public ITransformationProvider Transform
	{
		[CompilerGenerated]
		get
		{
			return _003CTransform_003Ek__BackingField;
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
					_003CTransform_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public new ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	public ICacheService CacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CCacheService_003Ek__BackingField;
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
					_003CCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public new IUnitOfWorkManager UnitOfWorkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUnitOfWorkManager_003Ek__BackingField;
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
					_003CUnitOfWorkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<IFormDependencyExtension> FormDependencyExtensions { get; set; }

	public IWorkWithFormDependeciesService WorkWithFormDependeciesService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkWithFormDependeciesService_003Ek__BackingField;
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
					_003CWorkWithFormDependeciesService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IWorkflowMetadataLoaderService WorkflowMetadataLoaderService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowMetadataLoaderService_003Ek__BackingField;
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
					_003CWorkflowMetadataLoaderService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
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

	public IEnumerable<IWorkflowClientScriptModuleExtensions> WorkflowClientScriptModuleExtensions { get; set; }

	public ISearchMetadataService SearchMetadataService
	{
		[CompilerGenerated]
		get
		{
			return _003CSearchMetadataService_003Ek__BackingField;
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
					_003CSearchMetadataService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private static IWorkflowProcessDependencyService WorkflowProcessDependencyService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IWorkflowProcessDependencyService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = workflowProcessDependencyService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (workflowProcessDependencyService = Locator.GetServiceNotNull<IWorkflowProcessDependencyService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	public void RenameItem(long id, long? draftId, string name)
	{
		((IQuery)base.Session.CreateSQLQuery(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F5076), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6C3810)), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682893842)), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105845052))))).SetParameter<string>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7FC3CD), name).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x1017D3D), id).SetParameter<long?>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF65DB0), draftId)
			.ExecuteUpdate(cleanUpCache: false);
		base.Session.CleanUpCache(InterfaceActivator.TypeOf<IWorkflowProcess>());
	}

	public DateTime GetLastPublishTime()
	{
		int num = 1;
		int num2 = num;
		DateTime? bLOB = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return DateTime.MinValue;
			case 1:
				bLOB = DataAccessManager.BLOBManager.GetBLOB<DateTime?>(__AssemblyInfo.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935269107));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (bLOB.HasValue)
			{
				return bLOB.GetValueOrDefault();
			}
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal void UpdateLastPublishTime()
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
				DataAccessManager.BLOBManager.SetBLOB(__AssemblyInfo.UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E9DD0D), DateTime.Now);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public override TProcess Load(long id)
	{
		TProcess val = base.Load(id);
		if (val != null)
		{
			return val.CastAsRealType();
		}
		return null;
	}

	public virtual TProcess LoadAsDraft(long id)
	{
		TProcess val = Load(id);
		WorkflowProcessDTO workflowProcessDTO = val.CastAsRealType().CreateDTO();
		WorkflowProcessDTO workflowProcessDTO2 = ((TProcess)val.Header.Current).CastAsRealType().CreateDTO();
		workflowProcessDTO.CopyIdsFrom(workflowProcessDTO2);
		workflowProcessDTO.Description = workflowProcessDTO2.Description;
		workflowProcessDTO.ParentId = workflowProcessDTO2.ParentId;
		TProcess obj = (TProcess)workflowProcessDTO.CreateEntity();
		obj.Save();
		return obj;
	}

	public virtual WorkflowProcessDTO LoadDraft(long id)
	{
		return Load(id).CastAsRealType().CreateDTO();
	}

	[PublicApiMember]
	public override void Save(TProcess process)
	{
		Contract.ArgumentNotNull(process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x141D91A));
		Contract.ArgumentNotNull(process.Header, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614C5173));
		Contract.ArgumentNotNull(process.Context, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6DD7D2));
		process.CreationDate = DateTime.Now;
		process.CreationAuthor = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (process.Header.Id <= 0)
		{
			process.Header.CreationDate = DateTime.Now;
			process.Header.CreationAuthor = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		}
		if (string.IsNullOrEmpty(process.Context.TableName))
		{
			process.Header.Save();
			process.Context.TableName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111179229) + process.Header.Id;
		}
		process.Context.Assembly = null;
		if (process.Parent != null)
		{
			process.Header.Parent = process.Parent.Header;
			process.Header.Save();
		}
		process.Header.Current = process;
		process.Header.IsDirtyProcess = true;
		base.Save(process);
		if (!WorkWithFormDependeciesService.IsActive())
		{
			IFormDependencyExtension formDependencyExtension = FormDependencyExtensions.FirstOrDefault((IFormDependencyExtension q) => q is WorkflowFormDependencyExtension);
			if (formDependencyExtension != null)
			{
				formDependencyExtension.GenerateNewDependencies(process.Uid);
				WorkflowProcessDependencyService.CollectDependencies(process);
			}
		}
	}

	[Transaction]
	public virtual void RecompileContext(TProcess process)
	{
		TProcess val = (TProcess)process.CastAsRealType().CreateDTO().CreateEntity();
		WorkflowProcessPublishingData workflowProcessPublishingData = new WorkflowProcessPublishingData();
		RecompileContext(val, null, workflowProcessPublishingData);
		BuildContextAssembly(val.Context, workflowProcessPublishingData.Context);
	}

	[Transaction]
	public virtual void Publish(TProcess process, long versionNumber, IWorkflowProcess parentProcess, string comment, bool isEmulation)
	{
		WorkflowProcessPublishingData workflowProcessPublishingData = new WorkflowProcessPublishingData();
		if (process.Header.Context != null && process.Header.Context.AssemblyRaw != null && process.Header.Context.AssemblyRaw.Length != 0)
		{
			CopyContextToDeletedSubHeaders(process.Header, process.Header.Context.AssemblyRaw, process.Header.Context.AssemblyName);
		}
		TProcess val = Publish(process, versionNumber, parentProcess, comment, isEmulation, workflowProcessPublishingData);
		BuildContextAssembly(val.Header.Context, workflowProcessPublishingData.FullContext);
		BuildContextAssembly(val.Context, workflowProcessPublishingData.Context);
		if (val.Context.AssemblyRaw != null && val.Context.AssemblyRaw.Length != 0)
		{
			workflowProcessPublishingData.ScriptCompiler.AddReference(val.Context.AssemblyRaw);
		}
		CompileScriptsAndProcessResults(workflowProcessPublishingData.ScriptCompiler, val);
	}

	public virtual TProcess Publish(TProcess process, long versionNumber, IWorkflowProcess parentProcess, string comment, bool isEmulation, WorkflowProcessPublishingData data)
	{
		Contract.ArgumentNotNull(process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1001963758));
		Contract.ArgumentNotNull(process.Header, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F80AB41));
		Contract.ArgumentNotNull(process.Context, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B615217));
		try
		{
			WorkflowProcessDTO workflowProcessDTO = process.CastAsRealType().CreateDTO();
			workflowProcessDTO.Parent = data?.ParentProcessDTO;
			ProcessValidatorAttribute attribute = AttributeHelper<ProcessValidatorAttribute>.GetAttribute(workflowProcessDTO.GetType(), inherited: true);
			WorkflowProcessValidator obj = ((attribute != null) ? ((WorkflowProcessValidator)Activator.CreateInstance(attribute.ValidatorType, workflowProcessDTO)) : new WorkflowProcessValidator(workflowProcessDTO));
			obj.Validate();
			if (obj.HasErrors)
			{
				throw new ProcessPublishingException(process.Header.Id, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077808012), process.Header.Name));
			}
			workflowProcessDTO.CopyIdsFrom(null);
			TProcess val = (TProcess)workflowProcessDTO.CreateEntity();
			val.CreationDate = ((parentProcess != null) ? parentProcess.CreationDate : new DateTime?(DateTime.Now));
			val.VersionNumber = versionNumber;
			val.Description = comment;
			val.Parent = parentProcess;
			if (parentProcess != null && !((ICollection<IWorkflowProcess>)parentProcess.SubProcesses).Contains((IWorkflowProcess)val))
			{
				parentProcess.SubProcesses.Add((IWorkflowProcess)val);
			}
			PublishEntity(val, parentProcess, isEmulation, data);
			foreach (IProcessHeader item in (IEnumerable<IProcessHeader>)process.Header.SubHeaders)
			{
				if (item.Status == WorkflowProcessStatus.Deleted || item.Current == null)
				{
					continue;
				}
				IWorkflowProcessManager manager = WorkflowProcessManager.GetManager(item.Current.GetType().GetTypeWithoutProxy());
				WorkflowProcessDTO parentProcessDTO = data?.ParentProcessDTO;
				if (data != null)
				{
					data.ParentProcessDTO = workflowProcessDTO;
				}
				try
				{
					manager.Publish(item.Current, versionNumber, val, comment, isEmulation, data);
				}
				finally
				{
					if (data != null)
					{
						data.ParentProcessDTO = parentProcessDTO;
					}
				}
			}
			return val;
		}
		catch (Exception ex)
		{
			if (ex is ProcessPublishingException)
			{
				throw;
			}
			TypeNotFoundException ex3 = ((ex is CodeGenerationException ex2) ? (ex2.InnerException as TypeNotFoundException) : (ex as TypeNotFoundException));
			if (ex3 != null)
			{
				IMetadataItemHeader metadataItemHeader = EntityManager<IMetadataItemHeader>.Instance.LoadOrNull(ex3.TypeUid);
				if (metadataItemHeader != null)
				{
					if (metadataItemHeader.Published == null)
					{
						throw new ProcessPublishingException(process.Header.Id, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716584974), metadataItemHeader.DisplayName));
					}
					if (Locator.GetServiceNotNull<IModelManager>().GetRestartRequiredMetadataUids().Contains(metadataItemHeader.Uid))
					{
						throw new ProcessPublishingException(process.Header.Id, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD30F15A), metadataItemHeader.DisplayName));
					}
				}
			}
			throw new ProcessPublishingException(process.Header.Id, ex);
		}
	}

	public virtual List<WorkflowProcessHistoryItem> LoadHistory(long processHeadId)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(processHeadId);
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763678055), (object)processHeader)).AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C66A031))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)GetProjectionProperties<WorkflowProcessHistoryItem>() })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(WorkflowProcessHistoryItem)))
			.List<WorkflowProcessHistoryItem>()
			.ToList();
	}

	public virtual List<WorkflowProcessHistoryItem> LoadHistoryByProcessIdArray(long[] processIds)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x7381B7ED), (ICollection)processIds)).AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EA165A))).AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213FF9E7)))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)GetProjectionProperties<WorkflowProcessHistoryItem>() })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(WorkflowProcessHistoryItem)))
			.List<WorkflowProcessHistoryItem>()
			.ToList();
	}

	public virtual IEnumerable<IResponsibilityMatrixItem> GetResponsibilityMatrixItems(IWorkflowProcess process, EleWise.ELMA.Security.Models.IUser user = null)
	{
		_003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_0();
		Contract.ArgumentNotNull(process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246EFFEA));
		IBPMNProcess obj = (process.CastAsRealType() as IBPMNProcess) ?? throw new ArgumentException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716584776));
		CS_0024_003C_003E8__locals0.infos = GetResponsibilityMatrixItems(new List<IWorkflowProcess> { process }, user);
		return ((IEnumerable<IResponsibilityMatrixItem>)obj.ResponsibilityMatrix).Where(delegate(IResponsibilityMatrixItem i)
		{
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass57_1 _003C_003Ec__DisplayClass57_ = default(_003C_003Ec__DisplayClass57_1);
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_1();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass57_.i = i;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return CS_0024_003C_003E8__locals0.infos.Any(_003C_003Ec__DisplayClass57_._003CGetResponsibilityMatrixItems_003Eb__1);
				}
			}
		}).ToList();
	}

	public virtual IEnumerable<ProcessResponsibilityItemInfo> GetResponsibilityMatrixItems(List<IWorkflowProcess> process, EleWise.ELMA.Security.Models.IUser user = null)
	{
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361013329)).SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC02DED), (IEnumerable)process.ToArray()).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213F0FAF), InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false))
			.SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC6620C), InterfaceActivator.UID<IUserGroup>(loadImplementation: false))
			.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F739E5), (IEnumerable)new long[1] { user?.Id ?? AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessResponsibilityItemInfo)))
			.CleanUpCache(cleanUpCache: false)
			.List<ProcessResponsibilityItemInfo>();
	}

	public virtual List<Guid> GetVisiblePropertyUids(IWorkflowProcess process)
	{
		_003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass59_0();
		Contract.ArgumentNotNull(process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1927CAE1));
		if (ProcessHeaderManager.IsOwner(process.Header) || ProcessHeaderManager.IsCurator(process.Header) || SecurityService.HasPermission(WorkflowPermissionProvider.ProcessMonitor, process.Header) || SecurityService.HasPermission(WorkflowPermissionProvider.FullMonitorAccessPermission))
		{
			return null;
		}
		if (process.ContextViewScheme == null)
		{
			return null;
		}
		IEnumerable<IResponsibilityMatrixItem> responsibilityMatrixItems = GetResponsibilityMatrixItems(process);
		responsibilityMatrixItems = responsibilityMatrixItems.Where((IResponsibilityMatrixItem i) => !i.IsDynamic);
		CS_0024_003C_003E8__locals0.swimlaneUids = (from uid in responsibilityMatrixItems.Where(delegate(IResponsibilityMatrixItem i)
			{
				int num3 = 1;
				int num4 = num3;
				Guid? swimlaneUid2 = default(Guid?);
				while (true)
				{
					switch (num4)
					{
					default:
						return swimlaneUid2.HasValue;
					case 1:
						swimlaneUid2 = i.SwimlaneUid;
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			}).Select(delegate(IResponsibilityMatrixItem r)
			{
				int num = 1;
				int num2 = num;
				Guid? swimlaneUid = default(Guid?);
				while (true)
				{
					switch (num2)
					{
					case 1:
						swimlaneUid = r.SwimlaneUid;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return swimlaneUid.Value;
					}
				}
			})
			where uid != Guid.Empty
			select uid).Distinct().ToList();
		return (from i in process.ContextViewScheme.Swimlanes.Where((SwimlaneContextViewScheme s) => CS_0024_003C_003E8__locals0.swimlaneUids.Contains(s.SwimlaneUid)).Union(new SwimlaneContextViewScheme[1] { process.ContextViewScheme.Default }).SelectMany((SwimlaneContextViewScheme s) => s.Items)
			select i.PropertyUid).Distinct().ToList();
	}

	[Transaction]
	public virtual ScriptModule LoadScriptModuleForEdit(long processId)
	{
		//Discarded unreachable code: IL_0074
		int num = 6;
		TProcess val = default(TProcess);
		ScriptModuleDTO scriptModuleDTO = default(ScriptModuleDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (val.ScriptModule == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					if (val.ScriptModule.Draft != null)
					{
						num2 = 2;
						continue;
					}
					goto case 9;
				case 9:
					scriptModuleDTO = Mapper.Map<ScriptModule, ScriptModuleDTO>(val.ScriptModule, new ScriptModuleDTO());
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				case 8:
					return val.ScriptModule.Draft;
				case 6:
					val = Load(processId);
					num2 = 5;
					continue;
				case 3:
					scriptModuleDTO.Id = 0L;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					break;
				case 7:
					throw new InvalidOperationException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495259528) + processId);
				default:
					val.ScriptModule.Draft.Uid = Guid.NewGuid();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					val.ScriptModule.Draft = Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModuleDTO, new ScriptModule());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			val.ScriptModule.Draft.Save();
			num = 8;
		}
	}

	[Transaction]
	public virtual void PublishScriptModule(long processId, ScriptModule draftScriptModule)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_00cb, IL_00da
		int num = 6;
		int num2 = num;
		TProcess val2 = default(TProcess);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
			case 5:
				if (val2.Parent != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
			case 7:
				val2 = (TProcess)val2.Parent;
				num2 = 2;
				break;
			case 4:
				CompileScripts(val2);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num2 = 3;
				}
				break;
			default:
				ApplyDraftScriptModule(val2);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
			{
				TProcess val = Load(processId);
				if (val.ScriptModule == null)
				{
					throw new InvalidOperationException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720494609) + processId);
				}
				val2 = val;
				num2 = 5;
				break;
			}
			}
		}
	}

	public virtual IEnumerable<TProcess> FindAllByHeader(long[] headers)
	{
		ICriteria obj = CreateCriteria();
		obj.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F06B7A), (ICollection)headers));
		return obj.List<TProcess>();
	}

	public virtual ChangeProcessVersionValidationResult ValidateChangeVersion(IWorkflowProcess oldProcess, IWorkflowProcess newProcess, Guid[] activeElementUids)
	{
		return new ChangeProcessVersionValidationResult();
	}

	protected virtual void PublishEntity(TProcess process, IWorkflowProcess parentProcess, bool isEmulation, WorkflowProcessPublishingData data)
	{
		process.CreationAuthor = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		process.Uid = Guid.NewGuid();
		process.ScriptModule.Uid = Guid.NewGuid();
		process.ScriptModule.ObjectUid = process.Uid;
		if (process.ClientScriptModule != null)
		{
			process.ClientScriptModule.Uid = Guid.NewGuid();
			process.ClientScriptModule.ObjectUid = process.Uid;
		}
		if (process.Parent != null)
		{
			process.Context.BaseClassUid = process.Parent.Context.Uid;
		}
		process.Context.CreateAndCheckDefaultProperties();
		if (process.InstanceMetrics != null)
		{
			process.InstanceMetrics.CreateAndCheckDefaultProperties();
		}
		if (process.Header.Id <= 0)
		{
			process.Header.Save();
		}
		if (process.Header.Context == null)
		{
			process.Header.Context = new ProcessContext
			{
				DisplayName = process.Context.DisplayName
			};
		}
		ProcessContext context = process.Header.Context;
		bool flag = process.ProcessMetrics != null && ((IEnumerable)process.ProcessMetrics.EntityProperties).OfType<ProcessMetric>().Any((ProcessMetric p) => !p.IsSystem);
		if (process.Header.ProcessMetrics == null && flag)
		{
			process.Header.ProcessMetrics = new ProcessMetricsContainer
			{
				DisplayName = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1001946738), process.Header.Name)
			};
		}
		ProcessMetricsContainer processMetrics = process.Header.ProcessMetrics;
		if (process.ProcessMetrics != null && string.IsNullOrEmpty(process.ProcessMetrics.Name))
		{
			process.ProcessMetrics.Name = process.Context.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F53E542);
		}
		if (process.ProcessMetrics != null && string.IsNullOrEmpty(process.ProcessMetrics.TableName))
		{
			process.ProcessMetrics.TableName = ((process.Context.TableName.Length > 25) ? process.Context.TableName.Substring(0, 25) : process.Context.TableName) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002108171);
		}
		if (process.ProcessMetrics != null && string.IsNullOrEmpty(process.ProcessMetrics.Namespace))
		{
			process.ProcessMetrics.Namespace = process.Context.Namespace;
		}
		bool flag2 = process.InstanceMetrics != null && ((IEnumerable)process.InstanceMetrics.EntityProperties).OfType<ProcessInstanceMetric>().Any((ProcessInstanceMetric p) => !p.IsSystem);
		if (process.Header.InstanceMetrics == null && flag2)
		{
			process.Header.InstanceMetrics = new ProcessInstanceMetricsContainer
			{
				DisplayName = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F80A073), process.Header.Name)
			};
		}
		ProcessInstanceMetricsContainer instanceMetrics = process.Header.InstanceMetrics;
		if (process.InstanceMetrics != null && string.IsNullOrEmpty(process.InstanceMetrics.Name))
		{
			process.InstanceMetrics.Name = process.Context.TableName + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F80A02B);
		}
		if (process.InstanceMetrics != null && string.IsNullOrEmpty(process.InstanceMetrics.TableName))
		{
			process.InstanceMetrics.TableName = ((process.Context.TableName.Length > 25) ? process.Context.TableName.Substring(0, 25) : process.Context.TableName) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980607148);
		}
		if (process.InstanceMetrics != null && string.IsNullOrEmpty(process.InstanceMetrics.Namespace))
		{
			process.InstanceMetrics.Namespace = process.Context.Namespace;
		}
		foreach (IProcessPublicationHandler item in Locator.GetServiceNotNull<IEnumerable<IProcessPublicationHandler>>())
		{
			item.UpdateProcess(process);
		}
		PublishFullContext(process.Header, process.Context, context, parentProcess?.Header.Context);
		PublishFullContext(process.Header, process.ProcessMetrics, processMetrics, parentProcess?.Header.ProcessMetrics);
		PublishFullContext(process.Header, process.InstanceMetrics, instanceMetrics, parentProcess?.Header.InstanceMetrics);
		CheckDeletedProperties(process, process.Context, context);
		base.Session.SaveOrUpdate((object)process);
		DateTime now = DateTime.Now;
		GenerateFullContextAssembly(process.Header, context, parentProcess?.Header.Context, process.Header.ProcessMetrics, process.Header.InstanceMetrics, data);
		base.Logger.Info(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36168785) + (int)(DateTime.Now - now).TotalMilliseconds + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738A15D6));
		if (process.Context.ViewModelMetadata != null)
		{
			process.Context.ViewModelMetadata.TypeRef = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682937184), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949691413), process.Header.Id, process.VersionNumber);
		}
		now = DateTime.Now;
		GenerateContextAssembly(process.Header, process.Context, process.ProcessMetrics, process.InstanceMetrics, parentProcess, data);
		base.Logger.Info(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25748470) + (int)(DateTime.Now - now).TotalMilliseconds + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10386687));
		PrepareScriptsCompilation(process, data.ScriptCompiler, recursiveByChild: false);
		process.ScriptModule.Save();
		process.ClientScriptModule?.Save();
		process.Header.Context.Save();
		process.Header.PublishedEmulation = process;
		if (!isEmulation)
		{
			process.Header.Published = process;
			process.Header.Status = WorkflowProcessStatus.Published;
			if (UnitOfWorkManager != null && CacheService != null)
			{
				_003C_003Ec__DisplayClass66_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass66_0();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				CS_0024_003C_003E8__locals0.cacheKey = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712470643) + process.Header.Id;
				CS_0024_003C_003E8__locals0.publishedId = process.Id;
				UnitOfWorkManager.RegisterPostCommitAction(delegate
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
							CS_0024_003C_003E8__locals0._003C_003E4__this.CacheService.Insert(CS_0024_003C_003E8__locals0.cacheKey, CS_0024_003C_003E8__locals0.publishedId);
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
							{
								num2 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
			}
			UpdateLastPublishTime();
		}
		process.Header.IsDirtyProcess = false;
		process.Header.Save();
	}

	protected virtual void CompileScripts(TProcess process)
	{
		if (process == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A69D5BF));
		}
		TProcess val = process;
		while (val.Parent != null)
		{
			val = (TProcess)val.Parent;
		}
		ProcessScriptCompiler scriptCompiler = new ProcessScriptCompiler();
		PrepareScriptsCompilation(val, scriptCompiler, recursiveByChild: true);
		CompileScriptsAndProcessResults(scriptCompiler, val);
	}

	protected virtual void PrepareScriptsCompilation(TProcess process, ProcessScriptCompiler scriptCompiler, bool recursiveByChild)
	{
		_003C_003Ec__DisplayClass68_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass68_0();
		CS_0024_003C_003E8__locals0.process = process;
		ProcessContext context = CS_0024_003C_003E8__locals0.process.Context;
		if (context.AssemblyRaw != null && context.AssemblyRaw.Length != 0)
		{
			scriptCompiler.AddReference(context.AssemblyRaw);
		}
		foreach (DataClassAssemblyInfo publishedDataClassAssembly in SearchMetadataService.GetPublishedDataClassAssemblies())
		{
			scriptCompiler.AddReference(publishedDataClassAssembly.AssemblyRaw);
		}
		if (CS_0024_003C_003E8__locals0.process.ScriptModule != null)
		{
			CS_0024_003C_003E8__locals0.process.ScriptModule.Uid = Guid.NewGuid();
			string text = CS_0024_003C_003E8__locals0.process.ScriptModule.Uid.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498856495));
			CS_0024_003C_003E8__locals0.process.ScriptModule.AssemblyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559BD9C0) + text;
			CS_0024_003C_003E8__locals0.process.ScriptModule.AssemblyRaw = null;
			scriptCompiler.Modules.Add(CS_0024_003C_003E8__locals0.process.ScriptModule);
			if (context.ViewModelMetadata != null)
			{
				List<ProcessContext> list = new List<ProcessContext>();
				IWorkflowProcess workflowProcess = CS_0024_003C_003E8__locals0.process;
				do
				{
					if (workflowProcess?.Header?.Current?.Context != null)
					{
						list.Add(workflowProcess.Header.Current.Context);
					}
					if (workflowProcess?.Context != null)
					{
						list.Add(workflowProcess.Context);
					}
					workflowProcess = workflowProcess.Parent;
				}
				while (workflowProcess != null);
				using (MetadataServiceContext.Extend(list))
				{
					ICodeGenerator codeGenerator = new ProcessContextScriptGenerator(MetadataServiceContext.Service);
					codeGenerator.Metadata = context;
					codeGenerator.GenerationParams.FileName = context.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438A46B3);
					codeGenerator.GenerationParams.Namespace = context.Namespace;
					string @string = Encoding.UTF8.GetString(codeGenerator.GenerateMainFile().Data);
					scriptCompiler.AddSourceCode(@string);
				}
				using (MetadataServiceContext.Extend(SearchMetadataService.GetPublishedDataClasses()))
				{
					WorkflowClientScriptModuleExtensions.ForEach(delegate(IWorkflowClientScriptModuleExtensions ext)
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
								ext.BuildClientProcessContextScript(CS_0024_003C_003E8__locals0.process);
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
								{
									num2 = 0;
								}
								break;
							}
						}
					});
				}
			}
		}
		if (!recursiveByChild)
		{
			return;
		}
		foreach (IWorkflowProcess item in (IEnumerable<IWorkflowProcess>)CS_0024_003C_003E8__locals0.process.SubProcesses)
		{
			PrepareScriptsCompilation((TProcess)item, scriptCompiler, recursiveByChild);
		}
	}

	protected void GenerateFullContextAssembly(IProcessHeader header, ProcessContext context, ProcessContext parentContext, ProcessMetricsContainer processMetrics, ProcessInstanceMetricsContainer instanceMetrics, WorkflowProcessPublishingData data)
	{
		//Discarded unreachable code: IL_00c6, IL_01fc, IL_0252, IL_02ab, IL_02ba
		int num = 14;
		WorkflowProcessBuilderData fullContext = default(WorkflowProcessBuilderData);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 10:
					if (instanceMetrics == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 13:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642758781));
				case 21:
					fullContext.MetadataToAdd.Add(new Tuple<IMetadata, GenerationParams>(context, new ProcessContextGenerationParams
					{
						ProcessHeader = header,
						IsFullContext = true,
						ParentContext = parentContext
					}));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					if (processMetrics == null)
					{
						num2 = 10;
						continue;
					}
					goto case 7;
				case 3:
					break;
				case 5:
					fullContext.MetadataToAdd.Add(new Tuple<IMetadata, GenerationParams>(instanceMetrics, new ProcessContextGenerationParams
					{
						ProcessHeader = header,
						IsFullContext = true
					}));
					num2 = 8;
					continue;
				case 18:
					context.Filterable = false;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					context.Namespace = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43969435);
					num2 = 18;
					continue;
				case 12:
					context.AssemblyRaw = null;
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 20;
					}
					continue;
				case 1:
					return;
				case 8:
					return;
				case 17:
				case 19:
					if (instanceMetrics != null)
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 21;
				default:
					fullContext.MetadataToRegister.Add(context);
					num2 = 2;
					continue;
				case 7:
					fullContext.MetadataToAdd.Add(new Tuple<IMetadata, GenerationParams>(processMetrics, new ProcessContextGenerationParams
					{
						ProcessHeader = header,
						IsFullContext = true
					}));
					num2 = 4;
					continue;
				case 9:
					context.AssemblyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111182107) + context.Uid.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303629866));
					num2 = 12;
					continue;
				case 2:
					if (processMetrics == null)
					{
						num2 = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					break;
				case 11:
					fullContext.MetadataToRegister.Add(instanceMetrics);
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
					{
						num2 = 21;
					}
					continue;
				case 15:
					throw new ArgumentException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EAE09E));
				case 16:
					fullContext = data.FullContext;
					num2 = 9;
					continue;
				case 14:
					if (data != null)
					{
						if (data.FullContext != null)
						{
							num2 = 16;
							continue;
						}
						goto case 15;
					}
					num2 = 13;
					continue;
				}
				break;
			}
			fullContext.MetadataToRegister.Add(processMetrics);
			num = 17;
		}
	}

	protected void GenerateContextAssembly(IProcessHeader header, ProcessContext context, ProcessMetricsContainer processMetrics, ProcessInstanceMetricsContainer instanceMetrics, IWorkflowProcess parentProcess, WorkflowProcessPublishingData data)
	{
		//Discarded unreachable code: IL_0115, IL_0124, IL_01b2, IL_0202, IL_0212, IL_0221, IL_022c, IL_037e, IL_038d, IL_056f, IL_05a7, IL_0641, IL_078d
		int num = 9;
		int num2 = num;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		List<IWorkflowProcess> list2 = default(List<IWorkflowProcess>);
		IEnumerator<PropertyMetadata> enumerator = default(IEnumerator<PropertyMetadata>);
		PropertyMetadata current = default(PropertyMetadata);
		IEnumerable<IWorkflowProcess> source2 = default(IEnumerable<IWorkflowProcess>);
		_003C_003Ec__DisplayClass70_1 _003C_003Ec__DisplayClass70_2 = default(_003C_003Ec__DisplayClass70_1);
		_003C_003Ec__DisplayClass70_0 _003C_003Ec__DisplayClass70_ = default(_003C_003Ec__DisplayClass70_0);
		IEnumerable<IWorkflowProcess> source = default(IEnumerable<IWorkflowProcess>);
		WorkflowProcessBuilderData context2 = default(WorkflowProcessBuilderData);
		ProcessContext parentContext = default(ProcessContext);
		List<EntityMetadata> list = default(List<EntityMetadata>);
		while (true)
		{
			switch (num2)
			{
			case 37:
				context.AssemblyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACC713F) + context.Uid.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246E5F8E));
				num2 = 13;
				break;
			case 13:
				context.AssemblyRaw = null;
				num2 = 18;
				break;
			case 32:
				if (instanceMetrics == null)
				{
					num2 = 30;
					break;
				}
				goto case 28;
			case 8:
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F7E5CB));
			case 7:
				if (processMetrics != null)
				{
					num2 = 40;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 23;
					}
					break;
				}
				goto case 32;
			case 30:
				return;
			case 16:
				workflowProcess = workflowProcess.Parent;
				num2 = 14;
				break;
			case 34:
				if (instanceMetrics == null)
				{
					num2 = 5;
					break;
				}
				goto case 36;
			case 2:
				list2 = null;
				num2 = 31;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
				{
					num2 = 38;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_0523:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
							{
								num3 = 1;
							}
							goto IL_0230;
						}
						goto IL_02dc;
						IL_02dc:
						current = enumerator.Current;
						num3 = 5;
						goto IL_0230;
						IL_0230:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 11:
								source2 = list2.Where(_003C_003Ec__DisplayClass70_2._003CGenerateContextAssembly_003Eb__5);
								num3 = 8;
								continue;
							case 2:
								_003C_003Ec__DisplayClass70_ = new _003C_003Ec__DisplayClass70_0();
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
								{
									num3 = 12;
								}
								continue;
							case 7:
								_003C_003Ec__DisplayClass70_2.prop1 = current;
								num3 = 11;
								continue;
							case 3:
								goto end_IL_0230;
							case 10:
								_003C_003Ec__DisplayClass70_2 = new _003C_003Ec__DisplayClass70_1();
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
								{
									num3 = 7;
								}
								continue;
							default:
								source = list2.Where(_003C_003Ec__DisplayClass70_._003CGenerateContextAssembly_003Eb__1);
								num3 = 6;
								continue;
							case 8:
								if (!source2.Any())
								{
									num3 = 13;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
									{
										num3 = 9;
									}
									continue;
								}
								goto case 4;
							case 12:
								_003C_003Ec__DisplayClass70_.prop1 = current;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
								{
									num3 = 0;
								}
								continue;
							case 6:
								goto IL_0398;
							case 9:
								throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865250414), current.DisplayName, string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747FB36A), (from h in new IProcessHeader[1] { header }.Union(source.Select((IWorkflowProcess p) => p.Header))
									select SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB7793C9 ^ 0xB7541D1) + h.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18413207)).ToArray())));
							case 4:
								throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB23BCC), current.Name, string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763686267), (from h in new IProcessHeader[1] { header }.Union(source2.Select((IWorkflowProcess p) => p.Header))
									select SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF42DFE0) + h.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -451950783)).ToArray())));
							case 13:
								goto IL_0523;
							case 1:
								goto end_IL_0523;
							}
							if (current.DisplayName != null)
							{
								num3 = 2;
								continue;
							}
							goto IL_0465;
							IL_0398:
							if (source.Any())
							{
								num3 = 9;
								continue;
							}
							goto IL_0465;
							IL_0465:
							if (current.Name != null)
							{
								num3 = 10;
								continue;
							}
							goto IL_0523;
							continue;
							end_IL_0230:
							break;
						}
						goto IL_02dc;
						continue;
						end_IL_0523:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								enumerator.Dispose();
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 15;
			case 15:
				context2.MetadataToAdd.Add(new Tuple<IMetadata, GenerationParams>(context, new ProcessContextGenerationParams
				{
					ProcessHeader = header,
					IsFullContext = false,
					ParentContext = parentContext,
					ParentContextList = list,
					FileName = context.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980551468)
				}));
				num2 = 7;
				break;
			case 39:
				context.Filterable = true;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
				{
					num2 = 0;
				}
				break;
			case 36:
				context2.MetadataToRegister.Add(instanceMetrics);
				num2 = 29;
				break;
			case 21:
				context2.MetadataToRegister.Add(processMetrics);
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
				{
					num2 = 34;
				}
				break;
			case 28:
				context2.MetadataToAdd.Add(new Tuple<IMetadata, GenerationParams>(instanceMetrics, new ProcessContextGenerationParams
				{
					ProcessHeader = header,
					IsFullContext = false
				}));
				num2 = 10;
				break;
			case 38:
				parentContext = null;
				num2 = 31;
				break;
			case 24:
				list2.Add(workflowProcess);
				num2 = 16;
				break;
			case 19:
				list = null;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 2;
				}
				break;
			case 18:
				context.Namespace = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895881541);
				num2 = 39;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
				{
					num2 = 19;
				}
				break;
			case 12:
				context2.MetadataToRegister.Add(context.ViewModelMetadata);
				num2 = 19;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 0;
				}
				break;
			case 40:
				context2.MetadataToAdd.Add(new Tuple<IMetadata, GenerationParams>(processMetrics, new ProcessContextGenerationParams
				{
					ProcessHeader = header,
					IsFullContext = false
				}));
				num2 = 32;
				break;
			case 17:
				context2.MetadataToRegister.Add(context);
				num2 = 22;
				break;
			case 25:
				parentContext = parentProcess.Context;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
				{
					num2 = 2;
				}
				break;
			case 31:
				if (parentProcess == null)
				{
					num2 = 11;
					break;
				}
				goto case 27;
			case 10:
				return;
			case 35:
				throw new ArgumentException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E9C1AB));
			case 22:
				if (processMetrics != null)
				{
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 34;
			case 3:
				workflowProcess = parentProcess;
				num2 = 4;
				break;
			case 11:
			case 33:
				if (list2 != null)
				{
					num2 = 23;
					break;
				}
				goto case 15;
			case 9:
				if (data != null)
				{
					if (data.Context == null)
					{
						num2 = 35;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
						{
							num2 = 30;
						}
					}
					else
					{
						context2 = data.Context;
						num2 = 37;
					}
				}
				else
				{
					num2 = 8;
				}
				break;
			case 6:
			case 26:
				list.Add(workflowProcess.Context);
				num2 = 24;
				break;
			case 4:
			case 14:
				if (workflowProcess != null)
				{
					num2 = 6;
					break;
				}
				goto case 11;
			case 20:
				list2 = new List<IWorkflowProcess>();
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 25;
				}
				break;
			case 5:
			case 29:
				if (context.ViewModelMetadata != null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 19;
			case 27:
				list = new List<EntityMetadata>();
				num2 = 15;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
				{
					num2 = 20;
				}
				break;
			default:
				context.BaseClassUid = parentProcess?.Context.Uid ?? Guid.Empty;
				num2 = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num2 = 17;
				}
				break;
			case 23:
				enumerator = context.Properties.Where((PropertyMetadata p) => !p.IsSystem).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected virtual void CreateContextDbStructure(IProcessHeader header, EntityMetadata oldContext, EntityMetadata newContext, EntityMetadata parentContext)
	{
		//Discarded unreachable code: IL_0108, IL_0140, IL_014f
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass71_0 CS_0024_003C_003E8__locals0;
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass71_0();
					int num3 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num3 = 2;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
						{
							CS_0024_003C_003E8__locals0.updater.PrepareActions();
							int num4 = 3;
							num3 = num4;
							break;
						}
						case 2:
							CS_0024_003C_003E8__locals0.updater = new DbProcessContextUpdater(header.Id, oldContext, newContext);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							Locator.GetServiceNotNull<IUnitOfWorkManager>().RegisterPreCommitAction(delegate
							{
								int num6 = 1;
								int num7 = num6;
								while (true)
								{
									switch (num7)
									{
									default:
										return;
									case 1:
										CS_0024_003C_003E8__locals0.updater.ExecuteActions();
										num7 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
										{
											num7 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							});
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					if (metadataServiceContext != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								((IDisposable)metadataServiceContext).Dispose();
								num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
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
			case 2:
			{
				IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				EntityMetadata[] first = new EntityMetadata[1] { newContext };
				object second;
				if (parentContext == null)
				{
					EntityMetadata[] array = new ProcessContext[0];
					second = array;
				}
				else
				{
					second = new EntityMetadata[1] { parentContext };
				}
				metadataServiceContext = new MetadataServiceContext(new ExtendedMetadataService(serviceNotNull, first.Union((IEnumerable<EntityMetadata>)second).ToList()));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0136, IL_0145
		int num = 5;
		int num2 = num;
		WorkflowProcessFilter workflowProcessFilter = default(WorkflowProcessFilter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (!workflowProcessFilter.Published)
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 5:
				base.SetupFilter(criteria, filter);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				criteria.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29954994), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EADD2C), (JoinType)0).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C668C01), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539495177), (JoinType)0).Add((ICriterion)(object)Restrictions.EqProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130113968), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360653183)));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (workflowProcessFilter != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 0:
				return;
			case 3:
				return;
			case 4:
				workflowProcessFilter = filter as WorkflowProcessFilter;
				num2 = 2;
				break;
			}
		}
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type parentType = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				parentType = InterfaceActivator.TypeOf<IWorkflowProcess>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			return new ExportRuleList
			{
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCD3338),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x1134637A),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x61421AD9),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EF548B),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x758C356),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430608871),
					ExportRuleType = ExportRuleType.ExportDeep
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495264978),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495307166),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657550019),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x11450CDB),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708143922),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498856977),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516536998),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6DDB70),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716585536),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947966161),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720439521),
					ExportRuleType = ExportRuleType.Export
				},
				new ExportRule
				{
					ParentType = parentType,
					PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x6142E973),
					ExportRuleType = ExportRuleType.Export
				}
			};
		}
	}

	IWorkflowProcess IWorkflowProcessManager.Load(long id)
	{
		return Load(id);
	}

	IWorkflowProcess IWorkflowProcessManager.LoadOrNull(long id)
	{
		return LoadOrNull(id);
	}

	void IWorkflowProcessManager.Save(IWorkflowProcess process)
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
				Save((TProcess)process);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	void IWorkflowProcessManager.Publish(IWorkflowProcess process, long versionNumber, IWorkflowProcess parentProcess, string comment, bool isEmulation)
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
				Publish((TProcess)process, versionNumber, parentProcess, comment, isEmulation);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	void IWorkflowProcessManager.Publish(IWorkflowProcess process, long versionNumber, IWorkflowProcess parentProcess, string comment, bool isEmulation, WorkflowProcessPublishingData data)
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
				Publish((TProcess)process, versionNumber, parentProcess, comment, isEmulation, data);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void CopyPropertyTableParts(EntityMetadata context)
	{
		//Discarded unreachable code: IL_002f, IL_0162, IL_01a2, IL_01b1, IL_01bd, IL_01cc
		int num = 2;
		int num2 = num;
		IEnumerator<TablePartMetadata> enumerator = default(IEnumerator<TablePartMetadata>);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 6;
							goto IL_003d;
						}
						goto IL_00bc;
						IL_003d:
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 3:
								current.TableParts.AddRange((IEnumerable<TablePartMetadata>)current.EntityTableParts);
								num3 = 5;
								continue;
							case 5:
								CopyPropertyTableParts(current);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
								{
									num3 = 0;
								}
								continue;
							case 7:
								goto IL_00bc;
							case 4:
								current.Properties.Clear();
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
								{
									num3 = 2;
								}
								continue;
							case 1:
								current.TableParts.Clear();
								num3 = 3;
								continue;
							case 2:
								current.Properties.AddRange((IEnumerable<PropertyMetadata>)current.EntityProperties);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						}
						continue;
						IL_00bc:
						current = enumerator.Current;
						int num4 = 4;
						num3 = num4;
						goto IL_003d;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
						{
							num5 = 0;
						}
						goto IL_0166;
					}
					goto IL_017c;
					IL_017c:
					enumerator.Dispose();
					num5 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num5 = 0;
					}
					goto IL_0166;
					IL_0166:
					switch (num5)
					{
					default:
						goto end_IL_0141;
					case 1:
						break;
					case 0:
						goto end_IL_0141;
					case 2:
						goto end_IL_0141;
					}
					goto IL_017c;
					end_IL_0141:;
				}
			case 2:
				enumerator = ((IEnumerable<TablePartMetadata>)context.EntityTableParts).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void PublishFullContext(IProcessHeader header, EntityMetadata context, EntityMetadata fullContext, EntityMetadata parentFullContext)
	{
		//Discarded unreachable code: IL_0098, IL_00a7, IL_0100, IL_010f, IL_023f, IL_0252, IL_0261
		int num = 3;
		int num2 = num;
		EntityMetadata oldContext = default(EntityMetadata);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass80_0 _003C_003Ec__DisplayClass80_ = default(_003C_003Ec__DisplayClass80_0);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 5:
				RefreshFullContext(context, fullContext);
				num2 = 12;
				break;
			case 12:
				CreateContextDbStructure(header, oldContext, fullContext, parentFullContext);
				num2 = 9;
				break;
			case 9:
				enumerator = context.Properties.GetEnumerator();
				num2 = 4;
				break;
			case 7:
				fullContext.TableParts.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				oldContext = ClassSerializationHelper.CloneObjectByXml(fullContext);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
							{
								num3 = 0;
							}
							goto IL_011e;
						}
						goto IL_01d5;
						IL_01d5:
						_003C_003Ec__DisplayClass80_ = new _003C_003Ec__DisplayClass80_0();
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
						{
							num3 = 1;
						}
						goto IL_011e;
						IL_011e:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 5:
								if (entityPropertyMetadata != null)
								{
									int num4 = 2;
									num3 = num4;
									continue;
								}
								break;
							case 4:
								break;
							case 1:
								_003C_003Ec__DisplayClass80_.prop = (EntityPropertyMetadata)enumerator.Current;
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
								{
									num3 = 6;
								}
								continue;
							case 6:
								entityPropertyMetadata = (EntityPropertyMetadata)fullContext.Properties.FirstOrDefault(_003C_003Ec__DisplayClass80_._003CPublishFullContext_003Eb__0);
								num3 = 5;
								continue;
							case 3:
								goto IL_01d5;
							case 2:
								_003C_003Ec__DisplayClass80_.prop.TableNumber = entityPropertyMetadata.TableNumber;
								num3 = 4;
								continue;
							case 0:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 6:
				return;
			case 13:
				CopyPropertyTableParts(fullContext);
				num2 = 10;
				break;
			case 3:
				if (fullContext != null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 1:
				fullContext.Properties.Clear();
				num2 = 8;
				break;
			default:
				fullContext.TableParts.AddRange((IEnumerable<TablePartMetadata>)fullContext.EntityTableParts);
				num2 = 13;
				break;
			case 8:
				fullContext.Properties.AddRange((IEnumerable<PropertyMetadata>)fullContext.EntityProperties);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
				{
					num2 = 7;
				}
				break;
			case 11:
				return;
			case 2:
				fullContext.Uid = Guid.NewGuid();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void RefreshFullContext(EntityMetadata context, EntityMetadata fullContext)
	{
		//Discarded unreachable code: IL_006a, IL_0079, IL_0084, IL_0282, IL_02a1, IL_02b0, IL_02dd, IL_03a5, IL_03b4, IL_0429, IL_0438, IL_0443, IL_057e, IL_0591, IL_05ce, IL_05d8, IL_071d, IL_075d, IL_0768, IL_0777
		int num = 13;
		IEnumerator<TablePartMetadata> enumerator3 = default(IEnumerator<TablePartMetadata>);
		_003C_003Ec__DisplayClass81_2 _003C_003Ec__DisplayClass81_4 = default(_003C_003Ec__DisplayClass81_2);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		_003C_003Ec__DisplayClass81_0 _003C_003Ec__DisplayClass81_ = default(_003C_003Ec__DisplayClass81_0);
		IEnumerator<EntityPropertyMetadata> enumerator = default(IEnumerator<EntityPropertyMetadata>);
		List<TablePartMetadata>.Enumerator enumerator2 = default(List<TablePartMetadata>.Enumerator);
		_003C_003Ec__DisplayClass81_4 _003C_003Ec__DisplayClass81_3 = default(_003C_003Ec__DisplayClass81_4);
		_003C_003Ec__DisplayClass81_1 _003C_003Ec__DisplayClass81_2 = default(_003C_003Ec__DisplayClass81_1);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator3.MoveNext())
							{
								num7 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
								{
									num7 = 5;
								}
								goto IL_0088;
							}
							goto IL_01b3;
							IL_01b3:
							_003C_003Ec__DisplayClass81_4 = new _003C_003Ec__DisplayClass81_2();
							num7 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
							{
								num7 = 5;
							}
							goto IL_0088;
							IL_0088:
							while (true)
							{
								switch (num7)
								{
								case 1:
									tablePartMetadata = ((IEnumerable<TablePartMetadata>)fullContext.EntityTableParts).FirstOrDefault(_003C_003Ec__DisplayClass81_4._003CRefreshFullContext_003Eb__2);
									num7 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
									{
										num7 = 5;
									}
									continue;
								case 9:
									tablePartMetadata = new TablePartMetadata
									{
										TablePartOwner = fullContext
									};
									num7 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
									{
										num7 = 1;
									}
									continue;
								case 4:
									fullContext.EntityTableParts.Add(tablePartMetadata);
									num7 = 6;
									continue;
								case 6:
									Mapper.Map<TablePartMetadata, TablePartMetadata>(_003C_003Ec__DisplayClass81_4.tp, tablePartMetadata);
									num7 = 11;
									continue;
								case 2:
									tablePartMetadata.Properties.First(_003C_003Ec__DisplayClass81_4._003CRefreshFullContext_003Eb__3).SubTypeUid = fullContext.Uid;
									num7 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
									{
										num7 = 10;
									}
									continue;
								case 10:
									break;
								default:
									goto IL_01b3;
								case 3:
									RefreshFullContext(_003C_003Ec__DisplayClass81_4.tp, tablePartMetadata);
									num7 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
									{
										num7 = 2;
									}
									continue;
								case 11:
									tablePartMetadata.Uid = Guid.NewGuid();
									num7 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
									{
										num7 = 3;
									}
									continue;
								case 8:
									_003C_003Ec__DisplayClass81_4.tp = enumerator3.Current;
									num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
									{
										num7 = 1;
									}
									continue;
								case 5:
									if (tablePartMetadata == null)
									{
										num7 = 9;
										continue;
									}
									goto case 6;
								case 7:
									goto end_IL_018d;
								}
								break;
							}
							continue;
							end_IL_018d:
							break;
						}
					}
					finally
					{
						int num8;
						if (enumerator3 == null)
						{
							num8 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
							{
								num8 = 2;
							}
							goto IL_0286;
						}
						goto IL_02bb;
						IL_02bb:
						enumerator3.Dispose();
						num8 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
						{
							num8 = 1;
						}
						goto IL_0286;
						IL_0286:
						switch (num8)
						{
						case 2:
							goto end_IL_0261;
						case 1:
							goto end_IL_0261;
						}
						goto IL_02bb;
						end_IL_0261:;
					}
					goto case 16;
				case 4:
					fullContext.Properties.Clear();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 3;
					}
					break;
				case 9:
					if (_003C_003Ec__DisplayClass81_.context == null)
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 1:
					enumerator = ((IEnumerable<EntityPropertyMetadata>)_003C_003Ec__DisplayClass81_.context.EntityProperties).GetEnumerator();
					num2 = 2;
					break;
				case 15:
					fullContext.TableParts.Clear();
					num2 = 6;
					break;
				case 11:
					return;
				case 14:
					fullContext.Name = _003C_003Ec__DisplayClass81_.context.Name;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
					{
						num2 = 5;
					}
					break;
				case 3:
					fullContext.Properties.AddRange((IEnumerable<PropertyMetadata>)fullContext.EntityProperties);
					num2 = 9;
					break;
				case 5:
					fullContext.TableName = _003C_003Ec__DisplayClass81_.context.TableName;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
					{
						num2 = 1;
					}
					break;
				case 12:
					_003C_003Ec__DisplayClass81_.context = context;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (_003C_003Ec__DisplayClass81_.context != null)
					{
						num2 = 14;
						break;
					}
					goto case 4;
				case 10:
					try
					{
						while (true)
						{
							IL_052c:
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
								{
									num5 = 1;
								}
								goto IL_0447;
							}
							goto IL_0495;
							IL_0495:
							_003C_003Ec__DisplayClass81_3 = new _003C_003Ec__DisplayClass81_4();
							num5 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
							{
								num5 = 4;
							}
							goto IL_0447;
							IL_0447:
							while (true)
							{
								switch (num5)
								{
								case 2:
									RefreshFullContext(null, _003C_003Ec__DisplayClass81_3.tp);
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
									{
										num5 = 4;
									}
									continue;
								case 3:
									break;
								case 5:
									_003C_003Ec__DisplayClass81_3.tp = enumerator2.Current;
									num5 = 6;
									continue;
								case 6:
									_003C_003Ec__DisplayClass81_3.tp.Uid = Guid.NewGuid();
									num5 = 2;
									continue;
								case 4:
									_003C_003Ec__DisplayClass81_3.tp.Properties.First(_003C_003Ec__DisplayClass81_3._003CRefreshFullContext_003Eb__5).SubTypeUid = fullContext.Uid;
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
									{
										num5 = 0;
									}
									continue;
								default:
									goto IL_052c;
								case 1:
									goto end_IL_052c;
								}
								break;
							}
							goto IL_0495;
							continue;
							end_IL_052c:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 15;
				case 7:
					enumerator3 = ((IEnumerable<TablePartMetadata>)_003C_003Ec__DisplayClass81_.context.EntityTableParts).GetEnumerator();
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
					{
						num2 = 8;
					}
					break;
				case 2:
					try
					{
						while (true)
						{
							IL_069d:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
								{
									num3 = 1;
								}
								goto IL_05dc;
							}
							goto IL_064b;
							IL_064b:
							_003C_003Ec__DisplayClass81_2 = new _003C_003Ec__DisplayClass81_1();
							num3 = 3;
							goto IL_05dc;
							IL_05dc:
							while (true)
							{
								switch (num3)
								{
								case 8:
									Mapper.Map<EntityPropertyMetadata, EntityPropertyMetadata>(_003C_003Ec__DisplayClass81_2.property, entityPropertyMetadata);
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
									{
										num3 = 5;
									}
									continue;
								case 6:
									entityPropertyMetadata = new EntityPropertyMetadata
									{
										Owner = fullContext
									};
									num3 = 7;
									continue;
								case 2:
									break;
								case 3:
									_003C_003Ec__DisplayClass81_2.property = enumerator.Current;
									num3 = 4;
									continue;
								case 7:
									fullContext.EntityProperties.Add(entityPropertyMetadata);
									num3 = 8;
									continue;
								default:
									if (entityPropertyMetadata == null)
									{
										num3 = 6;
										continue;
									}
									goto case 8;
								case 5:
									goto IL_069d;
								case 4:
									entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)fullContext.EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass81_2._003CRefreshFullContext_003Eb__1);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									goto end_IL_069d;
								}
								break;
							}
							goto IL_064b;
							continue;
							end_IL_069d:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
							{
								num4 = 0;
							}
							goto IL_0721;
						}
						goto IL_0737;
						IL_0737:
						enumerator.Dispose();
						num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
						{
							num4 = 1;
						}
						goto IL_0721;
						IL_0721:
						switch (num4)
						{
						default:
							goto end_IL_06fc;
						case 2:
							break;
						case 0:
							goto end_IL_06fc;
						case 1:
							goto end_IL_06fc;
						}
						goto IL_0737;
						end_IL_06fc:;
					}
					goto case 4;
				case 16:
				case 17:
					enumerator2 = ((IEnumerable<TablePartMetadata>)fullContext.EntityTableParts).Where(_003C_003Ec__DisplayClass81_._003CRefreshFullContext_003Eb__0).ToList().GetEnumerator();
					num2 = 10;
					break;
				case 13:
					_003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_0();
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 6;
					}
					break;
				case 6:
					fullContext.TableParts.AddRange((IEnumerable<TablePartMetadata>)fullContext.EntityTableParts);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 11;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 17;
		}
	}

	private void CopyContextToDeletedSubHeaders(IProcessHeader header, byte[] assemblyRaw, string assemblyName)
	{
		//Discarded unreachable code: IL_002e, IL_0038, IL_00b8, IL_010a, IL_0119, IL_01d9, IL_0219, IL_0228, IL_0234, IL_0243
		int num = 2;
		int num2 = num;
		IEnumerator<IProcessHeader> enumerator = default(IEnumerator<IProcessHeader>);
		IProcessHeader current = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
							{
								num3 = 2;
							}
							goto IL_003c;
						}
						goto IL_0124;
						IL_0124:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
						{
							num3 = 5;
						}
						goto IL_003c;
						IL_003c:
						while (true)
						{
							switch (num3)
							{
							default:
								current.Context.AssemblyRaw = assemblyRaw;
								num3 = 6;
								continue;
							case 3:
							case 7:
							case 10:
								break;
							case 2:
								if (current.Context.AssemblyRaw.Length != 0)
								{
									num3 = 7;
									continue;
								}
								goto default;
							case 5:
								if (current.Status == WorkflowProcessStatus.Deleted)
								{
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 9;
							case 4:
								goto IL_0124;
							case 11:
								if (current.Context.AssemblyRaw != null)
								{
									num3 = 2;
									continue;
								}
								goto default;
							case 9:
								CopyContextToDeletedSubHeaders(current, assemblyRaw, assemblyName);
								num3 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
								{
									num3 = 10;
								}
								continue;
							case 1:
								if (current.Context != null)
								{
									num3 = 11;
									continue;
								}
								break;
							case 6:
								current.Context.AssemblyName = assemblyName;
								num3 = 3;
								continue;
							case 8:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
						{
							num4 = 0;
						}
						goto IL_01dd;
					}
					goto IL_01f3;
					IL_01f3:
					enumerator.Dispose();
					num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
					{
						num4 = 0;
					}
					goto IL_01dd;
					IL_01dd:
					switch (num4)
					{
					default:
						goto end_IL_01b8;
					case 2:
						break;
					case 0:
						goto end_IL_01b8;
					case 1:
						goto end_IL_01b8;
					}
					goto IL_01f3;
					end_IL_01b8:;
				}
			case 2:
				enumerator = ((IEnumerable<IProcessHeader>)header.SubHeaders).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void ApplyDraftScriptModule(TProcess process)
	{
		if (process.ScriptModule != null && process.ScriptModule.Draft != null)
		{
			Guid uid = process.ScriptModule.Uid;
			ScriptModuleDTO scriptModuleDTO = Mapper.Map<ScriptModule, ScriptModuleDTO>(process.ScriptModule.Draft, new ScriptModuleDTO());
			scriptModuleDTO.Id = process.ScriptModule.Id;
			Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModuleDTO, process.ScriptModule);
			process.ScriptModule.Uid = uid;
		}
		foreach (TProcess item in (IEnumerable<IWorkflowProcess>)process.SubProcesses)
		{
			ApplyDraftScriptModule(item);
		}
	}

	private void CompileScriptsAndProcessResults(ScriptCompiler scriptCompiler, TProcess process)
	{
		scriptCompiler.AssemblyName = process.ScriptModule.AssemblyName;
		List<ProcessContext> list = new List<ProcessContext>();
		IWorkflowProcess workflowProcess = process;
		do
		{
			if (workflowProcess.Header?.Current?.Context != null)
			{
				list.Add(workflowProcess.Header.Current.Context);
			}
			if (workflowProcess.Context != null)
			{
				list.Add(workflowProcess.Context);
			}
			workflowProcess = workflowProcess.Parent;
		}
		while (workflowProcess != null);
		DataClassUsageAnalyzer dataClassUsageAnalyzer = new DataClassUsageAnalyzer();
		ServerEntityUsageAnalyzer serverEntityUsageAnalyzer = new ServerEntityUsageAnalyzer();
		ProcessEntityUsageAnalyzer processEntityUsageAnalyzer = new ProcessEntityUsageAnalyzer(list, process.ScriptModule.FullClassName, process.ScriptModule.AssemblyName);
		EnumUsageAnalyzer enumUsageAnalyzer = new EnumUsageAnalyzer();
		scriptCompiler.AddAnalyzers((DiagnosticAnalyzer)serverEntityUsageAnalyzer, (DiagnosticAnalyzer)processEntityUsageAnalyzer, (DiagnosticAnalyzer)enumUsageAnalyzer, (DiagnosticAnalyzer)dataClassUsageAnalyzer);
		ScriptCompileResult scriptCompileResult = scriptCompiler.Compile();
		if (!scriptCompileResult.Success)
		{
			_003C_003Ec__DisplayClass84_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass84_0();
			TProcess val = process;
			CS_0024_003C_003E8__locals0.firstError = scriptCompileResult.Messages.FirstOrDefault((ScriptCompileMessage m) => m.Type == ScriptCompileMessageType.Error);
			if (CS_0024_003C_003E8__locals0.firstError != null && CS_0024_003C_003E8__locals0.firstError.ModuleUid != Guid.Empty)
			{
				val = FindProcessByScriptModuleUid(process, CS_0024_003C_003E8__locals0.firstError.ModuleUid);
				if (val == null)
				{
					val = process;
				}
				scriptCompileResult.Messages = scriptCompileResult.Messages.Where(delegate(ScriptCompileMessage m)
				{
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 1:
							if (m.ModuleUid == Guid.Empty)
							{
								return true;
							}
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
							{
								num2 = 0;
							}
							break;
						default:
							return m.ModuleUid == CS_0024_003C_003E8__locals0.firstError.ModuleUid;
						}
					}
				}).ToList();
			}
			throw new ProcessPublishingException(val.Header.Id, scriptCompileResult);
		}
		process.ScriptModule.AssemblyRaw = scriptCompiler.AssemblyRaw;
		process.ScriptModule.DebugRaw = scriptCompiler.DebugRaw;
		List<EnumDependency> list2 = new List<EnumDependency>();
		List<EntityDependency> list3 = new List<EntityDependency>();
		List<DataClassDependency> list4 = new List<DataClassDependency>();
		foreach (KeyValuePair<IMetadata, ICollection<IPropertyMetadata>> referenceMetadatum in serverEntityUsageAnalyzer.CodeAnalyzerResult.CombineResult(processEntityUsageAnalyzer.CodeAnalyzerResult).CombineResult(dataClassUsageAnalyzer.CodeAnalyzerResult).CombineResult(enumUsageAnalyzer.CodeAnalyzerResult)
			.ReferenceMetadata)
		{
			if (!(referenceMetadatum.Key is ICodeItemMetadata codeItemMetadata))
			{
				continue;
			}
			ICodeItemMetadata codeItemMetadata2 = codeItemMetadata;
			if (codeItemMetadata2 == null)
			{
				continue;
			}
			if (!(codeItemMetadata2 is EnumMetadata enumMetadata))
			{
				if (!(codeItemMetadata2 is EntityMetadata entityMetadata))
				{
					if (codeItemMetadata2 is DataClassMetadata dataClassMetadata)
					{
						DataClassMetadata metadata = dataClassMetadata;
						list4.Add(metadata.GetSignature(referenceMetadatum.Value));
					}
				}
				else
				{
					EntityMetadata metadata2 = entityMetadata;
					list3.Add(metadata2.GetSignature(referenceMetadatum.Value));
				}
			}
			else
			{
				EnumMetadata metadata3 = enumMetadata;
				list2.Add(metadata3.GetSignature());
			}
		}
		ScriptModuleDependencyContainer scriptModuleDependencyContainer = new ScriptModuleDependencyContainer();
		scriptModuleDependencyContainer.EnumDependencies.AddRange(list2);
		scriptModuleDependencyContainer.EntityDependencies.AddRange(list3);
		scriptModuleDependencyContainer.DataClassDependencies.AddRange(list4);
		process.ScriptModule.Dependencies = scriptModuleDependencyContainer;
	}

	private TProcess FindProcessByScriptModuleUid(TProcess process, Guid scriptModuleUid)
	{
		if (process == null || process.ScriptModule == null)
		{
			return null;
		}
		if (process.ScriptModule.Uid == scriptModuleUid)
		{
			return process;
		}
		foreach (TProcess item in (IEnumerable<IWorkflowProcess>)process.SubProcesses)
		{
			TProcess val = FindProcessByScriptModuleUid(item, scriptModuleUid);
			if (val != null)
			{
				return val;
			}
		}
		return null;
	}

	private void BuildContextAssembly(ProcessContext context, WorkflowProcessBuilderData builderData)
	{
		//Discarded unreachable code: IL_00f8, IL_01a2, IL_01ac, IL_025b, IL_029b, IL_02a6, IL_02d6, IL_02f5, IL_0321, IL_0330
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass86_0 _003C_003Ec__DisplayClass86_ = default(_003C_003Ec__DisplayClass86_0);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		byte[] assemblyRaw = default(byte[]);
		IEnumerator<DataClassAssemblyInfo> enumerator = default(IEnumerator<DataClassAssemblyInfo>);
		DataClassAssemblyInfo current = default(DataClassAssemblyInfo);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass86_.builderData = builderData;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass86_ = new _003C_003Ec__DisplayClass86_0();
				num2 = 3;
				break;
			case 5:
				metadataServiceContext = new MetadataServiceContext(new ExtendedMetadataService(Locator.GetServiceNotNull<IMetadataRuntimeService>(), _003C_003Ec__DisplayClass86_.builderData.MetadataToRegister));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num2 = 2;
				}
				break;
			default:
				_003C_003Ec__DisplayClass86_.builderData.Builder.AssemblyName = context.AssemblyName;
				num2 = 5;
				break;
			case 2:
				try
				{
					_003C_003Ec__DisplayClass86_.builderData.MetadataToAdd.ForEach(_003C_003Ec__DisplayClass86_._003CBuildContextAssembly_003Eb__0);
					int num3 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							assemblyRaw = _003C_003Ec__DisplayClass86_.builderData.Builder.Build();
							num3 = 2;
							break;
						case 2:
							context.AssemblyRaw = assemblyRaw;
							num3 = 3;
							break;
						case 1:
							enumerator = SearchMetadataService.GetPublishedDataClassAssemblies().GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							context.DocumentationRaw = _003C_003Ec__DisplayClass86_.builderData.Builder.DocumentationRaw;
							num3 = 5;
							break;
						default:
							try
							{
								while (true)
								{
									IL_020f:
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
										{
											num4 = 1;
										}
										goto IL_01b0;
									}
									goto IL_01ca;
									IL_01ca:
									current = enumerator.Current;
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
									{
										num4 = 0;
									}
									goto IL_01b0;
									IL_01b0:
									while (true)
									{
										switch (num4)
										{
										case 3:
											break;
										default:
											_003C_003Ec__DisplayClass86_.builderData.Builder.AddReference(current.AssemblyRaw);
											num4 = 2;
											continue;
										case 2:
											goto IL_020f;
										case 1:
											goto end_IL_020f;
										}
										break;
									}
									goto IL_01ca;
									continue;
									end_IL_020f:
									break;
								}
							}
							finally
							{
								int num5;
								if (enumerator == null)
								{
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
									{
										num5 = 0;
									}
									goto IL_025f;
								}
								goto IL_0275;
								IL_0275:
								enumerator.Dispose();
								num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
								{
									num5 = 1;
								}
								goto IL_025f;
								IL_025f:
								switch (num5)
								{
								default:
									goto end_IL_023a;
								case 2:
									break;
								case 0:
									goto end_IL_023a;
								case 1:
									goto end_IL_023a;
								}
								goto IL_0275;
								end_IL_023a:;
							}
							goto case 4;
						case 5:
							return;
						}
					}
				}
				finally
				{
					int num6;
					if (metadataServiceContext == null)
					{
						num6 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
						{
							num6 = 0;
						}
						goto IL_02da;
					}
					goto IL_02ff;
					IL_02ff:
					((IDisposable)metadataServiceContext).Dispose();
					num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num6 = 0;
					}
					goto IL_02da;
					IL_02da:
					switch (num6)
					{
					default:
						goto end_IL_02b5;
					case 1:
						goto end_IL_02b5;
					case 2:
						break;
					case 0:
						goto end_IL_02b5;
					}
					goto IL_02ff;
					end_IL_02b5:;
				}
			case 1:
				return;
			}
		}
	}

	private void RecompileContext(TProcess process, IWorkflowProcess parentProcess, WorkflowProcessPublishingData data)
	{
		GenerateContextAssembly(process.Header, process.Context, process.ProcessMetrics, process.InstanceMetrics, parentProcess, data);
		foreach (IWorkflowProcess item in (IEnumerable<IWorkflowProcess>)process.SubProcesses)
		{
			WorkflowProcessDTO dto = item.CastAsRealType().CreateDTO();
			RecompileContext((TProcess)dto.CreateEntity(), process, data);
		}
	}

	private void CheckDeletedProperties(TProcess process, ProcessContext context, ProcessContext fullContext)
	{
		if (context == null || fullContext == null || fullContext.AssemblyName == null)
		{
			return;
		}
		using Dictionary<Guid, long>.Enumerator enumerator = RetrieveDeletedProperties(process, context).GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass88_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass88_0();
			CS_0024_003C_003E8__locals0.deletedProperty = enumerator.Current;
			EntityPropertyMetadata propertyMetadata = ((IEnumerable<EntityPropertyMetadata>)fullContext.EntityProperties).First((EntityPropertyMetadata p) => p.Uid == CS_0024_003C_003E8__locals0.deletedProperty.Key);
			fullContext.MarkPropertyAsDeleted(propertyMetadata, CS_0024_003C_003E8__locals0.deletedProperty.Value);
		}
	}

	private Dictionary<Guid, long> RetrieveDeletedProperties(TProcess process, ProcessContext context)
	{
		string sql = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595CE26A), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947922321)), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105894222)), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716491009)), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111223293)), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36164069)), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360700375)), Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7F2991)), process.Header.Id);
		Dictionary<Guid, long> dictionary = new Dictionary<Guid, long>();
		using (IDataReader dataReader = Transform.ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				try
				{
					dictionary.Add(Transform.Dialect.GetGuid(dataReader[1]), Convert.ToInt64(dataReader[0]));
				}
				catch (Exception exception)
				{
					base.Logger.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716494365)), exception);
				}
			}
		}
		if (dictionary.Count > 0)
		{
			foreach (EntityPropertyMetadata item in (IEnumerable<EntityPropertyMetadata>)context.EntityProperties)
			{
				dictionary.Remove(item.Uid);
			}
			return dictionary;
		}
		return dictionary;
	}

	[PublicApiMember]
	public virtual void SetInformUserRole(long processId, IOrganizationItem orgItem)
	{
		//Discarded unreachable code: IL_0068, IL_0077
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass90_0 _003C_003Ec__DisplayClass90_ = default(_003C_003Ec__DisplayClass90_0);
		IResponsibilityMatrixItem responsibilityMatrixItem = default(IResponsibilityMatrixItem);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass90_ = new _003C_003Ec__DisplayClass90_0();
				num2 = 2;
				break;
			case 5:
				return;
			case 6:
				if (responsibilityMatrixItem == null)
				{
					num2 = 4;
					break;
				}
				if (responsibilityMatrixItem.ResponsibilityLevel == ResponsibilityLevel.Inform)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass90_.orgItem = orgItem;
				num2 = 7;
				break;
			case 8:
				return;
			case 1:
				responsibilityMatrixItem.ResponsibilityLevel = ResponsibilityLevel.Inform;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947967591)));
			default:
				responsibilityMatrixItem.Save();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 5;
				}
				break;
			case 7:
			{
				IWorkflowProcess workflowProcess = WorkflowProcessManager.Instance.Load(processId);
				if (_003C_003Ec__DisplayClass90_.orgItem == null)
				{
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514201986)));
				}
				if (workflowProcess == null)
				{
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6D0BB6)));
				}
				responsibilityMatrixItem = ((IEnumerable<IResponsibilityMatrixItem>)((IBPMNProcess)workflowProcess).ResponsibilityMatrix).FirstOrDefault(_003C_003Ec__DisplayClass90_._003CSetInformUserRole_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num2 = 6;
				}
				break;
			}
			}
		}
	}

	[PublicApiMember]
	public virtual void SetOwnerUserRole(long processId, IOrganizationItem orgItem)
	{
		//Discarded unreachable code: IL_0046
		int num = 8;
		int num2 = num;
		IResponsibilityMatrixItem responsibilityMatrixItem = default(IResponsibilityMatrixItem);
		_003C_003Ec__DisplayClass91_0 _003C_003Ec__DisplayClass91_ = default(_003C_003Ec__DisplayClass91_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				responsibilityMatrixItem.Save();
				num2 = 2;
				break;
			case 6:
				return;
			case 8:
				_003C_003Ec__DisplayClass91_ = new _003C_003Ec__DisplayClass91_0();
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14394418)));
			case 3:
				if (responsibilityMatrixItem.ResponsibilityLevel != ResponsibilityLevel.Owner)
				{
					responsibilityMatrixItem.ResponsibilityLevel = ResponsibilityLevel.Owner;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 6;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass91_.orgItem = orgItem;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (responsibilityMatrixItem != null)
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 4:
			{
				IWorkflowProcess workflowProcess = WorkflowProcessManager.Instance.Load(processId);
				if (_003C_003Ec__DisplayClass91_.orgItem == null)
				{
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F4F40)));
				}
				if (workflowProcess == null)
				{
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516548840)));
				}
				responsibilityMatrixItem = ((IEnumerable<IResponsibilityMatrixItem>)((IBPMNProcess)workflowProcess).ResponsibilityMatrix).FirstOrDefault(_003C_003Ec__DisplayClass91_._003CSetOwnerUserRole_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	[PublicApiMember]
	public virtual void SetMemberUserRole(long processId, IOrganizationItem orgItem)
	{
		int num = 2;
		int num2 = num;
		IResponsibilityMatrixItem responsibilityMatrixItem = default(IResponsibilityMatrixItem);
		_003C_003Ec__DisplayClass92_0 _003C_003Ec__DisplayClass92_ = default(_003C_003Ec__DisplayClass92_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (responsibilityMatrixItem == null)
				{
					num2 = 7;
					continue;
				}
				if (responsibilityMatrixItem.ResponsibilityLevel == ResponsibilityLevel.Member)
				{
					num2 = 3;
					continue;
				}
				responsibilityMatrixItem.ResponsibilityLevel = ResponsibilityLevel.Member;
				num2 = 6;
				continue;
			case 1:
				_003C_003Ec__DisplayClass92_.orgItem = orgItem;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				return;
			case 6:
				responsibilityMatrixItem.Save();
				num2 = 5;
				continue;
			case 2:
				_003C_003Ec__DisplayClass92_ = new _003C_003Ec__DisplayClass92_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108907194)));
			case 3:
				return;
			}
			IWorkflowProcess workflowProcess = WorkflowProcessManager.Instance.Load(processId);
			if (_003C_003Ec__DisplayClass92_.orgItem == null)
			{
				throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39143620)));
			}
			if (workflowProcess == null)
			{
				throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29952982)));
			}
			responsibilityMatrixItem = ((IEnumerable<IResponsibilityMatrixItem>)((IBPMNProcess)workflowProcess).ResponsibilityMatrix).FirstOrDefault(_003C_003Ec__DisplayClass92_._003CSetMemberUserRole_003Eb__0);
			num2 = 4;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
			{
				num2 = 4;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetCuratorUserRole(long processId, IOrganizationItem orgItem)
	{
		int num = 6;
		IResponsibilityMatrixItem responsibilityMatrixItem = default(IResponsibilityMatrixItem);
		_003C_003Ec__DisplayClass93_0 _003C_003Ec__DisplayClass93_ = default(_003C_003Ec__DisplayClass93_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (responsibilityMatrixItem == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					if (responsibilityMatrixItem.IsCurator)
					{
						num2 = 7;
						continue;
					}
					responsibilityMatrixItem.IsCurator = true;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					break;
				default:
					responsibilityMatrixItem.Save();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass93_.orgItem = orgItem;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130126812)));
				case 3:
					return;
				case 7:
					return;
				case 4:
				{
					IWorkflowProcess workflowProcess = WorkflowProcessManager.Instance.Load(processId);
					if (_003C_003Ec__DisplayClass93_.orgItem == null)
					{
						throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -62984043)));
					}
					if (workflowProcess == null)
					{
						throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213F1485)));
					}
					responsibilityMatrixItem = ((IEnumerable<IResponsibilityMatrixItem>)((IBPMNProcess)workflowProcess).ResponsibilityMatrix).FirstOrDefault(_003C_003Ec__DisplayClass93_._003CSetCuratorUserRole_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				}
				break;
			}
			_003C_003Ec__DisplayClass93_ = new _003C_003Ec__DisplayClass93_0();
			num = 5;
		}
	}

	[PublicApiMember]
	public virtual EleWise.ELMA.Security.Models.IUser GetSwimlaneExecutor(IWorkflowInstance instance, SwimlaneElement element)
	{
		//Discarded unreachable code: IL_0092
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (element != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x6281D2D8)));
			case 1:
			{
				if (instance == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 0;
					}
					break;
				}
				ICollection<IWorkflowSwimlaneExecutor> source = EntityManager<IWorkflowSwimlaneExecutor>.Instance.Find(new Filter
				{
					Query = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x1417CD0), element.Uid, instance.Id)
				}, null);
				if (!source.Any())
				{
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E9C77D)));
				}
				return source.LastOrDefault().User;
			}
			default:
				throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F80E8D)));
			}
		}
	}

	[PublicApiMember]
	public virtual void ChangeSwimlaneExecutor(IWorkflowInstance instance, SwimlaneElement swimlaneElement, EleWise.ELMA.Security.Models.IUser newExecutor)
	{
		//Discarded unreachable code: IL_009b, IL_00aa
		int num = 7;
		ICollection<IWorkflowSwimlaneExecutor> source = default(ICollection<IWorkflowSwimlaneExecutor>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					source.LastOrDefault().User = newExecutor;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 6;
					}
					break;
				case 2:
				{
					if (source.Any())
					{
						num2 = 5;
						break;
					}
					IWorkflowSwimlaneExecutor workflowSwimlaneExecutor = InterfaceActivator.Create<IWorkflowSwimlaneExecutor>();
					workflowSwimlaneExecutor.User = newExecutor;
					workflowSwimlaneExecutor.WorkflowInstance = instance;
					workflowSwimlaneExecutor.SwimlaneUid = swimlaneElement.Uid;
					workflowSwimlaneExecutor.Save();
					num2 = 4;
					break;
				}
				case 4:
					return;
				case 7:
					if (swimlaneElement != null)
					{
						goto end_IL_0012;
					}
					goto default;
				default:
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708155610)));
				case 6:
					if (instance == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
						{
							num2 = 1;
						}
						break;
					}
					if (newExecutor == null)
					{
						num2 = 3;
						break;
					}
					source = EntityManager<IWorkflowSwimlaneExecutor>.Instance.Find(new Filter
					{
						Query = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B7439C), swimlaneElement.Uid, instance.Id)
					}, null);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 2;
					}
					break;
				case 8:
					return;
				case 1:
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642737689)));
				case 9:
					source.LastOrDefault().Save();
					num2 = 8;
					break;
				case 3:
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772644600)));
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	[PublicApiMember]
	public virtual void ClearSwimlane(IWorkflowInstance instance, string swimlaneName)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass96_0 _003C_003Ec__DisplayClass96_ = default(_003C_003Ec__DisplayClass96_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				_003C_003Ec__DisplayClass96_.swimlaneName = swimlaneName;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 4;
				}
				break;
			default:
				instance.SwimlaneExecutors.RemoveAll((ICollection<IWorkflowSwimlaneExecutor>)((IEnumerable<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Where(_003C_003Ec__DisplayClass96_._003CClearSwimlane_003Eb__1).ToList());
				num2 = 3;
				break;
			case 4:
				_003C_003Ec__DisplayClass96_.swimlaneUid = instance.Process.Diagram.Elements.OfType<SwimlaneElement>().Single(_003C_003Ec__DisplayClass96_._003CClearSwimlane_003Eb__0).Uid;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass96_ = new _003C_003Ec__DisplayClass96_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected WorkflowProcessManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool I80oDq9CxdMaTIKofKG()
	{
		return QPZ2Je9p24G3suT1den == null;
	}

	internal static object zFvNV89MCLtiauR5YdA()
	{
		return QPZ2Je9p24G3suT1den;
	}
}
