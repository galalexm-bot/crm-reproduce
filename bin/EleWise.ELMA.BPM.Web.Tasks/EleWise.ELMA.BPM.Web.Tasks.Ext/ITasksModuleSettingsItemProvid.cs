using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ITasksModuleSettingsItemProvider
{
	IEnumerable<TasksModuleSettingsItem> GetItems(UrlHelper urlHelper);
}
