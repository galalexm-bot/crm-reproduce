using EleWise.TemplateGenerator.Adl.Tree;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Helpers;

namespace EleWise.TemplateGenerator;

public sealed class ValidateMessage
{
	public string PatternString { get; set; }

	public ValidateErrorType ErrorType { get; set; }

	public ValidateErrorPartType ValidateErrorPartType { get; set; }

	public int Start { get; set; }

	public int Stop { get; set; }

	public ValidateMessage(TreeItem treeItem, IGeneratorDataSource dataSource, int start, int stop)
	{
		Start = start;
		Stop = stop;
		if (treeItem is Variable variable)
		{
			string[] propertyNames = PropertyNamesHelper.GetPropertyNames(variable.Name);
			string text = ((propertyNames.Length != 0) ? propertyNames[0] : null);
			if (text != null && dataSource.GetBlockInfo(text) != null)
			{
				ErrorType = ValidateErrorType.VariableInBlock;
			}
			else
			{
				ErrorType = ValidateErrorType.Variable;
			}
			PatternString = variable.ToString();
		}
		else if (treeItem is BlockStatement blockStatement)
		{
			ErrorType = ValidateErrorType.Block;
			PatternString = blockStatement.Expression.ToString();
		}
		else
		{
			PatternString = treeItem.ToString();
		}
	}
}
