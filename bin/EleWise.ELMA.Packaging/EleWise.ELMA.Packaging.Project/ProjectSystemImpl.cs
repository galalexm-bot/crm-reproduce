using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;
using EleWise.ELMA.Packaging.Components;
using NuGet;

namespace EleWise.ELMA.Packaging.ProjectSystem;

internal class ProjectSystemImpl : FileSystemImpl, IProjectSystem, IFileSystem, IPropertyProvider
{
	internal const string NetFrameworkIdentifier = ".NETFramework";

	internal static readonly Version NetFrameworkTargetVersion = new Version(4, 8);

	internal static readonly FrameworkName TargetFrameworkName = new FrameworkName(".NETFramework", NetFrameworkTargetVersion);

	private IElmaProjectSystem _projectSystem;

	private FrameworkName _targetFramework;

	public IElmaProjectSystem ProjectSystem => _projectSystem;

	public bool IsBindingRedirectSupported => false;

	public string ProjectName => base.Component.Name;

	public FrameworkName TargetFramework => TargetFrameworkName;

	public ProjectSystemImpl(IElmaComponent component, IEnumerable<IElmaFolder> folders, IElmaProjectSystem projectSystem)
		: base(component, folders)
	{
		if (projectSystem == null)
		{
			throw new ArgumentNullException("projectSystem");
		}
		_projectSystem = projectSystem;
	}

	public void AddFrameworkReference(string name)
	{
	}

	public void AddReference(string referencePath, Stream stream)
	{
		_projectSystem.AddReference(referencePath, stream);
	}

	public void AddReference(string referencePath, Stream stream, DateTime? creationTime, DateTime? lastWriteTime)
	{
		_projectSystem.AddReference(referencePath, stream, creationTime, lastWriteTime);
	}

	public bool IsSupportedFile(string path)
	{
		return GetFolder(path, throwOnError: false) != null;
	}

	public bool ReferenceExists(string referencePath)
	{
		return _projectSystem.ReferenceExists(referencePath);
	}

	public void RemoveReference(string referencePath)
	{
		_projectSystem.RemoveReference(referencePath);
	}

	public string ResolvePath(string path)
	{
		return path;
	}

	public dynamic GetPropertyValue(string propertyName)
	{
		if (propertyName == null)
		{
			return null;
		}
		if (!propertyName.Equals("RootNamespace", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		return string.Empty;
	}

	public void AddImport(string targetFullPath, ProjectImportLocation location)
	{
		throw new NotImplementedException();
	}

	public void RemoveImport(string targetFullPath)
	{
		throw new NotImplementedException();
	}

	public bool FileExistsInProject(string path)
	{
		throw new NotImplementedException();
	}
}
