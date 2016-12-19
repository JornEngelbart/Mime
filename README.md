# Mime
Simple MIME type guesser for .NET and .NET Core.

## Install
via [NuGet](https://www.nuget.org/packages/Mime):
```
PM> Install-Package Mime
```

## Requirements
Currently supports only Linux based OS(ex. Ubuntu 16.04), if you want to use package in Windows or MacOS, then you need to manually install libmagic(see [this](https://github.com/hey-red/Mime/issues/9#issuecomment-256984707) issue).

Open issue [here](https://github.com/hey-red/libmagic-package) if u want to maintain native libs for other OS.

## Usage
```C#
using HeyRed.Mime;

// (Optionally) You can set path to magic database file manually.
MimeGuesser.MagicFilePath = "/path/to/magic/file";

// Guess mime type of file(overloaded method takes byte array or stream as arg.)
MimeGuesser.GuessMimeType("path/to/file") //=> image/jpeg

// Get extension of file(overloaded method takes byte array or stream as arg.)
MimeGuesser.GuessExtension("path/to/file") //=> jpeg

// Get mime type and extension of file(overloaded method takes byte array or stream as arg.)
MimeGuesser.GuessFileType("path/to/file") //=> FileType
```
Also available extension methods for FileInfo.

## License
[MIT](\LICENSE)
