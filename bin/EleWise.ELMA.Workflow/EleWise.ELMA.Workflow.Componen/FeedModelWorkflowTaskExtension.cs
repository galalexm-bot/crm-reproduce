using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components.Feed;

[Component(Order = 10)]
internal class FeedModelWorkflowTaskExtensionMapper : IFeedModelEntityMapper
{
	private static FeedModelWorkflowTaskExtensionMapper irUgDlOcs7x9dOMa50Ty;

	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 1;
		int num2 = num;
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		while (true)
		{
			switch (num2)
			{
			case 1:
				workflowTaskBase = entity as IWorkflowTaskBase;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return originalModel;
			default:
				if (workflowTaskBase != null)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 4:
				return originalModel;
			case 3:
				od5ivZOc06bEk4H0q6eM(workflowTaskBase, originalModel);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static void Update(object task, object originalModel)
	{
		//Discarded unreachable code: IL_00d5, IL_00e4, IL_012a, IL_013e, IL_0148, IL_025f, IL_026e
		int num = 6;
		int num2 = num;
		List<MessageObject> list2 = default(List<MessageObject>);
		MessageObject item = default(MessageObject);
		MessageObject messageObject = default(MessageObject);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			List<MessageObject> list;
			switch (num2)
			{
			case 1:
				list2.Insert(0, item);
				num2 = 15;
				continue;
			case 18:
				messageObject.Name = workflowInstance.Name;
				num2 = 19;
				continue;
			default:
				messageObject.Id = workflowInstance.Id.ToString((IFormatProvider)J9OOtSOcbbDY21kgJb1m());
				num2 = 18;
				continue;
			case 19:
				item = messageObject;
				num2 = 13;
				continue;
			case 2:
				return;
			case 11:
				if (entityMetadata == null)
				{
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
					{
						num2 = 12;
					}
				}
				else
				{
					messageObject = default(MessageObject);
					num2 = 14;
				}
				continue;
			case 9:
				if (rmuZUNOcyJCg1sjxcyVS(task) == null)
				{
					num2 = 2;
					continue;
				}
				goto case 8;
			case 10:
				list = new List<MessageObject>();
				break;
			case 5:
				return;
			case 13:
				if (((IEnumerable<MessageObject>)EL1FTVOc5tZAxr7V4OVS(originalModel)).Any())
				{
					num2 = 7;
					continue;
				}
				goto case 10;
			case 15:
				OTgLoEOcgoVWjyn2rfPB(originalModel, new FeedMessageObjectList(list2));
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
				{
					num2 = 16;
				}
				continue;
			case 16:
				return;
			case 4:
				return;
			case 3:
				workflowInstance = ((IWorkflowInstance)KrNfeWOcmAHCaU8DWoP7(((IWorkflowTaskBase)task).WorkflowBookmark)).CastAsRealType();
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
				{
					num2 = 17;
				}
				continue;
			case 12:
				return;
			case 14:
				messageObject.TypeUid = entityMetadata.ImplementationUid;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				if (KrNfeWOcmAHCaU8DWoP7(rmuZUNOcyJCg1sjxcyVS(task)) == null)
				{
					return;
				}
				num2 = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
				{
					num2 = 20;
				}
				continue;
			case 20:
				if (originalModel == null)
				{
					return;
				}
				num2 = 3;
				continue;
			case 6:
				if (task == null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 9;
			case 17:
				entityMetadata = FyA6PCOctQx1hxHx8ig3(workflowInstance.GetType(), true, true) as EntityMetadata;
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
				{
					num2 = 11;
				}
				continue;
			case 7:
				list = ((IEnumerable<MessageObject>)EL1FTVOc5tZAxr7V4OVS(originalModel)).ToList();
				break;
			}
			list2 = list;
			num2 = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
			{
				num2 = 1;
			}
		}
	}

	public FeedModelWorkflowTaskExtensionMapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xdmjGWOcBEKiMmr3yJNQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void od5ivZOc06bEk4H0q6eM(object P_0, object P_1)
	{
		Update(P_0, P_1);
	}

	internal static bool clXbyUOcJOjwwJvLYHH5()
	{
		return irUgDlOcs7x9dOMa50Ty == null;
	}

	internal static FeedModelWorkflowTaskExtensionMapper cHYnEjOclG15pYxlT2MD()
	{
		return irUgDlOcs7x9dOMa50Ty;
	}

	internal static object rmuZUNOcyJCg1sjxcyVS(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object KrNfeWOcmAHCaU8DWoP7(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object FyA6PCOctQx1hxHx8ig3(Type P_0, bool P_1, bool P_2)
	{
		return InterfaceActivator.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object J9OOtSOcbbDY21kgJb1m()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object EL1FTVOc5tZAxr7V4OVS(object P_0)
	{
		return ((FeedModel)P_0).MessageObjects;
	}

	internal static void OTgLoEOcgoVWjyn2rfPB(object P_0, object P_1)
	{
		((FeedModel)P_0).MessageObjects = (FeedMessageObjectList)P_1;
	}

	internal static void xdmjGWOcBEKiMmr3yJNQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
