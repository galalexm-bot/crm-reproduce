using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Components;

[Component]
internal sealed class PackageLinkedFinder : StringKeyLinkedFinder
{
	private readonly IDeployManager deployManager;

	internal static PackageLinkedFinder hEVpPafGb3RhePr2y60C;

	public PackageLinkedFinder(IDeployManager deployManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.deployManager = deployManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		FindLinkedObjectsResult findLinkedObjectsResult = new FindLinkedObjectsResult();
		foreach (IStringKeyLinkedObject item in objectsToSearch.OfType<IStringKeyLinkedObject>())
		{
			if (!(GetData(item.UidStr, context) is PackageDescription description))
			{
				continue;
			}
			foreach (PackageDescription item2 in deployManager.FindPackageDependencies(description))
			{
				FillStrObj(findLinkedObjectsResult, context, item2.Id);
			}
		}
		return findLinkedObjectsResult;
	}

	protected override object GetDataWithUidStr(string uidStr, LinkedObjectsContext context)
	{
		int num = 1;
		int num2 = num;
		PackageFilter filter = default(PackageFilter);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				PackageFilter packageFilter = new PackageFilter();
				HJ5KwGfGE2m2NFuQGL1p(packageFilter, PackageLevel.All);
				WDPT0sfGfhFLEDcWS3dY(packageFilter, PackageStatus.Any);
				packageFilter.SearchString = uidStr;
				filter = packageFilter;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 2:
				return null;
			}
			List<PackageDescription> list = deployManager.FindPackages(filter);
			if (list == null)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return list.FirstOrDefault();
		}
	}

	internal static bool gPqyksfGhdYmLNTd8sSC()
	{
		return hEVpPafGb3RhePr2y60C == null;
	}

	internal static PackageLinkedFinder dPjwsKfGG7c3vNGBg84I()
	{
		return hEVpPafGb3RhePr2y60C;
	}

	internal static void HJ5KwGfGE2m2NFuQGL1p(object P_0, PackageLevel value)
	{
		((PackageFilter)P_0).Level = value;
	}

	internal static void WDPT0sfGfhFLEDcWS3dY(object P_0, PackageStatus value)
	{
		((PackageFilter)P_0).Status = value;
	}
}
