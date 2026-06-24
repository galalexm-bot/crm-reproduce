using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Bridge.Html5;

namespace EleWise.ELMA.Model.Diagrammer;

public abstract class DiagrammerElement<TCloneable> : IDiagrammerElement, ICloneableObjectLiteral where TCloneable : IDiagrammerElement, new()
{
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public PropertyInfo prop;

		internal bool _003CCopyTo_003Eb__0(PropertyInfo q)
		{
			if (((MemberInfo)q).get_Name() == ((MemberInfo)prop).get_Name())
			{
				return q.get_PropertyType() == prop.get_PropertyType();
			}
			return false;
		}
	}

	private string _003CId_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	private readonly DiagrammerElementKind _003CKind_003Ek__BackingField;

	private HTMLElement _003CPortalElement_003Ek__BackingField;

	private bool _003CSelected_003Ek__BackingField;

	private Action _003COnClick_003Ek__BackingField;

	private Action _003COnDoubleClick_003Ek__BackingField;

	private Action<bool> _003COnSelected_003Ek__BackingField;

	public string Id
	{
		get
		{
			return _003CId_003Ek__BackingField;
		}
		set
		{
			_003CId_003Ek__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public string DisplayName
	{
		get
		{
			return _003CDisplayName_003Ek__BackingField;
		}
		set
		{
			_003CDisplayName_003Ek__BackingField = value;
		}
	}

	public virtual DiagrammerElementKind Kind => _003CKind_003Ek__BackingField;

	public HTMLElement PortalElement
	{
		get
		{
			return _003CPortalElement_003Ek__BackingField;
		}
		set
		{
			_003CPortalElement_003Ek__BackingField = value;
		}
	}

	public bool Selected
	{
		get
		{
			return _003CSelected_003Ek__BackingField;
		}
		set
		{
			_003CSelected_003Ek__BackingField = value;
		}
	}

	public Action OnClick
	{
		get
		{
			return _003COnClick_003Ek__BackingField;
		}
		set
		{
			_003COnClick_003Ek__BackingField = value;
		}
	}

	public Action OnDoubleClick
	{
		get
		{
			return _003COnDoubleClick_003Ek__BackingField;
		}
		set
		{
			_003COnDoubleClick_003Ek__BackingField = value;
		}
	}

	public Action<bool> OnSelected
	{
		get
		{
			return _003COnSelected_003Ek__BackingField;
		}
		set
		{
			_003COnSelected_003Ek__BackingField = value;
		}
	}

	public virtual void CopyTo(IDiagrammerElement element)
	{
		PropertyInfo[] properties = ((object)element).GetType().GetProperties();
		PropertyInfo[] properties2 = base.GetType().GetProperties();
		for (int i = 0; i < properties2.Length; i++)
		{
			_003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass35_0();
			CS_0024_003C_003E8__locals0.prop = properties2[i];
			PropertyInfo val = Enumerable.FirstOrDefault<PropertyInfo>((System.Collections.Generic.IEnumerable<PropertyInfo>)properties, (Func<PropertyInfo, bool>)((PropertyInfo q) => ((MemberInfo)q).get_Name() == ((MemberInfo)CS_0024_003C_003E8__locals0.prop).get_Name() && q.get_PropertyType() == CS_0024_003C_003E8__locals0.prop.get_PropertyType()));
			if (CS_0024_003C_003E8__locals0.prop.get_CanRead() && val.get_CanWrite())
			{
				object obj = null;
				obj = ((!typeof(ICloneableObjectLiteral).IsAssignableFrom(CS_0024_003C_003E8__locals0.prop.get_PropertyType())) ? CS_0024_003C_003E8__locals0.prop.GetValue((object)this) : ((ICloneableObjectLiteral)CS_0024_003C_003E8__locals0.prop.GetValue((object)this)).Clone());
				val.SetValue((object)element, obj);
			}
		}
	}

	public virtual object Clone()
	{
		TCloneable val = new TCloneable();
		CopyTo(val);
		return val;
	}
}
