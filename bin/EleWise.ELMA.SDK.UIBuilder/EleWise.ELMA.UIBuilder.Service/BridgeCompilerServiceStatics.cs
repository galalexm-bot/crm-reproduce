using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeAnalyzers;
using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

namespace EleWise.ELMA.UIBuilder.Services;

public static class BridgeCompilerServiceStatics
{
	public static void DefaultAction(IJavaScriptCompilerModel bridgeCompilerModel, params IAnalyzerWithResult[] analyzers)
	{
		DefaultActionWithNameGetter(bridgeCompilerModel, DefaultAssemblyNameGetterFromDB, analyzers);
	}

	internal static void DefaultActionWithNameGetter(IJavaScriptCompilerModel bridgeCompilerModel, Func<Guid, string> moduleAssemblyNameGetter, params IAnalyzerWithResult[] analyzers)
	{
		if (analyzers == null || analyzers.Length == 0)
		{
			return;
		}
		ICodeAnalyzerResult[] array = analyzers.Select((IAnalyzerWithResult a) => a.CodeAnalyzerResult).ToArray();
		ICodeAnalyzerResult codeAnalyzerResult = array.First();
		ICodeAnalyzerResult[] array2 = array;
		foreach (ICodeAnalyzerResult codeAnalyzerResult2 in array2)
		{
			if (codeAnalyzerResult2 != codeAnalyzerResult)
			{
				codeAnalyzerResult = codeAnalyzerResult.CombineResult(codeAnalyzerResult2);
			}
		}
		foreach (KeyValuePair<IMetadata, ICollection<IPropertyMetadata>> referenceMetadatum in codeAnalyzerResult.ReferenceMetadata)
		{
			ICodeItemMetadata codeItemMetadata;
			if ((codeItemMetadata = referenceMetadatum.Key as ICodeItemMetadata) == null || bridgeCompilerModel.ReplaceModelMetadata.FirstOrDefault((IReplaceModelMetadata a) => a.Metadata == codeItemMetadata) != null)
			{
				continue;
			}
			ICodeItemMetadata codeItemMetadata2 = codeItemMetadata;
			if (codeItemMetadata2 == null)
			{
				continue;
			}
			if (!(codeItemMetadata2 is DataClassMetadata dataClassMetadata))
			{
				if (!(codeItemMetadata2 is EntityMetadata entityMetadata))
				{
					if (codeItemMetadata2 is EnumMetadata enumMetadata)
					{
						EnumMetadata metadata = enumMetadata;
						bridgeCompilerModel.ReplaceModelMetadata.Add(new ReplaceModelMetadata(metadata, "EleWise_ELMA_Core"));
						bridgeCompilerModel.ReplaceModelMetadata.Add(new ReplaceModelMetadata(metadata, "DynamicUIModel"));
						bridgeCompilerModel.ReplaceModelMetadata.Add(new ReplaceModelMetadata(metadata, "ExternalUIModel"));
						bridgeCompilerModel.ReplaceModelMetadata.Add(new ReplaceModelMetadata(metadata, "ConfigurationUIModel"));
					}
				}
				else
				{
					EntityMetadata metadata2 = entityMetadata;
					bridgeCompilerModel.ReplaceModelMetadata.Add(new ReplaceModelMetadata(metadata2, "DynamicUIModel"));
					bridgeCompilerModel.ReplaceModelMetadata.Add(new ReplaceModelMetadata(metadata2, "ExternalUIModel"));
					bridgeCompilerModel.ReplaceModelMetadata.Add(new ReplaceModelMetadata(metadata2, "ConfigurationUIModel"));
				}
			}
			else
			{
				DataClassMetadata dataClassMetadata2 = dataClassMetadata;
				string text = "";
				text = ((!(dataClassMetadata2.ModuleUid == Guid.Empty)) ? moduleAssemblyNameGetter(dataClassMetadata2.ModuleUid) : DataClassMetadataItemHeaderManager.Instance.Load(dataClassMetadata2.Uid).Published.AssemblyName.Replace('.', '_'));
				bridgeCompilerModel.ReplaceModelMetadata.Add(new ReplaceModelMetadata(codeItemMetadata, text));
			}
		}
	}

	private static string DefaultAssemblyNameGetterFromDB(Guid moduleUid)
	{
		return ModuleMetadataItemManager.ClientAssemblyName((ModuleInfoMetadata)ModuleMetadataItemHeaderManager.Instance.Load(moduleUid).Published.Metadata);
	}
}
