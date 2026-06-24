using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Html;

public class ListModelBase<T>
{
	public string Name { get; set; }

	public IEnumerable<T> Items { get; set; }
}
