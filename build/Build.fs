﻿open BlackFox.Fake
open System.IO
open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Tools

open Helpers

initializeContext()

open BasicTasks
open TestTasks
open PackageTasks
open DocumentationTasks
open ReleaseTasks

/// Full release of nuget package, git tag, and documentation for the stable version.
let _release = 
    BuildTask.createEmpty 
        "Release" 
        [clean; buildSolution; runTests; pack; buildDocs; createTag; publishNuget; releaseDocs]

/// Full release of nuget package, git tag, and documentation for the prerelease version.
let _preRelease = 
    BuildTask.createEmpty 
        "PreRelease" 
        [setPrereleaseTag; clean; buildSolution; runTests; packPrerelease; buildDocsPrerelease; createPrereleaseTag; publishNugetPrerelease; prereleaseDocs]

/// Full release of nuget package for the prerelease version.
let _releaseNoDocs = 
    BuildTask.createEmpty 
        "ReleaseNoDocs" 
        [clean; buildSolution; runTests; pack; createTag; publishNuget;]

/// Full release of nuget package for the prerelease version.
let _preReleaseNoDocs = 
    BuildTask.createEmpty 
        "PreReleaseNoDocs" 
        [setPrereleaseTag; clean; buildSolution; runTests; packPrerelease; createPrereleaseTag; publishNugetPrerelease]

ReleaseNotesTasks.updateReleaseNotes |> ignore

[<EntryPoint>]
let main args = 
    runOrDefault buildSolution args
