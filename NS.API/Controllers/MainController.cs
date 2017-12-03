using NS.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NS.API.Controllers
{
    [RoutePrefix("api/Main")]
    public class MainController : ApiController
    {
        private IMainService _service;

        public MainController(IMainService service)
        {
            _service = service;
        }

        [Route("GetPosts")]
        [HttpGet]
        public Task<HttpResponseMessage> GetPosts()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                var teste = _service.GetPosts();
                response = Request.CreateResponse(HttpStatusCode.OK, teste);
            }
            catch (Exception e)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}
