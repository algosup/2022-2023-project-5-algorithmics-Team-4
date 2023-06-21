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
- Configurable option (eg. acuracy margin)

## Technical Architecture and Choices

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

### Assumptions

- It doesn't matter what the specified wine amounts add up to
- Wine can be removed from the system
- Wine canot be added to the system
- the optimal result may be impossible to find

## Algorithms 

We will use a greedy algorithm that looks for the transfere that get us the closest to the target every time.<br>
A number of posiblity can be dismissed from consideration by the algorithm :

- tanks that are alredy full
- tanks that are larger than the sum of the transfere
- to futher improve execution time we could remove tanks at random at the cost of acuracy

*acknowledgement*<br>
This might not give the optimal result but it is hope that it will reduce processing time to a more managable number. <br>
An improved version could look several step ahead.

## Program

### Class

**Input :**
- Target formula
- List of all Tanks

**Tank :** *describe one tank*
- identifier
- volume
- Array of ratio of contained wine
- Array contained wines

**Formula :** *hold the target formula*
- Array of ratio
- Array of wines

## Development Steps

- Make some unit test
- Make a prototype to comply with the test
- Make an algorithm taking the 1st valid mix
- Make the greedy algorithm
- Check the limit of the Algorithm (larger imput size) and benchmark
- Expand test case to find issues
