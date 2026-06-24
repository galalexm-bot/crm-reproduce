using System;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class TableCellAlignmentAttribute : Attribute
{
	private LineAlignment value;

	private static TableCellAlignmentAttribute k9BOx1oZVrTrl653qKmA;

	public LineAlignment Value => value;

	public TableCellAlignmentAttribute(LineAlignment value)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DSgGEXoZRBqKUwimJgMR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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
				this.value = value;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void DSgGEXoZRBqKUwimJgMR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool MNIl9toZSnF8EsC1NSEb()
	{
		return k9BOx1oZVrTrl653qKmA == null;
	}

	internal static TableCellAlignmentAttribute S3gvXfoZiswBFAFGwxoG()
	{
		return k9BOx1oZVrTrl653qKmA;
	}
}
