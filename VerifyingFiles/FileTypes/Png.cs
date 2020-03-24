namespace VerifyingFiles
{
    public sealed class Png : FileType
    {
        public Png()
        {
            Name = "PNG";
            Description = "PNG Image";
            AddExtensions("png");
            AddSignatures(
                new byte[] {0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A}
            );
        }
    }
}