# Example Python file for theme testing
import math
import sys
from typing import List, Dict, Optional, Any, Callable

# Constant
PI = 3.14159

# Decorator
def debug(func):
    def wrapper(*args, **kwargs):
        print(f"Calling {func.__name__}")
        return func(*args, **kwargs)
    return wrapper

# Class with inheritance
class Shape:
    def area(self) -> float:
        raise NotImplementedError

class Circle(Shape):
    def __init__(self, radius: float):
        self.radius = radius
    def area(self) -> float:
        return PI * self.radius ** 2

# Function with type hints, default args, *args, **kwargs
@debug
def add(a: int, b: int = 0, *args: int, **kwargs: Any) -> int:
    return a + b + sum(args)

# Lambda, list comprehension, generator expression
squares = [x**2 for x in range(5)]
gen = (x for x in range(5))
add_one = lambda x: x + 1

# Exception handling
try:
    result = add(1, 2)
except Exception as e:
    print(f"Error: {e}")
finally:
    print("Done")

# f-Strings, raw strings, bytes
name = "World"
print(f"Hello, {name}!")
print(r"C:\\path\\to\\file")
print(b'bytes')

# Dict, set, tuple, list
my_dict: Dict[str, int] = {'a': 1, 'b': 2}
my_set = {1, 2, 3}
my_tuple = (1, 2, 3)
my_list: List[int] = [1, 2, 3]

# With statement
with open('test.txt', 'w') as f:
    f.write('Hello')

# Function with yield
def countdown(n: int):
    while n > 0:
        yield n
        n -= 1

# Async/await
import asyncio
async def main():
    await asyncio.sleep(1)

# Special variables
if __name__ == "__main__":
    print("Script is running directly.")
