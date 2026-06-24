using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public class ChangeEntityAction : EntityAction
{
	private EntityMetadata oldMetadata;

	internal static ChangeEntityAction ITeaxsohzkq1F3OposBs;

	public ChangeEntityAction(IDbModelUpdater updater, EntityMetadata metadata, EntityMetadata oldMetadata)
	{
		//Discarded unreachable code: IL_001c, IL_0021, IL_0111
		k6SGMnoGWJ0ktERjnmO4();
		base._002Ector(updater, metadata);
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!string.IsNullOrEmpty((string)lxpPjaoGh7rD5GQk0vEj(base.Metadata)))
				{
					num = 4;
					break;
				}
				goto case 3;
			case 5:
				Wg0II1oGb2BkuXV50R6h(oldMetadata, NACpZLoGoP0dRK14up8o(0x18A6761F ^ 0x18A423C7));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 0;
				}
				break;
			default:
				this.oldMetadata = oldMetadata;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				throw new DbModelException((string)gmohSRoGEKuMlvFjoYTF(c5vcnHoGGHNdqegLAOkT(NACpZLoGoP0dRK14up8o(-787452571 ^ -787333469)), base.Metadata.FullTypeName));
			case 4:
				if (HrvsKRoGfX2S5Y4hY5Tm(lxpPjaoGh7rD5GQk0vEj(oldMetadata), lxpPjaoGh7rD5GQk0vEj(metadata)))
				{
					num = 2;
					break;
				}
				return;
			case 2:
				base.Updater.TablesCreatedActions.Add(new DbRenameTableAction((ITransformationProvider)UYjvbAoGQUXCrLedFwQY(updater), (string)lxpPjaoGh7rD5GQk0vEj(oldMetadata), (string)lxpPjaoGh7rD5GQk0vEj(metadata)));
				num = 6;
				break;
			case 6:
				return;
			}
		}
	}

	public override void Execute()
	{
		base.Execute();
	}

	internal static void k6SGMnoGWJ0ktERjnmO4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object NACpZLoGoP0dRK14up8o(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Wg0II1oGb2BkuXV50R6h(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object lxpPjaoGh7rD5GQk0vEj(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static object c5vcnHoGGHNdqegLAOkT(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object gmohSRoGEKuMlvFjoYTF(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool HrvsKRoGfX2S5Y4hY5Tm(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object UYjvbAoGQUXCrLedFwQY(object P_0)
	{
		return ((IDbModelUpdater)P_0).Transform;
	}

	internal static bool Rs5QN8oGFmWvifPQiPDG()
	{
		return ITeaxsohzkq1F3OposBs == null;
	}

	internal static ChangeEntityAction DZweZ4oGBnHVXdQhjDvm()
	{
		return ITeaxsohzkq1F3OposBs;
	}
}
