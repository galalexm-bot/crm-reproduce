using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Messages.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IInformationChannelGroup
{
	Guid Uid { get; }

	string Name { get; }

	string FullName { get; }

	string IdItem { get; }

	string ImageUrl { get; }

	string BigImageUrl { get; }

	bool Expanded { get; }

	int Order { get; }

	string Description { get; }

	string GetUrl(HtmlHelper html);
}
