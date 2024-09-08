using Microsoft.AspNetCore.Http;

namespace Company.Service.Helper;

public class DocumentSettings
{
    public static string UploadFile(IFormFile file, string folderName)
    {
        // 1. Get folder path
        // var folderPath = @"";
        
        var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files", folderName);
        
        // 2. Get file name
        var fileName = $"{Guid.NewGuid()}-{file.FileName}";
        
        // 3. Combine folder path + file path
        var filePath = Path.Combine(folderPath, fileName);
        
        // 4. Save file
        using var fileStream = new FileStream(filePath, FileMode.Create);
        file.CopyTo(fileStream);
        
        return fileName;
    }
}