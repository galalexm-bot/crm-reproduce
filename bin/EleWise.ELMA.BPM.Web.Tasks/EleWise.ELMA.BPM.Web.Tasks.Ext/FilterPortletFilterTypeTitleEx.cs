using System;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component(Order = 200)]
public class FilterPortletFilterTypeTitleExtensions : IFilterPortletFilterTypeTitle
{
	public bool AvailableType(Guid TypeUid)
	{
		return TypeUid == InterfaceActivator.UID<ITaskBase>();
	}

	public string GetTitle(Guid TypeUid, Guid? Code)
	{
		if (Code == TaskConstants.IncomingThreadCodeUid)
		{
			return SR.T("Задачи - Входящие");
		}
		if (Code == TaskConstants.OutgoingThreadCodeUid)
		{
			return SR.T("Задачи - Исходящие");
		}
		if (Code == TaskConstants.ExecutionControlThreadCodeUid)
		{
			return SR.T("Задачи - Контроль выполнения");
		}
		if (Code == TaskConstants.CurrentControlThreadCodeUid)
		{
			return SR.T("Задачи - Текущий контроль");
		}
		if (Code == TaskConstants.SearchThreadCodeUid)
		{
			return SR.T("Задачи - Поиск");
		}
		if (Code == TaskConstants.CoExecutionControlThreadCodeUid)
		{
			return SR.T("Задачи - Соисполнитель");
		}
		return SR.T("Задачи");
	}
}
