namespace EleWise.ELMA.Packaging;

internal interface IProjectMetadata
{
	string Name { get; }

	string EvaluatedValue { get; }

	string UnevaluatedValue { get; }
}
