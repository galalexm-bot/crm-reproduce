using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Component(Order = 200)]
public class OrganizationItemRecipientForNotification : RecipientInfoForNotification
{
	internal static OrganizationItemRecipientForNotification va232rZtQfT2RqLbgGrO;

	[XmlIgnore]
	public List<Guid> Structures
	{
		get
		{
			if (base.RecipientValue != null)
			{
				return (List<Guid>)base.RecipientValue;
			}
			return new List<Guid>();
		}
		set
		{
			base.RecipientValue = value;
		}
	}

	public override IEnumerable<object> GetRecipients(IWorkflowInstance instance)
	{
		if (!(base.RecipientValue is IEnumerable<Guid>))
		{
			return null;
		}
		List<Guid> list = base.RecipientValue as List<Guid>;
		List<IUser> list2 = new List<IUser>();
		if (list == null || !list.Any())
		{
			throw new GetRecipientsException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x5599C748)));
		}
		foreach (Guid item in list)
		{
			list2.AddRange(RecipientInfoForNotificationHelper.GetUsersFromStrucutre(item));
		}
		return list2;
	}

	public OrganizationItemRecipientForNotification()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pSpFmjZtMrZqleXf2HDx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void pSpFmjZtMrZqleXf2HDx()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool CAKEG2ZtpPYCfXPRid66()
	{
		return va232rZtQfT2RqLbgGrO == null;
	}

	internal static OrganizationItemRecipientForNotification YXb8a5ZtCPy3xNavwOrY()
	{
		return va232rZtQfT2RqLbgGrO;
	}
}
