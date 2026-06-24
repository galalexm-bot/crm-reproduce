using System;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata;

public interface IRootMetadata : IMetadata, IXsiType
{
	void LoadFromType(Type type, bool inherit = true);

	bool IsRestartNeeded(IRootMetadata metadata);

	void ApplyRestartUnrequiredChanges(bool inherit);
}
