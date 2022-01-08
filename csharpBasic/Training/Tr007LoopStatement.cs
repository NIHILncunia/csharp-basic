namespace csharpBasic.Training; 

public class Tr007LoopStatement {
  public void n1_While() {
    int i = 1;
    // 1. 변수를 하나 만들어준다.
    while (i <= 5) {
      // 2. 반복의 조건을 설정한다.
      // 4. 다시 반복 조건을 살피고 false가 되면 반복을 멈춘다.
      Console.WriteLine($"while 반복문: {i}번째 반복");
      i++;
      // 3. 반복이 끝날 때 변수에 값을 더한다.
    }

    while (true) {
      Console.Write("반복을 멈출까요? (예/아니오) : ");
      string? result = Console.ReadLine();

      if (result == "예") {
        Console.WriteLine("반복을 멈춥니다.");
        break;
        // 반복문에서 빠져나올 수 있다.
      } else {
        Console.WriteLine("반복을 계속합니다.");
      }
    }

    int j = 1;

    do {
      Console.WriteLine($"do while 반복문: {j}번째 반복");
      j++;
    } while (j <= 5);
    // while문과 다른 점은 실행할 구문을 한번은 반드시 실행을 한다는 점에 있다.
    // 그리고 조건을 나중에 검사한다. 즉 false여도 한번은 실행한다는 것이다.
  }

  public void n2_For() {
    for (int j = 1; j <= 5; j++) {
      // while 반복문의 축약형이다. 이게 더 많이 사용된다.
      Console.WriteLine($"for 반복문: {j}번째 반복");
    }
    Console.WriteLine();

    for (int a = 0; a <= 10; a++) {
      if (a == 3) {
        continue;
        // 프로그램을 멈추는 것이 아닌, 건너뛸 수 있다.
      }

      if (a == 7) {
        goto 여기로;
        // 원하는 이름을 지어두고 프로그램의 흐름을 자유자재로 정할 수 있다.
        // 일종의 분기점인데 섬세하게 컨트롤이 가능할 것 같다.
        // 그러나 많이 사용하면 아름다운 코드는 나오지 않을 것 같다.
      }
      Console.WriteLine(a);
    }
      
    여기로:
    Console.WriteLine("진짜 점프다.");
    Console.WriteLine();
  }

  public void n3_ForTimesTable() {
    // 간단한 구구단 반복문을 만들어보자.
    for (int first = 1; first <= 9; first++) {
      // 반복문 안에 반복문 하나를 더 만든다.
      for (int second = 1; second <= 9; second++) {
        string result = Convert.ToString(first * second);
        // 결과를 문자열로 만들어두고,

        if (result.Length == 1) {
          result = " " + result;
          // 결과가 한글자일 때에는 앞에 공백을 넣어 가독성을 좋게 만든다.
        }

        Console.Write($"{second} × {first} = {result}   ");
        // 구구단을 나타낼 수 있도록 수식을 적어준다.
        // 줄바꿈이 안되게 하는 이유는 보기 좋게 만들기 위함이다.
      }
      Console.WriteLine();
      // 각 루프의 마지막에는 첫번째 반복문이 실행되기 때문에 줄바꿈이 된다.
      // 이렇게 하면 총 9줄의 구구단이 탄생한다.
    }
    Console.WriteLine();
  }

  public void n4_Foreach() {
    int[] arr = new int[] {
      1,2,3,4,5
    };

    foreach (int item in arr) {
      Console.WriteLine(item);
    }
    Console.WriteLine();
  }
}