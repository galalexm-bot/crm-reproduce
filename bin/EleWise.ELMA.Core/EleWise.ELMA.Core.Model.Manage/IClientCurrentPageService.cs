using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Managers;

[ServiceContract]
public interface IClientCurrentPageService
{
	System.Threading.Tasks.Task<DataClass> LoadClientComponentMetadataItem(Guid parentItemUid, ComponentViewItem componentViewItem, InterfaceBuilderViewMode viewMode = InterfaceBuilderViewMode.Runtime, bool cacheClear = false);
}
