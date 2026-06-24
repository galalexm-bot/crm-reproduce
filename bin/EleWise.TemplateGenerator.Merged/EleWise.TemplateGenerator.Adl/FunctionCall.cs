using System.Collections.Generic;

namespace EleWise.TemplateGenerator.Adl.Tree;

public class FunctionCall : Expression
{
	public string Name { get; set; }

	public List<Expression> Params { get; set; }

	public FunctionCall()
	{
		Params = new List<Expression>();
	}

	public override string ToString()
	{
		return Name + "()";
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		FunctionCall functionCall = (FunctionCall)base.CreateCopy(parent);
		functionCall.Name = Name;
		foreach (Expression param in Params)
		{
			functionCall.Params.Add((Expression)param.CreateCopy(functionCall));
		}
		return functionCall;
	}

	public override IEnumerable<TreeItem> GetChildItems()
	{
		foreach (TreeItem childItem in base.GetChildItems())
		{
			yield return childItem;
		}
		foreach (Expression param in Params)
		{
			yield return param;
		}
	}
}
