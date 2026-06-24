using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IFormDependencyExtension
{
	bool CheckType(Guid uid);

	bool ExistForm(Guid objectUid, Guid formUid);

	IEnumerable<Guid> GetFormUids(Guid uid);

	IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(Guid dependObjectUid, Guid dependObjectFormUid, IMetadata usesObjectMetadata, Guid usesObjectFormUid, FormDependencyDataType type);

	IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(Guid dependObjectUid, Guid dependObjectFormUid, Guid usesObjectUid, Guid usesObjectFormUid, FormDependencyDataType type);

	void GenerateNewDependencies(IMetadata dependObjectMetadata);

	void GenerateNewDependencies(Guid dependObjectUid);
}
