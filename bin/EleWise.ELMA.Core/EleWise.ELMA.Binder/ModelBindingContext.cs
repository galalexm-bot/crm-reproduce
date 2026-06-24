using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Binder;

public sealed class ModelBindingContext
{
	private ModelMetadata _003CModelMetadata_003Ek__BackingField;

	private ComponentMetadata _003CComponentMetadata_003Ek__BackingField;

	public ModelMetadata ModelMetadata
	{
		get
		{
			return _003CModelMetadata_003Ek__BackingField;
		}
		set
		{
			_003CModelMetadata_003Ek__BackingField = value;
		}
	}

	public ComponentMetadata ComponentMetadata
	{
		get
		{
			return _003CComponentMetadata_003Ek__BackingField;
		}
		set
		{
			_003CComponentMetadata_003Ek__BackingField = value;
		}
	}
}
