using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components.Feed;

[Component]
internal class FeedModelWorkflowInstanceMapper : IFeedModelEntityMapper
{
	internal static FeedModelWorkflowInstanceMapper vCOhNjOcLjEegnC4Yrwb;

	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		//Discarded unreachable code: IL_006e, IL_007d
		int num = 3;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 3:
				workflowInstance = entity as IWorkflowInstance;
				num2 = 2;
				break;
			case 1:
				return originalModel;
			default:
				return (FeedModel)jLBRaOOcWBeocIcKQX52(workflowInstance);
			case 2:
				if (workflowInstance != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	internal static FeedModel GetParentFeedModel(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_00a1, IL_00b0, IL_00ef, IL_0188, IL_0197, IL_01a6
		int num = 4;
		string text = default(string);
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					if (!pL4xYmOc6tE4e9p2w5gs(wyb1NgOcRai2fI6kHMGw(instance)))
					{
						num2 = 12;
						continue;
					}
					goto case 7;
				case 7:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 2:
				case 6:
				case 10:
					if (!pL4xYmOc6tE4e9p2w5gs(text))
					{
						num = 13;
						break;
					}
					goto case 5;
				default:
					if (NI0J6XOcqDcx1tbwpor2(instance) == null)
					{
						num2 = 10;
						continue;
					}
					goto case 1;
				case 4:
					if (instance != null)
					{
						num = 3;
						break;
					}
					goto case 11;
				case 9:
					text = SR.T((string)TTV8a3Oc3pj7lM2xwrQL(instance.Process));
					num2 = 2;
					continue;
				case 1:
					if (!string.IsNullOrEmpty((string)TTV8a3Oc3pj7lM2xwrQL(NI0J6XOcqDcx1tbwpor2(instance))))
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				case 11:
					return null;
				case 3:
					guid = mOSKKYOcjRKuUMYkh4Qf(instance.GetType(), true);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
					{
						num2 = 14;
					}
					continue;
				case 14:
					text = string.Empty;
					num2 = 15;
					continue;
				case 5:
					text = (InterfaceActivator.LoadMetadata<IWorkflowProcess>() as ClassMetadata).DisplayName;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 8;
					}
					continue;
				case 12:
					text = (string)wyb1NgOcRai2fI6kHMGw(instance);
					num2 = 7;
					continue;
				case 8:
				case 13:
				{
					FeedModel feedModel = new FeedModel();
					QtpvQaOcTmm2u9h0rToY(feedModel, instance.Id);
					XLRMmsOcQ9QgKAABvFPX(feedModel, guid);
					bhkfrlOcpajJitZOZy83(feedModel, DefaultEntityActions.CreateGuid);
					feedModel.ParentObjectId = instance.Id;
					feedModel.ParentObjectUid = guid;
					feedModel.ChangeDate = DateTime.Now;
					Lk3wasOcMjdZ5T0fq8Cx(feedModel, G8KaqSOcCMC7R3dkIDyp(instance));
					feedModel.CreationDate = (instance.StartDate.HasValue ? instance.StartDate.Value : f88DRCOckJIF2Na7k8M8());
					xiO9ivOcUV6v7h3eGjJQ(feedModel, true);
					z21PkcOcV0abELKpUmYe(feedModel, text);
					AmXGlmOcAFW2gvo8T68w(feedModel, string.Empty);
					qXiXpcOcGmlqNJkMhk6l(feedModel, FeedMessageUpdateProviderBase<IWorkflowInstance>.GetMessageAttachments(instance));
					return feedModel;
				}
				}
				break;
			}
		}
	}

	public FeedModelWorkflowInstanceMapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object jLBRaOOcWBeocIcKQX52(object P_0)
	{
		return GetParentFeedModel((IWorkflowInstance)P_0);
	}

	internal static bool keeiwLOcfZINLknVWDod()
	{
		return vCOhNjOcLjEegnC4Yrwb == null;
	}

	internal static FeedModelWorkflowInstanceMapper hsgmstOc9RAiMxEnB1Dn()
	{
		return vCOhNjOcLjEegnC4Yrwb;
	}

	internal static Guid mOSKKYOcjRKuUMYkh4Qf(Type P_0, bool P_1)
	{
		return InterfaceActivator.UID(P_0, P_1);
	}

	internal static object wyb1NgOcRai2fI6kHMGw(object P_0)
	{
		return ((IWorkflowInstance)P_0).Name;
	}

	internal static bool pL4xYmOc6tE4e9p2w5gs(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object NI0J6XOcqDcx1tbwpor2(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object TTV8a3Oc3pj7lM2xwrQL(object P_0)
	{
		return ((IWorkflowProcess)P_0).Name;
	}

	internal static void QtpvQaOcTmm2u9h0rToY(object P_0, long P_1)
	{
		((FeedModel)P_0).ActionObjectId = P_1;
	}

	internal static void XLRMmsOcQ9QgKAABvFPX(object P_0, Guid P_1)
	{
		((FeedModel)P_0).ActionObjectUid = P_1;
	}

	internal static void bhkfrlOcpajJitZOZy83(object P_0, Guid P_1)
	{
		((FeedModel)P_0).ActionUid = P_1;
	}

	internal static object G8KaqSOcCMC7R3dkIDyp(object P_0)
	{
		return ((IWorkflowInstance)P_0).Initiator;
	}

	internal static void Lk3wasOcMjdZ5T0fq8Cx(object P_0, object P_1)
	{
		((FeedModel)P_0).CreationAuthor = (IUser)P_1;
	}

	internal static DateTime f88DRCOckJIF2Na7k8M8()
	{
		return DateTime.Now;
	}

	internal static void xiO9ivOcUV6v7h3eGjJQ(object P_0, bool P_1)
	{
		((FeedModel)P_0).IsParent = P_1;
	}

	internal static void z21PkcOcV0abELKpUmYe(object P_0, object P_1)
	{
		((FeedModel)P_0).Subject = (string)P_1;
	}

	internal static void AmXGlmOcAFW2gvo8T68w(object P_0, object P_1)
	{
		((FeedModel)P_0).Text = (string)P_1;
	}

	internal static void qXiXpcOcGmlqNJkMhk6l(object P_0, object P_1)
	{
		((FeedModel)P_0).MessageAttachments = (FeedMessageAttachmentList)P_1;
	}
}
