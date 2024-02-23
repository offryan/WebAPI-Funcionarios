using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Funcionarios.Models;
using WebAPI_Funcionarios.Service.FuncionarioService;

namespace WebAPI_Funcionarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _funcionarioInterface;

        public FuncionarioController(IFuncionarioInterface funcionarioInterface)
        {
            _funcionarioInterface = funcionarioInterface;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
        {
            return Ok(await _funcionarioInterface.GetFuncionarios());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarioById(int id)
        {
            ServiceResponse<FuncionarioModel> serviceResponse = await _funcionarioInterface.GetFuncionarioById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel newFuncionario)
        {
            return Ok(await _funcionarioInterface.CreateFuncionario(newFuncionario));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> UpdateFuncionario(FuncionarioModel EditFuncionario)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.UpdateFuncionario(EditFuncionario);

            return Ok(serviceResponse);
        }



        [HttpPut("InativaFuncionarios")]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> InativaFuncionario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.InativaFuncionario(id);

            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> DeleteFuncionario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.DeleteFuncionario(id);

            return Ok(serviceResponse);
        }
    }
}
