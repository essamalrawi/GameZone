namespace GameZone.Settings
{
    public static class FileSettings
    {
        public static String ImagesPath = "/assets/images/games";
        public static String AllowExtenstions = ".jpg,.png,.jpeg";
        public static int MaxFileSizeInMB = 1;
        public static int MaxFileSizeInBytes = MaxFileSizeInMB * 1024 * 1024;
    }
}
