using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Scripts.Models;

public sealed class ScriptExecutionParams
{
	private readonly ReactiveProxy _003CModel_003Ek__BackingField;

	private readonly ModelInfo _003CModelInfo_003Ek__BackingField;

	private readonly IViewModel _003CViewModel_003Ek__BackingField;

	private readonly string _003CScriptName_003Ek__BackingField;

	private readonly ReactiveProxy _003CItem_003Ek__BackingField;

	private readonly AdditionalModel[] _003CAdditionalModels_003Ek__BackingField;

	private bool _003CUpdateModel_003Ek__BackingField;

	public ReactiveProxy Model => _003CModel_003Ek__BackingField;

	public ModelInfo ModelInfo => _003CModelInfo_003Ek__BackingField;

	public IViewModel ViewModel => _003CViewModel_003Ek__BackingField;

	public string ScriptName => _003CScriptName_003Ek__BackingField;

	public ReactiveProxy Item => _003CItem_003Ek__BackingField;

	public AdditionalModel[] AdditionalModels => _003CAdditionalModels_003Ek__BackingField;

	public bool UpdateModel
	{
		get
		{
			return _003CUpdateModel_003Ek__BackingField;
		}
		set
		{
			_003CUpdateModel_003Ek__BackingField = value;
		}
	}

	public ScriptExecutionParams(ReactiveProxy model, ModelInfo modelInfo, IViewModel viewModel, string scriptName, params AdditionalModel[] additionalModels)
		: this(model, modelInfo, viewModel, scriptName, null, updateModel: true, additionalModels)
	{
	}

	public ScriptExecutionParams(ReactiveProxy model, ModelInfo modelInfo, IViewModel viewModel, string scriptName, ReactiveProxy item, bool updateModel, params AdditionalModel[] additionalModels)
	{
		_003CModel_003Ek__BackingField = model;
		_003CModelInfo_003Ek__BackingField = modelInfo;
		_003CViewModel_003Ek__BackingField = viewModel;
		_003CScriptName_003Ek__BackingField = scriptName;
		_003CItem_003Ek__BackingField = item;
		_003CAdditionalModels_003Ek__BackingField = additionalModels ?? new AdditionalModel[0];
		UpdateModel = updateModel;
	}
}
