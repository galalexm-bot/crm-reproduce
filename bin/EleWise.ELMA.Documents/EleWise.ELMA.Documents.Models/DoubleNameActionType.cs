using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Documents.Models;

public enum DoubleNameActionType
{
	[DisplayName(typeof(__Resources_DragAndDropSettings), "P_DoubleNameUseFileName_DisplayName")]
	[Description(typeof(__Resources_DragAndDropSettings), "P_DoubleNameUseFileName_Description")]
	UseFileName,
	[DisplayName(typeof(__Resources_DragAndDropSettings), "P_DoubleNameAnotherName_DisplayName")]
	[Description(typeof(__Resources_DragAndDropSettings), "P_DoubleNameAnotherName_Description")]
	AnotherName,
	[DisplayName(typeof(__Resources_DragAndDropSettings), "P_DoubleNameExistDocument_DisplayName")]
	[Description(typeof(__Resources_DragAndDropSettings), "P_DoubleNameExistDocument_Description")]
	ExistDocument
}
