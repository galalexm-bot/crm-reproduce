using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Extensions;

public class DocumentDefaultHomePagePortlet
{
	public IPortlet Portlet { get; private set; }

	public string Zone { get; private set; }

	public int Order { get; private set; }

	public PortletFrame Frame { get; private set; }

	public DocumentDefaultHomePagePortlet(IPortlet portlet, string zone, int order, PortletFrame frame)
	{
		Portlet = portlet;
		Zone = zone;
		Order = order;
		Frame = frame;
	}

	public static void UpdateSettings(PortletPersonalization personalization, bool isLastObjectPortlet = false)
	{
		if (!(personalization is LastObjectPortletPersonalization lastObjectPortletPersonalization))
		{
			return;
		}
		if (!isLastObjectPortlet)
		{
			if (!string.IsNullOrWhiteSpace(lastObjectPortletPersonalization.Version))
			{
				return;
			}
			lastObjectPortletPersonalization.Version = "LastObject";
			if (lastObjectPortletPersonalization.RestrictTypes || (lastObjectPortletPersonalization.ObjectTypes != null && lastObjectPortletPersonalization.ObjectTypes.Any()))
			{
				return;
			}
		}
		lastObjectPortletPersonalization.Version = "DocumentLastObject";
		lastObjectPortletPersonalization.RestrictTypes = true;
		lastObjectPortletPersonalization.ObjectTypes = new List<Guid> { InterfaceActivator.UID<IDocument>() };
	}
}
