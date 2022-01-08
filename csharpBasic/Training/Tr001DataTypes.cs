namespace csharpBasic.Training; 

public class Tr001DataTypes {
  public void n1_IntegralTypes() {
    // 데이터는 두가지의 경우로 나뉜다. 값 형식과 참조 형식이다.
    // 기본 데이터 형식과 복합 데이터 형식으로도 나뉜다.
    // 값 형식은 스택 메모리에 값 자체를 담아서 저장하는 것이고
    // 참조 형식은 힙 메모리에 값을 저장하고, 스택 메모리에는 힙 메모리의 주소를 저장하는 것이다.
      
    // 모든 형식들은 C# 고유의 것이 아니고 .NET에 이미 있는 것들을 기반으로 형성된 것이다.
    // 공용 형식 시스템에 의거한 것이다.

    byte a = 255;
    // 부호 없는 8비트 정수 0 ~ 255
    sbyte b = 127;
    // 부호 있는 8비트 정수 -128 ~ 127
      
    Console.WriteLine($"a: {a}, b: {b}");
      
    short c = 32_767;
    // 부호 있는 16비트 정수 -32_768 ~ 32_767
    ushort d = 65_535;
    // 부호 없는 16비트 정수 0 ~ 65_535
      
    Console.WriteLine($"c: {c}, d: {d}");

    int e = 2_147_483_647;
    // 부호 있는 32비트 정수 -2_147_483_648 ~ 2_147_483_647
    uint f = 4_294_967_295;
    // 부호 없는 32비트 정수 0 ~ 4_294_967_295
      
    Console.WriteLine($"e: {e}, f: {f}");

    long g = 922_337_203_685_447_507;
    // 부호 있는 64비트 정수 -922_337_203_685_447_508 ~ 922_337_203_685_447_507
    ulong h = 18_446_744_073_709_551_615;
    // 부호 없는 64비트 정수 0 ~ 18_446_744_073_709_551_615
      
    Console.WriteLine($"g: {g}, h: {h}\n");

    int i = 255;
    // 아무런 접두사가 없으면 10진수로 간주한다.
    int j = 0xFF;
    // 0x로 시작하면 16진수로 간주한다.
    int k = 0b1101101;
    // 0b로 시작하면 2진수로 간주한다.
    // 프로그래밍을 하다보면 16진수와 2진수를 건드릴 때가 온다.
      
    Console.WriteLine($"10진수: {i}");
    Console.WriteLine($"16진수: {j}");
    Console.WriteLine($"2진수: {k}\n");

    float l = 7556.42f;
    // 소수점 7자리까지 가능. 10^38. f를 붙여야함. 32비트.
    double m = 7556.42;
    // 소수점 15~16자리까지 가능. 10^308. 64비트.
    decimal n = 7556.42m;
    // 소수점 29자리까지 가능. 그냥 많은 범위의 실수를 다룰 수 있다. m을 붙여야함. 128비트.
      
    Console.WriteLine($"l: {l}, m: {m}, n: {n}\n");

    char o = 'N';
    // 문자 하나를 담는데에 사용된다.
      
    Console.WriteLine($"0: {o}\n");

    byte aa = 255;
    sbyte bb = (sbyte) aa;
    int ll = (int) l;
    // 데이터 형식을 바꾸는 방법이다. 오버플로우가 생길 수 있기 때문에 무작정 변환은 안된다.
      
    Console.WriteLine($"aa: {aa}");
    Console.WriteLine($"bb: {bb}, ll: {ll}\n");
      
    uint aaa = uint.MaxValue;
    aaa += 11;
    // 데이터 타입의 범위를 넘어서는걸 오버플로우라고 한다. 이 경우에 값은 0으로 회귀한다.
    // 최저값보다 더 낮게 입력하면 언더플로우가 일어난다. 최대값으로 바뀐다.
      
    Console.WriteLine($"{aaa}\n");

    int? p = null;
    // 값이 없는 정수 타입을 만들고 싶으면 데이터형 뒤에 ?를 붙이면 된다.
    // 이렇게 하면 null을 할당할 수 있다.
      
    Console.WriteLine(p.HasValue);
    Console.WriteLine("");
    // 값이 있는지 없는지 확인할 수 있다.

    p = 34;
    // 나중에 값을 할당할 수 있다.
      
    Console.WriteLine(p.HasValue);
    Console.WriteLine(p.Value);
    Console.WriteLine("");
  }

  public void n2_CharAndStringTypes() {
    char a = '안';
    char b = '녕';
    char c = '하';
    char d = '세';
    char e = '요';
    // char 타입은 문자 하나만을 담을 수 있고 작은 따옴표를 사용한다.
    // 16비트이다.
      
    Console.Write(a);
    Console.Write(b);
    Console.Write(c);
    Console.Write(d);
    Console.Write(e);
    // 아래와 맥락은 같지만 줄바꿈이 안된다.
    Console.WriteLine();
    // 마지막에 줄바꿈을 해준다.

    string f = "니힐";
    // 문자열을 담을 수 있다. 길이에는 제한이 없다. 담은만큼 용량이 커진다.
      
    Console.WriteLine($"{f}\n");

    int g = int.Parse("12345");
    float h = float.Parse("123.45");
    int gg = Convert.ToInt32("12345");
    float hh = Convert.ToSingle("123.45");
    // 문자열을 숫자로 바꾸는 방법이다.
      
    Console.WriteLine($"g: {g} {g.GetType()}, h: {h} {h.GetType()}");
    Console.WriteLine($"gg: {gg} {gg.GetType()}, hh: {hh} {hh.GetType()}\n");
    // 타입을 확인하는 방법은 GetType 메소드를 사용하는 것이다.

    string i = g.ToString();
    string j = h.ToString();
    // 정수와 실수를 문자열로 바꾸는 방법이다.
      
    Console.WriteLine($"i: {i}, j: {j}\n");
  }

  public void n3_BoolTypes() {
    bool a = true;
    bool b = false;
    // 불리언은 이 두가지 밖에 없다. 이 형식들은 프로그래밍에서 가장 중요한 위치를 차지하고 있다.
    // 프로그래밍은 논리 구조를 따르며, 논리 구조를 좌우하는 것들이 바로 불리언 형식이다.
      
    Console.WriteLine($"a: {a}, b: {b}\n");
  }

  public void n4_ObjectTypes() {
    object a = 123;
    object b = 3.141592653589793238462643383279m;
    object c = true;
    object d = "안녕하세요.";
    // 모든 데이터 타입의 조상격이 object이다.
    // 모든 데이터 타입을 담는 것이 가능하다.
    // 오브젝트 타입은 참조형 형식 이기 때문에 힙 메모리에 데이터를 저장한다.
    // 스택 메모리에 데이터를 저장하는 형식들도 오브젝트를 이용하면 박싱이 되어 힙 메모리에 저장이 된다.

    int e = (int) a;
    // 박싱되어 저장된 힙 메모리의 데이터를 가져와 스택 메모리에 저장하는 것을 언박싱이라고 한다.
      
    Console.WriteLine($"{a}, {a.GetType()}");
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
  }
}