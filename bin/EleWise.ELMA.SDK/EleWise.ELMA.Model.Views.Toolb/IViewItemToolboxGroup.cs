using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Views.Toolbox;

[ExtensionPoint(ComponentType.All)]
public interface IViewItemToolboxGroup
{
	Guid GroupUid { get; }

	Guid ParentGroupUid { get; }

	string Name { get; }
}
