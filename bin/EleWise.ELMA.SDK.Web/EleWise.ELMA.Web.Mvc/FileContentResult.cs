using System;
using System.Web;

namespace EleWise.ELMA.Web.Mvc;

public class FileContentResult : FileResult
{
	public byte[] FileContents { get; private set; }

	public FileContentResult(byte[] fileContents, string contentType)
		: base(contentType)
	{
		if (fileContents == null)
		{
			throw new ArgumentNullException("fileContents");
		}
		FileContents = fileContents;
	}

	protected override void WriteFile(HttpResponseBase response)
	{
		response.OutputStream.Write(FileContents, 0, FileContents.Length);
	}
}
