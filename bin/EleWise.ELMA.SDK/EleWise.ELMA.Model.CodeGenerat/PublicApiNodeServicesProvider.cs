using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

[Component(Order = 4)]
public class PublicApiNodeServicesProvider : IPublicApiNodeProvider
{
	[Component(Order = int.MaxValue)]
	internal class PublicApiServicesNodeProvider : IPublicApiNodeProvider
	{
		private static PublicApiServicesNodeProvider DhwnUtvt8VUVDg0WpHGR;

		[IteratorStateMachine(typeof(_003CCreatePublicApiNodes_003Ed__0))]
		public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			return new _003CCreatePublicApiNodes_003Ed__0(-2);
		}

		public PublicApiServicesNodeProvider()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Ie2rNwvtZubd8vTh81x1()
		{
			return DhwnUtvt8VUVDg0WpHGR == null;
		}

		internal static PublicApiServicesNodeProvider YJMCWnvtupBPgpC5Sw10()
		{
			return DhwnUtvt8VUVDg0WpHGR;
		}
	}

	private static PublicApiNodeServicesProvider C1DeqNhAV74R5cD0jitj;

	[IteratorStateMachine(typeof(_003CCreatePublicApiNodes_003Ed__0))]
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCreatePublicApiNodes_003Ed__0(-2);
	}

	[IteratorStateMachine(typeof(_003CServices_003Ed__2))]
	public static IEnumerable<IPublicApiNode> Services(params Type[] serviceList)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CServices_003Ed__2(-2)
		{
			_003C_003E3__serviceList = serviceList
		};
	}

	public PublicApiNodeServicesProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool l3DyanhASJMo6WkvDBAd()
	{
		return C1DeqNhAV74R5cD0jitj == null;
	}

	internal static PublicApiNodeServicesProvider zVCxOshAiDJ9O8NCan56()
	{
		return C1DeqNhAV74R5cD0jitj;
	}
}
