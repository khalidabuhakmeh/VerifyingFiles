using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VerifyingFiles
{
    public static class FileTypeVerifier
    {
        private static FileTypeVerifyResult Unknown = new FileTypeVerifyResult
        {
            Name = "Unknown",
            Description = "Unknown File Type",
            IsVerified = false
        };
        
        static FileTypeVerifier()
        {
            Types = new List<FileType>
                {
                    new Jpeg(),
                    new Png(),
                    new Mp3()
                }
                .OrderByDescending(x => x.SignatureLength)
                .ToList();
        }

        private static IEnumerable<FileType> Types { get; set; }

        public static FileTypeVerifyResult What(string path)
        {
            using var file = File.OpenRead(path);
            FileTypeVerifyResult result = null;

            foreach (var fileType in Types)
            {
                result = fileType.Verify(file);
                if (result.IsVerified)
                    break;
            }

            return result?.IsVerified == true
                   ? result
                   : Unknown;
        }
    }
}