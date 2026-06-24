using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Extensions;

[Component]
internal class EmulationMessageExtension : IEmulationMessageExtension
{
	internal static EmulationMessageExtension XmlyVnFpxIjwyxqdPmO;

	private HashSet<Guid> TaskBaseChildClassesUids => new HashSet<Guid>(from c in MetadataLoader.GetChildClasses(MetadataServiceContext.Service.GetMetadata(InterfaceActivator.UID<ITaskBase>()) as EntityMetadata)
		select _003C_003Ec.jaAqEUZaYaixLvw7atGC(c));

	public bool SendMessage(IMessageBase messageBase, IEnumerable<IMessageChannel> messageChannel)
	{
		HashSet<Guid> taskBaseChildClassesUids = TaskBaseChildClassesUids;
		_003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals0;
		_003C_003Ec__DisplayClass2_2 CS_0024_003C_003E8__locals1;
		foreach (IMessage message3 in messageBase.GetMessages())
		{
			_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
			Guid value = message3.ObjectUid.Value;
			_003C_003Ec__DisplayClass2_.objectId = message3.ObjectId;
			if (taskBaseChildClassesUids.Contains(value))
			{
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_1();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass2_;
					CS_0024_003C_003E8__locals0.workflowTaskBase = null;
					Locator.GetServiceNotNull<ISecurityService>().RunBySystemUser(delegate
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
								CS_0024_003C_003E8__locals0.workflowTaskBase = WorkflowTaskBaseManager.Instance.LoadOrNull(_003C_003Ec__DisplayClass2_1.Ao9AlFZagQ5Te1jn5eaP(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.objectId));
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
								{
									num2 = 0;
								}
								break;
							}
						}
					});
					if (CS_0024_003C_003E8__locals0.workflowTaskBase != null && CS_0024_003C_003E8__locals0.workflowTaskBase.IsEmulation)
					{
						messageChannel = messageChannel.Where((IMessageChannel a) => _003C_003Ec.b2EttOZaJwm0yid3s6Fw(_003C_003Ec.ARPwlaZa8KmD5qhHXnEr(a), new Guid((string)_003C_003Ec.lQyc5xZasMx2PfVetAjM(0xF400DF8 ^ 0xF42D8E8))));
						if (messageChannel.Any())
						{
							CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass2_2();
							List<EleWise.ELMA.Security.IUser> list = message3.GetRecipients().ToList();
							EleWise.ELMA.Security.Models.IUser executorIsEmulation = CS_0024_003C_003E8__locals0.workflowTaskBase.ExecutorIsEmulation;
							CS_0024_003C_003E8__locals1.executor = CS_0024_003C_003E8__locals0.workflowTaskBase.Executor;
							if (executorIsEmulation != null && executorIsEmulation.GetId() != CS_0024_003C_003E8__locals1.executor.GetId())
							{
								List<EleWise.ELMA.Security.IUser> list2 = list.Where((EleWise.ELMA.Security.IUser r) => ((EleWise.ELMA.Security.Models.IUser)r).Id != CS_0024_003C_003E8__locals1.executor.Id).ToList();
								list2.Add(executorIsEmulation);
								list.Clear();
								list.AddRange(list2);
							}
							IWorkflowInstance instance = CS_0024_003C_003E8__locals0.workflowTaskBase.WorkflowBookmark.Instance;
							EmulationMessagesManager.Instance.SaveMessage(message3, list, CS_0024_003C_003E8__locals0.workflowTaskBase, instance, messageChannel);
							return true;
						}
					}
				}
				catch (Exception message)
				{
					Logger.Log.Error(message);
				}
			}
			Guid value2 = InterfaceActivator.UID<IWorkflowInstance>();
			Guid? objectUid = message3.ObjectUid;
			if (!(value2 == objectUid))
			{
				continue;
			}
			try
			{
				IWorkflowInstanceFilter workflowInstanceFilter = InterfaceActivator.Create<IWorkflowInstanceFilter>();
				workflowInstanceFilter.Id = Convert.ToInt64(_003C_003Ec__DisplayClass2_.objectId);
				workflowInstanceFilter.IsEmulation = true;
				if (WorkflowInstanceManager.Instance.Exists(workflowInstanceFilter))
				{
					ICollection<IWorkflowInstance> source = WorkflowInstanceManager.Instance.Find(workflowInstanceFilter, null);
					List<EleWise.ELMA.Security.IUser> recepient = message3.GetRecipients().ToList();
					IWorkflowInstance instance2 = source.FirstOrDefault();
					EmulationMessagesManager.Instance.SaveMessage(message3, recepient, null, instance2, messageChannel);
					return true;
				}
			}
			catch (Exception message2)
			{
				Logger.Log.Error(message2);
			}
		}
		return false;
	}

	public EmulationMessageExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HQjgLbFkU3T7SNOt1Rq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void HQjgLbFkU3T7SNOt1Rq()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool KsaIwOFCYs8KkXOnREn()
	{
		return XmlyVnFpxIjwyxqdPmO == null;
	}

	internal static EmulationMessageExtension yjrVP6FMkUfmhdbLcIA()
	{
		return XmlyVnFpxIjwyxqdPmO;
	}
}
