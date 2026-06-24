using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy;

public class PacketEntity
{
	public IEntity Entity;

	public List<IEntity> SubEntities;

	public ExportRuleList ExportRules;

	public string ContentType;

	public IDictionary<string, object> PacketData;

	private int version;

	internal static PacketEntity AoG9ZMEpOhao5lp6xPbB;

	public int Version
	{
		get
		{
			return version;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (value <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 1;
						}
						break;
					}
					version = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					throw new ArgumentOutOfRangeException((string)WL7gWNEpNkjpuxXMv48J(ThKYqVEp1CT02oC7sbfv(0x34A6D230 ^ 0x34A257A0)));
				}
			}
		}
	}

	public string NodeName
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (string)DrQBNQEp3qgRivQEaJUA(ThKYqVEp1CT02oC7sbfv(-787452571 ^ -787218117), version);
				case 1:
					if (version == 0)
					{
						return (string)ThKYqVEp1CT02oC7sbfv(-812025778 ^ -811784670);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PacketEntity(IEntity entity)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				PacketData = new Dictionary<string, object>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 3:
				Entity = entity;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num = 0;
				}
				break;
			case 1:
				SubEntities = new List<IEntity>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public PacketEntity(IEntity entity, string contentType)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		mJ6vAiEpP3r9kp8AqsIK();
		this._002Ector(entity);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
				ContentType = contentType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public PacketEntity(IEntity entity, string contentType, int version)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		mJ6vAiEpP3r9kp8AqsIK();
		this._002Ector(entity, contentType);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
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
			Version = version;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool oGNhNUEp2A0w510dGrYN()
	{
		return AoG9ZMEpOhao5lp6xPbB == null;
	}

	internal static PacketEntity FCJptbEpevQa5Xmtq4cA()
	{
		return AoG9ZMEpOhao5lp6xPbB;
	}

	internal static void mJ6vAiEpP3r9kp8AqsIK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object ThKYqVEp1CT02oC7sbfv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WL7gWNEpNkjpuxXMv48J(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object DrQBNQEp3qgRivQEaJUA(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}
}
