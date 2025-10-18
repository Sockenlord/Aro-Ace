// Example C++ file for theme testing
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <memory>

// Macro
#define PI 3.14159

// Enum
enum class Color { Red, Green, Blue };

// Struct
struct Point {
    int x;
    int y;
    Point(int x, int y) : x(x), y(y) {}
};

// Base class
class Shape {
public:
    virtual double area() const = 0;
    virtual std::string name() const { return "Shape"; }
    virtual ~Shape() = default;
};

// Derived class
class Circle : public Shape {
    double radius;
public:
    Circle(double r) : radius(r) {}
    double area() const override { return PI * radius * radius; }
    std::string name() const override { return "Circle"; }
};

// Template function
template<typename T>
T add(T a, T b) {
    return a + b;
}

// Function with lambda
void printSquares(const std::vector<int>& nums) {
    std::for_each(nums.begin(), nums.end(), [](int n) {
        std::cout << n << "^2 = " << n * n << std::endl;
    });
}

// Main function
int main() {
    // Variables
    int a = 5, b = 10;
    double d = 3.14;
    std::string s = "Hello, C++!";
    bool flag = true;

    // Pointers and smart pointers
    int* ptr = &a;
    std::unique_ptr<Shape> shape = std::make_unique<Circle>(2.0);

    // Control structures
    if (flag) {
        std::cout << s << std::endl;
    } else {
        std::cout << "Flag is false" << std::endl;
    }

    for (int i = 0; i < 3; ++i) {
        std::cout << "i = " << i << std::endl;
    }

    switch (a) {
        case 5:
            std::cout << "a is five" << std::endl;
            break;
        default:
            std::cout << "a is not five" << std::endl;
    }

    // Using template
    std::cout << "Sum: " << add(a, b) << std::endl;

    // Using lambda
    std::vector<int> numbers = {1, 2, 3};
    printSquares(numbers);

    // Using enum
    Color color = Color::Green;
    if (color == Color::Green) {
        std::cout << "Color is green" << std::endl;
    }

    // Struct usage
    Point p(3, 4);
    std::cout << "Point: (" << p.x << ", " << p.y << ")" << std::endl;

    // Virtual function
    std::cout << shape->name() << " area: " << shape->area() << std::endl;

    return 0;
}
