using EleWise.ELMA.Packaging;
using Microsoft.Build.Evaluation;

namespace EleWise.ELMA.BuildTools.MSBuild;

internal class ProjectMetadata : IProjectMetadata
{
	private readonly ProjectMetadata metadata;

	public string Name => metadata.get_Name();

	public string EvaluatedValue => metadata.get_EvaluatedValue();

	public string UnevaluatedValue => metadata.get_UnevaluatedValue();

	public ProjectMetadata(ProjectMetadata metadata)
	{
		this.metadata = metadata;
	}
}
