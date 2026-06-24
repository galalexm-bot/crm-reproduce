using Bridge;

namespace EleWise.ELMA.Model.Metadata;

[Module("Reactive")]
[External]
[ObjectLiteral]
public sealed class PropertyInfoExpression
{
	private string _003CObjectExpression_003Ek__BackingField;

	private string _003CExpressionForSerialize_003Ek__BackingField;

	[Name("name")]
	public string ObjectExpression
	{
		get
		{
			return _003CObjectExpression_003Ek__BackingField;
		}
		set
		{
			_003CObjectExpression_003Ek__BackingField = value;
		}
	}

	[Name("serializedName")]
	public string ExpressionForSerialize
	{
		get
		{
			return _003CExpressionForSerialize_003Ek__BackingField;
		}
		set
		{
			_003CExpressionForSerialize_003Ek__BackingField = value;
		}
	}
}
