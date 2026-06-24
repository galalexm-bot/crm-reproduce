using System;
using EleWise.ELMA.BPM.Web.Common.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class LastObjectInfoPortletModel : LastObjectInfoViewModel
{
	public override string ModelId
	{
		get
		{
			if (PortletSettings == null || !(PortletSettings.InstanceId != Guid.Empty))
			{
				return base.ModelId;
			}
			return PortletSettings.InstanceId.ToString();
		}
	}

	public LastObjectPortletPersonalization PortletSettings { get; set; }
}
