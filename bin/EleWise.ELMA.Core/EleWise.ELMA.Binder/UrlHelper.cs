using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Bridge;
using Bridge.Html5;

namespace EleWise.ELMA.Binder;

public static class UrlHelper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Match, string> _003C_003E9__3_0;

		public static Func<Match, string> _003C_003E9__3_1;

		internal string _003CGetParams_003Eb__3_0(Match m)
		{
			return ((Capture)m.get_Groups().get_Item(2)).get_Value();
		}

		internal string _003CGetParams_003Eb__3_1(Match m)
		{
			return ((Capture)m.get_Groups().get_Item(3)).get_Value();
		}
	}

	public static string GetCurrentUrl(string baseUrl)
	{
		return baseUrl + Window.Location.PathName + Window.Location.Search;
	}

	public static string[] GetCurrentHashes()
	{
		return ((System.Array)Window.Location.Hash.Split(new char[1] { '#' })).Slice(1) as string[];
	}

	public static Dictionary<string, string> ParseUrl(string url)
	{
		if (string.IsNullOrWhiteSpace(url))
		{
			return new Dictionary<string, string>();
		}
		return GetParams(url.Substring(url.IndexOf('?')));
	}

	public static Dictionary<string, string> GetParams(string uri)
	{
		uri = DecodeUri(uri);
		return Enumerable.Cast<Match>((System.Collections.IEnumerable)Regex.Matches(uri, "[\\?&](([^&=]+)=([^&=#]*))", (RegexOptions)0)).ToDictionary<string, string>((Func<Match, string>)((Match m) => ((Capture)m.get_Groups().get_Item(2)).get_Value()), (Func<Match, string>)((Match m) => ((Capture)m.get_Groups().get_Item(3)).get_Value()));
	}

	[Template("decodeURI({uri})")]
	public static extern string DecodeUri(string uri);

	[Template("encodeURI({uri})")]
	public static extern string EncodeUri(string uri);
}
