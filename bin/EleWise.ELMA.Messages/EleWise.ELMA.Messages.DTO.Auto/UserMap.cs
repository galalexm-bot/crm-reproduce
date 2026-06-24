using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.DTO.AutoMaps;

internal sealed class UserMap : BidirectionalMap<IUser, UserDTO>
{
	protected override void InitMap(IMappingExpression<IUser, UserDTO> map)
	{
		base.InitMap(map);
		map.ForMember<string>((Expression<Func<UserDTO, string>>)((UserDTO m) => m.DisplayName), (Action<IMemberConfigurationExpression<IUser, UserDTO, string>>)delegate(IMemberConfigurationExpression<IUser, UserDTO, string> opt)
		{
			opt.MapFrom<string>((Expression<Func<IUser, string>>)((IUser a) => a.GetShortName()));
		});
		map.ForMember<Guid?>((Expression<Func<UserDTO, Guid?>>)((UserDTO m) => m.Avatar), (Action<IMemberConfigurationExpression<IUser, UserDTO, Guid?>>)delegate(IMemberConfigurationExpression<IUser, UserDTO, Guid?> opt)
		{
			opt.MapFrom<Guid?>((Expression<Func<IUser, Guid?>>)((IUser a) => (a.Photo != null) ? ((Guid?)a.Photo.Uid) : ((Guid?)null)));
		});
	}
}
