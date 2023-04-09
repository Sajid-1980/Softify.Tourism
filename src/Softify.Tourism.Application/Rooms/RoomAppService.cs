using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Softify.Tourism.Authorization;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Authorization.Users;
using Softify.Tourism.Roles.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Softify.Tourism.Project;
using Softify.Tourism.Services.Dto;
using Softify.Tourism.Rooms.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Softify.Tourism.Rooms
{
    [AbpAuthorize(PermissionNames.Pages_Rooms)]
    public class RoomAppService : AsyncCrudAppService<Room, RoomDto, int, PagedRoomResultRequestDto, CreateRoomDto, RoomDto>, IRoomAppService
    {
        public RoomAppService(IRepository<Room> repository)
            : base(repository)
        {
            
        }
        public async Task<SelectList> GetSelectList(object selectedValue = null)
        {
            return new SelectList(await Repository.GetAll().Select(s => new { s.Id, s.RoomType }).ToListAsync(), "Id", "RoomType", selectedValue);
        }
       public async Task<SelectList> GetSelectList1(object selectedValue= null)
        {
            var selectList = new SelectList(await Repository.GetAll().Select(s => new { s.Id, s.RoomNo }).ToListAsync(), "Id", "RoomNo", selectedValue);
            return selectList;
        }

    }
}

