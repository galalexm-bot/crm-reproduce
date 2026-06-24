using System;
using System.IO;
using System.Reflection;

namespace EleWise.ELMA.CRM.Import.Web.Code;

public class ExcelManager
{
	public const string UID = "Excel.Application";

	private object oExcel;

	private object WorkBooks;

	private object WorkBook;

	private object WorkSheets;

	private object WorkSheet;

	private object Range;

	public ExcelManager()
	{
		oExcel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
	}

	public void OpenDocument(string name)
	{
		WorkBooks = oExcel.GetType().InvokeMember("Workbooks", BindingFlags.GetProperty, null, oExcel, null);
		WorkBook = WorkBooks.GetType().InvokeMember("Open", BindingFlags.InvokeMethod, null, WorkBooks, new object[2] { name, true });
		WorkSheets = WorkBook.GetType().InvokeMember("Worksheets", BindingFlags.GetProperty, null, WorkBook, null);
		WorkSheet = WorkSheets.GetType().InvokeMember("Item", BindingFlags.GetProperty, null, WorkSheets, new object[1] { 1 });
	}

	public void CloseDocument()
	{
		WorkBook.GetType().InvokeMember("Close", BindingFlags.InvokeMethod, null, WorkBook, new object[1] { true });
	}

	public void SaveDocument(string name)
	{
		if (File.Exists(name))
		{
			WorkBook.GetType().InvokeMember("Save", BindingFlags.InvokeMethod, null, WorkBook, null);
			return;
		}
		WorkBook.GetType().InvokeMember("SaveAs", BindingFlags.InvokeMethod, null, WorkBook, new object[1] { name });
	}

	public string GetValue(string range)
	{
		Range = WorkSheet.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, WorkSheet, new object[1] { range });
		return Range.GetType().InvokeMember("Value", BindingFlags.GetProperty, null, Range, null).ToString();
	}
}
