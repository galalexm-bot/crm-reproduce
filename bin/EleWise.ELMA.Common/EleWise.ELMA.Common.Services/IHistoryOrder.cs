using System.ComponentModel;

namespace EleWise.ELMA.Common.Services;

public interface IHistoryOrder
{
	ListSortDirection GetOrderType(IHistoryIdParams parameters);

	void SetOrderType(ListSortDirection direction, IHistoryIdParams parameters);
}
