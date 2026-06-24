using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using EleWise.TemplateGenerator.Adl;
using EleWise.TemplateGenerator.Adl.Tree;
using EleWise.TemplateGenerator.DataSources;

namespace EleWise.TemplateGenerator;

public abstract class GeneratorBase
{
	private GenerationContext context;

	public IGeneratorProvider Provider { get; set; }

	protected GenerationContext Context
	{
		get
		{
			return context;
		}
		set
		{
			context = value;
		}
	}

	public GeneratorBase(IGeneratorProvider provider = null)
	{
		Provider = provider ?? GlobalGeneratorSettings.DefaultProvider;
	}

	protected virtual Template Parse(string template)
	{
		if (Provider == null)
		{
			throw new NullReferenceException("Provider == null");
		}
		CommonTokenStream commonTokenStream = new CommonTokenStream(new AdlLexer(new ANTLRStringStream(template))
		{
			KeywordLocalizationStore = Provider.Localization.KeywordLocalizationStore
		});
		return new AdlWalker(new CommonTreeNodeStream(new AdlParser(commonTokenStream).template().Tree)
		{
			TokenStream = commonTokenStream
		}).template().Template;
	}

	protected virtual void Build(Template template, IGeneratorDataSource dataSource)
	{
		if (Provider == null)
		{
			throw new NullReferenceException("Provider == null");
		}
		if (template == null)
		{
			throw new NullReferenceException("template == null");
		}
		lock (this)
		{
			try
			{
				context = CreateGenerationContext(dataSource);
				if (Provider.TemplateTimeZoneOffset.HasValue)
				{
					context.ExtendedProperties["TemplateTimeZoneOffset"] = Provider.TemplateTimeZoneOffset;
				}
				BuildItem(template);
				PostProcessResult(context);
			}
			finally
			{
				context = null;
			}
		}
	}

	protected virtual IEnumerable<ValidateMessage> Validate(Template template, IGeneratorDataSource dataSourceType)
	{
		if (Provider == null)
		{
			throw new NullReferenceException("Provider == null");
		}
		if (template == null)
		{
			throw new NullReferenceException("template == null");
		}
		lock (this)
		{
			try
			{
				if (dataSourceType is ISupportGetPropertyMode supportGetPropertyMode)
				{
					supportGetPropertyMode.SetPropertyGetMode(GetPropertyMode.GetPropertyFromMetadata);
				}
				context = CreateGenerationContext(dataSourceType);
				if (Provider.TemplateTimeZoneOffset.HasValue)
				{
					context.ExtendedProperties["TemplateTimeZoneOffset"] = Provider.TemplateTimeZoneOffset;
				}
				return (from m in ValidateItem(template)
					orderby m.Start
					select m).ToArray();
			}
			finally
			{
				context = null;
			}
		}
	}

	protected virtual void PostProcessResult(GenerationContext context)
	{
	}

	protected virtual GenerationContext CreateGenerationContext(IGeneratorDataSource dataSource)
	{
		GenerationContext generationContext = new GenerationContext();
		generationContext.DataSource = dataSource;
		generationContext.GlobalDataSource = Provider.ConvertObjectToGlobalDataSource(dataSource);
		generationContext.Localization = Provider.Localization;
		generationContext.ExpressionEvaluator = Provider.CreateExpressionEvaluator(generationContext);
		generationContext.FunctionEvaluator = Provider.CreateFunctionEvaluator(generationContext);
		generationContext.FormatProvider = Provider.CreateFormatProvider(generationContext);
		return generationContext;
	}

	protected virtual IEnumerable<ValidateMessage> ValidateItem(TreeItem item)
	{
		List<ValidateMessage> list = new List<ValidateMessage>();
		if (item is Variable variable)
		{
			ValidateMessage validateMessage = ValidateVariable(variable);
			if (validateMessage != null)
			{
				list.Add(validateMessage);
			}
		}
		else if (item is BlockStatement block)
		{
			list.AddRange(ValidateBlockStatement(block));
		}
		else if (item is IfStatement statement)
		{
			list.AddRange(ValidateIfStatement(statement));
		}
		else if (item is ExpressionStatement expressionStatement && expressionStatement.Expression is FunctionCall function)
		{
			list.AddRange(ValidateFunction(function));
		}
		else if (item is CompositeTreeItem compositeTreeItem)
		{
			for (int num = compositeTreeItem.Items.Count - 1; num >= 0; num--)
			{
				list.AddRange(ValidateItem(compositeTreeItem.Items[num]));
			}
		}
		return list;
	}

