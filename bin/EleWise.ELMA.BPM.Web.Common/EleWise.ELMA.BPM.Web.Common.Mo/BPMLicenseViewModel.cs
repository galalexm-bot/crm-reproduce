using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class BPMLicenseViewModel
{
	public static BPMLicenseViewModel Current => ContextVars.GetOrAdd("BPMLicenseViewModel", () => new BPMLicenseViewModel());

	public ILicenseInfo MainLicenseInfo { get; set; }

	public string LicenseCountTitle { get; set; }

	public string LicenseCount { get; set; }

	public string UsedLicenseCount { get; set; }

	public bool IsConcurrent { get; set; }

	public string PrivilegeLicenseCountTitle { get; set; }

	public string PrivilegeLicenseCount { get; set; }

	public string UsedPrivilegeLicenseCount { get; set; }

	public IUserGroup PrivilegeAccessGroup { get; set; }

	public string RegistrationKey { get; set; }

	public string ActivationToken { get; set; }

	private BPMLicenseViewModel()
	{
		IModuleManager moduleManager = ComponentManager.Current.ModuleManager;
		if (moduleManager.MainApplication != null)
		{
			ILicensedUnit mainLicensedUnit = moduleManager.MainLicensedUnit;
			if (mainLicensedUnit != null)
			{
				RegistrationKey = ComponentManager.Current.LicenseManager.GetRegistrationKey(mainLicensedUnit);
				MainLicenseInfo = mainLicensedUnit.GetLicenseInfo();
			}
		}
		string text = ComponentManager.Current.LicenseManager.GetActivationToken();
		StringBuilder stringBuilder = new StringBuilder();
		while (text != null && text.Length > 0)
		{
			stringBuilder.AppendLine((text.Length > 40) ? text.Substring(0, 40) : text);
			text = ((text.Length > 40) ? text.Substring(40) : "");
		}
		ActivationToken = stringBuilder.ToString();
		IConcurrentLicenseInfo concurrentLicenseInfo = MainLicenseInfo as IConcurrentLicenseInfo;
		IWorkplaceLicenseInfo workplaceLicenseInfo = MainLicenseInfo as IWorkplaceLicenseInfo;
		IModule licModule = moduleManager.MainLicensedUnit as IModule;
		if (concurrentLicenseInfo != null && concurrentLicenseInfo.IsConcurrent && licModule != null)
		{
			IPrivilegeModuleAccessGroup privilegeModuleAccessGroup = ComponentManager.Current.GetExtensionPoints<IPrivilegeModuleAccessGroup>().FirstOrDefault((IPrivilegeModuleAccessGroup g) => g.ModuleUid == licModule.Uid);
			if (privilegeModuleAccessGroup != null)
			{
				PrivilegeAccessGroup = UserGroupManager.Instance.LoadOrNull(privilegeModuleAccessGroup.UserGroupUid);
			}
		}
		LicenseCountTitle = SR.T("Количество лицензий");
		if (workplaceLicenseInfo != null)
		{
			LicenseCount = (workplaceLicenseInfo.WorkplaceCount.HasValue ? workplaceLicenseInfo.WorkplaceCount.Value.ToString() : SR.T("Не ограничено"));
			UsedLicenseCount = workplaceLicenseInfo.UsedLicenseCount.ToString();
		}
		IsConcurrent = concurrentLicenseInfo?.IsConcurrent ?? false;
		if (IsConcurrent)
		{
			LicenseCountTitle = SR.T("Конкурентных лицензий");
			if (concurrentLicenseInfo.PrivilegeCount.HasValue && concurrentLicenseInfo.PrivilegeCount.Value != 0)
			{
				PrivilegeLicenseCountTitle = SR.T("Привилегированных лицензий");
				PrivilegeLicenseCount = concurrentLicenseInfo.PrivilegeCount.Value.ToString();
				UsedPrivilegeLicenseCount = concurrentLicenseInfo.UsedPrivilegeCount.ToString();
			}
		}
	}
}
