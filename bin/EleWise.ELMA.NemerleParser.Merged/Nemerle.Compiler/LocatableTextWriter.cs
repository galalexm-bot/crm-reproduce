using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class LocatableTextWriter : ISupportRelocation
{
	protected readonly StringBuilder sbuilder;

	public override Location Loc => Location.Default;

	public StringBuilder Sbuilder
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return sbuilder;
		}
	}

	public override void Write(string txt)
	{
		StringBuilder stringBuilder = sbuilder.Append(txt);
	}

	public override void FetchUpdatedLocation(Located _entity, Location _begin_loc)
	{
	}

	public override void MoveLocation(int _from_position)
	{
	}

	public override string ToString()
	{
		return sbuilder.ToString();
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

	[RecordCtor]
	public LocatableTextWriter([MappedMember("sbuilder")] StringBuilder sbuilder)
	{
		this.sbuilder = sbuilder;
	}
}
