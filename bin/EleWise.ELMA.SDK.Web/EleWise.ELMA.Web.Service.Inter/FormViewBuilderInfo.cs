using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class FormViewBuilderInfo
{
	[DataMember]
	public List<PropertyViewInfo> Properties { get; }

	[DataMember]
	public List<NotificationInfo> Notifications { get; }

	[DataMember]
	public bool ClosePopup { get; set; }

	public FormViewBuilderInfo()
	{
		Properties = new List<PropertyViewInfo>();
		Notifications = new List<NotificationInfo>();
	}
}
