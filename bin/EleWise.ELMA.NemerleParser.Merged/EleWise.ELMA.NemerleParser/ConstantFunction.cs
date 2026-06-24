using System.Collections.Generic;

namespace EleWise.ELMA.NemerleParser;

public class ConstantFunction : Constant
{
	public override int Stop
	{
		get
		{
			return (Parameters != null) ? Parameters.Stop : 0;
		}
		set
		{
		}
	}

	public string Name { get; set; }

	public ExpressionCollection Parameters { get; set; }

	public override IEnumerable<TreeItem> GetChildItems()
	{
		return Parameters.GetChildItems();
	}

	public override string ToString()
	{
		return Name;
	}
}
