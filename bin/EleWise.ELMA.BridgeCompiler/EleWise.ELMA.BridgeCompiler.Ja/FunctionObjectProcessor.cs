using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser.Processors;

internal sealed class FunctionObjectProcessor : BaseProcessor
{
	public FunctionObjectProcessor(IWorker worker)
		: base(worker)
	{
	}

	public override bool CanApply(AstNode node)
	{
		return node is FunctionObject;
	}

	public override void Process(AstNode node)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		FunctionObject function = (FunctionObject)node;
		ProcessClosing(function);
		ProcessLocalFunctions(function);
	}

	private void ProcessClosing(FunctionObject function)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		AstNode parent = ((AstNode)function).get_Parent();
		AstNodeList val;
		ParameterDeclaration val3;
		BindingIdentifier val4;
		if ((val = (AstNodeList)(object)((parent is AstNodeList) ? parent : null)) == null || val.get_Count() != 2 || !(val.get_Item(0) is ThisLiteral) || !(((AstNode)val).get_Parent() is CallNode) || !(((AstNode)val).get_Parent().get_Parent() is GroupingOperator) || ((IEnumerable<AstNode>)function.get_ParameterDeclarations()).FirstOrDefault((AstNode param) => (val3 = (ParameterDeclaration)(object)((param is ParameterDeclaration) ? param : null)) != null && (val4 = (BindingIdentifier)/*isinst with value type is only supported in some contexts*/) != null && (val4.get_Name() == "EleWise_ELMA_Core" || val4.get_Name() == "EleWise_ELMA_Core_React")) == null)
		{
			return;
		}
		for (int i = 0; i < function.get_ParameterDeclarations().get_Count(); i++)
		{
			BindingIdentifier val2 = (BindingIdentifier)((ParameterDeclaration)function.get_ParameterDeclarations().get_Item(i)).get_Binding();
			if (Array.IndexOf(base.Worker.MetadataModel.IgnoreModules, val2.get_Name()) == -1)
			{
				((AstNode)function.get_ParameterDeclarations()).ReplaceChild(function.get_ParameterDeclarations().get_Item(i), ((IEnumerable<AstNode>)new JSParser().Parse("_EmptyModule", base.Worker.Settings)).FirstOrDefault());
			}
		}
	}

	private void ProcessLocalFunctions(FunctionObject function)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (((AstNode)function).get_Parent() is BinaryOperator)
		{
			string code = ((AstNode)function).get_Context().get_Code();
			AstNode obj = ((IEnumerable<AstNode>)new JSParser().Parse("Bridge.fn.bind(this, " + code + ")", base.Worker.Settings)).First();
			CallNode val = (CallNode)(object)((obj is CallNode) ? obj : null);
			if (val != null)
			{
				base.Worker.Process(((AstNode)val).get_Children());
				((AstNode)function).get_Parent().ReplaceChild((AstNode)(object)function, (AstNode)(object)val);
			}
		}
	}
}
