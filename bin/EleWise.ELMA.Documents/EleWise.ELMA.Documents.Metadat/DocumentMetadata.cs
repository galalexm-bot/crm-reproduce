using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.CodeGeneration;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.PublicationBehaviours;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Metadata;

[Serializable]
[XmlRoot("Document")]
[Uid("2b660715-d111-4cc6-acfd-965661719fba")]
public class DocumentMetadata : EntityMetadata
{
	[Component]
	public class Info : IMetadataTypeInfo
	{
		public string Name => SR.T("Документ");

		public string Description => SR.T("Документ с привязкой к базе данных");

		public Type MetadataType => typeof(DocumentMetadata);

		public Type GeneratorType => typeof(DocumentGenerator);
	}

	public static Guid FolderTypeUid = new Guid("b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3");

	private const string DocumentUidS = "2b660715-d111-4cc6-acfd-965661719fba";

	public static string D_UID_S = "2b660715-d111-4cc6-acfd-965661719fba";

	public static Guid D_UID = new Guid(D_UID_S);

	public static string D_IMP_UID_S = "77a266e2-e8df-41ab-82ee-8fd93db77eec";

	public static Guid D_IMP_UID = new Guid(D_IMP_UID_S);

	[NonSerialized]
	[XmlIgnore]
	private LifeCycleDTO _lifeCycleDTO;

	[NonSerialized]
	[XmlIgnore]
	private List<object> _routes;

	[XmlElement("DisableCreate")]
	public virtual bool DisableCreate { get; set; }

	[XmlElement("ControlOnSendingValue")]
	[DefaultValue(false)]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual bool ControlOnSending { get; set; }

	[XmlElement("IsAllowRename")]
	public virtual bool IsAllowRename { get; set; }

	[XmlElement("TemplateName")]
	public virtual string TemplateName { get; set; }

	[XmlElement("UploadButton")]
	public virtual bool UploadButton { get; set; }

	[XmlElement("ScanButton")]
	public virtual bool ScanButton { get; set; }

	[XmlElement("TemplateButton")]
	public virtual bool TemplateButton { get; set; }

	[XmlElement("NeedAnswer")]
	public virtual bool NeedAnswer { get; set; }

	[XmlElement("AnswerDocumentProperty")]
	public virtual Guid AnswerDocumentProperty { get; set; }

	[XmlElement("MultipleRegistration")]
	[DefaultValue(false)]
	[PublicationBehaviour(typeof(NotValueEqualsBehaviour))]
	public virtual bool MultipleRegistration { get; set; }

	[XmlElement("EnableCrypto")]
	[PublicationBehaviour(PublicationType.Delta)]
	public virtual bool EnableCrypto { get; set; }

	[XmlElement("CryptoSettings")]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual CryptoSettings CryptoSettings { get; set; }

	[XmlIgnore]
	public virtual LifeCycleDTO LifeCycle
	{
		get
		{
			return _lifeCycleDTO;
		}
		set
		{
			_lifeCycleDTO = value;
		}
	}

	[XmlElement("UseLifeCycle")]
	public virtual bool UseLifeCycle { get; set; }

	[XmlIgnore]
	public virtual List<object> Routes
	{
		get
		{
			return _routes;
		}
		set
		{
			_routes = value;
		}
	}

