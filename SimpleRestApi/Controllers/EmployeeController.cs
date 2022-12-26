using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SimpleRestApi.Models;

namespace SimpleRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        [HttpPost]
        [Route("search")]
        public async Task<string> GetEmployeeList([FromBody] RequestModel reqModel)
        {
            EmployeeModel employee = new EmployeeModel();
            if (reqModel != null)
            {
                employee.Id = Guid.NewGuid().ToString();
                employee.EmployeeID = "009807";
                employee.FullName = "ZweWaiYanHtet";
                employee.DisplayName = "ZweWaiYanHtet";
                employee.StartDate = "";
                employee.Division = "Technology";
                employee.JobTitle = "Developer";
                employee.Mobile = "09975638342";
                employee.OfficeNumber = "YB2";
                employee.Mail = "zwewaiyanhtet@yomabank.com";
                employee.Department = "Architecture Office";
                employee.Section = "AO";
                employee.Manager = "AungMyoAye";
                employee.City = "Yangon";
                employee.BranchCode = "0057";
                employee.Office = "Head Office";
            }
            return await Task.FromResult(JsonConvert.SerializeObject(employee));
        }

        [HttpPut]
        [Route("update")]
        public string UpdateEmployee([FromBody] EmployeeModel reqModel)
        {
            ResponseModel response = new ResponseModel();
            if (reqModel != null)
            {
                response.Code = "200";
                response.Message = "Success";
                goto Results;
            }
            response.Code = "999";
            response.Message = "Error";
        Results:
            return JsonConvert.SerializeObject(response);
        }
    }
}
