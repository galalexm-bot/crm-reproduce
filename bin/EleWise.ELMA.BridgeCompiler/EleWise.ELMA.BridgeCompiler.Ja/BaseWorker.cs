using System.Collections.Generic;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Models;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Processors;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;

internal abstract class BaseWorker : IWorker
{
	public MetadataModel MetadataModel { get; }

	protected JSParser Parser { get; }

	public CodeSettings Settings => Parser.get_Settings();

	public IEnumerable<IProcessor> Processors { get; }

	public BaseWorker(MetadataModel mdModel)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		MetadataModel = mdModel;
		Parser = new JSParser();
		Processors = new List<IProcessor>
		{
			new CallNodeProcessor(this),
			new MemberProcessor(this),
			new FunctionObjectProcessor(this)
		};
	}

	public abstract string ProcessSourceCode(string sourceCode, CodeSettings codeSettings);

	public abstract void Process(IEnumerable<AstNode> nodes);
}
