using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.Tasks.ViewItems;

[Component(Order = 100)]
public class TasksViewItemToolboxGroup : IViewItemToolboxGroup
{
	public static readonly Guid UID = new Guid("{4D5F69FF-6F76-43F9-8047-8B69B0F39DB7}");

	public Guid GroupUid => UID;

	public Guid ParentGroupUid => Guid.Empty;

	public string Name => SR.T("Задачи");
}
