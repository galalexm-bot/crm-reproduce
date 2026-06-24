using System;
using System.Activities;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.CustomActivity;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Documents.BPMN.Diagrams.Activities.Approvement;

public class CustomActivityActivity : TaskActivity<CustomActivityElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		internal static object yoTMr7m4icNAcpg2Cny;

		public Type ActivityType => cH2COHmcHZKxFnwOP8Z(typeof(CustomActivityActivity).TypeHandle);

		public Type DiagramElementType => cH2COHmcHZKxFnwOP8Z(typeof(CustomActivityElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Jocle7mNC0O4Wrk1y6S();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type cH2COHmcHZKxFnwOP8Z(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void Jocle7mNC0O4Wrk1y6S()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static bool EuGxvgm9kaSHAeEfcIn()
		{
			return yoTMr7m4icNAcpg2Cny == null;
		}

		internal static Info l5A6xVmTFeYK90aYoQW()
		{
			return (Info)yoTMr7m4icNAcpg2Cny;
		}
	}

	private static CustomActivityActivity wXEbolyMZeZa2C2kKC;

	public CustomActivityHeaderManager CustomActivityHeaderManager => Locator.GetServiceNotNull<CustomActivityHeaderManager>();

	public ICustomActivityScriptingService CustomActivityScriptingService
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomActivityScriptingService_003Ek__BackingField;
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
					_003CCustomActivityScriptingService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowQueueItemManager WorkflowQueueItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowQueueItemManager_003Ek__BackingField;
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
					_003CWorkflowQueueItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IUnitOfWorkManager UnitOfWorkManager
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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IExternalCustomActivityService ExternalCustomActivityService
	{
		[CompilerGenerated]
		get
		{
			return _003CExternalCustomActivityService_003Ek__BackingField;
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
					_003CExternalCustomActivityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override bool CanInduceIdle => true;

	protected override void ExecuteTask(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_0157, IL_0166, IL_0175, IL_0305, IL_033c
		int num = 12;
		_003C_003Ec__DisplayClass21_2 _003C_003Ec__DisplayClass21_2 = default(_003C_003Ec__DisplayClass21_2);
		ICustomActivityHeader customActivityHeader = default(ICustomActivityHeader);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_3 = default(_003C_003Ec__DisplayClass21_0);
		_003C_003Ec__DisplayClass21_1 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					_003C_003Ec__DisplayClass21_2.externalServerQueueItem.ServerConnectionUid = _003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals2.externalServerUid;
					num2 = 23;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
					{
						num2 = 9;
					}
					continue;
				case 8:
					aVKKR27eGO8JYKykTN(this, context);
					num2 = 25;
					continue;
				case 27:
					return;
				default:
					customActivityHeader = CustomActivityHeaderManager.LoadOrNull(base.Element.CustomActivityHeaderUid);
					num2 = 29;
					continue;
				case 29:
					if (customActivityHeader != null)
					{
						num2 = 14;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 1;
				case 16:
					UnitOfWorkManager.RegisterPostCommitAction(_003C_003Ec__DisplayClass21_2._003CExecuteTask_003Eb__0);
					num2 = 27;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb == 0)
					{
						num2 = 27;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass21_2.externalServerQueueItem = WorkflowQueueItemManager.CreateQueueItem(workflowInstance, base.Element);
					num = 17;
					break;
				case 7:
					LYFn0sWYyG2LV04scM(mGGJnYBfVfFi5sPURd(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C126B81 ^ 0x3C126BDD));
					num2 = 13;
					continue;
				case 21:
					context.CreateBookmark(_003C_003Ec__DisplayClass21_2.externalServerQueueItem.Uid.ToString(), ExecuteActivity);
					num2 = 16;
					continue;
				case 11:
					Pt3lmu0EKhYsbiknVH(context, gHy0wZRYkmg60LZdeG(0x2772A0C0 ^ 0x2772A08A));
					num2 = 7;
					continue;
				case 12:
					_003C_003Ec__DisplayClass21_3 = new _003C_003Ec__DisplayClass21_0();
					num2 = 11;
					continue;
				case 25:
					return;
				case 14:
					CustomActivityScriptingService.ExecuteScript(customActivityHeader, (string)gHy0wZRYkmg60LZdeG(-7731921 ^ -7732159), null, (WorkflowInstanceContext)Vrsj6s5HKCl2erOkTv(workflowInstance), base.Element);
					num2 = 4;
					continue;
				case 13:
					if (!lm1NV1esYAAKBxVlVh(j8WYJ8HU9S6VqIBtAk(base.Element), Guid.Empty))
					{
						num2 = 20;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 10;
				case 28:
					return;
				case 20:
					workflowInstance = (IWorkflowInstance)elLT5WiqErVkDBtdXT(this, context);
					num2 = 6;
					continue;
				case 19:
					if (_003C_003Ec__DisplayClass21_3.externalService == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 26;
				case 24:
					_003C_003Ec__DisplayClass21_2.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass21_;
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					_003C_003Ec__DisplayClass21_3.externalService = ExternalCustomActivityService;
					num2 = 19;
					continue;
				case 5:
					_003C_003Ec__DisplayClass21_2 = new _003C_003Ec__DisplayClass21_2();
					num2 = 24;
					continue;
				case 2:
					return;
				case 23:
					HqLhnqfbeYLpa9OHVh(_003C_003Ec__DisplayClass21_2.externalServerQueueItem);
					num2 = 21;
					continue;
				case 1:
					rB4RZSruk1Lt5WybDN(VB8j34LjqWdYLd0FWi(), gHy0wZRYkmg60LZdeG(-2125832759 ^ -2125832891), new object[3]
					{
						j8WYJ8HU9S6VqIBtAk(base.Element),
						YI87q0J9Y8wEIVa0EQ(base.Element),
						workflowInstance.Id
					});
					num = 8;
					break;
				case 15:
					_003C_003Ec__DisplayClass21_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass21_3;
					num2 = 22;
					continue;
				case 22:
					_003C_003Ec__DisplayClass21_.externalServerUid = GTQ5CVuvTy216yV5He(_003C_003Ec__DisplayClass21_.CS_0024_003C_003E8__locals1.externalService, base.Element.CustomActivityHeaderUid);
					num2 = 10;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 != 0)
					{
						num2 = 18;
					}
					continue;
				case 18:
					if (!gwWaARltwCeUGR2bmC(_003C_003Ec__DisplayClass21_.externalServerUid, Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f2221527565f4c919b1fed8e8c54e4f7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 26:
					_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_1();
					num2 = 15;
					continue;
				case 4:
					aVKKR27eGO8JYKykTN(this, context);
					num2 = 2;
					continue;
				case 10:
					ContinueOnDefaultConnector(context);
					num = 28;
					break;
				}
				break;
			}
		}
	}

	private void ExecuteActivity(NativeActivityContext context, Bookmark bookmark, object state)
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
				RCvunZgDxXmDd5M1ss(this, context);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public CustomActivityActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool XT4vqxOmKeYivIwYT5()
	{
		return wXEbolyMZeZa2C2kKC == null;
	}

	internal static CustomActivityActivity GgcEYl6Lel9cYtyU8X()
	{
		return wXEbolyMZeZa2C2kKC;
	}

	internal static object gHy0wZRYkmg60LZdeG(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Pt3lmu0EKhYsbiknVH(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object mGGJnYBfVfFi5sPURd(object P_0)
	{
		return ((WorkflowActivity)P_0).WorkflowRuntimeService;
	}

	internal static void LYFn0sWYyG2LV04scM(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static Guid j8WYJ8HU9S6VqIBtAk(object P_0)
	{
		return ((CustomActivityElement)P_0).CustomActivityHeaderUid;
	}

	internal static bool lm1NV1esYAAKBxVlVh(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object elLT5WiqErVkDBtdXT(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static Guid GTQ5CVuvTy216yV5He(object P_0, Guid customActivityHeaderUid)
	{
		return ((IExternalCustomActivityService)P_0).GetAvailableServer(customActivityHeaderUid);
	}

	internal static bool gwWaARltwCeUGR2bmC(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void HqLhnqfbeYLpa9OHVh(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object VB8j34LjqWdYLd0FWi()
	{
		return Logger.Log;
	}

	internal static object YI87q0J9Y8wEIVa0EQ(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static void rB4RZSruk1Lt5WybDN(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).ErrorFormat((string)P_1, (object[])P_2);
	}

	internal static void aVKKR27eGO8JYKykTN(object P_0, object P_1)
	{
		((WorkflowActivity)P_0).ContinueOnDefaultConnector((NativeActivityContext)P_1);
	}

	internal static object Vrsj6s5HKCl2erOkTv(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static void RCvunZgDxXmDd5M1ss(object P_0, object P_1)
	{
		((TaskActivity<CustomActivityElement>)P_0).ExecuteTask((NativeActivityContext)P_1);
	}
}
