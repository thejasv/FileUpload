using System.ComponentModel.DataAnnotations;

namespace FileUpload.Models
{
    public class FileUploadViewModel
    {
        [Required]
        public IFormFile File { get; set; }
    }

}
