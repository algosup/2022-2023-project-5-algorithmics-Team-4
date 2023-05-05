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
    - [3. Related Documents](#3-related-documents)
    - [4. Terms/Acronyms and Definitions](#4-termsacronyms-and-definitions)
    - [5. Risk and Assumptions](#5-risk-and-assumptions)
    - [6. Stakeholders](#6-stakeholders)

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

### 3. Related Documents

| **Document** | **Description** |
|:---|:---|
| [Technical Specifications](Technical_Specifications.md) | This document provides detailed information on how the system solution will be built. |

### 4. Terms/Acronyms and Definitions

| **Term** | **Acronym(if applicable)** | **Definition** |
|:---|:---|:---|
| Champagne | | Sparkling wine produced from grapes grown in the Champagne region of France following rules that demand secondary fermentation of the wine in the bottle to create carbonation. |
| Krug Grande Cuvée | | The flagship of the House, the Grande Cuvée is the archetype of Krug’s philosophy of craftsmanship and savoir faire: a blend of more than 120 wines from ten or more different years. |
| Tank | | A large receptacle or storage chamber, especially for liquid or gas. |

### 5. Risk and Assumptions

| **Risk** | **Impact** | **Mitigation** |
|:---|:---|:---|
| The software is not finished on time | The client will not be able to use the software and will have to do the blending manually | Make a critical path, respect it and also deploy a good project management |
| The software is not working | The client will not be able to use the software and will have to do the blending manually | Our QA and our SE will need to work together to find and solve all problems users will be able to meet |
| The software is not user friendly | If the software is not user-friendly, use it will be hard and a waste of time to understand it | Write instructions and make them clearer as possible |
| The formula is not close to the final result | The champagne's flavors will not be those who are expected | We will have to redefine our calculations |
| The result is letting some tank partially empty | Champagne will be lost | We will have to redefine our calculations |

### 6. Stakeholders

| **Stakeholder** | **Role** | **Presentations** |
|:---|:---|:---|
| ALGOSUP | Project owner | The school who is in charge of the project |
| Krug Client | Client | The client who order the software |
| Julie Cavil | Krug Cellar Master | The person who will use the software |
| Team 4 | Project team | The team who will build the software (see [Project Team](#project-team)) |
