namespace GameZone.Services
{
    public interface ICategorieService
    {
        IEnumerable<SelectListItem> GetSelectList();
    }
}
