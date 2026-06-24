namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public class GridGroupResult
{
	public string Title { get; private set; }

	public object Key { get; private set; }

	public GridGroupResult(string title, object key)
	{
		Title = title;
		Key = key;
	}
}
