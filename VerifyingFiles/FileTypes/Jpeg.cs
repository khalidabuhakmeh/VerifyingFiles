namespace VerifyingFiles
{
    public sealed class Jpeg : FileType
    {
        public Jpeg()
        {
            Name = "JPEG";
            Description = "JPEG IMAGE";
            AddExtensions("jpeg", "jpg");
            AddSignatures(
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 },
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE2 },
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE3 }
            );
        }
    }
}