	protected virtual void BuildItem(TreeItem item)
	{
		if (item is PlainText plainText)
		{
			BuildPlainText(plainText);
		}
		else if (item is Variable variable)
		{
			BuildVariable(variable);
		}
		else if (item is Globalvariable globalVariable)
		{
			BuildGlobalVariable(globalVariable);
		}
		else if (item is ExpressionStatement statement)
		{
			BuildExpressionStatement(statement);
		}
		else if (item is IfStatement statement2)
		{
			BuildIfStatement(statement2);
		}
		else if (item is BlockStatement block)
		{
			BuildBlockStatement(block);
		}
		else if (item is CompositeTreeItem compositeTreeItem)
		{
			for (int num = compositeTreeItem.Items.Count - 1; num >= 0; num--)
			{
				BuildItem(compositeTreeItem.Items[num]);
			}
		}
	}

	protected virtual ValidateMessage ValidateVariable(Variable variable)
	{
		if (Context.ExpressionEvaluator.Evaluate(variable) == null)
		{
			return new ValidateMessage(variable, Context.DataSource, variable.Start, variable.Stop);
		}
		return null;
	}

	protected virtual IEnumerable<ValidateMessage> ValidateBlockStatement(BlockStatement block)
	{
		FormatedValue formatedValue = Context.ExpressionEvaluator.Evaluate(block.Expression);
		if (formatedValue == null)
		{
			return new List<ValidateMessage>
			{
				new ValidateMessage(block, Context.DataSource, block.Start, block.Stop)
			};
		}
		try
		{
			Context.DataSource.EnterBlock(block.Identifier, formatedValue);
			return ValidateItem(block.Content);
		}
		finally
		{
			Context.DataSource.LeaveBlock(block.Identifier);
		}
	}

	protected virtual IEnumerable<ValidateMessage> ValidateIfStatement(IfStatement statement)
	{
		List<ValidateMessage> list = new List<ValidateMessage>();
		if (statement.Condition is BinaryExpression binaryExpression)
		{
			list.AddRange(ValidateOperand(binaryExpression.Operand1));
			list.AddRange(ValidateOperand(binaryExpression.Operand2));
		}
		list.AddRange(ValidateItem(statement.TrueContent));
		list.AddRange(ValidateItem(statement.FalseContent));
		return list;
	}

	protected virtual IEnumerable<ValidateMessage> ValidateFunction(FunctionCall function)
	{
		IEnumerable<Variable> enumerable = from x in function.Params.OfType<Variable>()
			where x != null
			select x;
		foreach (Variable item in enumerable)
		{
			ValidateMessage validateMessage = ValidateVariable(item);
			if (validateMessage != null)
			{
				yield return validateMessage;
			}
		}
	}

	protected abstract void BuildPlainText(PlainText plainText);

	protected abstract void BuildGlobalVariable(Globalvariable globalVariable);

	protected abstract void BuildVariable(Variable variable);

	protected abstract void BuildExpressionStatement(ExpressionStatement statement);

	protected abstract void BuildIfStatement(IfStatement statement);

	protected abstract void BuildBlockStatement(BlockStatement block);

	private IEnumerable<ValidateMessage> ValidateOperand(Expression operand)
	{
		if (operand is FunctionCall function)
		{
			foreach (ValidateMessage item in ValidateFunction(function))
			{
				yield return item;
			}
		}
		else if (Context.ExpressionEvaluator.Evaluate(operand) == null)
		{
			yield return new ValidateMessage(operand, Context.DataSource, operand.Start, operand.Stop);
		}
	}
}
