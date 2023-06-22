module Common

open System.Reflection
open System.IO

let internal assembly = Assembly.GetExecutingAssembly()

let internal getEmbeddedResource file = 
    use str = assembly.GetManifestResourceStream($"AnyBadge.NET.Tests.{file}")
    use r = new StreamReader(str)
    r.ReadToEnd()