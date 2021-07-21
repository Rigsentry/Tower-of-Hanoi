# Tower of Hanoi
There are three towers. The objective of the game is to move all the disks over to tower #3, but you can't place a larger disk onto a smaller disk.

![alt text](tower_of_hanoi.gif)

Create a function that takes a number `discs` as an argument and returns the minimum amount of steps needed to complete the game.

## Examples
```
towerHanoi(3) ➞ 7

towerHanoi(5) ➞ 31

towerHanoi(0) ➞ 0
```

## Notes
* The amount of discs is always a positive integer.
* 1 disc can be changed per move.

## Test Cases
```
Test.assertEquals(towerHanoi(3), 7)
Test.assertEquals(towerHanoi(5), 31)
Test.assertEquals(towerHanoi(8), 255)
Test.assertEquals(towerHanoi(19), 524287)
Test.assertEquals(towerHanoi(9), 511)
Test.assertEquals(towerHanoi(13), 8191)
Test.assertEquals(towerHanoi(0), 0)
```

## Acceptance Criteria.
* Create a **function** that takes a number discs as an **integer** argument.
* The function must be able to satisfy all the test cases.

# How to push your code

Clone the repo and create a new branch with your name and push it.