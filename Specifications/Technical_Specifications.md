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













