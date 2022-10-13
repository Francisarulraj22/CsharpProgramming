using System;
using System.IO;

namespace FilesAndFolders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path=@"C:\Users\FrancisarulrajAlexan\OneDrive - Syncfusion\Desktop/MyFolder";
            string folderpath=path+"/Arun";
            string filepath=folderpath+"/newFile.txt";

            if(!Directory.Exists(folderpath))
            {
                System.Console.WriteLine("Forder Not Found, So Creating Folder");
                Directory.CreateDirectory(folderpath);

            }
            else{System.Console.WriteLine("Directry Found");}

            if(!File.Exists(filepath))
            {
                System.Console.WriteLine("File is Not found ,So Create New File");
                File.Create(filepath);

            }
            else{System.Console.WriteLine("File Found");}
          System.Console.WriteLine("Select Option:\n1.Create Folder\n2.Create File\n3.Delete Folder\n4.Delete File\n5.Exit");  
          int number=int.Parse(Console.ReadLine());
          switch (number)
          {
            case 1:
                {
                    System.Console.WriteLine("Enter Folder Name You Want to create");
                    string name1=Console.ReadLine();
                    string newpath=path+"\\"+name1;
                    
                    if(!Directory.Exists(newpath))
                    {
                        System.Console.WriteLine("Forder Not Found, So Creating Folder");
                        Directory.CreateDirectory(newpath);

                    }
                    else{System.Console.WriteLine("Directry Found");}
                    break;
                }
            case 2:
            {
                    System.Console.WriteLine("Enter File Name You Want to create:");
                    string name1=Console.ReadLine();
                    System.Console.WriteLine("Enter File Extension You Want to create:");
                    string extension=Console.ReadLine();
                    string newpath=path+"\\"+name1+"."+extension;
                    if(!File.Exists(newpath))
                    {
                        System.Console.WriteLine("File is Not found ,So Create New File");
                        File.Create(newpath);

                    }
                    else{System.Console.WriteLine("File Found");}
                    break;
            }
            case 4:
            {
                foreach (var name in Directory.GetDirectories(path))
                {
                    System.Console.WriteLine(name);
                    
                }
                System.Console.WriteLine("Select File you Want to Delete");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter File Extension You Want to create:");
                string extension=Console.ReadLine();
                string newpath=path+"\\"+name1+"."+extension;
                foreach (var name in Directory.GetFiles(path))
                {
                    if (name==newpath)
                    {
                      File.Delete(newpath);
                      System.Console.WriteLine("File Deleted!!!");  
                    }
                    
                }
                break;
            }
            case 3:
            {
                foreach (var name in Directory.GetDirectories(path))
                {
                    System.Console.WriteLine(name);
                    
                }
                System.Console.WriteLine("Select Folder you Want to Delete");
                string name1=Console.ReadLine();
                string newpath=path+"\\"+name1;
                foreach (var name in Directory.GetDirectories(path))
                {
                    if (name==newpath)
                    {
                      Directory.Delete(newpath);
                      System.Console.WriteLine("Folder Deleted!!!");  
                    }
                   else{System.Console.WriteLine("Ffolder not Found");} 
                }
                break;
            }
            default:
                break;
          }
          
        
        }
        
    }
}