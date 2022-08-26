using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serialisation_Demo.File_Handling
{
    class File_Demo
    {
        
        
            static void CreateFolder()
            {
                string path = @"E:\Dotnetcore\TestFolder";
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Folder is already exits");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Folder is created");
                }
            }
            static void FileCreate()
            {
                string path = @"E:\Dotnetcore\FileFolder";
                if (Directory.Exists(path))
                {
                    Console.WriteLine("File folder is already exits");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("File folder is created");
                }
            }
            static void Main(string[] args)
            {
                CreateFolder();
                FileCreate();
                Console.ReadLine();

            }
        }
    }








