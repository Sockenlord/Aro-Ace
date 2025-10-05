public class Java {

    private static final int LINE_COUNT = 100;

    // FizzBuzz;
    public static void main(String[] args) {
        String output = "";
        for (int i = 1; i <= LINE_COUNT; i++) {
            if (i % 3 == 0) {
                output += "Fizz";
              }
              if (i % 5 == 0) {
                  output += "Buzz";
              }
              if (output.isEmpty()) {
                  output += i;
              }
              System.out.println(output);
              output = "";
        }
    }
  }