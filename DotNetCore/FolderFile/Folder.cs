using System.Collections.Generic;
using System;
using System.Globalization;

namespace FolderFile
{
    public class Folder : IComparable, IElement
    {
        public string Name { get; set; }
        
        public List<IElement> FoldersOrFiles { get; set; }

        public int GetContainsNumber()
        {
            int foldersCount = 0;
            if(FoldersOrFiles != null)
            {
                foldersCount = FoldersOrFiles.Count;
            }

            return foldersCount;
        }

        public List<string> GetEveryPath()
        {
            List<string> paths = new List<string>();
            if(!string.IsNullOrEmpty(Name))
                paths.Add(Name + "/");

            if(FoldersOrFiles != null)
                foreach(IElement folderOrFile in FoldersOrFiles)
                {
                    if(folderOrFile is Folder)
                        ((Folder)folderOrFile)?.GetEveryPath().ForEach(path => paths.Add(Name + "/" + path));
                    if(folderOrFile is File)
                        paths.Add(Name + "/" + folderOrFile.Name);
                }
            
            return paths;
        }

        public int CompareTo(object obj)
        {
            Folder folder = obj as Folder;
            if(folder == this 
                || string.Equals(folder.Name, this.Name))
                return 0;
            else
                return - string.Compare(folder.Name, this.Name);
        }
    }
}
