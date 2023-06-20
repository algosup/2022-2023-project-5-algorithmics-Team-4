# Technical Specification

## Deliverable

An application outputing a step by step guide to blend wines into a target formula. The aplication should aim to have as few step as possible

## Requirements and Constrain

- Priority on reducing step over acuracy
- Priority on acuracy over reducing waste
- 5% inacuracy margin for each wines in the final formula
- Size and number of tanks defined by user
- Target formulae defined by user
- Output steps to target formula
- Tanks are either full or empty
- No more than 5 conexions to 1 tank or vice versa, per steps
- Should work with 300 wines in the target formula
- Should work with 400 tanks
- Should finish executing in less than 72 hours in the worst case

## Out of scope

- GUI
- Previous use of tanks

## Technical Architecture

### Technology

- C# Fast, Feature Rich, Member alredy trained
- .NET 6 Needed for c#, Long term suport, Nuget Packages
- Console App

### Input

Files can be created in Exel and be exported to CSV.

- Tanks.csv List all the tanks, their volumes and their content at the start of the process. An identifier will be asigned automaticaly on read coresponding to the tank's Exel table row
- Formula.csv Describe the proportion of each wines in the target formula. total should addup  to 1.

*example :*<br>

Tanks.csv (identifier in between ** are not present in the actual input but are here fro readablility)
```
100, '' *A*
20, 'water' *B*
200, 'water' *C*
15, 'grenadine' *D*
120, '' *E*
80, '' *F*
5, 'grenadine' *G*
```
Formula.csv
```
0.8, 'water'
0.2, 'grenadine'
```

### Output

The output will be writen in the console. It will write the steps taken to achive the end formula. Each step will say from which tank(s) to which tank(s) the transfer is made.<br>
*example :*<br>

```
C to E, F
F, D, G to A
Target formula in A
```






















