using System.Collections.Generic;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;

namespace EleWise.ELMA.Model.ViewModel;

public interface IViewModelWithDynamicPropertySettings : IViewModel
{
	Dictionary<IPropertyMetadata, TypeSettings> DynamicSettings { get; }
}
