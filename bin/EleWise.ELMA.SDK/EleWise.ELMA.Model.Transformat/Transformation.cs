using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Transformations
{
	[Serializable]
	[DebuggerDisplay("Count = {Items.Count}")]
	[DebuggerTypeProxy(typeof(Transformation<, , , >.DebugView))]
	public abstract class Transformation<TItem, TTransformation, TUid, TNullUid> : BaseTransformation<TItem, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
	{
		public sealed class DebugView
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Transformation<TItem, TTransformation, TUid, TNullUid> transformation;

			private static object f56G0dCBISF6bNHYUdTP;

			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public BaseTransformation<TItem, TUid>[] Items => transformation.Items.ToArray();

			public DebugView(Transformation<TItem, TTransformation, TUid, TNullUid> transformation)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				this.transformation = transformation;
			}

			internal static bool M0vs5LCBVGtNkgXbbqeT()
			{
				return f56G0dCBISF6bNHYUdTP == null;
			}

			internal static object h727IaCBSQyUZB8tOjA5()
			{
				return f56G0dCBISF6bNHYUdTP;
			}
		}

		private class PropertyGrouping
		{
			internal static object Ghn4ugCBiLfdhjYJXdJ4;

			public string Property
			{
				[CompilerGenerated]
				get
				{
					return _003CProperty_003Ek__BackingField;
				}
				[CompilerGenerated]
				private set
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
							_003CProperty_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public PropertyGrouping[] SubProperties
			{
				[CompilerGenerated]
				get
				{
					return _003CSubProperties_003Ek__BackingField;
				}
				[CompilerGenerated]
				private set
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
							_003CSubProperties_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public static PropertyGrouping[] Create(string[][] props)
			{
				return (from p in props.Where(delegate(string[] p)
					{
						//Discarded unreachable code: IL_0055, IL_0064
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return p.Length == 0;
							case 1:
								return true;
							case 2:
								if (p == null)
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
									{
										num4 = 1;
									}
									break;
								}
								goto default;
							}
						}
					})
					select new PropertyGrouping
					{
						Property = null,
						SubProperties = null
					}).Union(from p in props.Where(delegate(string[] p)
					{
						//Discarded unreachable code: IL_0035, IL_0044
						int num = 2;
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							default:
								return p.Length != 0;
							case 1:
								return false;
							case 2:
								if (p == null)
								{
									num2 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
									{
										num2 = 0;
									}
									break;
								}
								goto default;
							}
						}
					})
					group p.Skip(1).ToArray() by p.FirstOrDefault() into g
					select new PropertyGrouping
					{
						Property = g.Key,
						SubProperties = Create(g.ToArray())
					}).ToArray();
			}

			public PropertyGrouping()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool g3d9QnCBRUFWxmu23upT()
			{
				return Ghn4ugCBiLfdhjYJXdJ4 == null;
			}

			internal static object jfq5DGCBqofa0nWf7dDn()
			{
				return Ghn4ugCBiLfdhjYJXdJ4;
			}
		}

		private static TTransformation _instance;

		private List<BaseTransformation<TItem, TUid>> items;

		internal static object d5rAgUWUfaQyEB3X0WWY;

		public static TTransformation Instance => _instance ?? (_instance = new TTransformation());

		public List<BaseTransformation<TItem, TUid>> Items => items ?? (items = new List<BaseTransformation<TItem, TUid>>());

		public override void Apply(TItem rootItem)
		{
			if (items == null)
			{
				return;
			}
			foreach (BaseTransformation<TItem, TUid> item in items.Where((BaseTransformation<TItem, TUid> transformation) => transformation != null))
			{
				item.Apply(rootItem);
			}
		}

		public static TTransformation CreateTransformation(TItem item, TItem originalItem)
		{
			return (TTransformation)Instance.TransformationCreate(item, originalItem);
		}

		public static BaseTransformation<TItem, TUid> Add(TUid itemUid, TItem item, TNullUid afterItem = default(TNullUid), TNullUid beforeItem = default(TNullUid))
		{
			return Instance.TransformationAdd(itemUid, item, afterItem, beforeItem);
		}

		public static BaseTransformation<TItem, TUid> Move(TUid itemUid, TUid moveItemUid, TNullUid afterItem = default(TNullUid), TNullUid beforeItem = default(TNullUid))
		{
			return Instance.TransformationMove(itemUid, moveItemUid, afterItem, beforeItem);
		}

		public static BaseTransformation<TItem, TUid> Hide(TUid itemUid)
		{
			return Instance.TransformationHide(itemUid);
		}

		public static BaseTransformation<TItem, TUid> SetPropertyValue(TUid itemUid, string propertyName, object value)
		{
			return Instance.TransformationChange(itemUid, propertyName, value);
		}

		public static BaseTransformation<TItem, TUid> SetPropertyValue<T>(TUid itemUid, Expression<Func<TItem, T>> property, T value)
		{
			return Transformation<TItem, TTransformation, TUid, TNullUid>.SetPropertyValue<TItem, T>(itemUid, property, value);
		}

		public static BaseTransformation<TItem, TUid> SetPropertyValue<TItem2, T>(TUid itemUid, Expression<Func<TItem2, T>> property, T value) where TItem2 : TItem
		{
			MemberExpression obj = ((property != null) ? LinqUtils.GetMemberExpression(property) : null);
			return Instance.TransformationChange(itemUid, typeof(TItem2), LinqUtils.FullNameOf(property), obj?.Member, value);
		}

		protected internal abstract IList<TItem> GetSubItems(TItem item);

		protected internal abstract TUid GetUid(TItem item);

		protected internal abstract bool IsHide(TItem item);

		protected internal abstract void SetHide(TItem parentItem, TItem item, bool hide = true);

		protected internal abstract TItem CreateCopy(TItem item);

		protected internal abstract TItem Clone(TItem item);

		protected internal virtual void DeleteItem(TItem item, TItem subItem)
		{
			GetSubItems(item).Remove(subItem);
		}

		protected internal virtual void RemoveItem(TItem item, TItem subItem)
		{
			GetSubItems(item).Remove(subItem);
		}

		protected internal virtual void AddItem(TItem item, TItem subItem)
		{
			GetSubItems(item).Add(subItem);
		}

		protected internal virtual void InsertItem(TItem item, int index, TItem subItem)
		{
			GetSubItems(item).Insert(index, subItem);
		}

		protected virtual BaseTransformation<TItem, TUid> TransformationCreate(TItem item, TItem originalItem)
		{
			TTransformation val = new TTransformation();
			val.Uid = val.GetUid(originalItem);
			val.Items.AddRange(val.AddMoveTransformations(item, originalItem));
			val.Items.AddRange(val.HideTransformations(item, originalItem));
			val.Items.AddRange(val.ChangeTransformations(item, originalItem, originalItem));
			return val.Items.Any() ? val : null;
		}

		protected virtual BaseTransformation<TItem, TUid> TransformationAdd(TUid itemUid, TItem item, TNullUid afterItem = default(TNullUid), TNullUid beforeItem = default(TNullUid))
		{
			TransformationAdd<TItem, TTransformation, TUid, TNullUid> transformationAdd = new TransformationAdd<TItem, TTransformation, TUid, TNullUid>();
			transformationAdd.Uid = itemUid;
			transformationAdd.AfterItem = afterItem;
			transformationAdd.BeforeItem = beforeItem;
			transformationAdd.SetItem(item);
			return transformationAdd;
		}

		protected virtual BaseTransformation<TItem, TUid> TransformationMove(TUid itemUid, TUid moveItemUid, TNullUid afterItem = default(TNullUid), TNullUid beforeItem = default(TNullUid))
		{
			return new TransformationMove<TItem, TTransformation, TUid, TNullUid>
			{
				Uid = itemUid,
				MoveItemUid = moveItemUid,
				AfterItem = afterItem,
				BeforeItem = beforeItem
			};
		}

		protected virtual BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
		{
			return new TransformationHide<TItem, TTransformation, TUid, TNullUid>
			{
				Uid = itemUid
			};
		}

		protected virtual BaseTransformation<TItem, TUid> TransformationChange(TUid itemUid, string propertyName, object value, bool localizable = false)
		{
			return new TransformationChange<TItem, TTransformation, TUid, TNullUid>
			{
				Uid = itemUid,
				PropertyName = propertyName,
				Localizable = localizable,
				Value = value
			};
		}

		protected virtual BaseTransformation<TItem, TUid> TransformationChange(TUid itemUid, Type type, string propertyName, object value, bool localizable = false)
		{
			return TransformationChange(itemUid, propertyName, value, localizable);
		}

		protected BaseTransformation<TItem, TUid> TransformationChange(TUid uid, string propName, MemberInfo member, object value)
		{
			return TransformationChange(uid, propName, value, member != null && member.IsDefined(typeof(LocalizableAttribute), inherit: true));
		}

		protected BaseTransformation<TItem, TUid> TransformationChange(TUid uid, Type type, string propName, MemberInfo member, object value)
		{
			return TransformationChange(uid, type, propName, value, member != null && member.IsDefined(typeof(LocalizableAttribute), inherit: true));
		}

		protected abstract TNullUid ConvertUid(TUid uid);

		protected internal virtual TItem FindItem(TItem viewItem, TItem item)
		{
			return FindItem(viewItem, GetUid(item));
		}

		protected internal virtual TItem FindItem(TItem viewItem, TItem item, out TItem container)
		{
			return FindItem(viewItem, GetUid(item), out container);
		}

		protected internal virtual TItem FindItem(TItem viewItem, TUid itemUid)
		{
			TItem container;
			return FindItem(viewItem, itemUid, out container);
		}

		protected internal virtual TItem FindItem(TItem viewItem, TUid itemUid, out TItem container)
		{
			container = null;
			if (EqualsItems(viewItem, ConvertUid(itemUid)))
			{
				return viewItem;
			}
			IList<TItem> subItems = GetSubItems(viewItem);
			if (subItems == null)
			{
				return null;
			}
			foreach (TItem item in subItems)
			{
				TItem val = FindItem(item, itemUid, out container);
				if (val != null)
				{
					if (container == null)
					{
						container = viewItem;
					}
					return val;
				}
			}
			return null;
		}

		protected IEnumerable<BaseTransformation<TItem, TUid>> AddMoveTransformations(TItem viewItem, TItem originalItem)
		{
			_003C_003Ec__DisplayClass38_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass38_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.originalItem = originalItem;
			CS_0024_003C_003E8__locals0.viewItem = viewItem;
			if (CS_0024_003C_003E8__locals0.viewItem == null || CS_0024_003C_003E8__locals0.originalItem == null)
			{
				return new TTransformation[0];
			}
			CS_0024_003C_003E8__locals0.localItems = GetSubItems(CS_0024_003C_003E8__locals0.viewItem) ?? new TItem[0];
			CS_0024_003C_003E8__locals0.subItems = CS_0024_003C_003E8__locals0.localItems.ToDictionary((TItem item) => item, delegate(TItem item)
			{
				TItem container;
				TItem val3 = CS_0024_003C_003E8__locals0._003C_003E4__this.FindItem(CS_0024_003C_003E8__locals0.originalItem, item, out container);
				return new
				{
					item2 = val3,
					isHide = (val3 == null || CS_0024_003C_003E8__locals0._003C_003E4__this.IsHide(val3)),
					container = container
				};
			});
			CS_0024_003C_003E8__locals0.previousItemUid = delegate(TItem item, bool skipNewItems)
			{
				int num3 = CS_0024_003C_003E8__locals0.localItems.IndexOf(item);
				while (num3 > 0 && skipNewItems && CS_0024_003C_003E8__locals0.subItems[CS_0024_003C_003E8__locals0.localItems[num3 - 1]].item2 == null)
				{
					num3--;
				}
				return (num3 <= 0) ? default(TNullUid) : CS_0024_003C_003E8__locals0._003C_003E4__this.ConvertUid(CS_0024_003C_003E8__locals0._003C_003E4__this.GetUid(CS_0024_003C_003E8__locals0.localItems[num3 - 1]));
			};
			CS_0024_003C_003E8__locals0.nextItemUid = delegate(TItem item, bool skipMovedItems)
			{
				int j;
				for (j = CS_0024_003C_003E8__locals0.localItems.IndexOf(item); j != -1 && j < CS_0024_003C_003E8__locals0.localItems.Count - 1 && (CS_0024_003C_003E8__locals0.subItems[CS_0024_003C_003E8__locals0.localItems[j + 1]].item2 == null || (skipMovedItems && CS_0024_003C_003E8__locals0.subItems[CS_0024_003C_003E8__locals0.localItems[j + 1]].item2 != null && (!CS_0024_003C_003E8__locals0._003C_003E4__this.EqualsItems(CS_0024_003C_003E8__locals0.viewItem, CS_0024_003C_003E8__locals0.subItems[CS_0024_003C_003E8__locals0.localItems[j + 1]].container) || !CS_0024_003C_003E8__locals0._003C_003E4__this.EqualsItems(CS_0024_003C_003E8__locals0.localItems[j + 1], CS_0024_003C_003E8__locals0.subItems[CS_0024_003C_003E8__locals0.localItems[j + 1]].item2)))); j++)
				{
				}
				return (j == -1 || j >= CS_0024_003C_003E8__locals0.localItems.Count - 1) ? default(TNullUid) : CS_0024_003C_003E8__locals0._003C_003E4__this.ConvertUid(CS_0024_003C_003E8__locals0._003C_003E4__this.GetUid(CS_0024_003C_003E8__locals0.localItems[j + 1]));
			};
			TItem val = FindItem(CS_0024_003C_003E8__locals0.originalItem, CS_0024_003C_003E8__locals0.viewItem);
			CS_0024_003C_003E8__locals0.originalrootItems = ((val != null) ? GetSubItems(val) : null);
			CS_0024_003C_003E8__locals0.originalrootItems = CS_0024_003C_003E8__locals0.originalrootItems ?? new TItem[0];
			CS_0024_003C_003E8__locals0.hideItems = ((val != null) ? CS_0024_003C_003E8__locals0.originalrootItems.Where(delegate(TItem item)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass38_1();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals0.item = item;
				return CS_0024_003C_003E8__locals0.localItems.All((TItem i) => !CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.EqualsItems(i, CS_0024_003C_003E8__locals0.item));
			}).ToArray() : new TItem[0]);
			CS_0024_003C_003E8__locals0.movedItems = new List<TItem>();
			CS_0024_003C_003E8__locals0.movedOriginalItems = new List<TItem>();
			CS_0024_003C_003E8__locals0.previousItemUidTest = delegate(TItem item1, TItem item2)
			{
				int num = CS_0024_003C_003E8__locals0.localItems.IndexOf(item1);
				bool flag = false;
				while (num > 0 && CS_0024_003C_003E8__locals0.movedItems.Contains(CS_0024_003C_003E8__locals0.localItems[num - 1]))
				{
					num--;
					flag = true;
				}
				TItem val2 = ((num > 0) ? CS_0024_003C_003E8__locals0.localItems[num - 1] : null);
				if (val2 == null && flag)
				{
					return false;
				}
				int num2 = CS_0024_003C_003E8__locals0.originalrootItems.IndexOf(item2);
				while (num2 > 0 && (CS_0024_003C_003E8__locals0.hideItems.Contains(CS_0024_003C_003E8__locals0.originalrootItems[num2 - 1]) || CS_0024_003C_003E8__locals0.movedOriginalItems.Contains(CS_0024_003C_003E8__locals0.originalrootItems[num2 - 1])))
				{
					num2--;
				}
				TItem v = ((num2 > 0) ? CS_0024_003C_003E8__locals0.originalrootItems[num2 - 1] : null);
				return !CS_0024_003C_003E8__locals0._003C_003E4__this.EqualsItems(val2, v);
			};
			CS_0024_003C_003E8__locals0.viewItemUid = GetUid(CS_0024_003C_003E8__locals0.viewItem);
			return CS_0024_003C_003E8__locals0.subItems.Where(t => t.Value.item2 != null && (!CS_0024_003C_003E8__locals0._003C_003E4__this.EqualsItems(CS_0024_003C_003E8__locals0.viewItem, t.Value.container) || CS_0024_003C_003E8__locals0.previousItemUidTest(t.Key, t.Value.item2))).Select(t =>
			{
				CS_0024_003C_003E8__locals0.movedItems.Add(t.Key);
				CS_0024_003C_003E8__locals0.movedOriginalItems.Add(t.Value.item2);
				return CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationMove(CS_0024_003C_003E8__locals0.viewItemUid, CS_0024_003C_003E8__locals0._003C_003E4__this.GetUid(t.Key), CS_0024_003C_003E8__locals0.previousItemUid(t.Key, arg2: true), CS_0024_003C_003E8__locals0.nextItemUid(t.Key, arg2: true));
			}).Union(CS_0024_003C_003E8__locals0.subItems.Where(t => t.Value.isHide).Select(t =>
			{
				CS_0024_003C_003E8__locals0.movedItems.Add(t.Key);
				return CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationAdd(CS_0024_003C_003E8__locals0.viewItemUid, t.Key, CS_0024_003C_003E8__locals0.previousItemUid(t.Key, arg2: false), CS_0024_003C_003E8__locals0.nextItemUid(t.Key, arg2: false));
			}))
				.Union(CS_0024_003C_003E8__locals0.subItems.SelectMany(t => CS_0024_003C_003E8__locals0._003C_003E4__this.AddMoveTransformations(t.Key, CS_0024_003C_003E8__locals0.originalItem)))
				.ToArray();
		}

		protected IEnumerable<BaseTransformation<TItem, TUid>> HideTransformations(TItem viewItem, TItem originalItem)
		{
			_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass39_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.viewItem = viewItem;
			if (CS_0024_003C_003E8__locals0.viewItem == null || originalItem == null)
			{
				return new TTransformation[0];
			}
			var source = (from item in GetSubItems(originalItem) ?? new TItem[0]
				where !CS_0024_003C_003E8__locals0._003C_003E4__this.IsHide(item)
				select new
				{
					item = item,
					item2 = CS_0024_003C_003E8__locals0._003C_003E4__this.FindItem(CS_0024_003C_003E8__locals0.viewItem, item)
				}).ToArray();
			return (from t in source
				where t.item2 == null || CS_0024_003C_003E8__locals0._003C_003E4__this.IsHide(t.item2)
				select CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationHide(CS_0024_003C_003E8__locals0._003C_003E4__this.GetUid(t.item))).Union(source.SelectMany(t => CS_0024_003C_003E8__locals0._003C_003E4__this.HideTransformations(CS_0024_003C_003E8__locals0.viewItem, t.item))).ToArray();
		}

		private IEnumerable<PropertyGrouping> GetPropertyGroupings(PropertyInfo prop)
		{
			object[] customAttributes = prop.GetCustomAttributes(typeof(ChangeablePropertyAttribute), inherit: true);
			if (!customAttributes.Any())
			{
				return null;
			}
			return PropertyGrouping.Create((from p in customAttributes.Cast<ChangeablePropertyAttribute>().SelectMany((ChangeablePropertyAttribute a) => a.SubProperties ?? new string[1] { "" }).ToList()
				select p.Split('.')).ToArray());
		}

		protected virtual IEnumerable<BaseTransformation<TItem, TUid>> ChangeTransformations(TItem viewItem, TItem originalItem, TItem originalItemRoot)
		{
			_003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass41_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.viewItem = viewItem;
			CS_0024_003C_003E8__locals0.originalItem = originalItem;
			CS_0024_003C_003E8__locals0.originalItemRoot = originalItemRoot;
			IEnumerable<BaseTransformation<TItem, TUid>> first = new BaseTransformation<TItem, TUid>[0];
			if (CS_0024_003C_003E8__locals0.originalItem != null)
			{
				_003C_003Ec__DisplayClass41_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass41_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.type = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.viewItem.GetType();
				first = CS_0024_003C_003E8__locals1.type.GetProperties().SelectMany(delegate(PropertyInfo prop)
				{
					IEnumerable<PropertyGrouping> propertyGroupings = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.GetPropertyGroupings(prop);
					if (propertyGroupings == null)
					{
						return new BaseTransformation<TItem, TUid>[0];
					}
					object value = prop.GetValue(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.viewItem, null);
					object value2 = prop.GetValue(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.originalItem, null);
					return CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.PropertyChangeTransformations(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.GetUid(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.viewItem), CS_0024_003C_003E8__locals1.type, prop.Name, prop, value, value2, propertyGroupings);
				});
			}
			return first.Union((GetSubItems(CS_0024_003C_003E8__locals0.viewItem) ?? new TItem[0]).SelectMany((TItem item) => CS_0024_003C_003E8__locals0._003C_003E4__this.ChangeTransformations(item, CS_0024_003C_003E8__locals0._003C_003E4__this.FindItem(CS_0024_003C_003E8__locals0.originalItemRoot, item), CS_0024_003C_003E8__locals0.originalItemRoot))).ToArray();
		}

		protected internal virtual bool EqualsItems(TItem v1, TNullUid v2)
		{
			if (v1 != null)
			{
				return EqualsItems(ConvertUid(GetUid(v1)), v2);
			}
			return v2 == null;
		}

		protected internal virtual bool EqualsItems(TItem v1, TItem v2)
		{
			if (v1 == null || v2 == null)
			{
				return v1 == v2;
			}
			return EqualsItems(ConvertUid(GetUid(v1)), ConvertUid(GetUid(v2)));
		}

		protected internal virtual bool EqualsItems(TNullUid v1, TNullUid v2)
		{
			return Equals(v1, v2);
		}

		private new static bool Equals(object v1, object v2)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (v1 != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return v2 == null;
				case 1:
					return v1.Equals(v2);
				}
			}
		}

		private IEnumerable<BaseTransformation<TItem, TUid>> PropertyChangeTransformations(TUid uid, Type type, string propName, MemberInfo member, object obj, object originalObj, IEnumerable<PropertyGrouping> propertyGrouping)
		{
			_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass47_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.uid = uid;
			CS_0024_003C_003E8__locals0.type = type;
			CS_0024_003C_003E8__locals0.propName = propName;
			CS_0024_003C_003E8__locals0.obj = obj;
			CS_0024_003C_003E8__locals0.originalObj = originalObj;
			CS_0024_003C_003E8__locals0.member = member;
			if (CS_0024_003C_003E8__locals0.obj == null && CS_0024_003C_003E8__locals0.originalObj == null)
			{
				return new BaseTransformation<TItem, TUid>[0];
			}
			if (CS_0024_003C_003E8__locals0.obj == null || CS_0024_003C_003E8__locals0.originalObj == null)
			{
				return new BaseTransformation<TItem, TUid>[1] { TransformationChange(CS_0024_003C_003E8__locals0.uid, CS_0024_003C_003E8__locals0.type, CS_0024_003C_003E8__locals0.propName, CS_0024_003C_003E8__locals0.member, CS_0024_003C_003E8__locals0.obj) };
			}
			CS_0024_003C_003E8__locals0.propertiesContainer = CS_0024_003C_003E8__locals0.obj as IPropertiesContainer;
			if (CS_0024_003C_003E8__locals0.propertiesContainer != null)
			{
				_003C_003Ec__DisplayClass47_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass47_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.originalPropertiesContainer = (IPropertiesContainer)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.originalObj;
				return CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propertiesContainer.GetProperties().Union(CS_0024_003C_003E8__locals1.originalPropertiesContainer.GetProperties()).SelectMany(delegate(string prop)
				{
					object obj2 = (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propertiesContainer.GetProperties().Contains(prop) ? CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propertiesContainer.GetPropertyValue(prop, null) : TransformationChangeRemoveValue.Instance);
					object propertyValue = CS_0024_003C_003E8__locals1.originalPropertiesContainer.GetPropertyValue(prop, null);
					return (!Equals(obj2, propertyValue)) ? new BaseTransformation<TItem, TUid>[1] { CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.TransformationChange(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.uid, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345417984) + prop, null, obj2) } : new BaseTransformation<TItem, TUid>[0];
				})
					.ToArray();
			}
			return propertyGrouping.SelectMany(delegate(PropertyGrouping pg)
			{
				if (string.IsNullOrEmpty(pg.Property))
				{
					if (!Equals(CS_0024_003C_003E8__locals0.obj, CS_0024_003C_003E8__locals0.originalObj))
					{
						return new BaseTransformation<TItem, TUid>[1] { CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationChange(CS_0024_003C_003E8__locals0.uid, CS_0024_003C_003E8__locals0.type, CS_0024_003C_003E8__locals0.propName, CS_0024_003C_003E8__locals0.member, CS_0024_003C_003E8__locals0.obj) };
					}
					return new BaseTransformation<TItem, TUid>[0];
				}
				PropertyInfo reflectionProperty = CS_0024_003C_003E8__locals0.obj.GetType().GetReflectionProperty(pg.Property);
				return (!(reflectionProperty == null)) ? CS_0024_003C_003E8__locals0._003C_003E4__this.PropertyChangeTransformations(CS_0024_003C_003E8__locals0.uid, CS_0024_003C_003E8__locals0.type, CS_0024_003C_003E8__locals0.propName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488875761) + pg.Property, reflectionProperty, reflectionProperty.GetValue(CS_0024_003C_003E8__locals0.obj, null), reflectionProperty.GetValue(CS_0024_003C_003E8__locals0.originalObj, null), pg.SubProperties) : Enumerable.Empty<BaseTransformation<TItem, TUid>>();
			}).ToArray();
		}

		public override IEnumerable<string> GetLocalizableStrings()
		{
			_003C_003Ec__DisplayClass48_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass48_0();
			CS_0024_003C_003E8__locals0.allStrings = new List<string>();
			IEnumerable<string> localizableStrings = base.GetLocalizableStrings();
			if (localizableStrings != null)
			{
				CS_0024_003C_003E8__locals0.allStrings.AddRange(localizableStrings);
			}
			foreach (BaseTransformation<TItem, TUid> item in items)
			{
				IEnumerable<string> localizableStrings2 = item.GetLocalizableStrings();
				if (localizableStrings2 == null)
				{
					continue;
				}
				foreach (string item2 in localizableStrings2.Where((string s) => !CS_0024_003C_003E8__locals0.allStrings.Contains(s)))
				{
					CS_0024_003C_003E8__locals0.allStrings.Add(item2);
				}
			}
			return CS_0024_003C_003E8__locals0.allStrings;
		}

		public override void ApplyLocalization()
		{
			//Discarded unreachable code: IL_0032, IL_003c, IL_00ce, IL_00e1, IL_00f0
			int num = 2;
			int num2 = num;
			List<BaseTransformation<TItem, TUid>>.Enumerator enumerator = default(List<BaseTransformation<TItem, TUid>>.Enumerator);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
								{
									num3 = 1;
								}
								goto IL_0040;
							}
							goto IL_007c;
							IL_007c:
							enumerator.Current.ApplyLocalization();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
							{
								num3 = 0;
							}
							goto IL_0040;
							IL_0040:
							switch (num3)
							{
							case 2:
								goto IL_007c;
							case 1:
								return;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 2:
					base.ApplyLocalization();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					enumerator = items.GetEnumerator();
					num2 = 3;
					break;
				}
			}
		}

		protected Transformation()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool BeGPE9WUQUY6SytGAnml()
		{
			return d5rAgUWUfaQyEB3X0WWY == null;
		}

		internal static object KsP0xuWUCQr1ceqAyDv7()
		{
			return d5rAgUWUfaQyEB3X0WWY;
		}
	}
	[Serializable]
	public abstract class Transformation<TItem, TTransformation, TUid, TNullUid, TAdd, TMove, THide, TChange> : Transformation<TItem, TTransformation, TUid, TNullUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()where TAdd : TransformationAdd<TItem, TTransformation, TUid, TNullUid>, new()where TMove : TransformationMove<TItem, TTransformation, TUid, TNullUid>, new()where THide : TransformationHide<TItem, TTransformation, TUid, TNullUid>, new()where TChange : TransformationChange<TItem, TTransformation, TUid, TNullUid>, new()
	{
		private static object yvmoTnWUvrutc5jl9YTT;

		protected override BaseTransformation<TItem, TUid> TransformationAdd(TUid itemUid, TItem item, TNullUid afterItem = default(TNullUid), TNullUid beforeItem = default(TNullUid))
		{
			TAdd val = new TAdd();
			val.Uid = itemUid;
			val.AfterItem = afterItem;
			val.BeforeItem = beforeItem;
			val.SetItem(item);
			return val;
		}

		protected override BaseTransformation<TItem, TUid> TransformationMove(TUid itemUid, TUid moveItemUid, TNullUid afterItem = default(TNullUid), TNullUid beforeItem = default(TNullUid))
		{
			return new TMove
			{
				Uid = itemUid,
				MoveItemUid = moveItemUid,
				AfterItem = afterItem,
				BeforeItem = beforeItem
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
		{
			return new THide
			{
				Uid = itemUid
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationChange(TUid itemUid, string propertyName, object value, bool localizable = false)
		{
			return new TChange
			{
				Uid = itemUid,
				PropertyName = propertyName,
				Localizable = localizable,
				Value = value
			};
		}

		protected Transformation()
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

		internal static bool lwlh2YWU8AoQHvZmZEZN()
		{
			return yvmoTnWUvrutc5jl9YTT == null;
		}

		internal static object mKA8FSWUZQbFEGU7cPNR()
		{
			return yvmoTnWUvrutc5jl9YTT;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Struct
{
	[Serializable]
	public abstract class Transformation<TItem, TTransformation, TUid> : Transformation<TItem, TTransformation, TUid, TUid?> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : struct
	{
		private static object aMSPnmWUpvFPSTw3QR37;

		protected override TUid? ConvertUid(TUid uid)
		{
			return uid;
		}

		protected override BaseTransformation<TItem, TUid> TransformationAdd(TUid itemUid, TItem item, TUid? afterItem = null, TUid? beforeItem = null)
		{
			TransformationAdd<TItem, TTransformation, TUid> transformationAdd = new TransformationAdd<TItem, TTransformation, TUid>();
			transformationAdd.Uid = itemUid;
			transformationAdd.AfterItem = afterItem;
			transformationAdd.BeforeItem = beforeItem;
			transformationAdd.SetItem(item);
			return transformationAdd;
		}

		protected override BaseTransformation<TItem, TUid> TransformationMove(TUid itemUid, TUid moveItemUid, TUid? afterItem = null, TUid? beforeItem = null)
		{
			return new TransformationMove<TItem, TTransformation, TUid>
			{
				Uid = itemUid,
				MoveItemUid = moveItemUid,
				AfterItem = afterItem,
				BeforeItem = beforeItem
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
		{
			return new TransformationHide<TItem, TTransformation, TUid>
			{
				Uid = itemUid
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationChange(TUid itemUid, string propertyName, object value, bool localizable = false)
		{
			return new TransformationChange<TItem, TTransformation, TUid>
			{
				Uid = itemUid,
				PropertyName = propertyName,
				Localizable = localizable,
				Value = value
			};
		}

		protected Transformation()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool zlgygmWUa2ZE1iSk3p75()
		{
			return aMSPnmWUpvFPSTw3QR37 == null;
		}

		internal static object kMynBmWUD4JHbDIsQCog()
		{
			return aMSPnmWUpvFPSTw3QR37;
		}
	}
	[Serializable]
	public abstract class Transformation<TItem, TTransformation, TUid, TSaveItem, TAdd, TMove, THide, TChange> : Transformation<TItem, TTransformation, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : struct where TAdd : TransformationAdd<TItem, TTransformation, TUid, TSaveItem>, new()where TMove : TransformationMove<TItem, TTransformation, TUid>, new()where THide : TransformationHide<TItem, TTransformation, TUid>, new()where TChange : TransformationChange<TItem, TTransformation, TUid>, new()
	{
		internal static object ikmnWJWUtlgw0RPRtaD4;

		protected override BaseTransformation<TItem, TUid> TransformationAdd(TUid itemUid, TItem item, TUid? afterItem = null, TUid? beforeItem = null)
		{
			TAdd val = new TAdd();
			val.Uid = itemUid;
			val.AfterItem = afterItem;
			val.BeforeItem = beforeItem;
			val.SetItem(item);
			return val;
		}

		protected override BaseTransformation<TItem, TUid> TransformationMove(TUid itemUid, TUid moveItemUid, TUid? afterItem = null, TUid? beforeItem = null)
		{
			return new TMove
			{
				Uid = itemUid,
				MoveItemUid = moveItemUid,
				AfterItem = afterItem,
				BeforeItem = beforeItem
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
		{
			return new THide
			{
				Uid = itemUid
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationChange(TUid itemUid, string propertyName, object value, bool localizable = false)
		{
			return new TChange
			{
				Uid = itemUid,
				PropertyName = propertyName,
				Localizable = localizable,
				Value = value
			};
		}

		protected Transformation()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool wcjq1VWUw3Y9FqUj1JAX()
		{
			return ikmnWJWUtlgw0RPRtaD4 == null;
		}

		internal static object rOJwIFWU4iMMXktkvqBP()
		{
			return ikmnWJWUtlgw0RPRtaD4;
		}
	}
	[Serializable]
	public abstract class Transformation<TItem, TTransformation, TUid, TAdd, TMove, THide, TChange> : Transformation<TItem, TTransformation, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : struct where TAdd : TransformationAdd<TItem, TTransformation, TUid>, new()where TMove : TransformationMove<TItem, TTransformation, TUid>, new()where THide : TransformationHide<TItem, TTransformation, TUid>, new()where TChange : TransformationChange<TItem, TTransformation, TUid>, new()
	{
		private static object shXT3bWU6FnfhQTfaoGt;

		protected override BaseTransformation<TItem, TUid> TransformationAdd(TUid itemUid, TItem item, TUid? afterItem = null, TUid? beforeItem = null)
		{
			TAdd val = new TAdd();
			val.Uid = itemUid;
			val.AfterItem = afterItem;
			val.BeforeItem = beforeItem;
			val.SetItem(item);
			return val;
		}

		protected override BaseTransformation<TItem, TUid> TransformationMove(TUid itemUid, TUid moveItemUid, TUid? afterItem = null, TUid? beforeItem = null)
		{
			return new TMove
			{
				Uid = itemUid,
				MoveItemUid = moveItemUid,
				AfterItem = afterItem,
				BeforeItem = beforeItem
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
		{
			return new THide
			{
				Uid = itemUid
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationChange(TUid itemUid, string propertyName, object value, bool localizable = false)
		{
			return new TChange
			{
				Uid = itemUid,
				PropertyName = propertyName,
				Localizable = localizable,
				Value = value
			};
		}

		protected Transformation()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool v7c8NpWUHdLBIuaZ4Mqt()
		{
			return shXT3bWU6FnfhQTfaoGt == null;
		}

		internal static object rv95eSWUATcy08WD7wv4()
		{
			return shXT3bWU6FnfhQTfaoGt;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Class
{
	[Serializable]
	public abstract class Transformation<TItem, TTransformation, TUid> : Transformation<TItem, TTransformation, TUid, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : class
	{
		internal static object OLAYiFWULZBwLsVxFJ50;

		protected override TUid ConvertUid(TUid uid)
		{
			return uid;
		}

		protected override BaseTransformation<TItem, TUid> TransformationAdd(TUid itemUid, TItem item, TUid afterItem = null, TUid beforeItem = null)
		{
			TransformationAdd<TItem, TTransformation, TUid> transformationAdd = new TransformationAdd<TItem, TTransformation, TUid>();
			transformationAdd.Uid = itemUid;
			transformationAdd.AfterItem = afterItem;
			transformationAdd.BeforeItem = beforeItem;
			transformationAdd.SetItem(item);
			return transformationAdd;
		}

		protected override BaseTransformation<TItem, TUid> TransformationMove(TUid itemUid, TUid moveItemUid, TUid afterItem = null, TUid beforeItem = null)
		{
			return new TransformationMove<TItem, TTransformation, TUid>
			{
				Uid = itemUid,
				MoveItemUid = moveItemUid,
				AfterItem = afterItem,
				BeforeItem = beforeItem
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
		{
			return new TransformationHide<TItem, TTransformation, TUid>
			{
				Uid = itemUid
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationChange(TUid itemUid, string propertyName, object value, bool localizable = false)
		{
			return new TransformationChange<TItem, TTransformation, TUid>
			{
				Uid = itemUid,
				PropertyName = propertyName,
				Localizable = localizable,
				Value = value
			};
		}

		protected Transformation()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool TEoIjaWUUrU876ih3GTA()
		{
			return OLAYiFWULZBwLsVxFJ50 == null;
		}

		internal static object afdt73WUsayb2FTafv8V()
		{
			return OLAYiFWULZBwLsVxFJ50;
		}
	}
	[Serializable]
	public abstract class Transformation<TItem, TTransformation, TUid, TAdd, TMove, THide, TChange> : Transformation<TItem, TTransformation, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : class where TAdd : TransformationAdd<TItem, TTransformation, TUid>, new()where TMove : TransformationMove<TItem, TTransformation, TUid>, new()where THide : TransformationHide<TItem, TTransformation, TUid>, new()where TChange : TransformationChange<TItem, TTransformation, TUid>, new()
	{
		internal static object J1ZPL0WUcfjNu2M8U2xO;

		protected override BaseTransformation<TItem, TUid> TransformationAdd(TUid itemUid, TItem item, TUid afterItem = null, TUid beforeItem = null)
		{
			TAdd val = new TAdd();
			val.Uid = itemUid;
			val.AfterItem = afterItem;
			val.BeforeItem = beforeItem;
			val.SetItem(item);
			return val;
		}

		protected override BaseTransformation<TItem, TUid> TransformationMove(TUid itemUid, TUid moveItemUid, TUid afterItem = null, TUid beforeItem = null)
		{
			return new TMove
			{
				Uid = itemUid,
				MoveItemUid = moveItemUid,
				AfterItem = afterItem,
				BeforeItem = beforeItem
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
		{
			return new THide
			{
				Uid = itemUid
			};
		}

		protected override BaseTransformation<TItem, TUid> TransformationChange(TUid itemUid, string propertyName, object value, bool localizable = false)
		{
			return new TChange
			{
				Uid = itemUid,
				PropertyName = propertyName,
				Localizable = localizable,
				Value = value
			};
		}

		protected Transformation()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool bmhXBqWUzMGnsVy3Y3Kk()
		{
			return J1ZPL0WUcfjNu2M8U2xO == null;
		}

		internal static object io8sYdWsFbxQeYK6j9VT()
		{
			return J1ZPL0WUcfjNu2M8U2xO;
		}
	}
}
