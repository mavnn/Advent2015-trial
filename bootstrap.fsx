#r "System.IO.Compression"
#r "System.IO.Compression.FileSystem"
#I "packages/Http.fs-prerelease/lib/net40/"
#r "HttpFs.dll"

open System
open System.IO
open System.IO.Compression
open HttpFs.Client

let uri = Uri "http://nlp.stanford.edu/software/stanford-corenlp-full-2015-04-20.zip"

let getZipFile () =
  printfn "Getting Stanford files"
  createRequest Get uri
  |> Request.responseAsBytes
  |> Async.RunSynchronously
  |> fun bytes -> File.WriteAllBytes("stanford.zip", bytes)

let unzipFile file =
  printfn "Unzipping files"
  ZipFile.ExtractToDirectory(file, file |> Path.GetFullPath |> Path.GetDirectoryName)

if not <| Directory.Exists "stanford-corenlp-full-2015-04-20" then
  getZipFile ()
  unzipFile "stanford.zip"
  unzipFile (Path.Combine("stanford-corenlp-full-2015-04-20", "stanford-corenlp-3.5.2-models.jar"))

