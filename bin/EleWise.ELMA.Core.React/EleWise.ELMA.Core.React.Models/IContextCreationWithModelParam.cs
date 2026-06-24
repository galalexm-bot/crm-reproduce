using System.Collections.Generic;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;

namespace EleWise.ELMA.Core.React.Models;

public interface IContextCreationWithModelParameters : IContextCreationParameters
{
	object Model { get; }

	ModelType ModelType { get; }

	DataClassMetadata ViewModelMetadata { get; }

	System.Collections.Generic.ICollection<ViewModelPropertyInfo> AdditionalViewModelPropertyInfo { get; }
}
