using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Managers;

public class EmulationMessagesManager : EntityManager<IEmulationMessages, long>
{
	private static EmulationMessagesManager LPEa2VBu7DAf3lMCQ7C;

	public new static EmulationMessagesManager Instance => Locator.GetServiceNotNull<EmulationMessagesManager>();

	public void SaveMessage(IMessage message, List<EleWise.ELMA.Security.IUser> recepient, IWorkflowTaskBase task, IWorkflowInstance instance, IEnumerable<IMessageChannel> MessageChannel)
	{
		IEmulationMessages emulationMessages = Instance.Create();
		emulationMessages.DateMessage = DateTime.Now;
		emulationMessages.ObjectUid = message.ObjectUid;
		emulationMessages.Subject = message.Subject;
		emulationMessages.Text = message.ShortMessageText;
		emulationMessages.TextHtml = message.ShortMessageHtml;
		emulationMessages.WorkflowInstance = instance;
		if (task != null && task is IWorkflowTask)
		{
			emulationMessages.Task = (IWorkflowTask)task;
		}
		emulationMessages.TextHtml = message.FullMessageHtml;
		List<EleWise.ELMA.Security.Models.IUser> list = new List<EleWise.ELMA.Security.Models.IUser>();
		foreach (EleWise.ELMA.Security.IUser item in recepient)
		{
			list.Add((EleWise.ELMA.Security.Models.IUser)item);
		}
		emulationMessages.Recipients.AddAll((ICollection<EleWise.ELMA.Security.Models.IUser>)list);
		emulationMessages.Recipient = list.FirstOrDefault();
		List<Guid> list2 = new List<Guid>();
		foreach (IMessageChannel item2 in MessageChannel)
		{
			list2.Add(item2.Uid);
		}
		emulationMessages.ChannelMessage = list2;
		Instance.Save(emulationMessages);
	}

	public EmulationMessagesManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YICS0IBHTIvh9sEY54V();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void YICS0IBHTIvh9sEY54V()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool xqKOHIBDshdjBhUdl91()
	{
		return LPEa2VBu7DAf3lMCQ7C == null;
	}

	internal static EmulationMessagesManager DrCb8xBndYvDYiCVbMw()
	{
		return LPEa2VBu7DAf3lMCQ7C;
	}
}
