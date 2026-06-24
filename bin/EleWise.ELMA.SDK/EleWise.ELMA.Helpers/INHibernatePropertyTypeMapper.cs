using System;

namespace EleWise.ELMA.Helpers;

public interface INHibernatePropertyTypeMapper
{
	void Type<TPersistentType>();

	void Type(Type persistentType);

	void Type<TPersistentType>(object parameter);

	void Type(Type persistentType, object parameter);

	void Length(int length);
}
