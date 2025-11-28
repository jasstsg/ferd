namespace FERD.Helpers
{
    public static class ImageHelper
    {
        public static string Serialize(this Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        public static Image Deserialize(this string imageSettingValue)
        {
            byte[] imageBytes = Convert.FromBase64String(imageSettingValue);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
    }
}
