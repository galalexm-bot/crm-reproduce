using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components.Feed;

[Component(Order = 500)]
public class WorkflowInstanceFeedCommentActionNameExtension : DefaultFeedCommentActionNameExtension
{
	internal static WorkflowInstanceFeedCommentActionNameExtension V47AfkOcckfPamJx3bGX;

	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (MetadataLoader.IsBaseOrChildClass<IWorkflowInstance>(objectTypeUid))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return gggrS0OcdxVpCghdw7kW(actionUid, WorkflowInstanceActions.NotificationGuid);
			}
		}
	}

	public override string ActionName(FeedModel message)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0054, IL_0063
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (message != null)
					{
						goto IL_0074;
					}
					break;
				default:
					return (string)O822DSOcnS2ffwUR2vjk(message);
				case 4:
					return string.Empty;
				case 1:
					break;
				case 2:
					if (!gggrS0OcdxVpCghdw7kW(QCeyWNOcuvRBVkVb2yCc(message), new Guid((string)BhPvy6OcDsQvMyxp17N6(0x75BAD659 ^ 0x75BB1A35))))
					{
						goto end_IL_0012;
					}
					goto default;
				}
				return string.Empty;
				IL_0074:
				num2 = 2;
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public WorkflowInstanceFeedCommentActionNameExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mKj7jcOcHXi3oFoM0ppb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool gggrS0OcdxVpCghdw7kW(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool gfXXWLOcP8DJ0NXqmZOR()
	{
		return V47AfkOcckfPamJx3bGX == null;
	}

	internal static WorkflowInstanceFeedCommentActionNameExtension Rr7N1QOcXmu9tqmkjbkX()
	{
		return V47AfkOcckfPamJx3bGX;
	}

	internal static Guid QCeyWNOcuvRBVkVb2yCc(object P_0)
	{
		return ((FeedModel)P_0).ActionUid;
	}

	internal static object BhPvy6OcDsQvMyxp17N6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object O822DSOcnS2ffwUR2vjk(object P_0)
	{
		return ((FeedModel)P_0).Subject;
	}

	internal static void mKj7jcOcHXi3oFoM0ppb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
