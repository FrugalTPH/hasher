# Hasher

This is a rough & ready console app built to provide a quick file & string hashing service. Originally intended for use in MS Access / VBA projects, but provides its functionality as a standalone exe.

The app takes an input string **'src'**, calculates its hash value using the xxHash library, and then saves the hash value as a file at the location you specify with **'trg'**.

## Getting Started

### Installing

* Download the project anywhere.
* Compile a release build.
* Copy hasher.exe from the release folder to the location from which you want to use the app.

### Executing the program

To run the app call hasher.exe with (exactly) three arguments:

```
..\path\to\your\app-location\hasher.exe [hash-type] [src] [trg]
```

For example:

```
'C:\Program Files (portable)\hasher.exe' --s 'This is a test string to hash.' 'C:\ProgramData\YourApp\temp.hash'
```

Note: If your calling app is sending through batch requests for hashes, the calling app will be responsible for managing the target/output file(s). For example, make sure you have retrieved & used 'temp.hash' before submitting another request which would (quietly) overwrite 'temp.hash'.

#### Arguments (required)

| hash-type | Description |
| ------ | ----------- |
| `--s`  | Hashes src as a String. |
| `--f`  | Hashes src based on its File content. |

[src] is the content you want to be hashed.

[trg] is the output file/location.

#### Exceptions

If any arguments are missing, or if there is an unknown error, the application will attempt to write an error log for troubleshooting purposes **'hasher.err'** in the same directory as hasher.exe.



## Version History

* 0.1
    * Initial Release

## License

Copyright 2019 Frugal Consultancy & Design Ltd.

**MIT License**

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
