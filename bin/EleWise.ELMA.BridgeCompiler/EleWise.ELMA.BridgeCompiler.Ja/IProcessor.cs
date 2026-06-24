using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser.Processors;

internal interface IProcessor
{
	IWorker Worker { get; }

	bool CanApply(AstNode node);

	void Process(AstNode node);
}
