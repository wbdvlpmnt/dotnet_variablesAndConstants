## Variables and Constants Console App

- Use the 'Problems' tab in VS Code to find and Problems
- When we declare a float, we need to place f at the end of the number to tell .Net that this is a float and not a double. Compiler takes the decimal values as a double but we are trying to store in a float. Therefore the f tells the compiler explicitly that this is a float.
- Note the difference between strings and charecter, interms of quotes.
- Use the shortcut `cw` and then auto complete for a Console.Writeline
- Use `var` keyword to allow c# to decide the variable type for you without having to explicitly specify.
- You can `ctrl` or `apple` click a variable type to dive into the available methods and get some documentation.
- Use the format strings to see what we can store in a variable
- Use constants for handling constants, we cannot reassign a `const`

### To run this project:

- Clone the repository
- run `dotnet build`
- run `dotnet run`

 ![image](https://github.com/wbdvlpmnt/variablesAndConstants/assets/139825457/a579f92f-8297-4274-89a4-674d603d9fe1)


### Useful Commands:

1. `dotnet --help` | Provides help for the SDK
2. `dotnet new gitignore` | Generates a new gitignore file
3. `dotnet run` | Runs app from root dir
4. `dotnet build` | Build the app from root dir
5. `dotnet new console --use-program-main` | Create the console app
