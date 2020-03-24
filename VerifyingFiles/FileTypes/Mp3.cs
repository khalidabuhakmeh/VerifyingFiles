namespace VerifyingFiles
{
    public sealed class Mp3 : FileType
    {
        public Mp3()
        {
            Name = "MP3";
            Description = "MP3 Audio File";
            AddExtensions("mp3");
            AddSignatures(
                new byte[] { 0x49, 0x44, 0x33 }
            );
        }
    }
}