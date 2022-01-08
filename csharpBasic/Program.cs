using System;
using csharpBasic.Training;

namespace csharpBasic {
  public class Program {
    static void Main(string[] args) {
      // 스태틱은 인스턴스와 관련이 없다. 클래스 자체에 작용하는 메소드나 변수를 만들어낸다.
      // 스태틱이 아닌 메소드는 스태틱인 메소드에서 호출할 수 없다.
      // 스태틱이 있으면 프로그램 자체의 자원을 이용하는 클래스의 메소드나 변수가 된다.
      // 스태틱이 없는 메소드나 변수는 인스턴스를 통해서 생성해야만 한다.
      // 이는 다른 말로 하면 스태틱이 있으면 인스턴스를 만들 필요가 없다는 의미가 된다.
      
      Tr11();
    }

    // static void Tr() {
    //   Console.WriteLine("--------------------");
    //   Console.WriteLine("트레이닝 ?: ?");
    //   Console.WriteLine("--------------------");
    // }
    
    static void Tr11() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 11: 중복 클래스");
      Console.WriteLine("--------------------");

      Tr011NestedClass tr11 = new Tr011NestedClass();
      tr11.n1_NestedClass();
    }
    
    static void Tr10() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 10: 클래스");
      Console.WriteLine("--------------------");

      Tr010Class tr10 = new Tr010Class();
      tr10.n1_Copy();
      tr10.n2_This();
      tr10.n3_ExtendedClass();
      tr10.n4_HideMethod();
    }
    
    static void Tr09() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 9: 메소드 오버로딩");
      Console.WriteLine("--------------------");

      Tr009MethodOverloading tr09 = new Tr009MethodOverloading();
      tr09.n1_MethodOverloading();
    }
    
    static void Tr08() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 8: 메소드");
      Console.WriteLine("--------------------");

      Tr008Method tr08 = new Tr008Method();
      tr08.n1_CreateMethod();
      tr08.n2_OutKeyword();
      tr08.n3_ParamsMethod();
    }
    
    static void Tr07() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 7: 반복문");
      Console.WriteLine("--------------------");

      Tr007LoopStatement tr07 = new Tr007LoopStatement();
      tr07.n1_While();
      tr07.n2_For();
      tr07.n3_ForTimesTable();
      tr07.n4_Foreach();
    }
    
    static void Tr06() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 6: 조건문");
      Console.WriteLine("--------------------");

      Tr006IfStatement tr06 = new Tr006IfStatement();
      tr06.n1_IfStatement();
      tr06.n2_DataTypeIf();
      tr06.n3_SwitchExpression();
    }
    
    static void Tr05() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 5: 여러가지 연산자");
      Console.WriteLine("--------------------");

      Tr005DataCalc tr05 = new Tr005DataCalc();
      tr05.n1_NumberCalc();
      tr05.n2_RelationalOperator();
      tr05.n3_ConditionalOperator();
      tr05.n4_NullOperator();
      tr05.n5_BitOperator();
      tr05.n6_AssignmentOperator();
      tr05.n7_NullOperator();
    }
    
    static void Tr04() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 4: 포맷 스트링");
      Console.WriteLine("--------------------");

      Tr004StringFormat tr04 = new Tr004StringFormat();
      tr04.n1_ConsoleOutput();
      tr04.n2_StringFormat();
      tr04.n3_DateTime();
    }
    
    static void Tr03() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 3: 문자열 메소드");
      Console.WriteLine("--------------------");

      Tr003StringTypeMethod tr03 = new Tr003StringTypeMethod();
      tr03.n1_search();
      tr03.n2_modify();
      tr03.n3_split();
    }
    
    static void Tr02() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 2: 상수와 열거형");
      Console.WriteLine("--------------------");

      Tr002ConstAndEnum tr02 = new Tr002ConstAndEnum();
      tr02.n1_Const();
      tr02.n2_Enum();
    }

    static void Tr01() {
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 1: 데이터 타입");
      Console.WriteLine("--------------------");
      
      Tr001DataTypes tr01 = new Tr001DataTypes();
      tr01.n1_IntegralTypes();
      tr01.n2_CharAndStringTypes();
      tr01.n3_BoolTypes();
      tr01.n4_ObjectTypes();
    }
  }
}