using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components;

[Component(Order = 50)]
public class DocumentWatchProvider : BaseWatchProvider
{
	public override IEnumerable<Guid> TypeUid => from documentMetadata in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
		select documentMetadata.Uid;

	public override IEnumerable<Guid> ActionUids
	{
		get
		{
			yield return DmsObjectActions.EditGuid;
			yield return DocumentActions.AddCommentGuid;
			yield return DocumentActions.AddQuestionGuid;
			yield return DocumentActions.ChangeStatusGuid;
			yield return DmsObjectActions.RenameGuid;
			yield return DmsObjectActions.MoveGuid;
			yield return DmsObjectActions.ArchiveGuid;
			yield return DmsObjectActions.UnArchiveGuid;
			yield return DefaultEntityActions.DeleteGuid;
			yield return DocumentActions.SendedGuid;
			yield return DocumentActions.ConvertedFromOtherTypeGuid;
		}
	}

	public override string GlobalWatchDescription => SR.T("Вы будете получать оповещения по всем изменениям документов с типом документа \"{0}\"");

	public override string WatchDescription => SR.T("Вы будете получать оповещения по всем изменениям документа \"{0}\"");

	public override bool CanSendToUser(IEntity entity, EleWise.ELMA.Security.Models.IUser user)
	{
		return Locator.GetServiceNotNull<ISecurityService>().HasPermission(user, PermissionProvider.DocumentViewPermission, entity.CastAsRealType());
	}
}
