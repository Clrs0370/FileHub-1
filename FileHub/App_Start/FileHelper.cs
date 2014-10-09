/*----------------------------------------------------------------
* Copyright (C) 刘国柱 版权所有。 
* 文件功能描述：
* 创建人：刘国柱		
* 创建时间:2014/10/8 14:24:43 
* 修改人：		
* 修改时间:
* 修改描述： 
*----------------------------------------------------------------*/

using System.Collections.Generic;
using System.IO;
using System.Web;
using FileHub.Models;

namespace FileHub
{
    public class FileHelper
    {

        public FileHelper()
        {
        }

        public static List<MyFile> GetFileList(string path)
        {

            string physicalPath = HttpContext.Current.Request.MapPath(path);
            DirectoryInfo directoryInfo=new DirectoryInfo(physicalPath);
            if (!directoryInfo.Exists)
            {
                Directory.CreateDirectory(physicalPath);
            }

            string[] files= Directory.GetFiles(physicalPath);
            List<MyFile> list=new List<MyFile>();
            FileInfo fileInfo;
            foreach (var file in files)
            {
                fileInfo = new FileInfo(file);
                list.Add(new MyFile
                {
                    FileUrl = path +"/"+fileInfo.Name,
                    FileName = fileInfo.Name,
                    FileSize = fileInfo.Length/1024/1024,
                    FileExtend = fileInfo.Extension
                });
            }

            return list;
        }
    }

}