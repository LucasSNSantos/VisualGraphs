﻿using System;
using System.Diagnostics;
using System.IO;

namespace VisualGraphs.Classes
{
    class LogManager
    {
        private string pathDirectory;

        public LogManager(string path)
        {
            pathDirectory = path;
            if(!Directory.Exists(pathDirectory))
            {
                DirectoryInfo info = Directory.CreateDirectory(pathDirectory);
                Debug.WriteLine("Diretorio criado em : {0}", pathDirectory);
            }
        }

        public static void GenerateLogFile(Grafo g)
        {
            //path = @"C:\Users\souza\Documents\GitHub\VisualGraphs";
            //System.IO.File.WriteAllText(path, g.toString())
        }
    }
}
