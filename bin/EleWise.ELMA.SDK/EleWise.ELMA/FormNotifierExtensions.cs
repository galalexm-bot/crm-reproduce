using System;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA;

public static class FormNotifierExtensions
{
	internal static FormNotifierExtensions sYbuCyQp9ZeQO0WcFDT;

	public static void Error(this IFormNotifier notifier, Exception exception)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0091
		int num = 5;
		int num2 = num;
		string message = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 5:
				if (exception is ElmaInvalidOperationException)
				{
					num2 = 4;
					continue;
				}
				goto case 1;
			default:
				NotifyFormOfError(notifier, message);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 3;
				}
				continue;
			case 3:
				return;
			case 1:
				obj = null;
				goto IL_009c;
			case 4:
				obj = exception.InnerException;
				goto IL_009c;
			case 2:
				{
					obj = exception;
					break;
				}
				IL_009c:
				if (obj == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			message = ((Exception)obj).Message;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static void NotifyFormOfError(object form, object errorMessage)
	{
		((IFormNotifier)form).Error((string)errorMessage);
	}

	internal static bool BEW54PQa4vmoOhlZySI()
	{
		return sYbuCyQp9ZeQO0WcFDT == null;
	}

	internal static FormNotifierExtensions zH6tBoQDe0cRRp87Gik()
	{
		return sYbuCyQp9ZeQO0WcFDT;
	}
}
