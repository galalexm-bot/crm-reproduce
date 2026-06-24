using System.Collections.Generic;

namespace EleWise.ELMA.NemerleParser;

public class ExpressionCollection : Expression
{
	private List<Expression> expressions = new List<Expression>();

	public override IEnumerable<TreeItem> GetChildItems()
	{
		return expressions;
	}

	public override string ToString()
	{
		return string.Join(", ", expressions);
	}

	public void Add(Expression expression)
	{
		expressions.Add(expression);
	}
}
