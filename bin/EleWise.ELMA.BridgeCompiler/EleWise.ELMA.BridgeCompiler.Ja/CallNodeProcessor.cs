using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;
using EleWise.ELMA.BridgeCompiler.Models;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser.Processors;

internal sealed class CallNodeProcessor : BaseProcessor
{
	public CallNodeProcessor(IWorker worker)
		: base(worker)
	{
	}

	public override bool CanApply(AstNode node)
	{
		return node is CallNode;
	}

	public override void Process(AstNode node)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		CallNode val = (CallNode)node;
		AstNode leftHandSide = ((AstNode)val).get_LeftHandSide();
		Lookup lookup;
		if ((lookup = (Lookup)(object)((leftHandSide is Lookup) ? leftHandSide : null)) != null)
		{
			ProcessLocalFunctions(val);
			ProcessFactoryCall(val, lookup);
			ProcessDefineCall(val, lookup);
			ProcessObjectInitializerCall(val, lookup);
			ProcessBridgeCalls(val, lookup);
			ProcessElmaCoreCalls(val, lookup);
			ProcessTestCalls(val, lookup);
		}
	}

	private void ProcessDefineCall(CallNode call, Lookup lookup)
	{
		ArrayLiteral val;
		if (lookup.get_Name() != "define" || call.get_Arguments().get_Count() != 3 || (val = (ArrayLiteral)/*isinst with value type is only supported in some contexts*/) == null)
		{
			return;
		}
		for (int i = 0; i < val.get_Elements().get_Count(); i++)
		{
			AstNode val2 = val.get_Elements().get_Item(i);
			ConstantWrapper val3;
			if ((val3 = (ConstantWrapper)(object)((val2 is ConstantWrapper) ? val2 : null)) != null)
			{
				string value = val3.get_Value().ToString();
				if (Array.IndexOf(base.Worker.MetadataModel.IgnoreModules, value) == -1)
				{
					((AstNode)val.get_Elements()).ReplaceChild(val2, (AstNode)(object)NodeConstants.EmptyCall(base.Worker));
				}
			}
		}
	}

	private void ProcessFactoryCall(CallNode call, Lookup lookup)
	{
		if (lookup.get_Name() != "factory")
		{
			return;
		}
		for (int i = 0; i < call.get_Arguments().get_Count(); i++)
		{
			AstNode obj = call.get_Arguments().get_Item(i);
			CallNode call2;
			if ((call2 = (CallNode)(object)((obj is CallNode) ? obj : null)) != null)
			{
				ProcessRequireCall(call2);
			}
		}
	}

	private void ProcessRequireCall(CallNode call)
	{
		AstNode leftHandSide = ((AstNode)call).get_LeftHandSide();
		Lookup val;
		if ((val = (Lookup)(object)((leftHandSide is Lookup) ? leftHandSide : null)) == null || (val.get_Name() != "require" && val.get_Name() != "root") || call.get_Arguments().get_Count() != 1)
		{
			return;
		}
		AstNode val2 = call.get_Arguments().get_Item(0);
		if (val2 != null)
		{
			string value = ((object)val2).ToString();
			if (Array.IndexOf(base.Worker.MetadataModel.IgnoreModules, value) == -1)
			{
				((AstNode)call).get_Parent().ReplaceChild((AstNode)(object)call, (AstNode)(object)NodeConstants.EmptyCall(base.Worker));
			}
		}
	}

	private void ProcessObjectInitializerCall(CallNode call, Lookup lookup)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (call.get_IsConstructor())
		{
			string code = call.get_Function().get_Context().get_Code();
			ReplaceModel replaceModel = base.Worker.MetadataModel.ReplaceModels.Find((ReplaceModel a) => code == a.ReplaceFullName);
			if (replaceModel != null)
			{
				string text = "EleWise_ELMA_Core.EleWise.ELMA.DTO.ProxyGeneratorService.GetProxyGeneratorService(this).GenerateProxyByStringUid(\"" + replaceModel.ToReplaceArguments[0] + "\")";
				AstNode val = ((AstNode)new JSParser().Parse(text, base.Worker.Settings)).get_Children().First();
				((AstNode)call).get_Parent().ReplaceChild((AstNode)(object)call, val);
			}
		}
	}

	private void ProcessElmaCoreCalls(CallNode call, Lookup lookup)
	{
		if (!(lookup.get_Name() != "EleWise_ELMA_Core") || !(lookup.get_Name() != "EleWise_ELMA_Core_React"))
		{
			Member val;
			if (((AstNode)call).get_Context().get_Code().StartsWith("EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.BaseController$2") && call.get_Arguments().get_Count() == 2 && (val = (Member)/*isinst with value type is only supported in some contexts*/) != null)
			{
				val.set_Name("BaseController$1");
			}
			Member val2;
			if (((AstNode)call).get_Context().get_Code().StartsWith("EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.BaseCustomController$2") && call.get_Arguments().get_Count() == 2 && (val2 = (Member)/*isinst with value type is only supported in some contexts*/) != null)
			{
				val2.set_Name("BaseCustomController$1");
			}
			Member val3;
			if (((AstNode)call).get_Context().get_Code().StartsWith("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseCustomView$2") && call.get_Arguments().get_Count() == 2 && (val3 = (Member)/*isinst with value type is only supported in some contexts*/) != null && val3.get_Name() != "call")
			{
				val3.set_Name("BaseCustomView$1");
			}
		}
	}

	private void ProcessTestCalls(CallNode call, Lookup lookup)
	{
		Member val;
		if (!(lookup.get_Name() != "EleWise_ELMA_TestFramework") && call.get_Arguments().get_Count() == 3 && (val = (Member)/*isinst with value type is only supported in some contexts*/) != null && val.get_Name() == "ComponentTest$3")
		{
			val.set_Name("ComponentTest$2");
		}
	}

	private void ProcessLocalFunctions(CallNode call)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (!((AstNode)call).get_Context().get_Code().StartsWith("$asm.$."))
		{
			return;
		}
		IEnumerable<AstNode> children = ((AstNode)call).get_Children();
		AstNode obj = children.FirstOrDefault();
		Member val;
		if ((val = (Member)(object)((obj is Member) ? obj : null)) != null)
		{
			IEnumerable<AstNode> enumerable = children.Except((IEnumerable<AstNode>)(object)new Member[1] { val });
			base.Worker.Process(enumerable);
			IEnumerable<string> values = enumerable.Select((AstNode a) => OutputVisitor.Apply(a, base.Worker.Settings));
			AstNode obj2 = ((IEnumerable<AstNode>)new JSParser().Parse("Bridge.fn.bind(this, " + ((AstNode)val).get_Context().get_Code() + ")(" + string.Join(",", values), base.Worker.Settings)).First();
			CallNode val2 = (CallNode)(object)((obj2 is CallNode) ? obj2 : null);
			if (val2 != null)
			{
				((AstNode)call).get_Parent().ReplaceChild((AstNode)(object)call, (AstNode)(object)val2);
			}
		}
	}

	private void ProcessBridgeCalls(CallNode call, Lookup lookup)
	{
		if (lookup.get_Name() != "Bridge")
		{
			return;
		}
		foreach (AstNode child in ((AstNode)call).get_Children())
		{
			ProcessBridgeDefine(child, call);
		}
	}

	private void ProcessBridgeDefine(AstNode node, CallNode call)
	{
		Member val;
		ConstantWrapper val2;
		if ((val = (Member)(object)((node is Member) ? node : null)) == null || !(val.get_Name() == "define") || call.get_Arguments().get_Count() <= 0 || (val2 = (ConstantWrapper)/*isinst with value type is only supported in some contexts*/) == null || val2.get_Value() == null)
		{
			return;
		}
		string value = val2.get_Value().ToString();
		if (value.EndsWith("._Context") || value.EndsWith("ViewModelContext") || CheckProcessContextClass(value))
		{
			((AstNode)call).get_Parent().ReplaceChild((AstNode)(object)call, (AstNode)(object)NodeConstants.EmptyCall(base.Worker));
			return;
		}
		if (base.Worker.MetadataModel.ReplaceModels.Find((ReplaceModel a) => value == a.ReplaceFullName) != null)
		{
			((AstNode)call).get_Parent().ReplaceChild((AstNode)(object)call, (AstNode)(object)NodeConstants.EmptyCall(base.Worker));
			return;
		}
		int num = value.LastIndexOf(".");
		if (num > 0)
		{
			string parentClass = value.Substring(0, num);
			ReplaceModel replaceModel = base.Worker.MetadataModel.ReplaceModels.Find(delegate(ReplaceModel a)
			{
				string text = a.ReplaceName.Split('.').LastOrDefault();
				return text != null && value.EndsWith(parentClass + "." + text);
			});
			if (replaceModel != null)
			{
				base.Worker.MetadataModel.ReplaceModels.Add(new ReplaceModel(replaceModel.ModuleName, value, replaceModel.ToReplaceArguments));
				((AstNode)call).get_Parent().ReplaceChild((AstNode)(object)call, (AstNode)(object)NodeConstants.EmptyCall(base.Worker));
			}
		}
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
