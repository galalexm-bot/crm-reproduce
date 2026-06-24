using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

[ExtensionPoint]
public interface IViewItemToolboxItem
{
	string Name { get; }

	Guid Uid { get; }

	Guid GroupUid { get; }

	System.Type Type { get; }

	bool Visible { get; }

	string Icon { get; }

	ViewItem CreateViewItem();

	string GetSlotName(Guid uid);
}
