using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

[ExtensionPoint]
public interface IViewItemToolboxGroup
{
	Guid GroupUid { get; }

	Guid ParentGroupUid { get; }

	string Name { get; }

	bool Visible { get; }
}
