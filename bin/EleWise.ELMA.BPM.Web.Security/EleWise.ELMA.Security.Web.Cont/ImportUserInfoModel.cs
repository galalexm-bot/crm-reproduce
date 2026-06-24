using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.Security.Web.Controllers.Models;

public class ImportUserInfoModel
{
	private ExternalMembershipImportManager externalMembershipImportManager;

	public ExternalMembershipImportManager ExternalMembershipImportManager => externalMembershipImportManager ?? (externalMembershipImportManager = Locator.GetServiceNotNull<ExternalMembershipImportManager>());

	public string ProviderName { get; set; }

	public string SearchString { get; set; }

	public string NewSearchString { get; set; }

	public Guid AuthProviderGuid { get; set; }

	public List<ImportUserModel> ListData { get; set; }

	public EditableListModel Groups { get; set; }

	public long? LicenseCount { get; set; }

	public bool ImportInProgress => ExternalMembershipImportManager.CheckImportProgress(AuthProviderGuid);

	public ImportUserInfoModel()
	{
		SearchString = null;
		NewSearchString = null;
		AuthProviderGuid = Guid.Empty;
		ListData = new List<ImportUserModel>();
		ProviderName = string.Empty;
		Groups = new EditableListModel();
		Groups.Items = InterfaceActivator.Create<IEnumerable<EditableListItem>>();
		ILicensedUnit mainLicensedUnit = ComponentManager.Current.ModuleManager.MainLicensedUnit;
		if (mainLicensedUnit != null)
		{
			ILicenseInfo licenseInfo = mainLicensedUnit.GetLicenseInfo();
			IConcurrentLicenseInfo concurrentLicenseInfo = licenseInfo as IConcurrentLicenseInfo;
			IWorkplaceLicenseInfo workplaceLicenseInfo = licenseInfo as IWorkplaceLicenseInfo;
			LicenseCount = (((concurrentLicenseInfo == null || !concurrentLicenseInfo.IsConcurrent) && workplaceLicenseInfo.WorkplaceCount.HasValue) ? new long?((long)workplaceLicenseInfo.WorkplaceCount.Value - (long)workplaceLicenseInfo.UsedLicenseCount) : null);
		}
	}
}
