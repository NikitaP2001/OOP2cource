using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Diagnostics;


public class Operation
{
    public string[] fileBufer;
    public string[] folderBufer;
    public void Copy(string _CurrentFolder)
    {
        foreach (string s in folderBufer)
        {
            if (s != null)
            {
                DirectoryInfo target = new DirectoryInfo(s);
                string temp = _CurrentFolder + "\\" + target.Name;
                CopyDir(new DirectoryInfo(s), new DirectoryInfo(temp));
            }
            else break;
        }
        foreach (string filename in fileBufer)
        {
            if (filename != null)
            {
                FileInfo target = new FileInfo(filename);
                string temp = _CurrentFolder + "\\" + target.Name;
                CopyFile(filename, temp);
            }
            else break;
        }
        Array.Clear(fileBufer, 0, fileBufer.Length);
        Array.Clear(folderBufer, 0, folderBufer.Length);
    }
    static void CopyDir(DirectoryInfo source, DirectoryInfo target)
    {
        if (source.FullName.ToLower() == target.FullName.ToLower())
        {
            return;
        }

        // Check if the target directory exists, if not, create it.
        if (Directory.Exists(target.FullName) == false)
        {
            Directory.CreateDirectory(target.FullName);
        }

        // Copy each file into it's new directory.
        foreach (FileInfo fi in source.GetFiles())
        {
            Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
            fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
        }

        // Copy each subdirectory using recursion.
        foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
        {
            try
            {
                DirectoryInfo nextTargetSubDir =
                target.CreateSubdirectory(diSourceSubDir.Name);
                CopyDir(diSourceSubDir, nextTargetSubDir);
            } catch { }
        }
    }
    static void CopyFile(string file, string target) {
        if (!File.Exists(target))
        {
            if (File.Exists(target) == false)
            {
                File.Create(target).Close();
            }
            File.Copy(file, target, true);
        }
    }
    public void Delete(string _CurrentFolder)
    {
        foreach (string s in folderBufer)
        {
            if (s != null)
            {
                Directory.Delete(s, true);
            }
            else break;
        }
        foreach (string s in fileBufer)
        {
            if (s != null)
            {
                DirectoryInfo target = new DirectoryInfo(s);
                string temp = _CurrentFolder + "\\" + target.Name;
                File.Delete(temp);
            }
            else break;
        }
        Array.Clear(fileBufer, 0, fileBufer.Length);
        Array.Clear(folderBufer, 0, folderBufer.Length);
    }
    public Operation(int size)
    {
        fileBufer = new string[size];
        folderBufer = new string[size];
    }
    public void CreateFolder(string path, string folder) {
        if (!(path == ""))
        {
            path = folder + "\\" + path;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else throw new Exception("Invalid Name");
        }
        else throw new ArgumentNullException();
    }
    public void CreateFile(string path, string folder)
    {
        if (!(path == ""))
        {
            path = folder + "\\" + path;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else throw new Exception("Invalid Name");
        }
        else throw new ArgumentNullException();
    }
    public void Rename(string file, string name)
    {
        FileInfo fl = new FileInfo(file);
        System.IO.File.Move(file, fl.Directory + "\\" + name);
    }
    public string Read(string file)
    {
        using (var sr = new StreamReader(file))
        {
            var str = sr.ReadToEnd();
            return(str.ToString());
        }
    }
    public void Save(string file, string text)
    {
        using (var sr = new StreamWriter(file))
        {
            sr.Write(text);
            sr.Close();
        }
    }
    public string Read1(string file)
    {
        byte[] bufferArray = File.ReadAllBytes(file);
        string base64EncodedString = Convert.ToBase64String(bufferArray);
        string decodedString = Encoding.UTF8.GetString(bufferArray);
        bufferArray = Convert.FromBase64String(base64EncodedString);
        return (decodedString);
    }
    public string Replace(string str, string target, string text)
    {
        return str.Replace(target, text);
    }
}
namespace Lr3
{
    public class FileSystemExplorer
    {
        public Operation Operation = new Operation(32);
        public List<String> subdir = new List<String>();
        string[] drives;
        public string[] files;
        public string[] filesName;
        public void Refresh()
        {
            CurrentFolder = _CurrentFolder;
        }
        public void GetFiles(string pattern)
        {
            try
            {
                files = Directory.GetFiles(_CurrentFolder, pattern);
                filesName = new string[files.Length];
                for (int i = 0; i < files.Length; i++)
                {
                    filesName[i] = Path.GetFileName(files[i]);
                }
            }
            catch { }
        }
        public void GetFiles(decimal size)
        {
            try
            {
                bool foo(string val, decimal sizze)
                {
             
                    FileInfo fl = new FileInfo(val);
                    if (fl.Length == sizze)
                    {
                        return true;
                    } else return false;
                }
                files = Directory.GetFiles(_CurrentFolder);
                filesName = new string[files.Length];
                files = files.Where(val => foo(val,size)).ToArray();
                for (int i = 0; i < files.Length; i++)
                {
                    filesName[i] = Path.GetFileName(files[i]);
                }
            }
            catch { }
        }
        public void GetFiles(DateTime date)
        {
            try
            {
                bool foo(string val)
                {

                    DateTime modification = File.GetLastWriteTime(val);
                    if ((modification.DayOfYear == date.DayOfYear) && (modification.Year == date.Year))
                    {
                        return true;
                    }
                    else return false;
                }
                files = Directory.GetFiles(_CurrentFolder);
                files = files.Where(val => foo(val)).ToArray();
                filesName = new string[files.Length];
                for (int i = 0; i < files.Length; i++)
                {
                    filesName[i] = Path.GetFileName(files[i]);
                }
            }
            catch { }
        }
        private string _CurrentFolder;
        public string CurrentFolder
        {
            get { return _CurrentFolder; }
            set
            {
                try
                {
                    _CurrentFolder = value;
                    GetSubDirs(value);
                }
                catch { }
            }
        }
        void GetDrives()
        {
            try
            {
                drives = System.IO.Directory.GetLogicalDrives();
            }
            catch (System.IO.IOException)
            {
            }
            catch (System.Security.SecurityException)
            {
            }
        }
        void GetSubDirs(string root)
        {
            try
            {
                subdir = Directory.GetDirectories(root).ToList();
            }
            catch
            {
                subdir.Clear();
            }
        }
        public void GetUpperPath()
        {
            try
            {
                CurrentFolder = Directory.GetParent(_CurrentFolder).ToString();
            }
            catch { }
        }
        public FileSystemExplorer()
        {
            GetDrives();
            CurrentFolder = drives[0];
            GetSubDirs(CurrentFolder);
        }
    }
}