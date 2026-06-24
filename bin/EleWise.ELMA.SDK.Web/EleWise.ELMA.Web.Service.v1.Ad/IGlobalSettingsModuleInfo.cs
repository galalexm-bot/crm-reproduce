using System;

namespace EleWise.ELMA.Web.Service.v1.AdministrationService.Models;

internal interface IGlobalSettingsModuleInfo
{
	Guid Uid { get; }

	string DisplayName { get; }
}
