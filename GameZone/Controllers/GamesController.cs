
namespace GameZone.Controllers
{
    public class GamesController : Controller
    {
        private readonly IDevicesService _devicesService;
        private readonly ICategorieService _categoryService;
        private readonly IGamesService _gamesService;
        public GamesController(ICategorieService categoryService,
            IDevicesService devicesService,
            IGamesService gamesService)
        {
            _categoryService = categoryService;
            _devicesService = devicesService;
            _gamesService = gamesService;
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
        public async Task<IActionResult> Create(CreateGameFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _categoryService.GetSelectList();

                model.Devices = _devicesService.GetSelectList();
                return View(model);
            }

           await _gamesService.Create(model);

           return RedirectToAction(nameof(Index));
        }

    }
}
