using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.Calendar.ViewItems;

[Component]
public class CalendarViewItemToolboxGroup : IViewItemToolboxGroup
{
	public static readonly Guid UID = new Guid("{E4502471-AE15-4AD0-B209-4660895B1769}");

	public Guid GroupUid => UID;

	public Guid ParentGroupUid => Guid.Empty;

	public string Name => SR.T("Календарь");
}
