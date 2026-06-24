using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import;

[Serializable]
internal sealed class ContinuedImportState : IContinuedImportState
{
	internal static ContinuedImportState pVpDbTExbSa5ypmUlvXY;

	public List<IConfigImportSettings> SettingsList { get; }

	public long UserId { get; }

	public BPMAppFakeManifest[] Manifests { get; }

	public List<DeployLogMessage> LogMessages { get; }

	public int InitialSettingsCount { get; }

	IReadOnlyCollection<IConfigImportSettings> IContinuedImportState.SettingsList => SettingsList;

	public bool NeedToInstallPackages
	{
		[CompilerGenerated]
		get
		{
			return _003CNeedToInstallPackages_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CNeedToInstallPackages_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PackageInstallInfo PackageInstallInfo
	{
		[CompilerGenerated]
		get
		{
			return _003CPackageInstallInfo_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CPackageInstallInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ContinuedImportState(long? userId, IEnumerable<IConfigImportSettings> settingsList, BPMAppFakeManifest[] manifests)
	{
		SingletonReader.JJCZtPuTvSt();
		LogMessages = new List<DeployLogMessage>();
		base._002Ector();
		UserId = userId ?? 0;
		SettingsList = settingsList?.ToList() ?? new List<IConfigImportSettings>();
		Manifests = manifests;
		InitialSettingsCount = SettingsList.Count;
	}

	internal static bool bPf0yRExh69huOoP6LH0()
	{
		return pVpDbTExbSa5ypmUlvXY == null;
	}

	internal static ContinuedImportState sH1anpExG8cjlts6e83Q()
	{
		return pVpDbTExbSa5ypmUlvXY;
	}
}
