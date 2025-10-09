using Infrastructure.DataProvider.Servives.DataBaseServices;
using Microsoft.AspNetCore.Mvc;
using ModelORM.Models;

namespace AlunosApi.Controllers
{
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoDbService alunoDbService;

        public AlunoController(IAlunoDbService alunoDbService)
        {
            this.alunoDbService = alunoDbService;
        }

        [HttpGet("{id:int}", Name = "codigo")]
        public async Task<ActionResult<IAsyncEnumerable<AlunoModel>>> GetAlunosById(Int64 id)
        {
            AlunoModel alunosRet = await alunoDbService.GetById(id);
            if (alunosRet == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, $"Nenhum aluno encontrado com o código: {id}");
            }

            return Ok(alunosRet);
        }

        [HttpPost]
        public async Task<ActionResult<IAsyncResult>> PostAluno([FromBody] AlunoModel aluno)
        {
            AlunoModel newAluno = await alunoDbService.Create(aluno);

            if (newAluno == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar sua solicitação.");
            }

            return StatusCode(StatusCodes.Status201Created, aluno);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<IActionResult>> PutAluno([FromQuery] Int64 id, [FromBody] AlunoModel aluno)
        {
            if (aluno is null || id != aluno.Id)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, aluno);
            }

            AlunoModel alunoEnc = await alunoDbService.GetById(id);

            if (alunoEnc is null)
            {
                return StatusCode(StatusCodes.Status204NoContent, aluno);
            }

            AlunoModel editAluno = await alunoDbService.Update(alunoEnc);

            return StatusCode(StatusCodes.Status202Accepted, aluno);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAluno(Int64 id)
        {
            if (id <= 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"ID inválido {id}");
            }

            AlunoModel alunoEnc = await alunoDbService.GetById(id);

            if (alunoEnc is null)
            {
                return StatusCode(StatusCodes.Status204NoContent, $"Aluno como id {id} não foi encotrado na base de dados.");
            }

            await alunoDbService.Delete(alunoEnc.Id);

            return Ok($"Aluno => {alunoEnc.Id} | {alunoEnc.Nome} - foi deletado com sucesso!");
        }
    }
}
