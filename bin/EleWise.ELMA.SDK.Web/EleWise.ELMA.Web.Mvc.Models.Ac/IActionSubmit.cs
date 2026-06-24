namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

public interface IActionSubmit
{
	string ActionUrl { get; }

	string FormId { get; }

	bool IsMainAction { get; }

	bool IsAbortAction { get; }

	bool IsApproveAction { get; }
}
