using DBFramework;
using System;
using System.Data;
using System.Web.Http;

namespace CrushMateBackendAPI.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/usertypes")]
        public IHttpActionResult GetUserTypes()
        {
            try
            {
                DataSet ds = DBHD.ExecuteQuery_SP("SelectUserTypesForDropdown");

                return Ok(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}