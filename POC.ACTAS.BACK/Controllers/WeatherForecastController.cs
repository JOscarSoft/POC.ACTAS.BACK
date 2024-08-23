using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.ACTAS.BACK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _WebHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var serverHtmlPath = _WebHostEnvironment.WebRootPath + @"\ActaPreregistrados.html";
            var serverJsonData = _WebHostEnvironment.WebRootPath + @"\preregistroDATA.json";
            var templateString = System.IO.File.ReadAllText(serverHtmlPath);
            var jsonString = System.IO.File.ReadAllText(serverJsonData);

            var contribuyenteData = JsonConvert.DeserializeObject<Contribuyente>(jsonString);

            var ms = PDFUtility.GeneratePDFFile(FillCertificate(templateString,contribuyenteData));

            return File(ms.ToArray(), "application/pdf", $"Contribuyente-POC-ACTA.pdf");
        }


        private string FillCertificate(string template, Contribuyente contribuyente)
        {
            var mainAddress = contribuyente.localidades.FirstOrDefault(p => p.esPrincipal);
            return template
                .Replace("(P_NOMBRE)", $"{contribuyente.personaFisica.nombres} {contribuyente.personaFisica.apellidos}")
                .Replace("(P_NUM_RNC)", contribuyente.rncCedula)
                .Replace("(P_FECHA_SOLIC)", DateTime.Now.ToString("dd/MM/yyyy"))
                .Replace("(P_NUM_RNC)", contribuyente.rncCedula)
                .Replace("(P_RAZON_SOCIAL)", $"{contribuyente.personaFisica.nombres} {contribuyente.personaFisica.apellidos}")
                .Replace("(P_DIRECCION)", mainAddress.direccion.calle)
                .Replace("(P_SECTOR)", mainAddress.direccion.idSector.ToString())
                .Replace("(P_MUNICIPIO)", mainAddress.direccion.idMunicipio.ToString());
        }
    }
}
