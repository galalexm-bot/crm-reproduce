using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Common.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface ICheckAnyAttachmentServiceExt : ICheckAnyAttachmentService
{
	bool CheckAnyTwoAndMoreAttachmentsFromProperty(Guid typeUid, long id, string nameProperty);
}
