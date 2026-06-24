using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public class UploadDirectory
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CInputText_003Ek__BackingField;

		private string _003CInputDescription_003Ek__BackingField;

		private Upload.UploadFile[] _003CFileList_003Ek__BackingField;

		private bool _003CMultiple_003Ek__BackingField;

		private Upload.UploadFile[] _003CDefaultFileList_003Ek__BackingField;

		private Action<Upload.UploadInfo> _003CCustomRequest_003Ek__BackingField;

		private Action<Upload.UploadChangeParam> _003COnChange_003Ek__BackingField;

		private Action<Upload.UploadFile> _003COnRemove_003Ek__BackingField;

		private Action<UploadFolder> _003COnLoadFile_003Ek__BackingField;

		private Func<Upload.UploadFile, Upload.UploadFile[], bool> _003CBeforeUpload_003Ek__BackingField;

		private int _003CMaxFilesCount_003Ek__BackingField;

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

		[Name("inputDescription")]
		public string InputDescription
		{
			get
			{
				return _003CInputDescription_003Ek__BackingField;
			}
			set
			{
				_003CInputDescription_003Ek__BackingField = value;
			}
		}

		[Name("fileList")]
		public Upload.UploadFile[] FileList
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
		public Upload.UploadFile[] DefaultFileList
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
		public Action<Upload.UploadInfo> CustomRequest
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
		public Action<Upload.UploadChangeParam> OnChange
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
		public Action<Upload.UploadFile> OnRemove
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

		[Name("onLoadFile")]
		public Action<UploadFolder> OnLoadFile
		{
			get
			{
				return _003COnLoadFile_003Ek__BackingField;
			}
			set
			{
				_003COnLoadFile_003Ek__BackingField = value;
			}
		}

		[Name("beforeUpload")]
		public Func<Upload.UploadFile, Upload.UploadFile[], bool> BeforeUpload
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
	public class UploadFolder
	{
		private string _003CName_003Ek__BackingField;

		private UploadFolder _003CFolder_003Ek__BackingField;

		private Upload.UploadFile _003CFile_003Ek__BackingField;

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

		[Name("folder")]
		public UploadFolder Folder
		{
			get
			{
				return _003CFolder_003Ek__BackingField;
			}
			set
			{
				_003CFolder_003Ek__BackingField = value;
			}
		}

		[Name("file")]
		public Upload.UploadFile File
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

	[Template("React.createElement(elmaComponents.UploadDirectory, {props}, {children})")]
	public extern UploadDirectory(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(UploadDirectory source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(UploadDirectory source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
