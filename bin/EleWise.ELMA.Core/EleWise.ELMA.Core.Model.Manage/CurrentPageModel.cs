using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Managers;

public sealed class CurrentPageModel : Reactive
{
	private Guid _003CUid_003Ek__BackingField;

	private Guid _003CTypeUid_003Ek__BackingField;

	private RootViewItem _003CViewItem_003Ek__BackingField;

	private Guid _003CModuleUid_003Ek__BackingField;

	private InterfaceBuilderViewMode _003CViewMode_003Ek__BackingField;

	private ScriptModule _003CClientScriptModule_003Ek__BackingField;

	private ScriptModule _003CViewScriptModule_003Ek__BackingField;

	private ScriptModule _003CServerScriptModule_003Ek__BackingField;

	private ScriptModule _003CTestScriptModule_003Ek__BackingField;

	private string _003CMethodName_003Ek__BackingField;

	private IMetadata _003CMetadata_003Ek__BackingField;

	private string _003CMetadataName_003Ek__BackingField;

	private Guid _003CCurrentPartialViewItemUid_003Ek__BackingField;

	private RuntimeVersion _003CRuntimeVersion_003Ek__BackingField;

	private IMethodsService _003CMethodsService_003Ek__BackingField;

	private bool _003COverrideInitWorkspace_003Ek__BackingField;

	private InitWorkspaceParams _003CInitParams_003Ek__BackingField;

	private bool _003CScriptEditorReady_003Ek__BackingField = true;

	public Guid Uid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CUid_003Ek__BackingField = value;
		}
	}

	public Guid TypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CTypeUid_003Ek__BackingField = value;
		}
	}

	public RootViewItem ViewItem
	{
		get
		{
			return _003CViewItem_003Ek__BackingField;
		}
		set
		{
			_003CViewItem_003Ek__BackingField = value;
		}
	}

	public Guid ModuleUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CModuleUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CModuleUid_003Ek__BackingField = value;
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

	public string MethodName
	{
		get
		{
			return _003CMethodName_003Ek__BackingField;
		}
		set
		{
			_003CMethodName_003Ek__BackingField = value;
		}
	}

	public IMetadata Metadata
	{
		get
		{
			return _003CMetadata_003Ek__BackingField;
		}
		set
		{
			_003CMetadata_003Ek__BackingField = value;
		}
	}

	public string MetadataName
	{
		get
		{
			return _003CMetadataName_003Ek__BackingField;
		}
		set
		{
			_003CMetadataName_003Ek__BackingField = value;
		}
	}

	public Guid CurrentPartialViewItemUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CCurrentPartialViewItemUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CCurrentPartialViewItemUid_003Ek__BackingField = value;
		}
	}

	public RuntimeVersion RuntimeVersion
	{
		get
		{
			return _003CRuntimeVersion_003Ek__BackingField;
		}
		set
		{
			_003CRuntimeVersion_003Ek__BackingField = value;
		}
	}

	public IMethodsService MethodsService
	{
		get
		{
			return _003CMethodsService_003Ek__BackingField;
		}
		set
		{
			_003CMethodsService_003Ek__BackingField = value;
		}
	}

	public bool OverrideInitWorkspace
	{
		get
		{
			return _003COverrideInitWorkspace_003Ek__BackingField;
		}
		set
		{
			_003COverrideInitWorkspace_003Ek__BackingField = value;
		}
	}

	public InitWorkspaceParams InitParams
	{
		get
		{
			return _003CInitParams_003Ek__BackingField;
		}
		set
		{
			_003CInitParams_003Ek__BackingField = value;
		}
	}

	public bool ScriptEditorReady
	{
		get
		{
			return _003CScriptEditorReady_003Ek__BackingField;
		}
		set
		{
			_003CScriptEditorReady_003Ek__BackingField = value;
		}
	}
}
