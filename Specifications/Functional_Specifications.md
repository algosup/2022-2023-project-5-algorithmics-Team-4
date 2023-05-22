# Functional Specifications - Group 4

Author: [Alexis Lasselin](https://github.com/AlexisLasselin)

---

<details>

<summary>Table of Contents</summary>

- [Functional Specifications - Group 4](#functional-specifications---group-4)
  - [Project Team](#project-team)
  - [I. Introduction](#i-introduction)
    - [1. Purpose of the document](#1-purpose-of-the-document)
    - [2. Project Scope](#2-project-scope)
    - [3. Scope of the Document](#3-scope-of-the-document)
    - [4. Related Documents](#4-related-documents)
    - [5. Terms/Acronyms and Definitions](#5-termsacronyms-and-definitions)
    - [6. Risk and Assumptions](#6-risk-and-assumptions)
  - [II. System Overview](#ii-system-overview)
    - [1. System Actors and Personas](#1-system-actors-and-personas)
      - [A. Stakeholders](#a-stakeholders)
      - [B. Personas](#b-personas)
        - [Persona 1](#persona-1)
        - [Persona 2](#persona-2)
    - [2. Use Cases](#2-use-cases)

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

The main objective of this project is to build a software who determine the quantities of champagne in the correct proportions for the blending of the Krug Grande Cuvée. Our client for this project is the Champagne House Krug.

### 1. Purpose of the document

The Functional Specification Document is a document that provides detailed information on how the system solution will function and the requested behavior. Included in this document will be the detailed functional requirements.
This document will be updated as needed throughout the project to reflect any changes to the system solution.

### 2. Project Scope

The main feature of this software is the following:
Depending of pre-entered quantities and with a formula, the software will calculate the correct proportions of Champagne to blend in order to obtain the Krug Grande Cuvée.

There are the requirements for the software:

- [ ] No crash and bugs
- [ ] We must not have half empty tanks, oxidation will make the champagne unusable
- [ ] The final result must be the closest possible to the formula
- [ ] The code must be commented and in an idiomatic style to be easily readable
- [ ] The result must be find with the minimum number of steps possible
- [ ] The code's execution time must be the fastest possible

### 3. Scope of the Document

This document will be used by the project team to build the software. It will be used as a reference for the project team to ensure that the software is built to the specifications outlined in this document. This document will also be used by the project team to ensure that the software is built to the specifications outlined in this document.

### 4. Related Documents

| **Document** | **Description** |
|:---|:---|
| [Technical Specifications](Technical_Specifications.md) | This document provides detailed information on how the system solution will be built. |

### 5. Terms/Acronyms and Definitions

| **Term** | **Acronym(if applicable)** | **Definition** |
|:---|:---|:---|
| Champagne | | Sparkling wine produced from grapes grown in the Champagne region of France following rules that demand secondary fermentation of the wine in the bottle to create carbonation. |
| Krug Grande Cuvée | | The flagship of the House, the Grande Cuvée is the archetype of Krug’s philosophy of craftsmanship and savoir faire: a blend of more than 120 wines from ten or more different years. |
| Tank | | A large receptacle or storage chamber, especially for liquid or gas. |

### 6. Risk and Assumptions

| **Risk** | **Impact** | **Mitigation** |
|:---|:---|:---|
| The software is not finished on time | The client will not be able to use the software and will have to do the blending manually | Make a critical path, respect it and also deploy a good project management |
| The software is not working | The client will not be able to use the software and will have to do the blending manually | Our QA and our SE will need to work together to find and solve all problems users will be able to meet |
| The software is not user friendly | If the software is not user-friendly, use it will be hard and a waste of time to understand it | Write instructions and make them clearer as possible |
| The formula is not close to the final result | The champagne's flavors will not be those who are expected | We will have to redefine our calculations |
| The result is letting some tank partially empty | Champagne will be lost | We will have to redefine our calculations |

## II. System Overview

<!-- TODO -->

### 1. System Actors and Personas

#### A. Stakeholders

| **Stakeholder** | **Role** | **Presentations** |
|:---|:---|:---|
| ALGOSUP | Project owner | The school who is in charge of the project |
| Franck Jeannin | ALGOSUP CEO | The person who is the contact between the client and the school |
| Krug Client | Client | The client who order the software |
| Julie Cavil | Krug Cellar Master | The person who will use the software |
| Team 4 | Project team | The team who will build the software (see [Project Team](#project-team)) |

#### B. Personas

##### Persona 1

```text
Name: Pierre Dupont
Age: 35
Job: Winemaker 
Location: Reims, France

Presentation: Pierre is the owner of 4 domains in Champagne, he's currently preparing the blending of his champagne. 
This year, the harvest was very good and he has a lot of high quality grapes, he wants to make a champagne with a lot of character.
He's looking for a software who can help him to mass produce magnums of champagne with the correct proportions, taking stocks and the different tanks he has into account.
```

##### Persona 2

```text
Name: Marc Martin
Age: 42
Job: Cellar Master

Presentation: Marc is the cellar master of a big champagne house, he's currently preparing the blending of the Best Seller of the house. 
He has the perfect formula to make the best champagne possible, but he has a lot of tanks and he doesn't want to do the calculations by hand. 
He's looking for a software who can help him to mass produce bottles of champagne with the correct proportions, taking stocks and the different tanks he has into account.
```

### 2. Use Cases

To be able to use the software, the user will have to follow these steps:

1. Give a .csv file with the stocks of the different tanks;
2. Give the formula of the champagne;
3. The software will calculate the correct proportions of champagne to blend;
4. The software will give the result in a .csv file.
5. The user will be able to use the result to blend the champagne.

The software will be able to be used by the cellar master of a champagne house or by a winemaker.

Here is an example of a .csv file with the stocks of the different tanks:

```csv
Tank Name;Grape Variety;Capacity (in liters)
Tank 1;Chardonnay;5000
Tank 2;Pinot Noir;7500
Tank 3;Chardonnay;10000
Tank 4;;2000
Tank 5;Pinot Meunier;3000
Tank 6;;5000
Tank 7;Chardonnay;8000
```

Here is an example of an input formula of the champagne where, for each  grape variety, we have the perfect percentage of the grape variety in the final blend:

```text
Pinot Noir: 56%
Pinot Meunier: 41%
Chardonnay: 3%
```

<!-- TODO: The result presentation -->