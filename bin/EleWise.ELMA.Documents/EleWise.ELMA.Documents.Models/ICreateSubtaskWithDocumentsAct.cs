using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Models;

[InterfaceExtension(typeof(ICreateSubtaskActionModel))]
public interface ICreateSubtaskWithDocumentsActionModel : ICreateSubtaskActionModel, IAutoImplement
{
	[DisplayName(typeof(__Resources_ICreateSubtaskWithDocumentsActionModel), "P_CopyDocuments_DisplayName")]
	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskDefaultFieldCheck(typeof(CreateSubtaskDocumentsActionHandler), "IsDefaultValueDocument")]
	[SubtaskFieldType(CreateSubtaskSettingTypes.CopySetting)]
	bool CopyDocuments { get; set; }
}
