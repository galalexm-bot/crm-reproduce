using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class DefaultFormSettingAttribute : Attribute
{
	private Guid uid;

	private string value;

	internal static DefaultFormSettingAttribute K31MR3oQNri6ZNa7MCLL;

	public Guid Uid => uid;

	public string Value => value;

	public DefaultFormSettingAttribute(string uid, string value)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				this.value = value;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.uid = new Guid(uid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static bool QdOhKpoQ3WQ6w3hCZlfI()
	{
		return K31MR3oQNri6ZNa7MCLL == null;
	}

	internal static DefaultFormSettingAttribute NqXy9RoQpIjTA5iJ4M5w()
	{
		return K31MR3oQNri6ZNa7MCLL;
	}
}
