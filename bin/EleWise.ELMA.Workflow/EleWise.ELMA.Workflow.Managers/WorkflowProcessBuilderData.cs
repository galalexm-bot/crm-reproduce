using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowProcessBuilderData
{
	private static WorkflowProcessBuilderData U76DbEDMOfy6mLMAJgq;

	public ModelAssemblyBuilder Builder
	{
		[CompilerGenerated]
		get
		{
			return _003CBuilder_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CBuilder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<IMetadata> MetadataToRegister { get; private set; }

	public List<Tuple<IMetadata, GenerationParams>> MetadataToAdd { get; private set; }

	public WorkflowProcessBuilderData()
	{
		//Discarded unreachable code: IL_002a
		SylCI7DVibCSN9yLUsO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				MetadataToRegister = new List<IMetadata>();
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
				{
					num = 3;
				}
				break;
			case 5:
				MetadataToAdd = new List<Tuple<IMetadata, GenerationParams>>();
				num = 3;
				break;
			case 2:
				Y0TRKPD716CJDo7kXsN(Builder, gZ5DoODG9qIYoYpLIpM(-1647793954 ^ -1647796980));
				num = 4;
				break;
			case 3:
				Builder = new ModelAssemblyBuilder();
				num = 6;
				break;
			case 1:
			{
				Y0TRKPD716CJDo7kXsN(Builder, gZ5DoODG9qIYoYpLIpM(-961162596 ^ -961157214));
				int num2 = 2;
				num = num2;
				break;
			}
			case 4:
				return;
			case 6:
				GlmqiRDAUASr4i8ZTZM(Builder);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void SylCI7DVibCSN9yLUsO()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void GlmqiRDAUASr4i8ZTZM(object P_0)
	{
		((AssemblyBuilder)P_0).AddDefaultReferences();
	}

	internal static object gZ5DoODG9qIYoYpLIpM(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Y0TRKPD716CJDo7kXsN(object P_0, object P_1)
	{
		return ((AssemblyBuilder)P_0).AddReferenceByName((string)P_1);
	}

	internal static bool p34JdoDkdS3JEGYSnDw()
	{
		return U76DbEDMOfy6mLMAJgq == null;
	}

	internal static WorkflowProcessBuilderData xvUM7KDUZ1tFDQyG27U()
	{
		return U76DbEDMOfy6mLMAJgq;
	}
}
