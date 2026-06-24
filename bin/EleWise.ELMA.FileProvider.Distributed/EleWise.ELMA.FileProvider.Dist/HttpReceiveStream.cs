using System;
using System.IO;
using System.Net;

namespace EleWise.ELMA.FileProvider.Distributed.IO;

internal class HttpReceiveStream : Stream
{
	private readonly Uri url;

	private long pos;

	private WebResponse webResponse;

	private Stream webStream;

	public override bool CanRead => true;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

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
			return pos;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public HttpReceiveStream(string url)
		: this(new Uri(url))
	{
	}

	public HttpReceiveStream(Uri url)
	{
		this.url = url;
		pos = 0L;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		httpWebRequest.Method = "GET";
		webResponse = httpWebRequest.GetResponse();
		webStream = webResponse.GetResponseStream();
	}

	public override void Flush()
	{
		throw new NotSupportedException();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (count == 0)
		{
			return 0;
		}
		int num = webStream.Read(buffer, offset, count);
		pos += num;
		return num;
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return webStream.BeginRead(buffer, offset, count, callback, state);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		int num = webStream.EndRead(asyncResult);
		pos += num;
		return num;
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
		throw new NotSupportedException();
	}

	public override void Close()
	{
		if (webStream != null)
		{
			webStream.Close();
			webStream = null;
		}
		if (webResponse != null)
		{
			webResponse.Close();
			webResponse = null;
		}
		base.Close();
	}
}
