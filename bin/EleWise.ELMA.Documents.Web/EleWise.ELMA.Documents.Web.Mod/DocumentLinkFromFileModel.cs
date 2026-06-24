using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentLinkFromFileModel
{
	public IDocument Document { get; set; }

	[RequiredField]
	[DisplayName(typeof(__Resources_DocumentLinkFromFileModel), "P_Folder_DisplayName")]
	[DocumentFolderSettings(SelectOnlyCreate = true, CascadeMode = CascadeMode.SaveUpdate, FieldName = "Folder")]
	public IFolder Folder { get; set; }

	[RequiredField]
	[DisplayName(typeof(__Resources_DocumentLinkFromFileModel), "P_File_DisplayName")]
	public BinaryFile File { get; set; }

	[DisplayName(typeof(__Resources_DocumentLinkFromFileModel), "P_CopyPermissions_DisplayName")]
	public bool CopyPermissions { get; set; }

	public DocumentLinkFromFileModel()
	{
		CopyPermissions = true;
	}
}
