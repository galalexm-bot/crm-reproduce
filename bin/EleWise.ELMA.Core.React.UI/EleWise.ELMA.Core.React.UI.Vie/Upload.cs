using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Models;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public class Upload
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CInputText_003Ek__BackingField;

		private string _003CDescriptionText_003Ek__BackingField;

		private UploadFile[] _003CFileList_003Ek__BackingField;

		private bool _003CMultiple_003Ek__BackingField;

		private UploadFile[] _003CDefaultFileList_003Ek__BackingField;

		private Action<UploadInfo> _003CCustomRequest_003Ek__BackingField;

		private Action<UploadChangeParam> _003COnChange_003Ek__BackingField;

		private Action<UploadFile> _003COnRemove_003Ek__BackingField;

		private Func<UploadFile, UploadFile[], bool> _003CBeforeUpload_003Ek__BackingField;

		private int _003CMaxFilesCount_003Ek__BackingField;

		private string _003CAccept_003Ek__BackingField;

		private Action<DataTransferItemList> _003CLoadScreenshot_003Ek__BackingField;

		private Action<ScreenshotModalInfo> _003COpenScreenshotModal_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		[Name("inputText")]
		public string InputText
		{
			get
			{
				return _003CInputText_003Ek__BackingField;
			}
			set
			{
				_003CInputText_003Ek__BackingField = value;
			}
		}

		[Name("descriptionText")]
		public string DescriptionText
		{
			get
			{
				return _003CDescriptionText_003Ek__BackingField;
			}
			set
			{
				_003CDescriptionText_003Ek__BackingField = value;
			}
		}

		[Name("fileList")]
		public UploadFile[] FileList
		{
			get
			{
				return _003CFileList_003Ek__BackingField;
			}
			set
			{
				_003CFileList_003Ek__BackingField = value;
			}
		}

		[Name("multiple")]
		public bool Multiple
		{
			get
			{
				return _003CMultiple_003Ek__BackingField;
			}
			set
			{
				_003CMultiple_003Ek__BackingField = value;
			}
		}

		[Name("defaultFileList")]
		public UploadFile[] DefaultFileList
		{
			get
			{
				return _003CDefaultFileList_003Ek__BackingField;
			}
			set
			{
				_003CDefaultFileList_003Ek__BackingField = value;
			}
		}

		[Name("customRequest")]
		public Action<UploadInfo> CustomRequest
		{
			get
			{
				return _003CCustomRequest_003Ek__BackingField;
			}
			set
			{
				_003CCustomRequest_003Ek__BackingField = value;
			}
		}

		[Name("onChange")]
		public Action<UploadChangeParam> OnChange
		{
			get
			{
				return _003COnChange_003Ek__BackingField;
			}
			set
			{
				_003COnChange_003Ek__BackingField = value;
			}
		}

		[Name("onRemove")]
		public Action<UploadFile> OnRemove
		{
			get
			{
				return _003COnRemove_003Ek__BackingField;
			}
			set
			{
				_003COnRemove_003Ek__BackingField = value;
			}
		}

		[Name("beforeUpload")]
		public Func<UploadFile, UploadFile[], bool> BeforeUpload
		{
			get
			{
				return _003CBeforeUpload_003Ek__BackingField;
			}
			set
			{
				_003CBeforeUpload_003Ek__BackingField = value;
			}
		}

		[Name("maxFilesCount")]
		public int MaxFilesCount
		{
			get
			{
				return _003CMaxFilesCount_003Ek__BackingField;
			}
			set
			{
				_003CMaxFilesCount_003Ek__BackingField = value;
			}
		}

		[Name("accept")]
		public string Accept
		{
			get
			{
				return _003CAccept_003Ek__BackingField;
			}
			set
			{
				_003CAccept_003Ek__BackingField = value;
			}
		}

		[Name("loadScreenshot")]
		public Action<DataTransferItemList> LoadScreenshot
		{
			get
			{
				return _003CLoadScreenshot_003Ek__BackingField;
			}
			set
			{
				_003CLoadScreenshot_003Ek__BackingField = value;
			}
		}

		[Name("openScreenshotModal")]
		public Action<ScreenshotModalInfo> OpenScreenshotModal
		{
			get
			{
				return _003COpenScreenshotModal_003Ek__BackingField;
			}
			set
			{
				_003COpenScreenshotModal_003Ek__BackingField = value;
			}
		}

		[Name("disabled")]
		public bool Disabled
		{
			get
			{
				return _003CDisabled_003Ek__BackingField;
			}
			set
			{
				_003CDisabled_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	public class UploadFile
	{
		private string _003CUid_003Ek__BackingField;

		private int _003CSize_003Ek__BackingField;

		private string _003CName_003Ek__BackingField;

		private Guid _003CFileUid_003Ek__BackingField;

		private string _003CUrl_003Ek__BackingField;

		private string _003CStatus_003Ek__BackingField;

		private string _003CWebkitRelativePath_003Ek__BackingField;

		[Name("uid")]
		public string Uid
		{
			get
			{
				return _003CUid_003Ek__BackingField;
			}
			set
			{
				_003CUid_003Ek__BackingField = value;
			}
		}

		[Name("size")]
		public int Size
		{
			get
			{
				return _003CSize_003Ek__BackingField;
			}
			set
			{
				_003CSize_003Ek__BackingField = value;
			}
		}

		[Name("name")]
		public string Name
		{
			get
			{
				return _003CName_003Ek__BackingField;
			}
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		[Name("fileUid")]
		public Guid FileUid
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return _003CFileUid_003Ek__BackingField;
			}
			set
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				_003CFileUid_003Ek__BackingField = value;
			}
		}

		[Name("url")]
		public string Url
		{
			get
			{
				return _003CUrl_003Ek__BackingField;
			}
			set
			{
				_003CUrl_003Ek__BackingField = value;
			}
		}

		[Name("status")]
		public string Status
		{
			get
			{
				return _003CStatus_003Ek__BackingField;
			}
			set
			{
				_003CStatus_003Ek__BackingField = value;
			}
		}

		[Name("webkitRelativePath")]
		public string WebkitRelativePath
		{
			get
			{
				return _003CWebkitRelativePath_003Ek__BackingField;
			}
			set
			{
				_003CWebkitRelativePath_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	public class UploadInfo
	{
		private Action<UploadResponse> _003COnSuccess_003Ek__BackingField;

		private Action<string, UploadResponse> _003COnError_003Ek__BackingField;

		private UploadFile _003CFile_003Ek__BackingField;

		[Name("onSuccess")]
		public Action<UploadResponse> OnSuccess
		{
			get
			{
				return _003COnSuccess_003Ek__BackingField;
			}
			set
			{
				_003COnSuccess_003Ek__BackingField = value;
			}
		}

		[Name("onError")]
		public Action<string, UploadResponse> OnError
		{
			get
			{
				return _003COnError_003Ek__BackingField;
			}
			set
			{
				_003COnError_003Ek__BackingField = value;
			}
		}

		[Name("file")]
		public UploadFile File
		{
			get
			{
				return _003CFile_003Ek__BackingField;
			}
			set
			{
				_003CFile_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	public class ScreenshotModalInfo
	{
		private Action _003COnOpen_003Ek__BackingField;

		private Action _003COnClose_003Ek__BackingField;

		[Name("onOpen")]
		public Action OnOpen
		{
			get
			{
				return _003COnOpen_003Ek__BackingField;
			}
			set
			{
				_003COnOpen_003Ek__BackingField = value;
			}
		}

		[Name("onClose")]
		public Action OnClose
		{
			get
			{
				return _003COnClose_003Ek__BackingField;
			}
			set
			{
				_003COnClose_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	public class UploadChangeParam
	{
		private UploadFile[] _003CFileList_003Ek__BackingField;

		private UploadFile _003CFile_003Ek__BackingField;

		[Name("fileList")]
		public UploadFile[] FileList
		{
			get
			{
				return _003CFileList_003Ek__BackingField;
			}
			set
			{
				_003CFileList_003Ek__BackingField = value;
			}
		}

		[Name("file")]
		public UploadFile File
		{
			get
			{
				return _003CFile_003Ek__BackingField;
			}
			set
			{
				_003CFile_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Upload, {props}, {children})")]
	public extern Upload(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Upload source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Upload source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
