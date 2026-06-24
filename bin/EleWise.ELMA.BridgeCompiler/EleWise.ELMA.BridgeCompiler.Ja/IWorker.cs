using System.Collections.Generic;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Models;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Processors;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;

internal interface IWorker
{
	MetadataModel MetadataModel { get; }

	CodeSettings Settings { get; }

	IEnumerable<IProcessor> Processors { get; }

	string ProcessSourceCode(string sourceCode, CodeSettings codeSettings);

	void Process(IEnumerable<AstNode> nodes);
}
