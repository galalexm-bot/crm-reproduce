using System;

namespace EleWise.ELMA.UI.Models;

public interface IPortletPersonalization
{
	Guid PortletUid { get; set; }

	Guid InstanceId { get; set; }

	string Name { get; set; }

	double? Width { get; set; }

	double? Height { get; set; }

	bool DenyMinimize { get; set; }

	string NameUrl { get; set; }

	string ImageUrl { get; set; }

	bool EnableAsyncLoading { get; set; }

	bool ShowAsyncUpdateButton { get; set; }
}
