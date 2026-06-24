using System;
using System.Diagnostics;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Transformations
{
	[Serializable]
	[DebuggerTypeProxy(typeof(TransformationAdd<, , , , >.DebugView))]
	[DebuggerDisplay("ContainerUid: {Uid}, Item: {Item}{AfterItem != null ? \", AfterItemUid : \" + AfterItem : \"\", nq}{BeforeItem != null ? \", BeforeItemUid : \" + BeforeItem : \"\", nq}", Type = "Add")]
	public abstract class TransformationAdd<TItem, TTransformation, TUid, TNullUid, TSaveItem> : BaseTransformation<TItem, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
	{
		public sealed class DebugView
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly TransformationAdd<TItem, TTransformation, TUid, TNullUid, TSaveItem> transformation;

			public TUid ContainerUid => transformation.Uid;

			public TItem Item => transformation.GetItem();

			public TNullUid BeforeItemUid => transformation.BeforeItem;

			public TNullUid AfterItemUid => transformation.AfterItem;

			public DebugView(TransformationAdd<TItem, TTransformation, TUid, TNullUid, TSaveItem> transformation)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				this.transformation = transformation;
			}
		}

		public TSaveItem Item;

		internal static object ghSo22WUueLqcSmHlHay;

		public TNullUid BeforeItem { get; set; }

		public TNullUid AfterItem { get; set; }

		protected internal abstract TItem GetItem();

		protected internal abstract void SetItem(TItem value);

		public override void Apply(TItem rootItem)
		{
			ApplyReturn(rootItem);
		}

		public TItem ApplyReturn(TItem rootItem, TTransformation instance = null)
		{
			return StaticApply(rootItem, base.Uid, GetItem(), BeforeItem, AfterItem, instance);
		}

		public static TItem StaticApply(TItem rootItem, TUid Uid, TItem Item, TNullUid BeforeItem, TNullUid AfterItem, TTransformation instance = null)
		{
			_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
			CS_0024_003C_003E8__locals0.AfterItem = AfterItem;
			CS_0024_003C_003E8__locals0.BeforeItem = BeforeItem;
			if (Item == null)
			{
				return null;
			}
			CS_0024_003C_003E8__locals0.t = instance ?? Transformation<TItem, TTransformation, TUid, TNullUid>.Instance;
			TItem val = CS_0024_003C_003E8__locals0.t.FindItem(rootItem, Uid);
			if (val == null)
			{
				return null;
			}
			TItem container;
			TItem val2 = CS_0024_003C_003E8__locals0.t.FindItem(rootItem, Item, out container);
			if (container != null && val2 != null)
			{
				CS_0024_003C_003E8__locals0.t.DeleteItem(container, val2);
			}
			if (CS_0024_003C_003E8__locals0.AfterItem != null)
			{
				TItem val3 = (CS_0024_003C_003E8__locals0.t.GetSubItems(val) ?? new TItem[0]).FirstOrDefault((TItem i) => CS_0024_003C_003E8__locals0.t.EqualsItems(i, CS_0024_003C_003E8__locals0.AfterItem));
				if (val3 != null)
				{
					int num = (CS_0024_003C_003E8__locals0.t.GetSubItems(val) ?? new TItem[0]).IndexOf(val3);
					CS_0024_003C_003E8__locals0.t.InsertItem(val, num + 1, Item);
					return Item;
				}
			}
			if (CS_0024_003C_003E8__locals0.BeforeItem != null)
			{
				TItem val4 = (CS_0024_003C_003E8__locals0.t.GetSubItems(val) ?? new TItem[0]).FirstOrDefault((TItem i) => CS_0024_003C_003E8__locals0.t.EqualsItems(i, CS_0024_003C_003E8__locals0.BeforeItem));
				if (val4 != null)
				{
					int index = (CS_0024_003C_003E8__locals0.t.GetSubItems(val) ?? new TItem[0]).IndexOf(val4);
					CS_0024_003C_003E8__locals0.t.InsertItem(val, index, Item);
					return Item;
				}
			}
			CS_0024_003C_003E8__locals0.t.AddItem(val, Item);
			return Item;
		}

		protected TransformationAdd()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool RVSwSIWUIh81MXWxDRdT()
		{
			return ghSo22WUueLqcSmHlHay == null;
		}

		internal static object UJh2dGWUVZdW4ZsjbdKb()
		{
			return ghSo22WUueLqcSmHlHay;
		}
	}
	[Serializable]
	public class TransformationAdd<TItem, TTransformation, TUid, TNullUid> : TransformationAdd<TItem, TTransformation, TUid, TNullUid, TItem> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
	{
		internal static object Ord40RWUSRusL5jIcnIB;

		protected internal override TItem GetItem()
		{
			return Transformation<TItem, TTransformation, TUid, TNullUid>.Instance.Clone(Item);
		}

		protected internal override void SetItem(TItem value)
		{
			TTransformation instance = Transformation<TItem, TTransformation, TUid, TNullUid>.Instance;
			Item = instance.CreateCopy(value);
		}

		public TransformationAdd()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool PX5pYPWUiHnH9td2ftGZ()
		{
			return Ord40RWUSRusL5jIcnIB == null;
		}

		internal static object jFxdIKWURANCMQHxF4Cq()
		{
			return Ord40RWUSRusL5jIcnIB;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Struct
{
	[Serializable]
	public abstract class TransformationAdd<TItem, TTransformation, TUid, TSaveItem> : TransformationAdd<TItem, TTransformation, TUid, TUid?, TSaveItem> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : struct
	{
		private static object BYX3ngWU7TYp3tDqMEDe;

		protected TransformationAdd()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool tTqyE0WUxP3w38w2Byyp()
		{
			return BYX3ngWU7TYp3tDqMEDe == null;
		}

		internal static object aUOTISWU0vCMuVPtl4Of()
		{
			return BYX3ngWU7TYp3tDqMEDe;
		}
	}
	[Serializable]
	public class TransformationAdd<TItem, TTransformation, TUid> : EleWise.ELMA.Model.Transformations.TransformationAdd<TItem, TTransformation, TUid, TUid?> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : struct
	{
		internal static object pHcEofWUmpUronWg9SkF;

		public TransformationAdd()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool JrKyamWUyC29L352IJ8G()
		{
			return pHcEofWUmpUronWg9SkF == null;
		}

		internal static object AjOhvSWUM2AGq602y7v2()
		{
			return pHcEofWUmpUronWg9SkF;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Class
{
	[Serializable]
	public abstract class TransformationAdd<TItem, TTransformation, TUid, TSaveItem> : TransformationAdd<TItem, TTransformation, TUid, TUid, TSaveItem> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : class where TSaveItem : class
	{
		private static object RHuwnFWsB8eOpCdkP1JG;

		protected TransformationAdd()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool nnRjZxWsW4tnamB6ZgdY()
		{
			return RHuwnFWsB8eOpCdkP1JG == null;
		}

		internal static object wvBRJLWsonSt6meA6gCI()
		{
			return RHuwnFWsB8eOpCdkP1JG;
		}
	}
	[Serializable]
	public class TransformationAdd<TItem, TTransformation, TUid> : EleWise.ELMA.Model.Transformations.TransformationAdd<TItem, TTransformation, TUid, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : class
	{
		private static object rRW2m1WsbMcDCFs1AR3u;

		public TransformationAdd()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool eKUSbiWshjm27kNuKykR()
		{
			return rRW2m1WsbMcDCFs1AR3u == null;
		}

		internal static object SvfM1jWsGIYbRM3ea7dY()
		{
			return rRW2m1WsbMcDCFs1AR3u;
		}
	}
}
