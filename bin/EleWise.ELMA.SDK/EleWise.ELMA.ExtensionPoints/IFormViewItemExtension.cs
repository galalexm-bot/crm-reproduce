using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IFormViewItemExtension
{
	bool Check(object entity);

	FormViewItem GetFormViewItem(Guid formUid, object entity, bool checkExists);
}
