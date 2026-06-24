using System.Collections.Generic;

namespace EleWise.TemplateGenerator.Adl.Tree;

public class UnaryExpression : Expression
{
	public Expression Operand { get; set; }

	public UnaryOperator Operator { get; set; }

	public override string ToString()
	{
		return "<U_" + Operator.ToString() + ">";
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		UnaryExpression unaryExpression = (UnaryExpression)base.CreateCopy(parent);
		unaryExpression.Operand = (Expression)Operand.CreateCopy(unaryExpression);
		unaryExpression.Operator = Operator;
		return unaryExpression;
	}

	public override IEnumerable<TreeItem> GetChildItems()
	{
		foreach (TreeItem childItem in base.GetChildItems())
		{
			yield return childItem;
		}
		if (Operand != null)
		{
			yield return Operand;
		}
	}
}
