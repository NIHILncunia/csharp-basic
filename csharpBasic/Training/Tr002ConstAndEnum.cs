namespace csharpBasic.Training; 

public class Tr002ConstAndEnum {
  public void n1_Const() {
    const int a = 755642;
    // const를 붙이면 상수가 된다. 값을 바꿀 수 없게 된다.
      
    Console.WriteLine($"a: {a}\n");
  }

  enum Gender {
    MALE, FEMALE, NONE
  }
  // 같은 계열의 다른 값들이 중복된 값을 가지지 않게끔 열거형 타입을 사용하면 좋다.

  public void n2_Enum() {
    Console.WriteLine((int)Gender.MALE);
    Console.WriteLine((int)Gender.FEMALE);
    Console.WriteLine((int)Gender.NONE);
    Console.WriteLine("");
    // 값을 할당하지 않았는데도 알아서 할당이 되어있다.

    const Gender gender = Gender.MALE;
    // 만든 열거형 데이터는 그 자체로 타입이 될 수도 있다.
      
    Console.WriteLine(gender == Gender.MALE);
    Console.WriteLine(gender == Gender.FEMALE);
    Console.WriteLine(gender == Gender.NONE);
    Console.WriteLine("");
  }
}