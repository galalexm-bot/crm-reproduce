using System;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.OmniSharp.Model;

namespace EleWise.ELMA.OmniSharp.Api.Models;

[SimpleSerialize]
public sealed class AddReferencesRequest
{
	private string _003CFileName_003Ek__BackingField;

	private string _003CProjectFileName_003Ek__BackingField;

	private string[] _003CAssemblyNames_003Ek__BackingField = new string[0];

	private Guid[] _003CGlobalModulesUids_003Ek__BackingField = (Guid[])(object)new Guid[0];

	private WebReferenceInfo[] _003CWebReferences_003Ek__BackingField = new WebReferenceInfo[0];

	public string FileName
	{
		get
		{
			return _003CFileName_003Ek__BackingField;
		}
		set
		{
			_003CFileName_003Ek__BackingField = value;
		}
	}

	public string ProjectFileName
	{
		get
		{
			return _003CProjectFileName_003Ek__BackingField;
		}
		set
		{
			_003CProjectFileName_003Ek__BackingField = value;
		}
	}

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

	public WebReferenceInfo[] WebReferences
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
