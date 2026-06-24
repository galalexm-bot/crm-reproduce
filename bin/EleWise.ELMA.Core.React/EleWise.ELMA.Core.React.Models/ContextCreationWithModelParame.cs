using System;
using System.Collections.Generic;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public sealed class ContextCreationWithModelParameters : ContextCreationParameters, IContextCreationWithModelParameters, IContextCreationParameters
{
	private readonly object _003CModel_003Ek__BackingField;

	private readonly ModelType _003CModelType_003Ek__BackingField;

	private readonly DataClassMetadata _003CViewModelMetadata_003Ek__BackingField;

	private readonly System.Collections.Generic.ICollection<ViewModelPropertyInfo> _003CAdditionalViewModelPropertyInfo_003Ek__BackingField;

	public object Model => _003CModel_003Ek__BackingField;

	public ModelType ModelType => _003CModelType_003Ek__BackingField;

	public DataClassMetadata ViewModelMetadata => _003CViewModelMetadata_003Ek__BackingField;

	public System.Collections.Generic.ICollection<ViewModelPropertyInfo> AdditionalViewModelPropertyInfo => _003CAdditionalViewModelPropertyInfo_003Ek__BackingField;

	public ContextCreationWithModelParameters(IViewModel viewModel, IDataStack innerStack, IDataStack outerStack, ClassMetadata metadata, Guid metadataUid, Guid metadataTypeUid, Guid metadataModuleUid, object model, ModelType modelType, DataClassMetadata viewModelMetadata, System.Collections.Generic.ICollection<ViewModelPropertyInfo> additionalViewModelPropertyInfo = null)
		: base(viewModel, innerStack, outerStack, metadata, metadataUid, metadataTypeUid, metadataModuleUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(model, "model");
		_003CModel_003Ek__BackingField = model;
		_003CModelType_003Ek__BackingField = modelType;
		_003CViewModelMetadata_003Ek__BackingField = viewModelMetadata;
		_003CAdditionalViewModelPropertyInfo_003Ek__BackingField = (System.Collections.Generic.ICollection<ViewModelPropertyInfo>)(((object)additionalViewModelPropertyInfo) ?? ((object)new List<ViewModelPropertyInfo>()));
	}
}
