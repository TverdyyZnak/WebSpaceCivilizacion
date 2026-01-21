using Application.Constans;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebCivAPI.Contracts.ModulesContracts;

namespace WebCivAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModulesController : ControllerBase
    {
        private readonly ModulesConst _modulesConst;
        public ModulesController(ModulesConst modules)
        {
            _modulesConst = modules;
        }

        [HttpGet("description")]
        public ActionResult<IEnumerable<ModuleResponse>> GetModulesDescription()
        {
            var modules = _modulesConst.GetAllModules();
            var responses = modules.Select(m => new ModuleResponse(m.name, m.description, m.lvl));
            return Ok(responses);
        }

    }
}
