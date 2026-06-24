using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator;

public class NotificationGeneratorProvider : ElmaGeneratorProvider
{
	private NotificationTemplateBase notificationTemplate;

	private static NotificationGeneratorProvider kvyaWDHAAmklJm1p5tY;

	public NotificationGeneratorProvider(NotificationTemplateBase notificationTemplate = null)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qT0deJH0eyiN56lUfJr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.notificationTemplate = notificationTemplate;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override IGeneratorDataSource ConvertObjectToDataSource(object dataSourceObject)
	{
		return new ElmaObjectGeneratorDataSource(dataSourceObject);
	}

	public override IGeneratorFormatProvider CreateFormatProvider(GenerationContext context)
	{
		return new NotificationFormatProvider(context);
	}

	public override IGeneratorFunctionEvaluator CreateFunctionEvaluator(GenerationContext context)
	{
		return new NotificationFunctionEvaluator(context, notificationTemplate);
	}

	internal static void qT0deJH0eyiN56lUfJr()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool v8mwdiH7MJdTZjZ4On0()
	{
		return kvyaWDHAAmklJm1p5tY == null;
	}

	internal static NotificationGeneratorProvider wLdgABHxeOKjAPCHB2L()
	{
		return kvyaWDHAAmklJm1p5tY;
	}
}
