using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.FieldStorage;

public class FieldStorageProviderSelector : IFieldStorageProviderSelector, IDependency
{
	public const string Storage = "Storage";

	public const string DefaultProviderName = "Infoset";

	private readonly IEnumerable<IFieldStorageProvider> _storageProviders;

	public FieldStorageProviderSelector(IEnumerable<IFieldStorageProvider> storageProviders)
	{
		_storageProviders = storageProviders;
	}

	public IFieldStorageProvider GetProvider(ContentPartFieldDefinition partFieldDefinition)
	{
		IFieldStorageProvider fieldStorageProvider = null;
		if (partFieldDefinition.Settings.TryGetValue("Storage", out var value))
		{
			fieldStorageProvider = Locate(value);
		}
		return fieldStorageProvider ?? Locate("Infoset");
	}

	private IFieldStorageProvider Locate(string providerName)
	{
		return _storageProviders.FirstOrDefault((IFieldStorageProvider provider) => provider.ProviderName == providerName);
	}
}
