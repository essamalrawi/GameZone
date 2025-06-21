using GameZone.Attributes;
namespace GameZone.ViewModel
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        [AllowedExtensionsAttribute(FileSettings.AllowExtenstions),
            MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
