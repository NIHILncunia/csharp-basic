using System.Collections;

namespace csharpBasic.Training; 

public class Tr005DataCalc {
  public void n1_NumberCalc() {
    Console.WriteLine($"더하기: {1 + 1}");
    Console.WriteLine($"문자 숫자 더하기: {"1" + 1}");
    // 숫자와 문자열을 더하면 문자열이 된다.
    Console.WriteLine($"빼기: {2 - 1}");
    Console.WriteLine($"곱하기: {3 * 5}");
    Console.WriteLine($"나누기: {5 / 1}");
    Console.WriteLine($"나머지 수 구하기: {5 % 1}");
    Console.WriteLine();
    // 기본적인 사칙연산. / 는 나눗셈이고 % 는 나머지를 구하는 연산자를 의미한다.
    // 이 부분은 다른 언어들이랑 다를 게 없다.
      
    int number = 0;
    Console.WriteLine("기본값: {0}", number);
    Console.WriteLine("더하고 출력: {0}", ++number);
    Console.WriteLine("출력한 다음에 더하기: {0}", number++);
    Console.WriteLine("최종값: {0}", number);
    Console.WriteLine();
    // 값을 하나씩 미리 더하거나 호출한 후 더할 수 있다.
    // 전위 후위 감소/증가 연산을 실행한다.

    // 논리 연산자
    // && 와 || 로 논리적인 연산을 할 수 있다.
    // &&는 and 이다. ||는 or 이다.
    Console.WriteLine($"or: {false || true}");
    // 둘 중에 하나라도 트루라면 트루가 된다.
    Console.WriteLine($"and: {false && true}");
    // 둘 중에 하나라도 펄스라면 펄스가 된다. 즉, 둘 다 트루여야 한다.
    Console.WriteLine($"not: {!false}");
    // !는 거짓과 참의 관계를 역전시킨다.
    Console.WriteLine();
  }

  public void n2_RelationalOperator() {
    Console.WriteLine($"왼쪽이 오른쪽보다 작은가?: 3 < 4 = {3 < 4}");
    Console.WriteLine($"왼쪽이 오른쪽보다 작거나 같은가?: 3 <= 4 = {3 <= 4}");
    Console.WriteLine($"왼쪽이 오른쪽보다 큰가?: 3 > 4 = {3 > 4}");
    Console.WriteLine($"왼쪽이 오른쪽보다 크거나 같은가?: 3 >= 4 = {3 >= 4}");
    Console.WriteLine($"왼쪽과 오른쪽이 같은가?: 3 == 4 = {3 == 4}");
    Console.WriteLine($"왼쪽과 오른쪽이 다른가?: 3 != 4 = {3 != 4}");
    Console.WriteLine();
    // 자바스크립트에서는 ==와 ===이 따로 존재하는데 여긴 그런 게 없다.
  }

  public void n3_ConditionalOperator() {
    int nihilNumber = 7556;

    string result = nihilNumber == 8000 ? "값이 같음." : "값이 다름.";
    Console.WriteLine(result);
    Console.WriteLine();
    // 조건 연산자는 별다를 바가 없다.
  }

  public void n4_NullOperator() {
    ArrayList? list = null;
    // 배열을 하나 만든다. 값은 비어있다.

    list?.Add("아이유");
    list?.Add("유아");
    // 값이 null이냐 아니냐에 따라서 실행이 되고 안되고가 결정된다.
      
    Console.WriteLine($"개수: {list?.Count}");
    Console.WriteLine($"{list?[0]}");
    Console.WriteLine($"{list?[1]}");
    Console.WriteLine();
    // 값이 null이기 때문에 전부 실행되지 않는다.

    list = new ArrayList();
    // 이제 list에 값이 생겼다.
      
    list?.Add("아이유");
    list?.Add("유아");
      
    Console.WriteLine($"개수: {list?.Count}");
    Console.WriteLine($"{list?[0]}");
    Console.WriteLine($"{list?[1]}");
    Console.WriteLine();
    // 값이 null이 아니기 때문에 이제는 실행이 된다.
  }

