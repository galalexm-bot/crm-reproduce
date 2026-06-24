using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Bridge;
using EleWise.ELMA.Core.Model.Ranges;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Core.Helpers;

public static class StringParseHelper
{
	[ObjectLiteral]
	private class ParsedValue
	{
		private int _003CFirst_003Ek__BackingField;

		private RelativeDateTimeMeter _003CSecond_003Ek__BackingField;

		public int First
		{
			get
			{
				return _003CFirst_003Ek__BackingField;
			}
			set
			{
				_003CFirst_003Ek__BackingField = value;
			}
		}

		public RelativeDateTimeMeter Second
		{
			get
			{
				return _003CSecond_003Ek__BackingField;
			}
			set
			{
				_003CSecond_003Ek__BackingField = value;
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public RelativeDateTimeMeter minType;

		internal bool _003CGetDateTimeFromString_003Eb__3(ParsedValue v)
		{
			return v.Second == minType;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Match, int> _003C_003E9__0_0;

		public static Func<Match, ParsedValue> _003C_003E9__0_1;

		public static Func<ParsedValue, RelativeDateTimeMeter> _003C_003E9__0_2;

		public static Func<ParsedValue, bool> _003C_003E9__0_4;

		internal int _003CGetDateTimeFromString_003Eb__0_0(Match m)
		{
			return ((Capture)m).get_Value().get_Length();
		}

		internal ParsedValue _003CGetDateTimeFromString_003Eb__0_1(Match match)
		{
			return new ParsedValue
			{
				First = int.Parse(((Capture)match.get_Groups().get_Item(2)).get_Value()),
				Second = (RelativeDateTimeMeter)("чднмгhdwmy".IndexOf(((Capture)match.get_Groups().get_Item(6)).get_Value().get_Chars(0)) % 5)
			};
		}

		internal RelativeDateTimeMeter _003CGetDateTimeFromString_003Eb__0_2(ParsedValue v)
		{
			return v.Second;
		}

		internal bool _003CGetDateTimeFromString_003Eb__0_4(ParsedValue v)
		{
			return v.First != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public Regex regex;

		internal bool _003CPrepareDateMask_003Eb__0(string m)
		{
			return regex.IsMatch(m);
		}
	}

	public static bool GetDateTimeFromString(string str, bool isFrom, out System.DateTime? result, out string errorMessage)
	{
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unsupported input type for neg.
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		result = null;
		errorMessage = "";
		if (string.IsNullOrEmpty(str))
		{
			return false;
		}
		str = Regex.Replace(str, "\\s*", "").ToLower();
		if (string.IsNullOrEmpty(str))
		{
			errorMessage = SR.T("Передана пустая строка");
			return false;
		}
		MatchCollection val = Regex.Matches(str, string.Format("((([0])|([+-][1-9]([0-9])*))([{0}]))", (object)"чднмгhdwmy"));
		if (val.get_Count() < 1 || Enumerable.Cast<Match>((System.Collections.IEnumerable)val).Sum((Func<Match, int>)((Match m) => ((Capture)m).get_Value().get_Length())) != str.get_Length())
		{
			errorMessage = SR.T("Некорректный ввод");
			return false;
		}
		List<ParsedValue> val2 = Enumerable.Cast<Match>((System.Collections.IEnumerable)val).Select<ParsedValue>((Func<Match, ParsedValue>)((Match match) => new ParsedValue
		{
			First = int.Parse(((Capture)match.get_Groups().get_Item(2)).get_Value()),
			Second = (RelativeDateTimeMeter)("чднмгhdwmy".IndexOf(((Capture)match.get_Groups().get_Item(6)).get_Value().get_Chars(0)) % 5)
		})).ToList();
		if (!isFrom)
		{
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			CS_0024_003C_003E8__locals0.minType = Enumerable.Min<ParsedValue, RelativeDateTimeMeter>((System.Collections.Generic.IEnumerable<ParsedValue>)val2, (Func<ParsedValue, RelativeDateTimeMeter>)((ParsedValue v) => v.Second));
			Enumerable.First<ParsedValue>((System.Collections.Generic.IEnumerable<ParsedValue>)val2, (Func<ParsedValue, bool>)((ParsedValue v) => v.Second == CS_0024_003C_003E8__locals0.minType)).First++;
		}
		result = System.DateTime.get_Now();
		switch (val2.get_Item(0).Second)
		{
		case RelativeDateTimeMeter.Hour:
			result = result.get_Value().get_Date().AddHours((double)result.get_Value().get_Hour());
			break;
		case RelativeDateTimeMeter.Day:
			result = result.get_Value().get_Date();
			break;
		case RelativeDateTimeMeter.Week:
			result = result.get_Value().get_Date().AddDays((double)(-((result.get_Value().get_DayOfWeek() - 1 + 7) % 7)));
			break;
		case RelativeDateTimeMeter.Month:
			result = new System.DateTime(result.get_Value().get_Year(), result.get_Value().get_Month(), 1);
			break;
		case RelativeDateTimeMeter.Year:
			result = new System.DateTime(result.get_Value().get_Year(), 1, 1);
			break;
		}
		System.Collections.Generic.IEnumerator<ParsedValue> enumerator = Enumerable.Where<ParsedValue>((System.Collections.Generic.IEnumerable<ParsedValue>)val2, (Func<ParsedValue, bool>)((ParsedValue v) => v.First != 0)).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ParsedValue current = enumerator.get_Current();
				switch (current.Second)
				{
				case RelativeDateTimeMeter.Hour:
					result = result.get_Value().AddHours((double)current.First);
					break;
				case RelativeDateTimeMeter.Day:
					result = result.get_Value().AddDays((double)current.First);
					break;
				case RelativeDateTimeMeter.Week:
					result = result.get_Value().AddDays((double)(7 * current.First));
					break;
				case RelativeDateTimeMeter.Month:
					result = result.get_Value().AddMonths(current.First);
					break;
				case RelativeDateTimeMeter.Year:
					result = result.get_Value().AddYears(current.First);
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (!isFrom && result.get_Value().get_TimeOfDay() == TimeSpan.Zero)
		{
			result = result.get_Value().AddSeconds(-10.0);
		}
		return true;
	}

	public static string PrepareDateMask(string mask, string separator, string removeTemplate = null)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		string[] array = mask.Split(new string[1] { separator }, (StringSplitOptions)1);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].get_Length() == 1)
			{
				array[i] += array[i];
			}
		}
		if (!string.IsNullOrEmpty(removeTemplate))
		{
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
			CS_0024_003C_003E8__locals0.regex = new Regex(removeTemplate);
			array = Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)((string m) => CS_0024_003C_003E8__locals0.regex.IsMatch(m))).ToArray();
		}
		return string.Join(separator, array);
	}

	public static string GetJSMaskFromServer(string pattern)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		return Regex.Replace(Regex.Replace(pattern, "([Md]{3,4})|([a-zA-Z])", "($1$2)"), "\\([a-zA-Z]+\\)", new MatchEvaluator(EvaluateDateTimeMask));
	}

	public static string CreateSanitizedId(this string originalId)
	{
		return Regex.Replace(originalId, "[^A-Za-zА-Яа-я0-9:_-]", "_");
	}

	private static string EvaluateDateTimeMask(Match match)
	{
		int num = ((Capture)match).get_Value().get_Length() - 2;
		if (num != 1)
		{
			return "a".Repeat(num);
		}
		return "9";
	}
}
