using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;
using EleWise.ELMA.BridgeCompiler.Models;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser.Processors;

internal sealed class MemberProcessor : BaseProcessor
{
	private static readonly List<string> testMethods = new List<string>(4) { "And", "Given", "Then", "When" };

	private static readonly string ComponentControllerContext = string.Join("$", "", "ComponentController", "Context");

	private static readonly string ComponentController = string.Join("$", "", "ComponentController", "Controller");

	public MemberProcessor(IWorker worker)
		: base(worker)
	{
	}

	public override bool CanApply(AstNode node)
	{
		return node is Member;
	}

	public override void Process(AstNode node)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Invalid comparison between Unknown and I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Invalid comparison between Unknown and I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Invalid comparison between Unknown and I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		Member val = (Member)node;
		string value = ((AstNode)val).get_Context().get_Code();
		ProcessLocalFunctions(val);
		AstNode parent = ((AstNode)val).get_Parent();
		ReplaceModel[] array = base.Worker.MetadataModel.ReplaceModels.Where((ReplaceModel a) => value == a.ReplaceFullName).ToArray();
		string text;
		BinaryOperator val2;
		int num;
		if (array.Length != 0)
		{
			ReplaceModel replaceModel = array.FirstOrDefault((ReplaceModel a) => a.Options.Contract);
			if (replaceModel != null)
			{
				parent.ReplaceChild((AstNode)(object)val, (AstNode)(object)NodeConstants.ReactiveTypeCall(base.Worker, replaceModel.ToReplaceArguments[0]));
				return;
			}
			ReplaceModel replaceModel2 = array.FirstOrDefault((ReplaceModel a) => !a.Options.Contract);
			if (replaceModel2 != null)
			{
				if (!replaceModel2.Options.Value)
				{
					parent.ReplaceChild((AstNode)(object)val, (AstNode)(object)NodeConstants.EnumWrapperMember(base.Worker));
					return;
				}
				string[] array2 = new string[replaceModel2.ToReplaceArguments.Length];
				array2[0] = "\"" + replaceModel2.ToReplaceArguments[0] + "\"";
				array2[1] = "\"" + replaceModel2.ToReplaceArguments[1] + "\"";
				array2[2] = "\"" + replaceModel2.ToReplaceArguments[2] + "\"";
				text = "EleWise_ELMA_Core.EleWise.ELMA.Common.Models.EnumWrapper.Create(" + string.Join(",", array2) + ")";
				val2 = (BinaryOperator)(object)((parent is BinaryOperator) ? parent : null);
				if (val2 != null)
				{
					if ((int)val2.get_OperatorToken() != 63)
					{
						num = (((int)val2.get_OperatorToken() == 64) ? 1 : 0);
						if (num == 0)
						{
							goto IL_0211;
						}
					}
					else
					{
						num = 1;
					}
					string obj = (((int)val2.get_OperatorToken() == 64) ? "!" : "");
					bool num2 = val == val2.get_Operand1();
					string text2 = "";
					text2 = ((!num2) ? $"{val2.get_Operand1().get_Context()}, {text}" : $"{text}, {val2.get_Operand2().get_Context()}");
					text = obj + "Bridge.equals(" + text2 + ")";
				}
				else
				{
					num = 0;
				}
				goto IL_0211;
			}
		}
		ReplaceModel[] array3 = base.Worker.MetadataModel.ReplaceModels.Where((ReplaceModel a) => value.Contains(a.ReplaceInterfaceFullName)).ToArray();
		if (array3.Length != 0)
		{
			string text3 = null;
			int num3 = -1;
			ReplaceModel[] array4 = array3;
			for (int i = 0; i < array4.Length; i++)
			{
				text3 = array4[i].ReplaceInterfaceFullName + "$";
				num3 = value.IndexOf(text3, StringComparison.Ordinal);
				if (num3 > 0)
				{
					break;
				}
			}
			if (num3 > 0)
			{
				Member val3 = NodeConstants.ProxyTypeMember(base.Worker, value, text3);
				parent.ReplaceChild((AstNode)(object)val, (AstNode)(object)val3);
			}
		}
		if (value.EndsWith("._Context") || value.EndsWith("ViewModelContext") || CheckProcessContextClass(value))
		{
			parent.ReplaceChild((AstNode)(object)val, (AstNode)(object)NodeConstants.EmptyCall(base.Worker));
		}
		else
		{
			ProcessTestMembers(val);
		}
		return;
		IL_0211:
		AstNode val4 = ((AstNode)new JSParser().Parse(text, base.Worker.Settings)).get_Children().First();
		if (num != 0)
		{
			parent.get_Parent().ReplaceChild((AstNode)(object)val2, val4);
		}
		else
		{
			parent.ReplaceChild((AstNode)(object)val, val4);
		}
	}

	private void ProcessLocalFunctions(Member node)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		string code = ((AstNode)node).get_Context().get_Code();
		if (!code.StartsWith("$asm.$."))
		{
			return;
		}
		AstNode parent = ((AstNode)node).get_Parent();
		if (parent != null)
		{
			if (parent is Member)
			{
				return;
			}
			AstNode parent2 = parent.get_Parent();
			if (parent2 != null && parent2.get_Context().get_Code().StartsWith("Bridge.apply"))
			{
				return;
			}
		}
		AstNode obj = ((IEnumerable<AstNode>)new JSParser().Parse("Bridge.fn.bind(this, " + code + ")", base.Worker.Settings)).First();
		CallNode val = (CallNode)(object)((obj is CallNode) ? obj : null);
		if (val != null)
		{
			((AstNode)node).get_Parent().ReplaceChild((AstNode)(object)node, (AstNode)(object)val);
		}
	}

	private void ProcessTestMembers(Member member)
	{
		string name = member.get_Name();
		foreach (string testMethod in testMethods)
		{
			string text = Format(testMethod, "1");
			if (name.EndsWith(text))
			{
				int num = name.LastIndexOf("_Context") - 1;
				string text2 = name.Replace(name.Substring(num, name.Length - num), text);
				member.set_Name(text2.Replace("IComponentTestModel$2", "IComponentTestModel$1"));
				return;
			}
		}
		if (name.StartsWith("EleWise_ELMA_TestFramework"))
		{
			if (name.EndsWith(ComponentControllerContext))
			{
				member.set_Name("Context");
			}
			else if (name.EndsWith(ComponentController))
			{
				member.set_Name("Controller");
			}
		}
	}

	private static string Format(string arg1, string overrides)
	{
		return "$ComponentController$" + arg1 + "$" + overrides;
	}

	private static bool CheckProcessContextClass(string value)
	{
		if (value.StartsWith("EleWise.ELMA.Model.Entities.ProcessContext.") && !value.EndsWith("ViewModelController") && !value.EndsWith("IServer"))
		{
			return !value.EndsWith("_Scripts");
		}
		return false;
	}
}
