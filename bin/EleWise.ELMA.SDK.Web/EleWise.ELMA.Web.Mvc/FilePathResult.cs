using System;
using System.Web;

namespace EleWise.ELMA.Web.Mvc;

public class FilePathResult : FileResult
{
	public string FileName { get; private set; }

	public FilePathResult(string fileName, string contentType)
		: base(contentType)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		FileName = fileName;
	}

	protected override void WriteFile(HttpResponseBase response)
	{
		response.TransmitFile(FileName);
	}
}
