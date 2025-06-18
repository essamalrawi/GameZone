
namespace GameZone.Controllers
{
    public class GamesController : Controller
    {
        private readonly IDevicesService _devicesService;
        private readonly ICategorieService _categoryService;
        public GamesController( ICategorieService categoryService, IDevicesService devicesService)
        {
            _categoryService = categoryService;
            _devicesService = devicesService;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateGameFormViewModel viewModel = new()
            {
                Categories = _categoryService.GetSelectList(),

                Devices = _devicesService.GetSelectList(),

            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateGameFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _categoryService.GetSelectList();

                model.Devices = _devicesService.GetSelectList();
                return View(model);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
