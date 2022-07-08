using BookStore.Models.ViewModels;
using BookStore.Models.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;

namespace BookStore.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        ModelRepository _modelRepository = new ModelRepository();

        [Route("roles")]
        [HttpGet]
        [ProducesResponseType(typeof(ListResponse<RoleModel>), (int)HttpStatusCode.OK)]
        public IActionResult GetRoles(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var roles = _modelRepository.GetRoles(pageIndex, pageSize, keyword);
            ListResponse<RoleModel> listResponse = new ListResponse<RoleModel>()
            {
                Results = roles.Results.Select(c => new RoleModel(c)),
                TotalRecords = roles.TotalRecords,
            };

            return Ok(listResponse);
        }

                        
    }
}
