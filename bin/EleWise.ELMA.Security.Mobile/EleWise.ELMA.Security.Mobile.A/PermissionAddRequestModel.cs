using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security.Mobile.API.Models;

[Serializable]
[DataContract]
public class PermissionAddRequestModel
{
	[DataMember]
	[Description("SR.M('Идентификаторы сущностей (Long[])')")]
	public long[] Ids { get; set; }

	[DataMember]
	[Description("SR.M('Тип сущностей (Guid)')")]
	public Guid Type { get; set; }

	[DataMember]
	[Description("SR.M('Массив записей о выбранных привилегиях для объекта и пользователя')")]
	public EditableListItemItems[] Items { get; set; }
}
