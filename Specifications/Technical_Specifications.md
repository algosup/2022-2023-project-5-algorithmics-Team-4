# Technical Specifications

## Structuring data

We need to represent the wine tanks. This needs to be fast to access and to write. We will be using the folowing representation.

<table>
   <tbody>
      <tr>
        <td>Int *(Tank Volume)*</td>
      </tr>
      <tr>
         <td>
           <table>
             <tbody>
               <tr>
                 <td>
                   Hex *(Wine ID)*
                 </td>
                 <td>
                   Hex *(Wine ID)*
                 </td>
               </tr>
               <tr>
                 <td>
                   Int *(Wine Volume)*
                 </td>
                 <td>
                   Int *(Wine Volume)*
                 </td>
               </tr>
             </tbody>
           </table>
        </td>
      </tr>
      <tr>
         <td>Bool *(Empty of Full)*</td>
      </tr>
   </tbody>
</table>

- An Array of size ``n``, with ``n`` being the number of tanks 

In each meber of the array will be an array of size 3 storing :
- The tank volume
- The status (full or empty) as a bool for faste read
- A dynamic array

In the dynamic array we will store an array of size 2 with :
- An identifier for the wine (probably in Hex)
- The quantity of this wine in the tank


## Program

The program can be broken down into five looping steps.
- Checking and sorting full tanks acording to their content
- Select two wines to combine and calculate their volume
- Find one or several tanks that can store the combined volume
- For each target tanks calculate the volumes of each wines acording to the formula proportion
- Update the tanks Array with the new quantities

Repeat those step until their is only wine formula at the end which should be the expected formula
Finaly we can print the instruction detailing wich transfer we did

## Finding cobinaison of containers

We will do a Combination sum problem. to reduce processing time we will only tanks that are smaller than the target or less than 5% larger. We will also do a random selection to cut the number in half.

## Getting the data

We will get the data from a CSV using a parser. The Tanks will be empty by default exept the one initialized with some wine in them.







