using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class WorkflowTaskAcrossOverflow : IWorkLogTaskOverallOverflow
{
	internal static WorkflowTaskAcrossOverflow fxJHPAObeGR7pds2Axa0;

	public bool CheckType(IEntity entity)
	{
		return entity is IWorkflowTaskBase;
	}

	public ICollection<long> GetId(IEntity currentWorkLogObject)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.task = currentWorkLogObject as IWorkflowTaskBase;
		CS_0024_003C_003E8__locals0.element = ((CS_0024_003C_003E8__locals0.task != null && CS_0024_003C_003E8__locals0.task.WorkflowBookmark != null) ? CS_0024_003C_003E8__locals0.task.WorkflowBookmark.Instance.Process.Diagram.Elements.FirstOrDefault(delegate(Element e)
		{
			int num = 2;
			int num2 = num;
			Guid guid = default(Guid);
			Guid? elementUid = default(Guid?);
			while (true)
			{
				switch (num2)
				{
				case 2:
					guid = _003C_003Ec__DisplayClass1_0.G4yhdKvZ1RNUPaRJnaIH(e);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					elementUid = ((IWorkflowBookmark)_003C_003Ec__DisplayClass1_0.AZD3bovZhyMooGvKKDKS(CS_0024_003C_003E8__locals0.task)).ElementUid;
					num2 = 3;
					break;
				default:
					return false;
				case 3:
					if (elementUid.HasValue)
					{
						return _003C_003Ec__DisplayClass1_0.UtDuX6vZEixWTsgrFTsL(guid, elementUid.GetValueOrDefault());
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}) : null);
		if (ComponentManager.Current.GetExtensionPoints<IWorkLogChecker>().FirstOrDefault((IWorkLogChecker e) => _003C_003Ec__DisplayClass1_0.W56XYivZwHUeUyY31Ta5(e, CS_0024_003C_003E8__locals0.element)) != null)
		{
			ICollection<long> collection = new List<long>();
			List<string> list = new List<string>();
			list.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130113968));
			{
				foreach (IWorkflowTaskBase allTask in WorkflowTaskBaseManager.Instance.GetAllTasks(CS_0024_003C_003E8__locals0.task.WorkflowBookmark.Instance, allowSubInstances: false, list, new Guid[1] { CS_0024_003C_003E8__locals0.element.Uid }))
				{
					collection.Add(allTask.Id);
				}
				return collection;
			}
		}
		return null;
	}

	public WorkflowTaskAcrossOverflow()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ME9fl9ObNq8U57MBwFuY()
	{
		return fxJHPAObeGR7pds2Axa0 == null;
	}

	internal static WorkflowTaskAcrossOverflow S0t4IOObxRKRTYeT2hi9()
	{
		return fxJHPAObeGR7pds2Axa0;
	}
}
