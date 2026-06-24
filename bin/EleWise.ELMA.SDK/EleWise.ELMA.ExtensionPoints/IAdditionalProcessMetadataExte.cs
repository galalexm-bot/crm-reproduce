using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IAdditionalProcessMetadataExtension
{
	bool Check(IPropertyMetadata propertyMetadata);

	void ProcessMetadata(IPropertyMetadata propertyMetadata, Guid currentModuleUid, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies);
}
