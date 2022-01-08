namespace csharpBasic.Training;

public class Tr010Class {
  // 클래스는 객체 지향 프로그래밍에 있어서 반드시 필요한 개념이다. 클래스는 복합 데이터 형식이다.
  // 클래스는 변수인 멤버와 함수인 메소드를 지닌다. 클래스는 청사진이라고 할 수 있고 인스터스를 만들어 객체를 생성하는데에 쓰인다.
  // 클래스는 생성자가 있고 종료자가 있다. 종료자는 잘 쓰이지 않는다. 생성자는 알아둬야한다.
  // 생성자는 클래스의 이름과 똑같은 메소드이다. 사실 메소드와는 다르다.

  // 스태틱을 붙이면 클래스에 소속된다. 안붙이면 인스턴스에 소속된다.
  // 스태틱이 붙으면 인스턴스로 사용할 수 없다.
  // 스태틱 메소드는 정적 메소드라고 부르고 그 반대는 인스턴스 메소드라고 부른다.
  
  // this는 자기자신을 의미한다.
  
  // 접근 제한자, 접근 한정자는 클래스의 필드와 메소드를 숨기거나 공개하는 것을 조절하기 위해 존재한다.
  // 숨길 것은 숨기고 보일 것은 보이는 것이 좋다. C#에서 접근 한정자는 6개가 존재한다.
  
  // public은 클래스 내부와 외부에서 모두 접근 가능하다.
  // protected는 클래스 외부에서는 접근할 수 없다. 하지만 파생된 클래스에서는 접근이 가능하다.
  // private는 클래스 내부에서만 접근이 가능하다.
  // internal은 같은 어셈블리라면 퍼블릭으로, 아니라면 프라이빗으로 취급된다.
  // protected internal는 같은 어셈블리에서 프로텍티드로, 아니라면 프라이빗으로 취급된다.
  // private protected는 같은 어셈블리에 있는 클래스에서 상속받은 클래스 내부에서만 접근이 가능하다.
  
  // 한정자가 없으면 프라이빗으로 취급된다.
  
  // readonly 키워드는 읽기 전용 멤버를 만들 때에 사용된다. 생성자 함수에서 값의 할당이 가능하다.
  // 그 외의 다른 곳에서는 값을 수정할 수 없게 된다.
  // 읽기 전용 멤버는 상수와 변수 그 사이에 있는 셈이다.

  public void n1_Copy() {
    {
      MyClass source = new MyClass(1);
      source.MyField1 = 10;
      source.MyField2 = 20;

      MyClass target = source;
      target.MyField2 = 30;
    
      Console.WriteLine($"{source.MyField1} {source.MyField2}");
      Console.WriteLine($"{target.MyField1} {target.MyField2}");
      Console.WriteLine();
    }
    
    // 두가지의 인스턴스를 만들어 이렇게 하면 값이 다를 것 같지만
    // 클래스는 참조 형식이고 힙 메모리에 데이터를 저장한다.
    // 따라서 위의 결과는
    // 10 30
    // 10 30
    // 이다.
    // 이러한 구조는 얕은 복사라고 한다.
    
    {
      MyClass source = new MyClass(1);
      source.MyField1 = 10;
      source.MyField2 = 20;

      MyClass target = source.DeepCopy();
      target.MyField2 = 30;
      
      Console.WriteLine($"{source.MyField1} {source.MyField2}");
      Console.WriteLine($"{target.MyField1} {target.MyField2}");
      Console.WriteLine();
    }
    
    // 깊은 복사를 하면 두 인스턴스의 값을 다르게 적용할 수 있다.
  }

  public void n2_This() {
    ClassThis a = new ClassThis();
    a.PrintFields();
    Console.WriteLine();
    
    ClassThis b = new ClassThis(1);
    b.PrintFields();
    Console.WriteLine();
    
    ClassThis c = new ClassThis(10, 20);
    c.PrintFields();
    Console.WriteLine();
  }

  public void n3_ExtendedClass() {
    {
      ExtendedClass exClass = new ExtendedClass(1);
      exClass.MyField1 = 50;
      exClass.MyField2 = 25;
      Console.WriteLine($"{exClass.MyField1} + {exClass.MyField2} = {exClass.Add()}");
      Console.WriteLine();
    }

    {
      MyClass myClass = new MyClass(1);
      ExtendedClass exClass = new ExtendedClass(1);

      myClass.MyField1 = 54;
      exClass.MyField1 = 78;
      
      TwoClass.DisplayNumber(myClass);
      TwoClass.DisplayNumber(exClass);
      Console.WriteLine();
      
      Console.WriteLine($"{myClass is MyClass}");
      Console.WriteLine($"{exClass is MyClass}");
      Console.WriteLine();
      // is 연산자를 통해서 인스턴스가 해당 형식이 맞는지 알아낼 수 있다.
    }

    {
      MyClass myClass2 = new ExtendedClass(1);
      ExtendedClass? exClass = myClass2 as ExtendedClass;

      if (exClass != null) {
        exClass.MyField1 = 30;
        Console.WriteLine(exClass.MyField1);        
      }
      
      MyClass myClass1 = new ExtendedClass(1);
      ExtendedClass exClass2;
      
      if (myClass1 is ExtendedClass) {
        exClass2 = (ExtendedClass)myClass1;
        exClass2.MyField1 = 50;
        Console.WriteLine(exClass2.MyField1);
      }
      // as 연산자는 참조 형식에만 통한다.
      Console.WriteLine();
    }
  }

