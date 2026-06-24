using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

public sealed class AssemblyInfoWebGenerator : CodeGenerator
{
	private NamedMetadata metadata;

	private string assemblyName;

	public AssemblyInfoWebGenerator()
	{
	}

	public AssemblyInfoWebGenerator(string assemblyName)
	{
		Contract.ArgumentNotNullOrEmpty(assemblyName, "assemblyName");
		this.assemblyName = assemblyName;
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		try
		{
			return GenerateMainFileHelper(AssemblyAttributes());
		}
		catch (Exception innerException)
		{
			throw new CodeGenerationException(SR.T("Ошибка генерации класса AssemblyInfo.cs"), innerException);
		}
	}

	protected override void InitInternal(IMetadata metadata)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		Contract.CheckArgument(metadata is NamedMetadata, "metadata is NamedMetadata");
		this.metadata = (NamedMetadata)metadata;
		if (string.IsNullOrWhiteSpace(assemblyName))
		{
			assemblyName = this.metadata.Name;
		}
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return Enumerable.Empty<GeneratedFileInfo>();
	}

	private IEnumerable<ISyntaxNode> AssemblyAttributes()
	{
		return new ISyntaxNode[1] { AssemblyAttribute("Bridge.ModuleAttribute".CreateAttribute(string.Format("Bridge.ModuleType.{0}", "UMD").CreateTypeSyntax(useGlobal: false), NormalizeAssemblyName(assemblyName))) };
	}

	private static ISyntaxNode AssemblyAttribute(ISyntaxNode attribute)
	{
		attribute.Unpack<AttributeSyntax>().AssemblySpecifier = true;
		return attribute;
	}

	private static string NormalizeAssemblyName(string assemblyName)
	{
		return Regex.Replace(assemblyName, "[^\\w_\\d]", "_");
	}
}
