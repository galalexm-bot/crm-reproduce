using System;
using System.IO;
using System.Net;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.FileProvider.Distributed.IO;

internal class HttpSendStream : Stream
{
	private class UploadResponse
	{
		public bool Success { get; set; }

		public string Error { get; set; }
	}

	private const int BufferSize = 1048576;

	private readonly Uri url;

	private readonly Action<string> uploadInfoSetter;

	private int bufferStartPos;

	private byte[] buffer = new byte[1048576];

	private int currentBufferPos;

	private long? totalSize;

	private string fileUid;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => true;

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long Position
	{
		get
		{
			return bufferStartPos + currentBufferPos;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public string FileUid => fileUid;

	public HttpSendStream(Uri url, Action<string> uploadInfoSetter)
	{
		Contract.ArgumentNotNull(url, "url");
		this.url = url;
		this.uploadInfoSetter = uploadInfoSetter;
	}

	public override void Flush()
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (count == 0)
		{
			return;
		}
		int num = 0;
		int num2 = count;
		while (num2 > 0)
		{
			int num3 = Math.Min(num2, 1048576 - currentBufferPos);
			Array.Copy(buffer, offset + num, this.buffer, currentBufferPos, num3);
			currentBufferPos += num3;
			num2 -= num3;
			num += num3;
			if (currentBufferPos >= 1048576)
			{
				SendChunk(1048576);
				currentBufferPos = 0;
				bufferStartPos += 1048576;
			}
		}
	}

	public override void Close()
	{
		totalSize = Position;
		SendChunk(currentBufferPos);
		base.Close();
	}

	private void SendChunk(int count)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/octet-stream";
		httpWebRequest.ContentLength = count;
		string arg = (totalSize.HasValue ? totalSize.Value.ToString() : "*");
		int num = ((totalSize != 0) ? bufferStartPos : 0);
		long num2 = ((totalSize == 0) ? 0 : (Position - 1));
		string value = $"bytes {num}-{num2}/{arg}";
		httpWebRequest.Headers.Add(HttpRequestHeader.ContentRange, value);
		if (!fileUid.IsNullOrEmpty())
		{
			httpWebRequest.Headers["FileGuid"] = fileUid;
		}
		if (totalSize.HasValue && totalSize.Value == Position)
		{
			httpWebRequest.Headers["IsLastXhr"] = "true";
		}
		try
		{
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(buffer, 0, count);
			}
			using WebResponse webResponse = httpWebRequest.GetResponse();
			using Stream stream2 = webResponse.GetResponseStream();
			UploadResponse uploadResponse = JsonHelper.DeserializeResponse<UploadResponse>(stream2);
			if (!uploadResponse.Success)
			{
				throw new IOException(SR.T("При отправке контента произошла ошибка: {0}", uploadResponse.Error));
			}
			if (fileUid.IsNullOrEmpty())
			{
				fileUid = webResponse.Headers["FileGuid"];
				uploadInfoSetter(fileUid);
			}
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
			throw;
		}
	}
}
