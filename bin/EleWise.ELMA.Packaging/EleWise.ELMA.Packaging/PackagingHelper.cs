using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using NuGet;

namespace EleWise.ELMA.Packaging;

public class PackagingHelper
{
	private PackagingSettings _settings;

	private IPackageRepository _localRepository;

	private ElmaStoreComponentRepository _localComponentsRepository;

	private TransactionalPhysicalFileSystem _localRepositoryFileSystem;

	private DefaultPackagePathResolver _localRepositoryPathResolver;

	private SharedPackageRepository _sharedRepository;

	private static object _lockObj;

	private const int ERROR_ALREADY_EXISTS = 183;

	public IPackageRepository LocalRepository => _localRepository;

	public ElmaStoreComponentRepository LocalComponentsRepository => _localComponentsRepository;

	public TransactionalPhysicalFileSystem LocalRepositoryFileSystem => _localRepositoryFileSystem;

	public DefaultPackagePathResolver LocalRepositoryPathResolver => _localRepositoryPathResolver;

	public SharedPackageRepository SharedRepository => _sharedRepository;

	public static string OperationStatusFileName { get; set; }

	public PackagingHelper(PackagingSettings settings)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (string.IsNullOrEmpty(settings.LocalRepository))
		{
			throw new ArgumentException("settings.LocalRepository is null");
		}
		_settings = settings;
		_localRepositoryFileSystem = new TransactionalPhysicalFileSystem(settings.LocalRepository);
		_localRepositoryPathResolver = new DefaultPackagePathResolver((IFileSystem)(object)_localRepositoryFileSystem);
		_localRepository = (IPackageRepository)new LocalPackageRepository((IPackagePathResolver)(object)_localRepositoryPathResolver, (IFileSystem)(object)_localRepositoryFileSystem, true);
		_localComponentsRepository = new ElmaStoreComponentRepository(settings.LocalRepository);
		_sharedRepository = (SharedPackageRepository)(object)new ElmaSharedPackageRepository((IPackagePathResolver)(object)_localRepositoryPathResolver, (IFileSystem)(object)_localRepositoryFileSystem, (IFileSystem)(object)_localRepositoryFileSystem);
	}

	static PackagingHelper()
	{
		_lockObj = new object();
		OperationStatusFileName = PackageOperationStatus.GenerateFileName(Guid.NewGuid());
	}

	public void SaveOperationStatus(PackageOperationStatus status)
	{
		SaveOperationStatus(OperationStatusFileName, status);
	}

	public void SaveOperationStatus(string fileName, PackageOperationStatus status)
	{
		SaveOperationStatus(Path.Combine(_settings.Root, "PackageManager"), fileName, status);
	}

	public static void SaveOperationStatus(string packageManagerDir, string fileName, PackageOperationStatus status)
	{
		if (status == null)
		{
			throw new ArgumentNullException("status");
		}
		lock (_lockObj)
		{
			string fullFileName = Path.Combine(GetStatusDir(packageManagerDir), fileName);
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(PackageOperationStatus));
			MemoryStream ms = new MemoryStream();
			try
			{
				xmlSerializer.Serialize(ms, status);
				Path.GetDirectoryName(fullFileName);
				try
				{
					FSHelper.CreateFile(fullFileName, delegate
					{
						File.WriteAllBytes(fullFileName, ms.ToArray());
					}, TimeSpan.FromSeconds(1.0));
					SaveLastStatusFileName(packageManagerDir, fileName);
				}
				catch
				{
				}
			}
			finally
			{
				if (ms != null)
				{
					((IDisposable)ms).Dispose();
				}
			}
		}
	}

	public static void SaveError(string packageManagerDir, string errorMessage)
	{
		try
		{
			string statusDir = GetStatusDir(packageManagerDir);
			if (!Directory.Exists(statusDir))
			{
				Directory.CreateDirectory(statusDir);
			}
			string path = Path.Combine(statusDir, "_errors");
			if (!File.Exists(path))
			{
				File.WriteAllText(path, errorMessage + Environment.NewLine, Encoding.UTF8);
			}
			else
			{
				File.AppendAllText(path, errorMessage + Environment.NewLine);
			}
		}
		catch
		{
		}
	}

	public PackageOperationStatus GetOperationStatus(Guid updatingUid)
	{
		return GetOperationStatus(Path.Combine(_settings.Root, "PackageManager"), updatingUid);
	}

	public static PackageOperationStatus GetOperationStatus(string packageManagerDir, Guid updatingUid)
	{
		string path = ((updatingUid == Guid.Empty) ? GetLastStatusFileName(packageManagerDir) : GetStatusFileName(packageManagerDir, updatingUid));
		return GetOperationStatusByFullFileName(Path.Combine(GetStatusDir(packageManagerDir), path));
	}

	public static PackageOperationStatus GetOperationStatusByFullFileName(string fullFileName)
	{
		byte[] array = null;
		DateTime now = DateTime.Now;
		while (DateTime.Now - now <= TimeSpan.FromSeconds(1.0))
		{
			if (!File.Exists(fullFileName))
			{
				Thread.Sleep(50);
				continue;
			}
			try
			{
				array = File.ReadAllBytes(fullFileName);
			}
			catch
			{
				Thread.Sleep(50);
			}
		}
		if (array == null)
		{
			return null;
		}
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(PackageOperationStatus));
		using MemoryStream stream = new MemoryStream(array);
		return (PackageOperationStatus)xmlSerializer.Deserialize(stream);
	}

	public PackageOperationStatus GetOperationStatus()
	{
		return GetOperationStatus(Path.Combine(_settings.Root, "PackageManager"));
	}

	public static PackageOperationStatus GetOperationStatus(string packageManagerDir)
	{
		return GetOperationStatus(packageManagerDir, Guid.Empty);
	}

	public string GetExpandDir()
	{
		return Path.Combine(path3: Process.GetCurrentProcess().Id.ToString(), path1: _settings.Root, path2: "NugetExpand");
	}

	public void PurgeNugetExpandFolder()
	{
		OptimizedZipPackage.PurgeCache();
		FSHelper.DeleteDirectory(GetExpandDir(), recursive: true, new TimeSpan(10L));
	}

	public static IntPtr CreateMutex(string elmaRoot)
	{
		string text;
		using (SHA1 sHA = SHA1.Create())
		{
			text = Convert.ToBase64String(sHA.ComputeHash(Encoding.UTF8.GetBytes(elmaRoot.ToLower()))).Replace('/', '#').Replace('=', '@');
		}
		string lpName = "Elma3PackageManager_" + text;
		int lastError;
		IntPtr intPtr = CreateMutex(IntPtr.Zero, bInitialOwner: true, lpName, out lastError);
		if (intPtr != IntPtr.Zero && lastError == 183)
		{
			return IntPtr.Zero;
		}
		return intPtr;
	}

	public static void ReleaseMutex(IntPtr mutexHandle)
	{
		ReleaseMutexNative(mutexHandle);
	}

	public static string GetStatusDir(string packageManagerDir)
	{
		return Path.Combine(packageManagerDir, "status");
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);

	[DllImport("kernel32.dll", EntryPoint = "ReleaseMutex", SetLastError = true)]
	private static extern bool ReleaseMutexNative(IntPtr mutexHandle);

	private static IntPtr CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName, out int lastError)
	{
		IntPtr result = CreateMutex(lpMutexAttributes, bInitialOwner, lpName);
		lastError = Marshal.GetLastWin32Error();
		return result;
	}

	private static string GetOperationStatusFileName(string root)
	{
		return Path.Combine(root, "PackageManager", "logs", "CurrentOperation.xml");
	}

	private static string GetLastFileName(string packageManagerDir)
	{
		return Path.Combine(GetStatusDir(packageManagerDir), "_last");
	}

	private static void SaveLastStatusFileName(string packageManagerDir, string fileName)
	{
		string lastFileName = GetLastFileName(packageManagerDir);
		FSHelper.CreateFile(lastFileName, delegate
		{
			File.WriteAllText(lastFileName, fileName);
		}, TimeSpan.FromSeconds(1.0));
	}

	private static string GetLastStatusFileName(string packageManagerDir)
	{
		string lastFileName = GetLastFileName(packageManagerDir);
		if (!File.Exists(lastFileName))
		{
			return null;
		}
		string empty = string.Empty;
		DateTime now = DateTime.Now;
		while (true)
		{
			try
			{
				return File.ReadAllText(lastFileName);
			}
			catch
			{
				if (DateTime.Now - now > TimeSpan.FromSeconds(1.0))
				{
					throw new InvalidOperationException(SR.T("Не удалось получить имя файла последней операции своевременно"));
				}
				Thread.Sleep(50);
			}
		}
	}

	private static string GetStatusFileName(string packageManagerDir, Guid updatingUid)
	{
		return Directory.GetFiles(GetStatusDir(packageManagerDir), "*_" + updatingUid.ToString("n") + ".xml").FirstOrDefault();
	}
}
