using System.Linq;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Web.Mvc.Models.HttpHeaders;

public class RangeHttpHeader
{
	public class RangeItem
	{
		public bool IsValid { get; private set; }

		public long Start { get; private set; }

		public long End { get; private set; }

		public RangeItem(string rangeString)
		{
			string[] array = rangeString.Split('-');
			if (array.Length < 1)
			{
				IsValid = false;
				return;
			}
			long result;
			bool flag = long.TryParse(array[0], out result);
			long result2;
			bool flag2 = long.TryParse(array[1], out result2);
			if (!flag || !flag2)
			{
				IsValid = false;
				return;
			}
			IsValid = true;
			Start = result;
			End = result2;
		}

		public RangeItem(string rangeString, long fileLength)
		{
			string[] array = rangeString.Split('-');
			if (array.Length < 1)
			{
				IsValid = false;
				return;
			}
			string text = array[1];
			long result;
			if (string.IsNullOrWhiteSpace(text))
			{
				result = fileLength - 1;
			}
			else
			{
				if (!long.TryParse(text, out result))
				{
					IsValid = false;
					return;
				}
				if (result >= fileLength)
				{
					result = fileLength - 1;
				}
			}
			long result2;
			if (string.IsNullOrWhiteSpace(array[0]))
			{
				result2 = fileLength - 1 - result;
				result = fileLength - 1;
			}
			else
			{
				if (!long.TryParse(array[0], out result2))
				{
					IsValid = false;
					return;
				}
				if (result2 >= fileLength)
				{
					IsValid = false;
					return;
				}
			}
			IsValid = true;
			Start = result2;
			End = result;
		}
	}

	public bool IsPresent { get; private set; }

	public bool IsValid { get; private set; }

	public string Units { get; private set; }

	public RangeItem[] Ranges { get; private set; }

	public RangeHttpHeader(string headerValue)
	{
		if (headerValue.IsNullOrWhiteSpace())
		{
			IsPresent = false;
			return;
		}
		IsPresent = true;
		string[] array = headerValue.Split("=,".ToCharArray());
		if (array.Length < 2)
		{
			IsValid = false;
			return;
		}
		Units = array[0];
		Ranges = (from x in array.Skip(1)
			select new RangeItem(x)).ToArray();
		IsValid = Ranges.All((RangeItem x) => x.IsValid);
	}

	public RangeHttpHeader(string headerValue, long fileLength)
	{
		if (headerValue.IsNullOrWhiteSpace())
		{
			IsPresent = false;
			return;
		}
		IsPresent = true;
		string[] array = headerValue.Split("=,".ToCharArray());
		if (array.Length < 2)
		{
			IsValid = false;
			return;
		}
		Units = array[0];
		Ranges = (from x in array.Skip(1)
			select new RangeItem(x, fileLength)).ToArray();
		IsValid = Ranges.All((RangeItem x) => x.IsValid);
	}
}
