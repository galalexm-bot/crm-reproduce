using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public class DiagrammerSize : ICloneableObjectLiteral
{
	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	[Name("width")]
	public int Width
	{
		get
		{
			return _003CWidth_003Ek__BackingField;
		}
		set
		{
			_003CWidth_003Ek__BackingField = value;
		}
	}

	[Name("height")]
	public int Height
	{
		get
		{
			return _003CHeight_003Ek__BackingField;
		}
		set
		{
			_003CHeight_003Ek__BackingField = value;
		}
	}

	public object Clone()
	{
		return new DiagrammerSize
		{
			Width = Width,
			Height = Height
		};
	}
}
