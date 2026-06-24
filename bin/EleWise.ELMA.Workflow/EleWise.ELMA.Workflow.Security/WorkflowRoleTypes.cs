using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class WorkflowRoleTypes : IPermissionRoleTypeProvider
{
	public static readonly PermissionRoleType CurrentExecutor;

	public static readonly PermissionRoleType DirectorsOfCurrentExecutor;

	public static readonly PermissionRoleType Initiator;

	public static readonly PermissionRoleType ProcessCurator;

	public static readonly PermissionRoleType ProcessInstanceMember;

	public static readonly PermissionRoleType ProcessOwner;

	public static readonly PermissionRoleType ResponsibleForInstance;

	private static WorkflowRoleTypes nhNHAeyQsqNnuPu48Ty;

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return new PermissionRoleType[7] { CurrentExecutor, DirectorsOfCurrentExecutor, Initiator, ProcessCurator, ProcessInstanceMember, ProcessOwner, ResponsibleForInstance };
	}

	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType currentExecutor = CurrentExecutor;
		PermissionRoleType directorsOfCurrentExecutor = DirectorsOfCurrentExecutor;
		PermissionRoleType initiator = Initiator;
		PermissionRoleType processCurator = ProcessCurator;
		PermissionRoleType processInstanceMember = ProcessInstanceMember;
		PermissionRoleType processOwner = ProcessOwner;
		PermissionRoleType responsibleForInstance = ResponsibleForInstance;
		PermissionRoleType[] roleTypes = new PermissionRoleType[10] { currentExecutor, directorsOfCurrentExecutor, initiator, processCurator, processInstanceMember, processOwner, responsibleForInstance, organizationItem, group, user };
		return new PermissionRoleTypeStereotype[9]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IProcessHeader>(), WorkflowPermissionProvider.MyProcessesPermission, new PermissionRoleType[6] { responsibleForInstance, initiator, currentExecutor, organizationItem, group, user }),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IProcessHeader>(), WorkflowPermissionProvider.ProcessMonitor, new PermissionRoleType[5] { processOwner, processCurator, organizationItem, group, user }),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IProcessHeader>(), WorkflowPermissionProvider.MembersManagement, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IProcessHeader>(), WorkflowPermissionProvider.AssignResponsibleForInstance, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IProcessHeader>(), WorkflowPermissionProvider.TerminateProcess, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IProcessHeader>(), WorkflowPermissionProvider.ViewTaskListOfInstance, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IProcessHeader>(), WorkflowPermissionProvider.EditDataProcess, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IProcessHeader>(), WorkflowPermissionProvider.ReassignProcessTask, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IProcessHeader>(), WorkflowPermissionProvider.ChangeProcessVersionPermission, roleTypes)
		};
	}

	public WorkflowRoleTypes()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oDnF2KyMV3jYIZsHX71();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowRoleTypes()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				CurrentExecutor = new PermissionRoleType(new Guid((string)hiZuwfykRxrAQEK93o2(0x1134D2C0 ^ 0x1134FD22)), (string)mdbLFQyU4l1nW4s3Llo(hiZuwfykRxrAQEK93o2(0x69063C81 ^ 0x69060CAF)));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				ProcessCurator = new PermissionRoleType(new Guid((string)hiZuwfykRxrAQEK93o2(--1436248540 ^ 0x559B5894)), (string)mdbLFQyU4l1nW4s3Llo(hiZuwfykRxrAQEK93o2(0x246EEF98 ^ 0x246EDE0C)));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				oDnF2KyMV3jYIZsHX71();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 2;
				}
				break;
			default:
				ProcessInstanceMember = new PermissionRoleType(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C660C07)), (string)mdbLFQyU4l1nW4s3Llo(hiZuwfykRxrAQEK93o2(-865213812 ^ -865217666)));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
				{
					num2 = 8;
				}
				break;
			case 2:
				DirectorsOfCurrentExecutor = new PermissionRoleType(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130094962)), (string)mdbLFQyU4l1nW4s3Llo(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965279255)));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				ResponsibleForInstance = new PermissionRoleType(new Guid((string)hiZuwfykRxrAQEK93o2(-1001967776 ^ -1001972288)), SR.M((string)hiZuwfykRxrAQEK93o2(-43932417 ^ -43936237)));
				num2 = 6;
				break;
			case 8:
				ProcessOwner = new PermissionRoleType(new Guid((string)hiZuwfykRxrAQEK93o2(-682910880 ^ -682907314)), (string)mdbLFQyU4l1nW4s3Llo(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -63015345)));
				num2 = 5;
				break;
			case 6:
				return;
			case 7:
				Initiator = new PermissionRoleType(new Guid((string)hiZuwfykRxrAQEK93o2(-39189604 ^ -39177350)), (string)mdbLFQyU4l1nW4s3Llo(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483F9340)));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void oDnF2KyMV3jYIZsHX71()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool QEIaWqyph8hoLwqFBwP()
	{
		return nhNHAeyQsqNnuPu48Ty == null;
	}

	internal static WorkflowRoleTypes su7OMoyCoSXnOvMhAyW()
	{
		return nhNHAeyQsqNnuPu48Ty;
	}

	internal static object hiZuwfykRxrAQEK93o2(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object mdbLFQyU4l1nW4s3Llo(object P_0)
	{
		return SR.M((string)P_0);
	}
}
