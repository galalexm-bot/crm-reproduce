using System.Collections.Generic;

namespace EleWise.TemplateGenerator.Adl.Tree;

public class ExpressionStatement : TreeItem
{
	public Expression Expression { get; set; }

	public override string ToString()
	{
		return "[ExpressionStatement]";
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		ExpressionStatement expressionStatement = (ExpressionStatement)base.CreateCopy(parent);
		expressionStatement.Expression = (Expression)Expression.CreateCopy(expressionStatement);
		return expressionStatement;
	}

	public override IEnumerable<TreeItem> GetChildItems()
	{
		foreach (TreeItem childItem in base.GetChildItems())
		{
			yield return childItem;
		}
		if (Expression != null)
		{
			yield return Expression;
		}
	}
}
