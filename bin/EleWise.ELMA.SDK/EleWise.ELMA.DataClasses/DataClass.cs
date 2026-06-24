using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events.Publication;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services.FindComponent;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.DataClasses;

[DebuggerTypeProxy(typeof(DebugView))]
[DataContract]
public class DataClass : IDataClass, IEquatable<DataClass>
{
	private sealed class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly DataClass dataClass;

		internal static object scaQIY8JvycqIlm1eSV2;

		public DataClassMetadata[] Includes => dataClass.GetIncludes(onlyFilled: true).ToArray();

		public (string Name, object Value)[] Properties => dataClass.data.Values.Where((ValueContainer.DataContainer v) => v.Initialized).SelectMany(delegate(ValueContainer.DataContainer a)
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.a = a;
			return CS_0024_003C_003E8__locals0.a.values.Select((KeyValuePair<Guid, IPropertyValueContainerCast> b) => (CS_0024_003C_003E8__locals0._003C_003E4__this.Name(CS_0024_003C_003E8__locals0.a.Metadata, b.Key), b.Value.Get(CS_0024_003C_003E8__locals0._003C_003E4__this.dataClass)));
		}).ToArray();

		public DebugView(DataClass dataClass)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			IXruol8JuTVvDOv0sga9();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					this.dataClass = dataClass;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		private string Name(DataClassMetadata metadata, Guid propertyUid)
		{
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass6_.propertyUid = propertyUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return null;
				}
				PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CName_003Eb__0);
				if (propertyMetadata == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return (string)zr4HL68JIJxFymj04Mp0(propertyMetadata);
			}
		}

		internal static void IXruol8JuTVvDOv0sga9()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool KGgiAW8J8EZumGvHlVGI()
		{
			return scaQIY8JvycqIlm1eSV2 == null;
		}

		internal static DebugView wOiFLK8JZ8PTXZgifAxK()
		{
			return (DebugView)scaQIY8JvycqIlm1eSV2;
		}

		internal static object zr4HL68JIJxFymj04Mp0(object P_0)
		{
			return ((NamedMetadata)P_0).Name;
		}
	}

	private class DataClassCollectionPropertyValueContainer : IPropertyDefaultValueContainer
	{
		private class NestedDefaultValueContainer : IPropertyValueContainerCast, IPropertyValueContainer, IPropertyDefaultValueContainer
		{
			private readonly object dataClassCollectionPropertyValueContainer;

			private IEnumerable<DataClass> value;

			private object castedContainer;

			private static object ns8yCMZ1Bt7yfl4EgrXj;

			Type IPropertyValueContainer.PropertyType
			{
				get
				{
					int num = 1;
					int num2 = num;
					object obj;
					while (true)
					{
						switch (num2)
						{
						case 1:
						{
							object obj2 = castedContainer;
							if (obj2 == null)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num2 = 0;
								}
								continue;
							}
							obj = HTsSy1Z1h2WZcU9vaUvI(obj2);
							goto IL_005a;
						}
						default:
							obj = null;
							goto IL_005a;
						case 2:
							{
								obj = TypeOf<ICollection<DataClass>>.Raw;
								break;
							}
							IL_005a:
							if (obj == null)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
								{
									num2 = 2;
								}
								continue;
							}
							break;
						}
						break;
					}
					return (Type)obj;
				}
			}

			public NestedDefaultValueContainer(DataClassCollectionPropertyValueContainer dataClassCollectionPropertyValueContainer)
			{
				//Discarded unreachable code: IL_003a, IL_003f
				SingletonReader.JJCZtPuTvSt();
				value = new List<DataClass>();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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
					this.dataClassCollectionPropertyValueContainer = dataClassCollectionPropertyValueContainer;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num = 0;
					}
				}
			}

			object IPropertyValueContainer.Get(object obj)
			{
				int num = 2;
				int num2 = num;
				object obj2;
				while (true)
				{
					switch (num2)
					{
					case 2:
					{
						object obj3 = castedContainer;
						if (obj3 == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						obj2 = ((IPropertyValueContainer)obj3).Get(obj);
						goto IL_005b;
					}
					case 1:
						obj2 = null;
						goto IL_005b;
					default:
						{
							obj2 = value;
							break;
						}
						IL_005b:
						if (obj2 != null)
						{
							break;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				return obj2;
			}

			void IPropertyValueContainer.Set(object obj, object value)
			{
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						e2v0vuZ1bjsfTqhTrN4t(castedContainer, obj, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						if (castedContainer != null)
						{
							num2 = 2;
							break;
						}
						this.value = (IEnumerable<DataClass>)value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 1;
						}
						break;
					case 0:
						return;
					case 1:
						return;
					}
				}
			}

			IPropertyValueContainer<T> IPropertyValueContainerCast.Cast<T>()
			{
				if (castedContainer == null)
				{
					Type type = typeof(T).GetGenericArguments()[0];
					((DataClassCollectionPropertyValueContainer)dataClassCollectionPropertyValueContainer).propertyDefaultValueContainer = (IPropertyDefaultValueContainer)Activator.CreateInstance(typeof(PropertyCollectionValueContainer<, >).MakeGenericType(typeof(T), TypeOf.List.Raw.MakeGenericType(type)));
					IPropertyValueContainer<T> propertyValueContainer = (IPropertyValueContainer<T>)((IPropertyDefaultValueContainer)((DataClassCollectionPropertyValueContainer)dataClassCollectionPropertyValueContainer).propertyDefaultValueContainer).Initialize();
					if (value != null)
					{
						IList list = (IList)(object)propertyValueContainer.Get(null);
						foreach (DataClass item in value)
						{
							list.Add(item?.As(type));
						}
					}
					else
					{
						propertyValueContainer.Set(null, null);
					}
					castedContainer = propertyValueContainer;
					value = null;
				}
				return (IPropertyValueContainer<T>)castedContainer;
			}

			IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
			{
				return new NestedDefaultValueContainer((DataClassCollectionPropertyValueContainer)dataClassCollectionPropertyValueContainer);
			}

			internal static bool RD53VWZ1W3r6FdHIYMFj()
			{
				return ns8yCMZ1Bt7yfl4EgrXj == null;
			}

			internal static NestedDefaultValueContainer LUNPQSZ1omebrm5rRR2u()
			{
				return (NestedDefaultValueContainer)ns8yCMZ1Bt7yfl4EgrXj;
			}

			internal static void e2v0vuZ1bjsfTqhTrN4t(object P_0, object P_1, object P_2)
			{
				((IPropertyValueContainer)P_0).Set(P_1, P_2);
			}

			internal static Type HTsSy1Z1h2WZcU9vaUvI(object P_0)
			{
				return ((IPropertyValueContainer)P_0).PropertyType;
			}
		}

		private object propertyDefaultValueContainer;

		internal static object hwS85r8JVoy9rw9Ill1x;

		public DataClassCollectionPropertyValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			aSJyem8JRxUcvhYrieEN();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					propertyDefaultValueContainer = new NestedDefaultValueContainer(this);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return (IPropertyValueContainer)srVh8q8JqkgP9vuSK3TC(propertyDefaultValueContainer);
		}

		internal static void aSJyem8JRxUcvhYrieEN()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool tJiQOx8JSorbkvsV1dbn()
		{
			return hwS85r8JVoy9rw9Ill1x == null;
		}

		internal static DataClassCollectionPropertyValueContainer m8cGjo8JiGuQva2EfxIF()
		{
			return (DataClassCollectionPropertyValueContainer)hwS85r8JVoy9rw9Ill1x;
		}

		internal static object srVh8q8JqkgP9vuSK3TC(object P_0)
		{
			return ((IPropertyDefaultValueContainer)P_0).Initialize();
		}
	}

	private class DataClassPropertyValueContainer : IPropertyDefaultValueContainer
	{
		private class NestedDefaultValueContainer : IPropertyValueContainerCast, IPropertyValueContainer, IPropertyDefaultValueContainer
		{
			private readonly object dataClassPropertyValueContainer;

			private object value;

			private object castedContainer;

			private static object EQXokPZ1GnwIROWK6Y2O;

			Type IPropertyValueContainer.PropertyType
			{
				get
				{
					int num = 2;
					int num2 = num;
					object obj;
					while (true)
					{
						switch (num2)
						{
						case 2:
						{
							object obj2 = castedContainer;
							if (obj2 == null)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num2 = 1;
								}
								continue;
							}
							obj = m8n4MfZ1v0bsVaYePBdR(obj2);
							goto IL_005f;
						}
						case 1:
							obj = null;
							goto IL_005f;
						default:
							{
								obj = TypeOf<DataClass>.Raw;
								break;
							}
							IL_005f:
							if (obj == null)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							break;
						}
						break;
					}
					return (Type)obj;
				}
			}

			public NestedDefaultValueContainer(DataClassPropertyValueContainer dataClassPropertyValueContainer)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				maYRyDZ1QW60IABt4CsR();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						this.dataClassPropertyValueContainer = dataClassPropertyValueContainer;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}

			object IPropertyValueContainer.Get(object obj)
			{
				int num = 2;
				int num2 = num;
				object obj2;
				while (true)
				{
					switch (num2)
					{
					case 2:
					{
						object obj3 = castedContainer;
						if (obj3 == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						obj2 = ((IPropertyValueContainer)obj3).Get(obj);
						goto IL_0060;
					}
					case 1:
						obj2 = null;
						goto IL_0060;
					default:
						{
							obj2 = value;
							break;
						}
						IL_0060:
						if (obj2 != null)
						{
							break;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				return obj2;
			}

			void IPropertyValueContainer.Set(object obj, object value)
			{
				//Discarded unreachable code: IL_0035
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						return;
					case 4:
						SZvIWiZ1CPuyywGmyvcP(castedContainer, obj, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						if (castedContainer == null)
						{
							num2 = 2;
							break;
						}
						goto case 4;
					case 0:
						return;
					case 2:
						this.value = (DataClass)value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			IPropertyValueContainer<T> IPropertyValueContainerCast.Cast<T>()
			{
				if (castedContainer == null)
				{
					((DataClassPropertyValueContainer)dataClassPropertyValueContainer).propertyDefaultValueContainer = new PropertyValueContainer<T>(null);
					castedContainer = new PropertyValueContainer<T>(((DataClass)value)?.As(typeof(T)));
					value = null;
				}
				return (IPropertyValueContainer<T>)castedContainer;
			}

			IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
			{
				return new NestedDefaultValueContainer((DataClassPropertyValueContainer)dataClassPropertyValueContainer);
			}

			internal static void maYRyDZ1QW60IABt4CsR()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool K09qIjZ1Ev2rC0tv1qW4()
			{
				return EQXokPZ1GnwIROWK6Y2O == null;
			}

			internal static NestedDefaultValueContainer P6lsGpZ1fndJ3ZZP7d0p()
			{
				return (NestedDefaultValueContainer)EQXokPZ1GnwIROWK6Y2O;
			}

			internal static void SZvIWiZ1CPuyywGmyvcP(object P_0, object P_1, object P_2)
			{
				((IPropertyValueContainer)P_0).Set(P_1, P_2);
			}

			internal static Type m8n4MfZ1v0bsVaYePBdR(object P_0)
			{
				return ((IPropertyValueContainer)P_0).PropertyType;
			}
		}

		private object propertyDefaultValueContainer;

		internal static object h37bNR8JKNsAXUnwOyL9;

		public DataClassPropertyValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			esmAye8JkYPSMuaeM2sx();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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
				propertyDefaultValueContainer = new NestedDefaultValueContainer(this);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num = 1;
				}
			}
		}

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return (IPropertyValueContainer)lHWhvU8JnncDlfradVPN(propertyDefaultValueContainer);
		}

		internal static void esmAye8JkYPSMuaeM2sx()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool I45rAA8JX3o3CRFKmWm6()
		{
			return h37bNR8JKNsAXUnwOyL9 == null;
		}

		internal static DataClassPropertyValueContainer CZ4mGH8JThWcbHVpZPhK()
		{
			return (DataClassPropertyValueContainer)h37bNR8JKNsAXUnwOyL9;
		}

		internal static object lHWhvU8JnncDlfradVPN(object P_0)
		{
			return ((IPropertyDefaultValueContainer)P_0).Initialize();
		}
	}

	private class PropertyAnyTypeValueContainer : IPropertyDefaultValueContainer
	{
		private class NestedDefaultValueContainer : IPropertyValueContainerCast, IPropertyValueContainer, IPropertyDefaultValueContainer
		{
			private readonly object propertyAnyTypeValueContainer;

			private object value;

			private object castedContainer;

			internal static object MDkggbZ18o2UvN2VGnNc;

			Type IPropertyValueContainer.PropertyType
			{
				get
				{
					int num = 4;
					int num2 = num;
					object obj;
					while (true)
					{
						switch (num2)
						{
						case 1:
						{
							object obj3 = value;
							if (obj3 == null)
							{
								num2 = 2;
								continue;
							}
							obj = qcbFWUZ1iwHhswn8Txfo(obj3);
							goto IL_00aa;
						}
						case 4:
						{
							object obj2 = castedContainer;
							if (obj2 == null)
							{
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							obj = xh0fsWZ1S1A77k6kFmlA(obj2);
							goto IL_0079;
						}
						case 3:
							obj = null;
							goto IL_0079;
						case 2:
							obj = null;
							goto IL_00aa;
						default:
							{
								obj = TypeOf<object>.Raw;
								break;
							}
							IL_0079:
							if (obj != null)
							{
								break;
							}
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num2 = 1;
							}
							continue;
							IL_00aa:
							if (obj == null)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							break;
						}
						break;
					}
					return (Type)obj;
				}
			}

			public NestedDefaultValueContainer(PropertyAnyTypeValueContainer propertyAnyTypeValueContainer, object value)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 2:
						this.value = value;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num = 0;
						}
						break;
					case 0:
						return;
					case 1:
						this.propertyAnyTypeValueContainer = propertyAnyTypeValueContainer;
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			object IPropertyValueContainer.Get(object obj)
			{
				int num = 1;
				int num2 = num;
				object obj2;
				while (true)
				{
					switch (num2)
					{
					case 1:
					{
						object obj3 = castedContainer;
						if (obj3 == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num2 = 0;
							}
							continue;
						}
						obj2 = LDpgwaZ1IV7kAiUffcCY(obj3, obj);
						goto IL_0060;
					}
					default:
						obj2 = null;
						goto IL_0060;
					case 2:
						{
							obj2 = value;
							break;
						}
						IL_0060:
						if (obj2 != null)
						{
							break;
						}
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				return obj2;
			}

			void IPropertyValueContainer.Set(object obj, object val)
			{
				//Discarded unreachable code: IL_0035, IL_0044
				int num = 4;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						return;
					case 1:
						lBh81JZ1VNE85pu9lfCn(castedContainer, obj, val);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						if (castedContainer == null)
						{
							num2 = 3;
							break;
						}
						goto case 1;
					case 0:
						return;
					case 3:
						value = val;
						num2 = 2;
						break;
					}
				}
			}

			IPropertyValueContainer<T> IPropertyValueContainerCast.Cast<T>()
			{
				if (castedContainer == null)
				{
					if (((PropertyAnyTypeValueContainer)propertyAnyTypeValueContainer).propertyDefaultValueContainer is NestedDefaultValueContainer nestedDefaultValueContainer)
					{
						object obj = nestedDefaultValueContainer.value ?? ((object)default(T));
						((PropertyAnyTypeValueContainer)propertyAnyTypeValueContainer).propertyDefaultValueContainer = new PropertyValueContainer<T>(obj);
					}
					if (value != null && TypeOf<T>.Raw != TypeOf<object>.Raw && !TypeOf<T>.Raw.IsInstanceOfType(value))
					{
						object obj2 = value;
						TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(TypeOf<T>.Raw);
						if (!converter.CanConvertFrom(obj2.GetType()))
						{
							obj2 = ((obj2 is IFormattable formattable) ? formattable.ToString(null, CultureInfo.InvariantCulture) : obj2.ToString());
						}
						if (converter.CanConvertFrom(obj2.GetType()))
						{
							value = converter.ConvertFrom(null, CultureInfo.InvariantCulture, obj2);
						}
					}
					castedContainer = new PropertyValueContainer<T>(value ?? ((object)default(T)));
					value = null;
				}
				return (IPropertyValueContainer<T>)castedContainer;
			}

			IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
			{
				return new NestedDefaultValueContainer((PropertyAnyTypeValueContainer)propertyAnyTypeValueContainer, value);
			}

			internal static bool rLQWqXZ1Z2lc5jVwf9yQ()
			{
				return MDkggbZ18o2UvN2VGnNc == null;
			}

			internal static NestedDefaultValueContainer LHM7HpZ1uyHvW8U7RvIB()
			{
				return (NestedDefaultValueContainer)MDkggbZ18o2UvN2VGnNc;
			}

			internal static object LDpgwaZ1IV7kAiUffcCY(object P_0, object P_1)
			{
				return ((IPropertyValueContainer)P_0).Get(P_1);
			}

			internal static void lBh81JZ1VNE85pu9lfCn(object P_0, object P_1, object P_2)
			{
				((IPropertyValueContainer)P_0).Set(P_1, P_2);
			}

			internal static Type xh0fsWZ1S1A77k6kFmlA(object P_0)
			{
				return ((IPropertyValueContainer)P_0).PropertyType;
			}

			internal static Type qcbFWUZ1iwHhswn8Txfo(object P_0)
			{
				return P_0.GetType();
			}
		}

		private object propertyDefaultValueContainer;

		private static object KofDlK8JO3gD52SmfLmH;

		public PropertyAnyTypeValueContainer(object defaultValue)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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
				propertyDefaultValueContainer = new NestedDefaultValueContainer(this, defaultValue);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 1;
				}
			}
		}

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return (IPropertyValueContainer)MhlVnC8JPTjjPI38Pv2v(propertyDefaultValueContainer);
		}

		internal static bool GpOghZ8J2F64CRUfIJwx()
		{
			return KofDlK8JO3gD52SmfLmH == null;
		}

		internal static PropertyAnyTypeValueContainer rNQPBK8JeYWePRP9m3l2()
		{
			return (PropertyAnyTypeValueContainer)KofDlK8JO3gD52SmfLmH;
		}

		internal static object MhlVnC8JPTjjPI38Pv2v(object P_0)
		{
			return ((IPropertyDefaultValueContainer)P_0).Initialize();
		}
	}

	private class PropertyCollectionValueContainer<TProp, TVal> : IPropertyDefaultValueContainer where TVal : class, TProp, new()
	{
		private static object Wl7cPL8J1TQNmH9C2lVo;

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return new PropertyValueContainer<TProp>(new TVal());
		}

		public PropertyCollectionValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool r5EXbX8JN96YQ3LBJKvr()
		{
			return Wl7cPL8J1TQNmH9C2lVo == null;
		}

		internal static object YvDqLR8J3SHH1rMFWnKY()
		{
			return Wl7cPL8J1TQNmH9C2lVo;
		}
	}

	private class PropertyCollectionValueContainer : IPropertyDefaultValueContainer
	{
		private class NestedDefaultValueContainer<TValue> : IPropertyValueContainerCast, IPropertyValueContainer, IPropertyDefaultValueContainer
		{
			private readonly PropertyCollectionValueContainer propertyCollectionValueContainer;

			private ICollection<TValue> value;

			private IPropertyValueContainer castedContainer;

			internal static object JwuCaLZ1RVmDaFrARAs2;

			Type IPropertyValueContainer.PropertyType
			{
				get
				{
					int num = 2;
					int num2 = num;
					object obj;
					while (true)
					{
						switch (num2)
						{
						case 2:
						{
							IPropertyValueContainer propertyValueContainer = castedContainer;
							if (propertyValueContainer == null)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
								{
									num2 = 1;
								}
								continue;
							}
							obj = propertyValueContainer.PropertyType;
							goto IL_005f;
						}
						case 1:
							obj = null;
							goto IL_005f;
						default:
							{
								obj = TypeOf<ICollection<TValue>>.Raw;
								break;
							}
							IL_005f:
							if (obj != null)
							{
								break;
							}
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
					return (Type)obj;
				}
			}

			public NestedDefaultValueContainer(PropertyCollectionValueContainer propertyCollectionValueContainer)
			{
				//Discarded unreachable code: IL_001a, IL_001f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 2:
						this.propertyCollectionValueContainer = propertyCollectionValueContainer;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num = 1;
						}
						break;
					case 0:
						return;
					case 1:
					{
						ICollection<TValue> collection2;
						if (!TypeOf<IEntity>.Raw.IsAssignableFrom(TypeOf<TValue>.Raw))
						{
							ICollection<TValue> collection = new List<TValue>();
							collection2 = collection;
						}
						else
						{
							ICollection<TValue> collection = (ICollection<TValue>)new HashedSet<TValue>();
							collection2 = collection;
						}
						value = collection2;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num = 0;
						}
						break;
					}
					}
				}
			}

			object IPropertyValueContainer.Get(object obj)
			{
				int num = 1;
				int num2 = num;
				object obj2;
				while (true)
				{
					switch (num2)
					{
					case 1:
					{
						IPropertyValueContainer propertyValueContainer = castedContainer;
						if (propertyValueContainer == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
							{
								num2 = 0;
							}
							continue;
						}
						obj2 = propertyValueContainer.Get(obj);
						goto IL_0060;
					}
					default:
						obj2 = null;
						goto IL_0060;
					case 2:
						{
							obj2 = value;
							break;
						}
						IL_0060:
						if (obj2 != null)
						{
							break;
						}
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
				return obj2;
			}

			void IPropertyValueContainer.Set(object obj, object value)
			{
				//Discarded unreachable code: IL_0089, IL_0098
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						return;
					case 1:
						return;
					case 2:
						this.value = (ICollection<TValue>)value;
						num2 = 4;
						continue;
					case 3:
						if (castedContainer == null)
						{
							num2 = 2;
							continue;
						}
						break;
					}
					castedContainer.Set(obj, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 1;
					}
				}
			}

			IPropertyValueContainer<T> IPropertyValueContainerCast.Cast<T>()
			{
				if (castedContainer == null)
				{
					Type type = (TypeOf<IEntity>.Raw.IsAssignableFrom(TypeOf<TValue>.Raw) ? TypeOf<HashedSet<TValue>>.Raw : TypeOf<List<TValue>>.Raw);
					propertyCollectionValueContainer.propertyDefaultValueContainer = (IPropertyDefaultValueContainer)Activator.CreateInstance(typeof(PropertyCollectionValueContainer<, >).MakeGenericType(typeof(T), type));
					IPropertyValueContainer<T> propertyValueContainer = (IPropertyValueContainer<T>)((IPropertyDefaultValueContainer)propertyCollectionValueContainer.propertyDefaultValueContainer).Initialize();
					if (value != null)
					{
						ICollection<TValue> collection = (ICollection<TValue>)(object)propertyValueContainer.Get(null);
						foreach (TValue item in value)
						{
							collection.Add(item);
						}
					}
					else
					{
						propertyValueContainer.Set(null, null);
					}
					castedContainer = propertyValueContainer;
					value = null;
				}
				return (IPropertyValueContainer<T>)castedContainer;
			}

			IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
			{
				return new NestedDefaultValueContainer<TValue>(propertyCollectionValueContainer);
			}

			internal static bool fZJFC0Z1qerY11dyFg6K()
			{
				return JwuCaLZ1RVmDaFrARAs2 == null;
			}

			internal static object KLuTbuZ1K5a6xh6kORCn()
			{
				return JwuCaLZ1RVmDaFrARAs2;
			}
		}

		private object propertyDefaultValueContainer;

		private static object OCuvQ68JpDygB5lHx9HU;

		public PropertyCollectionValueContainer(Type tTarget)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			xexW9l8JtZxMURGLTRar();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					propertyDefaultValueContainer = (IPropertyDefaultValueContainer)Jod5r88J4lrX8Iv5wwfN(OdjoOV8Jwe15MU69ylwg(typeof(NestedDefaultValueContainer<>).TypeHandle).MakeGenericType(tTarget), new object[1] { this });
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return ((IPropertyDefaultValueContainer)propertyDefaultValueContainer).Initialize();
		}

		internal static void xexW9l8JtZxMURGLTRar()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static Type OdjoOV8Jwe15MU69ylwg(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object Jod5r88J4lrX8Iv5wwfN(Type P_0, object P_1)
		{
			return Activator.CreateInstance(P_0, (object[])P_1);
		}

		internal static bool u7cr2b8Jae0hESEjkGqC()
		{
			return OCuvQ68JpDygB5lHx9HU == null;
		}

		internal static PropertyCollectionValueContainer thWYcN8JDwEiBt3T0bBj()
		{
			return (PropertyCollectionValueContainer)OCuvQ68JpDygB5lHx9HU;
		}
	}

	private class PropertyInfo : System.Reflection.PropertyInfo
	{
		private class MethodParameterInfo : ParameterInfo
		{
			private static object IUsi7NZ1XINXmEYRNMwm;

			public override IEnumerable<CustomAttributeData> CustomAttributes { get; }

			public override object DefaultValue { get; }

			public override bool HasDefaultValue => false;

			public override object RawDefaultValue { get; }

			public MethodParameterInfo(MemberInfo member, Type parameterType, string name = null, int position = -1)
			{
				//Discarded unreachable code: IL_005b, IL_0060
				GF02knZ1nYevafDDg1tD();
				CustomAttributes = new CustomAttributeData[0];
				DefaultValue = DBNull.Value;
				RawDefaultValue = DBNull.Value;
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 5:
						DefaultValueImpl = null;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num = 1;
						}
						break;
					case 6:
						AttrsImpl = ParameterAttributes.None;
						num = 5;
						break;
					case 2:
						NameImpl = name;
						num = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num = 2;
						}
						break;
					default:
						MemberImpl = member;
						num = 4;
						break;
					case 1:
						return;
					case 3:
						PositionImpl = position;
						num = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num = 1;
						}
						break;
					case 4:
						ClassImpl = parameterType;
						num = 2;
						break;
					}
				}
			}

			internal static void GF02knZ1nYevafDDg1tD()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool Q5ljWUZ1TZEN3KEBKX8p()
			{
				return IUsi7NZ1XINXmEYRNMwm == null;
			}

			internal static MethodParameterInfo B8rxrCZ1k7a2rZNvjEYa()
			{
				return (MethodParameterInfo)IUsi7NZ1XINXmEYRNMwm;
			}
		}

		private abstract class MethodInfo : System.Reflection.MethodInfo
		{
			internal static object vSeBGnZ1Ooh4DdaPL0Iq;

			public override string Name { get; }

			public override Type DeclaringType { get; }

			public override Type ReflectedType { get; }

			public override MethodAttributes Attributes => MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName;

			public override CallingConventions CallingConvention => CallingConventions.Standard | CallingConventions.HasThis;

			public override bool IsSecurityCritical => true;

			public override bool IsSecuritySafeCritical => false;

			public override bool IsSecurityTransparent => false;

			public override MethodImplAttributes MethodImplementationFlags => MethodImplAttributes.CodeTypeMask;

			public override RuntimeMethodHandle MethodHandle
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public override ICustomAttributeProvider ReturnTypeCustomAttributes => (ICustomAttributeProvider)YV3URrZ1pmP21itS35kI(this);

			public MethodInfo(Type declaringType, string name)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						ReflectedType = declaringType;
						num = 2;
						break;
					case 1:
						DeclaringType = declaringType;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num = 0;
						}
						break;
					case 3:
						return;
					case 2:
						Name = name;
						num = 3;
						break;
					}
				}
			}

			public override string ToString()
			{
				return (string)bIilkiZ137yLmNEdRsel(UDYsJlZ1PIJmoDvDbMZg(0x4A1640F ^ 0x4A220BD), ReturnType, Ht7yu3Z119FyWp73pLhk(this), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A52F5C), ((IEnumerable<ParameterInfo>)bSQCMNZ1Nu7DhaqMoODn(this)).Select((ParameterInfo p) => p.ParameterType.ToString())));
			}

			public override MethodImplAttributes GetMethodImplementationFlags()
			{
				return MethodImplAttributes.CodeTypeMask;
			}

			public override System.Reflection.MethodInfo GetBaseDefinition()
			{
				return this;
			}

			public override object[] GetCustomAttributes(bool inherit)
			{
				return Array.Empty<object>();
			}

			public override object[] GetCustomAttributes(Type attributeType, bool inherit)
			{
				return Array.Empty<object>();
			}

			public override bool IsDefined(Type attributeType, bool inherit)
			{
				return false;
			}

			internal static bool qyg6MmZ12NO9KxvirfaM()
			{
				return vSeBGnZ1Ooh4DdaPL0Iq == null;
			}

			internal static MethodInfo IH4S23Z1eKiN4XhCQyVN()
			{
				return (MethodInfo)vSeBGnZ1Ooh4DdaPL0Iq;
			}

			internal static object UDYsJlZ1PIJmoDvDbMZg(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object Ht7yu3Z119FyWp73pLhk(object P_0)
			{
				return ((MemberInfo)P_0).Name;
			}

			internal static object bSQCMNZ1Nu7DhaqMoODn(object P_0)
			{
				return ((MethodBase)P_0).GetParameters();
			}

			internal static object bIilkiZ137yLmNEdRsel(object P_0, object P_1, object P_2, object P_3)
			{
				return string.Format((string)P_0, P_1, P_2, P_3);
			}

			internal static object YV3URrZ1pmP21itS35kI(object P_0)
			{
				return ((System.Reflection.MethodInfo)P_0).ReturnParameter;
			}
		}

		private class GetPropertyMethodInfo : MethodInfo
		{
			private static readonly object getParameters;

			private readonly Guid metadataUid;

			private readonly Guid propertyUid;

			private static object VgmDuiZ1aUnCVs4WXLkH;

			public override Type ReturnType { get; }

			public override ParameterInfo ReturnParameter { get; }

			public GetPropertyMethodInfo(Type declaringType, string name, Type type, Guid metadataUid, Guid propertyUid)
			{
				//Discarded unreachable code: IL_0035
				SingletonReader.JJCZtPuTvSt();
				base._002Ector(declaringType, (string)dxCWIBZ14TiopTMBBjKo(Di9yGnZ1w8yA2BPqpuMu(-1217523399 ^ -1217520199), name));
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						this.metadataUid = metadataUid;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					case 4:
						ReturnParameter = new MethodParameterInfo(this, type);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						ReturnType = type;
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 0;
						}
						break;
					default:
						this.propertyUid = propertyUid;
						num2 = 2;
						break;
					}
				}
			}

			public override ParameterInfo[] GetParameters()
			{
				return (ParameterInfo[])getParameters;
			}

			public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
			{
				return iHRCQjZ16tCH1HDA4XOe((DataClass)obj, metadataUid, propertyUid);
			}

			static GetPropertyMethodInfo()
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						keCKLDZ1HlFyNpNE0csK();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						getParameters = new ParameterInfo[0];
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}

			internal static object Di9yGnZ1w8yA2BPqpuMu(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object dxCWIBZ14TiopTMBBjKo(object P_0, object P_1)
			{
				return (string)P_0 + (string)P_1;
			}

			internal static bool j5FW5IZ1D0tAgNNlqfC0()
			{
				return VgmDuiZ1aUnCVs4WXLkH == null;
			}

			internal static GetPropertyMethodInfo UrbvlXZ1tMOsONF1koAA()
			{
				return (GetPropertyMethodInfo)VgmDuiZ1aUnCVs4WXLkH;
			}

			internal static object iHRCQjZ16tCH1HDA4XOe(object P_0, Guid metadataUid, Guid propertyUid)
			{
				return ((DataClass)P_0).GetObject(metadataUid, propertyUid);
			}

			internal static void keCKLDZ1HlFyNpNE0csK()
			{
				SingletonReader.JJCZtPuTvSt();
			}
		}

		private class SetPropertyMethodInfo : MethodInfo
		{
			private readonly object getParameters;

			private readonly Guid metadataUid;

			private readonly Guid propertyUid;

			internal static object ngOfVIZ1AJV4hTDZjhfH;

			public override Type ReturnType => pvA8P5Z1yxBEhyJQ8pRM(typeof(void).TypeHandle);

			public override ParameterInfo ReturnParameter { get; }

			public SetPropertyMethodInfo(Type declaringType, string name, Type type, Guid metadataUid, Guid propertyUid)
			{
				//Discarded unreachable code: IL_0041, IL_0046
				uL6NUvZ10SQW91JAeyTD();
				base._002Ector(declaringType, (string)evRk4cZ1mw9BywSa6jxZ(-2138958856 ^ -2138955916) + name);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						return;
					case 4:
						this.metadataUid = metadataUid;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						this.propertyUid = propertyUid;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num = 2;
						}
						break;
					default:
					{
						ParameterInfo[] array = (ParameterInfo[])(getParameters = new MethodParameterInfo[1]
						{
							new MethodParameterInfo(this, type, (string)evRk4cZ1mw9BywSa6jxZ(0x12441CA4 ^ 0x124455D2), 0)
						});
						num = 3;
						break;
					}
					case 3:
						ReturnParameter = new MethodParameterInfo(this, pvA8P5Z1yxBEhyJQ8pRM(typeof(void).TypeHandle));
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num = 4;
						}
						break;
					}
				}
			}

			public override ParameterInfo[] GetParameters()
			{
				return (ParameterInfo[])getParameters;
			}

			public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return null;
					case 1:
						cBGeySZ1MnL9jbtNgLKd((DataClass)obj, metadataUid, propertyUid, parameters[0]);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static void uL6NUvZ10SQW91JAeyTD()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static object evRk4cZ1mw9BywSa6jxZ(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static Type pvA8P5Z1yxBEhyJQ8pRM(RuntimeTypeHandle P_0)
			{
				return Type.GetTypeFromHandle(P_0);
			}

			internal static bool tTsqEoZ17V250gWESXc5()
			{
				return ngOfVIZ1AJV4hTDZjhfH == null;
			}

			internal static SetPropertyMethodInfo FX5Ou9Z1xFFTDX4rfv9U()
			{
				return (SetPropertyMethodInfo)ngOfVIZ1AJV4hTDZjhfH;
			}

			internal static void cBGeySZ1MnL9jbtNgLKd(object P_0, Guid metadataUid, Guid propertyUid, object P_3)
			{
				((DataClass)P_0).SetObject(metadataUid, propertyUid, P_3);
			}
		}

		private static readonly object IndexParameters;

		private readonly object getMethod;

		private readonly object setMethod;

		private readonly object accessors;

		internal static object KYoxum8J6C6wiieRAceF;

		public override PropertyAttributes Attributes => PropertyAttributes.None;

		public override bool CanRead => true;

		public override bool CanWrite => true;

		public override string Name { get; }

		public override Type PropertyType { get; }

		public override Type DeclaringType { get; }

		public override Type ReflectedType { get; }

		public override Module Module => DeclaringType.Module;

		public PropertyInfo(string name, Type propertyType, Guid metadataUid, Guid propertyUid)
		{
			//Discarded unreachable code: IL_001a
			t6Oo1X8J7Ip3ZgtVZ18U();
			base._002Ector();
			int num = 4;
			Type raw = default(Type);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					return;
				case 4:
					raw = TypeOf<DataClass>.Raw;
					num2 = 2;
					goto IL_001f;
				case 5:
					Name = name;
					num = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num = 4;
					}
					continue;
				case 7:
					PropertyType = propertyType;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num = 1;
					}
					continue;
				case 2:
					DeclaringType = raw;
					num = 5;
					continue;
				case 6:
					setMethod = new SetPropertyMethodInfo(raw, name, propertyType, metadataUid, propertyUid);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num = 0;
					}
					continue;
				case 1:
					{
						getMethod = new GetPropertyMethodInfo(raw, name, propertyType, metadataUid, propertyUid);
						num2 = 6;
						goto IL_001f;
					}
					IL_001f:
					num = num2;
					continue;
				}
				accessors = ((!((System.Reflection.MethodInfo)setMethod != null)) ? new System.Reflection.MethodInfo[1] { (System.Reflection.MethodInfo)getMethod } : new System.Reflection.MethodInfo[2]
				{
					(System.Reflection.MethodInfo)getMethod,
					(System.Reflection.MethodInfo)setMethod
				});
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num = 3;
				}
			}
		}

		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			return ((MethodBase)getMethod).Invoke(obj, (object[])null);
		}

		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
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
					((MethodBase)setMethod).Invoke(obj, new object[1] { value });
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override ParameterInfo[] GetIndexParameters()
		{
			return (ParameterInfo[])IndexParameters;
		}

		public override System.Reflection.MethodInfo GetGetMethod(bool nonPublic)
		{
			return (System.Reflection.MethodInfo)getMethod;
		}

		public override System.Reflection.MethodInfo GetSetMethod(bool nonPublic)
		{
			return (System.Reflection.MethodInfo)setMethod;
		}

		public override System.Reflection.MethodInfo[] GetAccessors(bool nonPublic)
		{
			return (System.Reflection.MethodInfo[])accessors;
		}

		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return Array.Empty<CustomAttributeData>();
		}

		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return false;
		}

		public override object[] GetCustomAttributes(bool inherit)
		{
			return Array.Empty<object>();
		}

		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return Array.Empty<object>();
		}

		public override string ToString()
		{
			return (string)NsKm218J06AE7ysodXph(JQyjW18JxTyGENuJB1NO(-70037984 ^ -70078352), PropertyType, Name);
		}

		static PropertyInfo()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					t6Oo1X8J7Ip3ZgtVZ18U();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				default:
					IndexParameters = new ParameterInfo[0];
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		internal static void t6Oo1X8J7Ip3ZgtVZ18U()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool Sc3aGD8JHqLA3e8w2YDQ()
		{
			return KYoxum8J6C6wiieRAceF == null;
		}

		internal static PropertyInfo QQk7W98JACyNajydEiaA()
		{
			return (PropertyInfo)KYoxum8J6C6wiieRAceF;
		}

		internal static object JQyjW18JxTyGENuJB1NO(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object NsKm218J06AE7ysodXph(object P_0, object P_1, object P_2)
		{
			return string.Format((string)P_0, P_1, P_2);
		}
	}

	internal interface IPropertyValueContainerCast : IPropertyValueContainer
	{
		IPropertyValueContainer<T> Cast<T>();
	}

	private class PropertyValueContainer<T> : IPropertyValueContainer<T>, IPropertyValueContainer, IPropertyDefaultValueContainer, IPropertyValueContainerCast
	{
		private T value;

		private Func<T> valueFactory;

		internal static object fTBx3j8JJlqn8P7OcVf2;

		Type IPropertyValueContainer.PropertyType => TypeOf<T>.Raw;

		public PropertyValueContainer(object value)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
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
				this.value = (T)value;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num = 0;
				}
			}
		}

		public PropertyValueContainer(Func<T> valueFactory)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.valueFactory = valueFactory;
		}

		object IPropertyValueContainer.Get(object obj)
		{
			return value;
		}

		void IPropertyValueContainer.Set(object obj, object value)
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
					this.value = (T)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		T IPropertyValueContainer<T>.Get(object obj)
		{
			return value;
		}

		void IPropertyValueContainer<T>.Set(object obj, T value)
		{
			this.value = value;
		}

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			//Discarded unreachable code: IL_0054
			int num = 1;
			int num2 = num;
			T val;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (valueFactory == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					val = valueFactory();
					break;
				default:
					val = value;
					break;
				}
				break;
			}
			return new PropertyValueContainer<T>(val);
		}

		IPropertyValueContainer<T1> IPropertyValueContainerCast.Cast<T1>()
		{
			return (IPropertyValueContainer<T1>)this;
		}

		internal static bool xCgvVp8J9jR3RD79y066()
		{
			return fTBx3j8JJlqn8P7OcVf2 == null;
		}

		internal static object qlVanw8JdJtyfFGNDhmB()
		{
			return fTBx3j8JJlqn8P7OcVf2;
		}
	}

	protected internal abstract class ValueContainer
	{
		internal class DataContainer
		{
			private readonly IDictionary<Guid, IPropertyDefaultValueContainer> defaultProperties;

			internal IDictionary<Guid, IPropertyValueContainerCast> values;

			private static DataContainer VoSkylZ1JCOFc5Bq92Oa;

			public DataClassMetadata Metadata { get; }

			public bool Initialized => values != null;

			public IPropertyValueContainerCast this[Guid propertyUid]
			{
				get
				{
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 2:
							return values[propertyUid];
						case 1:
							if (values == null)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 2;
						}
						values = defaultProperties.ToDictionary((KeyValuePair<Guid, IPropertyDefaultValueContainer> v) => v.Key, (KeyValuePair<Guid, IPropertyDefaultValueContainer> v) => (IPropertyValueContainerCast)v.Value.Initialize());
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 1;
						}
					}
				}
			}

			internal DataContainer(DataClassMetadata metadata, IDictionary<Guid, IPropertyDefaultValueContainer> defaultProperties)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				Metadata = metadata;
				this.defaultProperties = defaultProperties;
			}

			internal static bool fBiudtZ19UhGh6XKMyte()
			{
				return VoSkylZ1JCOFc5Bq92Oa == null;
			}

			internal static DataContainer HaxuATZ1d2wFeGJZV0Bg()
			{
				return VoSkylZ1JCOFc5Bq92Oa;
			}
		}

		private class DataClassMetadataValueContainer : ValueContainer
		{
			private readonly object metadata;

			private readonly IDictionary<Guid, IPropertyDefaultValueContainer> defaultProperties;

			private readonly object includeValueContainers;

			private static object E251VnZ1lawhIbKNVYnR;

			public DataClassMetadataValueContainer(DataClassMetadata metadata)
			{
				//Discarded unreachable code: IL_0033, IL_0038
				obK93WZ15OdVOVAYwnpQ();
				_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
				CS_0024_003C_003E8__locals0.metadata = metadata;
				base._002Ector();
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 2:
						this.metadata = CS_0024_003C_003E8__locals0.metadata;
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num = 3;
						}
						break;
					case 3:
						defaultProperties = CS_0024_003C_003E8__locals0.metadata.Properties.Where((PropertyMetadata a) => _003C_003Ec.UrQRWUZaTNfofVXvgj10(_003C_003Ec.oAprXUZaXT01PFOCHxij(a), ActionDescriptor.UID)).ToDictionary((PropertyMetadata p) => _003C_003Ec.ehCuI8Zak7jD9EcT9Fv6(p), (PropertyMetadata p) => (IPropertyDefaultValueContainer)_003C_003Ec__DisplayClass3_0.Q4pRiKZaiJFm7rCc37hZ(CS_0024_003C_003E8__locals0.metadata, null, p));
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num = 1;
						}
						break;
					case 1:
						includeValueContainers = CS_0024_003C_003E8__locals0.metadata.IncludeList.Select(delegate(DataClassDependency i)
						{
							//Discarded unreachable code: IL_002d, IL_003c
							int num2 = 2;
							int num3 = num2;
							while (true)
							{
								switch (num3)
								{
								case 2:
									if (_003C_003Ec.UrQRWUZaTNfofVXvgj10(_003C_003Ec.BZEDiuZanZ2aAr0G69qg(i), Guid.Empty))
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
										{
											num3 = 1;
										}
										break;
									}
									goto default;
								default:
									return (ValueContainer)_003C_003Ec.e0fpa9ZaOTxnwNrF01Lm(i.HeaderUid);
								case 1:
									return (ValueContainer)_003C_003Ec.FHPV4mZae4m9dgcCYKp6(i.ModuleUid, Guid.Empty, _003C_003Ec.xKFEruZa2TGR1JmQVjR7(i));
								}
							}
						}).ToArray();
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			internal override string Initialize(IDictionary<Guid, DataContainer> data)
			{
				if (!data.ContainsKey(((AbstractMetadata)metadata).Uid))
				{
					data[((AbstractMetadata)metadata).Uid] = new DataContainer((DataClassMetadata)metadata, defaultProperties);
					for (int i = 0; i < ((Array)includeValueContainers).Length; i++)
					{
						((ValueContainer)((object[])includeValueContainers)[i]).Initialize(data);
					}
				}
				return ((DataClassMetadata)metadata).TypeRef;
			}

			internal static IPropertyDefaultValueContainer CreatePropertyDefaultValueContainer(object metadata, object parentMetadata, object property)
			{
				//Discarded unreachable code: IL_0194
				int num = 4;
				IPropertyDefaultValueContainer defaultContainer = default(IPropertyDefaultValueContainer);
				IPropertyDefaultValueContainer result = default(IPropertyDefaultValueContainer);
				Type type = default(Type);
				Type type2 = default(Type);
				object obj3 = default(object);
				object obj = default(object);
				EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyCollectionValueContainer propertyCollectionValueContainer = default(EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyCollectionValueContainer);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						object obj2;
						switch (num2)
						{
						case 4:
						{
							if (FUSSFcZ1Y05V0Tjr6cq4(LsNOUyZ1jdOb30jx38eA(property), DataClassDescriptor.UID))
							{
								num2 = 3;
								continue;
							}
							ITypeDescriptor typeDescriptor = ((IMetadataService)YFNw4LZ1sT7XDAXNweUp()).GetTypeDescriptor(((PropertyMetadata)property).TypeUid, wD14eOZ1cVDC68U2foUl(property));
							ClassMetadata classMetadata = (ClassMetadata)metadata;
							if (parentMetadata != null)
							{
								DataClassMetadata dataClassMetadata = new DataClassMetadata();
								diAo5uZNFnKVuRNH3hTK(dataClassMetadata, qo4ixkZ1zth4Grah3mHK(parentMetadata));
								dataClassMetadata.BaseClassUid = IkCdrHZNBYvsHpQtrvJ7(parentMetadata);
								dataClassMetadata.isInterfaceType = w52ceRZNWQ482MfsMB9n(parentMetadata);
								classMetadata = dataClassMetadata;
							}
							defaultContainer = ((ITypeGenerationInfo)typeDescriptor).GetDefaultContainer(classMetadata, (PropertyMetadata)property);
							num2 = 12;
							continue;
						}
						case 6:
							return result;
						case 7:
							if (HZnqR1ZNbUivlnyeKr66(type.GetGenericTypeDefinition(), hSfcNpZNoQlfXLvGhymK(typeof(EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyValueContainer<>).TypeHandle)))
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto IL_01d5;
						case 9:
							return (IPropertyDefaultValueContainer)fHhDFrZNEZOK7BPpD03T(hSfcNpZNoQlfXLvGhymK(typeof(PropertyValueContainer<>).TypeHandle).MakeGenericType(type2), new object[1] { obj3 });
						case 10:
							if (obj != null)
							{
								num2 = 2;
								continue;
							}
							goto IL_01d5;
						case 13:
							result = new DataClassCollectionPropertyValueContainer();
							num2 = 6;
							continue;
						default:
							obj = p1Z6v4ZNG1s9lyOUcn3r(type.GetField((string)LQmYrSZNhfXMBT5e1DfZ(-97972138 ^ -97572876), BindingFlags.Instance | BindingFlags.NonPublic), defaultContainer);
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num2 = 10;
							}
							continue;
						case 8:
							if (type.IsGenericType)
							{
								num2 = 7;
								continue;
							}
							goto IL_01d5;
						case 3:
							if (ort7P7Z1U6utkxnFCoMl((DataClassSettings)sDPC6pZ1LcHNNnYP49Ol(property)) == RelationType.OneToOne)
							{
								result = new DataClassPropertyValueContainer();
								num2 = 11;
								continue;
							}
							num2 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num2 = 6;
							}
							continue;
						case 2:
							return (IPropertyDefaultValueContainer)fHhDFrZNEZOK7BPpD03T(hSfcNpZNoQlfXLvGhymK(typeof(PropertyValueContainer<>).TypeHandle).MakeGenericType(type.GetGenericArguments()[0]), new object[1] { obj });
						case 12:
							if ((propertyCollectionValueContainer = defaultContainer as EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyCollectionValueContainer) == null)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 5;
						case 5:
							return new PropertyCollectionValueContainer(propertyCollectionValueContainer.tTarget);
						case 1:
							break;
						case 11:
							{
								return result;
							}
							IL_01d5:
							obj2 = Lp7POoZNff5X2lwFXWsi(defaultContainer);
							type2 = obj2.GetType().GetInterface(hSfcNpZNoQlfXLvGhymK(typeof(IPropertyValueContainer<>).TypeHandle).FullName).GetGenericArguments()[0];
							obj3 = RjQCkpZNQgR7CyGZNdGL(obj2, null);
							num2 = 9;
							continue;
						}
						break;
					}
					type = defaultContainer.GetType();
					num = 8;
				}
			}

			internal static void obK93WZ15OdVOVAYwnpQ()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool YWMVlaZ1rKRRmCj6LW1v()
			{
				return E251VnZ1lawhIbKNVYnR == null;
			}

			internal static DataClassMetadataValueContainer tywayMZ1g77IMsuind5L()
			{
				return (DataClassMetadataValueContainer)E251VnZ1lawhIbKNVYnR;
			}

			internal static Guid LsNOUyZ1jdOb30jx38eA(object P_0)
			{
				return ((PropertyMetadata)P_0).TypeUid;
			}

			internal static bool FUSSFcZ1Y05V0Tjr6cq4(Guid P_0, Guid P_1)
			{
				return P_0 == P_1;
			}

			internal static object sDPC6pZ1LcHNNnYP49Ol(object P_0)
			{
				return ((PropertyMetadata)P_0).Settings;
			}

			internal static RelationType ort7P7Z1U6utkxnFCoMl(object P_0)
			{
				return ((DataClassSettings)P_0).RelationType;
			}

			internal static object YFNw4LZ1sT7XDAXNweUp()
			{
				return MetadataServiceContext.Service;
			}

			internal static Guid wD14eOZ1cVDC68U2foUl(object P_0)
			{
				return ((PropertyMetadata)P_0).SubTypeUid;
			}

			internal static Guid qo4ixkZ1zth4Grah3mHK(object P_0)
			{
				return ((AbstractMetadata)P_0).Uid;
			}

			internal static void diAo5uZNFnKVuRNH3hTK(object P_0, Guid value)
			{
				((AbstractMetadata)P_0).Uid = value;
			}

			internal static Guid IkCdrHZNBYvsHpQtrvJ7(object P_0)
			{
				return ((ClassMetadata)P_0).BaseClassUid;
			}

			internal static bool w52ceRZNWQ482MfsMB9n(object P_0)
			{
				return ((ClassMetadata)P_0).IsInterfaceType;
			}

			internal static Type hSfcNpZNoQlfXLvGhymK(RuntimeTypeHandle P_0)
			{
				return Type.GetTypeFromHandle(P_0);
			}

			internal static bool HZnqR1ZNbUivlnyeKr66(Type P_0, Type P_1)
			{
				return P_0 == P_1;
			}

			internal static object LQmYrSZNhfXMBT5e1DfZ(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object p1Z6v4ZNG1s9lyOUcn3r(object P_0, object P_1)
			{
				return ((FieldInfo)P_0).GetValue(P_1);
			}

			internal static object fHhDFrZNEZOK7BPpD03T(Type P_0, object P_1)
			{
				return Activator.CreateInstance(P_0, (object[])P_1);
			}

			internal static object Lp7POoZNff5X2lwFXWsi(object P_0)
			{
				return ((IPropertyDefaultValueContainer)P_0).Initialize();
			}

			internal static object RjQCkpZNQgR7CyGZNdGL(object P_0, object P_1)
			{
				return ((IPropertyValueContainer)P_0).Get(P_1);
			}
		}

		private class DTOHeaderValueContainer : ValueContainer
		{
			[Component]
			private class DataClassClearCacheHandler : IDataClassMetadataPublishingEventHandler, IEventHandler
			{
				internal static object NXRlLSZaPPqbQn3Im1Ba;

				public Task Complete(Guid publicationToken, UIMetadataPublishResult result)
				{
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 1:
							POqc2cZa3yVNrq5BvN4n(LastVersions);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num2 = 0;
							}
							break;
						default:
							return (Task)zNR82bZapPEbbvLj3Bad();
						}
					}
				}

				public Task Error(Guid publicationToken, Exception exception)
				{
					return Task.CompletedTask;
				}

				public DataClassClearCacheHandler()
				{
					//Discarded unreachable code: IL_002a, IL_002f
					SingletonReader.JJCZtPuTvSt();
					base._002Ector();
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num = 0;
					}
					switch (num)
					{
					case 0:
						break;
					}
				}

				internal static void POqc2cZa3yVNrq5BvN4n(object P_0)
				{
					((ConcurrentDictionary<Guid, long>)P_0).Clear();
				}

				internal static object zNR82bZapPEbbvLj3Bad()
				{
					return Task.CompletedTask;
				}

				internal static bool mtisOMZa1tHOWbJiULLF()
				{
					return NXRlLSZaPPqbQn3Im1Ba == null;
				}

				internal static DataClassClearCacheHandler YiIiAvZaN0Tkl1fl0F7p()
				{
					return (DataClassClearCacheHandler)NXRlLSZaPPqbQn3Im1Ba;
				}
			}

			private readonly Guid metadataUid;

			private long lastVersionId;

			private object lastVersion;

			private static readonly ConcurrentDictionary<Guid, long> LastVersions;

			internal static object r1CHHLZNCHbs87NhGhgA;

			public DTOHeaderValueContainer(Guid metadataUid)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				FdxX5VZNZodebcyTfGFa();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						this.metadataUid = metadataUid;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			internal override string Initialize(IDictionary<Guid, DataContainer> data)
			{
				long orAdd = LastVersions.GetOrAdd(metadataUid, GetLastVersionId);
				if (lastVersionId != orAdd || lastVersion == null)
				{
					lastVersion = null;
					lock (this)
					{
						lastVersion = lastVersion ?? CreateValueContainer(lastVersionId = orAdd);
					}
				}
				return ((ValueContainer)lastVersion).Initialize(data);
			}

			private static ValueContainer CreateValueContainer(long id)
			{
				return new DataClassMetadataValueContainer((DataClassMetadata)z9TdgJZNuOWYSMgEDFmU(DataClassMetadataItemManager.Instance.Load(id)));
			}

			private static long GetLastVersionId(Guid metadataUid)
			{
				int num = 1;
				int num2 = num;
				_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
				while (true)
				{
					switch (num2)
					{
					case 1:
						_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
					{
						IQueryOver<DataClassMetadataItemHeader, DataClassMetadataItemHeader> obj = ((ISession)L7AJD9ZNIN1ls8NcXtNx(Locator.GetServiceNotNull<ISessionProvider>(), string.Empty)).QueryOver<DataClassMetadataItemHeader>();
						ParameterExpression parameterExpression = (ParameterExpression)fab1rRZNiWToavkE6kAL(oCDDngZNVi1A3ewsbuNi(typeof(DataClassMetadataItemHeader).TypeHandle), yp6SLwZNSUvfQrp3lkfC(0x3B36AB09 ^ 0x3B3607BD));
						IQueryOver<DataClassMetadataItemHeader, DataClassMetadataItemHeader> obj2 = obj.Where(Expression.Lambda<Func<DataClassMetadataItemHeader, bool>>((Expression)Tva39FZNTbpNmBHTNFSk(Expression.Property(parameterExpression, (MethodInfo)NGFAjvZNRcPQ74vAaB7R((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), t8C7mYZNXfqmOTGV0VVU(x9vPM8ZNqbnRRs9aDOxP(_003C_003Ec__DisplayClass7_, oCDDngZNVi1A3ewsbuNi(typeof(_003C_003Ec__DisplayClass7_0).TypeHandle)), yPKkWQZNKnVfvOSduLoB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)NGFAjvZNRcPQ74vAaB7R((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						Expression<Func<DataClassMetadataItemHeader, object>>[] array = new Expression<Func<DataClassMetadataItemHeader, object>>[1];
						parameterExpression = Expression.Parameter(typeof(DataClassMetadataItemHeader), (string)yp6SLwZNSUvfQrp3lkfC(-1108654032 ^ -1108614012));
						array[0] = Expression.Lambda<Func<DataClassMetadataItemHeader, object>>((Expression)YeoYkBZNnfPVs45QaO7t(Expression.Property((Expression)iyi6YuZNkhZTm7x5hrcB(parameterExpression, (MethodInfo)NGFAjvZNRcPQ74vAaB7R((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle)), oCDDngZNVi1A3ewsbuNi(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression });
						return ((IQueryOver<DataClassMetadataItemHeader>)(object)obj2.Select(array)).SingleOrDefault<long>();
					}
					default:
						_003C_003Ec__DisplayClass7_.metadataUid = metadataUid;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			static DTOHeaderValueContainer()
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
					case 2:
						FdxX5VZNZodebcyTfGFa();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						LastVersions = new ConcurrentDictionary<Guid, long>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static void FdxX5VZNZodebcyTfGFa()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool VQgdw6ZNvfMZbNlFMUUu()
			{
				return r1CHHLZNCHbs87NhGhgA == null;
			}

			internal static DTOHeaderValueContainer n36aWBZN8kgG1OAsYn3K()
			{
				return (DTOHeaderValueContainer)r1CHHLZNCHbs87NhGhgA;
			}

			internal static object z9TdgJZNuOWYSMgEDFmU(object P_0)
			{
				return ((DataClassMetadataItem)P_0).Metadata;
			}

			internal static object L7AJD9ZNIN1ls8NcXtNx(object P_0, object P_1)
			{
				return ((ISessionProvider)P_0).GetSession((string)P_1);
			}

			internal static Type oCDDngZNVi1A3ewsbuNi(RuntimeTypeHandle P_0)
			{
				return Type.GetTypeFromHandle(P_0);
			}

			internal static object yp6SLwZNSUvfQrp3lkfC(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object fab1rRZNiWToavkE6kAL(Type P_0, object P_1)
			{
				return Expression.Parameter(P_0, (string)P_1);
			}

			internal static object NGFAjvZNRcPQ74vAaB7R(RuntimeMethodHandle P_0)
			{
				return MethodBase.GetMethodFromHandle(P_0);
			}

			internal static object x9vPM8ZNqbnRRs9aDOxP(object P_0, Type P_1)
			{
				return Expression.Constant(P_0, P_1);
			}

			internal static object yPKkWQZNKnVfvOSduLoB(RuntimeFieldHandle P_0)
			{
				return FieldInfo.GetFieldFromHandle(P_0);
			}

			internal static object t8C7mYZNXfqmOTGV0VVU(object P_0, object P_1)
			{
				return Expression.Field((Expression)P_0, (FieldInfo)P_1);
			}

			internal static object Tva39FZNTbpNmBHTNFSk(object P_0, object P_1, bool P_2, object P_3)
			{
				return Expression.Equal((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
			}

			internal static object iyi6YuZNkhZTm7x5hrcB(object P_0, object P_1)
			{
				return Expression.Property((Expression)P_0, (MethodInfo)P_1);
			}

			internal static object YeoYkBZNnfPVs45QaO7t(object P_0, Type P_1)
			{
				return Expression.Convert((Expression)P_0, P_1);
			}
		}

		private class ModuleHeaderValueContainer : ValueContainer
		{
			private readonly Guid moduleHeaderUid;

			private readonly Guid componentUid;

			private readonly Guid metadataUid;

			private static object UT0YXpZNOWmwUj26GNs5;

			public ModuleHeaderValueContainer(Guid moduleHeaderUid, Guid componentUid, Guid metadataUid)
			{
				//Discarded unreachable code: IL_002a
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 3:
						return;
					case 2:
						this.metadataUid = metadataUid;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num = 3;
						}
						break;
					default:
						this.moduleHeaderUid = moduleHeaderUid;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num = 1;
						}
						break;
					case 1:
					{
						this.componentUid = componentUid;
						int num2 = 2;
						num = num2;
						break;
					}
					}
				}
			}

			internal override string Initialize(IDictionary<Guid, DataContainer> data)
			{
				ItemRuntimeModel itemRuntimeModel = ContextVars.GetOrDefault<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939359884))?.RuntimeModules.FirstOrDefault((ItemRuntimeModel a) => vv5KyeZNPh2AZupkXJD0(a.HeaderUid, moduleHeaderUid));
				Guid guid = Guid.Empty;
				Guid moduleUid = Guid.Empty;
				if (itemRuntimeModel != null)
				{
					guid = itemRuntimeModel.ItemUid;
					moduleUid = itemRuntimeModel.HeaderUid;
				}
				else
				{
					UIRuntimeModel orAdd = ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AB7BE8), () => new UIRuntimeModel());
					itemRuntimeModel = orAdd.RuntimeModules.FirstOrDefault((ItemRuntimeModel a) => vv5KyeZNPh2AZupkXJD0(a.HeaderUid, moduleHeaderUid));
					if (itemRuntimeModel != null)
					{
						guid = itemRuntimeModel.ItemUid;
						moduleUid = itemRuntimeModel.HeaderUid;
					}
					else
					{
						IFindComponentService serviceNotNull = Locator.GetServiceNotNull<IFindComponentService>();
						ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487364434), () => new HashSet<Guid>()).Add(moduleHeaderUid);
						ClientComponentModel clientComponentModel = serviceNotNull.GetAdditionalModules().FirstOrDefault((ClientComponentModel a) => vv5KyeZNPh2AZupkXJD0(HWG6m4ZN1572042oYT5Q(a), moduleHeaderUid));
						if (clientComponentModel != null)
						{
							guid = clientComponentModel.ModuleItemUid;
							orAdd.RuntimeModules.Add(new ItemRuntimeModel
							{
								HeaderUid = moduleHeaderUid,
								ItemUid = guid
							});
						}
					}
				}
				if (!(guid == Guid.Empty))
				{
					return Create(moduleUid, guid, componentUid, metadataUid).Initialize(data);
				}
				return string.Empty;
			}

			internal static bool gAoissZN2uAX8fUguMQG()
			{
				return UT0YXpZNOWmwUj26GNs5 == null;
			}

			internal static ModuleHeaderValueContainer q8YWsKZNemNyava5SRBi()
			{
				return (ModuleHeaderValueContainer)UT0YXpZNOWmwUj26GNs5;
			}

			internal static bool vv5KyeZNPh2AZupkXJD0(Guid P_0, Guid P_1)
			{
				return P_0 == P_1;
			}

			internal static Guid HWG6m4ZN1572042oYT5Q(object P_0)
			{
				return ((ClientComponentModel)P_0).ModuleUid;
			}
		}

		private class ModuleValueContainer : ValueContainer
		{
			private static readonly ConcurrentDictionary<Guid, ModuleInfoMetadata> moduleInfoMetadataList;

			private readonly Guid moduleUid;

			private readonly Guid moduleItemUid;

			private readonly Guid componentUid;

			private readonly Guid metadataUid;

			private object valueContainer;

			internal static object Hp7Ig8ZNNUofLPO20AuR;

			public ModuleValueContainer(Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				D6Jaf5ZNaREGVP4BZL7x();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 3:
						this.componentUid = componentUid;
						num = 2;
						break;
					case 2:
						this.metadataUid = metadataUid;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num = 4;
						}
						break;
					case 4:
						return;
					default:
						this.moduleItemUid = moduleItemUid;
						num = 3;
						break;
					case 1:
						this.moduleUid = moduleUid;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			internal override string Initialize(IDictionary<Guid, DataContainer> data)
			{
				if (valueContainer == null)
				{
					lock (this)
					{
						if (valueContainer == null)
						{
							ModuleInfoMetadata orAdd = moduleInfoMetadataList.GetOrAdd(moduleItemUid, (Guid uid) => (ModuleInfoMetadata)IUT5ETZNwCISRUJjcWhC(QEaCYFZNtZQ9opHZw8BJ(udjx7wZNDT0IvcNFeL8F(), moduleUid, uid)));
							DataClassMetadata metadata = ((componentUid == Guid.Empty) ? orAdd.DataClasses.Find((DataClassMetadata m) => ElqQR2ZN6gp2wR47A6Xi(S15oZqZN4pHTKbJ2lktu(m), metadataUid)) : orAdd.Components.Find((ComponentMetadata c) => S15oZqZN4pHTKbJ2lktu(c) == componentUid).DataClasses.Find((DataClassMetadata m) => ElqQR2ZN6gp2wR47A6Xi(m.Uid, metadataUid)));
							valueContainer = new DataClassMetadataValueContainer(metadata);
						}
					}
				}
				return ((ValueContainer)valueContainer).Initialize(data);
			}

			static ModuleValueContainer()
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
						moduleInfoMetadataList = new ConcurrentDictionary<Guid, ModuleInfoMetadata>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						D6Jaf5ZNaREGVP4BZL7x();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			internal static void D6Jaf5ZNaREGVP4BZL7x()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool ANLeRwZN3t67KopXH6vv()
			{
				return Hp7Ig8ZNNUofLPO20AuR == null;
			}

			internal static ModuleValueContainer iuPvfQZNpFenrrnWDt1W()
			{
				return (ModuleValueContainer)Hp7Ig8ZNNUofLPO20AuR;
			}

			internal static object udjx7wZNDT0IvcNFeL8F()
			{
				return ModuleMetadataLoader;
			}

			internal static object QEaCYFZNtZQ9opHZw8BJ(object P_0, Guid moduleUid, Guid versionUid)
			{
				return ((IModuleMetadataLoader)P_0).GetSpecificModuleVersion(moduleUid, versionUid);
			}

			internal static object IUT5ETZNwCISRUJjcWhC(object P_0)
			{
				return ((ModuleVersion)P_0).Metadata;
			}

			internal static Guid S15oZqZN4pHTKbJ2lktu(object P_0)
			{
				return ((AbstractMetadata)P_0).Uid;
			}

			internal static bool ElqQR2ZN6gp2wR47A6Xi(Guid P_0, Guid P_1)
			{
				return P_0 == P_1;
			}
		}

		private sealed class EntityMetadataValueContainer : ValueContainer
		{
			private readonly object entityMetadata;

			private object valueContainer;

			internal static object wFVyJwZNHpEPEdC3rOKp;

			public EntityMetadataValueContainer(EntityMetadata entityMetadata)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				gD7fXnZNxLFZldf1qCqn();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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
					this.entityMetadata = entityMetadata;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num = 1;
					}
				}
			}

			internal override string Initialize(IDictionary<Guid, DataContainer> data)
			{
				if (valueContainer == null)
				{
					lock (this)
					{
						if (valueContainer == null)
						{
							valueContainer = new ViewModelMetadataValueContainer((EntityMetadata)entityMetadata);
						}
					}
				}
				return ((ValueContainer)valueContainer).Initialize(data);
			}

			internal static void gD7fXnZNxLFZldf1qCqn()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool IP9tPSZNASg6MsRPGA6a()
			{
				return wFVyJwZNHpEPEdC3rOKp == null;
			}

			internal static EntityMetadataValueContainer kRSanxZN72fj7nH4wwu2()
			{
				return (EntityMetadataValueContainer)wFVyJwZNHpEPEdC3rOKp;
			}
		}

		private class ViewModelMetadataValueContainer : ValueContainer
		{
			private object metadata;

			private IDictionary<Guid, IPropertyDefaultValueContainer> defaultProperties;

			private object includeViewModelMetadata;

			private static object I3iRqpZN0NdeRSu639AC;

			public ViewModelMetadataValueContainer(EntityMetadata entityMetadata)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						CaseProcessContext(entityMetadata);
						num = 3;
						continue;
					case 3:
						return;
					case 1:
						return;
					}
					if (yqTdIUZN9E251EHWKALK(nfaBlRZNMqn82uPCyKfm(entityMetadata), hNdlD1ZNJQwj9N8lR7Xn(0x5A4C7B29 ^ 0x5A4A4C97)))
					{
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num = 1;
						}
						continue;
					}
					CaseEntityMetadata(entityMetadata);
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num = 0;
					}
				}
			}

			internal override string Initialize(IDictionary<Guid, DataContainer> data)
			{
				if (!data.ContainsKey(((AbstractMetadata)metadata).Uid))
				{
					data[((AbstractMetadata)metadata).Uid] = new DataContainer((DataClassMetadata)metadata, defaultProperties);
					if (includeViewModelMetadata != null)
					{
						((ValueContainer)includeViewModelMetadata).Initialize(data);
					}
				}
				return ((DataClassMetadata)metadata).TypeRef;
			}

			private void CaseProcessContext(EntityMetadata entityMetadata)
			{
				int num = 2;
				int num2 = num;
				_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
				while (true)
				{
					switch (num2)
					{
					case 4:
						includeViewModelMetadata = CreateViewModelMetadataHeaderValueContainer(_003C_003Ec__DisplayClass5_.entityMetadata.BaseClassUid);
						num2 = 7;
						break;
					case 3:
						if (FuwJuhZNdMhK4xV5COvi(((DataClassMetadata)metadata).IncludeList) == 1)
						{
							num2 = 4;
							break;
						}
						return;
					case 1:
						_003C_003Ec__DisplayClass5_._003C_003E4__this = this;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 0;
						}
						break;
					case 7:
						return;
					default:
						_003C_003Ec__DisplayClass5_.entityMetadata = entityMetadata;
						num2 = 6;
						break;
					case 6:
						metadata = _003C_003Ec__DisplayClass5_.entityMetadata.ViewModelMetadata;
						num2 = 5;
						break;
					case 2:
						_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 1;
						}
						break;
					case 5:
						defaultProperties = ((ClassMetadata)metadata).Properties.Where((PropertyMetadata a) => _003C_003Ec.gYQtOHZa5IG7dLStfux4(a.TypeUid, ActionDescriptor.UID)).ToDictionary((PropertyMetadata p) => _003C_003Ec.jqH4H8ZajSd6UyMXAfme(p), _003C_003Ec__DisplayClass5_._003CCaseProcessContext_003Eb__2);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 3;
						}
						break;
					}
				}
			}

			private void CaseEntityMetadata(EntityMetadata entityMetadata)
			{
				//Discarded unreachable code: IL_0133
				int num = 4;
				EntityMetadata entityMetadata2 = default(EntityMetadata);
				_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
				Guid item2 = default(Guid);
				PropertyMetadata propertyMetadata = default(PropertyMetadata);
				Guid item = default(Guid);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 13:
							includeViewModelMetadata = eVRUZXZNLF1POeD05rpv(dYMBHsZNYi3d7lHbxtJ4(entityMetadata2));
							num2 = 18;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num2 = 20;
							}
							continue;
						case 9:
							_003C_003Ec__DisplayClass6_.entityMetadata = entityMetadata;
							num2 = 11;
							continue;
						case 19:
							if (item2 != Guid.Empty)
							{
								num2 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
								{
									num2 = 10;
								}
								continue;
							}
							goto case 14;
						case 12:
							if (propertyMetadata != null)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
								{
									num2 = 1;
								}
								continue;
							}
							goto case 16;
						case 15:
							entityMetadata2 = (EntityMetadata)((IMetadataService)TKWLLYZNjmApjlqZvVdf()).GetMetadata(entityMetadata2.BaseClassUid, loadImplementation: true);
							num2 = 13;
							continue;
						case 4:
							_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
							num2 = 3;
							continue;
						case 10:
							defaultProperties[propertyMetadata.Uid] = new ViewModelContextModelPropertyValueContainer(item, item2);
							num2 = 14;
							continue;
						case 11:
							metadata = pJ4bjEZNlTQP4IBEodTT(_003C_003Ec__DisplayClass6_.entityMetadata);
							num2 = 6;
							continue;
						case 8:
						{
							(Guid, Guid) rootViewModelContextData = GetRootViewModelContextData(_003C_003Ec__DisplayClass6_.entityMetadata);
							item = rootViewModelContextData.Item1;
							item2 = rootViewModelContextData.Item2;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						case 2:
							if (pwtTfbZN5fJHFGJeftpv(entityMetadata2) == EntityMetadataType.InterfaceExtension)
							{
								num2 = 15;
								continue;
							}
							goto case 13;
						default:
							if (!Jqsj4uZNgKMZttjLEA9F(item, Guid.Empty))
							{
								num = 17;
								break;
							}
							goto case 19;
						case 16:
							if (FuwJuhZNdMhK4xV5COvi(((DataClassMetadata)metadata).IncludeList) == 1)
							{
								num2 = 5;
								continue;
							}
							return;
						case 1:
							if (FuwJuhZNdMhK4xV5COvi(((DataClassMetadata)metadata).IncludeList) == 0)
							{
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
								{
									num2 = 7;
								}
								continue;
							}
							goto case 16;
						case 14:
						case 17:
							entityMetadata2 = _003C_003Ec__DisplayClass6_.entityMetadata;
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num2 = 2;
							}
							continue;
						case 7:
							defaultProperties[mlxUnCZNrFvUZVDxKesJ(propertyMetadata)] = DataClassMetadataValueContainer.CreatePropertyDefaultValueContainer(metadata, _003C_003Ec__DisplayClass6_.entityMetadata, propertyMetadata);
							num = 16;
							break;
						case 3:
							_003C_003Ec__DisplayClass6_._003C_003E4__this = this;
							num2 = 9;
							continue;
						case 20:
							return;
						case 5:
							if (propertyMetadata != null)
							{
								num2 = 8;
								continue;
							}
							goto case 14;
						case 6:
							defaultProperties = ((ClassMetadata)metadata).Properties.Where(delegate(PropertyMetadata a)
							{
								//Discarded unreachable code: IL_0080, IL_008f
								int num3 = 1;
								int num4 = num3;
								while (true)
								{
									switch (num4)
									{
									case 2:
										return a.Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92FCC99);
									default:
										return true;
									case 1:
										if (_003C_003Ec.gYQtOHZa5IG7dLStfux4(_003C_003Ec.kRmG9DZaYnnLKrQYGZRi(a), ActionDescriptor.UID))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
											{
												num4 = 0;
											}
											break;
										}
										goto case 2;
									}
								}
							}).ToDictionary((PropertyMetadata p) => _003C_003Ec.jqH4H8ZajSd6UyMXAfme(p), _003C_003Ec__DisplayClass6_._003CCaseEntityMetadata_003Eb__2);
							num2 = 18;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num2 = 8;
							}
							continue;
						case 18:
							propertyMetadata = ((ClassMetadata)metadata).Properties.Find((PropertyMetadata property) => _003C_003Ec.lq0nYqZasKXsAvRR2YJL(_003C_003Ec.uenULHZaL4dof7fwXIvg(property), _003C_003Ec.IPANvXZaUph62ekCrQEF(0x6A81B9B4 ^ 0x6A8167F8)));
							num2 = 12;
							continue;
						}
						break;
					}
				}
			}

			private static (Guid, Guid) GetRootViewModelContextData(object entityMetadata)
			{
				DataClassMetadata dataClassMetadata = ((EntityMetadata)entityMetadata).ViewModelMetadata;
				EntityMetadata entityMetadata2 = (EntityMetadata)entityMetadata;
				if (entityMetadata2.Type == EntityMetadataType.InterfaceExtension)
				{
					entityMetadata2 = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(entityMetadata2.BaseClassUid);
				}
				while (entityMetadata2.BaseClassUid != Guid.Empty)
				{
					entityMetadata2 = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(entityMetadata2.BaseClassUid);
					DataClassMetadata dataClassMetadata2 = null;
					if (entityMetadata2.ViewModelMetadata != null)
					{
						dataClassMetadata2 = entityMetadata2.ViewModelMetadata;
					}
					else if (entityMetadata2.ImplementedExtensionUids != null && entityMetadata2.ImplementedExtensionUids.Count != 0)
					{
						string text = entityMetadata2.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A62650C);
						foreach (Guid implementedExtensionUid in entityMetadata2.ImplementedExtensionUids)
						{
							EntityMetadata entityMetadata3 = MetadataServiceContext.Service.GetMetadata(implementedExtensionUid, loadImplementation: false) as EntityMetadata;
							if (entityMetadata3?.Name == text && entityMetadata3.ViewModelMetadata != null)
							{
								dataClassMetadata2 = entityMetadata3.ViewModelMetadata;
								break;
							}
						}
					}
					if (dataClassMetadata2 == null)
					{
						break;
					}
					dataClassMetadata = dataClassMetadata2;
				}
				PropertyMetadata propertyMetadata = dataClassMetadata.Properties.Find((PropertyMetadata property) => _003C_003Ec.lq0nYqZasKXsAvRR2YJL(_003C_003Ec.uenULHZaL4dof7fwXIvg(property), _003C_003Ec.IPANvXZaUph62ekCrQEF(-1334993905 ^ -1335016893)));
				return (dataClassMetadata.Uid, propertyMetadata?.Uid ?? Guid.Empty);
			}

			internal static object nfaBlRZNMqn82uPCyKfm(object P_0)
			{
				return ((ClassMetadata)P_0).Namespace;
			}

			internal static object hNdlD1ZNJQwj9N8lR7Xn(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool yqTdIUZN9E251EHWKALK(object P_0, object P_1)
			{
				return (string)P_0 == (string)P_1;
			}

			internal static bool YlxeM1ZNm8jZiG2YUYaW()
			{
				return I3iRqpZN0NdeRSu639AC == null;
			}

			internal static ViewModelMetadataValueContainer yV2L41ZNyen7Pa40a1e6()
			{
				return (ViewModelMetadataValueContainer)I3iRqpZN0NdeRSu639AC;
			}

			internal static int FuwJuhZNdMhK4xV5COvi(object P_0)
			{
				return ((List<DataClassDependency>)P_0).Count;
			}

			internal static object pJ4bjEZNlTQP4IBEodTT(object P_0)
			{
				return ((EntityMetadata)P_0).ViewModelMetadata;
			}

			internal static Guid mlxUnCZNrFvUZVDxKesJ(object P_0)
			{
				return ((AbstractMetadata)P_0).Uid;
			}

			internal static bool Jqsj4uZNgKMZttjLEA9F(Guid P_0, Guid P_1)
			{
				return P_0 != P_1;
			}

			internal static EntityMetadataType pwtTfbZN5fJHFGJeftpv(object P_0)
			{
				return ((EntityMetadata)P_0).Type;
			}

			internal static object TKWLLYZNjmApjlqZvVdf()
			{
				return MetadataServiceContext.Service;
			}

			internal static Guid dYMBHsZNYi3d7lHbxtJ4(object P_0)
			{
				return ((ClassMetadata)P_0).BaseClassUid;
			}

			internal static object eVRUZXZNLF1POeD05rpv(Guid ownerMetadataUid)
			{
				return CreateViewModelMetadataHeaderValueContainer(ownerMetadataUid);
			}
		}

		private class ViewModelMetadataHeaderValueContainer : ValueContainer
		{
			private readonly Guid ownerMetadataUid;

			internal static object WkrrBpZNUOr7TrBp9JkJ;

			public ViewModelMetadataHeaderValueContainer(Guid ownerMetadataUid)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				c4WMyIZNz5Bo2Jw2gwsx();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						this.ownerMetadataUid = ownerMetadataUid;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}

			internal override string Initialize(IDictionary<Guid, DataContainer> data)
			{
				EntityMetadata entityMetadata = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(ownerMetadataUid);
				EntityMetadata entityMetadata2 = entityMetadata;
				if (entityMetadata.ViewModelMetadata == null && entityMetadata.ImplementedExtensionUids != null)
				{
					string text = entityMetadata2.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334915907);
					foreach (Guid implementedExtensionUid in entityMetadata.ImplementedExtensionUids)
					{
						EntityMetadata entityMetadata3 = MetadataServiceContext.Service.GetMetadata(implementedExtensionUid, loadImplementation: false) as EntityMetadata;
						if (entityMetadata3?.Name == text && entityMetadata3.ViewModelMetadata != null)
						{
							entityMetadata2 = entityMetadata3;
							break;
						}
					}
				}
				return new ViewModelMetadataValueContainer(entityMetadata2).Initialize(data);
			}

			internal static void c4WMyIZNz5Bo2Jw2gwsx()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool sl73b6ZNsudnj5ugMoQw()
			{
				return WkrrBpZNUOr7TrBp9JkJ == null;
			}

			internal static ViewModelMetadataHeaderValueContainer SrOTr1ZNcjlHWC7BluNX()
			{
				return (ViewModelMetadataHeaderValueContainer)WkrrBpZNUOr7TrBp9JkJ;
			}
		}

		private static readonly ConcurrentDictionary<Type, ValueContainer> DTOTypesValueContainers;

		private static readonly IDictionary<Guid, ValueContainer> ViewModelValueContainers;

		private static readonly ConcurrentDictionary<Guid, ValueContainer> DTOHeaderValueContainers;

		private static readonly ConcurrentDictionary<(Guid componentUid, Guid metadataUid), ValueContainer> ComponentValueContainers;

		private static readonly ConcurrentDictionary<(Guid moduleHeaderUid, Guid componentUid, Guid metadataUid), ValueContainer> ModuleHeaderValueContainers;

		private static readonly ConcurrentDictionary<(Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid), ValueContainer> ModuleValueContainers;

		internal static ValueContainer I7AcvZ8JlpEU0y7Ln0bi;

		public static ValueContainer Create<T>()
		{
			return Create(typeof(T));
		}

		internal static ValueContainer Create(Type type)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					ylPCBI8JYRxb8nGhJCR7(rSivU28J5ksUmHtZXe2w(type, TypeOf<DataClass>.Raw), qx3rpL8JjnH5h78mNLml(-541731959 ^ -541861525));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return DTOTypesValueContainers.GetOrAdd(type, delegate(Type t)
				{
					//Discarded unreachable code: IL_00c0, IL_00cf, IL_01a2, IL_01b1, IL_01c0
					int num3 = 5;
					_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
					ComponentMetadata componentMetadata = default(ComponentMetadata);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 7:
								if (!_003C_003Ec.k4UhNuZ3CN0nqlavBAJq(_003C_003Ec.oCqQ2KZ3QDbxT6M3UX4d(_003C_003Ec__DisplayClass1_.metadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334892485)))
								{
									goto end_IL_0012;
								}
								goto default;
							case 5:
								_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
								num4 = 4;
								break;
							case 2:
								componentMetadata = (ComponentMetadata)MetadataLoader.LoadMetadata(_003C_003Ec.anwdeOZ3vWJuxmged7lQ(t));
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num4 = 1;
								}
								break;
							case 9:
								return (ValueContainer)_003C_003Ec.fLBBqsZ3IkKtsv9BePIU(_003C_003Ec__DisplayClass1_.metadata.ModuleUid, _003C_003Ec.ElMNoUZ3uHa3jWpyMDrV(componentMetadata), _003C_003Ec.ElMNoUZ3uHa3jWpyMDrV(_003C_003Ec__DisplayClass1_.metadata));
							case 3:
								if (!_003C_003Ec.L3L42YZ3ZiHRYskCdUid(_003C_003Ec.LDsU3GZ38ZosQLaPMhnX(_003C_003Ec__DisplayClass1_.metadata), Guid.Empty))
								{
									num4 = 8;
									break;
								}
								goto case 10;
							case 10:
								return (ValueContainer)_003C_003Ec.fLBBqsZ3IkKtsv9BePIU(_003C_003Ec__DisplayClass1_.metadata.ModuleUid, Guid.Empty, _003C_003Ec.ElMNoUZ3uHa3jWpyMDrV(_003C_003Ec__DisplayClass1_.metadata));
							case 8:
								return (ValueContainer)_003C_003Ec.KRWURUZ3V92rnVEaPar7(_003C_003Ec.ElMNoUZ3uHa3jWpyMDrV(_003C_003Ec__DisplayClass1_.metadata));
							case 1:
								if (!_003C_003Ec.L3L42YZ3ZiHRYskCdUid(_003C_003Ec.LDsU3GZ38ZosQLaPMhnX(_003C_003Ec__DisplayClass1_.metadata), Guid.Empty))
								{
									return new DataClassMetadataValueContainer(componentMetadata.DataClasses.First(_003C_003Ec__DisplayClass1_._003CCreate_003Eb__1));
								}
								num4 = 9;
								break;
							case 4:
								_003C_003Ec__DisplayClass1_.metadata = LoadMetadata(t);
								num4 = 7;
								break;
							default:
								return new DataClassMetadataValueContainer(_003C_003Ec__DisplayClass1_.metadata);
							case 6:
								if (!t.IsNested)
								{
									num4 = 3;
									break;
								}
								goto case 2;
							}
							continue;
							end_IL_0012:
							break;
						}
						num3 = 6;
					}
				});
			}
		}

		internal static ValueContainer CreateViewModelValueContainer(EntityMetadata entityMetadata)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return ViewModelValueContainers.GetOrAdd(wdS8aM8JLKc2lALUI0nu(_003C_003Ec__DisplayClass3_.entityMetadata), _003C_003Ec__DisplayClass3_._003CCreateViewModelValueContainer_003Eb__0);
				default:
					_003C_003Ec__DisplayClass3_.entityMetadata = entityMetadata;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		public static ValueContainer CreateViewModelMetadataHeaderValueContainer(Guid ownerMetadataUid)
		{
			return new ViewModelMetadataHeaderValueContainer(ownerMetadataUid);
		}

		public static ValueContainer Create(Guid metadataUid)
		{
			return DTOHeaderValueContainers.GetOrAdd(metadataUid, (Guid uid) => new DTOHeaderValueContainer(uid));
		}

		public static ValueContainer Create(Guid componentUid, Guid metadataUid)
		{
			return ComponentValueContainers.GetOrAdd((componentUid, metadataUid), delegate((Guid componentUid, Guid metadataUid) t)
			{
				_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
				CS_0024_003C_003E8__locals0.t = t;
				return new DataClassMetadataValueContainer(((ComponentMetadata)ComponentMetadataItemManager.Instance.Load(CS_0024_003C_003E8__locals0.t.componentUid).Metadata).DataClasses.Find((DataClassMetadata m) => _003C_003Ec__DisplayClass8_0.hCaZ4FZ3ndm0fq7GpSJU(m) == CS_0024_003C_003E8__locals0.t.metadataUid));
			});
		}

		public static ValueContainer CreateByHeader(Guid moduleHeaderUid, Guid componentUid, Guid metadataUid)
		{
			return ModuleHeaderValueContainers.GetOrAdd((moduleHeaderUid, componentUid, metadataUid), ((Guid moduleHeaderUid, Guid componentUid, Guid metadataUid) t) => new ModuleHeaderValueContainer(t.moduleHeaderUid, t.componentUid, t.metadataUid));
		}

		public static ValueContainer Create(Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid)
		{
			return ModuleValueContainers.GetOrAdd((moduleUid, moduleItemUid, componentUid, metadataUid), ((Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid) t) => new ModuleValueContainer(t.moduleUid, t.moduleItemUid, t.componentUid, t.metadataUid));
		}

		internal abstract string Initialize(IDictionary<Guid, DataContainer> data);

		protected ValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			L2RcWn8JUPqIVMPXx7Hx();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ValueContainer()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 7:
					ModuleValueContainers = new ConcurrentDictionary<(Guid, Guid, Guid, Guid), ValueContainer>();
					num2 = 5;
					break;
				case 1:
					DTOTypesValueContainers = new ConcurrentDictionary<Type, ValueContainer>();
					num2 = 4;
					break;
				case 3:
					DTOHeaderValueContainers = new ConcurrentDictionary<Guid, ValueContainer>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 6;
					}
					break;
				case 4:
					ViewModelValueContainers = PublishCacheContext.CreateCache(delegate(IDictionary<Guid, ValueContainer> cache, Type _, Guid uid)
					{
						cache.Remove(uid);
					});
					num2 = 3;
					break;
				case 6:
					ComponentValueContainers = new ConcurrentDictionary<(Guid, Guid), ValueContainer>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					ModuleHeaderValueContainers = new ConcurrentDictionary<(Guid, Guid, Guid), ValueContainer>();
					num2 = 7;
					break;
				case 2:
					L2RcWn8JUPqIVMPXx7Hx();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static bool rSivU28J5ksUmHtZXe2w(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static object qx3rpL8JjnH5h78mNLml(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void ylPCBI8JYRxb8nGhJCR7(bool condition, object P_1)
		{
			Contract.CheckArgument(condition, (string)P_1);
		}

		internal static bool XUBGyA8Jr6bY2gPlyuCA()
		{
			return I7AcvZ8JlpEU0y7Ln0bi == null;
		}

		internal static ValueContainer pfMbiD8JgBK08XnAkbP6()
		{
			return I7AcvZ8JlpEU0y7Ln0bi;
		}

		internal static Guid wdS8aM8JLKc2lALUI0nu(object P_0)
		{
			return ((AbstractMetadata)P_0).Uid;
		}

		internal static void L2RcWn8JUPqIVMPXx7Hx()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private sealed class ViewModelContextModelPropertyValueContainer : IPropertyDefaultValueContainer
	{
		private sealed class NestedDefaultValueContainer : IPropertyValueContainerCast, IPropertyValueContainer, IPropertyDefaultValueContainer
		{
			private readonly Guid rootViewModelMetadataUid;

			private readonly Guid modelPropertyUid;

			private readonly object viewModelContextModelPropertyValueContainer;

			private object castedContainer;

			internal static object yqnbiDZ3OWA729NC3xkm;

			Type IPropertyValueContainer.PropertyType
			{
				get
				{
					int num = 2;
					int num2 = num;
					object obj;
					while (true)
					{
						switch (num2)
						{
						case 2:
						{
							object obj2 = castedContainer;
							if (obj2 == null)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num2 = 1;
								}
								continue;
							}
							obj = O9X4mAZ33NHy2xCvgtYy(obj2);
							goto IL_005f;
						}
						case 1:
							obj = null;
							goto IL_005f;
						default:
							{
								obj = TypeOf<IEntity>.Raw;
								break;
							}
							IL_005f:
							if (obj != null)
							{
								break;
							}
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
					return (Type)obj;
				}
			}

			public NestedDefaultValueContainer(Guid rootViewModelMetadataUid, Guid modelPropertyUid, ViewModelContextModelPropertyValueContainer viewModelContextModelPropertyValueContainer)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						return;
					case 1:
						this.modelPropertyUid = modelPropertyUid;
						num = 3;
						continue;
					case 3:
						this.viewModelContextModelPropertyValueContainer = viewModelContextModelPropertyValueContainer;
						num = 2;
						continue;
					}
					this.rootViewModelMetadataUid = rootViewModelMetadataUid;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num = 1;
					}
				}
			}

			object IPropertyValueContainer.Get(object obj)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return YQ6wgVZ3PBkZGBgimwDZ((DataClass)obj, rootViewModelMetadataUid, modelPropertyUid);
					case 1:
						if (castedContainer != null)
						{
							return ((IPropertyValueContainer)castedContainer).Get(obj);
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			void IPropertyValueContainer.Set(object obj, object value)
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						if (castedContainer != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num2 = 0;
							}
						}
						else
						{
							nIGCdXZ3N53qtWO2LsRk((DataClass)obj, rootViewModelMetadataUid, modelPropertyUid, value);
							num2 = 3;
						}
						break;
					case 1:
						zHItTYZ31UocMG1Mc7Uj(castedContainer, obj, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						return;
					case 0:
						return;
					}
				}
			}

			IPropertyValueContainer<T> IPropertyValueContainerCast.Cast<T>()
			{
				if (castedContainer == null)
				{
					NestedDefaultValueContainer<T> nested = new NestedDefaultValueContainer<T>(rootViewModelMetadataUid, modelPropertyUid);
					((ViewModelContextModelPropertyValueContainer)viewModelContextModelPropertyValueContainer).nested = nested;
					castedContainer = nested;
				}
				return (IPropertyValueContainer<T>)castedContainer;
			}

			IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
			{
				return this;
			}

			internal static bool vDK8bSZ32LHZmaqs7fG5()
			{
				return yqnbiDZ3OWA729NC3xkm == null;
			}

			internal static NestedDefaultValueContainer TsLPBEZ3eRywjXLYQUxi()
			{
				return (NestedDefaultValueContainer)yqnbiDZ3OWA729NC3xkm;
			}

			internal static object YQ6wgVZ3PBkZGBgimwDZ(object P_0, Guid metadataUid, Guid propertyUid)
			{
				return ((DataClass)P_0).GetObject(metadataUid, propertyUid);
			}

			internal static void zHItTYZ31UocMG1Mc7Uj(object P_0, object P_1, object P_2)
			{
				((IPropertyValueContainer)P_0).Set(P_1, P_2);
			}

			internal static void nIGCdXZ3N53qtWO2LsRk(object P_0, Guid metadataUid, Guid propertyUid, object P_3)
			{
				((DataClass)P_0).SetObject(metadataUid, propertyUid, P_3);
			}

			internal static Type O9X4mAZ33NHy2xCvgtYy(object P_0)
			{
				return ((IPropertyValueContainer)P_0).PropertyType;
			}
		}

		private sealed class NestedDefaultValueContainer<T> : IPropertyValueContainerCast, IPropertyValueContainer, IPropertyDefaultValueContainer, IPropertyValueContainer<T>
		{
			private readonly Guid rootViewModelMetadataUid;

			private readonly Guid modelPropertyUid;

			private static object ujV8fJZ3pKiWLQBQYCg8;

			Type IPropertyValueContainer.PropertyType => TypeOf<T>.Raw;

			public NestedDefaultValueContainer(Guid rootViewModelMetadataUid, Guid modelPropertyUid)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.modelPropertyUid = modelPropertyUid;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num = 0;
						}
						break;
					default:
						this.rootViewModelMetadataUid = rootViewModelMetadataUid;
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num = 2;
						}
						break;
					}
				}
			}

			object IPropertyValueContainer.Get(object obj)
			{
				return ((DataClass)obj).GetObject(rootViewModelMetadataUid, modelPropertyUid);
			}

			void IPropertyValueContainer.Set(object obj, object value)
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
						((DataClass)obj).SetObject(rootViewModelMetadataUid, modelPropertyUid, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			T IPropertyValueContainer<T>.Get(object obj)
			{
				return (T)((IPropertyValueContainer)this).Get(obj);
			}

			void IPropertyValueContainer<T>.Set(object obj, T value)
			{
				((IPropertyValueContainer)this).Set(obj, (object)value);
			}

			IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
			{
				return this;
			}

			IPropertyValueContainer<T1> IPropertyValueContainerCast.Cast<T1>()
			{
				return (IPropertyValueContainer<T1>)(object)this;
			}

			internal static bool U68cAdZ3acj6Y5tgftLX()
			{
				return ujV8fJZ3pKiWLQBQYCg8 == null;
			}

			internal static object bv229sZ3D7iAecwwe2gW()
			{
				return ujV8fJZ3pKiWLQBQYCg8;
			}
		}

		private object nested;

		private static object O0AK5j8JsftEsumGy3k2;

		public ViewModelContextModelPropertyValueContainer(Guid rootViewModelMetadataUid, Guid modelPropertyUid)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			LlQ8En89F79SfJVlkaLu();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					nested = new NestedDefaultValueContainer(rootViewModelMetadataUid, modelPropertyUid, this);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return (IPropertyValueContainer)lxlbsH89BcD6ioHUFjxG(nested);
		}

		internal static void LlQ8En89F79SfJVlkaLu()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool ce1ArL8JcviaKUWlJ4Rl()
		{
			return O0AK5j8JsftEsumGy3k2 == null;
		}

		internal static ViewModelContextModelPropertyValueContainer OTPLCb8JzZNWlMVwlYXj()
		{
			return (ViewModelContextModelPropertyValueContainer)O0AK5j8JsftEsumGy3k2;
		}

		internal static object lxlbsH89BcD6ioHUFjxG(object P_0)
		{
			return ((IPropertyDefaultValueContainer)P_0).Initialize();
		}
	}

	private IDictionary<Guid, ValueContainer.DataContainer> data;

	private static ContextVars.Local<ConcurrentDictionary<Type, Guid>> uids;

	private static readonly Guid DataClassUid;

	private static DataClass F3W4tqfFKkpE5xxh98xg;

	[Obsolete("TODO: ELMA-29857 Убрать после выноса EleWise.ELMA.SDK.DTO")]
	internal string TypeRef
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeRef_003Ek__BackingField;
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
				case 1:
					_003CTypeRef_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	private static IModuleMetadataLoader ModuleMetadataLoader => Locator.GetServiceNotNull<IModuleMetadataLoader>();

	protected internal DataClass(ValueContainer valueContainer)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Sgw5MefFk5jrpOKqQQ40();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				data = new Dictionary<Guid, ValueContainer.DataContainer>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 2;
				}
				break;
			case 2:
				TypeRef = valueContainer.Initialize(data);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public static bool operator ==(DataClass left, DataClass right)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (object)right == null;
			case 1:
				if ((object)left != null)
				{
					return left.Equals(right);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool operator !=(DataClass left, DataClass right)
	{
		return !(left == right);
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_004e, IL_0075, IL_00b7, IL_00ef, IL_00fe
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				int num;
				if (!zYZtUafFneHV1Eed5AVq(this, obj))
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num = 1;
					}
					goto IL_0052;
				}
				int num2 = 1;
				goto IL_007b;
				IL_007b:
				result = (byte)num2 != 0;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num = 0;
				}
				goto IL_0052;
				IL_0052:
				switch (num)
				{
				default:
					return result;
				case 0:
					return result;
				case 1:
					break;
				}
				num2 = (Equals((DataClass)obj) ? 1 : 0);
				goto IL_007b;
			}
			catch (InvalidCastException)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					}
					result = false;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num3 = 1;
					}
				}
			}
		}
	}

	public bool Equals(DataClass other)
	{
		return data == other?.data;
	}

	internal IEnumerable<DataClassMetadata> GetIncludes(bool onlyFilled)
	{
		return from p in data.If(onlyFilled, (IEnumerable<KeyValuePair<Guid, ValueContainer.DataContainer>> _) => _.Where((KeyValuePair<Guid, ValueContainer.DataContainer> p) => p.Value.Initialized))
			select p.Value.Metadata;
	}

	internal bool Is(Type type)
	{
		return Is(AJOHiWfFO61fTXGWM6aJ(type));
	}

	internal DataClass As(Guid uid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (Is(uid))
				{
					return this;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal object As(Type type)
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 2:
				if (type.IsInstanceOfType(this))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return ((DataClass)EX8LA7fF2OYKNiEf43mr(type)).InitFrom(this);
			case 3:
				if (Is(AJOHiWfFO61fTXGWM6aJ(type)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 1;
			default:
				return this;
			}
		}
	}

	public virtual bool Is<T>() where T : DataClass
	{
		return Is(Uid<T>());
	}

	public T As<T>() where T : DataClass, new()
	{
		object obj;
		if (Is<T>())
		{
			obj = this as T;
			if (obj == null)
			{
				return (T)new T().InitFrom(this);
			}
		}
		else
		{
			obj = null;
		}
		return (T)obj;
	}

	protected bool Is(Guid metadataUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return data.ContainsKey(metadataUid);
			case 1:
				if (metadataUid == DataClassUid)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected DataClass Cast<T>() where T : DataClass, new()
	{
		if (!Is<T>())
		{
			return null;
		}
		return this;
	}

	protected internal object GetObject(Guid metadataUid, Guid propertyUid)
	{
		return GecSmIfFPe3d6874WHRJ(SAqhDofFeW1eEhEexLup(data[metadataUid], propertyUid), this);
	}

	protected internal void SetObject(Guid metadataUid, Guid propertyUid, object value)
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
				Mt0eWjfF1Vtx5cOrFAsR(SAqhDofFeW1eEhEexLup(data[metadataUid], propertyUid), this, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected internal T Get<T>(Guid metadataUid, Guid propertyUid)
	{
		return data[metadataUid][propertyUid].Cast<T>().Get(this);
	}

	protected internal void Set<T>(Guid metadataUid, Guid propertyUid, T value)
	{
		data[metadataUid][propertyUid].Cast<T>().Set(this, value);
	}

	internal static void FillTypesCache(Type type, ISet<Type> typesCast)
	{
		if (!typesCast.Add(type))
		{
			return;
		}
		object[] customAttributes = type.GetCustomAttributes(inherit: false);
		foreach (object obj in customAttributes)
		{
			Type type2 = obj.GetType();
			if (type2.FullName == "EleWise.ELMA.Model.Attributes.IncludeAttribute" && type2.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2023153B), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetValue(obj) is Type type3 && !type3.IsInterface)
			{
				FillTypesCache(type3, typesCast);
			}
		}
	}

	private DataClass InitFrom(DataClass dataClass)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return this;
			case 1:
				data = dataClass.data;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				TypeRef = (string)a07PQ9fFNOCBO9ufBngT(dataClass);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected static Guid Uid(Type type)
	{
		return uids.Value.GetOrAdd(type, delegate(Type t)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					UidAttribute customAttribute = t.GetCustomAttribute<UidAttribute>();
					if (customAttribute != null)
					{
						return customAttribute.Uid;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				default:
					return _003C_003Ec.VRiDu289GTjFG5YWhT5a(t);
				}
			}
		});
	}

	protected static Guid Uid<T>()
	{
		return Uid(TypeOf<T>.Raw);
	}

	internal System.Reflection.PropertyInfo GetProperty(ClassMetadata metadata, PropertyMetadata propertyMetadata)
	{
		return new PropertyInfo(propertyMetadata.Name, VGvhC0fFpcboKfaD0vfR(SAqhDofFeW1eEhEexLup(data[VVhoXpfF3hD16t3mr7Yf(metadata)], VVhoXpfF3hD16t3mr7Yf(propertyMetadata))), VVhoXpfF3hD16t3mr7Yf(metadata), VVhoXpfF3hD16t3mr7Yf(propertyMetadata));
	}

	internal static DataClassMetadata LoadMetadata(Type type, bool inherit = true)
	{
		return MetadataLoader.LoadMetadata(type, inherit) as DataClassMetadata;
	}

	static DataClass()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				DataClassUid = Uid<DataClass>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				Sgw5MefFk5jrpOKqQQ40();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 0;
				}
				break;
			default:
				uids = new ContextVars.Local<ConcurrentDictionary<Type, Guid>>(() => new ConcurrentDictionary<Type, Guid>());
				num2 = 3;
				break;
			case 2:
				return;
			}
		}
	}

	internal static void Sgw5MefFk5jrpOKqQQ40()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool C6IByVfFX5vmu1RDxLuR()
	{
		return (object)F3W4tqfFKkpE5xxh98xg == null;
	}

	internal static DataClass eFejttfFT52V3DPTJBtq()
	{
		return F3W4tqfFKkpE5xxh98xg;
	}

	internal static bool zYZtUafFneHV1Eed5AVq(object P_0, object P_1)
	{
		return P_0.Equals(P_1);
	}

	internal static Guid AJOHiWfFO61fTXGWM6aJ(Type type)
	{
		return Uid(type);
	}

	internal static object EX8LA7fF2OYKNiEf43mr(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object SAqhDofFeW1eEhEexLup(object P_0, Guid propertyUid)
	{
		return ((ValueContainer.DataContainer)P_0)[propertyUid];
	}

	internal static object GecSmIfFPe3d6874WHRJ(object P_0, object P_1)
	{
		return ((IPropertyValueContainer)P_0).Get(P_1);
	}

	internal static void Mt0eWjfF1Vtx5cOrFAsR(object P_0, object P_1, object P_2)
	{
		((IPropertyValueContainer)P_0).Set(P_1, P_2);
	}

	internal static object a07PQ9fFNOCBO9ufBngT(object P_0)
	{
		return ((DataClass)P_0).TypeRef;
	}

	internal static Guid VVhoXpfF3hD16t3mr7Yf(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Type VGvhC0fFpcboKfaD0vfR(object P_0)
	{
		return ((IPropertyValueContainer)P_0).PropertyType;
	}
}
