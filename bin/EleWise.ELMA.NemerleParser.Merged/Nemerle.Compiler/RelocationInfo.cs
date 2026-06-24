using System;
using System.Runtime.CompilerServices;
using Nemerle.Collections;

namespace Nemerle.Compiler;

public class RelocationInfo : ISupportRelocation
{
	public readonly Hashtable<object, byte> VisitedObjects;

	public readonly int FileIndex;

	public readonly TextPoint Begin;

	public readonly TextPoint Old;

	public readonly TextPoint New;

	public RelocationInfo(int fileIndex, TextPoint begin, TextPoint old, TextPoint @new)
	{
		VisitedObjects = new Hashtable<object, byte>();
		FileIndex = fileIndex;
		Begin = begin;
		Old = old;
		New = @new;
	}

	public override string ToString()
	{
		return "FileIndex=" + Convert.ToString(FileIndex) + " Begin=" + Convert.ToString(Begin) + " Old=" + Convert.ToString(Old) + " New=" + Convert.ToString(New);
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
