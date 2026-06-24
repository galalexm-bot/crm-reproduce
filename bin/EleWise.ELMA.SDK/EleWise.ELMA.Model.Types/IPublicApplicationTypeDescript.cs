using System;
using System.Collections.Generic;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Types;

public interface IPublicApplicationTypeDescriptor
{
	bool IsPublicApplicationDisplayEnabled(Guid subTypeUid);

	bool IsPublicApplicationEditorEnabled(Guid subTypeUid);

	void CheckPublicApplicationCompatibility(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, PropertyViewItem viewItem, string parentPropertyName, List<IPublicApplicationCompatibilityError> errors);
}
