using System;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ISelectableGridProvider
{
	Guid Uid { get; }

	bool ShowCheckBox(SelectableGridCheckBoxModel model);
}
