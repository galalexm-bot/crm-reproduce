using Nevron.Dom;

namespace EleWise.ELMA.Diagrams;

public interface ISelectionProvider
{
	bool IsNodeSelected(INNode node);

	void SelectNode(INNode node);
}
