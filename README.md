https://github.com/fsprojects/FSharp.Data.GraphQL/issues/506

```bash
docker run --rm -it $(docker build -q .)
```

```
Unhandled exception. System.TypeInitializationException: The type initializer for 'FSharp.Data.GraphQL.Net6' threw an exception.
 ---> System.TypeInitializationException: The type initializer for '<StartupCode$fsharp-data-graphql-net-6>.$FSharp.Data.GraphQL.Net6' threw an exception.
 ---> System.IO.FileLoadException: Could not load file or assembly 'FSharp.Core, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'. The located assembly's manifest definition does not match the assembly reference. (0x80131040)
File name: 'FSharp.Core, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
   --- End of inner exception stack trace ---
   at FSharp.Data.GraphQL.Net6..cctor()
   --- End of inner exception stack trace ---
   at FSharp.Data.GraphQL.Net6.main(String[] argv) in /home/Program.fs:line 21
```
