using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.FullTextSearch.Extensions;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Web.FullTextSearch.Components;

[Component]
public class DocumentFullTextSearchCheck : NeedFullTextSearchCheck
{
	public override void HasUserFields(IDocumentFilter filter, CheckFullTextSearchModel result)
	{
		if (filter != null)
		{
			if (filter.HierarchicalByFolder)
			{
				result.Errors.Add(SR.T("Включен иерархический поиск (с учетом подпапок)"));
			}
			if ((filter.ChangeAuthor != null && ((IEnumerable<IUser>)filter.ChangeAuthor).Any()) || (filter.ChangeDate != null && (filter.ChangeDate.FromValue.HasValue || filter.ChangeDate.ToValue.HasValue)) || (filter.CreationAuthor != null && ((IEnumerable<IUser>)filter.CreationAuthor).Any()) || (filter.CreationDate != null && (filter.CreationDate.FromValue.HasValue || filter.CreationDate.ToValue.HasValue)) || filter.DocumentType.HasValue || filter.Name != null || filter.Query != null || filter.Status != null || !(filter.Subtype == null) || (filter.Types != null && filter.Types.Count((ReferenceOnEntityType t) => t != null) != 0) || filter.TypeUid.HasValue || filter.NeedAnswer.HasValue)
			{
				result.Errors.Add(SR.T("Заполнены поля расширенного поиска карточки документа"));
			}
		}
	}
}
