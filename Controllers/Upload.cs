using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace traveldesk.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class User_registerController : ControllerBase
    {
        private IHostingEnvironment Environment;
        public User_registerController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }
        [HttpPost("upload")]
        public dynamic UploadFile(List<FileUploadModel> file)
        {
            string directoryPath = Path.Combine(Environment.ContentRootPath, "upload");
            for (var i = 0; i < file.Count; i++)
            {
                if (file[i].type == "image/jpeg" || file[i].type == "image/webp" || file[i].type == "image/png")
                {
                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var stringChars = new char[10];
                    var random = new Random();
                    for (int k = 0; k < stringChars.Length; k++)
                    {
                        stringChars[k] = chars[random.Next(chars.Length)];
                    }
                    var finalString = new String(stringChars);
                    string strm = Convert.ToString(file[i].files);
                    Regex regex = new Regex(@"^[\w/\:.-]+;base64,");
                    string base64File = regex.Replace(strm, string.Empty);
                    var bytess = Convert.FromBase64String(base64File);
                    string filepath = $@"{directoryPath}" + $"/Travel_{finalString}.jpeg";
                    using (var imageFile = new FileStream(filepath, FileMode.Create))
                    {
                        imageFile.Write(bytess, 0, bytess.Length);
                        imageFile.Flush();
                    }
                }
                if(file[i].type == "application/pdf"){
                     
                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var stringChars = new char[10];
                    var random = new Random();
                    for (int k = 0; k < stringChars.Length; k++)
                    {
                        stringChars[k] = chars[random.Next(chars.Length)];
                    }
                    var finalString = new String(stringChars);
                    string strm = Convert.ToString(file[i].files);
                    Regex regex = new Regex(@"^[\w/\:.-]+;base64,");
                    string base64File = regex.Replace(strm, string.Empty);
                    var bytess = Convert.FromBase64String(base64File);
                    string filepath = $@"{directoryPath}" + $"/Travel_{finalString}.pdf";
                    using (var imageFile = new FileStream(filepath, FileMode.Create))
                    {
                        imageFile.Write(bytess, 0, bytess.Length);
                        imageFile.Flush();
                    }
                }
            }





            return "rytyu";


        }
    }
}
