using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views;

public class DiagrammerOnPageResizeResult
{
	private System.Collections.Generic.ICollection<int> _003CPageSplittingListX_003Ek__BackingField;

	private System.Collections.Generic.ICollection<int> _003CPageSplittingListY_003Ek__BackingField;

	public System.Collections.Generic.ICollection<int> PageSplittingListX
	{
		get
		{
			return _003CPageSplittingListX_003Ek__BackingField;
		}
		set
		{
			_003CPageSplittingListX_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<int> PageSplittingListY
	{
		get
		{
			return _003CPageSplittingListY_003Ek__BackingField;
		}
		set
		{
			_003CPageSplittingListY_003Ek__BackingField = value;
		}
	}
}
