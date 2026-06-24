using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security.Mobile.API.Models;

[Serializable]
[DataContract(Name = "PermissionRequest")]
public class PermissionRequestModel
{
	[DataMember]
	[Description("SR.M('Идентификаторы сущностей (Long[])')")]
	public long[] EntityIds { get; set; }

	[DataMember]
	[Description("SR.M('Guid типа (Guid)')")]
	public Guid TypeUid { get; set; }

	[DataMember]
	[Description("SR.M('Идентификаторы пользователей (Long[])')")]
	public long[] UsersIds { get; set; }

	[DataMember]
	[Description("SR.M('Идентификаторы групп/пользователей с префиксом (String[])')")]
	public string[] PrefixedUsersIds { get; set; }

	[DataMember]
	[Description("SR.M('Guid привилегии (Guid)')")]
	public Guid Permission { get; set; }

	[DataMember]
	[Description("SR.M('Guid-ы привилегий по умолчанию (Guid[])')")]
	public Guid[] DefaultPermissions { get; set; }

	[DataMember]
	[Description("SR.M('Нужно ли замещение (Bool)')")]
	public bool NeedReplacement { get; set; }
}
