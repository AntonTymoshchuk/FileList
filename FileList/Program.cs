using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> paths = new List<string>();
            //DirectoryInfo user = new DirectoryInfo(@"C:\Users\Lenovo\Pictures\Saved Pictures");
            Console.WriteLine(Directory.GetLastWriteTime(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)));
            Console.ReadLine();
            Console.WriteLine(Directory.GetLastWriteTime(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)));
            Console.ReadLine();
        }
    }

    class Tree
    {

    }

    class TreeItem
    {
        private string path;
        private bool isFolder;
        private List<TreeItem> treeItems = new List<TreeItem>();
        private DateTime lastWriteTime;

        public string Path
        {
            get { return path; }
        }

        public bool IsFolder
        {
            get { return isFolder; }
        }

        public List<TreeItem> Content
        {
            get { return treeItems; }
        }

        public DateTime LastWriteTime
        {
            get { return lastWriteTime; }
        }
    }
}
