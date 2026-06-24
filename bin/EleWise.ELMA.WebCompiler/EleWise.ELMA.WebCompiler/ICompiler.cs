using System;
using System.Collections.Generic;

namespace EleWise.ELMA.WebCompiler;

public interface ICompiler
{
	bool Compile(string assemblyName, IEnumerable<Tuple<string, string>> sourceCodes, IEnumerable<string> referencePaths, bool debug, out byte[] peRaw, out byte[] pdbRaw, out IEnumerable<WebCompileDiagnostic> diagnostics);
}
