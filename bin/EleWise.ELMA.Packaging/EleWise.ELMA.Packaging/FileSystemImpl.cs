using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Packaging.Components;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal class FileSystemImpl : IFileSystem
{
	private class RootFolder : ElmaMappedFolder
	{
		protected override string SourcePath => "";

		protected override string TargetPath => "";

		public RootFolder(IElmaComponent component)
			: base(component)
		{
		}
	}

	private IElmaComponent _component;

	private IEnumerable<IElmaFolder> _folders;

	private IElmaFolder _rootFolder;

	public string Root => _component.ComponentRoot;

	public ILogger Logger { get; set; }

	public IEnumerable<IElmaFolder> Folders => _folders;

	public IElmaComponent Component => _component;

	public FileSystemImpl(IElmaComponent component, IEnumerable<IElmaFolder> folders)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (folders == null)
		{
			throw new ArgumentNullException("folders");
		}
		_component = component;
		_folders = folders;
	}

	public void AddFile(string path, Stream stream)
	{
		GetFolder(path).AddFile(path, stream);
	}

	public void AddFile(string path, Stream stream, DateTime? creationTime, DateTime? lastWriteTime)
	{
		GetFolder(path).AddFile(path, stream, creationTime, lastWriteTime);
	}

	public void DeleteDirectory(string path, bool recursive)
	{
		GetFolder(path).DeleteDirectory(path, recursive);
	}

	public void DeleteFile(string path)
	{
		GetFolder(path).DeleteFile(path);
	}

	public bool DirectoryExists(string path)
	{
		return GetFolder(path).DirectoryExists(path);
	}

	public bool FileExists(string path)
	{
		return GetFolder(path).FileExists(path);
	}

	public DateTimeOffset GetCreated(string path)
	{
		return GetFolder(path).GetCreated(path);
	}

	public IEnumerable<string> GetDirectories(string path)
	{
		return GetFolder(path).GetDirectories(path);
	}

	public IEnumerable<string> GetFiles(string path, string filter, bool recursive)
	{
		return GetFolder(path).GetFiles(path, filter, recursive);
	}

	public string GetFullPath(string path)
	{
		return GetFolder(path).GetFullPath(path);
	}

	public DateTimeOffset GetLastAccessed(string path)
	{
		return GetFolder(path).GetLastAccessed(path);
	}

	public DateTimeOffset GetLastModified(string path)
	{
		return GetFolder(path).GetLastModified(path);
	}

	public Stream OpenFile(string path)
	{
		return GetFolder(path).OpenFile(path);
	}

	public void AddFile(string path, Action<Stream> writeToStream)
	{
		GetFolder(path).AddFile(path, writeToStream);
	}

	public void DeleteFiles(IEnumerable<IPackageFile> files, string rootDir)
	{
		throw new NotImplementedException();
	}

	public void AddFiles(IEnumerable<IPackageFile> files, string rootDir)
	{
		throw new NotImplementedException();
	}

	public void MakeFileWritable(string path)
	{
		throw new NotImplementedException();
	}

	public void MoveFile(string source, string destination)
	{
		throw new NotImplementedException();
	}

	public Stream CreateFile(string path)
	{
		throw new NotImplementedException();
	}

	protected virtual IElmaFolder GetFolder(string path, bool throwOnError = true)
	{
		if (!path.Contains(Path.DirectorySeparatorChar))
		{
			if (_rootFolder == null)
			{
				_rootFolder = new RootFolder(_component);
			}
			return _rootFolder;
		}
		IElmaFolder elmaFolder = _folders.FirstOrDefault((IElmaFolder f) => f.IsSupported(path));
		if (elmaFolder == null && throwOnError)
		{
			throw new PackagingException(SR.T("Не найден дескриптор папки для пути \"{0}\"", path));
		}
		return elmaFolder;
	}
}
