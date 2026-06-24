using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public sealed class DiagrammerPoint : ICloneableObjectLiteral
{
	private int _003CX_003Ek__BackingField;

	private int _003CY_003Ek__BackingField;

	[Name("x")]
	public int X
	{
		get
		{
			return _003CX_003Ek__BackingField;
		}
		set
		{
			_003CX_003Ek__BackingField = value;
		}
	}

	[Name("y")]
	public int Y
	{
		get
		{
			return _003CY_003Ek__BackingField;
		}
		set
		{
			_003CY_003Ek__BackingField = value;
		}
	}

	public object Clone()
	{
		return new DiagrammerPoint
		{
			X = X,
			Y = Y
		};
	}
}
