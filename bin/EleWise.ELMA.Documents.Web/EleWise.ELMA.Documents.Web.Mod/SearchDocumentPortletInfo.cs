using System;
using EleWise.ELMA.Documents.Web.Portlets;

namespace EleWise.ELMA.Documents.Web.Models;

public class SearchDocumentPortletInfo : SearchDocumentInfo
{
	public SearchDocumentPersonalization Personalization { get; set; }

	public override string InfoId
	{
		get
		{
			if (Personalization == null || !(Personalization.InstanceId != Guid.Empty))
			{
				return base.InfoId;
			}
			return Personalization.InstanceId.ToString();
		}
	}
}
