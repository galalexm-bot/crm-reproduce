using System.Collections.Generic;

namespace EleWise.TemplateGenerator.Adl.Tree;

public class IfStatement : TreeItem
{
	public Expression Condition { get; set; }

	public CompositeTreeItem TrueContent { get; set; }

	public CompositeTreeItem FalseContent { get; set; }

	public IfStatement()
	{
		TrueContent = new CompositeTreeItem();
	}

	public override string ToString()
	{
		return "[IF]";
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		IfStatement ifStatement = (IfStatement)base.CreateCopy(parent);
		ifStatement.Condition = (Expression)Condition.CreateCopy(ifStatement);
		ifStatement.TrueContent = (CompositeTreeItem)TrueContent.CreateCopy(ifStatement);
		if (FalseContent != null)
		{
			ifStatement.FalseContent = (CompositeTreeItem)FalseContent.CreateCopy(ifStatement);
		}
		return ifStatement;
	}

	public override IEnumerable<TreeItem> GetChildItems()
	{
		foreach (TreeItem childItem in base.GetChildItems())
		{
			yield return childItem;
		}
		if (Condition != null)
		{
			yield return Condition;
		}
		if (TrueContent != null)
		{
			yield return TrueContent;
		}
		if (FalseContent != null)
		{
			yield return FalseContent;
		}
	}
}
