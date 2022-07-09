using Microsoft.AspNetCore.Mvc;
using LessonMonitor.Core.Services;
using LessonMonitor.Core;
using System.Threading.Tasks;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController : ControllerBase
    {
        private readonly IMembersService _membersService;

        public MembersController(IMembersService membersService)
        {
            _membersService = membersService;
        }

        public async Task<Member> Get(int id)
        {
            return await _membersService.Get(id);
        }

        public async Task<Member[]> Get()
        {
            return await _membersService.Get();
        }
    }
}
