using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeAnalyzers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.CodeAnalyzers;

internal sealed class ProcessEntityUsageAnalyzer : EntityUsageAnalyzer
{
	private readonly string scriptAssemblyName;

	private readonly List<string> contextAssemblyNameList;

	internal static ProcessEntityUsageAnalyzer VClv6vOcEN4m9AsQwEUC;

	protected override IDictionary<string, EntityMetadata> EntityMetadataList { get; }

	public ProcessEntityUsageAnalyzer(IEnumerable<ProcessContext> processContexts, string className, string scriptAssemblyName)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		contextAssemblyNameList = new List<string>();
		base._002Ector();
		this.scriptAssemblyName = scriptAssemblyName;
		EntityMetadataList = new Dictionary<string, EntityMetadata>();
		foreach (ProcessContext processContext in processContexts)
		{
			contextAssemblyNameList.Add(processContext.AssemblyName);
			EntityMetadataList[className] = processContext;
			EntityMetadataList[processContext.FullTypeName] = processContext;
			List<TablePartMetadata> tableParts = processContext.TableParts;
			AddTableParts(tableParts);
		}
	}

	protected override bool CheckModule(IModuleSymbol module)
	{
		//Discarded unreachable code: IL_005f
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (_003C_003Ec__DisplayClass6_.module != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 5;
			case 5:
				return false;
			case 3:
				if (!Evuv7ROPZ6LUqoAidcqe(dxSR3xOcz7tYxZgJ5D1m(_003C_003Ec__DisplayClass6_.module), uCX3IOOPO7iEVYVAPaZK(scriptAssemblyName, womxgZOPKkkdRaOg1pvm(0x1145BED7 ^ 0x11451963))))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return contextAssemblyNameList.Any(_003C_003Ec__DisplayClass6_._003CCheckModule_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass6_.module = module;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void AddTableParts(ICollection<TablePartMetadata> tableParts)
	{
		if (tableParts == null || tableParts.Count == 0)
		{
			return;
		}
		foreach (TablePartMetadata tablePart in tableParts)
		{
			EntityMetadataList[tablePart.FullTypeName] = tablePart;
			AddTableParts(tablePart.TableParts);
		}
	}

	internal static object dxSR3xOcz7tYxZgJ5D1m(object P_0)
	{
		return ((ISymbol)P_0).get_Name();
	}

	internal static object womxgZOPKkkdRaOg1pvm(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object uCX3IOOPO7iEVYVAPaZK(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool Evuv7ROPZ6LUqoAidcqe(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool awTQmVOcwJpuyujMM3rF()
	{
		return VClv6vOcEN4m9AsQwEUC == null;
	}

	internal static ProcessEntityUsageAnalyzer WB0a2xOc4gWKS1s7qhrC()
	{
		return VClv6vOcEN4m9AsQwEUC;
	}
}
