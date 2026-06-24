using System;
using System.IO;
using System.Threading;
using EleWise.ELMA.Packaging.FileSystems;
using NuGet;

namespace EleWise.ELMA.Packaging;

public class TransactionalPhysicalFileSystem : PhysicalFileSystem
{
	public TransactionalPhysicalFileSystem(string root)
		: base(root)
	{
	}

	public override void AddFile(string path, Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		((PhysicalFileSystem)this).EnsureDirectory(Path.GetDirectoryName(path));
		string fullPath = ((PhysicalFileSystem)this).GetFullPath(path);
		FS.CreateFile(fullPath, delegate
		{
			using Stream destination = File.Create(fullPath);
			stream.CopyTo(destination);
		});
	}

	public override void AddFile(string path, Action<Stream> writeToStream)
	{
		if (writeToStream == null)
		{
			throw new ArgumentNullException("writeToStream");
		}
		((PhysicalFileSystem)this).EnsureDirectory(Path.GetDirectoryName(path));
		string fullPath = ((PhysicalFileSystem)this).GetFullPath(path);
		FS.CreateFile(fullPath, delegate
		{
			using Stream obj = File.Create(fullPath);
			writeToStream(obj);
		});
	}

	public override void DeleteFile(string path)
	{
		if (!((PhysicalFileSystem)this).FileExists(path))
		{
			return;
		}
		try
		{
			path = ((PhysicalFileSystem)this).GetFullPath(path);
			FS.DeleteFile(path);
		}
		catch (FileNotFoundException)
		{
		}
	}

	public override void DeleteDirectory(string path)
	{
		((PhysicalFileSystem)this).DeleteDirectory(path, false);
	}

	public override void DeleteDirectory(string path, bool recursive)
	{
		if (!((PhysicalFileSystem)this).DirectoryExists(path))
		{
			return;
		}
		try
		{
			path = ((PhysicalFileSystem)this).GetFullPath(path);
			FS.DeleteDirectory(path, deleteEmptyDirs: false, null);
			int num = 0;
			while (Directory.Exists(path) && num < 5)
			{
				Thread.Sleep(100);
				num++;
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
	}
}
