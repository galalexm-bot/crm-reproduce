using System;
using System.Web.Mvc;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Portlets;

[Serializable]
public class WebDocumentPersonalization : PortletPersonalization
{
	[Personalization(PersonalizationScope.Shared)]
	[HiddenInput(DisplayValue = false)]
	public virtual long? DocumentId { get; set; }

	[Property("a3a41ae4-30e2-4c46-bba2-ee55efdc7b90", "07c1ed28-cf39-4c5e-a303-99a045c96558")]
	public virtual IWebDocument Document
	{
		get
		{
			if (DocumentId.HasValue)
			{
				return WebDocumentManager.Instance.LoadOrNull(DocumentId.Value);
			}
			return null;
		}
		set
		{
			if (value != null)
			{
				DocumentId = value.Id;
			}
			else
			{
				DocumentId = null;
			}
		}
	}
}
