using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Packaging.Logging;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ElmaStoreComponentRepository
{
	private class ComponentCacheEntry
	{
		public ElmaStoreComponentFile Component { get; private set; }

		public DateTimeOffset LastModifiedTime { get; private set; }

		public ComponentCacheEntry(ElmaStoreComponentFile component, DateTimeOffset lastModifiedTime)
		{
			Component = component;
			LastModifiedTime = lastModifiedTime;
		}
	}

	private readonly ConcurrentDictionary<string, ComponentCacheEntry> _componentCache = new ConcurrentDictionary<string, ComponentCacheEntry>(StringComparer.OrdinalIgnoreCase);

	private string _path;

	public string Source => _path;

	public ElmaStoreComponentRepository(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentNullException("path");
		}
		_path = path;
	}

	public IEnumerable<ElmaStoreComponentFile> GetComponents()
	{
		if (!Directory.Exists(_path))
		{
			return new ElmaStoreComponentFile[0];
		}
		List<string> list = (from fn in Directory.GetFiles(_path, "*.elma4manifest").Union(Directory.GetFiles(_path, "*.elma4")).Union(ElmaStoreComponentFile.SupportedComponentExtension.SelectMany((string ext) => Directory.GetFiles(_path, "*" + ext)))
				.Union(ElmaStoreComponentFile.SupportedManifestMask.SelectMany((string mask) => Directory.GetFiles(_path, mask)))
			select Path.Combine(_path, Path.GetFileNameWithoutExtension(fn))).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
		List<ElmaStoreComponentFile> list2 = new List<ElmaStoreComponentFile>();
		foreach (string item in list)
		{
			try
			{
				string componentFileName = GetComponentFileName(item);
				ElmaStoreComponentFile component2 = GetComponent((string fn) => new ElmaStoreComponentFile(fn), componentFileName);
				list2.Add(component2);
			}
			catch (Exception exception)
			{
				Logger.Log.Error($"Cannot load component from file '{item}'", exception);
			}
		}
		foreach (IGrouping<string, ElmaStoreComponentFile> group in from g in (from c in list2
				group c by c.Id + " " + c.Version).ToList()
			where g.Count() > 1
			select g)
		{
			ElmaStoreComponentFile component = group.FirstOrDefault((ElmaStoreComponentFile g) => g.ComponentFileExists);
			if (component == null)
			{
				component = group.First();
			}
			list2.RemoveAll((ElmaStoreComponentFile c) => group.Contains(c) && c != component);
		}
		return list2;
	}

	public void RemoveComponentFile(ElmaStoreComponentFile componentFile)
	{
		if (componentFile == null)
		{
			throw new ArgumentNullException("componentFile");
		}
	}

	private ElmaStoreComponentFile GetComponent(Func<string, ElmaStoreComponentFile> openComponent, string path)
	{
		DateTimeOffset dateTimeOffset = File.GetLastWriteTime(path);
		if (!_componentCache.TryGetValue(path, out var value) || (value != null && dateTimeOffset > value.LastModifiedTime))
		{
			value = new ComponentCacheEntry(openComponent(path), dateTimeOffset);
			_componentCache[path] = value;
		}
		return value.Component;
	}

	private string GetComponentFileName(string fileName)
	{
		return (from ext in new string[2] { ".elma4manifest", ".elma4" }.Concat(ElmaStoreComponentFile.SupportedManifestExtension).Concat(ElmaStoreComponentFile.SupportedComponentExtension)
			select fileName + ext).First(File.Exists);
	}
}
