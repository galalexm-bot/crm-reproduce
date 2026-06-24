using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Extensions;

[Component(Order = 200)]
public class FilterPortletCheckPermissionExtensions : IFilterPortletCheckPermission
{
	private static FilterPortletCheckPermissionExtensions caE3YLYSON6TZXPrEYO;

	public bool AvailablePermissionType(Guid TypeUid)
	{
		return PvsPdaYUM6LeJul7cy7(TypeUid, InterfaceActivator.UID<IWorkflowInstance>());
	}

	public bool HasPermission(Guid TypeUid)
	{
		return vPp5SeYm4BbdJAvIPiN(Locator.GetServiceNotNull<ISecurityService>(), WorkflowGlobalPermissionProvider.WorkflowAccessPermission);
	}

	public FilterPortletCheckPermissionExtensions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qQeAgEYAa9AonP0XREd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool PvsPdaYUM6LeJul7cy7(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool VJggQBYkHOt1LM8VwVr()
	{
		return caE3YLYSON6TZXPrEYO == null;
	}

	internal static FilterPortletCheckPermissionExtensions qGsQEZYbCSQaET10wwg()
	{
		return caE3YLYSON6TZXPrEYO;
	}

	internal static bool vPp5SeYm4BbdJAvIPiN(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}

	internal static void qQeAgEYAa9AonP0XREd()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
