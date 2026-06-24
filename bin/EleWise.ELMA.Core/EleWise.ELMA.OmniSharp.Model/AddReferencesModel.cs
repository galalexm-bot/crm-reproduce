using System;
using System.Collections.Generic;

namespace EleWise.ELMA.OmniSharp.Model;

public sealed class AddReferencesModel
{
	private string[] _003CAssemblyNames_003Ek__BackingField;

	private Guid[] _003CGlobalModulesUids_003Ek__BackingField;

	private System.Collections.Generic.IEnumerable<WebReferenceInfo> _003CWebReferences_003Ek__BackingField;

	public string[] AssemblyNames
	{
		get
		{
			return _003CAssemblyNames_003Ek__BackingField;
		}
		set
		{
			_003CAssemblyNames_003Ek__BackingField = value;
		}
	}

	public Guid[] GlobalModulesUids
	{
		get
		{
			return _003CGlobalModulesUids_003Ek__BackingField;
		}
		set
		{
			_003CGlobalModulesUids_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.IEnumerable<WebReferenceInfo> WebReferences
	{
		get
		{
			return _003CWebReferences_003Ek__BackingField;
		}
		set
		{
			_003CWebReferences_003Ek__BackingField = value;
		}
	}
}
