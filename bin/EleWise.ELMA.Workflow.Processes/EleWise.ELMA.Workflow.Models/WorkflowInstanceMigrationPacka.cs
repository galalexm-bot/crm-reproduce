using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowInstanceMigrationPackageActions : DefaultEntityActions
{
	[Uid("9fd90747-ab6d-4a25-9fa9-72dcb2668f50")]
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationPackageActions), "P_ProcessSuccess_DisplayName")]
	public const string ProcessSuccess = "9fd90747-ab6d-4a25-9fa9-72dcb2668f50";

	private static Guid _processSuccessGuid;

	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationPackageActions), "P_ProcessError_DisplayName")]
	[Uid("62ceca61-e899-4037-a4cb-358b5934f326")]
	public const string ProcessError = "62ceca61-e899-4037-a4cb-358b5934f326";

	private static Guid _processErrorGuid;

	internal static WorkflowInstanceMigrationPackageActions v72wESsxmND4jwlglEb;

	public static Guid ProcessSuccessGuid => _processSuccessGuid;

	public static Guid ProcessErrorGuid => _processErrorGuid;

	protected WorkflowInstanceMigrationPackageActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HQjSS2swYcXAvGbFdEZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowInstanceMigrationPackageActions()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				HQjSS2swYcXAvGbFdEZ();
				num2 = 2;
				break;
			case 1:
				_processErrorGuid = new Guid((string)BHq8mxstyYukItCYmAj(-1756425685 ^ -1756409033));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				_processSuccessGuid = new Guid((string)BHq8mxstyYukItCYmAj(-408604271 ^ -408587967));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void HQjSS2swYcXAvGbFdEZ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool SQge72sFBCAGwDj0NAm()
	{
		return v72wESsxmND4jwlglEb == null;
	}

	internal static WorkflowInstanceMigrationPackageActions POM3mus8u4RYt8w8YKl()
	{
		return v72wESsxmND4jwlglEb;
	}

	internal static object BHq8mxstyYukItCYmAj(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
[Uid("532fe071-967a-4e43-8bcf-2d8b2471b130")]
[DisplayName(typeof(__Resources_WorkflowInstanceMigrationPackageStatus), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
public enum WorkflowInstanceMigrationPackageStatus
{
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationPackageStatus), "P_New_DisplayName")]
	[Uid("56cfa3d9-2b72-4678-861d-84872b71bd91")]
	New,
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationPackageStatus), "P_InProgress_DisplayName")]
	[Uid("17682403-4a95-4ee5-91d8-1a5d5bb68ed3")]
	InProgress,
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationPackageStatus), "P_Processed_DisplayName")]
	[Uid("80c5b5ed-6923-497c-8b54-55d824628481")]
	Processed,
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationPackageStatus), "P_ProcessedWithErrors_DisplayName")]
	[Uid("67f061a7-e97c-4068-a7a0-e22a921dc3a5")]
	ProcessedWithErrors,
	[Uid("b967bf5d-a356-4a34-94d6-84c74314579d")]
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationPackageStatus), "P_ReOpen_DisplayName")]
	ReOpen
}
