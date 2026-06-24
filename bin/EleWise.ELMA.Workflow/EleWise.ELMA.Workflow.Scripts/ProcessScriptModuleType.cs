using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Workflow.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scripts;

public class ProcessScriptModuleType : IScriptModuleType
{
	public class Parameters
	{
		internal static Parameters opwwk0ZWMFqsX6OWKcCt;

		public string ProcessEntityName
		{
			[CompilerGenerated]
			get
			{
				return _003CProcessEntityName_003Ek__BackingField;
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
					case 1:
						_003CProcessEntityName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public Parameters()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			oV1KNvZWVLX6jRhQ0Dfb();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool r8UuYQZWkPJa50XUeoGK()
		{
			return opwwk0ZWMFqsX6OWKcCt == null;
		}

		internal static Parameters s68gCaZWUB43i4ZodRAy()
		{
			return opwwk0ZWMFqsX6OWKcCt;
		}

		internal static void oV1KNvZWVLX6jRhQ0Dfb()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	public const string UID_S = "{F5DB64FB-5893-4F9C-81E5-732D863ACD5E}";

	public static readonly Guid UID;

	private static readonly string Example;

	internal static ProcessScriptModuleType COm3AmmDxyxS3QbAyrK;

	public Guid Uid => UID;

	public string Name => (string)xVJJf0mjbNMAchbIr1w(nV1XOwmL18PdC2oFeIo(-63028171 ^ -63016233));

	public static string GenerateSourceCode(WorkflowProcessDTO wp)
	{
		//Discarded unreachable code: IL_00e4
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		object resourceName;
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass3_.summary = (string)WkAStbm9ivpAeOxXW4C(nV1XOwmL18PdC2oFeIo(0x51EF0063 ^ 0x51EF366B), new object[1] { gavOFsmfsceZ9FTaQwC(_003C_003Ec__DisplayClass3_.wp) });
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				if (cbAlMumWyI8hFsKy2Hh(_003C_003Ec__DisplayClass3_.wp.Context) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				resourceName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6C4980);
				break;
			case 4:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 3;
				continue;
			case 3:
				_003C_003Ec__DisplayClass3_.wp = wp;
				num2 = 2;
				continue;
			case 1:
				resourceName = nV1XOwmL18PdC2oFeIo(--1212129906 ^ 0x483F9438);
				break;
			}
			break;
		}
		return ResourceTemplateGenerator.GenerateTemplate<ProcessScriptModuleType>((string)resourceName, _003C_003Ec__DisplayClass3_._003CGenerateSourceCode_003Eb__0);
	}

	public string GenerateSourceCode(object parameters)
	{
		return (string)WTUMt6mR0jxQWkyG2Y7((WorkflowProcessDTO)parameters);
	}

	public ScriptCompileResult Compile(ScriptModule module)
	{
		throw new NotImplementedException();
	}

	public ProcessScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		c7AhAEm6LvfbwJjM5MV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessScriptModuleType()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				Example = (string)xVJJf0mjbNMAchbIr1w(nV1XOwmL18PdC2oFeIo(-1776305410 ^ -1776317034));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				c7AhAEm6LvfbwJjM5MV();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)nV1XOwmL18PdC2oFeIo(0x7AC609FE ^ 0x7AC63EE6));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static object nV1XOwmL18PdC2oFeIo(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object gavOFsmfsceZ9FTaQwC(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Name;
	}

	internal static object WkAStbm9ivpAeOxXW4C(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object cbAlMumWyI8hFsKy2Hh(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static bool ofDpYBmnJAcm5AyDr3k()
	{
		return COm3AmmDxyxS3QbAyrK == null;
	}

	internal static ProcessScriptModuleType rPTHe3mHu4N1Huv3JGc()
	{
		return COm3AmmDxyxS3QbAyrK;
	}

	internal static object xVJJf0mjbNMAchbIr1w(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object WTUMt6mR0jxQWkyG2Y7(object P_0)
	{
		return GenerateSourceCode((WorkflowProcessDTO)P_0);
	}

	internal static void c7AhAEm6LvfbwJjM5MV()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
