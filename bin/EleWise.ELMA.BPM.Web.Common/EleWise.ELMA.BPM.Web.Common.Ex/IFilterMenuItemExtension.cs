using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterMenuItemExtension
{
	IEnumerable<FilterMenuItem> FilterMenuItems();
}
