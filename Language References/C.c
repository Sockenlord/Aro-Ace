// Example C file for theme testing
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>

#define PI 3.14159
#define SQUARE(x) ((x)*(x))

// Enum
typedef enum { RED, GREEN, BLUE } Color;

// Struct
typedef struct {
    int x;
    int y;
} Point;

// Function declaration
int add(int a, int b);
void print_point(const Point* p);

// Main function
int main(void) {
    // Variables
    int a = 5, b = 10;
    double d = 2.5;
    char str[20] = "Hello, C!";
    int arr[] = {1, 2, 3};
    Color color = GREEN;
    Point p = {3, 4};

    // Control structures
    if (a < b) {
        printf("a is less than b\n");
    } else {
        printf("a is not less than b\n");
    }

    for (int i = 0; i < 3; ++i) {
        printf("arr[%d] = %d\n", i, arr[i]);
    }

    switch (color) {
        case RED:
            printf("Color is red\n");
            break;
        case GREEN:
            printf("Color is green\n");
            break;
        case BLUE:
            printf("Color is blue\n");
            break;
        default:
            printf("Unknown color\n");
    }

    // Function calls
    printf("Sum: %d\n", add(a, b));
    print_point(&p);

    // Pointer arithmetic
    int* ptr = arr;
    printf("First element: %d\n", *ptr);

    // Macro usage
    printf("Square of 4: %d\n", SQUARE(4));
    printf("PI: %.5f\n", PI);

    // String functions
    printf("Length: %zu\n", strlen(str));
    strcpy(str, "C is fun!");
    printf("New str: %s\n", str);

    // Math functions
    printf("sqrt(16): %.2f\n", sqrt(16));

    return 0;
}

// Function definitions
int add(int a, int b) {
    return a + b;
}

void print_point(const Point* p) {
    printf("Point: (%d, %d)\n", p->x, p->y);
}
