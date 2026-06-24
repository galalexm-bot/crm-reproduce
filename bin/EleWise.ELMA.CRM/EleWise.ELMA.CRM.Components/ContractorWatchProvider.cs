using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Components;

[Component]
public class ContractorWatchProvider : BaseWatchProvider
{
	public override IEnumerable<Guid> TypeUid => from metadata in MetadataLoader.GetChildClasses((EntityMetadata)MetadataLoader.LoadMetadata(typeof(IContractor))).OfType<EntityMetadata>()
		select metadata.Uid;

	public override IEnumerable<Guid> ActionUids
	{
		get
		{
			yield return DefaultEntityActions.DeleteGuid;
			yield return ContractorActions.EditGuid;
			yield return DefaultEntityActions.UpdateGuid;
			yield return ContractorActions.AddCommentGuid;
			yield return ContractorActions.AddSlaveGuid;
			yield return ContractorActions.DelSlaveGuid;
		}
	}

	public override string WatchDescription => SR.T("Вы будете получать оповещения по всем изменениям в контрагенте \"{0}\"");

	public override string TextConfirmFromDelete(Guid entityTypeUid, object entityId)
	{
		return SR.T("Отписаться от оповещений об изменениях в контрагенте ?");
	}
}
