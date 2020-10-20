using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AndroidNativeCore
{
    public class AndroidFileManager
    {
        AndroidJavaObject a;
        public AndroidFileManager()
        {
           a = new AndroidJavaObject(AndroidCore.PluginPackage + ".Core");
        }
        public bool makeDirectory(string path)
        {          
           return a.Call<bool>("createDirectory", path);
        }
        public void writeFile(string path,string child,byte[] data)
        {
            a.Call("writeFile", path,child,data);
        }
        public bool deleteFile(string path)
        {
            return a.Call<bool>("deleteFile", path);
        }
        public byte[] readFile(string path)
        {
           return a.Call<byte[]>("readFile", path);
        }
        public bool isFileExits(string path)
        {
            return a.Call<bool>("isFileExits", path);
        }
    }
}
