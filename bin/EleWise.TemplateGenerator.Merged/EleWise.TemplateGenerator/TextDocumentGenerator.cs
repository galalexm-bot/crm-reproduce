using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EleWise.TemplateGenerator.Adl.Tree;
using EleWise.TemplateGenerator.DataSources;

namespace EleWise.TemplateGenerator;

public class TextDocumentGenerator : DocumentGeneratorBase
{
	private readonly Stream templateFileStream;

	private readonly string templateFileName;

	private readonly Template template;

	private StringBuilder output;

	public Template Template => template;

	public override ICollection<Exception> LastExceptions => null;

	public TextDocumentGenerator(string templateFileName, IGeneratorProvider provider = null)
		: base(provider)
	{
		this.templateFileName = templateFileName;
		string text = File.ReadAllText(templateFileName);
		template = Parse(text);
	}

	public TextDocumentGenerator(Stream templateFileStream, IGeneratorProvider provider = null)
		: base(provider)
	{
		this.templateFileStream = templateFileStream;
		string text = new StreamReader(templateFileStream).ReadToEnd();
		template = Parse(text);
	}

	public override void Generate(IGeneratorDataSource dataSource)
	{
		output = new StringBuilder();
		Build(template, dataSource);
	}

	public override IEnumerable<ValidateMessage> Validate(IGeneratorDataSource dataSourceType)
	{
		return Validate(template, dataSourceType);
	}

	protected override void PostProcessResult(GenerationContext context)
	{
		if (output != null && !string.IsNullOrEmpty(templateFileName))
		{
			File.WriteAllText(templateFileName, output.ToString());
		}
	}

	protected override void BuildPlainText(PlainText plainText)
	{
		output.Insert(0, plainText.Text);
	}

	protected override void BuildVariable(Variable variable)
	{
		FormatedValue value = base.Context.ExpressionEvaluator.Evaluate(variable);
		ReplaceToFormatedValue(variable, value);
	}

	protected override void BuildGlobalVariable(Globalvariable globalVariable)
	{
		FormatedValue value = base.Context.ExpressionEvaluator.Evaluate(globalVariable);
		ReplaceToFormatedValue(globalVariable, value);
	}

	protected override void BuildExpressionStatement(ExpressionStatement statement)
	{
		FormatedValue value = base.Context.ExpressionEvaluator.Evaluate(statement.Expression);
		ReplaceToFormatedValue(statement, value);
	}

	protected virtual void ReplaceToFormatedValue(TreeItem item, FormatedValue value)
	{
		string text = ((value != null) ? base.Context.FormatProvider.FormatValue(value) : string.Empty);
		if (text != null)
		{
			output.Insert(0, text);
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
