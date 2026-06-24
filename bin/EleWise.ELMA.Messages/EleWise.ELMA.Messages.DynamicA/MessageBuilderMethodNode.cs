using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;

namespace EleWise.ELMA.Messages.DynamicAPI;

internal sealed class MessageBuilderMethodNode : PublicApiCustomBuilderMethodNode, IPublicApiNode
{
	public MessageBuilderMethodNode(string parentPath, string methodName, string @namespace, string className, string summaryComment)
		: base(parentPath, methodName, @namespace, className, summaryComment)
	{
	}

	IEnumerable<ISyntaxNode> IPublicApiNode.Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		if (!tree[base.Path].OfType<PublicApiCustomBuilderNode>().Any())
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		return new ISyntaxNode[1] { PublicApiNodeGenerate() };
	}
}
