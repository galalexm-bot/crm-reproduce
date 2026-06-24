using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Public;

[Serializable]
[DataContract]
public class PublicServiceException
{
	private int statusCode;

	internal static PublicServiceException HVGtNsBmhgO0XpOebAcZ;

	[DataMember]
	[XmlElement("StatusCode")]
	public int StatusCode
	{
		get
		{
			return statusCode;
		}
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
					statusCode = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
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

	[XmlElement("Message")]
	[DataMember]
	public string Message
	{
		[CompilerGenerated]
		get
		{
			return _003CMessage_003Ek__BackingField;
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
					_003CMessage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	[XmlElement("InnerException")]
	public PublicServiceException InnerException
	{
		[CompilerGenerated]
		get
		{
			return _003CInnerException_003Ek__BackingField;
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
					_003CInnerException_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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

	public static Exception CreateWebFault(string message, int statusCode = 200)
	{
		return new WebFaultException<PublicServiceException>(new PublicServiceException(message, statusCode), HttpStatusCode.BadRequest);
	}

	public static Exception CreateWebFault(string message, Exception innerException, int statusCode = 200)
	{
		return new WebFaultException<PublicServiceException>(new PublicServiceException(message, statusCode, innerException), HttpStatusCode.BadRequest);
	}

	public PublicServiceException()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		wMAtUyBmfUus9eDiTEF2();
		statusCode = 200;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PublicServiceException(string message)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		wMAtUyBmfUus9eDiTEF2();
		statusCode = 200;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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
				Message = message;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PublicServiceException(string message, int statusCode)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		wMAtUyBmfUus9eDiTEF2();
		this.statusCode = 200;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				Message = message;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				StatusCode = statusCode;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PublicServiceException(string message, int statusCode, Exception innerException)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		wMAtUyBmfUus9eDiTEF2();
		this.statusCode = 200;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				StatusCode = statusCode;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 0;
				}
				break;
			default:
				Message = message;
				num = 2;
				break;
			case 2:
				SetInnerException(innerException);
				num = 3;
				break;
			case 3:
				return;
			}
		}
	}

	public PublicServiceException(Exception exception)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		wMAtUyBmfUus9eDiTEF2();
		statusCode = 200;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			InitializeFromException(exception);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
			{
				num = 1;
			}
		}
	}

	public PublicServiceException(string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		statusCode = 200;
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				Message = message;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num = 0;
				}
				break;
			default:
				SetInnerException(innerException);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	private void InitializeFromException(Exception innerException)
	{
		//Discarded unreachable code: IL_00a0
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				if (innerException == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				Message = (string)PT6qN5BmQI5P1Ucr5604(innerException);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				SetInnerException(innerException);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 0:
				return;
			case 5:
				StatusCode = 200;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void SetInnerException(Exception innerException)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				if (innerException == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 0:
				return;
			case 3:
				break;
			}
			InnerException = new PublicServiceException((string)PT6qN5BmQI5P1Ucr5604(innerException), (Exception)gjbc38BmC6iDdGRgy2mL(innerException));
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
			{
				num2 = 0;
			}
		}
	}

	internal static bool Ne5UbTBmGJheialv20I4()
	{
		return HVGtNsBmhgO0XpOebAcZ == null;
	}

	internal static PublicServiceException nEm1QvBmE0gfA0Vimq6E()
	{
		return HVGtNsBmhgO0XpOebAcZ;
	}

	internal static void wMAtUyBmfUus9eDiTEF2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object PT6qN5BmQI5P1Ucr5604(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object gjbc38BmC6iDdGRgy2mL(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}
}
