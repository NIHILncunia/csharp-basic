namespace csharpBasic.Training; 

public class People {
  private string _name = "NIHILncunia";

  public ref string GetName() {
    return ref _name;
    // 참조로 리턴할 수 있다.
  }

  public void PrintName() {
    Console.WriteLine($"이름: {_name}");
  }
}
  
public class Tr008Method {
  public static int Add(int a, int b) {
    return a + b;
  }

  public static int Fibonacci(int n) {
    if (n < 2) {
      return n;
      // return은 점프문이며 프로그램을 멈춰버리고 원래 있던 곳으로 돌아가는 기능을 가졌다.
    } else {
      int result = Fibonacci(n - 1) + Fibonacci(n - 2);
      return result;
    }
  }

  public static void Swap(int a, int b) {
    int temp = b;
    b = a;
    a = temp;
  }
    
  public static void RefSwap(ref int a, ref int b) {
    int temp = b;
    b = a;
    a = temp;
  }
    
  public void n1_CreateMethod() {
    Console.WriteLine(Add(1, 2));
    // 메소드는 코드를 간추릴 수 있는 기능을 가짐과 동시에 여러가지 기능을 자유자재로 부여할 수 있다.
      
    Console.WriteLine(Fibonacci(10));
    // 재귀는 메소드의 안에서 자기 자신을 다시 호출하는 것이다.
    // 기능상의 저하가 있을 수 있기 때문에 남용은 안된다.
      
    // 매개변수는 전달한다고 해서 값 자체가 전달되는 게 아니다.
    // 매개변수들은 사실 전부 다른 공간에 저장된다.

    int x = 3;
    int y = 4;
      
    Console.WriteLine("매개변수: 값에 의한 전달");
    Console.WriteLine($"x: {x} / y: {y}");
    Swap(x, y);
    Console.WriteLine($"x: {x} / y: {y}");
    Console.WriteLine();
    // 값이 바뀌지 않는다.

    Console.WriteLine("매개변수: 참조에 의한 전달");
    Console.WriteLine($"x: {x} / y: {y}");
    RefSwap(ref x, ref y);
    Console.WriteLine($"x: {x} / y: {y}");
    Console.WriteLine();
    // 참조에 의한 전달이 되면 값이 바뀐다.
    // 참조로 전달을 하면 값을 따로 저장하지만 참조된 위치를 그대로 사용하기 때문이다.

    People nihil = new People();
    ref string refLocalName = ref nihil.GetName();
    string localName = nihil.GetName();
      
    nihil.PrintName();
    Console.WriteLine($"refLocalName: {refLocalName}");
    Console.WriteLine($"localName: {localName}");
    Console.WriteLine();
      
    refLocalName = "anikai7556";
      
    nihil.PrintName();
    Console.WriteLine($"refLocalName: {refLocalName}");
    Console.WriteLine($"localName: {localName}");
    Console.WriteLine();
    // 참조를 통한 반환을 이용하면 메소드 호출이 끝난 뒤에도 값을 계속 이용할 수 있다.
    // 반환된 값을 수정할 수 있다는 이점도 존재한다.
  }

  // public void RefDivide(int a, int b, ref int c, ref int d) {
  //   c = a / b;
  //   d = a % b;
  // }

  public void OutDivide(int a, int b, out int c, out int d) {
    c = a / b;
    d = a % b;
  }

  public void n2_OutKeyword() {
    int a = 30;
    int b = 4;
      
    // RefDivide(a, b, ref c, ref d);
    OutDivide(a, b, out int c, out int d);
    // ref나 out을 이용하면 리턴을 하지 않아도 값을 저장하고 이를 사용할 수가 있다.
    // out은 출력을 위한 매개변수다. 변수를 만들어두고 값을 할당하지 않아도 이용이 가능하며 메소드 자체에서 변수를 선언해도 된다.
      
    Console.WriteLine($"몫: {c} 나머지: {d}");
  }

  public int Add(params int[] number) {
    int result = 0;

    for (int i = 0; i < number.Length; i++) {
      result += number[i];
    }

    return result;
  }

  public void n3_ParamsMethod() {
    int a = Add(1, 4, 5, 2, 6, 7, 5);
    Console.WriteLine($"a: {a}");
    // params를 이용해서 다양한 개수의 매개변수를 입력받을 수 있다.

    // Add(b: 20, a: 50);
    // 메소드를 호출할 때에 매개변수에 이름을 지정할 수 있다. 이 경우 순서를 지키지 않아도 된다.
    // 메소드를 선언할 때 매개변수에 값을 할당할 수 있고,
    // 값이 할당되어있으면 호출을 할 때에 선택적으로 매개변수를 입력할 수 있게 된다.

    Console.WriteLine(LocalFunction());
    // 로컬 함수 호출.

    string LocalFunction() {
      return "귤은 많이 먹으면 안돼.";
    }
    // 로컬 함수는 메소드 내에서 사용되는 함수이다. 메소드가 아니기에 함수라고 부른다.
  }
}