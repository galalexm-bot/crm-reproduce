using System;
using System.Diagnostics;
using System.Linq;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Transformations
{
	[Serializable]
	[DebuggerDisplay("NewContainerUid: {Uid}, MoveItemUid: {MoveItemUid}{AfterItem != null ? \", AfterItemUid : \" + AfterItem : \"\", nq}{BeforeItem != null ? \", BeforeItemUid : \" + BeforeItem : \"\", nq}", Type = "Move")]
	[DebuggerTypeProxy(typeof(TransformationMove<, , , >.DebugView))]
	public class TransformationMove<TItem, TTransformation, TUid, TNullUid> : BaseTransformation<TItem, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
	{
		public sealed class DebugView
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly TransformationMove<TItem, TTransformation, TUid, TNullUid> transformation;

			public TUid NewContainerUid => transformation.Uid;

			public TUid MoveItemUid => transformation.MoveItemUid;

			public TNullUid BeforeItemUid => transformation.BeforeItem;

			public TNullUid AfterItemUid => transformation.AfterItem;

			public DebugView(TransformationMove<TItem, TTransformation, TUid, TNullUid> transformation)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				this.transformation = transformation;
			}
		}

		internal static object vfsrJOWU1j8ZctH1eE08;

		public TUid MoveItemUid { get; set; }

		public TNullUid BeforeItem { get; set; }

		public TNullUid AfterItem { get; set; }

		public override void Apply(TItem rootItem)
		{
			ApplyReturn(rootItem);
		}

		public TItem ApplyReturn(TItem rootItem, TTransformation instance = null)
		{
			return StaticApply(rootItem, base.Uid, MoveItemUid, BeforeItem, AfterItem, instance);
		}

		public static TItem StaticApply(TItem rootItem, TUid Uid, TUid MoveItemUid, TNullUid BeforeItem, TNullUid AfterItem, TTransformation instance = null)
		{
			_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
			_003C_003Ec__DisplayClass15_.AfterItem = AfterItem;
			_003C_003Ec__DisplayClass15_.BeforeItem = BeforeItem;
			try
			{
				_003C_003Ec__DisplayClass15_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_1();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass15_;
				CS_0024_003C_003E8__locals0.t = instance ?? Transformation<TItem, TTransformation, TUid, TNullUid>.Instance;
				TItem val = CS_0024_003C_003E8__locals0.t.FindItem(rootItem, Uid);
				if (val == null)
				{
					return null;
				}
				TItem container;
				TItem val2 = CS_0024_003C_003E8__locals0.t.FindItem(rootItem, MoveItemUid, out container);
				if (val2 == null)
				{
					return null;
				}
				CS_0024_003C_003E8__locals0.t.RemoveItem(container, val2);
				if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.AfterItem != null)
				{
					TItem val3 = (CS_0024_003C_003E8__locals0.t.GetSubItems(val) ?? new TItem[0]).FirstOrDefault((TItem i) => CS_0024_003C_003E8__locals0.t.EqualsItems(i, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.AfterItem));
					if (val3 != null)
					{
						int num = (CS_0024_003C_003E8__locals0.t.GetSubItems(val) ?? new TItem[0]).IndexOf(val3);
						CS_0024_003C_003E8__locals0.t.InsertItem(val, num + 1, val2);
						return val2;
					}
				}
				if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.BeforeItem != null)
				{
					TItem val4 = (CS_0024_003C_003E8__locals0.t.GetSubItems(val) ?? new TItem[0]).FirstOrDefault((TItem i) => CS_0024_003C_003E8__locals0.t.EqualsItems(i, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.BeforeItem));
					if (val4 != null)
					{
						int index = (CS_0024_003C_003E8__locals0.t.GetSubItems(val) ?? new TItem[0]).IndexOf(val4);
						CS_0024_003C_003E8__locals0.t.InsertItem(val, index, val2);
						return val2;
					}
				}
				CS_0024_003C_003E8__locals0.t.AddItem(val, val2);
				return val2;
			}
			catch (Exception ex)
			{
				Logger.Log.Error(ex.Message, ex);
				return null;
			}
		}

		public TransformationMove()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool ToYKSmWUN0FJQs8lHkEG()
		{
			return vfsrJOWU1j8ZctH1eE08 == null;
		}

		internal static object ooTXmDWU3L3YgPuLRqbo()
		{
			return vfsrJOWU1j8ZctH1eE08;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Struct
{
	[Serializable]
	public class TransformationMove<TItem, TTransformation, TUid> : TransformationMove<TItem, TTransformation, TUid, TUid?> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : struct
	{
		internal static object ePxrHqWU5uXm9tYxOpYG;

		public TransformationMove()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool zeJr6FWUjBRxEFfMrdUh()
		{
			return ePxrHqWU5uXm9tYxOpYG == null;
		}

		internal static object x491rkWUYKS5ojBvx4BL()
		{
			return ePxrHqWU5uXm9tYxOpYG;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Class
{
	[Serializable]
	public class TransformationMove<TItem, TTransformation, TUid> : TransformationMove<TItem, TTransformation, TUid, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : class
	{
		internal static object VByOmgWsZeEONVxrjisF;

		public TransformationMove()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool DVQZ2qWsugxw7G5UwERi()
		{
			return VByOmgWsZeEONVxrjisF == null;
		}

		internal static object i4BsjkWsIVpfc3fmrQ7E()
		{
			return VByOmgWsZeEONVxrjisF;
		}
	}
}
