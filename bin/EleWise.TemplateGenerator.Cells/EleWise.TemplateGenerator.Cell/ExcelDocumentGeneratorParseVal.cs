using System;
using EleWise.TemplateGenerator.Cells.Internal;

namespace EleWise.TemplateGenerator.Cells;

public class ExcelDocumentGeneratorParseValueException : Exception
{
	public int Row { get; private set; }

	public int Col { get; private set; }

	public Type CellType { get; private set; }

	public object Value { get; private set; }

	public override string Message => $"Parse cell value error (row: {Row}, column: {Col}, type: {CellType}, value: {Value})";

	internal ExcelDocumentGeneratorParseValueException(int row, int col, WorkbookWrapper.CellType cellType, object value, Exception innerException)
		: base(null, innerException)
	{
		Row = row;
		Col = col;
		switch (cellType)
		{
		case WorkbookWrapper.CellType.Decimal:
			CellType = typeof(decimal);
			break;
		case WorkbookWrapper.CellType.DateTime:
			CellType = typeof(DateTime);
			break;
		case WorkbookWrapper.CellType.String:
			CellType = typeof(string);
			break;
		default:
			CellType = typeof(object);
			break;
		}
		Value = value;
	}
}
