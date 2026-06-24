using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[Description(typeof(__LogOutResponse_SR), "Description")]
[DataContract(Name = "Auth")]
public class LogOutResponse
{
	internal static LogOutResponse i6ieDmfNvhFst1jfhDKb;

	[Description(typeof(__LogOutResponse_SR), "Success")]
	[DataMember]
	public bool Success
	{
		[CompilerGenerated]
		get
		{
			return _003CSuccess_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CSuccess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LogOutResponse()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GESHJqfNuwxduGZcX391();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool V5OSjvfN8eX6IsCvUIm8()
	{
		return i6ieDmfNvhFst1jfhDKb == null;
	}

	internal static LogOutResponse uDh2CHfNZqwVqjHIF9Nd()
	{
		return i6ieDmfNvhFst1jfhDKb;
	}

	internal static void GESHJqfNuwxduGZcX391()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
