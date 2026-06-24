using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

public interface IActionItemList : IList<IActionItem>, ICollection<IActionItem>, IEnumerable<IActionItem>, IEnumerable
{
	object Attributes { get; }
}
