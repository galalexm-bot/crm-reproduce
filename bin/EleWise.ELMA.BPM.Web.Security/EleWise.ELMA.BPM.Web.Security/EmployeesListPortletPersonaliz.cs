using System;
using System.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Security.Portlets;

[Serializable]
public class EmployeesListPortletPersonalization : PortletPersonalization
{
	private EmployeesBirthdaysOutputMode _birthdaySettings = EmployeesBirthdaysOutputMode.MonthAhead;

	private EmployeesEmployDateOutputMode _newEmployeeSettings = EmployeesEmployDateOutputMode.MonthBehind;

	[Personalization(PersonalizationScope.User)]
	[Category("Дни рождения")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_EmployeesListPortletPersonalization), "P_BirthdaySettings_DisplayName")]
	public EmployeesBirthdaysOutputMode BirthdaySettings
	{
		get
		{
			return _birthdaySettings;
		}
		set
		{
			_birthdaySettings = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[Category("Дни рождения")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_EmployeesListPortletPersonalization), "P_IsViewNotBirthdayData_DisplayName")]
	public bool IsViewNotBirthdayData { get; set; }

	[Personalization(PersonalizationScope.User)]
	[Category("Новые сотрудники")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_EmployeesListPortletPersonalization), "P_NewEmployeeSettings_DisplayName")]
	public EmployeesEmployDateOutputMode NewEmployeeSettings
	{
		get
		{
			return _newEmployeeSettings;
		}
		set
		{
			_newEmployeeSettings = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[Category("Новые сотрудники")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_EmployeesListPortletPersonalization), "P_IsViewNoNewEmployeeData_DisplayName")]
	public bool IsViewNoNewEmployeeData { get; set; }
}
