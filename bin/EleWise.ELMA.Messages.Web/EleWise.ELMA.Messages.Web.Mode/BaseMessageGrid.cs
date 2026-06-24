using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class BaseMessageGrid : BaseGrid<IBaseMessage, IBaseMessageFilter>
{
	public BaseMessageGrid()
	{
		base.CheckBoxGrid = true;
		base.GridId = "BaseMessageGrid";
	}
}
