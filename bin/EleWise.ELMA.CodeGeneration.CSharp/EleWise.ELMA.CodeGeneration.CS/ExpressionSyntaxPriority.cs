namespace EleWise.ELMA.CodeGeneration.CSharp;

internal class ExpressionSyntaxPriority
{
	private string _generation;

	private int _priority;

	private int _asParent;

	public static ExpressionSyntaxPriority Assignment = new ExpressionSyntaxPriority(0);

	public static ExpressionSyntaxPriority SnippetExpression = new ExpressionSyntaxPriority(0);

	public static ExpressionSyntaxPriority TryCast = new ExpressionSyntaxPriority(10);

	public static ExpressionSyntaxPriority Default = new ExpressionSyntaxPriority(20);

	public static ExpressionSyntaxPriority LambdaExpression = new ExpressionSyntaxPriority(20, 0);

	public static ExpressionSyntaxPriority Coalesce = new ExpressionSyntaxPriority(0, 100);

	public static ExpressionSyntaxPriority LogicalOr = new ExpressionSyntaxPriority(" || ", 110);

	public static ExpressionSyntaxPriority LogicalAnd = new ExpressionSyntaxPriority(" && ", 115);

	public static ExpressionSyntaxPriority ValueEquals = new ExpressionSyntaxPriority(" == ", 120);

	public static ExpressionSyntaxPriority ValueNotEquals = new ExpressionSyntaxPriority(" != ", 120);

	public static ExpressionSyntaxPriority Add = new ExpressionSyntaxPriority(" + ", 130);

	public static ExpressionSyntaxPriority Subtract = new ExpressionSyntaxPriority(" - ", 130);

	public static ExpressionSyntaxPriority Multiply = new ExpressionSyntaxPriority(" * ", 140);

	public static ExpressionSyntaxPriority Divide = new ExpressionSyntaxPriority(" / ", 140);

	public static ExpressionSyntaxPriority Cast = new ExpressionSyntaxPriority(1000, 0);

	public static ExpressionSyntaxPriority Identifier = new ExpressionSyntaxPriority(2000);

	public static ExpressionSyntaxPriority MemberAccess = new ExpressionSyntaxPriority(2000);

	public static ExpressionSyntaxPriority ElementAccess = new ExpressionSyntaxPriority(2000, 0);

	public static ExpressionSyntaxPriority Invocation = new ExpressionSyntaxPriority(2000, 0);

	public static ExpressionSyntaxPriority ObjectCreation = new ExpressionSyntaxPriority(2000, 0);

	private ExpressionSyntaxPriority(int priority)
		: this(priority, priority)
	{
	}

	private ExpressionSyntaxPriority(int priority, int asParent)
		: this(null, priority)
	{
		_asParent = asParent;
	}

	private ExpressionSyntaxPriority(string generation, int priority)
	{
		_generation = generation;
		_priority = priority;
	}

	internal bool NeedBrackets(ExpressionSyntaxPriority parent)
	{
		return (parent?._asParent ?? 0) > _priority;
	}

	internal void Generate()
	{
		GenerationContext.Current.Write(_generation);
	}

	public override string ToString()
	{
		return $"{_generation} {_priority}";
	}
}
