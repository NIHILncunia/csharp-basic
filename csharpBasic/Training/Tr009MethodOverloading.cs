namespace csharpBasic.Training; 

public static class Number {
  public static int Add(int a, int b) {
    return a + b;
  }

  public static double Add(float a, int b) {
    return a + b;
  }
}
  
public class Tr009MethodOverloading {
  public void n1_MethodOverloading() {
    // 메소드 오버로딩이란 같은 이름의 메소드를 여러가지 방식으로 구현하는 것을 말한다.
    // 오버로딩을 구현할 때에는 매개변수의 형식이 달라야한다. 구분을 할 수 있게 해줘야하기 때문이다.

    int result1 = Number.Add(1, 5);
    Console.WriteLine(result1);

    double result2 = Number.Add(0.5f, 4);
    Console.WriteLine(result2);
    // 같은 메소드로 구현하기 때문에 코드가 간결해진다.
    // 무엇보다 이름에 대한 고민이 급격하게 줄어들게 된다.
  }
}