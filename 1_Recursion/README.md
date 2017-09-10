1. <b>Recursion</b>(fuction calling itself) 
- should have a base case
- parameters and return values travel through the stack at each step
- prefer iteration for linear calculations (without branched calls)
- each step should move towards the base case
    Direct recursion: a method directly calls itself
    Indirect recursion: method A calls method B, method B calls A. Or even A-> B -> C -> A	
- recursive methods have 3 parts (pre-actions, recursion, post-actions)<br/>
  
  static void Recursion()<br/>
  {<br/>
  ....//Pre-actions<br/>
  ....Recutsion();<br/>
  ....//Post-actions<br/>
  }<br/>

2. <b>Backtracking</b> (has exponential time!) - class of algorithms for finding all solutions to some combinatorial problem
- at each step tries all prespective possibilities recursively
- drop all non-prespective possibilities as early as possible<br/>
  
  void Backtracking(Node node)<br/>
  {<br/>
  ..if (node is solution)<br/>
  ....PrintSolution(node);<br/>
  ..else<br/>
  ....for each child c of node<br/>
  ......if (c is perspective candidate)<br/>
  ......{<br/>
  ........MarkPositionVisited(c);<br/>
  ........Backtracking(c);<br/>
  ........UnmarkPositionVisited(c);<br/>
  ......}<br/>
  }<br/>
