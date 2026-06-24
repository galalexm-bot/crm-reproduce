using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.CRM.ViewItems;

[Component(Order = 100)]
public class CRMViewItemToolboxGroup : IViewItemToolboxGroup
{
	public static readonly Guid UID = new Guid("{8CD2C773-2CAC-4060-A1A6-F80C2C336DA9}");

	public Guid GroupUid => UID;

	public Guid ParentGroupUid => Guid.Empty;

	public string Name => SR.T("Работа с клиентами");
}
