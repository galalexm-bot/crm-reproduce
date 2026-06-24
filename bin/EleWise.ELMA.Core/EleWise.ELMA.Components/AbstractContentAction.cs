using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Components;

[Component]
public abstract class AbstractContentAction : IContentActionV2
{
	public abstract string Id { get; }

	public abstract ContentAction ContentAction { get; }
}
