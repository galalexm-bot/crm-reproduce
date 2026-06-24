using System;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowMessageTypeParameterManager : EntityManager<IWorkflowMessageTypeParameter, long>
{
	internal static WorkflowMessageTypeParameterManager bt0LrPDpL5U8DUivNO2;

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
				type = InterfaceActivator.TypeOf<IWorkflowMessageTypeParameter>();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			bwibtDDyaDY1u4LFZxd(exportRule, type);
			GGMvQ6DOK9fWhLbgLtd(exportRule, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-481953825 ^ -481974861));
			ePhCnyD6cMV0PIg6K8T(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule obj = new ExportRule
			{
				ParentType = type,
				PropertyName = (string)aRMNj6DROKCdNqN5Xnr(0x2772A0C0 ^ 0x2772F660)
			};
			ePhCnyD6cMV0PIg6K8T(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule2 = new ExportRule();
			bwibtDDyaDY1u4LFZxd(exportRule2, type);
			exportRule2.PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-254800515 ^ -254780671);
			exportRule2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule2);
			ExportRule exportRule3 = new ExportRule();
			bwibtDDyaDY1u4LFZxd(exportRule3, type);
			GGMvQ6DOK9fWhLbgLtd(exportRule3, aRMNj6DROKCdNqN5Xnr(-1917423727 ^ -1917436861));
			exportRule3.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			bwibtDDyaDY1u4LFZxd(exportRule4, type);
			exportRule4.PropertyName = (string)aRMNj6DROKCdNqN5Xnr(--286570904 ^ 0x1114EF58);
			ePhCnyD6cMV0PIg6K8T(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			return exportRuleList;
		}
	}

	public WorkflowMessageTypeParameterManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SsTWh5D0qqTdcWf1ZiL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f1ba867523264a63932ee1e8d0cd4a24 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void bwibtDDyaDY1u4LFZxd(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static void GGMvQ6DOK9fWhLbgLtd(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void ePhCnyD6cMV0PIg6K8T(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static object aRMNj6DROKCdNqN5Xnr(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool FacYCgDGu1eGdmvU29h()
	{
		return bt0LrPDpL5U8DUivNO2 == null;
	}

	internal static WorkflowMessageTypeParameterManager vIGp4dDnM8LygGvY4p4()
	{
		return bt0LrPDpL5U8DUivNO2;
	}

	internal static void SsTWh5D0qqTdcWf1ZiL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
