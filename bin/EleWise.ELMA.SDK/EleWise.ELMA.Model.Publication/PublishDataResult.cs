using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities.EntityReferences;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Publication;

public sealed class PublishDataResult
{
	internal static PublishDataResult UDJX17oVXC8yhpQEv0eb;

	public IList<ReferenceOnEntity> PublishedData { get; }

	public IList<string> ErrorMessages { get; }

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return _003CIsSuccess_003Ek__BackingField;
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
					_003CIsSuccess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool NeedRestart
	{
		[CompilerGenerated]
		get
		{
			return _003CNeedRestart_003Ek__BackingField;
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
				case 1:
					_003CNeedRestart_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public PublishDataResult(IList<ReferenceOnEntity> publishData = null, IList<string> errorMessages = null)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		IList<ReferenceOnEntity> list2;
		if (publishData == null)
		{
			IList<ReferenceOnEntity> list = new List<ReferenceOnEntity>();
			list2 = list;
		}
		else
		{
			list2 = publishData;
		}
		PublishedData = list2;
		IList<string> list4;
		if (errorMessages == null)
		{
			IList<string> list3 = new List<string>();
			list4 = list3;
		}
		else
		{
			list4 = errorMessages;
		}
		ErrorMessages = list4;
	}

	internal static bool GHkeBKoVT85TrGqX1593()
	{
		return UDJX17oVXC8yhpQEv0eb == null;
	}

	internal static PublishDataResult vqKav6oVk6eIof3uk5uZ()
	{
		return UDJX17oVXC8yhpQEv0eb;
	}
}
