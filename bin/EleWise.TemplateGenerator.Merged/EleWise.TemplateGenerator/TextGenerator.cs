using System.Collections.Generic;
using System.Text;
using EleWise.TemplateGenerator.Adl.Tree;
using EleWise.TemplateGenerator.DataSources;

namespace EleWise.TemplateGenerator;

public class TextGenerator : GeneratorBase
{
	private Template template;

	private StringBuilder output;

	public Template Template => template;

	public TextGenerator(string template, IGeneratorProvider provider = null)
		: base(provider)
	{
		this.template = Parse(template);
	}

	public string Generate(object dataSourceObject)
	{
		return Generate(base.Provider.ConvertObjectToDataSource(dataSourceObject));
	}

	public string Generate(IGeneratorDataSource dataSource)
	{
		output = new StringBuilder();
		Build(template, dataSource);
		if (output == null)
		{
			return string.Empty;
		}
		return output.ToString();
	}

	public IEnumerable<ValidateMessage> Validate(object dataSourceType)
	{
		return Validate(template, base.Provider.ConvertObjectToDataSource(dataSourceType));
	}

	protected virtual StringBuilder PostProcessResult(GenerationContext context, StringBuilder result)
	{
		return result;
	}

	protected override void PostProcessResult(GenerationContext context)
	{
		output = PostProcessResult(context, output);
	}

	protected override void BuildPlainText(PlainText plainText)
	{
		output.Insert(0, plainText.Text);
	}

	protected override void BuildVariable(Variable variable)
	{
		FormatedValue formatedValue = base.Context.ExpressionEvaluator.Evaluate(variable);
		if (formatedValue != null)
		{
			output.Insert(0, base.Context.FormatProvider.FormatValue(formatedValue));
		}
	}

	protected override void BuildGlobalVariable(Globalvariable globalVariable)
	{
		FormatedValue formatedValue = base.Context.ExpressionEvaluator.Evaluate(globalVariable);
		if (formatedValue != null)
		{
			output.Insert(0, base.Context.FormatProvider.FormatValue(formatedValue));
		}
	}

	protected override void BuildExpressionStatement(ExpressionStatement statement)
	{
		FormatedValue formatedValue = base.Context.ExpressionEvaluator.Evaluate(statement.Expression);
		if (formatedValue != null)
		{
			output.Insert(0, base.Context.FormatProvider.FormatValue(formatedValue));
		}
	}

	protected override void BuildIfStatement(IfStatement statement)
	{
		FormatedValue formatedValue = base.Context.ExpressionEvaluator.Evaluate(statement.Condition);
		if (formatedValue != null && formatedValue.Value is bool && (bool)formatedValue.Value)
		{
			BuildItem(statement.TrueContent);
		}
		else if (statement.FalseContent != null)
		{
			BuildItem(statement.FalseContent);
		}
	}

	protected override void BuildBlockStatement(BlockStatement block)
	{
		FormatedValue value = base.Context.ExpressionEvaluator.Evaluate(block.Expression);
		BlockInfo blockInfo = base.Context.DataSource.EnterBlock(block.Identifier, value);
		if (blockInfo == null)
		{
			return;
		}
		try
		{
			for (int num = blockInfo.Count - 1; num >= 0; num--)
			{
				base.Context.DataSource.SetBlockIndex(block.Identifier, num);
				TreeItem item = block.Content.CreateCopy(null);
				BuildItem(item);
			}
		}
		finally
		{
			base.Context.DataSource.LeaveBlock(block.Identifier);
		}
	}
}
