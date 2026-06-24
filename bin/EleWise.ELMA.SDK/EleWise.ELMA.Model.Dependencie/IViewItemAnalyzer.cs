using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

[ExtensionPoint(ComponentType.All)]
internal interface IViewItemAnalyzer
{
	DependencyAnalysisResult Analyse(ClassMetadata contextMetadata, IMetadata metadata, FormViewItem form, DependencyServiceOptions options);
}
