using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public interface IPublicApiNode
{
	string ParentPath { get; }

	string Path { get; }

	IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree);
}
