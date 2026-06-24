using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentMetadataProfileInfo : EntityModel<IDocumentMetadataProfile>
{
	public PermissionRoleTypeSelectorModel CreateDocumentRoleTypeSelectorModel { get; set; }

	public IEnumerable<AssignedRoleTypeModel> CreateDocumentRoleTypeModels { get; set; }

	public PermissionRoleTypeSelectorModel WatchListRoleTypeSelectorModel { get; set; }

	public IEnumerable<AssignedRoleTypeModel> WatchListRoleTypeModels { get; set; }

	public PermissionRoleTypeSelectorModel SignListRoleTypeSelectorModel { get; set; }

	public IEnumerable<AssignedRoleTypeModel> SignListRoleTypeModels { get; set; }

	public DocumentHistoryProfileView DocumentHistory { get; set; }

	public DocumentActionsProfileView ActionsProfile { get; set; }

	[RequiredField]
	public IDocument SelectedDocument { get; set; }

	public IUser CurrentUser => Locator.GetService<IAuthenticationService>().GetCurrentUser<IUser>();

	public TemplatiesFullModel GetTemplates()
	{
		TemplatiesFullModel res = new TemplatiesFullModel();
		if (base.Entity == null)
		{
			return res;
		}
		((IEnumerable<IDocumentTemplate>)base.Entity.Templates).ToList().ForEach(delegate(IDocumentTemplate t)
		{
			if (t.File != null || t.Document != null)
			{
				res.Templates.Add(new SimpleTemplateModel
				{
					Name = ((t.TemplateType == DocumentTemplateType.Document) ? t.Document.Name : t.File.Name),
					FileId = ((t.File != null) ? t.File.Id : ""),
					DocumentId = ((t.Document != null) ? t.Document.Id : 0),
					TemplateType = t.TemplateType,
					TemplateId = t.Id,
					CreationDate = (t.CreationDate.HasValue ? t.CreationDate.Value.ToString("g") : ""),
					CreationUser = ((t.CreationAuthor != null) ? t.CreationAuthor.ToString() : "")
				});
			}
		});
		return res;
	}
}
