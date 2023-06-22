# 2022-2023-project-5-algorithmics-Team-4

## Introduction

To be able to use the program, you need to download the .zip file after clicking on the green button "Code" on the top right of the page. Then, you need to unzip the file and open the folder with your IDE. You can then run the program by using the following commands in the terminal: 

```bash
cd .\ConsoleAppBlend\ConsoleAppBlend\
dotnet run
```

The first command allows you to go to the folder where the program is located meanwhile the second command allows you to run the program.

## How to use the program

The program requires you two files put in the main folder (the one with your README.md and all the subfolders). You must name the first file "formula.csv" and the second "tank.csv".

If you want to use your own files, you must respect the following rules:

- All the files must be in .csv format
- The first file will replace the "formula.csv" file and must contain the following informations: wine ratio and the name of the wine (in this order)
As an example, you can use the following file:

```csv
0.5,Merlot
0.3,Cabernet
0.2,Syrah
```

- The second file will replace the "tank.csv" file and must contain the following informations: tank capacity and, if yes, say the name of the wine that is already in the tank (in this order)
As an example, you can use the following file:

```csv
100,Merlot
200,Cabernet
300,Syrah
600,
```

- To adapt the program to your own files, you must change the following lines in the Program.cs file:

```csharp
ReadCSV.ReadFormula(@"../../yourFormulaFile.csv");

ReadCSV.ReadTank(@"../../yourTankFile.csv");
```

## What the program returns

Once you executed the program, if there is no error, it will create a file named "output.txt" in the main folder. This file will contain the following informations:

```txt
Transfere from tank N°X to tank N°Y
Transfere from tank N°Z to tank N°Y
...
```

The program will also return the following informations in the terminal:

```bash
Execution time: T ms
```
