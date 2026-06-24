using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.Words;
using EleWise.TemplateGenerator.Adl.Tree;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Words.Internal;

namespace EleWise.TemplateGenerator.Words;

public class WordDocumentGenerator : DocumentGeneratorBase
{
	private readonly Stream templateFileStream;

	private readonly string templateFileName;

	private readonly Document document;

	private Template template;

	private DocumentWrapper wrapper;

	public Template Template => template;

	public override ICollection<Exception> LastExceptions => null;

	public WordDocumentGenerator(string templateFileName, IGeneratorProvider provider = null)
		: base(provider)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		this.templateFileName = templateFileName;
		document = new Document(templateFileName);
		InitConstructor();
	}

	public WordDocumentGenerator(Stream templateFileStream, IGeneratorProvider provider = null)
		: base(provider)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		this.templateFileStream = templateFileStream;
		document = new Document(templateFileStream);
		InitConstructor();
	}

	public override void Generate(IGeneratorDataSource dataSource)
	{
		Build(template, dataSource);
	}

	public override IEnumerable<ValidateMessage> Validate(IGeneratorDataSource dataSourceType)
	{
		return Validate(template, dataSourceType);
	}

	protected override void PostProcessResult(GenerationContext context)
	{
		if (document != null && !string.IsNullOrWhiteSpace(templateFileName))
		{
			document.Save(templateFileName);
		}
	}

	protected override void BuildPlainText(PlainText plainText)
	{
	}

	protected override void BuildVariable(Variable variable)
	{
		FormatedValue value = base.Context.ExpressionEvaluator.Evaluate(variable);
		ReplaceToFormatedValue(variable, value);
	}

	protected override void BuildGlobalVariable(Globalvariable globalVariable)
	{
	}

	protected override void BuildExpressionStatement(ExpressionStatement statement)
	{
		FormatedValue value = base.Context.ExpressionEvaluator.Evaluate(statement.Expression);
		ReplaceToFormatedValue(statement, value);
	}

	protected virtual void ReplaceToStringValue(TreeItem item, string formattedValue)
	{
		bool num = wrapper.ReplaceText(item.Start, item.Stop, formattedValue);
		wrapper.RecalcRange();
		formattedValue = ((!num) ? formattedValue.Replace("\r\n", " ").Replace("\n", " ") : formattedValue.Replace("\r\n", "").Replace("\n", ""));
		int delta = ((!string.IsNullOrEmpty(formattedValue)) ? formattedValue.Length : 0) - (item.Stop - item.Start + 1);
		item.Root.RecalcRange(item.Stop, delta);
	}

	protected virtual void ReplaceToImage(TreeItem item, Image image, DrawingFormat format)
	{
		ShapeWrapper item2 = new ShapeWrapper(image, document, null, format);
		wrapper.ReplaceText(item.Start, item.Stop, "");
		wrapper.PasteDown(new List<NodeWrapper> { item2 }, item.Start);
		wrapper.RecalcRange();
		int delta = -(item.Stop - item.Start + 1);
		item.Root.RecalcRange(item.Stop, delta);
	}

	protected virtual void ReplaceToFormatedValue(TreeItem item, FormatedValue value)
	{
		DrawingFormat drawingFormat = ((value != null) ? (value.Format as DrawingFormat) : null);
		Image image = ((drawingFormat != null) ? base.Context.FormatProvider.GetImage(value) : null);
		if (image != null)
		{
			ReplaceToImage(item, image, drawingFormat);
			return;
		}
		string formattedValue = ((value != null) ? base.Context.FormatProvider.FormatValue(value) : string.Empty);
		ReplaceToStringValue(item, formattedValue);
	}

	protected override void BuildIfStatement(IfStatement statement)
	{
		FormatedValue formatedValue = base.Context.ExpressionEvaluator.Evaluate(statement.Condition);
		CompositeTreeItem compositeTreeItem = null;
		compositeTreeItem = ((formatedValue == null || !(formatedValue.Value is bool) || !(bool)formatedValue.Value) ? statement.FalseContent : statement.TrueContent);
		if (compositeTreeItem != null)
		{
			int start = statement.Start;
			int num = compositeTreeItem.Start - 1;
			int num2 = compositeTreeItem.Stop + 1;
			int stop = statement.Stop;
			wrapper.Cut(num2, stop);
			wrapper.RecalcRange();
			statement.Root.RecalcRange(num2, -(stop - num2 + 1));
			BuildItem(compositeTreeItem);
			wrapper.Cut(start, num);
			wrapper.RecalcRange();
			statement.Root.RecalcRange(start, -(num - start + 1));
		}
		else
		{
			wrapper.Cut(statement.Start, statement.Stop);
			wrapper.RecalcRange();
			statement.Root.RecalcRange(statement.Stop, -(statement.Stop - statement.Start + 1));
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
			for (int i = 0; i < blockInfo.Count; i++)
			{
				base.Context.DataSource.SetBlockIndex(block.Identifier, i);
				wrapper.CopyPaste(block.Content.Start, block.Content.Stop, block.Start);
				wrapper.RecalcRange();
				TreeItem treeItem = block.Content.CreateCopy(block.Parent);
				treeItem.RecalcRange(0, block.Start - block.Content.Start);
				block.Root.RecalcRange(block.Start, treeItem.Stop - treeItem.Start + 1);
				int index = ((CompositeTreeItem)block.Parent).Items.IndexOf(block);
				((CompositeTreeItem)block.Parent).Items.Insert(index, treeItem);
				BuildItem(treeItem);
			}
			wrapper.Cut(block.Start, block.Stop);
			wrapper.RecalcRange();
			block.Root.RecalcRange(block.Start, -(block.Stop - block.Start + 1));
		}
		finally
		{
			base.Context.DataSource.LeaveBlock(block.Identifier);
		}
	}

	private void InitConstructor()
	{
		wrapper = new DocumentWrapper(document);
		template = Parse(wrapper.FullText);
	}
}
