using System.Collections.Generic;

namespace EleWise.TemplateGenerator.Adl.Tree;

public class BinaryExpression : Expression
{
	public override int Start
	{
		get
		{
			return Operand1.Start;
		}
		set
		{
		}
	}

	public override int Stop
	{
		get
		{
			return Operand2.Stop;
		}
		set
		{
		}
	}

	public Expression Operand1 { get; set; }

	public BinaryOperator Operator { get; set; }

	public Expression Operand2 { get; set; }

	public override string ToString()
	{
		return "<" + Operator.ToString() + ">";
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		BinaryExpression binaryExpression = (BinaryExpression)base.CreateCopy(parent);
		binaryExpression.Operand1 = (Expression)Operand1.CreateCopy(binaryExpression);
		binaryExpression.Operator = Operator;
		binaryExpression.Operand2 = (Expression)Operand2.CreateCopy(binaryExpression);
		return binaryExpression;
	}

	public override IEnumerable<TreeItem> GetChildItems()
	{
		foreach (TreeItem childItem in base.GetChildItems())
		{
			yield return childItem;
		}
		if (Operand1 != null)
		{
			yield return Operand1;
		}
		if (Operand2 != null)
		{
			yield return Operand2;
		}
	}
}
