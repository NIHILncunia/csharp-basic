using System.Globalization;

namespace csharpBasic.Training; 

public class Tr004StringFormat {
  public void n1_ConsoleOutput() {
    Console.Write("Hey!");
    // 줄바꿈이 안된다.
    Console.WriteLine("Hello World!");
    // 자바스크립트의 콘솔로그 같은 기능.
    // 한 줄이기 때문에 자동으로 줄바꿈이 된다.

    Console.Write("줄\n바꿈\n");
    // 다른 프로그래밍 언어에도 있는 줄바꿈 기능이다.

    string name = "Nihil";
    int age = 29;

    Console.WriteLine("{0}님의 나이는 {1}세 입니다.", name, age);
    Console.WriteLine();
    // 포맷 스트링이다. 중괄호 안에 숫자에 따라 순서대로 들어가게 된다.
    // 순서가 일치하지 않으면 값이 들어가지 않는다.
      
    Console.WriteLine("{0}DEF", "ABC");
    // 포맷 스트링은 이렇게 간단하게 사용할 수도 있지만 다른 기능도 존재한다.
    Console.WriteLine("{0, -10}DEF", "ABC");
    Console.WriteLine("{0, 10}DEF", "ABC");
    Console.WriteLine();
    // 숫자를 붙이면 -의 경우 문자열의 뒤에 붙고 -가 아닌 경우 문자열의 앞에 붙는다.

    Console.WriteLine(@"
        문자열의 앞에 @를 붙이면
        입력한대로 출력한다.
      ");

    Console.WriteLine($"{name}님의 나이는 {age}세 입니다.");
    // 달러를 붙이면 보간법을 이용할 수 있게 된다. 위와 결과가 같다.

    int number = 9;
      
    Console.WriteLine($"사이보그 {number:D3}");
    // 보간법으로도 서식을 자유롭게 조정할 수 있다.

    // string message = String.Format("{0}님의 나이는 {1}세 입니다.", name, age);
    // Console.WriteLine(message);
    Console.WriteLine();
    // 포맷 스트링은 이렇게도 사용할 수 있다.

    // Console.Write("사용자에게 값 받기: ");
    // string input = Console.ReadLine(); // 기다렸다가 값을 입력받는다.
    // Console.Write("입력 받은 키 숫자 코드 보여주기: ");
    // int key = Console.Read(); // 사용자에게서 입력받은 키의 숫자 코드를 보여준다.
    // Console.Write("입력받은 값을 보여주기: ");
    // ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자에게서 키를 입력받아서 가져온다. 대문자로 표기된다.
    //
    // Console.WriteLine("\n" + input);
    // Console.WriteLine(key + " / " + Convert.ToChar(key));
    // Console.WriteLine(keyInfo.Key);
    //
    // Console.Beep();
    // 삐 소리를 낸다.
  }

  public void n2_StringFormat() {
    // {0, 10:D}
    // 첫번째는 첨자, 두번째는 맞춤 숫자, 세번째는 서식 지정자이다.
    // 서식 지정자를 통해 숫자의 표기를 바꿀 수 있다.
    // 서식 지정자의 뒤에 숫자를 붙이면 자릿수가 늘어난다.
      
    Console.WriteLine("{0:D}", 255);
    Console.WriteLine("{0:D5}", 255);
    Console.WriteLine("0x{0:X8}", 255);
    // D는 숫자 중에서도 10진수를 의미한다.
      
    Console.WriteLine("{0:X}", 0xFF);
    // 16진수를 의미한다.
      
    Console.WriteLine("{0:N}", 123456789);
    Console.WriteLine("{0:N0}", 123456789);
    // 숫자에 콤마를 찍어서 보여준다. 뒤에 0을 붙이면 소수점이 사라진다.
      
    Console.WriteLine("{0:F}", 123.45);
    // 고정 소수점을 표현한다. 
      
    Console.WriteLine("{0:E}", 123.456789);
    Console.WriteLine();
    // 지수를 표현한다.
  }

  public void n3_DateTime() {
    DateTime dt = new DateTime(2021, 12, 29, 06, 30, 00);
    // 시간을 나타낼 수 있는 클래스이다.
      
    Console.WriteLine("{0}", dt);
    // 이렇게 하면 컴퓨터의 언어 상태에 따라 다르게 출력된다.
    // 이를 모든 환경에서 동일하게 출력하려면 지정자를 사용하면 된다.
      
    Console.WriteLine("{0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
    // 12시간
    Console.WriteLine("{0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);
    // 24시간
    Console.WriteLine("{0:yyyy MMdd}", dt);
    Console.WriteLine();
      
    // 문화권이 다를 경우에도 동일하게 보이게 하려면 아래와 같이 처리하면 된다.
    CultureInfo ciko = new CultureInfo("ko-KR");
    CultureInfo cien = new CultureInfo("en-US");
    // 국가 코드를 이용해 다른 문화권의 사람들을 배려할 수 있다.
      
    Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciko));
    Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", cien));
    Console.WriteLine();
  }
}