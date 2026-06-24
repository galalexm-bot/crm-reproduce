using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Signatures;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;

namespace EleWise.ELMA.Model;

public sealed class RenderComponentModel
{
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public EntityDependency newModelEntityDependency;

		internal bool _003CFill_003Eb__0(EntityDependency ed)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)ed).get_HeaderUid() == ((Dependency)newModelEntityDependency).get_HeaderUid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_1
	{
		public PropertySignature property;

		internal bool _003CFill_003Eb__1(PropertySignature a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return a.get_Uid() == property.get_Uid();
		}
	}

	private IDictionary<string, Guid> _003CRenderComponentCache_003Ek__BackingField;

	private IDictionary<Guid, ClientComponentModel> _003CComponentCache_003Ek__BackingField;

	private ClientComponentModel _003CHeader_003Ek__BackingField;

	private System.Collections.Generic.ICollection<EntityDependency> _003CEntityDependencies_003Ek__BackingField;

	private System.Collections.Generic.ICollection<ClientExtensionPointModel> _003CExtensionPoints_003Ek__BackingField;

	private System.Collections.Generic.ICollection<CustomTypeModel> _003CCustomTypes_003Ek__BackingField;

	private bool _003CIsEmpty_003Ek__BackingField;

	public IDictionary<string, Guid> RenderComponentCache
	{
		get
		{
			return _003CRenderComponentCache_003Ek__BackingField;
		}
		private set
		{
			_003CRenderComponentCache_003Ek__BackingField = value;
		}
	}

	public IDictionary<Guid, ClientComponentModel> ComponentCache
	{
		get
		{
			return _003CComponentCache_003Ek__BackingField;
		}
		private set
		{
			_003CComponentCache_003Ek__BackingField = value;
		}
	}

	public ClientComponentModel Header
	{
		get
		{
			return _003CHeader_003Ek__BackingField;
		}
		private set
		{
			_003CHeader_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<EntityDependency> EntityDependencies
	{
		get
		{
			return _003CEntityDependencies_003Ek__BackingField;
		}
		private set
		{
			_003CEntityDependencies_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<ClientExtensionPointModel> ExtensionPoints
	{
		get
		{
			return _003CExtensionPoints_003Ek__BackingField;
		}
		private set
		{
			_003CExtensionPoints_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<CustomTypeModel> CustomTypes
	{
		get
		{
			return _003CCustomTypes_003Ek__BackingField;
		}
		private set
		{
			_003CCustomTypes_003Ek__BackingField = value;
		}
	}

	public bool IsEmpty
	{
		get
		{
			return _003CIsEmpty_003Ek__BackingField;
		}
		private set
		{
			_003CIsEmpty_003Ek__BackingField = value;
		}
	}

	public RenderComponentModel()
	{
		RenderComponentCache = (IDictionary<string, Guid>)(object)new Dictionary<string, Guid>();
		ComponentCache = (IDictionary<Guid, ClientComponentModel>)(object)new Dictionary<Guid, ClientComponentModel>();
		EntityDependencies = (System.Collections.Generic.ICollection<EntityDependency>)new List<EntityDependency>();
		ExtensionPoints = (System.Collections.Generic.ICollection<ClientExtensionPointModel>)new List<ClientExtensionPointModel>();
		CustomTypes = (System.Collections.Generic.ICollection<CustomTypeModel>)new List<CustomTypeModel>();
		IsEmpty = true;
	}

	public RenderComponentModel(RecursiveComponentModel recursiveModel)
		: this()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		Header = recursiveModel.get_Header();
		ExtensionPoints = recursiveModel.get_ExtensionPoints();
		CustomTypes = recursiveModel.get_CustomTypes();
		System.Collections.Generic.IEnumerator<ClientComponentModel> enumerator = ((System.Collections.Generic.IEnumerable<ClientComponentModel>)recursiveModel.get_ComponentCache()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ClientComponentModel current = enumerator.get_Current();
				System.Collections.Generic.IEnumerator<string> enumerator2 = ((System.Collections.Generic.IEnumerable<string>)current.get_RenderUidList()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						string current2 = enumerator2.get_Current();
						RenderComponentCache.set_Item(current2, current.get_ItemUid());
						RenderComponentCache.set_Item(current2, (current.get_ModuleItemUid() == Guid.Empty) ? current.get_ItemUid() : current.get_ModuleItemUid());
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
				if (current.get_ModuleItemUid() == Guid.Empty)
				{
					ComponentCache.set_Item(current.get_ItemUid(), current);
				}
				else
				{
					ComponentCache.set_Item(current.get_ModuleItemUid(), current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		IsEmpty = false;
	}

	public void Fill(RenderComponentModel newModel, bool withClear = false)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		if (newModel == null)
		{
			Clear();
			return;
		}
		IsEmpty = false;
		Header = newModel.Header;
		if (withClear)
		{
			RenderComponentCache = newModel.RenderComponentCache;
			ComponentCache = newModel.ComponentCache;
			EntityDependencies = newModel.EntityDependencies;
			ExtensionPoints = newModel.ExtensionPoints;
			CustomTypes = newModel.CustomTypes;
			return;
		}
		System.Collections.Generic.IEnumerator<KeyValuePair<string, Guid>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, Guid>>)newModel.RenderComponentCache).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				KeyValuePair<string, Guid> current = enumerator.get_Current();
				RenderComponentCache.set_Item(current.get_Key(), current.get_Value());
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		System.Collections.Generic.IEnumerator<KeyValuePair<Guid, ClientComponentModel>> enumerator2 = ((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, ClientComponentModel>>)newModel.ComponentCache).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				KeyValuePair<Guid, ClientComponentModel> current2 = enumerator2.get_Current();
				ComponentCache.set_Item(current2.get_Key(), current2.get_Value());
			}
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
		System.Collections.Generic.IEnumerator<EntityDependency> enumerator3 = ((System.Collections.Generic.IEnumerable<EntityDependency>)newModel.EntityDependencies).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator3).MoveNext())
			{
				_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass30_0();
				CS_0024_003C_003E8__locals0.newModelEntityDependency = enumerator3.get_Current();
				EntityDependency val = Enumerable.FirstOrDefault<EntityDependency>((System.Collections.Generic.IEnumerable<EntityDependency>)EntityDependencies, (Func<EntityDependency, bool>)((EntityDependency ed) => ((Dependency)ed).get_HeaderUid() == ((Dependency)CS_0024_003C_003E8__locals0.newModelEntityDependency).get_HeaderUid()));
				if (val == null)
				{
					EntityDependencies.Add(CS_0024_003C_003E8__locals0.newModelEntityDependency);
					continue;
				}
				System.Collections.Generic.IEnumerator<PropertySignature> enumerator4 = ((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)CS_0024_003C_003E8__locals0.newModelEntityDependency).get_Properties()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator4).MoveNext())
					{
						_003C_003Ec__DisplayClass30_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass30_1();
						CS_0024_003C_003E8__locals1.property = enumerator4.get_Current();
						if (Enumerable.FirstOrDefault<PropertySignature>((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)val).get_Properties(), (Func<PropertySignature, bool>)((PropertySignature a) => a.get_Uid() == CS_0024_003C_003E8__locals1.property.get_Uid())) == null)
						{
							((ClassDependency)val).get_Properties().Add(CS_0024_003C_003E8__locals1.property);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator4)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator3)?.Dispose();
		}
		System.Collections.Generic.IEnumerator<ClientExtensionPointModel> enumerator5 = Enumerable.Where<ClientExtensionPointModel>((System.Collections.Generic.IEnumerable<ClientExtensionPointModel>)newModel.ExtensionPoints, (Func<ClientExtensionPointModel, bool>)((ClientExtensionPointModel el) => !ExtensionPoints.Contains(el))).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator5).MoveNext())
			{
				ClientExtensionPointModel current3 = enumerator5.get_Current();
				ExtensionPoints.Add(current3);
			}
		}
		finally
		{
			((System.IDisposable)enumerator5)?.Dispose();
		}
		System.Collections.Generic.IEnumerator<CustomTypeModel> enumerator6 = Enumerable.Where<CustomTypeModel>((System.Collections.Generic.IEnumerable<CustomTypeModel>)newModel.CustomTypes, (Func<CustomTypeModel, bool>)((CustomTypeModel el) => !CustomTypes.Contains(el))).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator6).MoveNext())
			{
				CustomTypeModel current4 = enumerator6.get_Current();
				CustomTypes.Add(current4);
			}
		}
		finally
		{
			((System.IDisposable)enumerator6)?.Dispose();
		}
	}

	public void Clear()
	{
		Header = null;
		((System.Collections.Generic.ICollection<KeyValuePair<string, Guid>>)RenderComponentCache).Clear();
		((System.Collections.Generic.ICollection<KeyValuePair<Guid, ClientComponentModel>>)ComponentCache).Clear();
		EntityDependencies.Clear();
		ExtensionPoints.Clear();
		CustomTypes.Clear();
		IsEmpty = true;
	}

	private bool _003CFill_003Eb__30_2(ClientExtensionPointModel el)
	{
		return !ExtensionPoints.Contains(el);
	}

	private bool _003CFill_003Eb__30_3(CustomTypeModel el)
	{
		return !CustomTypes.Contains(el);
	}
}
