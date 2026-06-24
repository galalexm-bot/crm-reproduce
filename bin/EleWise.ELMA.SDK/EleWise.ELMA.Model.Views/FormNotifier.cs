using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

internal class FormNotifier : IFormNotifier
{
	[Obsolete("Поле устарело, используйте mvcMessages")]
	private List<KeyValuePair<string, string>> messages;

	private List<KeyValuePair<string, MvcHtmlString>> mvcMessages;

	internal static FormNotifier RTa8ckoXUDtOI0mBfkKC;

	[Obsolete("Свойство устарело, используйте MvcMessages")]
	public List<KeyValuePair<string, string>> Messages => messages;

	public List<KeyValuePair<string, MvcHtmlString>> MvcMessages => mvcMessages;

	public FormNotifier()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BS80fDoXz6i1yAKdjrMm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				messages = new List<KeyValuePair<string, string>>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				mvcMessages = new List<KeyValuePair<string, MvcHtmlString>>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public void Information(string text)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108798308), (MvcHtmlString)hrLJ3foTFSPlRIjL5k6Q(text.HtmlEncode())));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Warning(string text)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string)pTIxr5oTBa244Tdnskso(-1939377524 ^ -1939526070), (MvcHtmlString)hrLJ3foTFSPlRIjL5k6Q(C7bNSToTWFSyem3tTyAk(text))));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Error(string text)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string)pTIxr5oTBa244Tdnskso(0x4EA5403C ^ 0x4EA71CE4), (MvcHtmlString)hrLJ3foTFSPlRIjL5k6Q(text.HtmlEncode())));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Information(MvcHtmlString text)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string)pTIxr5oTBa244Tdnskso(-978351861 ^ -978463321), text));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Warning(MvcHtmlString text)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string)pTIxr5oTBa244Tdnskso(-812025778 ^ -811916152), text));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Error(MvcHtmlString text)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				mvcMessages.Add(new KeyValuePair<string, MvcHtmlString>((string)pTIxr5oTBa244Tdnskso(--1333735954 ^ 0x4F7D6ECA), text));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void BS80fDoXz6i1yAKdjrMm()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool XfD8iKoXsdvvenConXLw()
	{
		return RTa8ckoXUDtOI0mBfkKC == null;
	}

	internal static FormNotifier s6j9vjoXcNBVHTQSp3j1()
	{
		return RTa8ckoXUDtOI0mBfkKC;
	}

	internal static object hrLJ3foTFSPlRIjL5k6Q(object P_0)
	{
		return MvcHtmlString.Create((string)P_0);
	}

	internal static object pTIxr5oTBa244Tdnskso(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object C7bNSToTWFSyem3tTyAk(object P_0)
	{
		return ((string)P_0).HtmlEncode();
	}
}
