using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.API.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.AutoMaps;

namespace EleWise.ELMA.Documents.API.Service.v1;

[Component]
internal class DocumentVersionModelMapConfigurator : IAutoMapConfigurator
{
	public void Configure(IMapperConfigurationExpression configuration)
	{
		((IProfileExpression)configuration).CreateMap<IDocumentVersion, DocumentVersionModel>().ForMember<long?>((Expression<Func<DocumentVersionModel, long?>>)((DocumentVersionModel vm) => vm.CreationAuthor), (Action<IMemberConfigurationExpression<IDocumentVersion, DocumentVersionModel, long?>>)delegate(IMemberConfigurationExpression<IDocumentVersion, DocumentVersionModel, long?> c)
		{
			c.MapFrom<long?>((Expression<Func<IDocumentVersion, long?>>)((IDocumentVersion dv) => (dv.CreationAuthor != null) ? ((long?)dv.CreationAuthor.Id) : ((long?)null)));
		}).ForMember<long?>((Expression<Func<DocumentVersionModel, long?>>)((DocumentVersionModel vm) => vm.ChangeAuthor), (Action<IMemberConfigurationExpression<IDocumentVersion, DocumentVersionModel, long?>>)delegate(IMemberConfigurationExpression<IDocumentVersion, DocumentVersionModel, long?> c)
		{
			c.MapFrom<long?>((Expression<Func<IDocumentVersion, long?>>)((IDocumentVersion dv) => (dv.ChangeAuthor != null) ? ((long?)dv.ChangeAuthor.Id) : ((long?)null)));
		})
			.ForMember<long?>((Expression<Func<DocumentVersionModel, long?>>)((DocumentVersionModel vm) => vm.BlockAuthor), (Action<IMemberConfigurationExpression<IDocumentVersion, DocumentVersionModel, long?>>)delegate(IMemberConfigurationExpression<IDocumentVersion, DocumentVersionModel, long?> c)
			{
				c.MapFrom<long?>((Expression<Func<IDocumentVersion, long?>>)((IDocumentVersion dv) => (dv.BlockAuthor != null) ? ((long?)dv.BlockAuthor.Id) : ((long?)null)));
			})
			.ForMember<Guid?>((Expression<Func<DocumentVersionModel, Guid?>>)((DocumentVersionModel vm) => vm.FileUid), (Action<IMemberConfigurationExpression<IDocumentVersion, DocumentVersionModel, Guid?>>)delegate(IMemberConfigurationExpression<IDocumentVersion, DocumentVersionModel, Guid?> c)
			{
				c.MapFrom<Guid?>((Expression<Func<IDocumentVersion, Guid?>>)((IDocumentVersion dv) => (dv.File != null) ? ((Guid?)dv.File.Uid) : ((Guid?)null)));
			});
	}
}
