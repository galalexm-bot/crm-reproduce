using System;
using Bridge;

namespace EleWise.ELMA.Core.React.UI.Models;

public sealed class UploadResponse
{
	private bool _003CSuccess_003Ek__BackingField;

	private Guid _003CUid_003Ek__BackingField;

	private string _003CFileName_003Ek__BackingField;

	private string _003CFileHref_003Ek__BackingField;

	private int _003CFileSize_003Ek__BackingField;

	private bool _003CValidMaxSize_003Ek__BackingField;

	private bool _003CValidSizeZero_003Ek__BackingField;

	private int _003CMaxFileSizeMb_003Ek__BackingField;

	[Name("success")]
	public bool Success
	{
		get
		{
			return _003CSuccess_003Ek__BackingField;
		}
		set
		{
			_003CSuccess_003Ek__BackingField = value;
		}
	}

	[Name("uid")]
	public Guid Uid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CUid_003Ek__BackingField = value;
		}
	}

	[Name("fileName")]
	public string FileName
	{
		get
		{
			return _003CFileName_003Ek__BackingField;
		}
		set
		{
			_003CFileName_003Ek__BackingField = value;
		}
	}

	[Name("fileHref")]
	public string FileHref
	{
		get
		{
			return _003CFileHref_003Ek__BackingField;
		}
		set
		{
			_003CFileHref_003Ek__BackingField = value;
		}
	}

	[Name("fileSize")]
	public int FileSize
	{
		get
		{
			return _003CFileSize_003Ek__BackingField;
		}
		set
		{
			_003CFileSize_003Ek__BackingField = value;
		}
	}

	[Name("validMaxSize")]
	public bool ValidMaxSize
	{
		get
		{
			return _003CValidMaxSize_003Ek__BackingField;
		}
		set
		{
			_003CValidMaxSize_003Ek__BackingField = value;
		}
	}

	[Name("validSizeZero")]
	public bool ValidSizeZero
	{
		get
		{
			return _003CValidSizeZero_003Ek__BackingField;
		}
		set
		{
			_003CValidSizeZero_003Ek__BackingField = value;
		}
	}

	[Name("maxFileSizeMb")]
	public int MaxFileSizeMb
	{
		get
		{
			return _003CMaxFileSizeMb_003Ek__BackingField;
		}
		set
		{
			_003CMaxFileSizeMb_003Ek__BackingField = value;
		}
	}

	public UploadResponse()
	{
		ValidMaxSize = true;
		ValidSizeZero = true;
	}
}
