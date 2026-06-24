using System.Collections.Generic;

namespace EleWise.TemplateGenerator.Adl.Tree;

public class BlockStatement : TreeItem
{
	public string Identifier { get; set; }

	public Expression Expression { get; set; }

	public CompositeTreeItem Content { get; set; }

	public BlockStatement()
	{
		Content = new CompositeTreeItem();
	}

	public override string ToString()
	{
		return "[Block(" + Identifier + ")]";
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		BlockStatement blockStatement = (BlockStatement)base.CreateCopy(parent);
		blockStatement.Identifier = Identifier;
		blockStatement.Expression = (Expression)Expression.CreateCopy(blockStatement);
		blockStatement.Content = (CompositeTreeItem)Content.CreateCopy(blockStatement);
		return blockStatement;
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
		if (Content != null)
		{
			yield return Content;
		}
	}
}
