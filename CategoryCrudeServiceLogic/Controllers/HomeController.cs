using CategoryCrudeServiceLogic.Data;
using CategoryCrudeServiceLogic.Models;
using CategoryCrudeServiceLogic.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CategoryCrudeServiceLogic.Controllers
{
    public class HomeController : Controller
    {
       private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo
            };

            return View(model);
        }
    }
}
