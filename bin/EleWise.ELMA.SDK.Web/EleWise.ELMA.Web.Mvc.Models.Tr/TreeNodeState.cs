using System;

namespace EleWise.ELMA.Web.Mvc.Models.Trees;

[Serializable]
public class TreeNodeState
{
	public string Id { get; set; }

	public bool Expanded { get; set; }
}
