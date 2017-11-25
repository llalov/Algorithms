<table>
<tbody>
<tr>
<th colspan="7">
Comparison of Sorting Algorithms 
</th>
</tr>
<tr>
<td><b>Name</b></td>
<td><b>Best</b></td>
<td><b>Average</b></td>
<td><b>Worst</b></td>
<td><b>Memory</b></td>
<td><b>Stable</b></td>
<td><b>Method</b></td>
</tr>

<tr>
<td>Selection sort</td>
<td>n2</td>
<td>n2</td>
<td>n2</td>
<td>1</td>
<td>No</td>
<td>Selection</td>
</tr>

<tr>
<td>Bubble sort</td>
<td>n</td>
<td>n2</td>
<td>n2</td>
<td>1</td>
<td>Yes</td>
<td>Exchanging</td>
</tr>

<tr>
<td>Insertion sort</td>
<td>n</td>
<td>n2</td>
<td>n2</td>
<td>1</td>
<td>Yes</td>
<td>Insertion</td>
</tr>

<tr>
<td>Quick sort</td>
<td>n*log(n)</td>
<td>n*log(n)</td>
<td>n2</td>
<td>log(n)</td>
<td>Depends</td>
<td>Partitioning</td>
</tr>

<tr>
<td>Merge sort</td>
<td>n*log(n)</td>
<td>n*log(n)</td>
<td>n*log(n)</td>
<td>1(or n)</td>
<td>Yes</td>
<td>Merging</td>
</tr>

<tr>
<td>Heap sort</td>
<td>n*log(n)</td>
<td>n*log(n)</td>
<td>n*log(n)</td>
<td>1</td>
<td>No</td>
<td>Selection</td>
</tr>

<tr>
<td>Bogo sort</td>
<td>n</td>
<td>n*n!</td>
<td>n*n!</td>
<td>1</td>
<td>No</td>
<td>Luck</td>
</tr>

</tbody>
</table>
<br/><br/>
1. <b>Sorting Algorithms</b><br/>
Stable: Maintain the order of equal elements.If two items compare as equal, their relative order is preserved<br/>
Unstable: Rearrange the equal elements in unpredictable order.<br/>

- Selection sort (simple, but inefficient algorithm): https://visualgo.net/en/sorting<br/>
Swap the first with the min element on the right, then the second, etc.<br/>
- Bubble sort (simple, but inefficient algorithm ): https://visualgo.net/en/sorting<br/>
Swaps to neighbor elements when not in order until sorted<br/>
- Insertion sort (simple, but inefficient algorithm ): https://visualgo.net/en/sorting <br/>
Move the first unsorted element left to its place<br/>
---------------------EFFICIENT----------------------------<br/>
- Merge sort (efficient sorting algorithm) https://visualgo.net/en/sorting<br/>
Divide the list into sub-lists (tipically 2 sub lists)<br/>
Sort each sub-list (recursively call merge-sort)<br/>
Merge the sorted sub-lists into a single list<br/>
Highly parallelizable on multiple cores/machines: up to 0(log(n))<br/>
- Quick sort (efficient sorting algorithm) https://visualgo.net/en/sorting<br/>
Choose a pivot; move smaller elements left & larger right; sort left & right<br/>
- Counting sort (very efficient sorting algorithm) https://visualgo.net/en/sorting<br/>
Sorts small integers by counting their occurrences<br/>
Not a comparison-based sort<br/>
- Bucket sort (partitions an array into a number of buckets)<br/>
Each bucket is then sorted individually with a different algorithm<br/>
Not a comparison-based sort<br/>

2. <b>Shuffling Algorithms</b><br/>
Randomizing the order of items in a collection. Generating random permutation.<br/>

- Fisher–Yates Shuffle Algorithm<br/>
https://bost.ocks.org/mike/shuffle/<br/>

3. <b>Searching Algorithms</b><br/>
Algorithms for finding an item with specified properties among a collection of items<br/>

- Linear search (finds a particular value in a list) http://www.cs.usfca.edu/~galles/visualization/Search.html<br/>
Checking every one of the elements<br/>
One at a time, in sequence<br/>
Until the desired one is found<br/>
- Binary search (finds an item within a ordered data structure)<br/>
At each step, compare the input with the middle element<br/>
The algorithm repeats its action to the left or right sub-structure<br/>
-  Interpolation search (an algorithm for searching for a given key in an ordered indexed array)<br/>
Parallels how humans search through a telephone book<br/>
Calculates where in the remaining search space the item might be<br/>
Binary search always chooses the middle element<br/>
Can we have a better hit, e.g. Angel in the phonebook should be at the start, not at the middle, OK?<br/><br/>
