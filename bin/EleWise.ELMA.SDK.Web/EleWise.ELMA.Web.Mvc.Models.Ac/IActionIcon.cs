namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

public interface IActionIcon
{
	string IconUrl { get; }

	string IconCls { get; }

	bool Checked { get; }
}
