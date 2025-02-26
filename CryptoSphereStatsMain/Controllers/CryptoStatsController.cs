using Microsoft.AspNetCore.Mvc;
using CryptoSphereStats.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoSphereStats.Controllers
{
    public class CryptoStatsController : Controller
    {
        private readonly CryptoService _cryptoService;

        //dependency injection CryptoService
        public CryptoStatsController(CryptoService cryptoService)
        {
            _cryptoService = cryptoService;
        }

        // Action that fetches cryptocurrency data and passes it to the view
        public async Task<IActionResult> CryptoStats()
        {

            List<CryptoData> cryptoData = await _cryptoService.GetCryptoDataAsync();

            return View(cryptoData);
        }
    }
}
