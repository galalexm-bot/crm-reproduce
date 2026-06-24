using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using Orchard.Environment.Configuration;
using Orchard.Exceptions;
using Orchard.Localization;
using Orchard.Validation;

namespace Orchard.FileSystems.Media;

public class FileSystemStorageProvider : IStorageProvider, IDependency
{
	private class FileSystemStorageFile : IStorageFile
	{
		private readonly string _path;

		private readonly FileInfo _fileInfo;

		public FileSystemStorageFile(string path, FileInfo fileInfo)
		{
			_path = path;
			_fileInfo = fileInfo;
		}

		public string GetPath()
		{
			return _path;
		}

		public string GetName()
		{
			return _fileInfo.Name;
		}

		public long GetSize()
		{
			return _fileInfo.Length;
		}

		public DateTime GetLastUpdated()
		{
			return _fileInfo.LastWriteTime;
		}

		public string GetFileType()
		{
			return _fileInfo.Extension;
		}

		public Stream OpenRead()
		{
			return new FileStream(_fileInfo.FullName, FileMode.Open, FileAccess.Read);
		}

		public Stream OpenWrite()
		{
			return new FileStream(_fileInfo.FullName, FileMode.Open, FileAccess.ReadWrite);
		}

		public Stream CreateFile()
		{
			return new FileStream(_fileInfo.FullName, FileMode.Truncate, FileAccess.ReadWrite);
		}
	}

	private class FileSystemStorageFolder : IStorageFolder
	{
		private readonly string _path;

		private readonly DirectoryInfo _directoryInfo;

		public Localizer T { get; set; }

		public FileSystemStorageFolder(string path, DirectoryInfo directoryInfo)
		{
			_path = path;
			_directoryInfo = directoryInfo;
			T = NullLocalizer.Instance;
		}

		public string GetPath()
		{
			return _path;
		}

		public string GetName()
		{
			return _directoryInfo.Name;
		}

		public DateTime GetLastUpdated()
		{
			return _directoryInfo.LastWriteTime;
		}

		public long GetSize()
		{
			return GetDirectorySize(_directoryInfo);
		}

		public IStorageFolder GetParent()
		{
			if (_directoryInfo.Parent != null)
			{
				return new FileSystemStorageFolder(Path.GetDirectoryName(_path), _directoryInfo.Parent);
			}
			throw new ArgumentException(T("Directory {0} does not have a parent directory", _directoryInfo.Name).ToString());
		}

		private static long GetDirectorySize(DirectoryInfo directoryInfo)
		{
			long num = 0L;
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				if (!IsHidden(fileInfo))
				{
					num += fileInfo.Length;
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				if (!IsHidden(directoryInfo2))
				{
					num += GetDirectorySize(directoryInfo2);
				}
			}
			return num;
		}
	}

	private readonly string _storagePath;

	private readonly string _virtualPath;

	private readonly string _publicPath;

	public Localizer T { get; set; }

