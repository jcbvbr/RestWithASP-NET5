using Microsoft.AspNetCore.Http;
using RestWithASPNET.Data.VO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithASPNET.Business
{
    public interface IFileBusiness
    {
        byte[] GetFile(string filename);
        Task<FileDetailVO> SaveFileToDisk(IFormFile file);
        Task<List<FileDetailVO>> SaveFilesToDisk(IList<IFormFile> file);
    }
}
