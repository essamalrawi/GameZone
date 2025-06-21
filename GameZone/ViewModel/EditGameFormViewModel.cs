using GameZone.Attributes;

namespace GameZone.ViewModel
{
    public class EditGameFormViewModel : GameFormViewModel
    {
        public int Id { get; set; }

        public string? CurrentCover { get; set; }

        [AllowedExtensionsAttribute(FileSettings.AllowExtenstions),
    MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile? Cover { get; set; } = default!;
    }
}
