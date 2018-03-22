using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolderFile;
using System.Collections.Generic;
using System;

namespace DesignPatterns
{
    [TestClass]
    public class FolderFileTest
    {
        // Composite
        [TestMethod]
        public void Should_folder_contains_one_element_when_gettings_contains()
        {
            var textFile = new File { Name = "data.txt" };
            var parentFolder = new Folder { Name = "Parent Folder" };
            parentFolder.FoldersOrFiles = new List<IElement> { textFile };

            var containsNumber = parentFolder.GetContainsNumber();
            
            Assert.AreEqual(1, containsNumber);
        }

        [TestMethod]
        public void Should_folder_contains_three_elements_when_gettings_contains()
        {
            var folder = CreateFolderTree();

            var containsNumber = folder.GetContainsNumber();
            
            Assert.AreEqual(2, containsNumber);
        }

        [TestMethod]
        public void Should_Contains_These_3_Paths()
        {
            //Arrange
            var folder = CreateFolderTree();

            // Act
            List<string> everyPath = folder.GetEveryPath();
            string[] rootFolder = everyPath[0].Split('/');
            string[] rootAndfile = everyPath[1].Split('/');
            string[] rootAndFolder = everyPath[2].Split('/');
            
            // Assert
            Assert.AreEqual(rootFolder[0], folder.Name);
            Assert.AreEqual(rootAndfile[0], folder.Name);
            Assert.AreEqual(rootAndfile[1], "data.txt" );
            Assert.AreEqual(rootAndFolder[0], folder.Name);
            Assert.AreEqual(rootAndFolder[1], "Data Folder" );
        }

        [TestMethod]
        public void Should_Sort_3_Empty_Folder()
        {
            //Arrange
            var folders = new List<Folder>{
                new Folder{Name = "BBB"},
                new Folder{Name = "AAA"},
                new Folder{Name = "CCC"},
            };

            // Act
            folders.Sort();
            
            // Assert
            Assert.AreEqual(folders[0].Name, "AAA");
            Assert.AreEqual(folders[1].Name, "BBB");
            Assert.AreEqual(folders[2].Name, "CCC");
        }

        private static Folder CreateFolderTree()
        {
            var textFile = new File { Name = "data.txt" };
            var firstFolder = new Folder { Name = "Data Folder" };
            var secondFolder = new Folder { Name = "Folder" };

            var parentFolder = new Folder { Name = "Parent Folder" };
            parentFolder.FoldersOrFiles = new List<IElement> { firstFolder, textFile };

            return parentFolder;
        }
    }
}
