using System;
using System.IO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FileProvider.Distributed.Models;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.FileProvider.Distributed;

internal class DistributedFsLocationSchema : ILocationSchema
{
	private readonly Endpoint endpoint;

	internal DistributedFsLocationSchema(Endpoint endpoint)
	{
		this.endpoint = endpoint;
	}

	public Uri MapPersistentLocation(SystemFile systemFile)
	{
		string arg = systemFile.Id + Path.GetExtension(systemFile.Name.ReplaceInvalidFileNameChars());
		return new UriBuilder
		{
			Scheme = "elma",
			Host = endpoint.Name,
			Port = -1,
			Path = $"/{VirtualContentPath.PersistentFolderName}/{arg}"
		}.Uri;
	}

	public Uri MapPreviewLocation(string uid, string contentPath)
	{
		return new UriBuilder
		{
			Scheme = "elma",
			Host = endpoint.Name,
			Port = -1,
			Path = $"/{VirtualContentPath.PreviewFolderName}/{uid}/{contentPath}"
		}.Uri;
	}

	public Uri MapTempLocation(string uid, string extension)
	{
		return new UriBuilder
		{
			Scheme = "elma",
			Host = endpoint.Name,
			Port = -1,
			Path = $"/{VirtualContentPath.TempFolderName}/{uid}"
		}.Uri;
	}

	public Uri CreateNewTempLocation(string extension = null)
	{
		return MapTempLocation(Guid.NewGuid().ToString("N"), extension);
	}

	public Uri RemapTempLocationFor(Uri location)
	{
		return new UriBuilder
		{
			Scheme = "elma",
			Host = endpoint.Name,
			Port = -1,
			Path = location.LocalPath
		}.Uri;
	}
}
