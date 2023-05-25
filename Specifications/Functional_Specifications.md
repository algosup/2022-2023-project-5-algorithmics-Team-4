# Functional Specifications - Group 4

Author: [Alexis Lasselin](https://github.com/AlexisLasselin)

---

<details>

<summary>Table of Contents</summary>

- [Functional Specifications - Group 4](#functional-specifications---group-4)
  - [Project Team](#project-team)
  - [I. Introduction](#i-introduction)
    - [1. Project Scope](#1-project-scope)
    - [2. Related Documents](#2-related-documents)
    - [3. Risk and Assumptions](#3-risk-and-assumptions)
  - [II. System Overview](#ii-system-overview)
    - [1. System Actors and Personas](#1-system-actors-and-personas)
      - [A. Stakeholders](#a-stakeholders)
      - [B. Personas](#b-personas)
        - [Persona 1 - Pierre Dupont](#persona-1---pierre-dupont)
        - [Persona 2 - Marc Martin](#persona-2---marc-martin)
        - [Persona 3 - Jean Dupont](#persona-3---jean-dupont)
        - [Persona 4 - Marc Sautier](#persona-4---marc-sautier)
    - [2. Use Cases](#2-use-cases)
    - [3. Technical Terms](#3-technical-terms)
      - [A. Steps](#a-steps)
  - [III. Terms/Acronyms and Definitions](#iii-termsacronyms-and-definitions)

</details>

---

## Project Team

|**Member**|**Role**|
|:---|:---|
|[Salaheddine Namir](https://github.com/T3rryc)| Project manager |
|[Alexis Lasselin](https://github.com/AlexisLasselin)| Program manager |
|[Max Bernard](https://github.com/maxbernard3)| Tech Lead |
|[Victor Leroy](https://github.com/Victor-Leroy)| Software Engineer |
|[Nicolas Mida](https://github.com/Nicolas-Mida)| Quality Assurance |

## I. Introduction

The main objective of this project is to build software that determines the sequences of champagne in the correct proportions for the blending of the Krug Grande Cuvée. Our client for this project is the Champagne House, Krug.

### 1. Project Scope

The main feature of this software is the following:
Depending on pre-entered quantities and with a formula, the software will calculate the correct proportions of Champagne to blend to obtain the Krug Grande Cuvée.

There are the requirements for the software:

- [ ] No crashes and bugs
- [ ] We must not have half-empty tanks because of oxidation that will make the the remaining liquid unusable
- [ ] The final result must be the closest possible to the formula, to the tenth
- [ ] The code must be commented on and in an idiomatic style to be easily readable
- [ ] The result must be given with the minimum number of steps possible (Steps are defined in [the technical terms](#3-technical-terms)
- [ ] The code's execution time must be as fast as possible!

### 2. Related Documents

| **Document** | **Description** |
|:---|:---|
| [Technical Specifications](Technical_Specifications.md) | This document provides detailed information on how the system solution will be built. |

### 3. Risk and Assumptions

| **Risk** | **Impact** | **Mitigation** |
|:---|:---|:---|
| The software is not finished on time | The client will not be able to use the software and will have to do the calculation manually | Make a critical path, respect it, and also deploy good project management |
| The software is not working | The client will not be able to use the software and will have to do the calculation manually | Our QA and our SE will need to work together to find and solve all problems users will be able to meet |
| The software is not user-friendly | If the software is not user-friendly, using it will be hard and a waste of time to understand it | Write instructions and make them clearer as possible |
| The software is not efficient | The champagne's flavors will not be those that are expected or the result is letting some tank partially empty| We will have to redefine our calculations |
| The software is not fast enough | The client will have to wait a long time to get the result | We must ask to the client if he prefer efficiency or speed |

## II. System Overview

<!-- TODO -->

### 1. System Actors and Personas

#### A. Stakeholders

| **Stakeholder** | **Role** | **Presentations** |
|:---|:---|:---|
| ALGOSUP | Project owner | The school who is in charge of the project |
| Franck Jeannin | ALGOSUP CEO | The person who is the contact between the client and the school |
| Krug Client | Client | The client who order the software |
| Julie Cavil | Krug Cellar Master | Someone who knows the formula of the Champagne |
| Team 4 | Project team | The team who will build the software (see [Project Team](#project-team)) |

#### B. Personas

##### Persona 1 - Pierre Dupont

Name: Pierre Dupont
Age: 35
Job: Winemaker
Location: Reims, France

Presentation: Pierre is the owner of 4 domains in Champagne, he's currently preparing the blending of his champagne.
This year, the harvest was very good and he has a lot of high-quality grapes, he wants to make a champagne with a lot of character.
He's looking for software that can help him to mass produce magnums of champagne with the correct proportions, taking stocks and the different tanks he has into account.

##### Persona 2 - Marc Martin

Name: Marc Martin
Age: 42
Job: Cellar Master

Presentation: Marc is the cellar master of a big champagne house, he's currently preparing the blending of the Best Seller of the house.
He has the perfect formula to make the best champagne possible, but he has a lot of tanks and he doesn't want to do the calculations by hand.
He's looking for software that can help him to mass produce bottles of champagne with the correct proportions, taking stocks and the different tanks he has into account.

##### Persona 3 - Jean Dupont

Name: Jean Dupont
Age: 25
Job: Work-study student

Presentation: Jean is a student in oenology, he's currently preparing his thesis on the blending of champagne.
He has the perfect formula for his brother's champagne, but there are a lot of tanks and he doesn't want to do the calculations by hand because he doesn't have the time.
He's looking for an efficient software that can help him to confirm his thesis.

##### Persona 4 - Marc Sautier

Name: Marc Sautier
Age: 15
Job: Student (Trainee in middle school)

Presentation: Marc is a student in middle school, and one of his tasks is to help the cellar master to blend the champagne, precisely to make the count of the stocks for the calculation of the blending. He's not very good at math and he made some mistakes. The cellar master is not happy and he's looking for a software that can help him to do the calculation.

### 2. Use Cases

To be able to use the software, the user will have to follow these steps:

1. Give a .csv file with the stocks of the different tanks;
2. Give the formula of the champagne;
3. The software will calculate the correct proportions of champagne to blend;
4. The software will give the result in a .txt file.
5. The user will be able to use the result to blend the champagne.

The software will be able to be used by the cellar master of a champagne house or by a winemaker.

Here is an example of a .csv file with the stocks of the different tanks:

```csv
Tank Name,Wine name,Capacity
Tank 1,A,5000
Tank 2,B,7500
Tank 3,A,10000
Tank 4, ,2000
Tank 5,C,3000
Tank 6, ,5000
Tank 7,A,8000
```

Here is an example of an input formula of the champagne where, for each wine, the user define the percentage of the wine in the final blend, to the tenth.

```text
B: 56%
C: 40,2%
A: 3,8%
```

If there is an error in the formula (sum different from 100%), the software will return an warning message.

Here is an example of an output file:

```text
Step 1: 5000L of A from Tank 1 to tank 4
Step 2: 7500L of B from Tank 2 to tank 4
Step 3: 10000L of A from Tank 3 to tank 1
Step 4: 2000L of A from Tank 4 to tank 3
etc...
```

### 3. Technical Terms

#### A. Steps

A step is moving wine from 1-5 tanks into 1-5 tanks (5 is a maximum, realistically you are only going to do 2-3 at a time). A step is defined by:

- The wine name;
- The quantity of wine to move;
- The tank from which the wine is taken;
- The tank in which the wine is put.
- The number of the step.

## III. Terms/Acronyms and Definitions

| **Term** | **Acronym(if applicable)** | **Definition** |
|:---|:---|:---|
| Blend | | A mixture of different wines. |
| Cellar Master | | The person in charge of the cellar. |
| Champagne | | Sparkling wine produced from grapes grown in the Champagne region of France following rules that demand secondary fermentation of the wine in the bottle to create carbonation. |
| Krug Grande Cuvée | | The flagship of the House, the Grande Cuvée is the archetype of Krug’s philosophy of craftsmanship and savoir-faire: a blend of more than 120 wines from ten or more different years. |
| Oenology | | The science and study of wine and winemaking. |
| Tank | | A large receptacle or storage chamber, especially for liquid or gas. |
| Winemaker | | A person who makes wine. |
