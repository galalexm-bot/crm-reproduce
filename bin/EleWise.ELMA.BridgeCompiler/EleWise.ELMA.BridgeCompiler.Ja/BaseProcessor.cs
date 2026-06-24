using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser.Processors;

internal abstract class BaseProcessor : IProcessor
{
	public IWorker Worker { get; }

	public BaseProcessor(IWorker worker)
	{
		Worker = worker;
	}

	public abstract bool CanApply(AstNode node);

	public abstract void Process(AstNode node);
}
