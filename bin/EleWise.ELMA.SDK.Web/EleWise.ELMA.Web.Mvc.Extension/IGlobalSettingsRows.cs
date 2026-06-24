using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Web.Mvc.Html.Forms;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IGlobalSettingsRows
{
	IEnumerable<IRowDriver> GetRowDrivers(Guid moduleGuid);

	GlobalSettingsSaveResult SaveSettings(Guid moduleGuid, ControllerContext context, GlobalSettingsBase settingsModel);
}
