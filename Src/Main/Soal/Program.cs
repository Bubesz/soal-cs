﻿
using MetaDslx.Core;
using MetaDslx.Soal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = null;
                string outputDirectory = null;
                //bool separateXsdWsdl = false;
                //bool singleFileWsdl = false;
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                    {
                        if (i + 1 < args.Length)
                        {
                            if (args[i] == "-o")
                            {
                                outputDirectory = args[++i];
                            }
                            else 
                            {
                                Console.WriteLine("Unknown option: '"+args[i]+"'");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unknown option: '" + args[i] + "'");
                        }
                    }
                    else
                    {
                        fileName = args[i];
                    }
                }
                if (fileName == null)
                {
                    Console.WriteLine("Usage:");
                    Console.WriteLine("  Soal.exe [options] [input.soal]");
                    Console.WriteLine("Options:");
                    Console.WriteLine("  -o [dir]: output directory");;
                    return;
                }
                if (outputDirectory == null)
                {
                    outputDirectory = Directory.GetCurrentDirectory();
                }
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("Could not find file: "+fileName);
                    return;
                }
                //if (singleFileWsdl && separateXsdWsdl)
                //{
                //    Console.WriteLine("Warning: conflicting options '-separateXsdWsdl' and '-singleFileWsdl'. '-singleFileWsdl' will be used.");
                //}
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string source = reader.ReadToEnd();
                    SpringCompiler compiler = new SpringCompiler(source, Path.GetFileName(fileName));
                    compiler.Compile();
                    if (!compiler.Diagnostics.HasErrors())
                    {
                        Model model = compiler.Model;
                        SpringGenerator generator = new SpringGenerator(compiler.Model, compiler.Diagnostics, compiler.FileName);
                        //generator.SeparateXsdWsdl = separateXsdWsdl;
                        //generator.SingleFileWsdl = singleFileWsdl;
                        generator.OutputDirectory = outputDirectory;
                        generator.Generate();
                        SoalPrinter printer = new SoalPrinter(compiler.Model.Instances);
                        using (StreamWriter writer = new StreamWriter(fileName+"0"))
                        {
                            writer.WriteLine(printer.Generate());
                        }
                    }
                    foreach (var msg in compiler.Diagnostics.GetMessages(true))
                    {
                        Console.WriteLine(msg);
                    }
                }
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
