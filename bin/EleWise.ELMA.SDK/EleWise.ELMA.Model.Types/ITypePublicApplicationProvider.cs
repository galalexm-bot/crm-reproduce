using System;
using System.Collections.Generic;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Types;

[ExtensionPoint(ComponentType.All)]
public interface ITypePublicApplicationProvider
{
	bool? IsPublicApplicationDisplayEnabled(Guid typeUid, Guid subTypeUid);

	bool? IsPublicApplicationEditorEnabled(Guid typeUid, Guid subTypeUid);

	void CheckPublicApplicationCompatibility(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, PropertyViewItem viewItem, string parentPropertyName, List<IPublicApplicationCompatibilityError> errors);
}