	public FileSystemStorageProvider(ShellSettings settings)
	{
		string path = (HostingEnvironment.IsHosted ? (HostingEnvironment.MapPath("~/Media/") ?? "") : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Media"));
		_storagePath = Path.Combine(path, settings.Name);
		_virtualPath = "~/Media/" + settings.Name + "/";
		string text = "";
		if (HostingEnvironment.IsHosted)
		{
			text = HostingEnvironment.ApplicationVirtualPath;
		}
		if (!text.EndsWith("/"))
		{
			text += "/";
		}
		if (!text.StartsWith("/"))
		{
			text = "/" + text;
		}
		_publicPath = text + "Media/" + settings.Name + "/";
		T = NullLocalizer.Instance;
	}

	private string MapStorage(string path)
	{
		string mappedPath = (string.IsNullOrEmpty(path) ? _storagePath : Path.Combine(_storagePath, path));
		return PathValidation.ValidatePath(_storagePath, mappedPath);
	}

	private string MapPublic(string path)
	{
		if (!string.IsNullOrEmpty(path))
		{
			return Path.Combine(_publicPath, path).Replace(Path.DirectorySeparatorChar, '/').Replace(" ", "%20");
		}
		return _publicPath;
	}

	private static string Fix(string path)
	{
		if (!string.IsNullOrEmpty(path))
		{
			if (Path.DirectorySeparatorChar == '/')
			{
				return path;
			}
			return path.Replace('/', Path.DirectorySeparatorChar);
		}
		return "";
	}

	public bool FileExists(string path)
	{
		return File.Exists(MapStorage(path));
	}

	public string GetPublicUrl(string path)
	{
		return MapPublic(path);
	}

	public string GetStoragePath(string url)
	{
		if (url.StartsWith(_virtualPath))
		{
			return url.Substring(_virtualPath.Length).Replace('/', Path.DirectorySeparatorChar).Replace("%20", " ");
		}
		if (url.StartsWith(_publicPath))
		{
			return url.Substring(_publicPath.Length).Replace('/', Path.DirectorySeparatorChar).Replace("%20", " ");
		}
		return null;
	}

	public IStorageFile GetFile(string path)
	{
		FileInfo fileInfo = new FileInfo(MapStorage(path));
		if (!fileInfo.Exists)
		{
			throw new ArgumentException(T("File {0} does not exist", path).ToString());
		}
		return new FileSystemStorageFile(Fix(path), fileInfo);
	}

	public IEnumerable<IStorageFile> ListFiles(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(MapStorage(path));
		if (!directoryInfo.Exists)
		{
			throw new ArgumentException(T("Directory {0} does not exist", path).ToString());
		}
		return (from fi in directoryInfo.GetFiles()
			where !IsHidden(fi)
			select fi).Select((Func<FileInfo, IStorageFile>)((FileInfo fi) => new FileSystemStorageFile(Path.Combine(Fix(path), fi.Name), fi))).ToList();
	}

	public bool FolderExists(string path)
	{
		return new DirectoryInfo(MapStorage(path)).Exists;
	}

	public IEnumerable<IStorageFolder> ListFolders(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(MapStorage(path));
		if (!directoryInfo.Exists)
		{
			try
			{
				directoryInfo.Create();
			}
			catch (Exception ex)
			{
				if (ex.IsFatal())
				{
					throw;
				}
				throw new ArgumentException(T("The folder could not be created at path: {0}. {1}", path, ex).ToString());
			}
		}
		return (from di in directoryInfo.GetDirectories()
			where !IsHidden(di)
			select di).Select((Func<DirectoryInfo, IStorageFolder>)((DirectoryInfo di) => new FileSystemStorageFolder(Path.Combine(Fix(path), di.Name), di))).ToList();
	}

	public bool TryCreateFolder(string path)
	{
		try
		{
			if (new DirectoryInfo(MapStorage(path)).Exists)
			{
				return false;
			}
			CreateFolder(path);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public void CreateFolder(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(MapStorage(path));
		if (directoryInfo.Exists)
		{
			throw new ArgumentException(T("Directory {0} already exists", path).ToString());
		}
		Directory.CreateDirectory(directoryInfo.FullName);
	}

	public void DeleteFolder(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(MapStorage(path));
		if (!directoryInfo.Exists)
		{
			throw new ArgumentException(T("Directory {0} does not exist", path).ToString());
		}
		directoryInfo.Delete(recursive: true);
	}

	public void RenameFolder(string oldPath, string newPath)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(MapStorage(oldPath));
		if (!directoryInfo.Exists)
		{
			throw new ArgumentException(T("Directory {0} does not exist", oldPath).ToString());
		}
		DirectoryInfo directoryInfo2 = new DirectoryInfo(MapStorage(newPath));
		if (directoryInfo2.Exists)
		{
			throw new ArgumentException(T("Directory {0} already exists", newPath).ToString());
		}
		Directory.Move(directoryInfo.FullName, directoryInfo2.FullName);
	}

	public void DeleteFile(string path)
	{
		FileInfo fileInfo = new FileInfo(MapStorage(path));
		if (!fileInfo.Exists)
		{
			throw new ArgumentException(T("File {0} does not exist", path).ToString());
		}
		fileInfo.Delete();
	}

	public void RenameFile(string oldPath, string newPath)
	{
		FileInfo fileInfo = new FileInfo(MapStorage(oldPath));
		if (!fileInfo.Exists)
		{
			throw new ArgumentException(T("File {0} does not exist", oldPath).ToString());
		}
		FileInfo fileInfo2 = new FileInfo(MapStorage(newPath));
		if (fileInfo2.Exists)
		{
			throw new ArgumentException(T("File {0} already exists", newPath).ToString());
		}
		File.Move(fileInfo.FullName, fileInfo2.FullName);
	}

	public void CopyFile(string originalPath, string duplicatePath)
	{
		FileInfo fileInfo = new FileInfo(MapStorage(originalPath));
		if (!fileInfo.Exists)
		{
			throw new ArgumentException(T("File {0} does not exist", originalPath).ToString());
		}
		FileInfo fileInfo2 = new FileInfo(MapStorage(duplicatePath));
		if (fileInfo2.Exists)
		{
			throw new ArgumentException(T("File {0} already exists", duplicatePath).ToString());
		}
		File.Copy(fileInfo.FullName, fileInfo2.FullName);
	}

	public IStorageFile CreateFile(string path)
	{
		FileInfo fileInfo = new FileInfo(MapStorage(path));
		if (fileInfo.Exists)
		{
			throw new ArgumentException(T("File {0} already exists", fileInfo.Name).ToString());
		}
		string directoryName = Path.GetDirectoryName(fileInfo.FullName);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		File.WriteAllBytes(fileInfo.FullName, Array.Empty<byte>());
		return new FileSystemStorageFile(Fix(path), fileInfo);
	}

	public bool TrySaveStream(string path, Stream inputStream)
	{
		try
		{
			if (FileExists(path))
			{
				return false;
			}
			SaveStream(path, inputStream);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public void SaveStream(string path, Stream inputStream)
	{
		using Stream stream = CreateFile(path).OpenWrite();
		byte[] array = new byte[8192];
		while (true)
		{
			int num = inputStream.Read(array, 0, array.Length);
			if (num <= 0)
			{
				break;
			}
			stream.Write(array, 0, num);
		}
	}

	public string Combine(string path1, string path2)
	{
		return Path.Combine(path1, path2);
	}

	private static bool IsHidden(FileSystemInfo di)
	{
		return (di.Attributes & FileAttributes.Hidden) != 0;
	}
}
