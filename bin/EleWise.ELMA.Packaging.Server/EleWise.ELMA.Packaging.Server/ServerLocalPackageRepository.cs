using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using NuGet;
using NuGet.Resources;

namespace EleWise.ELMA.Packaging.Server.Infrastructure;

public class ServerLocalPackageRepository : PackageRepositoryBase, IPackageLookup, IPackageRepository
{
	private class PackageCacheEntry
	{
		public IPackage Package { get; private set; }

		public DateTimeOffset LastModifiedTime { get; private set; }

		public DateTimeOffset ExpirationTime { get; set; }

		public PackageCacheEntry(IPackage package, DateTimeOffset lastModifiedTime, DateTimeOffset expirationTime)
		{
			Package = package;
			LastModifiedTime = lastModifiedTime;
			ExpirationTime = expirationTime;
		}
	}

	private readonly ConcurrentDictionary<string, PackageCacheEntry> packageCache = new ConcurrentDictionary<string, PackageCacheEntry>(StringComparer.OrdinalIgnoreCase);

	private readonly ConcurrentDictionary<PackageName, string> packagePathLookup = new ConcurrentDictionary<PackageName, string>();

	private readonly bool enableCaching;

	private readonly TimeSpan Expiration = TimeSpan.FromMinutes(5.0);

	public IPackagePathResolver PathResolver { get; set; }

	protected IFileSystem FileSystem { get; private set; }

	public override string Source => FileSystem.get_Root();

	public override bool SupportsPrereleasePackages => true;

	public ServerLocalPackageRepository(string physicalPath)
		: this(physicalPath, enableCaching: true)
	{
	}

