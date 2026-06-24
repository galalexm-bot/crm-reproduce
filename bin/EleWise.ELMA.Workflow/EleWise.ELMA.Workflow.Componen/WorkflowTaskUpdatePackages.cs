using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.ExtensionPoints.API;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.API.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class WorkflowTaskUpdatePackages : ITaskUpdatePackages
{
	[Component(Order = 130)]
	internal class PackageService : TaskUpdatePackageServiceBase
	{
		private static PackageService GllNhdvZ4elmKX8RMFRw;

		public override string ServiceName => (string)CT31PqvvZPg1efNTLlDf(Skr9R2vvONOMAERsEh84(0xB7793C9 ^ 0xB754493));

		public override Guid ServiceUid => serviceUid;

		[IteratorStateMachine(typeof(_003CKnownTypes_003Ed__0))]
		public override IEnumerable<Type> KnownTypes(ICustomAttributeProvider provider)
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			return new _003CKnownTypes_003Ed__0(-2);
		}

		public PackageService()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			F5n8S8vvvEHqBSHPNOjU();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object Skr9R2vvONOMAERsEh84(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object CT31PqvvZPg1efNTLlDf(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool fUP69cvZzju93m9ZFbDp()
		{
			return GllNhdvZ4elmKX8RMFRw == null;
		}

		internal static PackageService Xec0LbvvKCR7PrJtqVWY()
		{
			return GllNhdvZ4elmKX8RMFRw;
		}

		internal static void F5n8S8vvvEHqBSHPNOjU()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static readonly Guid serviceUid;

	private static Guid[] typeUids;

	internal static WorkflowTaskUpdatePackages NWNa2DO5KSganPqKqVMf;

	public Guid ServiceUid => serviceUid;

	public Guid[] TypeUids
	{
		get
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = typeUids;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = new Guid[1] { InterfaceActivator.UID<IWorkflowTask>() };
					typeUids = (Guid[])obj;
					break;
				}
				break;
			}
			return (Guid[])obj;
		}
	}

	public IEnumerable<PackageBase> ConvertPackages(IEnumerable<ITaskBase> updateIdPackages)
	{
		return updateIdPackages.OfType<IWorkflowTask>().Select((Func<IWorkflowTask, PackageBase>)((IWorkflowTask task) => new WorkflowTaskPackage(TypeUids[0])
		{
			Data = new WorkflowTaskWCF(task)
		})).ToArray();
	}

	public IEnumerable<PackageBase> ConvertPackages(Guid serviceUid, IEnumerable<ITaskBase> updateIdPackages)
	{
		return ConvertPackages(updateIdPackages);
	}

	public WorkflowTaskUpdatePackages()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IWa0yuO5vg5pX7JaaVHQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowTaskUpdatePackages()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				IWa0yuO5vg5pX7JaaVHQ();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				serviceUid = new Guid((string)QmqIr1O5YxODNHy8vywX(-495296780 ^ -495215602));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool UFf9wjO5ONqTaTc1lMLk()
	{
		return NWNa2DO5KSganPqKqVMf == null;
	}

	internal static WorkflowTaskUpdatePackages dvFeAPO5ZHT821QV7bmS()
	{
		return NWNa2DO5KSganPqKqVMf;
	}

	internal static void IWa0yuO5vg5pX7JaaVHQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object QmqIr1O5YxODNHy8vywX(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
