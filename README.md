# Unexpected Behavior with Reference Types in C#

This repository demonstrates an example of unexpected behavior that can occur when working with reference types in C#.  In C#, reference types (such as classes) are passed by reference, meaning that multiple variables can refer to the same object in memory. Changes made through one variable will be reflected in all variables referencing the same object.

The `bug.cs` file contains code that exhibits this behavior. The `bugSolution.cs` file shows how to avoid this issue by creating a copy of the object or using value types instead of reference types when appropriate.

## How to Reproduce
1. Clone this repository.
2. Open the `bug.cs` file in a C# IDE.
3. Run the code.  Observe that the output is 20, which may be unexpected if you assumed pass-by-value semantics.
4. Examine the `bugSolution.cs` file to see how this unexpected behavior is resolved.

## Solutions
The `bugSolution.cs` file provides two solutions:

1. **Creating a copy:** A deep copy of the object can be created before making changes using techniques like object serialization or member-wise copying.  This ensures that modifications don't affect the original object.
2. **Using value types:** In situations where appropriate, switching to value types (such as structs) can resolve the issue as value types are passed by value, not by reference.

This example highlights the importance of understanding how reference types behave in C# to avoid unintended consequences and potential bugs in your code.