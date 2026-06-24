using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Packaging;

public sealed class PackageInfoEqualityComparer : IEqualityComparer<PackageInfo>
{
	public static readonly PackageInfoEqualityComparer IdAndVersion = new PackageInfoEqualityComparer((PackageInfo x, PackageInfo y) => x.Id.Equals(y.Id, StringComparison.OrdinalIgnoreCase) && x.Version.Equals(y.Version), (PackageInfo x) => x.Id.GetHashCode() ^ ((object)x.Version).GetHashCode());

	public static readonly PackageInfoEqualityComparer Id = new PackageInfoEqualityComparer((PackageInfo x, PackageInfo y) => x.Id.Equals(y.Id, StringComparison.OrdinalIgnoreCase), (PackageInfo x) => x.Id.GetHashCode());

	private readonly Func<PackageInfo, PackageInfo, bool> _equals;

	private readonly Func<PackageInfo, int> _getHashCode;

	private PackageInfoEqualityComparer(Func<PackageInfo, PackageInfo, bool> equals, Func<PackageInfo, int> getHashCode)
	{
		_equals = equals;
		_getHashCode = getHashCode;
	}

	public bool Equals(PackageInfo x, PackageInfo y)
	{
		return _equals(x, y);
	}

	public int GetHashCode(PackageInfo obj)
	{
		return _getHashCode(obj);
	}
}
