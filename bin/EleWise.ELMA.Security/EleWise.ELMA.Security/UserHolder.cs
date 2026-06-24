using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

[Serializable]
internal class UserHolder : EntityHolder<long, EleWise.ELMA.Security.Models.IUser>
{
	private Guid _ticketId;

	private static UserHolder zX4Ed7NJHYhfxChxTgJ;

	public Guid TicketId => _ticketId;

	public UserHolder(EleWise.ELMA.Security.Models.IUser user, Guid ticketId)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		JEEaA4NhCPNM1mNHYtQ();
		base._002Ector(user);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
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
			_ticketId = ticketId;
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
			{
				num = 1;
			}
		}
	}

	internal static void JEEaA4NhCPNM1mNHYtQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool lcMn5LNKHo3Pl1kETL1()
	{
		return zX4Ed7NJHYhfxChxTgJ == null;
	}

	internal static UserHolder aoxGF7NtTrsGCi8JXim()
	{
		return zX4Ed7NJHYhfxChxTgJ;
	}
}
