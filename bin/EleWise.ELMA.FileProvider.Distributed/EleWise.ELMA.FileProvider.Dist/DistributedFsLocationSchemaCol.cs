using System.Collections.Generic;
using EleWise.ELMA.FileProvider.Distributed.Managers;
using EleWise.ELMA.FileProvider.Distributed.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.FileProvider.Distributed;

internal class DistributedFsLocationSchemaCollection
{
	private readonly EndpointsCollection endpoints;

	private readonly IFileGatewayService fileGatewayService;

	private DistributedFileOriginManager fileOriginManager;

	private readonly Dictionary<string, ILocationSchema> schemas = new Dictionary<string, ILocationSchema>();

	protected DistributedFileOriginManager FileOriginManager => fileOriginManager ?? (fileOriginManager = Locator.GetServiceNotNull<DistributedFileOriginManager>());

	public ILocationSchema SystemLocationSchema => schemas[endpoints.DefaultEndpointName];

	public DistributedFsLocationSchemaCollection(EndpointsCollection endpoints, IFileGatewayService fileGatewayService)
	{
		this.endpoints = endpoints;
		this.fileGatewayService = fileGatewayService;
		foreach (string allEndpointName in endpoints.AllEndpointNames)
		{
			schemas[allEndpointName] = new DistributedFsLocationSchema(endpoints[allEndpointName]);
		}
	}

	public ILocationSchema GetNearestLocationSchema()
	{
		string closestGateway = fileGatewayService.GetClosestGateway();
		return schemas[closestGateway];
	}

	public ILocationSchema GetSourceLocationSchema(SystemFile systemFile)
	{
		BinaryFileOrigin binaryFileOrigin = FileOriginManager.LoadOrigin(systemFile);
		return schemas[binaryFileOrigin.SourceGateway];
	}

	public ILocationSchema GetOrDefault(string name)
	{
		if (!schemas.TryGetValue(name, out var value))
		{
			return schemas[endpoints.DefaultEndpointName];
		}
		return value;
	}
}
