using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.FileProvider.Distributed.Models;

internal class EndpointsCollection
{
	private readonly IDictionary<string, Endpoint> endpoints = new Dictionary<string, Endpoint>();

	public string DefaultEndpointName { get; private set; }

	public Endpoint DefaultEndpoint => this[DefaultEndpointName];

	public ICollection<string> AllEndpointNames => endpoints.Keys;

	public Endpoint this[string name] => endpoints[name];

	public EndpointsCollection(IEnumerable<Endpoint> endpointsCollection, ILogger logger)
	{
		Contract.ArgumentNotNull(endpointsCollection, "endpointsCollection");
		Contract.ArgumentNotNull(logger, "logger");
		foreach (Endpoint item in endpointsCollection)
		{
			if (endpoints.ContainsKey(item.Name))
			{
				throw new ConfigurationErrorsException(SR.T("Точка хранения с именем '{0}' уже была добавлена ранее. Имена должны быть уникальны.", item.Name));
			}
			if (item.IsDefault)
			{
				if (!string.IsNullOrEmpty(DefaultEndpointName))
				{
					logger.WarnFormat(SR.T("В конфигурации указано более одной точки хранения по умолчанию (default=\"true\"). Необходимо оставить одну."));
				}
				DefaultEndpointName = item.Name;
			}
			endpoints.Add(item.Name, item);
			logger.InfoFormat(SR.T("В провайдер добавлена точка хранения '{0}' с адресом '{1}'", item.Name, item.Url));
		}
		if (endpoints.Count == 0)
		{
			throw new ConfigurationErrorsException(SR.T("В коллекцию точек хранения контента не было добавлено ни одного узла."));
		}
		DefaultEndpointName = DefaultEndpointName ?? endpoints.Keys.First();
		logger.InfoFormat(SR.T("Точкой хранения по умолчанию выбрана '{0}'", DefaultEndpointName));
	}

	public Endpoint GetOrDefault(string name)
	{
		if (!endpoints.TryGetValue(name, out var value))
		{
			return endpoints[DefaultEndpointName];
		}
		return value;
	}
}
