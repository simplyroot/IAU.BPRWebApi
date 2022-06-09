using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAU.BPRWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost("AddNewObject")]
        public string AddNewObject([FromBody] List<ServiceParameterObject> _data)
        {
            try
            {
                var name = _data.FirstOrDefault(x => x.Key == "_name").Value;
                var surname = _data.FirstOrDefault(x => x.Key == "_surname").Value;

                var student = new StudentObject()
                {
                    Id = 1,
                    Name = name,
                    Surname = surname
                };

                return JsonConvert.SerializedObject(new ApiResult()
                {
                    Message = "Adding a new object is Succesfully",
                    Response = student != null ? JsonConvert.SerializeObject(student) : null,
                    Status = student != null

                });
            }
            catch (Exception)
            {
                return JsonConvert.SerializeObject(new ApiResult()
                {
                    Message = "Adding a new object is Succesfully",
                    Response = null,
                    Status = false
                });
                
            }
        }
    }
}
