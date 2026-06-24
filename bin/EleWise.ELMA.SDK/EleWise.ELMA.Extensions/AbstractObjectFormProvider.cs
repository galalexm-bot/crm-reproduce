using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public abstract class AbstractObjectFormProvider : IObjectFormProvider
{
	protected readonly IMetadataRuntimeService MetadataRuntimeService;

	protected readonly ViewModelDescriptor ViewModelDescriptor;

	internal static AbstractObjectFormProvider ie6cdqG3jKjObZ0qF8sO;

	protected AbstractObjectFormProvider(IMetadataRuntimeService metadataRuntimeService, ViewModelDescriptor viewModelDescriptor)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				MetadataRuntimeService = metadataRuntimeService;
				num = 2;
				break;
			case 2:
				ViewModelDescriptor = viewModelDescriptor;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public abstract bool Check(Guid typeUid, Guid subTypeUid);

	public virtual (object, ClassMetadata) GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
	{
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(subTypeUid);
		EntityMetadata entityMetadata = InterfaceActivator.LoadMetadata(typeByUid) as EntityMetadata;
		if (entityMetadata == null)
		{
			return (null, null);
		}
		DataClassMetadata viewModelMetadata = entityMetadata.ViewModelMetadata;
		EntityMetadata entityMetadata2 = null;
		EntityMetadata entityMetadata3 = entityMetadata;
		while (viewModelMetadata == null)
		{
			if (entityMetadata3.ImplementedExtensionUids != null)
			{
				foreach (Guid implementedExtensionUid in entityMetadata3.ImplementedExtensionUids)
				{
					entityMetadata2 = MetadataRuntimeService.GetMetadata(implementedExtensionUid, loadImplementation: false) as EntityMetadata;
					if (entityMetadata2?.ViewModelMetadata != null)
					{
						viewModelMetadata = entityMetadata2.ViewModelMetadata;
						entityMetadata = entityMetadata3;
						break;
					}
				}
			}
			if (entityMetadata3.BaseClassUid == Guid.Empty)
			{
				break;
			}
			entityMetadata3 = (EntityMetadata)MetadataRuntimeService.GetMetadata(entityMetadata3.BaseClassUid);
			if (entityMetadata3.ViewModelMetadata != null)
			{
				viewModelMetadata = entityMetadata3.ViewModelMetadata;
				entityMetadata = entityMetadata3;
				break;
			}
		}
		if (viewModelMetadata != null)
		{
			Assembly assembly = ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97920304), isFullName: false);
			string text = ((!string.IsNullOrWhiteSpace(entityMetadata.ScriptModuleTypeName)) ? entityMetadata.ScriptModuleTypeName.Split(',').First().Trim() : (entityMetadata.Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F8E0B2) + entityMetadata.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2ADB063)));
			string name = text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345264810);
			if (assembly.GetType(name) != null)
			{
				string text2 = ((entityMetadata2 != null) ? entityMetadata2.Name : entityMetadata.Name);
				string name2 = text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE134AB) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC00579);
				Type type = assembly.GetType(name2);
				if (type != null)
				{
					return (DeserializeViewModelContext(model, viewModelMetadata, type), viewModelMetadata);
				}
			}
			return (null, null);
		}
		return (new EntityJsonSerializer().Deserialize(model, typeByUid), entityMetadata);
	}

	public virtual FormViewItem GetFormByType(object obj, ViewType viewType)
	{
		//Discarded unreachable code: IL_0111
		int num = 1;
		int num2 = num;
		FormViewItem formViewItem = default(FormViewItem);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			object obj2;
			switch (num2)
			{
			case 2:
				formViewItem = (FormViewItem)rIRkJ0GpFLqTExBTUuWD(formViewItem);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 6;
				}
				continue;
			case 3:
				if (viewType == ViewType.Display)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 6;
			default:
				if (aMEdLhG3sAty7CfWd5rE(classMetadata) != ClassFormsScheme.FormConstructor)
				{
					num2 = 4;
					continue;
				}
				obj2 = KQRnwwG3zAdAkqjo3YfF(qg6YnjG3crqYOKsuSRrt(classMetadata), viewType);
				break;
			case 5:
				formViewItem = Transform(classMetadata, formViewItem, viewType);
				num2 = 7;
				continue;
			case 6:
				return formViewItem;
			case 1:
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(H1CPZ0G3UZOCGnHKegsr(obj).GetType());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				if (formViewItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 6;
			case 4:
				obj2 = null;
				break;
			}
			formViewItem = (FormViewItem)obj2;
			num2 = 5;
		}
	}

	public virtual FormViewItem GetFormByUid(object obj, Guid formUid)
	{
		//Discarded unreachable code: IL_00d9
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		ClassMetadata classMetadata = default(ClassMetadata);
		FormViewItem formViewItem = default(FormViewItem);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!(_003C_003Ec__DisplayClass6_.formUid == Guid.Empty))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 5:
				_003C_003Ec__DisplayClass6_.formUid = formUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return null;
			case 4:
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(H1CPZ0G3UZOCGnHKegsr(obj).GetType());
				num2 = 2;
				break;
			case 2:
				formViewItem = classMetadata.GetForms().FirstOrDefault(_003C_003Ec__DisplayClass6_._003CGetFormByUid_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 5;
				break;
			case 1:
				return Transform(classMetadata, formViewItem);
			}
		}
	}

	public virtual void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments)
	{
	}

	protected virtual FormViewItem Transform(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType = ViewType.Custom, ItemType itemType = ItemType.Default)
	{
		//Discarded unreachable code: IL_0097
		int num = 8;
		int num2 = num;
		FormViewItemTransformation formViewItemTransformation = default(FormViewItemTransformation);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 9:
				if (JQ3ItQGpBHsik39oJFpp(formViewItemTransformation.Items) == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				_003C_003Ec__DisplayClass8_.itemType = itemType;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 6;
				}
				break;
			case 8:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 7;
				break;
			case 2:
				_003C_003Ec__DisplayClass8_.formViewItem = (FormViewItem)nqyxQuGpWPOuxZ8ZRC0V(_003C_003Ec__DisplayClass8_.formViewItem, formViewItemTransformation);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass8_.formViewItem = formViewItem;
				num2 = 4;
				break;
			case 4:
				_003C_003Ec__DisplayClass8_.viewType = viewType;
				num2 = 5;
				break;
			default:
				return _003C_003Ec__DisplayClass8_.formViewItem;
			case 6:
				formViewItemTransformation = new FormViewItemTransformation();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				formViewItemTransformation.Items.AddRange(from t in _003C_003Ec__DisplayClass8_.formViewItem.GetAllItems().OfType<DefaultContainerViewItem>().Select(_003C_003Ec__DisplayClass8_._003CTransform_003Eb__0)
					where t != null
					select t);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	private object DeserializeViewModelContext(string model, DataClassMetadata viewModelContextMetadata, Type viewModelContextType)
	{
		int num = 5;
		int num2 = num;
		Dictionary<string, object> values = default(Dictionary<string, object>);
		ExpandoObject value = default(ExpandoObject);
		ClassMetadata metadata = default(ClassMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		IActionExecutionParamModel actionExecutionParamModel = default(IActionExecutionParamModel);
		while (true)
		{
			switch (num2)
			{
			default:
				values = new Dictionary<string, object> { 
				{
					(string)YduP8CGpbq8lIl1gxKne(0x638095EB ^ 0x63822C99),
					value
				} };
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				metadata = new ClassMetadata();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			{
				PropertyMetadata propertyMetadata2 = new PropertyMetadata();
				QmbFbSGph77R7AiRXKdX(propertyMetadata2, YduP8CGpbq8lIl1gxKne(-1638402543 ^ -1638576285));
				S0HatyGpEAFRMOaYWAqe(propertyMetadata2, Nnt3XvGpGQBIgoSLw62J(ViewModelDescriptor));
				ixNdXaGpfd8Fh7dHj2yt(propertyMetadata2, viewModelContextMetadata.Uid);
				DataClassSettings dataClassSettings = new DataClassSettings();
				rUVHyQGpQUS1SMp2Qen1(dataClassSettings, RelationType.OneToOne);
				EJswTQGpC5ubKn7iGqbb(propertyMetadata2, dataClassSettings);
				propertyMetadata = propertyMetadata2;
				num2 = 6;
				break;
			}
			case 6:
				value = new JsonSerializer().Deserialize<ExpandoObject>(model);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				ViewModelDescriptor.Deserialize(actionExecutionParamModel, metadata, propertyMetadata, values);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				actionExecutionParamModel = (IActionExecutionParamModel)Activator.CreateInstance(I7dJIKGpo4KwclwghmKr(typeof(ActionExecutionParamModel<>).TypeHandle).MakeGenericType(viewModelContextType));
				num2 = 4;
				break;
			case 2:
				return COHcWZGpvb3j6AAer0Is(actionExecutionParamModel);
			}
		}
	}

	internal static bool c69OKMG3YQVQtubCckpW()
	{
		return ie6cdqG3jKjObZ0qF8sO == null;
	}

	internal static AbstractObjectFormProvider XgsM5BG3LKMpCXwHsGnY()
	{
		return ie6cdqG3jKjObZ0qF8sO;
	}

	internal static object H1CPZ0G3UZOCGnHKegsr(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static ClassFormsScheme aMEdLhG3sAty7CfWd5rE(object P_0)
	{
		return ((ClassMetadata)P_0).FormsScheme;
	}

	internal static object qg6YnjG3crqYOKsuSRrt(object P_0)
	{
		return ((ClassMetadata)P_0).DefaultForms;
	}

	internal static object KQRnwwG3zAdAkqjo3YfF(object P_0, ViewType viewType)
	{
		return ((ClassDefaultForms)P_0).GetForm(viewType);
	}

	internal static object rIRkJ0GpFLqTExBTUuWD(object P_0)
	{
		return ((FormView)P_0).CloneAsReadOnly();
	}

	internal static int JQ3ItQGpBHsik39oJFpp(object P_0)
	{
		return ((List<ViewItemTransformation>)P_0).Count;
	}

	internal static object nqyxQuGpWPOuxZ8ZRC0V(object P_0, object P_1)
	{
		return ((FormViewItem)P_0).Transformate((ViewItemTransformation)P_1);
	}

	internal static Type I7dJIKGpo4KwclwghmKr(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object YduP8CGpbq8lIl1gxKne(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void QmbFbSGph77R7AiRXKdX(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static Guid Nnt3XvGpGQBIgoSLw62J(object P_0)
	{
		return ((TypeDescriptor)P_0).Uid;
	}

	internal static void S0HatyGpEAFRMOaYWAqe(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static void ixNdXaGpfd8Fh7dHj2yt(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}

	internal static void rUVHyQGpQUS1SMp2Qen1(object P_0, RelationType value)
	{
		((DataClassSettings)P_0).RelationType = value;
	}

	internal static void EJswTQGpC5ubKn7iGqbb(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static object COHcWZGpvb3j6AAer0Is(object P_0)
	{
		return ((IActionExecutionParamModel)P_0).Parameter;
	}
}
public abstract class AbstractObjectFormProvider<T> : AbstractObjectFormProvider where T : IEntity
{
	private static object gY5SdnGp8fFvPKRkYKuF;

	protected AbstractObjectFormProvider(IMetadataRuntimeService metadataRuntimeService, ViewModelDescriptor viewModelDescriptor)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(metadataRuntimeService, viewModelDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override bool Check(Guid typeUid, Guid subTypeUid)
	{
		//Discarded unreachable code: IL_0077, IL_0086
		int num = 1;
		int num2 = num;
		Type typeByUidOrNull = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return false;
			default:
				typeByUidOrNull = MetadataRuntimeService.GetTypeByUidOrNull(subTypeUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (typeByUidOrNull != null)
				{
					num2 = 3;
					break;
				}
				return false;
			case 3:
				return typeof(T).IsAssignableFrom(typeByUidOrNull);
			case 1:
				if (!(typeUid != EntityMetadata.UID))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static bool NtvQZFGpZoPDtn0niDRQ()
	{
		return gY5SdnGp8fFvPKRkYKuF == null;
	}

	internal static object SA7OD0GpuN2XhVLBQBLV()
	{
		return gY5SdnGp8fFvPKRkYKuF;
	}
}
