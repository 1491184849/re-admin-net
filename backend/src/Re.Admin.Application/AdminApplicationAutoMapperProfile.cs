using AutoMapper;

using Re.Admin.Entity;
using Re.Admin.Organization.Dtos;
using Re.Admin.System.Dtos;
using Re.Admin.System.LogManagement.Dtos;

namespace Re.Admin;

public class AdminApplicationAutoMapperProfile : Profile
{
    public AdminApplicationAutoMapperProfile()
    {
        CreateMap<SysUser, UserListDto>();
        CreateMap<SysRole, RoleListDto>();
        CreateMap<MenuDto, SysMenu>();
        CreateMap<SysMenu, MenuListDto>();
        CreateMap<DictDto, SysDict>();
        CreateMap<SysDict, DictListDto>();
        CreateMap<SysLoginLog, LoginLogListDto>();
        CreateMap<SysBusinessLog, BusinessLogListDto>();
        CreateMap<OrgPositionGroup, PositionGroupListDto>();
        CreateMap<OrgEmployee, EmployeeListDto>();
        CreateMap<OrgPosition, PositionListDto>();
        CreateMap<OrgDept, DeptListDto>();
    }
}
