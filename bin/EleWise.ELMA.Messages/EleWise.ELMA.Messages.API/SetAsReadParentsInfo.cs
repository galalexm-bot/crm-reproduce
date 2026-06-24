using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API;

[DataContract]
public class SetAsReadParentsInfo
{
	[DataMember]
	public string FirstBeforeHash;

	[DataMember]
	public string LastAfterHash;

	[DataMember]
	public int? Priority;
}
