using System;
using System.Collections.Generic;

namespace EleWise.ELMA.WebCompiler;

public class WebCompileException : Exception
{
	public HashSet<CompilingFileInfo> FilesWithErrors { get; private set; }

	public WebCompileException()
		: base("Cannot compile web module")
	{
		FilesWithErrors = new HashSet<CompilingFileInfo>();
	}
}
