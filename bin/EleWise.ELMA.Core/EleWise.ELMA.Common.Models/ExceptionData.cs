using System;

namespace EleWise.ELMA.Common.Models;

public sealed class ExceptionData
{
	private int _003CExceptionCode_003Ek__BackingField;

	private string _003CMessage_003Ek__BackingField;

	private System.Exception _003COriginalException_003Ek__BackingField;

	public int ExceptionCode
	{
		get
		{
			return _003CExceptionCode_003Ek__BackingField;
		}
		set
		{
			_003CExceptionCode_003Ek__BackingField = value;
		}
	}

	public string Message
	{
		get
		{
			return _003CMessage_003Ek__BackingField;
		}
		set
		{
			_003CMessage_003Ek__BackingField = value;
		}
	}

	public System.Exception OriginalException
	{
		get
		{
			return _003COriginalException_003Ek__BackingField;
		}
		set
		{
			_003COriginalException_003Ek__BackingField = value;
		}
	}

	public ExceptionData()
	{
		ExceptionCode = 0;
		Message = "";
	}

	public ExceptionData(int id, string text)
	{
		ExceptionCode = id;
		Message = text;
	}

	public ExceptionData(int id, string text, System.Exception exception)
	{
		ExceptionCode = id;
		Message = text;
		OriginalException = exception;
	}
}
