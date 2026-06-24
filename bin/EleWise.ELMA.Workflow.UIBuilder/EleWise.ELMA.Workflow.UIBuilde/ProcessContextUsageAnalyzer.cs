using System.Collections.Generic;
using EleWise.ELMA.CodeAnalyzers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using Microsoft.CodeAnalysis;

namespace EleWise.ELMA.Workflow.UIBuilder.CodeAnalyzers;

internal sealed class ProcessContextUsageAnalyzer : EntityUsageAnalyzer
{
	private readonly string assemblyName;

	protected override IDictionary<string, EntityMetadata> EntityMetadataList { get; }

	public ProcessContextUsageAnalyzer(IEnumerable<ProcessContext> processContexts, string assemblyName)
	{
		this.assemblyName = assemblyName;
		EntityMetadataList = new Dictionary<string, EntityMetadata>();
		foreach (ProcessContext processContext in processContexts)
		{
			EntityMetadataList[processContext.FullTypeName + "_Scripts." + processContext.Name] = processContext;
			AddTableParts(processContext.TableParts, processContext.FullTypeName);
		}
	}

	protected override bool CheckModule(IModuleSymbol module)
	{
		if (module == null)
		{
			return false;
		}
		return ((ISymbol)module).get_Name() == assemblyName + ".dll";
	}

	private void AddTableParts(ICollection<TablePartMetadata> tableParts, string fullTypeName)
	{
		if (tableParts == null || tableParts.Count == 0)
		{
			return;
		}
		foreach (TablePartMetadata tablePart in tableParts)
		{
			EntityMetadataList[fullTypeName + "_Scripts." + tablePart.Name] = tablePart;
			AddTableParts(tablePart.TableParts, fullTypeName);
		}
	}
}
