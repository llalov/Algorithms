1. Recursion(fuction calling itself) 
- should have a base case
- parameters and return values travel through the stack at each step
- prefer iteration for linear calculations (without branched calls)
- each step should move towards the base case
    Direct recursion: a method directly calls itself
    Indirect recursion: method A calls method B, method B calls A. Or even A-> B -> C -> A	
- recursive methods have 3 parts (pre-actions, recursion, post-actions)
  
  static void Recursion()
  {
    //Pre-actions
    Recutsion();
    //Post-actions
  }

2. Backtracking (has exponential time!) - class of algorithms for finding all solutions to some combinatorial problem
- at each step tries all prespective possibilities recursively
- drop all non-prespective possibilities as early as possible
  
  void Backtracking(Node node)
  {
    if (node is solution)
      PrintSolution(node);
    else
      for each child c of node
        if (c is perspective candidate)
        {
          MarkPositionVisited(c);
          Backtracking(c);
          UnmarkPositionVisited(c);
        }
  }