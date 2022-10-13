using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadWriteTxtFile
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            if(!Directory.Exists("Test Folder"))
            {
                System.Console.WriteLine("Forder Not Found, So Creating Folder");
                Directory.CreateDirectory("Test Folder");
                System.Console.WriteLine("<<<<<<< Folder Created >>>>>>>");
            }
            else{System.Console.WriteLine("Folder exist!!!");}
            
            
            if(!File.Exists("Test Folder/Test.txt"))
            {
                System.Console.WriteLine("File is Not Found, So Creating File");
                File.Create("Test Folder/Test.txt");
                System.Console.WriteLine("<<<<<<< File Created >>>>>>>");
            }
            else{System.Console.WriteLine("File exist!!!");}
            

            System.Console.WriteLine("Select Option:\n  1.Read File info\n  2.Write File info");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        string line;
                        StreamReader sr=null;
                        try
                        {
                            sr=new StreamReader("Test Folder/Test.txt");
                             line=sr.ReadLine();
                             while (line!=null)
                             {
                                System.Console.WriteLine(line);
                                line=sr.ReadLine();
                             }
                        }
                        catch (System.Exception e)
                        {
                            System.Console.WriteLine("Exception : "+e.Message);
                        }
                        finally
                        {

                            if(sr!=null)
                            {System.Console.WriteLine("Executing Finally Block.");
                            sr.Close();
                            }
                        }

                        break;
                    }
                case 2:
                {
                    StreamWriter sw=null;
                    try
                    {       string[] old=File.ReadAllLines("Test Folder/Test.txt");
                            sw=new StreamWriter("Test Folder/Test.txt");
                            System.Console.WriteLine("Enter new Content for File:");
                            string info = Console.ReadLine();
                            string old1=" ";
                                foreach (var text in old)
                                {
                                    old1=old1+"\n"+text;
                                }
                                old1=old1+"\n"+info;
                                sw.WriteLine(old1);
                        
                    }
                    catch (System.Exception e)
                    {
                        System.Console.WriteLine("Exception : "+e.Message);
                    }
                    finally
                    {
                        System.Console.WriteLine("Entered Finally Block");
                        sw.Close();
                    }
                    break;
                }
                case 3:
                    break;
                default:
                    break;
            }
            
        }
    }
}