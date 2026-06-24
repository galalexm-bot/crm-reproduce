using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser;

internal static class NodeConstants
{
	internal static Member ProxyTypeMember(IWorker worker, string oldValue, string newValue)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		string text = oldValue.Replace(newValue, "EleWise_ELMA_Core$EleWise$ELMA$DTO$ProxyType$");
		return (Member)((IEnumerable<AstNode>)new JSParser().Parse(text, worker.Settings)).First();
	}

	internal static CallNode ReactiveTypeCall(IWorker worker, string typeToCast)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		return (CallNode)((AstNode)new JSParser().Parse("EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType(\"" + typeToCast + "\")", worker.Settings)).get_Children().First();
	}

	internal static Member EnumWrapperMember(IWorker worker)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		AstNode obj = ((IEnumerable<AstNode>)new JSParser().Parse("EleWise_ELMA_Core.EleWise.ELMA.Common.Models.EnumWrapper", worker.Settings)).First();
		return (Member)(object)((obj is Member) ? obj : null);
	}

	internal static CallNode EmptyCall(IWorker worker)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		AstNode obj = ((IEnumerable<AstNode>)new JSParser().Parse("emptyCallFunction()", worker.Settings)).First();
		return (CallNode)(object)((obj is CallNode) ? obj : null);
	}
}
