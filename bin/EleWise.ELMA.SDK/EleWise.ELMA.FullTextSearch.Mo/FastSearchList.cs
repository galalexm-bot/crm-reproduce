using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.FullTextSearch.Enum;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model;

public class FastSearchList
{
	private List<string> fields;

	private Dictionary<string, Weight> weights;

	internal static FastSearchList FbkukqGi0nK6lDEKEmMu;

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<string> Fields => fields.Where((string s) => !_003C_003Ec.EJWjQtvcbBZAXBxP6E9Z(s)).Distinct().ToList();

	public Dictionary<string, Weight> Weights => weights;

	public FastSearchList(string value, List<string> fields, Dictionary<string, Weight> weights)
	{
		SingletonReader.JJCZtPuTvSt();
		this.fields = new List<string>();
		this.weights = new Dictionary<string, Weight>();
		base._002Ector();
		Value = value;
		this.fields = fields;
		this.weights = weights;
	}

	internal static bool wSTvKmGimG6YHjEpp51V()
	{
		return FbkukqGi0nK6lDEKEmMu == null;
	}

	internal static FastSearchList DWR8V2GiyYZdYapHf0lN()
	{
		return FbkukqGi0nK6lDEKEmMu;
	}
}
