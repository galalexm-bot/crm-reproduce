using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.Documents.ViewItems;

[Component(Order = 100)]
public class DocumentsViewItemToolboxGroup : IViewItemToolboxGroup
{
	public static readonly Guid UID = new Guid("{703050EE-1BC5-4386-984C-55BBC6CE57E7}");

	public Guid GroupUid => UID;

	public Guid ParentGroupUid => Guid.Empty;

	public string Name => SR.T("Документы");
}
