/*----------------------------------------------------------------
* Copyright (C)  版权所有。 
* 文件功能描述：
* 创建人：刘国柱		
* 创建时间:2014/10/8 14:26:44 
* 修改人：		
* 修改时间:
* 修改描述： 
*----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FileHub.Models
{
    public class MyFile
    {
        public MyFile()
        {
        }

        public string FileName { get; set; }

        public long FileSize { get; set; }

        public string FileUrl { get; set; }

        public string FileExtend { get; set; }

        public FileType FileType { get; set; }
    }

    public enum FileType
    {
        Music,
        Video,
        Picture
    }
}