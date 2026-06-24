using System;
using System.Collections.Generic;
using System.IO;
using EleWise.ELMA.Packaging.FileSystems;
using NuGet;

namespace EleWise.ELMA.Packaging.Components;

public abstract class ElmaMappedFolder : IElmaFolder
{
	private IElmaComponent _component;

	private IFileSystem _fs;

	public IElmaComponent Component => _component;

	protected abstract string SourcePath { get; }

	protected abstract string TargetPath { get; }

	protected virtual bool DeleteEmptyDirs => true;

	public ElmaMappedFolder(IElmaComponent component)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		_component = component;
		_fs = (IFileSystem)(object)new TransactionalPhysicalFileSystem(Path.Combine(component.ComponentRoot, TargetPath));
	}

	public virtual bool IsSupported(string path)
	{
		return path.ToUpper().StartsWith(SourcePath.ToUpper());
	}

	public void AddFile(string path, Stream stream)
	{
		AddFile(path, stream, null, null);
	}

	public void AddFile(string path, Stream stream, DateTime? creationTime, DateTime? lastWriteTime)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		FS.CreateFile(GetFullPath(path), stream, creationTime, lastWriteTime);
	}

	public virtual void DeleteDirectory(string path, bool recursive)
	{
		if (recursive)
		{
			throw new NotSupportedException(SR.T("Действие рекурсивного удаления папки не поддерживается"));
		}
		FS.DeleteDirectory(MapPath(path), DeleteEmptyDirs, _fs.get_Root());
	}

	public virtual void DeleteFile(string path)
	{
		FS.DeleteFile(Path.Combine(_fs.get_Root(), MapPath(path)), DeleteEmptyDirs, _fs.get_Root());
	}

	public virtual bool DirectoryExists(string path)
	{
		return _fs.DirectoryExists(MapPath(path));
	}

	public virtual bool FileExists(string path)
	{
		return _fs.FileExists(MapPath(path));
	}

	public virtual DateTimeOffset GetCreated(string path)
	{
		return _fs.GetCreated(MapPath(path));
	}

	public virtual IEnumerable<string> GetDirectories(string path)
	{
		return _fs.GetDirectories(MapPath(path));
	}

	public virtual IEnumerable<string> GetFiles(string path, string filter, bool recursive)
	{
		return _fs.GetFiles(MapPath(path), filter, recursive);
	}

	public virtual string GetFullPath(string path)
	{
		return _fs.GetFullPath(MapPath(path));
	}

	public virtual DateTimeOffset GetLastAccessed(string path)
	{
		return _fs.GetLastAccessed(MapPath(path));
	}

	public virtual DateTimeOffset GetLastModified(string path)
	{
		return _fs.GetLastModified(MapPath(path));
	}

	public virtual Stream OpenFile(string path)
	{
		return _fs.OpenFile(MapPath(path));
	}

	public virtual void AddFile(string path, Action<Stream> writeToStream)
	{
		_fs.AddFile(MapPath(path), writeToStream);
	}

	public virtual Stream CreateFile(string path)
	{
		return _fs.CreateFile(MapPath(path));
	}

	protected string MapPath(string path)
	{
		return path.Substring(SourcePath.Length);
	}
}
