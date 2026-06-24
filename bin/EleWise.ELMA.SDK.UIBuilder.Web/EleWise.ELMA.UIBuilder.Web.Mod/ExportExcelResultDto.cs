using System.Runtime.Serialization;

namespace EleWise.ELMA.UIBuilder.Web.Models;

[DataContract]
internal sealed class ExportExcelResultDto
{
	[DataMember]
	public string FileHref { get; set; }

	[DataMember]
	public bool Ready { get; set; }

	[DataMember]
	public string Error { get; set; }
}
