using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class DataClassAssemblyBuilderService : IDataClassAssemblyBuilderService
{
	private readonly IJavaScriptCompilerService javaScriptCompilerService;

	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private readonly DbPreUpdater dbPreUpdater;

	private const string EmptyDataClassTemplate = "\r\nnamespace {NAMESPACE}\r\n{\r\n    public class {NAME}\r\n    {\r\n    }\r\n}\r\n";

	public DataClassAssemblyBuilderService(IJavaScriptCompilerService javaScriptCompilerService, IUITypeGenerationFacade uiTypeGenerationFacade, IRuntimeApplication runtimeApplication)
	{
		this.javaScriptCompilerService = javaScriptCompilerService;
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
		dbPreUpdater = runtimeApplication.DbPreUpdater;
	}

	public void Build(DataClassBuildAssemblyModel model)
	{
		DataClassMetadataItem[] items = model.Items;
		if (items == null || items.Length == 0)
		{
			return;
		}
		Dictionary<string, byte[]> dictionary = new Dictionary<string, byte[]>();
		Dictionary<string, byte[]> dictionary2 = new Dictionary<string, byte[]>();
		DataClassMetadataItem[] array;
		if (items.Length > 1)
		{
			array = items;
			foreach (DataClassMetadataItem item2 in array)
			{
				DataClassMetadata dataClassMetadata = (DataClassMetadata)item2.Metadata;
				string text = GenerateEmptyDataClassSourceCode(dataClassMetadata);
				using (ModelAssemblyBuilder modelAssemblyBuilder = new ModelAssemblyBuilder(item2.AssemblyName))
				{
					modelAssemblyBuilder.AddSourceCode(text);
					modelAssemblyBuilder.GenerateAssemblyInfo((string q) => q.Replace("{ASSEMBLY_VERSION}", item2.AssemblyVersion).Replace("{ASSEMBLY_FILE_VERSION}", item2.AssemblyVersion));
					ISyntaxNode syntaxNode = typeof(MetadataItemUidAttribute).CreateAttribute(item2.Uid.ToString());
					syntaxNode.Unpack<AttributeSyntax>().AssemblySpecifier = true;
					byte[] bytes = syntaxNode.GenerateCSCode();
					modelAssemblyBuilder.AddSourceCode(Encoding.UTF8.GetString(bytes));
					modelAssemblyBuilder.Build();
					dictionary[dataClassMetadata.FullTypeName] = modelAssemblyBuilder.AssemblyRaw;
				}
				IJavaScriptCompilerModel javaScriptCompilerModel = javaScriptCompilerService.CreateCompilerModel(item2.AssemblyName, scriptApiCheck: true, item2.AssemblyVersion);
				javaScriptCompilerModel.AddSourceCode(text);
				string sourceCode = GenerateAssemblyFileSourceCode(dataClassMetadata, item2.AssemblyVersion);
				javaScriptCompilerModel.AddSourceCode(sourceCode);
				JavaScriptCodeCompilerResult javaScriptCodeCompilerResult = javaScriptCompilerService.Compile(javaScriptCompilerModel, withoutJsOutput: true);
				dictionary2[dataClassMetadata.FullTypeName] = javaScriptCodeCompilerResult.AssemblyRaw;
			}
		}
		array = items;
		foreach (DataClassMetadataItem item in array)
		{
			DataClassMetadata metadata = (DataClassMetadata)item.Metadata;
			using (ModelAssemblyBuilder modelAssemblyBuilder2 = new ModelAssemblyBuilder(item.AssemblyName))
			{
				modelAssemblyBuilder2.AddDefaultReferences();
				modelAssemblyBuilder2.AddMetadata(metadata);
				modelAssemblyBuilder2.GenerateAssemblyInfo((string q) => q.Replace("{ASSEMBLY_VERSION}", item.AssemblyVersion).Replace("{ASSEMBLY_FILE_VERSION}", item.AssemblyVersion));
				ISyntaxNode syntaxNode2 = typeof(MetadataItemUidAttribute).CreateAttribute(item.Uid.ToString());
				syntaxNode2.Unpack<AttributeSyntax>().AssemblySpecifier = true;
				byte[] bytes2 = syntaxNode2.GenerateCSCode();
				modelAssemblyBuilder2.AddSourceCode(Encoding.UTF8.GetString(bytes2));
				foreach (KeyValuePair<string, byte[]> item3 in dictionary.Where((KeyValuePair<string, byte[]> assembly) => assembly.Key != metadata.FullTypeName))
				{
					modelAssemblyBuilder2.AddReference(item3.Value);
				}
				foreach (byte[] assembly in model.Assemblies)
				{
					modelAssemblyBuilder2.AddReference(assembly);
				}
				modelAssemblyBuilder2.AddReferenceByName("EleWise.ELMA.ConfigurationModel");
				modelAssemblyBuilder2.AddReferenceByName("EleWise.ELMA.DynamicModel");
				modelAssemblyBuilder2.Build();
				item.AssemblyRaw = modelAssemblyBuilder2.AssemblyRaw;
				item.DebugRaw = modelAssemblyBuilder2.DebugRaw;
				item.DocumentationRaw = modelAssemblyBuilder2.DocumentationRaw;
			}
			IJavaScriptCompilerModel javaScriptCompilerModel2 = javaScriptCompilerService.CreateCompilerModel(item.AssemblyName, scriptApiCheck: true, item.AssemblyVersion);
			javaScriptCompilerModel2.AddSourceCode("Source", GetMetadataGeneratedClientSourceCode(metadata));
			foreach (KeyValuePair<string, byte[]> item4 in dictionary2.Where((KeyValuePair<string, byte[]> assembly) => assembly.Key != metadata.FullTypeName))
			{
				javaScriptCompilerModel2.AddReference(item4.Value);
			}
			foreach (byte[] clientAssembly in model.ClientAssemblies)
			{
				javaScriptCompilerModel2.AddReference(clientAssembly);
			}
			foreach (AssemblyModelsMetadata assemblyModel in dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled, "ConfigurationUIModel", "DynamicUIModel", "ExternalUIModel"))
			{
				if (assemblyModel?.AssemblyRawStream != null)
				{
					javaScriptCompilerModel2.AddReference(assemblyModel.AssemblyRawStream.ToArray());
				}
			}
			string sourceCode2 = GenerateAssemblyFileSourceCode(metadata, item.AssemblyName);
			javaScriptCompilerModel2.AddSourceCode("AssemblyInfo", sourceCode2);
			JavaScriptCodeCompilerResult javaScriptCodeCompilerResult2 = javaScriptCompilerService.Compile(javaScriptCompilerModel2, withoutJsOutput: true);
			if (javaScriptCodeCompilerResult2 == null)
			{
				throw new MetadataPublishingException(SR.T("Ошибка компиляции вложенного объекта \"{0}\"", metadata.Name));
			}
			item.ClientAssemblyRaw = javaScriptCodeCompilerResult2.AssemblyRaw;
			ComponentManager.LoadAssembly(item.AssemblyRaw);
			item.Save();
			item.Header.IsDirtyItem = false;
			item.Header.Save();
		}
	}

	private static string GenerateAssemblyFileSourceCode(DataClassMetadata metadata, string assemblyName)
	{
		GeneratedFileInfo generatedFileInfo = ((ICodeGenerator)new AssemblyInfoWebGenerator(assemblyName)
		{
			Metadata = metadata,
			GenerationParams = 
			{
				FileName = metadata.Name + ".cs",
				Namespace = metadata.Namespace
			}
		}).GenerateMainFile();
		return Encoding.UTF8.GetString(generatedFileInfo.Data);
	}

	private static string GenerateEmptyDataClassSourceCode(DataClassMetadata metadata)
	{
		return "\r\nnamespace {NAMESPACE}\r\n{\r\n    public class {NAME}\r\n    {\r\n    }\r\n}\r\n".Replace("{NAMESPACE}", metadata.Namespace).Replace("{NAME}", metadata.Name);
	}

	private string GetMetadataGeneratedClientSourceCode(AbstractMetadata metadata)
	{
		GeneratedFileInfo generatedFileInfo = ((ICodeGenerator)new DataClassWebGenerator(uiTypeGenerationFacade)
		{
			Metadata = metadata
		}).GenerateMainFile();
		return Encoding.UTF8.GetString(generatedFileInfo.Data);
	}
}
