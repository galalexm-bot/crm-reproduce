using System;
using System.Diagnostics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Transformations
{
	[Serializable]
	[DebuggerTypeProxy(typeof(TransformationHide<, , , >.DebugView))]
	[DebuggerDisplay("ItemUid: {Uid}", Type = "Hide")]
	public class TransformationHide<TItem, TTransformation, TUid, TNullUid> : BaseTransformation<TItem, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
	{
		public sealed class DebugView
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly TransformationHide<TItem, TTransformation, TUid, TNullUid> transformation;

			public TUid ItemUid => transformation.Uid;

			public DebugView(TransformationHide<TItem, TTransformation, TUid, TNullUid> transformation)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				this.transformation = transformation;
			}
		}

		internal static object Sb9bLsWU2K37rrTVHja3;

		public override void Apply(TItem rootItem)
		{
			ApplyReturn(rootItem);
		}

		public TItem ApplyReturn(TItem rootItem, TTransformation instance = null)
		{
			return StaticApply(rootItem, base.Uid, instance);
		}

		public static TItem StaticApply(TItem rootItem, TUid Uid, TTransformation instance = null)
		{
			TTransformation val = instance ?? Transformation<TItem, TTransformation, TUid, TNullUid>.Instance;
			TItem container;
			TItem val2 = val.FindItem(rootItem, Uid, out container);
			if (val2 != null)
			{
				val.SetHide(container, val2);
			}
			return val2;
		}

		public TransformationHide()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
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

		internal static bool wRAYVFWUerJRF0woSeKu()
		{
			return Sb9bLsWU2K37rrTVHja3 == null;
		}

		internal static object dZdXYVWUP23cOspytO9t()
		{
			return Sb9bLsWU2K37rrTVHja3;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Struct
{
	[Serializable]
	public class TransformationHide<TItem, TTransformation, TUid> : TransformationHide<TItem, TTransformation, TUid, TUid?> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : struct
	{
		private static object sY0xx3WUlnS7JASM9da8;

		public TransformationHide()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool aFVSMQWUr1i2uf7TCXno()
		{
			return sY0xx3WUlnS7JASM9da8 == null;
		}

		internal static object hnemIjWUgi80acLFx2AS()
		{
			return sY0xx3WUlnS7JASM9da8;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Class
{
	[Serializable]
	public class TransformationHide<TItem, TTransformation, TUid> : TransformationHide<TItem, TTransformation, TUid, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : class
	{
		private static object nkI0uZWsCQj4CYXiQJY4;

		public TransformationHide()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool TWwonfWsv12feca7a94q()
		{
			return nkI0uZWsCQj4CYXiQJY4 == null;
		}

		internal static object AoUAPoWs8ek28bSULqyZ()
		{
			return nkI0uZWsCQj4CYXiQJY4;
		}
	}
}
