using System.Text;

namespace EleWise.ELMA.Messaging.Email;

internal class EmailEncoding : Encoding
{
	private readonly Encoding en;

	public override string HeaderName => en.HeaderName;

	public override string BodyName => en.WebName;

	public override int CodePage => en.CodePage;

	public override string EncodingName => en.EncodingName;

	public override bool IsBrowserDisplay => en.IsBrowserDisplay;

	public override bool IsBrowserSave => en.IsBrowserSave;

	public override bool IsMailNewsDisplay => en.IsMailNewsDisplay;

	public override bool IsMailNewsSave => en.IsMailNewsSave;

	public override bool IsSingleByte => en.IsSingleByte;

	public override string WebName => en.WebName;

	public override int WindowsCodePage => en.WindowsCodePage;

	public new static Encoding GetEncoding(string name)
	{
		return GetEncoding(Encoding.GetEncoding(name));
	}

	public static Encoding GetEncoding(Encoding en)
	{
		if (en is ASCIIEncoding || en is UnicodeEncoding || en is UTF32Encoding || en is UTF7Encoding || en is UTF8Encoding)
		{
			return en;
		}
		return new EmailEncoding(en);
	}

	private EmailEncoding(Encoding en)
	{
		this.en = en;
	}

	public override int GetByteCount(char[] chars, int index, int count)
	{
		return en.GetByteCount(chars, index, count);
	}

	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return en.GetCharCount(bytes, index, count);
	}

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		return en.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
	}

	public override int GetMaxByteCount(int charCount)
	{
		return en.GetMaxByteCount(charCount);
	}

	public override int GetMaxCharCount(int byteCount)
	{
		return en.GetMaxCharCount(byteCount);
	}

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		return en.GetBytes(chars, charIndex, charCount, bytes, byteIndex);
	}

	public override byte[] GetBytes(string s)
	{
		return en.GetBytes(s);
	}

	public override int GetByteCount(char[] chars)
	{
		return en.GetByteCount(chars);
	}

	public override int GetByteCount(string s)
	{
		return en.GetByteCount(s);
	}

	public override byte[] GetBytes(char[] chars)
	{
		return en.GetBytes(chars);
	}

	public override byte[] GetBytes(char[] chars, int index, int count)
	{
		return en.GetBytes(chars, index, count);
	}

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		return en.GetBytes(s, charIndex, charCount, bytes, byteIndex);
	}

	public override int GetCharCount(byte[] bytes)
	{
		return en.GetCharCount(bytes);
	}

	public override char[] GetChars(byte[] bytes)
	{
		return en.GetChars(bytes);
	}

	public override char[] GetChars(byte[] bytes, int index, int count)
	{
		return en.GetChars(bytes, index, count);
	}

	public override Decoder GetDecoder()
	{
		return en.GetDecoder();
	}

	public override Encoder GetEncoder()
	{
		return en.GetEncoder();
	}

	public override byte[] GetPreamble()
	{
		return en.GetPreamble();
	}

	public override string GetString(byte[] bytes)
	{
		return en.GetString(bytes);
	}

	public override string GetString(byte[] bytes, int index, int count)
	{
		return en.GetString(bytes, index, count);
	}

	public override bool IsAlwaysNormalized(NormalizationForm form)
	{
		return en.IsAlwaysNormalized(form);
	}
}
