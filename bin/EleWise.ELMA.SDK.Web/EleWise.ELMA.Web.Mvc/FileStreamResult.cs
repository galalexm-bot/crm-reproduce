using System;
using System.IO;
using System.Web;

namespace EleWise.ELMA.Web.Mvc;

public class FileStreamResult : FileResult
{
	private const int BufferSize = 4096;

	public Stream FileStream { get; private set; }

	public FileStreamResult(Stream fileStream, string contentType)
		: base(contentType)
	{
		if (fileStream == null)
		{
			throw new ArgumentNullException("fileStream");
		}
		FileStream = fileStream;
	}

	protected override void WriteFile(HttpResponseBase response)
	{
		Stream outputStream = response.OutputStream;
		using (FileStream)
		{
			byte[] buffer = new byte[4096];
			while (true)
			{
				int num = FileStream.Read(buffer, 0, 4096);
				if (num == 0)
				{
					break;
				}
				outputStream.Write(buffer, 0, num);
			}
		}
	}
}
