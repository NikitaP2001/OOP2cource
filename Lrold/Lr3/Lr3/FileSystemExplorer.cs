using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Collections.ObjectModel;


public class Dir<T>
{
    private readonly T _addr;
    private readonly List<Dir<T>> _childdir = new List<Dir<T>>();

    public Dir(T dir)
    {
        _addr = dir;
    }

    public Dir<T> this[int i]
    {
        get { return _childdir[i]; }
    }

    public Dir<T> Parent { get; private set; }

    public T Value { get { return _addr; } }

    public ReadOnlyCollection<Dir<T>> Children
    {
        get { return _childdir.AsReadOnly(); }
    }

    public Dir<T> AddChild(T value)
    {
        var node = new Dir<T>(value) { Parent = this };
        _childdir.Add(node);
        return node;
    }

    public Dir<T>[] AddChildren(params T[] values)
    {
        return values.Select(AddChild).ToArray();
    }

    public bool RemoveChild(Dir<T> node)
    {
        return _childdir.Remove(node);
    }

    public void Traverse(Action<T> action)
    {
        action(Value);
        foreach (var child in _childdir)
            child.Traverse(action);
    }

    public IEnumerable<T> Flatten()
    {
        return new[] { Value }.Concat(_childdir.SelectMany(x => x.Flatten()));
    }
}
namespace Lr3
{
    public class FileSystemExplorer
    {
        public List<Dir<String>> root = new List<Dir<String>>();
        void CheckDrives()
        {
            try
            {
                string[] drives = System.IO.Directory.GetLogicalDrives();
                foreach (string str in drives)
                {
                    var node = new Dir<String>(str);
                    root.Add(new Dir<String>(str));
                }
            }
            catch (System.IO.IOException)
            {
                Debug.WriteLine("An I/O error occurs.");
            }
            catch (System.Security.SecurityException)
            {
                Debug.WriteLine("The caller does not have the " +
                    "required permission.");
            }
        }
        void AddDirs(string root)
        {
                List<string> GetDirectories = new List<string>();
                GetDirectories = Directory.GetDirectories(root).ToList();
                foreach (string a in GetDirectories)
                {
                    try
                    {
                        AddDirs(a);
                    }
                    catch
                    {
                    Debug.WriteLine("acess denied");
                    }
                }    
        
        }
        public FileSystemExplorer()
        {
            CheckDrives();
            foreach (Dir<String> d in root)
            {
                AddDirs(d.Value);
            }
        }       
    }
}
