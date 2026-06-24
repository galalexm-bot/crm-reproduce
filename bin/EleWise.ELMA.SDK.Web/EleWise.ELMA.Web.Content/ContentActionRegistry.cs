using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Content;

[Service(Scope = ServiceScope.Shell)]
public class ContentActionRegistry : IContentActionRegistry
{
	private readonly IDictionary<string, ILinkTypeProvider> linkTypeProviders;

	public ContentActionRegistry(IEnumerable<ILinkTypeProvider> linkTypeProviders)
	{
		if (linkTypeProviders == null)
		{
			throw new ArgumentNullException("linkTypeProviders");
		}
		this.linkTypeProviders = (from l in linkTypeProviders
			group l by l.Id).ToDictionary((IGrouping<string, ILinkTypeProvider> p) => p.Key, (IGrouping<string, ILinkTypeProvider> g) => g.First());
	}

	public IContentAction Get(string typeId, string id)
	{
		return GetLinkTypeProvider(typeId)?.Get(id);
	}

	public ILinkTypeProvider GetLinkTypeProvider(string typeId)
	{
		linkTypeProviders.TryGetValue(typeId, out var value);
		if (value == null && typeId.StartsWith("configuration_pagev2"))
		{
			linkTypeProviders.TryGetValue("EleWise.ELMA.Web.Content.ContentActionConstants.PageLinkTypeProvider", out value);
		}
		return value;
	}
}
