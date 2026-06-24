using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.ViewModel;

public interface ICacheModelMetadata : IViewModel
{
	IDictionary<Guid, ModelMetadata> Cache { get; }
}
