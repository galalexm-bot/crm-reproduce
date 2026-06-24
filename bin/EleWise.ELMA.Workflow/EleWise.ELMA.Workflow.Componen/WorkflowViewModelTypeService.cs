using EleWise.ELMA.Components;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

public sealed class WorkflowViewModelTypeService : ViewModelTypeService
{
	public const string MetadataTypeCode = "WorkflowProcess";

	internal static WorkflowViewModelTypeService IMSqBLOB33wmtCDPLU4w;

	public override bool Check(string metadataTypeCode)
	{
		return iV6Ik4OBCPcNF0SNi1qb(metadataTypeCode, dTQIr0OBp49ByQwVao4U(-539998957 ^ -540016105));
	}

	public override ViewModelTypeName GetViewPropertyModelType(IPropertyMetadata property, string metadataNamespace)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(property is ITablePartMetadata))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return (ViewModelTypeName)o9xDc9OBMvnTTjiD6vSC(this, property, metadataNamespace);
			}
		}
	}

	public override ViewModelTypeName GetViewModelType(string metadataName, string metadataNamespace, bool useOriginalModel)
	{
		return null;
	}

	public WorkflowViewModelTypeService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		O4sb1eOBk2Ym4b0278qB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object dTQIr0OBp49ByQwVao4U(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool iV6Ik4OBCPcNF0SNi1qb(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool pdUqrUOBTPE5PL5swhXV()
	{
		return IMSqBLOB33wmtCDPLU4w == null;
	}

	internal static WorkflowViewModelTypeService mYpifBOBQSlS4BWBe4BI()
	{
		return IMSqBLOB33wmtCDPLU4w;
	}

	internal static object o9xDc9OBMvnTTjiD6vSC(object P_0, object P_1, object P_2)
	{
		return ((ViewModelTypeService)P_0).GetViewPropertyModelType((IPropertyMetadata)P_1, (string)P_2);
	}

	internal static void O4sb1eOBk2Ym4b0278qB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
