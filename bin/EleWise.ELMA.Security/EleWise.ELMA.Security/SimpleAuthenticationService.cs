using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

[Service(Type = ComponentType.DesignServer, InjectProperties = true, Scope = ServiceScope.Application, EnableInterceptors = false)]
public class SimpleAuthenticationService : IAuthenticationService
{
	private IUser user;

	private Dictionary<Guid, AuthenticatedSessionInfo> _currentSessionInfos;

	internal static SimpleAuthenticationService P0k8P6lbm7193YdsXe9;

	public IUser GetCurrentUser()
	{
		return user;
	}

	public object GetCurrentUserId()
	{
		throw new NotImplementedException();
	}

	public T GetCurrentUser<T>() where T : IUser
	{
		return (T)GetCurrentUser();
	}

	public void SignIn(IUser user, bool rememberMeSet = false)
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
				this.user = user;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void SignIn(IUser user, bool rememberMeSet, bool checkRequireChangePassword)
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
				this.user = user;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SignOut()
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
				user = null;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetAuthenticatedUserForRequest(IUser user)
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
				this.user = user;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetAuthenticatedUserIdForRequest(object userId)
	{
		throw new NotImplementedException();
	}

	public AuthenticatedSessionInfo GetCurrentSession()
	{
		//Discarded unreachable code: IL_0054, IL_0120, IL_0158, IL_0167
		int num = 1;
		AuthenticatedSessionInfo value = default(AuthenticatedSessionInfo);
		Dictionary<Guid, AuthenticatedSessionInfo> currentSessionInfos = default(Dictionary<Guid, AuthenticatedSessionInfo>);
		bool lockTaken = default(bool);
		KeyValuePair<Guid, AuthenticatedSessionInfo> keyValuePair = default(KeyValuePair<Guid, AuthenticatedSessionInfo>);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return value;
				case 3:
					try
					{
						Monitor.Enter(currentSessionInfos, ref lockTaken);
						int num3 = 2;
						while (true)
						{
							switch (num3)
							{
							case 3:
								return value;
							default:
								value = keyValuePair.Value;
								num3 = 3;
								break;
							case 2:
								_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
								{
									num3 = 1;
								}
								break;
							case 1:
								_003C_003Ec__DisplayClass8_.userId = ql8klZlfAj610XtXX4l(user);
								num3 = 4;
								break;
							case 4:
								keyValuePair = _currentSessionInfos.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CGetCurrentSession_003Eb__0);
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									Monitor.Exit(currentSessionInfos);
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 1:
					currentSessionInfos = _currentSessionInfos;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			lockTaken = false;
			num = 3;
		}
	}

	public IEnumerable<AuthenticatedSessionInfo> GetActiveSessions()
	{
		return _currentSessionInfos.Values.Cast<AuthenticatedSessionInfo>().ToList().AsReadOnly();
	}

	public IEnumerable<AuthenticatedSessionInfo> GetSessions(AuthenticatedSessionFilter filter)
	{
		return GetActiveSessions();
	}

	public void RemoveSession(Guid ticketId)
	{
		//Discarded unreachable code: IL_008f, IL_0111, IL_0141, IL_0150, IL_015c, IL_016b
		int num = 1;
		int num2 = num;
		bool lockTaken = default(bool);
		Dictionary<Guid, AuthenticatedSessionInfo> currentSessionInfos = default(Dictionary<Guid, AuthenticatedSessionInfo>);
		while (true)
		{
			switch (num2)
			{
			default:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				currentSessionInfos = _currentSessionInfos;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				try
				{
					Monitor.Enter(currentSessionInfos, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							_currentSessionInfos.Remove(ticketId);
							num3 = 2;
							break;
						case 1:
							if (_currentSessionInfos.ContainsKey(ticketId))
							{
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
								{
									num3 = 0;
								}
								break;
							}
							return;
						case 2:
							return;
						}
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
						{
							num4 = 0;
						}
						goto IL_0115;
					}
					goto IL_012b;
					IL_012b:
					AdtxHol11bKbZPoXWOf(currentSessionInfos);
					num4 = 2;
					goto IL_0115;
					IL_0115:
					switch (num4)
					{
					case 1:
						goto end_IL_00f0;
					case 2:
						goto end_IL_00f0;
					}
					goto IL_012b;
					end_IL_00f0:;
				}
			case 3:
				return;
			}
		}
	}

	public void RemoveAllUserSessions(object userId)
	{
		//Discarded unreachable code: IL_0097, IL_0110, IL_011f, IL_01ce, IL_0202, IL_023a
		int num = 4;
		int num2 = num;
		bool lockTaken = default(bool);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		Dictionary<Guid, AuthenticatedSessionInfo> currentSessionInfos = default(Dictionary<Guid, AuthenticatedSessionInfo>);
		List<KeyValuePair<Guid, AuthenticatedSessionInfo>>.Enumerator enumerator = default(List<KeyValuePair<Guid, AuthenticatedSessionInfo>>.Enumerator);
		KeyValuePair<Guid, AuthenticatedSessionInfo> current = default(KeyValuePair<Guid, AuthenticatedSessionInfo>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				lockTaken = false;
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass12_.userId = userId;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				try
				{
					Monitor.Enter(currentSessionInfos, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							enumerator = _currentSessionInfos.Where(_003C_003Ec__DisplayClass12_._003CRemoveAllUserSessions_003Eb__0).ToList().GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
							{
								num3 = 0;
							}
							continue;
						}
						try
						{
							while (true)
							{
								IL_018c:
								int num4;
								if (!enumerator.MoveNext())
								{
									num4 = 3;
									goto IL_012e;
								}
								goto IL_0175;
								IL_012e:
								while (true)
								{
									switch (num4)
									{
									case 2:
										_currentSessionInfos.Remove(current.Key);
										num4 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 != 0)
										{
											num4 = 0;
										}
										continue;
									case 1:
										goto IL_018c;
									case 3:
										return;
									}
									break;
								}
								goto IL_0175;
								IL_0175:
								current = enumerator.Current;
								int num5 = 2;
								num4 = num5;
								goto IL_012e;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num6 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							case 0:
								break;
							}
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num7 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								AdtxHol11bKbZPoXWOf(currentSessionInfos);
								num7 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
								{
									num7 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 4:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				currentSessionInfos = _currentSessionInfos;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public SimpleAuthenticationService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		aSFe5ulzpJ2ORYDARyB();
		_currentSessionInfos = new Dictionary<Guid, AuthenticatedSessionInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool HtnWqBlSVttXvTKiEDl()
	{
		return P0k8P6lbm7193YdsXe9 == null;
	}

	internal static SimpleAuthenticationService Heehgal9WIEd4ISBW15()
	{
		return P0k8P6lbm7193YdsXe9;
	}

	internal static object ql8klZlfAj610XtXX4l(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void AdtxHol11bKbZPoXWOf(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void aSFe5ulzpJ2ORYDARyB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