  public void n5_BitOperator() {
    // 비트 연산자는 숫자 자체가 아닌 숫자가 가리키고 있는 비트를 계산하는 연산자다.

    int a = 1;
    Console.WriteLine("a << 1: {0:D5} ({0:X8})", a << 1);
    Console.WriteLine("a << 2: {0:D5} ({0:X8})", a << 2);
    Console.WriteLine("a << 5: {0:D5} ({0:X8})", a << 5);
    Console.WriteLine();
      
    int b = 255;
    Console.WriteLine("b >> 1: {0:D5} ({0:X8})", b >> 1);
    Console.WriteLine("b >> 2: {0:D5} ({0:X8})", b >> 2);
    Console.WriteLine("b >> 5: {0:D5} ({0:X8})", b >> 5);
    Console.WriteLine();
      
    int c = -255;
    Console.WriteLine("c >> 1: {0:D5} ({0:X8})", c >> 1);
    Console.WriteLine("c >> 2: {0:D5} ({0:X8})", c >> 2);
    Console.WriteLine("c >> 5: {0:D5} ({0:X8})", c >> 5);
    Console.WriteLine();
    // 비트를 옮겨서 값을 바꾸는 연산이다.
      
    // 비트 논리 연산자는 비트를 이용한 논리 연산을 수행한다. 네가지가 존재한다.
    // 비트 논리 연산자는 1은 참이고 0은 거짓이다. 각 비트별로 연산을 수행한다.

    int d = 9 & 10;
    Console.WriteLine($"9 & 10: {d} {d:D5} {d:X8}");
    // 논리곱 연산자
    // &는 둘 다 1일 때에 결과가 1인 연산을 수행한다.
    // 9는 2진수로 1001이다. 10은 2진수로 1010이다.
      
    // 1001
    // 1010
    // 이렇게 비교했을 때 둘 다 1인 곳만 1이 되기에 1000이 결과가 된다.
    // 1000은 10진수로 8이다.

    int e = 9 | 10;
    Console.WriteLine($"9 | 10: {e} {e:D5} {e:X8}");
    // 논리합 연산자
    // |는 둘 중 하나가 1이면 결과가 1인 연산을 수행한다.
    // 두 값을 비교하면 1 0 1 1 이므로 11이 출력된다.

    int f = 9 ^ 10;
    Console.WriteLine($"9 ^ 10: {f} {f:D5} {f:X8}");
    // 배타적 논리합 연산자
    // ^는 값이 같으면 결과가 0인 연산을 수행한다.
    // 두 값을 비교하면 0 0 1 1 이므로 3이 출력된다.

    int g = ~9;
    Console.WriteLine($"~9: {g} {g:D5} {g:X8}");
    Console.WriteLine();
    // 보수 연산자
    // ~는 단항 연산자로 비트 값을 반전시키는 연산을 수행한다.
    // 9는 1 0 0 1 이고 32비트로는 00000000000000000000000000001001이다. 이를 반전시키면
    // 11111111111111111111111111110110 로 값은 -10이 된다.
  }

  public void n6_AssignmentOperator() {
    // 할당 연산자는 간단하다.
    // a = 1 + 1;
    // 위의 연산을 간략화할 수 있다.
    int a;
    a = 100;
    a += 10;
      
    Console.WriteLine($"a += 10: {a}");
    Console.WriteLine();
    // 모든 연산자에 적용되는 법칙이다.
  }

  public void n7_NullOperator() {
    // null 병합 연산자: ??
    // 좌항이 null이면 우항을 뱉고 좌항이 null이 아니면 좌항을 뱉는다.

    int? a = null;
    // 값을 초기화.
      
    Console.WriteLine($"a ?? 0: {a ?? 0}");

    a = 7556;
      
    Console.WriteLine($"a ?? 0: {a ?? 0}");
    Console.WriteLine();
  }
}