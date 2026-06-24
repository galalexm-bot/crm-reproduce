using System;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.Utility.Extensions;

namespace Orchard.ContentManagement.MetaData;

public static class ContentDefinitionManagerExtensions
{
	public static void AlterTypeDefinition(this IContentDefinitionManager manager, string name, Action<ContentTypeDefinitionBuilder> alteration)
	{
		ContentTypeDefinitionBuilder contentTypeDefinitionBuilder = new ContentTypeDefinitionBuilder(manager.GetTypeDefinition(name) ?? new ContentTypeDefinition(name, name.CamelFriendly()));
		alteration(contentTypeDefinitionBuilder);
		manager.StoreTypeDefinition(contentTypeDefinitionBuilder.Build());
	}

	public static void AlterPartDefinition(this IContentDefinitionManager manager, string name, Action<ContentPartDefinitionBuilder> alteration)
	{
		ContentPartDefinitionBuilder contentPartDefinitionBuilder = new ContentPartDefinitionBuilder(manager.GetPartDefinition(name) ?? new ContentPartDefinition(name));
		alteration(contentPartDefinitionBuilder);
		manager.StorePartDefinition(contentPartDefinitionBuilder.Build());
	}
}