  public void n4_HideMethod() {
    Base baseClass = new Base();
    baseClass.Print();
    
    CopyBase copyClass = new CopyBase();
    copyClass.Print();
    
    Base baseClassCopy = new CopyBase();
    baseClassCopy.Print();
  }
}

public class MyClass {
  protected int Number;
  public MyClass(int number) {
    this.Number = number;
  }
  
  public int MyField1;
  public int MyField2;

  public MyClass DeepCopy() {
    MyClass newCopy = new MyClass(1);
    newCopy.MyField1 = MyField1;
    newCopy.MyField2 = MyField2;
    // 깊은 복사는 이런식으로 수행한다.

    return newCopy;
  }

  public virtual int Add() {
    Console.WriteLine("원본 메소드");
    return MyField1 + MyField2;
  }
  // 오버라이딩은 기반 클래스에 정의되어 있는 메소드를 재정의하는 것을 말한다.
  // 이 클래스는 기반 클래스이고, 아래의 파생 클래스에서 위 메소드를 재정의한다.
  // 버추얼이 오버라이딩을 가능하게 만드는 키워드이다.
}

public class ClassThis {
  int a, b, c;
  // 변수를 지정한다.

  // public ClassThis() {
  //   this.a = 5425;
  // }
  //
  // public ClassThis(int b) {
  //   this.a = 5425;
  //   this.b = b;
  // }
  //
  // public ClassThis(int b, int c) {
  //   this.a = 5425;
  //   this.b = b;
  //   this.c = c;
  // }
  // 생성자도 오버로딩이 가능하다. 문제는 중복되는 값이 있다. 위를 아래처럼 개선할 수 있다.
  
  public ClassThis() {
    this.a = 5425;
    Console.WriteLine("ClassThis()");
  }
  
  public ClassThis(int b): this() {
    this.b = b;
    Console.WriteLine($"ClassThis({b})");
  }
  
  public ClassThis(int b, int c): this(b) {
    this.c = c;
    Console.WriteLine($"ClassThis({b}, {c})");
  }
  // this() 는 생성자를 나타내는 것이다.
  // 이렇게 하면 중복값을 피할 수 있다.

  public void PrintFields() {
    Console.WriteLine($"a: {a}, b: {b}, c: {c}");
  }
}

public class ExtendedClass : MyClass {
  // 상속은 이렇게 처리한다.

  public ExtendedClass(int number): base(number) {
    
  }
  // base()는 부모 클래스의 생성자이다. 이렇게 동기화가 가능하다.

  public override int Add() {
    Console.WriteLine("오버라이딩된 메소드");
    return MyField1 + MyField2;
  }
  // 상속을 받으면 받는 클래스는 자식 클래스가 되고 주는 클래스는 부모 클래스가 된다.
  // 자식 클래스는 부모 클래스의 자원을 이용할 수 있다.
  // 부모 클래스는 기반 클래스라고도 하고, 자식 클래스는 파생 클래스라고도 한다.
  // sealed 한정자를 이용해 특정 클래스는 상속하지 못하게 할 수 있다.
  
  // 오버라이드를 붙이면 재정의가 가능해진다.
  // 프라이빗이 붙으면 오버라이딩이 불가능하다.
  
  // 오버라이딩이 가능한 메소드는 파생 클래스의 파생 클래스에서도 사용이 가능하기 떄문에
  // 이를 막기 위해서는 sealed를 붙이면 된다.
}

public class TwoClass {
  public static void DisplayNumber(MyClass myClass) {
    Console.WriteLine($"number: {myClass.MyField1}");
  }
  // 파생 클래스가 많아도 기반 클래스의 타입을 이용해 하나의 메소드로 코드를 줄이는 것도 가능하다.
}

public class Base {
  public void Print() {
    Console.WriteLine("기반 클래스 메소드");
  }
}

public class CopyBase : Base {
  public new void Print() {
    Console.WriteLine("파생 클래스 메소드");
  }
  // 클래스와 생성자가 다를 경우에는 기반 클래스의 메소드가 호출된다. 따라서 오버라이딩을 활용해야한다.
  // new를 붙이는 이유는 CLR에게 기반 클래스의 메소드를 숨기기 위함이다.
}

public partial class PartialClass {
  // 분할 클래스는 이렇게 사용한다.
}

public partial class PartialClass {
  // 같은 이름의 클래스를 여러개 만들어서 사용할 수 있다.
  // 컴파일러는 이게 여러개인지 아닌지 구분 안한다. 한개처럼 작용한다.
}