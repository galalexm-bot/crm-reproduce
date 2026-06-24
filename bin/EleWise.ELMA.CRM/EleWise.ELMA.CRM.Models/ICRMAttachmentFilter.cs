using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ICRMAttachment))]
public interface ICRMAttachmentFilter : IEntityFilter
{
	[Uid("bd639c8e-c476-4571-8384-18baf2771355")]
	DateTimeRange CreationDate { get; set; }

	[Uid("3223a1a2-8a41-450b-83bc-52ac047220f1")]
	IUser CreationAuthor { get; set; }

	[Uid("5839b2bd-e84c-4182-a15a-50bf04b137c0")]
	IContractor Contractor { get; set; }

	[Uid("92e0417c-9ae9-48c3-9901-f300b8b969fc")]
	IContact Contact { get; set; }

	[Uid("42a18bed-4556-4fe3-ac95-310ef0e2f333")]
	ILead Lead { get; set; }

	[Uid("63e770cb-78da-436a-9c82-22b4bd425eee")]
	ISale Sale { get; set; }
}
