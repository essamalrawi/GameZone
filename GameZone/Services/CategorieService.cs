
namespace GameZone.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly ApplicationDbContext _context;

        public CategorieService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> GetSelectList()
        {
          return _context.Categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .AsNoTracking()
                .ToList();
        }
    }
}
