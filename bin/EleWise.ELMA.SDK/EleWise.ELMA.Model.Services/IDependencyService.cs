using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.Model.Services;

public interface IDependencyService
{
	MetadataDependencyContainer GetClassMetadataDependencies(ClassMetadata contextMetadata, IMetadata metadata, IEnumerable<FormViewItem> forms, DependencyServiceOptions options = null);

	DependencyAnalysisResult SimpleFormDependencyAnalysis(ClassMetadata contextMetadata, IMetadata metadata, FormViewItem form, DependencyServiceOptions options = null);

	DependencyAnalysisResult SimpleFunctionDependencyAnalysis(FunctionMetadata metadata, DependencyServiceOptions options = null);

	CompatibilityResult CheckFunctionCompatibility(FunctionDependency current, FunctionDependency candidate);

	CompatibilityResult CheckDataClassCompatibility(DataClassDependency current, DataClassDependency candidate);

	void FillDependencies(ComponentMetadata componentMetadata, IEnumerable<Guid> ignoredMetadata, DependencyServiceOptions options = null);

	ModuleDependency CalculateDependencies(ModuleInfoMetadata module, IEnumerable<Guid> ignoredMetadata);
}
