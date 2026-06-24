using System;
using System.Collections.Generic;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.UI.Scripts.Services;

public interface IEqlPropertiesService
{
	void SetEqlComputedProperties(object source, Type sourceType, IEnumerable<PropertyMetadata> properties, List<SerializedModel> additionalModels);

	void SetEqlComputedProperties(DataClass source, DataClassMetadata viewModelMetadata, List<SerializedModel> additionalModels);
}
