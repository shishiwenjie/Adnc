﻿using Adnc.Application.Shared.Dtos;
using Adnc.Infra.Entities;
using Adnc.Infra.IRepositories;
using Adnc.Maint.Application.Contracts.Dtos;
using Adnc.Maint.Entities;
using AutoMapper;

namespace Adnc.Maint.Application
{
    public class AdncMaintProfile : Profile
    {
        public AdncMaintProfile()
        {
            CreateMap(typeof(IPagedModel<>), typeof(PageModelDto<>)).ForMember("XData", opt => opt.Ignore());
            CreateMap<OpsLogCreationDto, SysOperationLog>();
            CreateMap<SysOperationLog, OpsLogDto>();
            CreateMap<SysLoginLog, LoginLogDto>();
            CreateMap<SysNloglog, NlogLogDto>();
            CreateMap<SysNloglogProperty, NlogLogPropertyDto>();
            CreateMap<CfgCreationDto, SysCfg>();
            CreateMap<SysCfg, CfgDto>();

            CreateMap<DictCreationDto, SysDict>();
            CreateMap<SysDict, DictDto>();
            CreateMap<SysNotice, NoticeDto>().ReverseMap();

            //CreateMap<TaskSaveInputDto, SysTask>();
            //CreateMap<SysTask, TaskDto>();
            //CreateMap<SysTaskLog, TaskLogDto>().ReverseMap();
        }
    }
}