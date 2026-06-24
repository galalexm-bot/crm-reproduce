using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security.Mobile.API.Models;

[Serializable]
[DataContract]
public class EditableListItemItems
{
	[DataMember]
	[Description("SR.M('Guid-ы привилегий (String)')")]
	public string Data { get; set; }

	[DataMember]
	[Description("SR.M('Запись, содержащая GUID типа сущности, Идентификатор пользователя и Идентификатор сущности (String)')")]
	public string Value { get; set; }
}
