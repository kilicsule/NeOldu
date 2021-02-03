using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NeOldu.Data.Dal.Core
{
    public interface IFileManager
    {
        Task<string> FileImageSaveAsync(IFormFile resim);
        string FileImageCopyAsync(string resim);
        bool ImageDelete(string resim);
    }
    public class FileManager : IFileManager
    {
        public async Task<string> FileImageSaveAsync(IFormFile image)
        {
            if (image != null && image.Length > 0)
            {
                string imageName = image.FileName.UniqueCodeCreate();
                string filePath = Path.Combine(@"wwwroot\Images\", imageName);
                var file = File.Create(filePath);
                await image.CopyToAsync(file);
                file.Close();
                return imageName;
            }
            return null;
        }

        public string FileImageCopyAsync(string image)
        {
            string imageName = image.UniqueCodeCreate();
            File.Copy(@"wwwroot\Images\" + image, @"wwwroot\Images\" + imageName);
            return imageName;
        }

        public bool ImageDelete(string image)
        {
            if (image != null)
            {
                string filePathDelete = Path.Combine(@"wwwroot\Images\", image);
                if (File.Exists(filePathDelete) && image != null)
                {
                    File.Delete(filePathDelete);
                    return true;
                }
                return false;
            }
            return true;
        }
    }
    public static class GuidStringCode
    {
        public static string UniqueCodeCreate(this string fileName, string fileExtension = null)
        {
            string uz;
            if (fileExtension != null)
            {
                uz = fileExtension;
            }
            else
            {
                uz = fileName.Substring(fileName.LastIndexOf('.'), fileName.Length - fileName.LastIndexOf('.'));
            }
            return Guid.NewGuid().ToString() + uz;
        }
    }
}
