using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Dynamic;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;

namespace EleWise.ELMA.Events.Audit;

[Serializable]
public class AuditEventArgs : EventArgs, IAuditEventArgs, IAuditEventHolder, IExtendedPropertiesContainer
{
	protected IAuditObject auditObject;

	protected IAuditAction auditAction;

	private readonly IDictionary<string, object> _extendedProperties;

	internal static AuditEventArgs DfXak9GLJcTdi401ntN3;

	[JsonIgnore]
	public virtual IAuditObject Object
	{
		get
		{
			return auditObject;
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
				case 0:
					return;
				case 1:
					auditObject = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[JsonIgnore]
	public virtual IAuditAction Action
	{
		get
		{
			return auditAction;
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
				case 0:
					return;
				case 1:
					auditAction = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[JsonIgnore]
	public virtual IDictionary<string, object> ExtendedProperties => _extendedProperties;

	public AuditEventArgs()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		ylZA3DGLlOpqLnsLoCuZ();
		_extendedProperties = new Dictionary<string, object>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public AuditEventArgs(IAuditObject auditObject, IAuditAction auditAction)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		ylZA3DGLlOpqLnsLoCuZ();
		_extendedProperties = new Dictionary<string, object>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
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
			Initialize(auditObject, auditAction);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
			{
				num = 1;
			}
		}
	}

	protected void Initialize(IAuditObject @object, IAuditAction action)
	{
		int num = 2;
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
				pouqYsGLg5hpLbiFeVIy(this, action);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				DZsvj5GLrgEN0AefQUiH(this, @object);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private bool Equals(AuditEventArgs other)
	{
		//Discarded unreachable code: IL_0106, IL_0115, IL_0145, IL_0154, IL_026e, IL_027d, IL_028d, IL_029c, IL_02ac
		int num = 17;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (other.Action != null)
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 22:
					if (DsJvgVGL5jSZL2gpJ372(other) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto default;
				case 10:
					if (pcVkfhGLYi9EUrHXsCKw(other.Object.Uid, pidJH2GLjlY6mDujwTgX(DsJvgVGL5jSZL2gpJ372(this))))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 8:
					if (ExtendedProperties == null)
					{
						num2 = 6;
						continue;
					}
					goto case 19;
				case 17:
					if (other == null)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 10;
						}
						continue;
					}
					if (this != other)
					{
						if (other.Object == null)
						{
							num2 = 15;
							continue;
						}
						goto case 22;
					}
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 12;
					}
					continue;
				case 21:
					if (DsJvgVGL5jSZL2gpJ372(this) == null)
					{
						num2 = 18;
						continue;
					}
					goto case 10;
				case 19:
					if (other.ExtendedProperties == null)
					{
						num = 13;
						break;
					}
					goto case 9;
				case 12:
					return true;
				case 14:
					if (other.ExtendedProperties == null)
					{
						num2 = 8;
						continue;
					}
					goto case 19;
				case 16:
					return false;
				case 2:
					return !other.ExtendedProperties.Except(ExtendedProperties).Any();
				case 11:
				case 13:
					return false;
				case 6:
					return true;
				default:
					return false;
				case 15:
					if (DsJvgVGL5jSZL2gpJ372(this) != null)
					{
						num2 = 22;
						continue;
					}
					goto case 1;
				case 4:
					if (sxleleGLL2D0emfKcEKB(this) != null)
					{
						num2 = 5;
						continue;
					}
					goto case 14;
				case 1:
					if (sxleleGLL2D0emfKcEKB(other) == null)
					{
						num = 4;
						break;
					}
					goto case 5;
				case 9:
					if (ExtendedProperties == null)
					{
						num2 = 11;
						continue;
					}
					goto case 7;
				case 3:
					if (sxleleGLL2D0emfKcEKB(this) != null)
					{
						num2 = 20;
						continue;
					}
					goto default;
				case 20:
					if (!pcVkfhGLYi9EUrHXsCKw(FiJomZGLU46feYQhWSXX(other.Action), ((IAuditAction)sxleleGLL2D0emfKcEKB(this)).Uid))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				case 7:
					if (other.ExtendedProperties.Count == lpCGTXGLsEWEx0VfLJId(ExtendedProperties))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 11;
				}
				break;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0087, IL_0096, IL_00a5
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return false;
				case 3:
					if (this == obj)
					{
						goto end_IL_0012;
					}
					if (obj is AuditEventArgs)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				case 2:
					return true;
				case 4:
					if (obj != null)
					{
						num2 = 3;
						break;
					}
					goto case 5;
				default:
					return false;
				case 1:
					return Equals((AuditEventArgs)obj);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public override int GetHashCode()
	{
		//Discarded unreachable code: IL_0046, IL_0075, IL_0084, IL_0095, IL_00d2, IL_00e1, IL_01dd, IL_0215
		int num = 1;
		int num2 = num;
		IEnumerator<KeyValuePair<string, object>> enumerator = default(IEnumerator<KeyValuePair<string, object>>);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		int num3 = default(int);
		Guid guid = default(Guid);
		while (true)
		{
			int num6;
			switch (num2)
			{
			case 3:
				num6 = 0;
				goto IL_0292;
			case 1:
				if (Object != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 6:
				try
				{
					while (true)
					{
						IL_0191:
						int num7;
						if (!jQEgx2GLcnVQAsS3dEWo(enumerator))
						{
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
							{
								num7 = 0;
							}
							goto IL_00a3;
						}
						goto IL_0132;
						IL_0132:
						current = enumerator.Current;
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num7 = 1;
						}
						goto IL_00a3;
						IL_00a3:
						while (true)
						{
							switch (num7)
							{
							case 6:
							{
								num3 = (num3 * 397) ^ current.Key.GetHashCode();
								int num8 = 3;
								num7 = num8;
								continue;
							}
							case 7:
								num3 = (num3 * 397) ^ current.Value.GetHashCode();
								num7 = 5;
								continue;
							case 4:
								break;
							case 1:
								if (current.Key != null)
								{
									num7 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
									{
										num7 = 6;
									}
									continue;
								}
								goto case 3;
							case 3:
								if (current.Value == null)
								{
									num7 = 2;
									continue;
								}
								goto case 7;
							case 2:
							case 5:
								goto IL_0191;
							default:
								return num3;
							case 0:
								return num3;
							}
							break;
						}
						goto IL_0132;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								rQeiuCGLzhYH1JmVwHfl(enumerator);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 5:
				enumerator = ExtendedProperties.GetEnumerator();
				num2 = 6;
				break;
			case 8:
				if (ExtendedProperties != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 4;
			case 4:
				return num3;
			default:
				guid = pidJH2GLjlY6mDujwTgX(DsJvgVGL5jSZL2gpJ372(this));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 7;
				}
				break;
			case 7:
				num6 = guid.GetHashCode();
				goto IL_0292;
			case 2:
				{
					int num4 = num3 * 397;
					int num5;
					if (sxleleGLL2D0emfKcEKB(this) == null)
					{
						num5 = 0;
					}
					else
					{
						guid = FiJomZGLU46feYQhWSXX(sxleleGLL2D0emfKcEKB(this));
						num5 = guid.GetHashCode();
					}
					num3 = num4 ^ num5;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 8;
					}
					break;
				}
				IL_0292:
				num3 = num6;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void ylZA3DGLlOpqLnsLoCuZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Qh2yeHGL9xhCe4cR3Tpc()
	{
		return DfXak9GLJcTdi401ntN3 == null;
	}

	internal static AuditEventArgs xIJEDbGLdkqReU198jD9()
	{
		return DfXak9GLJcTdi401ntN3;
	}

	internal static void DZsvj5GLrgEN0AefQUiH(object P_0, object P_1)
	{
		((AuditEventArgs)P_0).Object = (IAuditObject)P_1;
	}

	internal static void pouqYsGLg5hpLbiFeVIy(object P_0, object P_1)
	{
		((AuditEventArgs)P_0).Action = (IAuditAction)P_1;
	}

	internal static object DsJvgVGL5jSZL2gpJ372(object P_0)
	{
		return ((AuditEventArgs)P_0).Object;
	}

	internal static Guid pidJH2GLjlY6mDujwTgX(object P_0)
	{
		return ((IAuditObject)P_0).Uid;
	}

	internal static bool pcVkfhGLYi9EUrHXsCKw(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object sxleleGLL2D0emfKcEKB(object P_0)
	{
		return ((AuditEventArgs)P_0).Action;
	}

	internal static Guid FiJomZGLU46feYQhWSXX(object P_0)
	{
		return ((IAuditAction)P_0).Uid;
	}

	internal static int lpCGTXGLsEWEx0VfLJId(object P_0)
	{
		return ((ICollection<KeyValuePair<string, object>>)P_0).Count;
	}

	internal static bool jQEgx2GLcnVQAsS3dEWo(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void rQeiuCGLzhYH1JmVwHfl(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
