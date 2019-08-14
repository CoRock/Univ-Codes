# One-Dimensional Arrays

  - Automatic Allocation in C
```C
    int x[10];
```
  - Dynamic Allocation in C
```C
    int x[10];
    int *x;
    x = (int *) malloc(10 * sizeof(int));
```
  - Dynamic Allocation in C#
```C#
    int[] x;
    x = new int[10];
```

# Two-Dimensional Arrays 

  1. int[,] x;
```C#
    x = new int[2, 3];
    x[1, 2] = 5;
    x[0, 1] = 7;
```
  2. int[,] x;
```C#

```
1차원 배열의 레퍼런스들을 가리키는 레퍼런스