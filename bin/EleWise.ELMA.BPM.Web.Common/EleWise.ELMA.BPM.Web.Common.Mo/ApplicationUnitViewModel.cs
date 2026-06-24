using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ApplicationUnitViewModel
{
	public IApplicationUnit Unit { get; set; }

	public ILicensedUnit LicensedUnit { get; set; }

	public int Level { get; set; }

	public bool ShowStatus { get; set; }

	public bool IsConcurrent
	{
		get
		{
			if (LicensedUnit?.GetLicenseInfo() is IConcurrentLicenseInfo concurrentLicenseInfo)
			{
				return concurrentLicenseInfo.IsConcurrent;
			}
			return false;
		}
	}

	public string StatusText
	{
		get
		{
			ILicensedUnit licensedUnit = LicensedUnit;
			if (licensedUnit == null)
			{
				licensedUnit = Unit as ILicensedUnit;
			}
			ILicenseInfo licenseInfo = licensedUnit?.GetLicenseInfo();
			string result = "";
			IModule module = Unit as IModule;
			if (licenseInfo != null)
			{
				LicenseStatus licenseStatus = licenseInfo.Status;
				if (licenseStatus == LicenseStatus.Activated && !IsEnabled)
				{
					licenseStatus = LicenseStatus.NotActivated;
				}
				result = licenseInfo.ToString();
				switch (licenseStatus)
				{
				case LicenseStatus.Activated:
					result = SR.T("Активирован");
					if (Unit != ComponentManager.Current.ModuleManager.MainApplication && licenseInfo is IWorkplaceLicenseInfo workplaceLicenseInfo)
					{
						if (workplaceLicenseInfo.WorkplaceCount.HasValue)
						{
							uint value = workplaceLicenseInfo.WorkplaceCount.Value;
							long num = (long)value - (long)workplaceLicenseInfo.UsedLicenseCount;
							result = SR.T("Активирован (лицензий: {0}; осталось: {1})", value, num);
						}
						else
						{
							result = SR.T("Активирован (лицензий: не ограничено)");
						}
					}
					break;
				case LicenseStatus.DateExpired:
					result = SR.T("Истек срок действия лицензии");
					break;
				case LicenseStatus.NeedRestart:
					result = SR.T("Требуется перезапуск сервера");
					break;
				case LicenseStatus.NotActivated:
					result = SR.T("Не активирован");
					break;
				}
			}
			else if (module != null)
			{
				result = ((module.Status == ModuleStatus.Enabled) ? SR.T("Включен") : ((module.Status == ModuleStatus.RestartRequired) ? SR.T("Требуется перезапуск сервера") : SR.T("Отключен")));
			}
			return result;
		}
	}

	public bool IsEnabled
	{
		get
		{
			if (Unit is IModule module)
			{
				return module.Status == ModuleStatus.Enabled;
			}
			return false;
		}
	}

	public ApplicationUnitViewModel(IApplicationUnit unit, int level, bool showStatus)
	{
		Unit = unit;
		Level = level;
		ShowStatus = showStatus;
	}

	public IUserGroup GetAccessUserGroup()
	{
		IModule module = Unit as IModule;
		if (module == null)
		{
			return null;
		}
		ILicensedModuleAccessGroup licensedModuleAccessGroup = ComponentManager.Current.GetExtensionPoints<ILicensedModuleAccessGroup>().FirstOrDefault((ILicensedModuleAccessGroup g) => g.ModuleUid == module.Uid);
		if (licensedModuleAccessGroup == null)
		{
			return null;
		}
		return UserGroupManager.Instance.LoadOrNull(licensedModuleAccessGroup.UserGroupUid);
	}
}
