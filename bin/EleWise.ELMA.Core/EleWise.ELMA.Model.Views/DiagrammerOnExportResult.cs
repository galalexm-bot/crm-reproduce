using System.Collections.Generic;
using Bridge;

namespace EleWise.ELMA.Model.Views;

[ObjectLiteral]
public class DiagrammerOnExportResult
{
	private System.Collections.Generic.ICollection<string> _003CImages_003Ek__BackingField;

	private System.Collections.Generic.ICollection<int> _003CPageSplittingListX_003Ek__BackingField;

	private System.Collections.Generic.ICollection<int> _003CPageSplittingListY_003Ek__BackingField;

	public System.Collections.Generic.ICollection<string> Images
	{
		get
		{
			return _003CImages_003Ek__BackingField;
		}
		set
		{
			_003CImages_003Ek__BackingField = value;
		}
	}

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
