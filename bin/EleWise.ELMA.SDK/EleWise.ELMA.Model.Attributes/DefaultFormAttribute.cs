using System;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class DefaultFormAttribute : Attribute
{
	private ViewType viewType;

	private Guid formUid;

	private Guid actionUid;

	private Guid groupUid;

	private Guid targetUid;

	private bool deletedFromChild;

	internal static DefaultFormAttribute RL5ZpNoC3DTFvTxOKM7N;

	public ViewType ViewType => viewType;

	public Guid ActionUid => actionUid;

	public Guid FormUid => formUid;

	public Guid GroupUid => groupUid;

	public Guid TargetUid => targetUid;

	public bool DeletedFromChild => deletedFromChild;

	public DefaultFormAttribute(ViewType viewType, string formUid)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		HlKYmMoCD1VQPqv7Wx0u();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.viewType = viewType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.formUid = new Guid(formUid);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public DefaultFormAttribute(ViewType viewType, string actionUid, string formUid)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		HlKYmMoCD1VQPqv7Wx0u();
		this._002Ector(viewType, formUid);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
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
			this.actionUid = new Guid(actionUid);
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
			{
				num = 1;
			}
		}
	}

	public DefaultFormAttribute(ViewType viewType, string actionUid, string formUid, string groupUid, string targetUid)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		HlKYmMoCD1VQPqv7Wx0u();
		this._002Ector(viewType, actionUid, formUid);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.targetUid = new Guid(targetUid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				this.groupUid = new Guid(groupUid);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public DefaultFormAttribute(ViewType viewType, string actionUid, string formUid, string groupUid, string targetUid, bool deletedFromChild)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		HlKYmMoCD1VQPqv7Wx0u();
		this._002Ector(viewType, actionUid, formUid, groupUid, targetUid);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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
			this.deletedFromChild = deletedFromChild;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void HlKYmMoCD1VQPqv7Wx0u()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wwyj8CoCpgFt7qbIHf9y()
	{
		return RL5ZpNoC3DTFvTxOKM7N == null;
	}

	internal static DefaultFormAttribute z3euNYoCae2OJTirf6a0()
	{
		return RL5ZpNoC3DTFvTxOKM7N;
	}
}
