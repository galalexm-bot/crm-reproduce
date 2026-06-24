using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aspose.Cells;
using EleWise.TemplateGenerator.Adl.Tree;
using EleWise.TemplateGenerator.Cells.Internal;
using EleWise.TemplateGenerator.DataSources;

namespace EleWise.TemplateGenerator.Cells;

internal sealed class ExcelRunningTitleGenerator : GeneratorBase
{
	internal sealed class RunningTitleTemplates
	{
		public Template[] Headers { get; private set; }

		public Template[] Footers { get; private set; }

		public RunningTitleTemplates()
		{
			Headers = new Template[3];
			Footers = new Template[3];
		}
	}

	private readonly WorkbookWrapper wrapper;

	private readonly Workbook workbook;

	private readonly string templateFileName;

	private readonly Stream templateFileStream;

	private StringBuilder currentText;

	public IEnumerable<RunningTitleTemplates> RunningTitleTemplatesList { get; set; }

	public ExcelRunningTitleGenerator(WorkbookWrapper wrapper, Workbook workbook, string templateFileName)
	{
		this.wrapper = wrapper;
		this.workbook = workbook;
		this.templateFileName = templateFileName;
		InitConstructor();
	}

	public ExcelRunningTitleGenerator(WorkbookWrapper wrapper, Workbook workbook, Stream templateFileStream)
	{
		this.wrapper = wrapper;
		this.workbook = workbook;
		this.templateFileStream = templateFileStream;
		InitConstructor();
	}

	public void Generate(IGeneratorDataSource dataSource)
	{
		if (base.Provider == null)
		{
			throw new NullReferenceException("Provider == null");
		}
		lock (this)
		{
			try
			{
				base.Context = CreateGenerationContext(dataSource);
				currentText = new StringBuilder();
				if (base.Provider.TemplateTimeZoneOffset.HasValue)
				{
					base.Context.ExtendedProperties["TemplateTimeZoneOffset"] = base.Provider.TemplateTimeZoneOffset;
				}
				int num = 0;
				foreach (RunningTitleTemplates runningTitleTemplates in RunningTitleTemplatesList)
				{
					if (runningTitleTemplates == null)
					{
						continue;
					}
					for (int i = 0; i < 3; i++)
					{
						Template template = runningTitleTemplates.Headers[i];
						if (template != null)
						{
							currentText.Clear();
							BuildItem(template);
							wrapper.SetHeader(num, i, currentText.ToString());
						}
					}
					for (int j = 0; j < 3; j++)
					{
						Template template2 = runningTitleTemplates.Footers[j];
						if (template2 != null)
						{
							currentText.Clear();
							BuildItem(template2);
							wrapper.SetFooter(num, j, currentText.ToString());
						}
					}
					num++;
				}
				PostProcessResult(base.Context);
			}
			finally
			{
				currentText = null;
				base.Context = null;
			}
		}
	}

	public IEnumerable<ValidateMessage> Validate(IGeneratorDataSource dataSource)
	{
		if (base.Provider == null)
		{
			throw new NullReferenceException("Provider == null");
		}
		lock (this)
		{
			try
			{
				if (dataSource is ISupportGetPropertyMode supportGetPropertyMode)
				{
					supportGetPropertyMode.SetPropertyGetMode(GetPropertyMode.GetPropertyFromMetadata);
				}
				base.Context = CreateGenerationContext(dataSource);
				if (base.Provider.TemplateTimeZoneOffset.HasValue)
				{
					base.Context.ExtendedProperties["TemplateTimeZoneOffset"] = base.Provider.TemplateTimeZoneOffset;
				}
				List<ValidateMessage> list = new List<ValidateMessage>();
				foreach (RunningTitleTemplates runningTitleTemplates in RunningTitleTemplatesList)
				{
					if (runningTitleTemplates == null)
					{
						continue;
					}
					for (int i = 0; i < 3; i++)
					{
						Template template = runningTitleTemplates.Headers[i];
						if (template != null)
						{
							list.AddRange(ValidateItem(template));
						}
					}
					for (int j = 0; j < 3; j++)
					{
						Template template2 = runningTitleTemplates.Footers[j];
						if (template2 != null)
						{
							list.AddRange(ValidateItem(template2));
						}
					}
				}
				foreach (ValidateMessage item in list)
				{
					item.ValidateErrorPartType = ValidateErrorPartType.InRunningTitle;
				}
				return list;
			}
			finally
			{
				base.Context = null;
			}
		}
	}

	protected override void PostProcessResult(GenerationContext context)
	{
		if (workbook != null)
		{
			workbook.CalculateFormula();
			workbook.Save(templateFileName);
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

	protected override void BuildExpressionStatement(ExpressionStatement statement)
	{
		FormatedValue value = base.Context.ExpressionEvaluator.Evaluate(statement.Expression);
		ReplaceToFormatedValue(value);
	}

	protected override void BuildGlobalVariable(Globalvariable globalVariable)
	{
		FormatedValue value = base.Context.ExpressionEvaluator.Evaluate(globalVariable);
		ReplaceToFormatedValue(value);
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

	protected override void BuildPlainText(PlainText plainText)
	{
		currentText.Insert(0, plainText.Text);
	}

	protected override void BuildVariable(Variable variable)
	{
		FormatedValue value = base.Context.ExpressionEvaluator.Evaluate(variable);
		ReplaceToFormatedValue(value);
	}

	private void InitConstructor()
	{
		List<RunningTitleTemplates> list = new List<RunningTitleTemplates>();
		for (int i = 0; i < wrapper.GetSheetsCount(); i++)
		{
			WorkbookWrapper.RunningTitleTexts runningTitleTexts = wrapper.ExtractRunningTitleTexts(i);
			RunningTitleTemplates runningTitleTemplates = null;
			if (runningTitleTexts != null)
			{
				runningTitleTemplates = new RunningTitleTemplates();
				for (int j = 0; j < 3; j++)
				{
					string text = runningTitleTexts.Headers[j];
					if (text != null)
					{
						runningTitleTemplates.Headers[j] = Parse(text);
					}
					string text2 = runningTitleTexts.Footers[j];
					if (text2 != null)
					{
						runningTitleTemplates.Footers[j] = Parse(text2);
					}
				}
			}
			list.Add(runningTitleTemplates);
		}
		RunningTitleTemplatesList = list;
	}

	private void ReplaceToFormatedValue(FormatedValue value)
	{
		string text = ((value != null) ? base.Context.FormatProvider.FormatValue(value) : string.Empty);
		if (text != null)
		{
			currentText.Insert(0, text);
		}
	}
}
