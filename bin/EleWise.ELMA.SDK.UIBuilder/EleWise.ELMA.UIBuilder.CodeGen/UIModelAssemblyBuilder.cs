using System.Collections.Generic;
using System.Text;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class UIModelAssemblyBuilder
{
	internal delegate bool BeforeCompile(IJavaScriptCompilerModel compilerModel);

	private readonly string assemblyName;

	private readonly ICollection<byte[]> references;

	private readonly ICollection<IMetadata> metadatas;

	private readonly IJavaScriptCompilerService javaScriptCompilerService;

	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private readonly bool scriptApiCheck;

	internal event BeforeCompile BeforeCompileEvent;

	public UIModelAssemblyBuilder(string assemblyName, IJavaScriptCompilerService javaScriptCompilerService, IUITypeGenerationFacade uiTypeGenerationFacade, bool scriptApiCheck)
	{
		this.assemblyName = assemblyName;
		this.javaScriptCompilerService = javaScriptCompilerService;
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
		this.scriptApiCheck = scriptApiCheck;
		references = new List<byte[]>();
		metadatas = new List<IMetadata>();
	}

	public ClientBuildResult BuildAssembly()
	{
		IJavaScriptCompilerModel javaScriptCompilerModel = javaScriptCompilerService.CreateCompilerModel(assemblyName, scriptApiCheck);
		foreach (IMetadata metadata in metadatas)
		{
			ICodeGenerator codeGenerator = GetCodeGenerator(metadata);
			if (codeGenerator != null)
			{
				codeGenerator.Metadata = metadata;
				codeGenerator.GenerationParams = new GenerationParams();
				GeneratedFileInfo generatedFileInfo = codeGenerator.GenerateMainFile();
				javaScriptCompilerModel.AddSourceCode((metadata is NamedMetadata namedMetadata) ? namedMetadata.Name : null, Encoding.UTF8.GetString(generatedFileInfo.Data));
			}
		}
		ClassMetadata classMetadata = new ClassMetadata
		{
			Name = assemblyName,
			Namespace = assemblyName
		};
		ICodeGenerator codeGenerator2 = new AssemblyInfoWebGenerator();
		codeGenerator2.Metadata = classMetadata;
		codeGenerator2.GenerationParams.FileName = classMetadata.Name + ".cs";
		codeGenerator2.GenerationParams.Namespace = classMetadata.Namespace;
		javaScriptCompilerModel.AddSourceCode(Encoding.UTF8.GetString(codeGenerator2.GenerateMainFile().Data));
		if (references != null)
		{
			foreach (byte[] reference in references)
			{
				javaScriptCompilerModel.AddReference(reference);
			}
		}
		this.BeforeCompileEvent?.Invoke(javaScriptCompilerModel);
		JavaScriptCodeCompilerResult javaScriptCodeCompilerResult = javaScriptCompilerService.Compile(javaScriptCompilerModel, withoutJsOutput: true);
		return new ClientBuildResult(javaScriptCodeCompilerResult.AssemblyRaw, javaScriptCodeCompilerResult.JsAssemblyRaw, javaScriptCodeCompilerResult.MinJsAssemblyRaw, assemblyName, javaScriptCodeCompilerResult.DocumentationRaw);
		ICodeGenerator GetCodeGenerator(IMetadata metadata)
		{
			if (metadata is EnumMetadata)
			{
				return new EnumWebGenerator();
			}
			return new DataClassWebGenerator(uiTypeGenerationFacade);
		}
	}

	public void AddReference(byte[] reference)
	{
		Contract.NotNull(reference, "reference");
		references.Add(reference);
	}

	public void AddReferenceList(IEnumerable<byte[]> references)
	{
		Contract.NotNull(references, "references");
		foreach (byte[] reference in references)
		{
			this.references.Add(reference);
		}
	}

	public void RegisterMetadata(IMetadata metadata)
	{
		Contract.NotNull(metadata, "metadata");
		metadatas.Add(metadata);
	}

	public void RegisterMetadataList(IEnumerable<IMetadata> metadatas)
	{
		Contract.NotNull(metadatas, "metadatas");
		foreach (IMetadata metadata in metadatas)
		{
			RegisterMetadata(metadata);
		}
	}
}
