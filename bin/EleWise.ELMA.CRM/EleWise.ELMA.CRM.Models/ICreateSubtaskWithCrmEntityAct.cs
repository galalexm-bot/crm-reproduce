using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.CRM.Models;

[InterfaceExtension(typeof(ICreateSubtaskActionModel))]
public interface ICreateSubtaskWithCrmEntityActionModel : ICreateSubtaskActionModel, IAutoImplement
{
	[DisplayName(typeof(ICreateSubtaskWithCrmEntityActionModel_SR), "CrmEntity")]
	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskDefaultFieldCheck(typeof(EleWise.ELMA.CRM.Components.CreateSubtaskActionHandler), "IsDefaultValueCrmEntity")]
	[SubtaskFieldType(CreateSubtaskSettingTypes.CopySetting)]
	bool CopyCrmEntity { get; set; }
}
internal static class ICreateSubtaskWithCrmEntityActionModel_SR
{
	public static string CrmEntity => SR.T("Кому (Работа с клиентами)");
}
