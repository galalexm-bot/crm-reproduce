using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views.Toolbox;

[ExtensionPoint(ComponentType.All)]
public interface IViewItemToolboxItem
{
	string Name { get; }

	Guid GroupUid { get; }

	Image Image { get; }

	ViewItem CreateViewItem();

	bool IsAvailable(IMetadata metadata);
}
