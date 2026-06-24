using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IFeedObjectGroupExtension
{
	string MessageTypeCssClass { get; }

	string CommentaryDescription { get; }

	bool IsSupport(Guid objectTypeUid);

	string MessageTypeName(Guid objectTypeUid);
}
