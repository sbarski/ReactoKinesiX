﻿namespace System
open System.Reflection
open System.Runtime.CompilerServices

[<assembly: AssemblyTitleAttribute("ReactoKinesix")>]
[<assembly: AssemblyProductAttribute("ReactoKinesix")>]
[<assembly: AssemblyDescriptionAttribute("A Rx-based .Net client library for Amazon Kinesis")>]
[<assembly: AssemblyVersionAttribute("0.2.1")>]
[<assembly: AssemblyFileVersionAttribute("0.2.1")>]
[<assembly: InternalsVisibleToAttribute("ReactoKinesiX.Tests")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.1"
