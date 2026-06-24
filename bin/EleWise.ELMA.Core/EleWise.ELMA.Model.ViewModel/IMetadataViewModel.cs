using EleWise.ELMA.Core.Abstractions.Metadata.Models;

namespace EleWise.ELMA.Model.ViewModel;

public interface IMetadataViewModel : IViewModel
{
	UIViewModel UIViewModel { get; }

	ModelMetadata ModelMetadata { get; }

	bool IsDesignMode { get; }

	bool IsDesignModeDeep { get; }
}
