using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Common.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface ICheckAnyAttachmentService
{
	bool CheckAnyAttachments(Guid typeUid, IEntity entity);

	bool CheckAnyAttachmentsSpecified(Guid typeUid, IEntity entity);

	long GetCountAttachments(Guid typeUid, IEntity entity);

	bool CheckAnyFile(Guid typeUid, IEntity entity);
}
