using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;

namespace Nemerle.Compiler;

public sealed class FileSource : ISource, ISupportRelocation
{
	private sealed class _N_closureOf__ctor_45730
	{
		internal bool _N_checkLastLineForLF_45735;

		internal _N_closureOf__ctor_45730()
		{
		}
	}

	private sealed class _N__N_lambda__45724__45740 : Function<bool>
	{
		[SpecialName]
		private _N_closureOf__ctor_45730 _N__ctor_closure_45744;

		public _N__N_lambda__45724__45740(_N_closureOf__ctor_45730 _N__ctor_closure_45744)
		{
			this._N__ctor_closure_45744 = _N__ctor_closure_45744;
		}

		[SpecialName]
		public sealed override bool apply()
		{
			return _N__ctor_closure_45744._N_checkLastLineForLF_45735;
		}
	}

	private sealed class _N_closureOf__ctor_45758
	{
		internal WarningOptions _N_warnings_45763;

		internal _N_closureOf__ctor_45758()
		{
		}
	}

	private sealed class _N__N_lambda__45752__45771 : Function<bool>
	{
		[SpecialName]
		private _N_closureOf__ctor_45758 _N__ctor_closure_45775;

		public _N__N_lambda__45752__45771(_N_closureOf__ctor_45758 _N__ctor_closure_45775)
		{
			this._N__ctor_closure_45775 = _N__ctor_closure_45775;
		}

		[SpecialName]
		public sealed override bool apply()
		{
			return _N__ctor_closure_45775._N_warnings_45763.IsEnabled(10002);
		}
	}

	private ISource _N_field__internalSource_embeded_in_InternalSource_3319;

	private readonly string _filePath;

	private readonly bool _checkDuplicatedFiles;

	private readonly Function<bool> _checkLastLineForLF;

	public int FileIndex => InternalSource.FileIndex;

	private ISource InternalSource
	{
		get
		{
			if (null == _N_field__internalSource_embeded_in_InternalSource_3319)
			{
				_N_field__internalSource_embeded_in_InternalSource_3319 = ReadFile(_filePath, _checkDuplicatedFiles, _checkLastLineForLF.apply());
			}
			return _N_field__internalSource_embeded_in_InternalSource_3319;
		}
	}

	public FileSource(string filePath, bool checkDuplicatedFiles, bool checkLastLineForLF)
	{
		_N_closureOf__ctor_45730 n__ctor_closure_ = new _N_closureOf__ctor_45730
		{
			_N_checkLastLineForLF_45735 = checkLastLineForLF
		};
		base._002Ector();
		if (filePath == null)
		{
			throw new ArgumentNullException("filePath", "The ``NotNull'' contract of parameter ``filePath'' has been violated. See ncc\\parsing\\Source.n:56:28:56:36: .");
		}
		_filePath = filePath;
		_checkDuplicatedFiles = checkDuplicatedFiles;
		Function<bool> function = (_checkLastLineForLF = new _N__N_lambda__45724__45740(n__ctor_closure_));
	}

	public FileSource(string filePath, WarningOptions warnings)
	{
		_N_closureOf__ctor_45758 n_closureOf__ctor_ = new _N_closureOf__ctor_45758
		{
			_N_warnings_45763 = warnings
		};
		base._002Ector();
		if (n_closureOf__ctor_._N_warnings_45763 == null)
		{
			throw new ArgumentNullException("warnings", "The ``NotNull'' contract of parameter ``warnings'' has been violated. See ncc\\parsing\\Source.n:63:57:63:65: .");
		}
		if (filePath == null)
		{
			throw new ArgumentNullException("filePath", "The ``NotNull'' contract of parameter ``filePath'' has been violated. See ncc\\parsing\\Source.n:63:28:63:36: .");
		}
		_filePath = filePath;
		_checkDuplicatedFiles = true;
		Function<bool> function = (_checkLastLineForLF = new _N__N_lambda__45752__45771(n_closureOf__ctor_));
	}

	public string GetText()
	{
		return InternalSource.GetText();
	}

	public static ISource ReadFile(string filePath, bool checkDuplicatedFiles, bool checkLastLineForLF)
	{
		//Discarded unreachable code: IL_0153
		if (filePath == null)
		{
			throw new ArgumentNullException("filePath", "The ``NotNull'' contract of parameter ``filePath'' has been violated. See ncc\\parsing\\Source.n:85:38:85:46: .");
		}
		try
		{
			FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			try
			{
				StreamReader streamReader = new StreamReader(fileStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: true, throwOnInvalidBytes: true));
				StringSource result;
				try
				{
					int fileIndex = ((!checkDuplicatedFiles) ? Location.GetFileIndex(filePath) : Location.AddFile(filePath));
					string text = streamReader.ReadToEnd();
					if (checkLastLineForLF)
					{
						fileStream.Seek(-1L, SeekOrigin.End);
						int num = fileStream.ReadByte();
						if (num < 0)
						{
							throw new LexerBase.Error("unexpected end of file");
						}
						char c = Convert.ToChar(num);
						if (c != '\n')
						{
							Message.Warning(new Location(fileIndex, 1, 1), "no new line at the end of the file");
						}
					}
					result = new StringSource(fileIndex, text);
				}
				finally
				{
					((IDisposable)streamReader)?.Dispose();
				}
				return result;
			}
			finally
			{
				((IDisposable)fileStream)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			Message.Error(new Location(filePath, 1, 1, 1, 1), "cannot open file `" + Convert.ToString(filePath) + "': " + Convert.ToString(ex.Message));
			throw new Recovery();
		}
	}

	[CompilerGenerated]
	internal void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			ISource n_field__internalSource_embeded_in_InternalSource_ = _N_field__internalSource_embeded_in_InternalSource_3319;
			if (n_field__internalSource_embeded_in_InternalSource_ != null)
			{
				((ISupportRelocation)n_field__internalSource_embeded_in_InternalSource_).RelocateImpl(_info);
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