	public ServerLocalPackageRepository(string physicalPath, bool enableCaching)
		: this((IPackagePathResolver)new DefaultPackagePathResolver(physicalPath), (IFileSystem)new PhysicalFileSystem(physicalPath), enableCaching)
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)
	//IL_0008: Unknown result type (might be due to invalid IL or missing references)
	//IL_0013: Expected O, but got Unknown
	//IL_0013: Expected O, but got Unknown


	public ServerLocalPackageRepository(IPackagePathResolver pathResolver, IFileSystem fileSystem)
		: this(pathResolver, fileSystem, enableCaching: true)
	{
	}

	public ServerLocalPackageRepository(IPackagePathResolver pathResolver, IFileSystem fileSystem, bool enableCaching)
	{
		if (pathResolver == null)
		{
			throw new ArgumentNullException("pathResolver");
		}
		if (fileSystem == null)
		{
			throw new ArgumentNullException("fileSystem");
		}
		FileSystem = fileSystem;
		PathResolver = pathResolver;
		this.enableCaching = enableCaching;
	}

	public override IQueryable<IPackage> GetPackages()
	{
		return GetPackages(OpenPackage).AsQueryable();
	}

	public bool Exists(string packageId, SemanticVersion version)
	{
		return FindPackage(packageId, version) != null;
	}

	public IPackage FindPackage(string packageId, SemanticVersion version)
	{
		if (string.IsNullOrEmpty(packageId))
		{
			throw new ArgumentException("packageId");
		}
		if (version == (SemanticVersion)null)
		{
			throw new ArgumentNullException("version");
		}
		return FindPackage(OpenPackage, packageId, version);
	}

	public IEnumerable<IPackage> FindPackagesById(string packageId)
	{
		if (string.IsNullOrEmpty(packageId))
		{
			throw new ArgumentException("packageId");
		}
		return FindPackagesById(OpenPackage, packageId);
	}

	protected virtual IPackage OpenPackage(string path)
	{
		if (!FileSystem.FileExists(path))
		{
			return null;
		}
		if (string.Equals(Path.GetExtension(path), Constants.PackageExtension, StringComparison.OrdinalIgnoreCase))
		{
			IPackage val;
			try
			{
				val = CreatePackage(path);
			}
			catch (FileFormatException innerException)
			{
				throw new InvalidDataException(string.Format(CultureInfo.CurrentCulture, NuGetResources.get_ErrorReadingPackage(), path), innerException);
			}
			LocalPackage val2 = (LocalPackage)(object)((val is LocalPackage) ? val : null);
			if (val2 != null)
			{
				val2.set_Published((DateTimeOffset?)FileSystem.GetLastModified(path));
			}
			return val;
		}
		if (Path.GetExtension(path) == Constants.ManifestExtension)
		{
			return (IPackage)(object)new ServerUnzippedPackage(FileSystem, Path.GetFileNameWithoutExtension(path));
		}
		return null;
	}

	private IEnumerable<IPackage> GetPackages(Func<string, IPackage> openPackage)
	{
		return (from p in GetPackageFiles().Select((Func<string, IPackage>)delegate(string path)
			{
				try
				{
					return GetPackage(openPackage, path);
				}
				catch
				{
					return null;
				}
			})
			where p != null
			select p).Distinct();
	}

	private IPackage GetPackage(Func<string, IPackage> openPackage, string path)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		if (!packageCache.TryGetValue(path, out var value) || (value != null && DateTimeOffset.Now > value.ExpirationTime))
		{
			DateTimeOffset lastModified = FileSystem.GetLastModified(path);
			if (value == null || lastModified > value.LastModifiedTime)
			{
				IPackage val = openPackage(path);
				value = new PackageCacheEntry(val, lastModified, DateTimeOffset.UtcNow.Add(Expiration));
				if (enableCaching)
				{
					packageCache[path] = value;
					packagePathLookup.GetOrAdd(new PackageName(((IPackageName)val).get_Id(), ((IPackageName)val).get_Version()), path);
				}
			}
			else
			{
				value.ExpirationTime = DateTimeOffset.UtcNow.Add(Expiration);
			}
		}
		return value.Package;
	}

	private IEnumerable<string> GetPackageFiles(string filter = null)
	{
		filter = filter ?? ("*" + Constants.PackageExtension);
		foreach (string directory in FileSystem.GetDirectories(string.Empty))
		{
			foreach (string file in FileSystemExtensions.GetFiles(FileSystem, directory, filter))
			{
				yield return file;
			}
		}
		foreach (string file2 in FileSystemExtensions.GetFiles(FileSystem, string.Empty, filter))
		{
			yield return file2;
		}
	}

	private IPackage FindPackage(Func<string, IPackage> openPackage, string packageId, SemanticVersion version)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		PackageName lookupPackageName = new PackageName(packageId, version);
		if (enableCaching && packagePathLookup.TryGetValue(lookupPackageName, out var value) && FileSystem.FileExists(value))
		{
			return GetPackage(openPackage, value);
		}
		return (from path in GetPackageLookupPaths(packageId, version)
			select new
			{
				path = path,
				package = GetPackage(openPackage, path)
			} into p
			where lookupPackageName.Equals(new PackageName(((IPackageName)p.package).get_Id(), ((IPackageName)p.package).get_Version()))
			select p.package).FirstOrDefault();
	}

	public virtual IEnumerable<string> GetPackageLookupPaths(string packageId, SemanticVersion version)
	{
		string packageFileName = PathResolver.GetPackageFileName(packageId, version);
		string filter = Path.ChangeExtension(packageFileName, Constants.ManifestExtension);
		IEnumerable<string> enumerable = GetPackageFiles(packageFileName).Concat(GetPackageFiles(filter));
		if (!(version != (SemanticVersion)null) || version.get_Version().Revision >= 1)
		{
			return enumerable;
		}
		string text = ((version.get_Version().Build < 1) ? string.Join(".", packageId, version.get_Version().Major, version.get_Version().Minor) : string.Join(".", packageId, version.get_Version().Major, version.get_Version().Minor, version.get_Version().Build));
		string text2 = text;
		string filter2 = text2 + "*" + Constants.ManifestExtension;
		IEnumerable<string> second = from path in GetPackageFiles(text2 + "*" + Constants.PackageExtension)
			where FileNameMatchesPattern(packageId, version, path)
			select path;
		IEnumerable<string> second2 = from path in GetPackageFiles(filter2)
			where FileNameMatchesPattern(packageId, version, path)
			select path;
		return enumerable.Concat(second).Concat(second2);
	}

	private IEnumerable<IPackage> FindPackagesById(Func<string, IPackage> openPackage, string packageId)
	{
		HashSet<IPackage> hashSet = new HashSet<IPackage>((IEqualityComparer<IPackage>)PackageEqualityComparer.IdAndVersion);
		AddRange(hashSet, GetPackages(openPackage, packageId, GetPackageFiles(packageId + "*" + Constants.PackageExtension)));
		return hashSet;
	}

	private IEnumerable<IPackage> GetPackages(Func<string, IPackage> openPackage, string packageId, IEnumerable<string> packagePaths)
	{
		foreach (string packagePath in packagePaths)
		{
			IPackage val = null;
			try
			{
				val = GetPackage(openPackage, packagePath);
			}
			catch (InvalidOperationException)
			{
				if (!string.Equals(Constants.ManifestExtension, Path.GetExtension(packagePath), StringComparison.OrdinalIgnoreCase))
				{
					throw;
				}
			}
			if (val != null && ((IPackageName)val).get_Id().Equals(packageId, StringComparison.OrdinalIgnoreCase))
			{
				yield return val;
			}
		}
	}

	protected virtual IPackage CreatePackage(string path)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		return (IPackage)new OptimizedZipPackage(FileSystem, path);
	}

	private static bool FileNameMatchesPattern(string packageId, SemanticVersion version, string path)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
		SemanticVersion val = default(SemanticVersion);
		if (fileNameWithoutExtension.Length > packageId.Length && SemanticVersion.TryParse(fileNameWithoutExtension.Substring(packageId.Length + 1), ref val))
		{
			return val == version;
		}
		return false;
	}

	private static void AddRange<T>(ICollection<T> collection, IEnumerable<T> items)
	{
		foreach (T item in items)
		{
			collection.Add(item);
		}
	}
}
