using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.ExtensionPoints;

internal sealed class UpdateModel : IUpdateModel
{
	private readonly IMetadata _003CMetadata_003Ek__BackingField;

	private ScriptModule _003CClientScriptModule_003Ek__BackingField;

	private ScriptModule _003CViewScriptModule_003Ek__BackingField;

	private ScriptModule _003CServerScriptModule_003Ek__BackingField;

	private ScriptModule _003CTestScriptModule_003Ek__BackingField;

	private InterfaceBuilderViewMode _003CViewMode_003Ek__BackingField;

	public IMetadata Metadata => _003CMetadata_003Ek__BackingField;

	public ScriptModule ClientScriptModule
	{
		get
		{
			return _003CClientScriptModule_003Ek__BackingField;
		}
		set
		{
			_003CClientScriptModule_003Ek__BackingField = value;
		}
	}

	public ScriptModule ViewScriptModule
	{
		get
		{
			return _003CViewScriptModule_003Ek__BackingField;
		}
		set
		{
			_003CViewScriptModule_003Ek__BackingField = value;
		}
	}

	public ScriptModule ServerScriptModule
	{
		get
		{
			return _003CServerScriptModule_003Ek__BackingField;
		}
		set
		{
			_003CServerScriptModule_003Ek__BackingField = value;
		}
	}

	public ScriptModule TestScriptModule
	{
		get
		{
			return _003CTestScriptModule_003Ek__BackingField;
		}
		set
		{
			_003CTestScriptModule_003Ek__BackingField = value;
		}
	}

	public InterfaceBuilderViewMode ViewMode
	{
		get
		{
			return _003CViewMode_003Ek__BackingField;
		}
		set
		{
			_003CViewMode_003Ek__BackingField = value;
		}
	}

	public UpdateModel(IMetadata metadata)
	{
		_003CMetadata_003Ek__BackingField = metadata;
	}
}
