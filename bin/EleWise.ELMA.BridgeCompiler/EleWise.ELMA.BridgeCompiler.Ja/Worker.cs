using System.Collections.Generic;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Models;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Processors;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;

internal sealed class Worker : BaseWorker
{
	public Worker(MetadataModel mdModel)
		: base(mdModel)
	{
	}

	public override string ProcessSourceCode(string source, CodeSettings codeSettings)
	{
		source = PreProcess(source);
		Block val = base.Parser.Parse(source, codeSettings);
		Process((IEnumerable<AstNode>)val);
		string source2 = OutputVisitor.Apply((AstNode)(object)val, codeSettings);
		return PostProcess(source2);
	}

	public override void Process(IEnumerable<AstNode> nodes)
	{
		foreach (AstNode node in nodes)
		{
			foreach (IProcessor processor in base.Processors)
			{
				if (processor.CanApply(node))
				{
					processor.Process(node);
				}
			}
			Process(node.get_Children());
		}
	}

	private string PreProcess(string source)
	{
		return source.Replace("/*##|", "/*!##|");
	}

	private string PostProcess(string source)
	{
		return source.Replace("/*!##|", "/*##|").Replace(", emptyCallFunction()", string.Empty).Replace("emptyCallFunction(),", string.Empty)
			.Replace("emptyCallFunction()", string.Empty)
			.Replace("_EmptyModule, ", string.Empty)
			.Replace(", _EmptyModule", string.Empty)
			.Replace("$asyncBody();", Constants.CoreModule.MobxAsyncActionFunc);
	}
}
