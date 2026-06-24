using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class ExternalType : ISupportRelocation
{
	internal readonly Type system_type;

	internal readonly LibraryReference library;

	internal TypeInfo tycon;

	public Type SystemType
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return system_type;
		}
	}

	internal void ConstructTypeInfo(NamespaceTree.Node node, bool fix_node)
	{
		if (tycon == null)
		{
			tycon = library.ConstructTypeInfo(system_type, node);
		}
		if (fix_node)
		{
			node.Value = new NamespaceTree.TypeInfoCache.Cached(tycon);
		}
	}

	[RecordCtor]
	public ExternalType([MappedMember("system_type")] Type system_type, [MappedMember("library")] LibraryReference library, [MappedMember("tycon")] TypeInfo tycon)
	{
		this.system_type = system_type;
		this.library = library;
		this.tycon = tycon;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			library?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
