using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.Cells;
using EleWise.TemplateGenerator.Adl.Tree;
using EleWise.TemplateGenerator.Cells.Internal;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Formats;

namespace EleWise.TemplateGenerator.Cells;

public class ExcelDocumentGenerator : DocumentGeneratorBase
{
	private readonly Stream templateFileStream;

	private readonly string templateFileName;

	private readonly Workbook workbook;

	private readonly List<Template> templates = new List<Template>();

	private readonly List<string> texts = new List<string>();

	private WorkbookWrapper wrapper;

	private int currentSheet;

	private Template currentTemplate;

	private string inputText;

	private List<Exception> lastExceptions;

	private ExcelRunningTitleGenerator excelRunningTitleGenerator;

	public IEnumerable<Template> Templates => templates;

	public override ICollection<Exception> LastExceptions => lastExceptions;

	public ExcelDocumentGenerator(string templateFileName, IGeneratorProvider provider = null)
		: base(provider)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		this.templateFileName = templateFileName;
		workbook = new Workbook(templateFileName);
		InitConstructor();
	}

	public ExcelDocumentGenerator(Stream templateFileStream, IGeneratorProvider provider = null)
		: base(provider)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		this.templateFileStream = templateFileStream;
		workbook = new Workbook(templateFileStream);
		InitConstructor();
	}

	public override void Generate(IGeneratorDataSource dataSource)
	{
		lastExceptions = new List<Exception>();
		for (int i = 0; i < templates.Count; i++)
		{
			currentSheet = i;
			currentTemplate = templates[i];
			inputText = texts[i];
			Build(currentTemplate, dataSource);
		}
		excelRunningTitleGenerator.Generate(dataSource);
	}

	public override IEnumerable<ValidateMessage> Validate(IGeneratorDataSource dataSourceType)
	{
		lastExceptions = new List<Exception>();
		List<ValidateMessage> list = new List<ValidateMessage>();
		for (int i = 0; i < templates.Count; i++)
		{
			currentTemplate = templates[i];
			list.AddRange(Validate(currentTemplate, dataSourceType));
		}
		list.AddRange(excelRunningTitleGenerator.Validate(dataSourceType));
		return list;
	}

	protected override void PostProcessResult(GenerationContext context)
	{
		if (workbook != null && !string.IsNullOrWhiteSpace(templateFileName))
		{
			workbook.Save(templateFileName);
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
		ExcelCell colRow = GetColRow(item.Start);
		ExcelCell colRow2 = GetColRow(item.Stop);
		string cellText = wrapper.GetCellText(currentSheet, colRow.Col, colRow.Row);
		cellText = cellText.Remove(colRow.Pos, item.Stop - item.Start + 1);
		cellText = cellText.Insert(colRow.Pos, formattedValue);
		wrapper.SetCellText(currentSheet, colRow.Col, colRow.Row, cellText);
		ReplaceInputText(colRow.AbsolutePos, colRow2.AbsolutePos - colRow.AbsolutePos + 1, formattedValue);
		int delta = ((!string.IsNullOrEmpty(formattedValue)) ? formattedValue.Length : 0) - (item.Stop - item.Start + 1);
		item.Root.RecalcRange(item.Stop, delta);
	}

	protected virtual void ReplaceToImage(TreeItem item, Image image, DrawingFormat format)
	{
		ExcelCell colRow = GetColRow(item.Start);
		ExcelCell colRow2 = GetColRow(item.Stop);
		string cellText = wrapper.GetCellText(currentSheet, colRow.Col, colRow.Row);
		cellText = cellText.Remove(colRow.Pos, item.Stop - item.Start + 1);
		wrapper.SetCellText(currentSheet, colRow.Col, colRow.Row, cellText);
		wrapper.InsertImage(currentSheet, colRow.Col, colRow.Row, image, format);
		ReplaceInputText(colRow.AbsolutePos, colRow2.AbsolutePos - colRow.AbsolutePos + 1, "");
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
		string text = ((value != null) ? base.Context.FormatProvider.FormatValue(value) : string.Empty);
		ExcelCell colRow = GetColRow(item.Start);
		if (value != null && value.Value != null && colRow.Pos == 0 && wrapper.GetCellText(currentSheet, colRow.Col, colRow.Row).Length == item.Stop - item.Start + 1)
		{
			ExcelCell colRow2 = GetColRow(item.Stop);
			WorkbookWrapper.CellStyleInfo cellType = wrapper.GetCellType(currentSheet, colRow.Col, colRow.Row);
			bool flag = false;
			try
			{
				wrapper.SetCellValue(currentSheet, colRow.Col, colRow.Row, cellType.CellType, value.Value);
				flag = true;
			}
			catch (Exception innerException)
			{
				lastExceptions.Add(new ExcelDocumentGeneratorParseValueException(colRow.Row, colRow.Col, WorkbookWrapper.CellType.Decimal, text, innerException));
			}
			if (flag)
			{
				if (!cellType.IsTextFormat || cellType.CellType == WorkbookWrapper.CellType.Default)
				{
					wrapper.SetCellValueWithTypeConvert(currentSheet, colRow.Col, colRow.Row, text);
				}
				ReplaceInputText(colRow.AbsolutePos, colRow2.AbsolutePos - colRow.AbsolutePos + 1, text);
				int delta = ((!string.IsNullOrEmpty(text)) ? text.Length : 0) - (item.Stop - item.Start + 1);
				item.Root.RecalcRange(item.Stop, delta);
				return;
			}
		}
		ReplaceToStringValue(item, text);
	}

	protected override void BuildIfStatement(IfStatement statement)
	{
		FormatedValue formatedValue = base.Context.ExpressionEvaluator.Evaluate(statement.Condition);
		if (formatedValue != null && formatedValue.Value is bool && (bool)formatedValue.Value)
		{
			BuildItem(statement.TrueContent);
			ExcelCell colRow = GetColRow(statement.Start);
			ExcelCell colRow2 = GetColRow(statement.TrueContent.Start - 1);
			ExcelCell colRow3 = GetColRow(statement.TrueContent.Stop + 1);
			ExcelCell colRow4 = GetColRow(statement.Stop);
			if (colRow.Row == colRow4.Row)
			{
				int num = ClearRange(colRow3, colRow4);
				num += ClearRange(colRow, colRow2);
				statement.Root.RecalcRange(statement.Stop, -num);
				return;
			}
			int num2 = DeleteRows(colRow3.Row, colRow4.Row);
			if (colRow2.Row >= colRow3.Row)
			{
				colRow2.Row = colRow3.Row - 1;
			}
			if (colRow2.Row >= colRow.Row)
			{
				num2 += DeleteRows(colRow.Row, colRow2.Row);
			}
			statement.Root.RecalcRange(statement.Stop, -num2);
		}
		else if (statement.FalseContent != null)
		{
			BuildItem(statement.FalseContent);
			ExcelCell colRow5 = GetColRow(statement.Start);
			ExcelCell colRow6 = GetColRow(statement.FalseContent.Start - 1);
			ExcelCell colRow7 = GetColRow(statement.FalseContent.Stop + 1);
			ExcelCell colRow8 = GetColRow(statement.Stop);
			if (colRow5.Row == colRow8.Row)
			{
				int num3 = ClearRange(colRow7, colRow8);
				num3 += ClearRange(colRow5, colRow6);
				statement.Root.RecalcRange(statement.Stop, -num3);
				return;
			}
			int num4 = DeleteRows(colRow7.Row, colRow8.Row);
			if (colRow6.Row >= colRow7.Row)
			{
				colRow6.Row = colRow7.Row - 1;
			}
			if (colRow6.Row >= colRow5.Row)
			{
				num4 += DeleteRows(colRow5.Row, colRow6.Row);
			}
			statement.Root.RecalcRange(statement.Stop, -num4);
		}
		else
		{
			ExcelCell colRow9 = GetColRow(statement.Start);
			ExcelCell colRow10 = GetColRow(statement.Stop);
			if (colRow9.Row == colRow10.Row)
			{
				int num5 = ClearRange(colRow9, colRow10);
				statement.Root.RecalcRange(statement.Stop, -num5);
			}
			else
			{
				int num6 = DeleteRows(colRow9.Row, colRow10.Row);
				statement.Root.RecalcRange(statement.Stop, -num6);
			}
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
			ExcelCell colRow = GetColRow(block.Start);
			ExcelCell colRow2 = GetColRow(block.Stop);
			if (colRow.Col == colRow2.Col && colRow.Row == colRow2.Row)
			{
				throw new InvalidOperationException("Table statement is not supported in single cell of Excel document");
			}
			int num = colRow.Row + 1;
			int num2 = colRow2.Row - colRow.Row - 1;
			for (int i = 0; i < blockInfo.Count; i++)
			{
				base.Context.DataSource.SetBlockIndex(block.Identifier, i);
				TreeItem treeItem = block.Content.CreateCopy(null);
				int num3 = GetExcelCell(0, num).AbsolutePos - block.Content.Start;
				treeItem.RecalcRange(0, block.Start - block.Content.Start - num3);
				int delta = 0;
				CopyRows(num, num + num2 - 1, colRow.Row, ref delta);
				BuildItem(treeItem);
				int num4 = treeItem.Stop - treeItem.Start + 1;
				block.Root.RecalcRange(block.Start, num4 - num3);
				colRow = GetColRow(block.Start);
				colRow2 = GetColRow(block.Stop);
				num = colRow.Row + 1;
				num2 = colRow2.Row - colRow.Row - 1;
			}
			int num5 = DeleteRows(num - 1, num + num2);
			block.Root.RecalcRange(block.Start, -num5);
		}
		finally
		{
			base.Context.DataSource.LeaveBlock(block.Identifier);
		}
	}

	private void InitConstructor()
	{
		wrapper = new WorkbookWrapper(workbook);
		for (int i = 0; i < wrapper.GetSheetsCount(); i++)
		{
			string text = wrapper.ExtractText(i);
			texts.Add(text);
			Template item = Parse(text);
			templates.Add(item);
		}
		excelRunningTitleGenerator = ((templateFileStream != null) ? new ExcelRunningTitleGenerator(wrapper, workbook, templateFileStream) : new ExcelRunningTitleGenerator(wrapper, workbook, templateFileName));
	}

	private ExcelCell GetColRow(int pos)
	{
		ExcelCell result = default(ExcelCell);
		result.Row = 0;
		result.Col = 0;
		result.Pos = 0;
		result.AbsolutePos = 0;
		result.CellStartPos = 0;
		for (int i = 0; i < inputText.Length && i != pos; i++)
		{
			result.AbsolutePos++;
			switch (inputText[i])
			{
			case '\uffff':
				result.Row++;
				result.Col = 0;
				result.Pos = 0;
				result.CellStartPos = result.AbsolutePos;
				break;
			case '\ufffe':
				result.Col++;
				result.Pos = 0;
				result.CellStartPos = result.AbsolutePos;
				break;
			default:
				result.Pos++;
				break;
			}
		}
		return result;
	}

	private ExcelCell GetExcelCell(int col, int row)
	{
		ExcelCell result = default(ExcelCell);
		result.Row = 0;
		result.Col = 0;
		result.Pos = 0;
		result.AbsolutePos = 0;
		result.CellStartPos = 0;
		for (int i = 0; i < inputText.Length; i++)
		{
			if (col == result.Col && row == result.Row)
			{
				break;
			}
			result.AbsolutePos++;
			switch (inputText[i])
			{
			case '\uffff':
				result.Row++;
				result.Col = 0;
				result.Pos = 0;
				result.CellStartPos = result.AbsolutePos;
				break;
			case '\ufffe':
				result.Col++;
				result.Pos = 0;
				result.CellStartPos = result.AbsolutePos;
				break;
			default:
				result.Pos++;
				break;
			}
		}
		return result;
	}

	private void ReplaceInputText(int start, int lng, string text)
	{
		string text2 = "";
		if (start > 0)
		{
			text2 = inputText.Substring(0, start);
		}
		if (!string.IsNullOrEmpty(text))
		{
			text2 += text;
		}
		if (start + lng < inputText.Length)
		{
			text2 += inputText.Substring(start + lng);
		}
		inputText = text2;
	}

	private int ClearRange(ExcelCell cStart, ExcelCell cEnd)
	{
		int num = 0;
		int num2 = cStart.Col;
		int num3 = cStart.Row;
		int colsCount = wrapper.GetColsCount(currentSheet);
		while (num3 < cEnd.Row || (num3 == cEnd.Row && num2 <= cEnd.Col))
		{
			if (num2 == cStart.Col && num3 == cStart.Row && num2 == cEnd.Col && num3 == cEnd.Row)
			{
				string cellText = wrapper.GetCellText(currentSheet, cStart.Col, cStart.Row);
				int num4 = cEnd.Pos - cStart.Pos + 1;
				cellText = cellText.Remove(cStart.Pos, num4);
				ReplaceInputText(cStart.AbsolutePos, num4, "");
				num += num4;
				wrapper.SetCellText(currentSheet, cStart.Col, cStart.Row, cellText);
			}
			else if (num2 == cStart.Col && num3 == cStart.Row)
			{
				string cellText2 = wrapper.GetCellText(currentSheet, cStart.Col, cStart.Row);
				int num5 = cellText2.Length - cStart.Pos + 1;
				cellText2 = cellText2.Remove(cStart.Pos, num5);
				ReplaceInputText(cStart.AbsolutePos, num5, "");
				num += num5;
				wrapper.SetCellText(currentSheet, cStart.Col, cStart.Row, cellText2);
			}
			else if (num2 == cEnd.Col && num3 == cEnd.Row)
			{
				string cellText3 = wrapper.GetCellText(currentSheet, cStart.Col, cStart.Row);
				int pos = cEnd.Pos;
				cellText3 = cellText3.Remove(0, pos);
				ReplaceInputText(GetExcelCell(cEnd.Col, cEnd.Row).CellStartPos, pos, "");
				num += pos;
				wrapper.SetCellText(currentSheet, cEnd.Col, cEnd.Row, cellText3);
			}
			else
			{
				int length = wrapper.GetCellText(currentSheet, num2, num3).Length;
				wrapper.SetCellText(currentSheet, num2, num3, "");
				ReplaceInputText(GetExcelCell(num2, num3).CellStartPos, length, "");
				num += length;
			}
			num2++;
			if (num2 > colsCount)
			{
				num2 = 0;
				num3++;
			}
		}
		return num;
	}

	private int CopyRows(int startRow, int endRow, int rowToInsert, ref int delta)
	{
		ExcelCell excelCell = GetExcelCell(0, startRow);
		ExcelCell excelCell2 = GetExcelCell(0, endRow + 1);
		string text = inputText.Substring(excelCell.AbsolutePos, excelCell2.AbsolutePos - excelCell.AbsolutePos);
		int length = text.Length;
		ExcelCell excelCell3 = GetExcelCell(0, rowToInsert);
		ReplaceInputText(excelCell3.AbsolutePos, 0, text);
		delta = excelCell3.AbsolutePos - excelCell.AbsolutePos;
		wrapper.CopyRows(currentSheet, startRow, endRow, rowToInsert);
		return length;
	}

	private int DeleteRows(int startRow, int endRow)
	{
		ExcelCell excelCell = GetExcelCell(0, startRow);
		int num = GetExcelCell(0, endRow + 1).AbsolutePos - excelCell.AbsolutePos;
		ReplaceInputText(excelCell.AbsolutePos, num, "");
		wrapper.DeleteRows(currentSheet, startRow, endRow);
		return num;
	}
}
