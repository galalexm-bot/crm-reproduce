using System.Collections.Generic;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class CodeEditorViewItem : ViewItem
{
	private ActionWithParam<string> _003COnChange_003Ek__BackingField;

	private string _003CSourceCode_003Ek__BackingField;

	private string _003CLanguageId_003Ek__BackingField;

	private string _003CFileName_003Ek__BackingField;

	private int _003CPosition_003Ek__BackingField;

	private string _003CProjectFileName_003Ek__BackingField;

	private string _003CReferences_003Ek__BackingField;

	private ActionWithParam<string> _003COnChangeReferences_003Ek__BackingField;

	private System.Collections.Generic.ICollection<AssemblyReference> _003CGlobalScriptModules_003Ek__BackingField;

	private ActionWithParam<System.Collections.Generic.ICollection<AssemblyReference>> _003COnChangeGlobalScriptModules_003Ek__BackingField;

	private System.Collections.Generic.ICollection<ScriptWebReference> _003CWebReferences_003Ek__BackingField;

	private ActionWithParam<ScriptWebReference> _003CAddWebReference_003Ek__BackingField;

	private ActionWithParam<System.Collections.Generic.ICollection<ScriptWebReference>> _003CRemoveWebReferences_003Ek__BackingField;

	private string _003CNamespace_003Ek__BackingField;

	private string _003CProjectName_003Ek__BackingField;

	[DynamicProperty(false)]
	public ActionWithParam<string> OnChange
	{
		get
		{
			return _003COnChange_003Ek__BackingField;
		}
		set
		{
			_003COnChange_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public string SourceCode
	{
		get
		{
			return _003CSourceCode_003Ek__BackingField;
		}
		set
		{
			_003CSourceCode_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string LanguageId
	{
		get
		{
			return _003CLanguageId_003Ek__BackingField;
		}
		set
		{
			_003CLanguageId_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public int Position
	{
		get
		{
			return _003CPosition_003Ek__BackingField;
		}
		set
		{
			_003CPosition_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[DynamicProperty(false)]
	public string References
	{
		get
		{
			return _003CReferences_003Ek__BackingField;
		}
		set
		{
			_003CReferences_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParam<string> OnChangeReferences
	{
		get
		{
			return _003COnChangeReferences_003Ek__BackingField;
		}
		set
		{
			_003COnChangeReferences_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public System.Collections.Generic.ICollection<AssemblyReference> GlobalScriptModules
	{
		get
		{
			return _003CGlobalScriptModules_003Ek__BackingField;
		}
		set
		{
			_003CGlobalScriptModules_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<System.Collections.Generic.ICollection<AssemblyReference>> OnChangeGlobalScriptModules
	{
		get
		{
			return _003COnChangeGlobalScriptModules_003Ek__BackingField;
		}
		set
		{
			_003COnChangeGlobalScriptModules_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public System.Collections.Generic.ICollection<ScriptWebReference> WebReferences
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<ScriptWebReference> AddWebReference
	{
		get
		{
			return _003CAddWebReference_003Ek__BackingField;
		}
		set
		{
			_003CAddWebReference_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<System.Collections.Generic.ICollection<ScriptWebReference>> RemoveWebReferences
	{
		get
		{
			return _003CRemoveWebReferences_003Ek__BackingField;
		}
		set
		{
			_003CRemoveWebReferences_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public string Namespace
	{
		get
		{
			return _003CNamespace_003Ek__BackingField;
		}
		set
		{
			_003CNamespace_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public string ProjectName
	{
		get
		{
			return _003CProjectName_003Ek__BackingField;
		}
		set
		{
			_003CProjectName_003Ek__BackingField = value;
		}
	}
}
