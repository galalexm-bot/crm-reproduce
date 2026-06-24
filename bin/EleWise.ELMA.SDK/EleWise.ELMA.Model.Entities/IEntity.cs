using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Model.Entities;

[ExtensionPoint(false, ComponentType.All, ServiceScope.Application)]
[Component]
public interface IEntity : IIdentified
{
	string ToString(string format);

	object GetPropertyValue(Guid propertyUid);

	T GetPropertyValue<T>(Guid propertyUid);

	void SetPropertyValue(Guid propertyUid, object value);

	TSettings GetPropertySettings<TSettings>(Guid propertyUid) where TSettings : TypeSettings;

	TypeSettings GetPropertySettings(Guid propertyUid);

	TypeSettings GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings);

	TypeSettings LoadPropertyInstanceSettings(Guid propertyUid);

	void SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings);

	ITypeSettingsInstanceStore LoadSettingsInstanceStore(bool createIfNotExists, bool loadIfNotLoaded);

	IEnumerable<IEntity> GetContainedEntities();

	IEntity GetRootEntity();

	void Save();

	void Delete();

	void Refresh();

	bool IsNew();

	bool IsDirty();

	Guid[] GetDirtyPropertyUids();
}
[DefaultManager(typeof(EntityManagerMaker))]
public interface IEntity<IdT> : IEntity, IIdentified
{
	IdT Id { get; set; }
}
