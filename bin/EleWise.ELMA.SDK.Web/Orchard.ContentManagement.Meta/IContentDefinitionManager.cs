using System.Collections.Generic;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.MetaData;

public interface IContentDefinitionManager : IDependency
{
	IEnumerable<ContentTypeDefinition> ListTypeDefinitions();

	IEnumerable<ContentPartDefinition> ListPartDefinitions();

	IEnumerable<ContentFieldDefinition> ListFieldDefinitions();

	ContentTypeDefinition GetTypeDefinition(string name);

	ContentPartDefinition GetPartDefinition(string name);

	void DeleteTypeDefinition(string name);

	void DeletePartDefinition(string name);

	void StoreTypeDefinition(ContentTypeDefinition contentTypeDefinition);

	void StorePartDefinition(ContentPartDefinition contentPartDefinition);
}
