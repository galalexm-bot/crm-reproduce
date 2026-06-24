using System;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[Serializable]
public sealed class ContentAction
{
	public string TypeProviderId { get; set; }

	public string Id { get; set; }

	public string Name { get; set; }

	public string Category { get; set; }

	public int Order { get; set; }

	public string ActionType { get; set; }

	public string Image16 { get; set; }

	public string Image24 { get; set; }

	public string Image32 { get; set; }

	public string Href { get; set; }
}