	public static List<string> SendableDocumentProperties
	{
		get
		{
			List<string> list = new List<string>();
			list.Add(LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendStatus)));
			list.Add(LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendDate)));
			list.Add(LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendUser)));
			list.Add(LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendDocumentType)));
			list.Add(LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendNumber)));
			list.Add(LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendScanCopy)));
			return list;
		}
	}

	public DocumentMetadata()
	{
		BaseClassUid = D_UID;
		LifeCycle = new LifeCycleDTO();
		Routes = new List<object>();
		UploadButton = true;
		ScanButton = true;
		TemplateButton = true;
		CryptoSettings = new CryptoSettings();
		UseLifeCycle = true;
	}

	public override void InitNew()
	{
		base.InitNew();
		Filterable = true;
	}

	public override void AfterLoad()
	{
		base.AfterLoad();
		if (Filterable && Filter == null)
		{
			Filter = new EntityFilterMetadata();
			Filter.InitNew();
		}
		TitlePropertyUid = Guid.Empty;
		if (ControlOnSending && (Type == EntityMetadataType.Interface || Type == EntityMetadataType.Entity))
		{
			CreateSendDocumentProperties();
		}
	}

	public override PropertyMetadata CreateProperty(bool initNew = false)
	{
		return new DocumentAttributeMetadata
		{
			Uid = Guid.NewGuid()
		};
	}

	public override EntityMetadata CreateInterfaceImplementationMetadata(List<EntityMetadata> extensions = null)
	{
		DocumentMetadata documentMetadata = (DocumentMetadata)base.CreateInterfaceImplementationMetadata(extensions);
		if (extensions != null && extensions.FirstOrDefault() != null && extensions.FirstOrDefault() is DocumentMetadata documentMetadata2)
		{
			documentMetadata.DisplayName = documentMetadata2.DisplayName;
			documentMetadata.TemplateName = documentMetadata2.TemplateName;
			documentMetadata.IsAllowRename = documentMetadata2.IsAllowRename;
			documentMetadata.ControlOnSending = documentMetadata2.ControlOnSending;
			documentMetadata.DisableCreate = documentMetadata2.DisableCreate;
			documentMetadata.MultipleRegistration = documentMetadata2.MultipleRegistration;
			documentMetadata.UploadButton = documentMetadata2.UploadButton;
			documentMetadata.ScanButton = documentMetadata2.ScanButton;
			documentMetadata.TemplateButton = documentMetadata2.TemplateButton;
			documentMetadata.NeedAnswer = documentMetadata2.NeedAnswer;
			documentMetadata.AnswerDocumentProperty = documentMetadata2.AnswerDocumentProperty;
			documentMetadata.EnableCrypto = documentMetadata2.EnableCrypto;
			documentMetadata.CryptoSettings = documentMetadata2.CryptoSettings;
			documentMetadata.UseLifeCycle = documentMetadata2.UseLifeCycle;
		}
		if (documentMetadata != null)
		{
			documentMetadata.TitlePropertyUid = Guid.Empty;
		}
		return documentMetadata;
	}

	public override void LoadFromType(Type type, bool inherit = true)
	{
		base.LoadFromType(type, inherit);
		ControlOnSendingValueAttribute controlOnSendingValueAttribute = (ControlOnSendingValueAttribute)type.GetReflectionCustomAttributes(typeof(ControlOnSendingValueAttribute), inherit: false).FirstOrDefault();
		if (controlOnSendingValueAttribute != null)
		{
			ControlOnSending = controlOnSendingValueAttribute.Value;
		}
		IsAllowRenameAttribute isAllowRenameAttribute = (IsAllowRenameAttribute)type.GetReflectionCustomAttributes(typeof(IsAllowRenameAttribute), inherit: false).FirstOrDefault();
		if (isAllowRenameAttribute != null)
		{
			IsAllowRename = isAllowRenameAttribute.Value;
		}
		TemplateNameAttribute templateNameAttribute = (TemplateNameAttribute)type.GetReflectionCustomAttributes(typeof(TemplateNameAttribute), inherit: false).FirstOrDefault();
		if (templateNameAttribute != null)
		{
			TemplateName = templateNameAttribute.Value;
		}
		MultipleRegistrationAttribute multipleRegistrationAttribute = (MultipleRegistrationAttribute)type.GetReflectionCustomAttributes(typeof(MultipleRegistrationAttribute), inherit: false).FirstOrDefault();
		if (multipleRegistrationAttribute != null)
		{
			MultipleRegistration = multipleRegistrationAttribute.Value;
		}
		DisableCreateAttribute disableCreateAttribute = (DisableCreateAttribute)type.GetReflectionCustomAttributes(typeof(DisableCreateAttribute), inherit: false).FirstOrDefault();
		if (disableCreateAttribute != null)
		{
			DisableCreate = disableCreateAttribute.Value;
		}
		UploadButtonAttribute uploadButtonAttribute = (UploadButtonAttribute)type.GetReflectionCustomAttributes(typeof(UploadButtonAttribute), inherit: false).FirstOrDefault();
		if (uploadButtonAttribute != null)
		{
			UploadButton = uploadButtonAttribute.Value;
		}
		ScanButtonAttribute scanButtonAttribute = (ScanButtonAttribute)type.GetReflectionCustomAttributes(typeof(ScanButtonAttribute), inherit: false).FirstOrDefault();
		if (scanButtonAttribute != null)
		{
			ScanButton = scanButtonAttribute.Value;
		}
		TemplateButtonAttribute templateButtonAttribute = (TemplateButtonAttribute)type.GetReflectionCustomAttributes(typeof(TemplateButtonAttribute), inherit: false).FirstOrDefault();
		if (templateButtonAttribute != null)
		{
			TemplateButton = templateButtonAttribute.Value;
		}
		NeedAnswerAttribute needAnswerAttribute = (NeedAnswerAttribute)type.GetReflectionCustomAttributes(typeof(NeedAnswerAttribute), inherit: false).FirstOrDefault();
		if (needAnswerAttribute != null)
		{
			NeedAnswer = needAnswerAttribute.Value;
		}
		AnswerDocumentPropertyAttribute answerDocumentPropertyAttribute = (AnswerDocumentPropertyAttribute)type.GetReflectionCustomAttributes(typeof(AnswerDocumentPropertyAttribute), inherit: false).FirstOrDefault();
		if (answerDocumentPropertyAttribute != null)
		{
			AnswerDocumentProperty = answerDocumentPropertyAttribute.Value;
		}
		EnableCrypto = AttributeHelper<EnableCryptoAttribute>.GetAttribute(type, inherited: true)?.Value ?? false;
		CryptoSettings attribute = AttributeHelper<CryptoSettings>.GetAttribute(type, inherited: true);
		if (attribute != null)
		{
			CryptoSettings = attribute;
		}
		UseLifeCycleAttribute attribute2 = AttributeHelper<UseLifeCycleAttribute>.GetAttribute(type, inherited: true);
		if (attribute2 != null)
		{
			UseLifeCycle = attribute2.Value;
		}
	}

	public virtual List<DocumentAttributeMetadata> CreateSendDocumentProperties()
	{
		List<DocumentAttributeMetadata> list = new List<DocumentAttributeMetadata>();
		List<PropertyMetadata> properties = Properties.ToList();
		List<PropertyMetadata> list2 = MetadataLoader.GetBaseClassMetadataList(this, includeExtensions: true, loadImplementation: false).SelectMany((ClassMetadata m) => m.Properties).ToList();
		list2.AddRange(Properties);
		try
		{
			string sendStatusProperty = LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendStatus));
			list.Add(CreateSendPropety(sendStatusProperty, EnumDescriptor.UID, list2, delegate(DocumentAttributeMetadata p)
			{
				p.Nullable = false;
				p.SubTypeUid = InterfaceActivator.UID<SendStatus>(loadImplementation: false);
				EnumSettings enumSettings = p.Settings as EnumSettings;
				if (string.IsNullOrEmpty(enumSettings.FieldName))
				{
					enumSettings.FieldName = sendStatusProperty;
				}
				enumSettings.DefaultValue = null;
			}));
			string sendDateProperty = LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendDate));
			list.Add(CreateSendPropety(sendDateProperty, DateTimeDescriptor.UID, list2, delegate(DocumentAttributeMetadata p)
			{
				p.Nullable = true;
				DateTimeSettings dateTimeSettings = p.Settings as DateTimeSettings;
				if (string.IsNullOrEmpty(dateTimeSettings.FieldName))
				{
					dateTimeSettings.FieldName = sendDateProperty;
				}
				dateTimeSettings.RelativeInFilter = true;
				dateTimeSettings.DefaultValue = null;
			}));
			string senderProperty = LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendUser));
			list.Add(CreateSendPropety(senderProperty, EntityDescriptor.UID, list2, delegate(DocumentAttributeMetadata p)
			{
				p.SubTypeUid = InterfaceActivator.UID<IUser>(loadImplementation: false);
				EntitySettings entitySettings2 = p.Settings as EntitySettings;
				if (string.IsNullOrEmpty(entitySettings2.FieldName))
				{
					entitySettings2.FieldName = senderProperty;
				}
				entitySettings2.CascadeMode = CascadeMode.SaveUpdate;
			}));
			string sendDocumentTypeProperty = LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendDocumentType));
			list.Add(CreateSendPropety(sendDocumentTypeProperty, EntityDescriptor.UID, list2, delegate(DocumentAttributeMetadata p)
			{
				p.SubTypeUid = InterfaceActivator.UID<ISendDocumentType>(loadImplementation: false);
				EntitySettings entitySettings = p.Settings as EntitySettings;
				if (string.IsNullOrEmpty(entitySettings.FieldName))
				{
					entitySettings.FieldName = sendDocumentTypeProperty;
				}
				entitySettings.CascadeMode = CascadeMode.SaveUpdate;
			}));
			string sendNumberProperty = LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendNumber));
			list.Add(CreateSendPropety(sendNumberProperty, StringDescriptor.UID, list2, delegate(DocumentAttributeMetadata p)
			{
				StringSettings stringSettings = p.Settings as StringSettings;
				if (string.IsNullOrEmpty(stringSettings.FieldName))
				{
					stringSettings.FieldName = sendNumberProperty;
				}
				stringSettings.MaxValue = 2000;
				stringSettings.DefaultValue = null;
			}));
			string sendScanCopyProperty = LinqUtils.NameOf((Expression<Func<ISendableDocument, object>>)((ISendableDocument d) => d.SendScanCopy));
			list.Add(CreateSendPropety(sendScanCopyProperty, BinaryFileDescriptor.UID, list2, delegate(DocumentAttributeMetadata p)
			{
				p.Filterable = false;
				BinaryFileSettings binaryFileSettings = p.Settings as BinaryFileSettings;
				if (string.IsNullOrEmpty(binaryFileSettings.FieldName))
				{
					binaryFileSettings.FieldName = sendScanCopyProperty;
				}
			}));
		}
		catch
		{
			ControlOnSending = false;
			Properties = properties;
			throw;
		}
		foreach (DocumentAttributeMetadata item in list)
		{
			UpdatePropertyVisibility(item);
		}
		return list;
	}

	public virtual void DeleteSendDocumentProperties()
	{
		foreach (string sendableDocumentProperty in SendableDocumentProperties)
		{
			DeleteSendProperty(sendableDocumentProperty);
		}
	}

	public override DataClassMetadata CreateViewModelMetadata()
	{
		DataClassMetadata dataClassMetadata = base.CreateViewModelMetadata();
		Locator.GetService<IUpdateDocumentViewModelMetadataService>()?.Update(dataClassMetadata);
		return dataClassMetadata;
	}

	protected virtual void UpdatePropertyVisibility(DocumentAttributeMetadata p)
	{
		p.ViewSettings.Attributes.Clear();
		p.ViewSettings.Attributes.Add(new ViewAttribute
		{
			ViewType = ViewType.Create,
			Visibility = Visibility.Hidden
		});
		p.ViewSettings.Attributes.Add(new ViewAttribute
		{
			ViewType = ViewType.Display,
			Visibility = Visibility.Hidden
		});
		p.ViewSettings.Attributes.Add(new ViewAttribute
		{
			ViewType = ViewType.Edit,
			Visibility = Visibility.Hidden
		});
		p.ViewSettings.Attributes.Add(new ViewAttribute
		{
			ViewType = ViewType.List,
			Visibility = Visibility.Hidden
		});
		p.ViewSettings.Attributes.Add(new ViewAttribute
		{
			ViewType = ViewType.Filter,
			Visibility = Visibility.Visible
		});
	}

	protected virtual DocumentAttributeMetadata CreateSendPropety(string propertyName, Guid typeUid, Action<DocumentAttributeMetadata> typeSettingsAction)
	{
		List<PropertyMetadata> list = MetadataLoader.GetBaseClassMetadataList(this, includeExtensions: true, loadImplementation: false).SelectMany((ClassMetadata m) => m.Properties).ToList();
		list.AddRange(Properties);
		return CreateSendPropety(propertyName, typeUid, list, typeSettingsAction);
	}

	protected virtual void DeleteSendProperty(string propertyName)
	{
		PropertyMetadata propertyMetadata = Properties.FirstOrDefault((PropertyMetadata p) => p.Name.Equals(propertyName, StringComparison.Ordinal));
		if (propertyMetadata != null)
		{
			Properties.Remove(propertyMetadata);
		}
	}

	private DocumentAttributeMetadata CreateSendPropety(string propertyName, Guid typeUid, List<PropertyMetadata> allProperties, Action<DocumentAttributeMetadata> typeSettingsAction)
	{
		DocumentAttributeMetadata documentAttributeMetadata = (DocumentAttributeMetadata)allProperties.FirstOrDefault((PropertyMetadata p1) => p1.Name == propertyName && p1.IsSystem);
		if (documentAttributeMetadata != null)
		{
			return documentAttributeMetadata;
		}
		DocumentAttributeMetadata documentAttributeMetadata2 = (DocumentAttributeMetadata)Properties.FirstOrDefault((PropertyMetadata p1) => p1.Name == propertyName);
		if (documentAttributeMetadata2 != null)
		{
			if (typeUid == EntityDescriptor.UID && ((EntitySettings)documentAttributeMetadata2.Settings).RelationType != 0)
			{
				throw new MetadataException(SR.T("Сущность уже содержит свойство с именем \"{0}\", но его тип связи не Одиночная", propertyName));
			}
			if (documentAttributeMetadata2.TypeUid != typeUid)
			{
				throw new MetadataException(SR.T("Сущность уже содержит свойство с именем \"{0}\", но его тип не \"{1}\"", propertyName, typeUid));
			}
			if (!documentAttributeMetadata2.IsSystem)
			{
				int num = Properties.IndexOf(documentAttributeMetadata2);
				PropertyMetadata propertyMetadata = Properties.LastOrDefault((PropertyMetadata p1) => p1.IsSystem);
				int num2 = ((propertyMetadata != null) ? (Properties.IndexOf(propertyMetadata) + 1) : 0);
				if (num > num2)
				{
					Properties.Remove(documentAttributeMetadata2);
					Properties.Insert(num2, documentAttributeMetadata2);
				}
				documentAttributeMetadata2.IsSystem = true;
				documentAttributeMetadata2.Nullable = false;
				documentAttributeMetadata2.Required = false;
			}
			typeSettingsAction?.Invoke(documentAttributeMetadata2);
			return documentAttributeMetadata2;
		}
		documentAttributeMetadata2 = (DocumentAttributeMetadata)CreateProperty(initNew: true);
		documentAttributeMetadata2.IsSystem = true;
		PropertyInfo property2 = typeof(ISendableDocument).GetProperty(propertyName);
		string text = propertyName;
		if (property2 != null)
		{
			EleWise.ELMA.Model.Attributes.DisplayNameAttribute attribute = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute(typeof(ISendableDocument).GetProperty(propertyName), inherited: false);
			if (attribute != null)
			{
				text = attribute.Value;
			}
		}
		documentAttributeMetadata2.DisplayName = text;
		documentAttributeMetadata2.Name = propertyName;
		documentAttributeMetadata2.TypeUid = typeUid;
		documentAttributeMetadata2.Filterable = true;
		PropertyMetadata propertyMetadata2 = Properties.LastOrDefault((PropertyMetadata p1) => p1.IsSystem);
		int index = ((propertyMetadata2 != null) ? (Properties.IndexOf(propertyMetadata2) + 1) : 0);
		typeSettingsAction?.Invoke(documentAttributeMetadata2);
		string fieldName = ((SimpleTypeSettings)documentAttributeMetadata2.Settings).FieldName;
		PropertyMetadata propertyMetadata3 = allProperties.FirstOrDefault((PropertyMetadata property) => property.Settings is SimpleTypeSettings simpleTypeSettings && simpleTypeSettings.FieldName.Equals(fieldName, StringComparison.OrdinalIgnoreCase));
		if (propertyMetadata3 != null)
		{
			throw new MetadataException(SR.T("Сущность уже содержит свойство \"{0}\" с именем в БД \"{1}\"", propertyMetadata3.Name, fieldName));
		}
		Properties.Insert(index, documentAttributeMetadata2);
		return documentAttributeMetadata2;
	}
}
