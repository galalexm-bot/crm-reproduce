using System;
using System.Collections.Generic;

namespace EleWise.ELMA.DevServer.TypeDescriptors;

[Obsolete("Не использовать! Указанный API не зафиксирован и может быть изменен или удален в любой момент!", false)]
public interface ITypeDescriptorProvider
{
	IEnumerable<Type> GetTypeDescriptors();
}
