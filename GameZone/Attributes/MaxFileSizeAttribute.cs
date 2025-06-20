namespace GameZone.Attributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
      
            private readonly int _maxSizeFile;

            public MaxFileSizeAttribute(int maxSizeFile)
            {
                _maxSizeFile = maxSizeFile;
            }

            protected override ValidationResult? IsValid
                (object? value, ValidationContext validationContext)
            {
                var file = value as IFormFile;

                if (file is not null)
                {

                    if (file.Length > _maxSizeFile)
                    {
                        return new ValidationResult($"Maxiumm allowed size is {_maxSizeFile} bytes");
                    }
                }

                return ValidationResult.Success;
            }
        }
}
