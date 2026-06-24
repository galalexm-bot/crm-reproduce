using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Actors;
using EleWise.ELMA.Workflow.CodeGeneration;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class CustomActivityManager : EntityManager<ICustomActivity, long>, ICustomActivityManager, IEntityManager<ICustomActivity, long>, IEntityManager<ICustomActivity>, IEntityManager
{
	private sealed class CustomActivityPublicationEventHandler : ICustomActivityPublicationEventHandler, IEventHandler
	{
		private readonly object actor;

		private readonly long activityId;

		private readonly TaskCompletionSource<bool> taskCompletionSource;

		internal static object WT09jinIEdaLu8rZvuQ;

		public Task Wait => taskCompletionSource.Task;

		public CustomActivityPublicationEventHandler(ICustomActivityPublicationActor actor, long activityId)
		{
			//Discarded unreachable code: IL_003c, IL_0041
			lTf7RHyEyFij3ZYesUG();
			taskCompletionSource = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					this.activityId = activityId;
					num = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 == 0)
					{
						num = 1;
					}
					break;
				default:
					this.actor = actor;
					num = 2;
					break;
				case 1:
					return;
				}
			}
		}

		public Task Complete(long customActivityId)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (activityId != customActivityId)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 != 0)
						{
							num2 = 0;
						}
						break;
					}
					taskCompletionSource.TrySetResult(result: true);
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return (Task)ajuSOUyXP3Xq3igaXYA(actor);
				default:
					return (Task)Y5ZLNAyCHx8C5nFIwwU();
				}
			}
		}

		public Task Error(long customActivityId, Exception exception)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (Task)Y5ZLNAyCHx8C5nFIwwU();
				case 1:
					if (activityId == customActivityId)
					{
						gxcW3fyondO1tCesolD(taskCompletionSource, exception);
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 2:
					return (Task)ajuSOUyXP3Xq3igaXYA(actor);
				}
			}
		}

		internal static void lTf7RHyEyFij3ZYesUG()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static bool BCfsdVnZH0DMSdLrQYI()
		{
			return WT09jinIEdaLu8rZvuQ == null;
		}

		internal static CustomActivityPublicationEventHandler N7jFZonzfGDMYGYn7uQ()
		{
			return (CustomActivityPublicationEventHandler)WT09jinIEdaLu8rZvuQ;
		}

		internal static object Y5ZLNAyCHx8C5nFIwwU()
		{
			return Task.CompletedTask;
		}

		internal static object ajuSOUyXP3Xq3igaXYA(object P_0)
		{
			return ((ICustomActivityPublicationActor)P_0).PublicationComplete();
		}

		internal static bool gxcW3fyondO1tCesolD(object P_0, object P_1)
		{
			return ((TaskCompletionSource<bool>)P_0).TrySetException((Exception)P_1);
		}
	}

	public static readonly string ParametersAssemblyPrefix;

	public static readonly string DebugParametersAssemblyPrefix;

	internal static CustomActivityManager eqkUJbKR0ar0PV4WaTL;

	public new static CustomActivityManager Instance => Locator.GetServiceNotNull<CustomActivityManager>();

	public IActorModelRuntime ActorModelRuntime
	{
		[CompilerGenerated]
		get
		{
			return _003CActorModelRuntime_003Ek__BackingField;
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
					_003CActorModelRuntime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
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

	public IEventHandlerSubscribeService EventHandlerSubscribeService
	{
		[CompilerGenerated]
		get
		{
			return _003CEventHandlerSubscribeService_003Ek__BackingField;
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
					_003CEventHandlerSubscribeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
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

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
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

	[Transaction]
	public virtual ScriptModule LoadScriptModuleForEdit(long caId)
	{
		int num = 3;
		int num2 = num;
		ScriptModuleDTO scriptModuleDTO = default(ScriptModuleDTO);
		ICustomActivity customActivity = default(ICustomActivity);
		while (true)
		{
			switch (num2)
			{
			case 1:
				scriptModuleDTO = Mapper.Map<ScriptModule, ScriptModuleDTO>((ScriptModule)UrSEfTKWmlDKRhwG7at(customActivity), new ScriptModuleDTO());
				num2 = 4;
				break;
			case 7:
				throw new InvalidOperationException((string)esRNfBKer9Hi5VUPIGx(Sq8b3JKHGZAlBKV708V(--192118127 ^ 0xB73269D), caId));
			case 3:
				customActivity = Load(caId);
				num2 = 2;
				break;
			case 4:
				scriptModuleDTO.Id = 0L;
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				((ScriptModule)UrSEfTKWmlDKRhwG7at(customActivity)).Draft = Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModuleDTO, new ScriptModule());
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (UrSEfTKWmlDKRhwG7at(customActivity) != null)
				{
					if (WGtqdxKioFfr4Qr5IvI(UrSEfTKWmlDKRhwG7at(customActivity)) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
				{
					num2 = 7;
				}
				break;
			default:
				return ((ScriptModule)UrSEfTKWmlDKRhwG7at(customActivity)).Draft;
			case 5:
				mhmvEDKum6JABs3VI0K(WGtqdxKioFfr4Qr5IvI(UrSEfTKWmlDKRhwG7at(customActivity)));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e307e1455f8c4779adb085e36b40526a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual long GetPublishingVersionNumber(long headerId)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 1;
		int num2 = num;
		ITransformationProvider service = default(ITransformationProvider);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return 1L;
			default:
				service = Locator.GetService<ITransformationProvider>();
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (headerId > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 4:
				return lI9oMaK5Ki5CULbrahG(b8smHuK7E5JICD6Pdpq(V9Cc3RKrh1GJdkN1F1n(Lpmb8dKJBLgLUAvpLmK(yues4FKL0MYt9Hmum8w(this), text), false)));
			case 2:
				text = string.Format((string)Sq8b3JKHGZAlBKV708V(-901337984 ^ -901320524), (service != null) ? pxoT9CKlPBMMFcbBWtq(service.Dialect, Sq8b3JKHGZAlBKV708V(-680549150 ^ -680527800)) : Sq8b3JKHGZAlBKV708V(0x3F8E27D0 ^ 0x3F8E7B7A), (service != null) ? pxoT9CKlPBMMFcbBWtq(kJrUO4KfW9VD9jAsFAA(service), Sq8b3JKHGZAlBKV708V(0x4E58FEAF ^ 0x4E58AB19)) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48B7D69C ^ 0x48B7832A), headerId);
				num2 = 4;
				break;
			}
		}
	}

	public virtual List<ICustomActivity> LoadHistory(long customActivityHeadId)
	{
		ICustomActivityHeader customActivityHeader = CustomActivityHeaderManager.Instance.Load(customActivityHeadId);
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-693602260 ^ -693621350), (object)customActivityHeader)).AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x77F4B0AB ^ 0x77F4EC01))).List<ICustomActivity>()
			.ToList();
	}

	public virtual IDictionary<long, List<ICustomActivity>> LoadHistories(IEnumerable<long> customActivityHeadIds)
	{
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ICustomActivity), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-481953825 ^ -481963761));
		string text = LinqUtils.NameOf(Expression.Lambda<Func<ICustomActivity, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
		IEnumerable<IGrouping<long, ICustomActivity>> enumerable = from ca in CreateCriteria().CreateAlias(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x124714F0 ^ 0x12474838), (JoinType)0).Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-478552651 ^ -478576287), (ICollection)customActivityHeadIds.ToArray())).AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E58FEAF ^ 0x4E58A205)))
				.List<ICustomActivity>()
			group ca by ca.Header.Id;
		Dictionary<long, List<ICustomActivity>> dictionary = new Dictionary<long, List<ICustomActivity>>();
		foreach (IGrouping<long, ICustomActivity> item in enumerable)
		{
			long key = item.Key;
			if (!dictionary.ContainsKey(key))
			{
				dictionary.Add(key, item.ToList());
			}
			else
			{
				dictionary[key].AddRange(item.ToList());
			}
		}
		return dictionary;
	}

	public virtual ICustomActivity LoadAsDraft(long id)
	{
		int num = 1;
		int num2 = num;
		CustomActivityDTO customActivityDTO = default(CustomActivityDTO);
		CustomActivityDTO dto = default(CustomActivityDTO);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				object obj = dVexCaKIMJ5uGtdxo2a(customActivityDTO);
				LMIKInKZ3SfGpeAjA5y(obj);
				return (ICustomActivity)obj;
			}
			default:
				customActivityDTO.CopyIdsFrom(dto);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
			{
				ICustomActivity customActivity = Load(id);
				customActivityDTO = (CustomActivityDTO)WvTfHWKg9AcH4LmHj4r(customActivity);
				dto = (CustomActivityDTO)WvTfHWKg9AcH4LmHj4r(EpRRcVK1tq9fi44QHfa(customActivity.Header));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public virtual void Publish(ICustomActivity ca)
	{
		int num = 2;
		int num2 = num;
		TaskAwaiter taskAwaiter = default(TaskAwaiter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				taskAwaiter.GetResult();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				taskAwaiter = iSKO3SKzjqpqBVOgGFK(PublishAsync(ca));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void Save(ICustomActivity ca)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (ca.Header != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				return;
			case 3:
				if (EpRRcVK1tq9fi44QHfa(tKMWWjME8yVJTkfksV7(ca)) == ca)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				MPAkdGMCl9Zx7KCEUQg(tKMWWjME8yVJTkfksV7(ca), true);
				num2 = 2;
				continue;
			case 2:
				break;
			}
			base.Save(ca);
			num2 = 1;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 == 0)
			{
				num2 = 1;
			}
		}
	}

	public virtual void GenerateCustomActivityParametersAssembly(ICustomActivity ca, bool debugAssembly = false)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_0098, IL_01ba, IL_01d9, IL_01e8, IL_0215, IL_0224
		int num = 9;
		IEnumerator<EntityPropertyMetadata> enumerator = default(IEnumerator<EntityPropertyMetadata>);
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		CustomActivityParameters customActivityParameters = default(CustomActivityParameters);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					enumerator = ((IEnumerable<EntityPropertyMetadata>)ca.Parameters.EntityProperties).GetEnumerator();
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					try
					{
						while (true)
						{
							int num3;
							if (!FVDLTQMxYPuB338abnZ(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c != 0)
								{
									num3 = 1;
								}
								goto IL_009c;
							}
							goto IL_0173;
							IL_0173:
							_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
							num3 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
							{
								num3 = 2;
							}
							goto IL_009c;
							IL_009c:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 3:
									GKQ1jxMhxvZnVUB48Jp(((IEnumerable<EntityPropertyMetadata>)customActivityParameters.EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass23_._003CGenerateCustomActivityParametersAssembly_003Eb__0), _003C_003Ec__DisplayClass23_.property, new string[3]
									{
										SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-193507406 ^ -193497016),
										(string)Sq8b3JKHGZAlBKV708V(0x5A5DBA54 ^ 0x5A5DE6B2),
										SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x29336E79 ^ 0x2933328D)
									});
									num3 = 4;
									continue;
								case 2:
									_003C_003Ec__DisplayClass23_.property = enumerator.Current;
									num3 = 3;
									continue;
								default:
									goto IL_0173;
								case 1:
									goto end_IL_00ba;
								}
								break;
							}
							continue;
							end_IL_00ba:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f1ba867523264a63932ee1e8d0cd4a24 == 0)
							{
								num4 = 2;
							}
							goto IL_01be;
						}
						goto IL_01f3;
						IL_01f3:
						mfmZMCMFpIRaqpGAg32(enumerator);
						num4 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 != 0)
						{
							num4 = 0;
						}
						goto IL_01be;
						IL_01be:
						switch (num4)
						{
						default:
							goto end_IL_0199;
						case 2:
							goto end_IL_0199;
						case 1:
							break;
						case 0:
							goto end_IL_0199;
						}
						goto IL_01f3;
						end_IL_0199:;
					}
					goto case 1;
				case 11:
					customActivityParameters.Uid = Guid.NewGuid();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					return;
				case 9:
					OeJkZGM3SZgUbSJZTIU(EehWv6MX9KF8RGDgthe(ca), iKHZQIMoXmBP56uWElV());
					num = 8;
					break;
				case 3:
					customActivityParameters.Properties.AddRange((IEnumerable<PropertyMetadata>)customActivityParameters.EntityProperties);
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					type = FsF87SM2BCIBhctwldN(ComponentManager.LoadAssembly((byte[])sr0jYSMwNhv1bHb4uiU(customActivityParameters), (byte[])yip6W4MtnRiDkvDXyOZ(customActivityParameters)), W0Vm0cMswxYADEaUkOJ(customActivityParameters));
					num2 = 4;
					continue;
				case 8:
					customActivityParameters = (CustomActivityParameters)EehWv6MX9KF8RGDgthe(ca);
					num2 = 10;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc == 0)
					{
						num2 = 11;
					}
					continue;
				case 4:
					if (ttgtgtMq2kkrL3QC1PZ(type, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					ES29D1MDHL5TTLD18bc(Locator.GetServiceNotNull<IMetadataRuntimeService>(), type, false);
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					eMLkrCM8cx8VlEtH0CA(customActivityParameters.Properties);
					num = 3;
					break;
				case 5:
					GenerateContextAssembly(ca, customActivityParameters, debugAssembly);
					num = 10;
					break;
				case 6:
					throw new MetadataException(string.Format((string)MmWcuuMQcZIsxTTtcqd(Sq8b3JKHGZAlBKV708V(-478552651 ^ -478576453)), eCIyNWMV19dCm8u6QQk(customActivityParameters), W0Vm0cMswxYADEaUkOJ(customActivityParameters)));
				}
				break;
			}
		}
	}

	protected void GenerateContextAssembly(ICustomActivity ca, CustomActivityParameters context, bool debugAssembly = false)
	{
		//Discarded unreachable code: IL_01af, IL_01e7, IL_01f6
		int num = 3;
		int num2 = num;
		ModelAssemblyBuilder modelAssemblyBuilder = default(ModelAssemblyBuilder);
		byte[] array = default(byte[]);
		string assemblyName = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				BpPlJ2MagM4aI1wD3fW(context, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x27475F40 ^ 0x27470296));
				num2 = 5;
				break;
			case 0:
				return;
			case 1:
				try
				{
					PTh967MvrIng9LhhPwD(modelAssemblyBuilder);
					int num3 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							return;
						case 1:
							X0w1GNMPUMuynYXOfP3(modelAssemblyBuilder, Sq8b3JKHGZAlBKV708V(-282877824 ^ -282883324));
							num3 = 2;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea == 0)
							{
								num3 = 2;
							}
							break;
						case 6:
							context.DebugRaw = modelAssemblyBuilder.DebugRaw;
							num3 = 4;
							break;
						case 3:
							array = modelAssemblyBuilder.Build();
							num3 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							X0w1GNMPUMuynYXOfP3(modelAssemblyBuilder, Sq8b3JKHGZAlBKV708V(-465190147 ^ -465178907));
							num3 = 5;
							break;
						default:
							EQVenFMNmuflIwKN17U(context, array);
							num3 = 6;
							break;
						case 5:
						{
							ModelAssemblyBuilder modelAssemblyBuilder2 = modelAssemblyBuilder;
							GenerationParams generationParams = new GenerationParams();
							YVb3oOM4cXlN3itAsSS(generationParams, typeof(CustomActivityParamsGenerator));
							KKoQjEMT2SxdH2PrwRT(generationParams, zvKvsWM9mk1dkqm6TSH(typeof(ClassMetadata).TypeHandle));
							YZdrqBMcw3uogaGEwnu(modelAssemblyBuilder2, context, generationParams);
							int num4 = 3;
							num3 = num4;
							break;
						}
						}
					}
				}
				finally
				{
					if (modelAssemblyBuilder != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc != 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								mfmZMCMFpIRaqpGAg32(modelAssemblyBuilder);
								num5 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f != 0)
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
			case 6:
				gkooVWMMilSpKCoKL3g(context, assemblyName);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 != 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				modelAssemblyBuilder = new ModelAssemblyBuilder((string)eCIyNWMV19dCm8u6QQk(context), (string)zPFwBVMYgsMPGuRAnpA(context));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				assemblyName = GetAssemblyName(debugAssembly, ca, context);
				num2 = 2;
				break;
			case 2:
				eW5KIbMKmrBd8qiityr(context, assemblyName);
				num2 = 6;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private string GetAssemblyName(bool debugAssembly, ICustomActivity ca, CustomActivityParameters context)
	{
		//Discarded unreachable code: IL_013c, IL_014b
		int num = 4;
		int num2 = num;
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (debugAssembly)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				result = string.Concat(ParametersAssemblyPrefix, ca.Id, Sq8b3JKHGZAlBKV708V(-79921577 ^ -79944091), OQZnh0Mdp49dWIHko0E(context).ToString((string)Sq8b3JKHGZAlBKV708V(-1197637235 ^ -1197616605)));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				result = (string)plGtcOMjI2Ee4i7IavP(new object[4]
				{
					DebugParametersAssemblyPrefix,
					ca.Id,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x148F9F60 ^ 0x148FC752),
					OQZnh0Mdp49dWIHko0E(context).ToString((string)Sq8b3JKHGZAlBKV708V(0x66914DC5 ^ 0x66911E6B))
				});
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			}
		}
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<ICustomActivity>();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			xk9mHfMSdJUu1LlRFGj(obj, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3907FE5 ^ 0x3902A53));
			obj.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(obj);
			ExportRule exportRule = new ExportRule();
			R75VNMMkNPgS9t9b7tn(exportRule, type);
			xk9mHfMSdJUu1LlRFGj(exportRule, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-796330436 ^ -796352332));
			exportRule.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			R75VNMMkNPgS9t9b7tn(exportRule2, type);
			xk9mHfMSdJUu1LlRFGj(exportRule2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-5433396 ^ -5420572));
			bsXWVSMbieXGb3fHY5J(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule exportRule3 = new ExportRule();
			R75VNMMkNPgS9t9b7tn(exportRule3, type);
			xk9mHfMSdJUu1LlRFGj(exportRule3, Sq8b3JKHGZAlBKV708V(0x78FAF0B5 ^ 0x78FAA367));
			bsXWVSMbieXGb3fHY5J(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			return exportRuleList;
		}
	}

	[AsyncStateMachine(typeof(_003CPublishAsync_003Ed__27))]
	private Task PublishAsync(ICustomActivity customActivity)
	{
		int num = 3;
		int num2 = num;
		_003CPublishAsync_003Ed__27 stateMachine = default(_003CPublishAsync_003Ed__27);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 2;
				break;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 5;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num2 = 6;
				break;
			case 2:
				stateMachine.customActivity = customActivity;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			case 1:
				stateMachine._003C_003Et__builder = BmERmZMUbbT4KTLX8mv();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public CustomActivityManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CustomActivityManager()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 1:
				ParametersAssemblyPrefix = (string)Sq8b3JKHGZAlBKV708V(0x4244DF13 ^ 0x42448157);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				DebugParametersAssemblyPrefix = (string)Sq8b3JKHGZAlBKV708V(-2038019883 ^ -2038032721);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool LT6gE6K0nmtws6uWGK1()
	{
		return eqkUJbKR0ar0PV4WaTL == null;
	}

	internal static CustomActivityManager PJP3FNKBIgx3uxTPmBi()
	{
		return eqkUJbKR0ar0PV4WaTL;
	}

	internal static object UrSEfTKWmlDKRhwG7at(object P_0)
	{
		return ((ICustomActivity)P_0).ScriptModule;
	}

	internal static object Sq8b3JKHGZAlBKV708V(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object esRNfBKer9Hi5VUPIGx(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object WGtqdxKioFfr4Qr5IvI(object P_0)
	{
		return ((ScriptModule)P_0).Draft;
	}

	internal static void mhmvEDKum6JABs3VI0K(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static object pxoT9CKlPBMMFcbBWtq(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object kJrUO4KfW9VD9jAsFAA(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object yues4FKL0MYt9Hmum8w(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object Lpmb8dKJBLgLUAvpLmK(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object V9Cc3RKrh1GJdkN1F1n(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static object b8smHuK7E5JICD6Pdpq(object P_0)
	{
		return ((IQuery)P_0).UniqueResult();
	}

	internal static long lI9oMaK5Ki5CULbrahG(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object WvTfHWKg9AcH4LmHj4r(object P_0)
	{
		return ((ICustomActivity)P_0).CreateDTO();
	}

	internal static object EpRRcVK1tq9fi44QHfa(object P_0)
	{
		return ((ICustomActivityHeader)P_0).Draft;
	}

	internal static object dVexCaKIMJ5uGtdxo2a(object P_0)
	{
		return ((CustomActivityDTO)P_0).CreateEntity();
	}

	internal static void LMIKInKZ3SfGpeAjA5y(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static TaskAwaiter iSKO3SKzjqpqBVOgGFK(object P_0)
	{
		return ((Task)P_0).GetAwaiter();
	}

	internal static object tKMWWjME8yVJTkfksV7(object P_0)
	{
		return ((ICustomActivity)P_0).Header;
	}

	internal static void MPAkdGMCl9Zx7KCEUQg(object P_0, bool value)
	{
		((ICustomActivityHeader)P_0).IsDirtyCustomActivity = value;
	}

	internal static object EehWv6MX9KF8RGDgthe(object P_0)
	{
		return ((ICustomActivity)P_0).Parameters;
	}

	internal static Guid iKHZQIMoXmBP56uWElV()
	{
		return Guid.NewGuid();
	}

	internal static void OeJkZGM3SZgUbSJZTIU(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static void GKQ1jxMhxvZnVUB48Jp(object P_0, object P_1, object P_2)
	{
		((AbstractMetadata)P_0).CopyFrom((AbstractMetadata)P_1, (string[])P_2);
	}

	internal static bool FVDLTQMxYPuB338abnZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void mfmZMCMFpIRaqpGAg32(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void eMLkrCM8cx8VlEtH0CA(object P_0)
	{
		((List<PropertyMetadata>)P_0).Clear();
	}

	internal static object sr0jYSMwNhv1bHb4uiU(object P_0)
	{
		return ((CustomActivityParameters)P_0).AssemblyRaw;
	}

	internal static object yip6W4MtnRiDkvDXyOZ(object P_0)
	{
		return ((CustomActivityParameters)P_0).DebugRaw;
	}

	internal static object W0Vm0cMswxYADEaUkOJ(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static Type FsF87SM2BCIBhctwldN(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool ttgtgtMq2kkrL3QC1PZ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object MmWcuuMQcZIsxTTtcqd(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object eCIyNWMV19dCm8u6QQk(object P_0)
	{
		return ((CustomActivityParameters)P_0).AssemblyName;
	}

	internal static void ES29D1MDHL5TTLD18bc(object P_0, Type P_1, bool P_2)
	{
		((IMetadataRuntimeService)P_0).RegisterType(P_1, P_2);
	}

	internal static void eW5KIbMKmrBd8qiityr(object P_0, object P_1)
	{
		((CustomActivityParameters)P_0).AssemblyName = (string)P_1;
	}

	internal static void gkooVWMMilSpKCoKL3g(object P_0, object P_1)
	{
		((EntityMetadata)P_0).TableName = (string)P_1;
	}

	internal static void BpPlJ2MagM4aI1wD3fW(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static object zPFwBVMYgsMPGuRAnpA(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void PTh967MvrIng9LhhPwD(object P_0)
	{
		((AssemblyBuilder)P_0).AddDefaultReferences();
	}

	internal static bool X0w1GNMPUMuynYXOfP3(object P_0, object P_1)
	{
		return ((AssemblyBuilder)P_0).AddReferenceByName((string)P_1);
	}

	internal static void YVb3oOM4cXlN3itAsSS(object P_0, Type P_1)
	{
		((GenerationParams)P_0).GeneratorType = P_1;
	}

	internal static Type zvKvsWM9mk1dkqm6TSH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void KKoQjEMT2SxdH2PrwRT(object P_0, Type P_1)
	{
		((GenerationParams)P_0).MetadataType = P_1;
	}

	internal static void YZdrqBMcw3uogaGEwnu(object P_0, object P_1, object P_2)
	{
		((ModelAssemblyBuilder)P_0).AddMetadata((IMetadata)P_1, (GenerationParams)P_2);
	}

	internal static void EQVenFMNmuflIwKN17U(object P_0, object P_1)
	{
		((CustomActivityParameters)P_0).AssemblyRaw = (byte[])P_1;
	}

	internal static Guid OQZnh0Mdp49dWIHko0E(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object plGtcOMjI2Ee4i7IavP(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static void xk9mHfMSdJUu1LlRFGj(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void R75VNMMkNPgS9t9b7tn(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static void bsXWVSMbieXGb3fHY5J(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static AsyncTaskMethodBuilder BmERmZMUbbT4KTLX8mv()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
