using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class OwnerPropertyUidAttribute : Attribute
{
	private Guid value;

	internal static OwnerPropertyUidAttribute M4fJnNo8UCCgtGFew2tZ;

	public Guid Value => value;

	public OwnerPropertyUidAttribute(string value)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		D9SVQPo8zrh7hBdHhGvK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.value = ((!IEJ5MYoZFhpI57DF5bPJ(value)) ? new Guid(value) : Guid.Empty);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void D9SVQPo8zrh7hBdHhGvK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IEJ5MYoZFhpI57DF5bPJ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool vb2kjio8svTUwIKc6KHZ()
	{
		return M4fJnNo8UCCgtGFew2tZ == null;
	}

	internal static OwnerPropertyUidAttribute nnEc6Ko8cRAJc4Habysv()
	{
		return M4fJnNo8UCCgtGFew2tZ;
	}
}
