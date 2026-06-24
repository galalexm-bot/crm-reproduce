using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Views;

[ServiceContract]
public interface IViewItemInfoService
{
	ViewItemTypeInfo GetInfo(System.Type viewItemType);
}
