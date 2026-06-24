using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UIBuilder.Components;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.UIBuilder.CodeGeneration;

namespace EleWise.ELMA.Workflow.UIBuilder.Components
{
	[Component]
	internal sealed class ProcessContextClientScriptModuleTypeInfo : IScriptModuleTypeInfo
	{
		public Type GeneratorType => typeof(ProcessContextClientScriptModuleCodeGenerator);

		public bool Check(IMetadata metadata, Guid scriptModuleTypeUid)
		{
			if (metadata is ProcessContext)
			{
				return scriptModuleTypeUid == ClientScriptModuleType.TypeUid;
			}
			return false;
		}
	}
}
namespace EleWise.ELMA.Workflow.UIBuilder.CodeGeneration
{
	internal sealed class ProcessContextClientScriptModuleCodeGenerator : ScriptModuleCodeGenerator
	{
		private const string ViewModelController = "ViewModelController";

		protected override IEnumerable<ISyntaxNode> GetNamespaces()
		{
			foreach (ISyntaxNode @namespace in base.GetNamespaces())
			{
				yield return @namespace;
			}
			yield return "System.Collections.Generic".NamespaceImportDeclaration();
			yield return "EleWise.ELMA.Core".NamespaceImportDeclaration();
			yield return "EleWise.ELMA.Core.Controllers".NamespaceImportDeclaration();
			yield return "EleWise.ELMA.Model.Validation".NamespaceImportDeclaration();
			yield return "EleWise.ELMA.Model.ViewModel".NamespaceImportDeclaration();
			yield return "EleWise.ELMA.Model.Views".NamespaceImportDeclaration();
		}

		protected override string GetClassName()
		{
			return metadata.Name + "_Scripts";
		}

		protected override void WriteComments(ISyntaxNode type)
		{
			type.XmlComments(SR.T("Клиентский модуль сценариев процесса \"{0}\"", metadata.DisplayName).SummaryComment());
		}

		protected override IEnumerable<ISyntaxNode> GetMembers()
		{
			return new ISyntaxNode[1] { "ViewModelController".ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial) };
		}
	}
}
