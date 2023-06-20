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

## Technical Architecture

### Technology

- C# Fast, Feature Rich, Member alredy trained
- .NET 6 Needed for c#, Long term suport, Nuget Packages
- Console App

### Input

Files can be created in Exel and be exported to CSV.

- Tanks.csv List all the tanks, their volumes and their content at the start of the process
- Formula.csv Describe the proportion of each wines in the target formula. total should addup  to 1.

*example :*<br>

Tanks.csv
```
100, ''
20, 'water'
200, 'water'
15, 'grenadine'
30, ''
```
Formula.csv
```
0.8, 'water'
0.2, 'grenadine'
```






















