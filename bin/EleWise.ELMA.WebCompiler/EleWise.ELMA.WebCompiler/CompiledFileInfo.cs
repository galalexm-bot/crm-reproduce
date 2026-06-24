using System;
using System.Collections.Generic;

namespace EleWise.ELMA.WebCompiler;

internal class CompiledFileInfo : IEquatable<CompiledFileInfo>
{
	public string VirtualPath { get; set; }

	public string HashCode { get; set; }

	public string AssemblyUid { get; set; }

	public string ClassName { get; set; }

	public List<WebCompileDiagnostic> Errors { get; set; }

	public DateTime LastUseDate { get; set; }

	public bool ShouldSerializeAssemblyUid()
	{
		if (AssemblyUid != null)
		{
			return !ShouldSerializeErrors();
		}
		return false;
	}

	public bool ShouldSerializeClassName()
	{
		if (ClassName != null)
		{
			return !ShouldSerializeErrors();
		}
		return false;
	}

	public bool ShouldSerializeErrors()
	{
		if (Errors != null)
		{
			return Errors.Count > 0;
		}
		return false;
	}

	public bool Equals(CompiledFileInfo other)
	{
		if (other != null && AssemblyUid == other.AssemblyUid && VirtualPath == other.VirtualPath && ClassName == other.ClassName)
		{
			return HashCode == other.HashCode;
		}
		return false;
	}
}
